/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/17/2009 7:55:42 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DMS.Common
{
    public class Loger
    {
        static Loger instance;

        public static Loger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(Loger))
                    {
                        instance = new Loger();
                    }
                }
                return instance;
            }
        }

        public event LogWritingEventHandler LogWriting;

        protected void OnLogWriting(LogWritingEventArgs e)
        {
            if (LogWriting != null)
            {
                LogWriting(this, e);
            }
        }

        /// <summary>
        /// 记录一个错误日志
        /// </summary>
        /// <param name="message"></param>
        public void WriteErrorLog(string message)
        {
            DateTime dt = DateTime.Now;
            OnLogWriting(new LogWritingEventArgs(message, LogType.Error, dt));
            string fileName = Path.Combine(Application.StartupPath, "log.txt");
            
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(message);
            sw.WriteLine(string.Empty);
            sw.Close();
        }
    }

    public delegate void LogWritingEventHandler(object sender, LogWritingEventArgs e);

    public class LogWritingEventArgs
    {
        private string m_log;
        private LogType m_type;
        private DateTime m_logTime;

        public LogWritingEventArgs(string log, LogType type, DateTime logTime)
        {
            m_log = log;
            m_type = type;
            m_logTime = logTime;
        }

        public string Log
        {
            get { return m_log; }
        }

        public LogType Type
        {
            get { return m_type; }
        }

        public DateTime LogTime
        {
            get { return m_logTime; }
        }
    }

    public enum LogType
    {
        Error,
        Message
    }
}
