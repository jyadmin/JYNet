/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:01:28 PM
 * */
using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.Specialized;
using System.Text;

namespace DMS.Common
{
    /// <summary>
    /// Xml配置器
    /// </summary>
    public class XmlConfiger
    {
        #region sectionInfo

        public const string SECTIONS_NODE_PATH = "/configSections/section";
        public const string SECTION_NAME = "name";
        public const string SECTION_FILEPATH = "fileName";

        #endregion

        private Hashtable m_cacheDocuments;
        private XmlDocument m_configDocument;
        private bool m_enableAutoRefreshConfig;
        string m_mainFileName;

        #region static Instatce

        private static XmlConfiger _me;
        public static XmlConfiger Instance
        {
            get
            {
                if (_me == null)
                {
                    lock (typeof(XmlConfiger))
                    {
                        _me = new XmlConfiger();
                    }
                }
                return _me;
            }
        }

        #endregion

        /// <summary>
        /// 加载主配置文件
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadMainConfigFile(string fileName)
        {
            m_mainFileName = fileName;
            m_configDocument.Load(fileName);
        }

        /// <summary>
        /// 清空缓存
        /// </summary>
        public void ClearCache()
        {
            m_configDocument = new XmlDocument();
            m_cacheDocuments.Clear();
            m_enableAutoRefreshConfig = true;
        }

        /// <summary>
        /// 加载一个配置项
        /// </summary>
        /// <param name="sectionName"></param>
        public void LoadSection(string sectionName)
        {
            XmlDocument doc = GetSectionXmlDocumentWithOutCache(sectionName);
            this.m_cacheDocuments[sectionName] = doc;
        }

        public void SaveSection(string sectionName)
        {
            XmlDocument doc = GetSectionXmlDocument(sectionName);
            doc.Save(GetSectionFileName(sectionName));
        }

        public XmlDocument GetSectionXmlDocument(string sectionName)
        {
            //先查看对应的XmlDocument是否缓存，若已经缓存，直接返回缓存中的document,
            //若没有缓存，从文件加载出来，再放入缓存，并进行文件更改监视，然后返回
            XmlDocument doc = (XmlDocument)this.m_cacheDocuments[sectionName];
            if (doc == null)
            {
                doc = GetSectionXmlDocumentWithOutCache(sectionName);

                FileWatcher.Instance.AddItem(sectionName, GetSectionFileName(sectionName), new FileChangedEventHandler(this.ConfigFileChangedHandler));
                this.m_cacheDocuments.Add(sectionName, doc);
            }
            return doc;
        }

        public XmlDocument GetSectionXmlDocumentWithOutCache(string sectionName)
        {
            string fileName = GetSectionFileName(sectionName);
            if (fileName == null || fileName == "")
                throw new BePressedForConfigException(sectionName, "没有找到" + sectionName + "配置项!");
            try
            {
                XmlDocument doc = GetXmlDocument(fileName);
                return doc;
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new XmlConfigDocumentException(sectionName, "缺少配置文件:" + fileName);
            }
            catch (System.IO.IOException)
            {
                throw new XmlConfigDocumentException(sectionName, "配置文件:" + fileName + "无法访问");
            }
            catch (XmlException)
            {
                throw new XmlConfigDocumentException(sectionName, "配置文件有错误!");
            }
            catch (System.Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.ToString());
                throw err;
            }
        }

