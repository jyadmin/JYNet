/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:00:31 PM
 * */
using System;
using System.IO;
using System.Net;

namespace DMS.Common
{
    public class FileHelper
    {
        public FileHelper()
        {
        }

        /// <summary>
        /// 将指定文件读成字节数组并返回
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static byte[] GetBytes(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            FileStream fs = file.OpenRead();
            byte[] result = new byte[fs.Length];
            fs.Read(result, 0, result.Length);
            return result;
        }

        public static void UpLoadFile(byte[] file, string url, NetworkCredential credential)
        {
            WebClient wc = new WebClient();
            wc.Credentials = credential;
            wc.UploadData(url, "PUT", file);
        }

        public static void DownLoadFile(string url, string fileName, string localFile, NetworkCredential credential)
        {
            WebClient wc = new WebClient();
            wc.Credentials = credential;
            wc.DownloadFile(url + fileName, localFile);
        }

        public static void WriteFile(string fileContent, string fileName)
        {
            System.IO.StreamWriter sw = new StreamWriter(fileName);
            sw.Write(fileContent);
            sw.Close();
        }

        public static void WriteFile(byte[] bytes, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

        }

        public static void DeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName);
        }
    }
}
