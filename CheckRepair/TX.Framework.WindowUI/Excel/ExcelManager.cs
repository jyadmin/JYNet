﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Text;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Collections;
using System.Reflection;

namespace System.Office.Excel
{
    /// <summary>
    /// 
    /// </summary>
    public class ExcelManager : IDisposable
    {
        private Microsoft.Office.Interop.Excel.Application _ApplicationClass;
        private _Worksheet _Worksheet;
        private CultureInfo _OriginalCulture;
        private string _OpenFileName;
        private bool _Disposed;

        public ExcelManager()
        {
            _OriginalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            _ApplicationClass = new Microsoft.Office.Interop.Excel.Application();
            _ApplicationClass.DisplayAlerts = false;
        }

        #region Workbooks 功能

        /// <summary>
        /// 创建指定文件名的EXCEL文件
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void Create(string fileName)
        {
            try
            {
                Close();
                _ApplicationClass.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                _ApplicationClass.ActiveWorkbook.SaveAs(fileName,
                                          XlFileFormat.xlWorkbookNormal,
                                          System.Type.Missing,
                                          System.Type.Missing,
                                          System.Type.Missing,
                                          System.Type.Missing,
                                          XlSaveAsAccessMode.xlNoChange,
                                          System.Type.Missing,
                                          System.Type.Missing,
                                          System.Type.Missing,
                                          System.Type.Missing,
                                          System.Type.Missing);
                _OpenFileName = fileName;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Error Creating File '{0}'", fileName), err);
            }
        }

        /// <summary>
        /// 打开指定文件名
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void Open(string fileName)
        {
            try
            {
                Close();
                _ApplicationClass.Workbooks.Open(fileName,
                                    false,
                                    false,
                                    System.Type.Missing,
                                    System.Type.Missing,
                                    System.Type.Missing,
                                    System.Type.Missing,
                                    System.Type.Missing,
                                    System.Type.Missing,
                                    false,
                                    System.Type.Missing,
                                    System.Type.Missing,
                                    false,
                                    System.Type.Missing,
                                    System.Type.Missing);
                _OpenFileName = fileName;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Error Opening File '{0}'", fileName), err);
            }
        }

        /// <summary>
        /// 关闭当前EXCEL文件
        /// </summary>
        public void Close()
        {
            try
            {
                _ApplicationClass.Workbooks.Close();
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Error Closing File '{0}'", _OpenFileName), err);
            }
        }


        /// <summary>
        /// 保存EXCEL
        /// </summary>
        public void Save()
        {
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");
            _ApplicationClass.ActiveWorkbook.Save();
        }

        /// <summary>
        /// 另存为EXCEL
        /// </summary>
        /// <param name="newFileName">New name of file</param>
        public void SaveAs(string newFileName)
        {
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                _ApplicationClass.ActiveWorkbook.SaveAs(newFileName,
                                        XlFileFormat.xlWorkbookNormal,
                                        System.Type.Missing,
                                        System.Type.Missing,
                                        System.Type.Missing,
                                        System.Type.Missing,
                                        XlSaveAsAccessMode.xlNoChange,
                                        System.Type.Missing,
                                        System.Type.Missing,
                                        System.Type.Missing,
                                        System.Type.Missing,
                                        System.Type.Missing);
                _OpenFileName = newFileName;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Can not save file as '{0}'", newFileName), err);
            }
        }

        #endregion

        #region Worksheets 功能