        /// <summary>
        /// 返回一个配置项目的配置文件名
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public string GetSectionFileName(string sectionName)
        {
            XmlNode node = m_configDocument.SelectSingleNode("/configSections/section[@name='" + sectionName + "']");
            if (node == null)
                return null;
            XmlAttribute att = node.Attributes["fileName"];
            if (att == null)
                return null;
            return Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, att.Value);
        }

        #region constructors

        private XmlConfiger()
        {
            m_configDocument = new XmlDocument();
            m_cacheDocuments = new Hashtable();
            m_enableAutoRefreshConfig = true;
        }

        #endregion

        #region public static methods

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public static XmlDocument GetXmlDocument(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(GetFullPath(fileName));
            return doc;
        }

        private static string GetFullPath(string path)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase, path);
        }

        #region xPath
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="nodePath"></param>
        /// <param name="attFilters"></param>
        /// <returns></returns>
        public static string BuildXPath(string sectionName, string nodePath, NameValueCollection attFilters)
        {
            return "/" + sectionName + "/" + nodePath + BuildAttributeFilterXPath(attFilters);
        }
        /// <summary>
        /// 根据一个条件集合生成XPath条件字符串
        /// </summary>
        /// <param name="attFilters"></param>
        /// <returns></returns>
        public static string BuildAttributeFilterXPath(NameValueCollection attFilters)
        {
            if (attFilters == null)
                return "";
            StringBuilder sb = new StringBuilder();
            sb.Append("[@");
            foreach (string key in attFilters.Keys)
            {
                sb.Append(key + "='" + attFilters[key] + "'] and ");
            }
            if (sb.Length != 0)
                sb.Remove(sb.Length - 4, 4);
            return sb.ToString();
        }
        #endregion

        #endregion

        #region xml operate

        public void AddElement(string sectionName, string parentNodePath, string elementName, NameValueCollection atts)
        {
            XmlDocument doc = GetSectionXmlDocument(sectionName);
            XmlNode node = doc.CreateNode(XmlNodeType.Element, elementName, doc.NamespaceURI);
            foreach (string key in atts.Keys)
            {
                XmlNode att = doc.CreateNode(XmlNodeType.Attribute, key, doc.NamespaceURI);
                att.Value = atts[key];
                node.Attributes.SetNamedItem(att);
            }
            XmlNode parentNode = doc.SelectSingleNode(BuildXPath(sectionName, parentNodePath, null));
            parentNode.AppendChild(node);
            doc.Save(GetSectionFileName(sectionName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="XPathString"></param>
        public void RemoveElement(string sectionName, string XPathString)
        {
            XmlDocument doc = GetSectionXmlDocument(sectionName);
            XmlNode node = doc.SelectSingleNode(XPathString);
            node.ParentNode.RemoveChild(node);
            doc.Save(GetSectionFileName(sectionName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <param name="nodePath"></param>
        /// <param name="attFilter"></param>
        /// <returns></returns>
        public bool ExsitsNode(string sectionName, string nodePath, NameValueCollection attFilter)
        {
            XmlDocument doc = GetSectionXmlDocument(sectionName);
            return !(doc.SelectSingleNode(BuildXPath(sectionName, nodePath, attFilter)) == null);
        }

        #endregion

        #region nameValueCollection

        public NameValueCollection GetNameValueConfigs(string sectionName, string nodePath, string keyAttName, string valueAttName, NameValueCollection attFilter)
        {
            NameValueCollection result = new NameValueCollection();
            XmlDocument doc = GetSectionXmlDocumentWithOutCache(sectionName);
            XmlNodeList nodes = doc.SelectNodes(BuildXPath(sectionName, nodePath, attFilter));
            foreach (XmlNode node in nodes)
            {
                XmlAttribute keyAtt = node.Attributes[keyAttName];
                if (keyAtt == null)
                    continue;
                XmlAttribute valueAtt = node.Attributes[valueAttName];
                if (valueAtt == null)
                    continue;
                if (result[keyAtt.Value] == null)
                    result.Add(keyAtt.Value, valueAtt.Value);
                else
                    result[keyAtt.Value] = valueAtt.Value;
            }
            return result;
        }

        public NameValueCollection GetNameValueConfigs(string sectionName, string nodePath, string keyAtt, string valueAtt)
        {
            return GetNameValueConfigs(sectionName, nodePath, keyAtt, valueAtt, null);
        }

        #endregion

        #region get/set values

        public string GetValue(string sectionName, string nodePath, string attributeName)
        {
            return GetValue(sectionName, nodePath, attributeName, null);
        }

        public string GetValue(string sectionName, string nodePath, string attName, NameValueCollection attFilter)
        {
            return GetAttribute(sectionName, nodePath, attName, attFilter).Value;
        }

        public void SetValue(string sectionName, string nodePath, string attributeName, string v)
        {
            SetValue(sectionName, nodePath, attributeName, v, null);
        }

        public void SetValue(string sectionName, string nodePath, string attName, string v, NameValueCollection attFilter)
        {
            GetAttribute(sectionName, nodePath, attName, attFilter).Value = v;
            SaveSection(sectionName);
        }

        private XmlAttribute GetAttribute(string sectionName, string nodePath, string attName, NameValueCollection attFilter)
        {
            XmlDocument doc = GetSectionXmlDocument(sectionName);
            XmlNode node = doc.SelectSingleNode(BuildXPath(sectionName, nodePath, attFilter));
            if (node == null)
                throw new XmlConfigDocumentException(sectionName, "没有节点:" + nodePath);
            XmlAttribute att = GetAttribute(node, attName);
            if (att == null)
                throw new XmlConfigDocumentException(sectionName, "没有属性:" + attName);
            return att;
        }

        /// <summary>
        /// 返回xmlnode的指定属性，如果没有此属性，则返回null
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attName"></param>
        /// <returns></returns>
        public static XmlAttribute GetAttribute(XmlNode node, string attName)
        {
            if (attName == "" || attName == null)
                attName = "value";
            XmlAttribute att = node.Attributes[attName];
            return att;
        }

        #endregion

        #region properties

        /// <summary>
        /// 获取或设置配置文件改变时是否立即刷新相关缓存
        /// </summary>
        public bool EnableAutoRefreshConfig
        {
            get { return this.m_enableAutoRefreshConfig; }
            set { this.m_enableAutoRefreshConfig = value; }
        }

        #endregion

        #region event handlers

        /// <summary>
        /// 配置文件改变时的处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigFileChangedHandler(object sender, FileChangedEventArgs e)
        {
            if (m_enableAutoRefreshConfig)
            {
                LoadSection((string)e.Key);
            }
        }

        private void MainFileChangedHandler(object sender, System.IO.FileSystemEventArgs e)
        {
            this.LoadMainConfigFile(this.m_mainFileName);
            this.OnMainConfigFileChanged(EventArgs.Empty);
        }
        #endregion

        #region events
        public delegate void MainConfigFileChangedHandler(object sender, EventArgs e);

        public event MainConfigFileChangedHandler MainConfigFileChanged;

        public void OnMainConfigFileChanged(EventArgs e)
        {
            if (MainConfigFileChanged != null)
                MainConfigFileChanged(this, e);
        }
        #endregion
    }
}
