/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/12/2009 11:20:52 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.UI.Common
{
    /// <summary>
    /// 命令按钮的类型
    /// </summary>
    public enum CommandType
    {
        /// <summary>
        /// 新建
        /// </summary>
        New,
        /// <summary>
        /// 查看
        /// </summary>
        View,
        /// <summary>
        /// 修改
        /// </summary>
        Modify,
        /// <summary>
        /// 删除
        /// </summary>
        Delete,
        /// <summary>
        /// 审核
        /// </summary>
        Audit,
        /// <summary>
        /// 作废
        /// </summary>
        Abolish,
        /// <summary>
        /// 打印
        /// </summary>
        Print,
        /// <summary>
        /// 预览
        /// </summary>
        PrintPreview,
        /// <summary>
        /// 其它(没有图标)
        /// </summary>
        Other,
        /// <summary>
        /// 保存
        /// </summary>
        Save,
        /// <summary>
        /// 统计
        /// </summary>
        Stat,
        /// <summary>
        /// 计算
        /// </summary>
        Computer,
        /// <summary>
        /// 帮助
        /// </summary>
        Help,
        /// <summary>
        /// 提交
        /// </summary>
        Submit,
        /// <summary>
        /// 签收
        /// </summary>
        Signin,
        /// <summary>
        /// 弹出
        /// </summary>
        Popup,
        /// <summary>
        /// 下发
        /// </summary>
        Descend,
        /// <summary>
        /// 反审核
        /// </summary>
        RAudit,
        /// <summary>
        /// 关闭
        /// </summary>
        Close,
        /// <summary>
        /// 填写
        /// </summary>
        Write,
        /// <summary>
        /// 更新
        /// </summary>
        Update,
        /// <summary>
        /// 取消
        /// </summary>
        Cancel,
        /// <summary>
        /// 启用
        /// </summary>
        Start,
        /// <summary>
        /// 停用
        /// </summary>
        Stop,
        /// <summary>
        /// 下载
        /// </summary>
        Download,
        /// <summary>
        /// 导出Excel
        /// </summary>
        ExportExcel,
        /// <summary>
        /// 导出Word
        /// </summary>
        ExportWord,
        /// <summary>
        /// 导入数据
        /// </summary>
        ImportData,
        /// <summary>
        /// 清除数据
        /// </summary>
        ClearData,
        /// <summary>
        /// 导出模板
        /// </summary>
        ExportTemplate
    }
}