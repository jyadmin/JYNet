using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DMS.Common
{
    public class Reflector
    {
        /// <summary>
        /// 根据类型信息反射一个类型，并创建它的实例
        /// 如果找不到这个类型，会引发一个System.ArgumentOutOfRange异常
        /// </summary>
        /// <param name="typeFullName"></param>
        /// <returns></returns>
        public static object Reflect(string typeFullName)
        {
            return Reflect(typeFullName, null);
        }

        /// <summary>
        /// 根据类型信息反射一个类型，并根据参数创建它的实例
        /// 如果找不到这个类型，会引发一个System.ArgumentOutOfRange异常
        /// </summary>
        /// <param name="typeFullName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static object Reflect(string typeFullName, object[] args)
        {
            if (typeFullName == null || typeFullName == "")
                return null;
            Type type = Type.GetType(typeFullName);
            if (type == null)
                return null;
            return type.InvokeMember(null, BindingFlags.CreateInstance, null, null, args);
        }


        /// <summary>
        /// 反射得到一个对象的属性信息
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="pName"></param>
        /// <returns></returns>
        public static PropertyInfo GetPropertyInfo(object obj, String propertyName)
        {
            return obj.GetType().GetProperty(propertyName);
        }

        /// <summary>
        /// 反射得到一个属性名对应的值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="pName"></param>
        /// <returns></returns>
        public static object GetPropertyValue(object obj, String propertyName)
        {
            PropertyInfo pi = Reflector.GetPropertyInfo(obj, propertyName);
            if (null == pi)
                throw new ArgumentOutOfRangeException("propertyName", "没有此属性");
            return pi.GetValue(obj, null);
        }

        public static void SetPropertyValue(object obj, string propertyName, object v)
        {
            PropertyInfo pi = GetPropertyInfo(obj, propertyName);
            if (null == pi)
                throw new ArgumentOutOfRangeException("propertyName", "没有此属性");
            pi.SetValue(obj, v, null);
        }

        public static void SetPropertyValue(object obj, Type type, string propertyName, object v)
        {
            PropertyInfo pi = type.GetProperty(propertyName);
            if (null == pi)
                throw new ArgumentOutOfRangeException("propertyName", "没有此属性");
            pi.SetValue(obj, v, null);
        }

    }// END CLASS DEFINITION Reflector
}