        public void ActivateSheet(string sheetName)
        {
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                foreach (_Worksheet wsheet in _ApplicationClass.ActiveWorkbook.Sheets)
                {
                    if (String.Compare(wsheet.Name, sheetName, true) == 0)
                    {
                        wsheet.Activate();
                        _Worksheet = wsheet;
                        return;
                    }
                }
                throw new ExcelException(String.Format("Can not find sheet '{0}'", sheetName));
            }
            catch (Exception e)
            {
                throw new ExcelException(String.Format("Can not activate sheet '{0}'", sheetName), e);
            }
        }

        public void RenameSheet(string oldName, string newName)
        {
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                // "_Worksheet" is used instead of "Worksheet" to resolve ambiguity 
                // between _Worksheet.Activate() method and DocEvents_Event.Activate event.
                foreach (_Worksheet wsheet in _ApplicationClass.Sheets)
                {
                    if (String.Compare(wsheet.Name, oldName, true) == 0)
                    {
                        wsheet.Name = newName;
                        return;
                    }
                }
                throw new ExcelException(String.Format("Can not find sheet '{0}'", oldName));
            }
            catch (Exception err)
            {
                throw new ExcelException(
                    String.Format("Can not rename sheet '{0}' to '{1}'", oldName, newName), err);
            }
        }

        /// <summary>
        /// Renames current sheet.
        /// </summary>
        /// <param name="newName">New name of current sheet</param>
        public void RenameCurrentSheet(string newName)
        {
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                (_ApplicationClass.ActiveSheet as _Worksheet).Name = newName;
            }
            catch (Exception err)
            {
                throw new ExcelException(
                    "Can not rename current sheet", err);
            }
        }

        #endregion

        public void CopyRows(int startRow, int endRow, int targetRow)
        {
            try
            {
                Range range = this._Worksheet.Rows[targetRow + ":" + targetRow, Missing.Value] as Range;
                for (int i = 0; i < ((endRow - startRow) + 1); i++)
                {
                    range.Insert(XlDirection.xlDown, Missing.Value);
                }
                range = this._Worksheet.Rows[startRow + ":" + endRow, Missing.Value] as Range;
                range.Copy(this._Worksheet.get_Range("A" + targetRow, Missing.Value));
            }
            catch (Exception ex)
            {
                throw new ExcelException(String.Format("Copy Rows Error: 开始行: {0}, 结束行: {1},", startRow, endRow), ex);
            }
        }

        #region 单元格与范围值 相关功能

        public object GetValue(string cellAddress, Category category)
        {
            if (String.IsNullOrEmpty(cellAddress))
                throw new ArgumentNullException("cellAddress");

            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                Range range = (_ApplicationClass.ActiveSheet as _Worksheet).get_Range(cellAddress, System.Type.Missing);
                if (category == Category.Numeric)
                    return range.Value2;
                else
                    return range.Text;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Can not access values at address '{0}'", cellAddress), err);
            }
        }

        public double? GetNumericValue(string cellAddress)
        {
            return (double?)GetValue(cellAddress, Category.Numeric);
        }

        public object GetFormattedValue(string cellAddress)
        {
            return GetValue(cellAddress, Category.Formatted);
        }

        private bool IsWasteCellInMergeArea(Range range)
        {
            // If it is not a part of merge area, it can not be a waste!
            if (!((bool)range.MergeCells))
                return false;
            Range firstCellInMergeArea = range.MergeArea.Cells[1, 1] as Range;
            // If it is not first cell of merge area, it is a waste cell
            return !(range.Column == firstCellInMergeArea.Column && range.Row == firstCellInMergeArea.Row);
        }

        public ArrayList GetRangeValues(string startCellAddress, string endCellAddress, Category category)
        {
            if (String.IsNullOrEmpty(startCellAddress))
                throw new ArgumentNullException("startCellAddress");
            if (String.IsNullOrEmpty(endCellAddress))
                throw new ArgumentNullException("endCellAddress");
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                Range range = _ApplicationClass.get_Range(startCellAddress, endCellAddress);

                ArrayList arr = new ArrayList();
                foreach (Range r in range)
                {
                    if (IsWasteCellInMergeArea(r))
                        continue;
                    if (category == Category.Formatted)
                        arr.Add(r.Text);
                    else
                        arr.Add((double?)r.Value2);
                }
                return arr;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Can not get values of range '{0}:{1}'", startCellAddress, endCellAddress), err);
            }
        }

        public ArrayList GetRangeFormattedValues(string startCellAddress, string endCellAddress)
        {
            return GetRangeValues(startCellAddress, endCellAddress, Category.Formatted);
        }

        public ArrayList GetRangeNumericValues(string startCellAddress, string endCellAddress)
        {
            return GetRangeValues(startCellAddress, endCellAddress, Category.Numeric);
        }

        /// <summary>
        /// Sets a cell content.
        /// </summary>
        /// <param name="cellAddress">Cell's address (for example "A2")</param>
        /// <param name="value">Any desired value</param>
        public void SetValue(string cellAddress, object value)
        {
            Guard.ArgumentNotNullOrEmptyString(cellAddress, "cellAddress");
          
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                _ApplicationClass.get_Range(cellAddress, System.Type.Missing).Value2 = value;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Can not set value of cell '{0}'", cellAddress), err);
            }
        }

        public void SetRangeValue(string startCellAddress, string endCellAddress, object value)
        {
            Guard.ArgumentNotNullOrEmptyString(startCellAddress, "startCellAddress");
            Guard.ArgumentNotNullOrEmptyString(endCellAddress, "endCellAddress");

            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                _ApplicationClass.get_Range(startCellAddress, endCellAddress).Value2 = value;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Can not set values of range '{0}:{1}'", startCellAddress, endCellAddress), err);
            }
        }

        /// <summary>
        /// Sets an array of values in a Range.
        /// </summary>
        /// <param name="startCellAddress">First cell's address (for example "A1")</param>
        /// <param name="endCellAddress">Last cell's address (for example "A1")</param>
        /// <param name="values">Any array of desired values</param>
        /// <remarks>
        /// <para>Array and Range can be of diffrent sizes. If array is smaller, extra cells remain intact. 
        /// If range is smaller, extra values of array will not be used.</para>
        /// <para>Merge areas will also be considered. The whole merge area assumes as one cell.</para>
        /// </remarks>
        public void SetRangeValues(string startCellAddress, string endCellAddress, IList values)
        {
            Guard.ArgumentNotNull(values, "values");
            Guard.ArgumentNotNullOrEmptyString(startCellAddress, "startCellAddress");
            Guard.ArgumentNotNullOrEmptyString(endCellAddress, "endCellAddress");

            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                int index = 0;
                Range range = _ApplicationClass.get_Range(startCellAddress, endCellAddress);
                foreach (Range childRange in range)
                {
                    if (index >= values.Count) return;
                    if (IsWasteCellInMergeArea(childRange)) continue;
                    childRange.Value2 = values[index];
                    index++;
                }
            }
            catch (Exception e)
            {
                throw new ExcelException(String.Format("Can not set values of range '{0}:{1}'", startCellAddress, endCellAddress), e);
            }
        }

        public void SetRowHeight(string cellAddress, int height)
        {
            if (!AnyFileOpen)
                throw new ExcelException("No file is Open");

            try
            {
                _ApplicationClass.get_Range(cellAddress).RowHeight = height;
            }
            catch (Exception err)
            {
                throw new ExcelException(String.Format("Can not set RowHeight of cell '{0}'", cellAddress), err);
            }
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_Disposed)
            {
                if (disposing)
                {
                    if (_ApplicationClass != null)
                    {
                        Close();
                        _ApplicationClass.Quit();
                        _ApplicationClass = null;
                        Thread.CurrentThread.CurrentCulture = _OriginalCulture;
                    }
                }
            }
            _Disposed = true;
        }

        public string OpenFileName
        {
            get { return _OpenFileName; }
        }

        public bool AnyFileOpen
        {
            get { return !String.IsNullOrEmpty(_OpenFileName); }
        }
    }
}
