/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/13/2009 8:56:08 PM
 * */
using System;
using System.Diagnostics;
using System.Collections.Specialized;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DMS.Common
{
    public class XmlConfigurationManager
    {
        static NameValueCollection configFileNames;

        static XmlConfigurationManager()
        {
            configFileNames = new NameValueCollection();
        }

        public static void LoadConfig(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList nodes;

            nodes = doc.SelectNodes("/configSections/configSection");
            if (nodes != null)
            {
                foreach (XmlNode node in nodes)
                {
                    XmlAttribute IDAtt = node.Attributes["sectionID"];
                    if (IDAtt == null)
                        continue;
                    XmlAttribute fileNameAtt = node.Attributes["configFileName"];
                    if (fileNameAtt == null)
                        continue;
                    if (configFileNames[IDAtt.Value] != String.Empty)
                        configFileNames.Add(IDAtt.Value, fileNameAtt.Value);
                }
            }
        }

        public static void Save(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
            FileStream fs = new FileStream(GetFileName(obj.GetType()), FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer xmlSer = new XmlSerializer(obj.GetType());
            try
            {
                xmlSer.Serialize(fs, obj);
            }
            finally
            {
                fs.Close();
            }
        }

        public static void SaveConfigObject(object obj, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer xmlSer = new XmlSerializer(obj.GetType());
            try
            {
                xmlSer.Serialize(fs, obj);
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// get config object by the specified type 
        /// </summary>
        /// <exception cref="NotFoundConfigSectionException">thrown when the config file wasn't be found</exception>
        /// <exception cref="ConfigSectionErrorException">thrown when the config file can't be load</exception>
        /// <param name="t"></param>
        /// <returns></returns>
        public static object GetConfigObject(Type t)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(GetFileName(t), FileMode.Open, FileAccess.Read);
            }
            catch
            {
                throw new NotFoundConfigSectionException(t.FullName);
            }
            XmlSerializer xmlSer = new XmlSerializer(t);
            try
            {
                return xmlSer.Deserialize(fs);
            }
            catch (System.Exception err)
            {
                Debug.WriteLine(err.ToString());
                throw new ConfigSectionErrorException(t.FullName);
            }
            finally
            {
                fs.Close();
            }
        }

        private static string GetFileName(Type t)
        {
            string fileName = configFileNames[t.FullName];
            if (fileName == null)
                throw new NotFoundConfigSectionException(t.FullName);
            return Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, fileName);
        }
    }
}
