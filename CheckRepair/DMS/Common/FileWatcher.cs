/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:03:17 PM
 * */
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace DMS.Common
{
    /// <summary>
    /// 文件监视器
    /// </summary>
    public class FileWatcher
    {
        /// <summary>
        /// FileSystemWatcher / 相关文件改变处理委托　
        /// </summary>
        private Hashtable m_watchers;
        /// <summary>
        /// 监视的文件全名 / 标识键
        /// </summary>
        private Hashtable m_keys;

        private static FileWatcher instance;
        public static FileWatcher Instance
        {
            get
            {
                if (instance == null)
                    instance = new FileWatcher();
                return instance;
            }
        }

        protected FileWatcher()
        {
            m_watchers = new Hashtable();
            m_keys = new Hashtable();
        }

        /// <summary>
        /// 添加一个监视项
        /// </summary>
        /// <param name="key">标识键</param>
        /// <param name="fileName">文件名</param>
        /// <param name="changedHandler">文件改变处理函数</param>
        public void AddItem(object key, string fileName, FileChangedEventHandler changedHandler)
        {
            FileSystemWatcher fsw = new FileSystemWatcher(Path.GetDirectoryName(fileName), Path.GetFileName(fileName));
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.NotifyFilter = NotifyFilters.LastAccess;
            fsw.EnableRaisingEvents = true;
            m_watchers.Add(fsw, changedHandler);
            m_keys.Add(Path.GetFullPath(fileName).ToLower(), key);
        }

        /// <summary>
        ///　当一个监视项改变时，调用对应处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            Debug.WriteLine(e.FullPath + " file changed");
            FileChangedEventHandler handler = (FileChangedEventHandler)this.m_watchers[sender];
            string fullPath = Path.GetFullPath(e.FullPath);
            FileChangedEventArgs args = new FileChangedEventArgs(fullPath, m_keys[fullPath.ToLower()]);
            if (handler != null)
                try
                {
                    if (handler.Method.IsStatic)
                        handler.Method.Invoke(null, new object[] { this, args });
                    else
                        handler.Method.Invoke(handler.Target, new object[] { this, args });
                }
                catch (System.Reflection.TargetInvocationException tiEx)
                {
                    Debug.WriteLine(tiEx.InnerException.ToString());
                    throw tiEx;
                }
            else
                this.m_watchers.Remove(sender);
        }
    }

    public delegate void FileChangedEventHandler(object sender, FileChangedEventArgs e);

    public class FileChangedEventArgs : EventArgs
    {
        private string m_fileName;
        private object m_key;

        public FileChangedEventArgs(string fileName, object key)
        {
            m_fileName = fileName;
            m_key = key;
        }

        /// <summary>
        /// 文件全名
        /// </summary>
        public string FileName
        {
            get { return m_fileName; }
            set { m_fileName = value; }
        }

        /// <summary>
        /// 标识键
        /// </summary>
        public object Key
        {
            get { return m_key; }
            set { m_key = value; }
        }
    }
}
