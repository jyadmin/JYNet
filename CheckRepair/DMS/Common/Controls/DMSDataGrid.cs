using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DMS.Common.Controls
{
    /// <summary>
    /// a custom-build DataGrid
    /// </summary>
    public class QMDataGrid : DataGrid
    {
        static QMDataGrid()
        {

        }

        public static DataGridTableStyle GenerateCommonDataGridTableStyle()
        {
            DataGridTableStyle commonStyle = new DataGridTableStyle();

            return commonStyle;
        }

        public QMDataGrid()
        {
            this.MouseUp += new MouseEventHandler(QMDataGrid_MouseUp);

            #region setting styles

            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right))); 
            this.AlternatingBackColor = System.Drawing.Color.White;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataMember = "";
            this.FlatMode = true;
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.GridLineColor = System.Drawing.Color.Wheat;
            this.HeaderBackColor = System.Drawing.Color.CadetBlue;
            this.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.HeaderForeColor = System.Drawing.Color.White;
            this.CaptionVisible = false;
            this.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "dataGrid";
            this.ParentRowsBackColor = System.Drawing.Color.Ivory;
            this.ParentRowsForeColor = System.Drawing.Color.Black;
            this.SelectionBackColor = System.Drawing.Color.Wheat;
            this.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.RowHeadersVisible = false;
            this.Size = new System.Drawing.Size(741, 454);
            this.TabIndex = 0;

            this.FlatMode = false;

            #endregion
        }

        private void QMDataGrid_MouseUp(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.DataGrid.HitTestInfo hti = this.HitTest(e.X, e.Y);
            if (hti.Type == DataGrid.HitTestType.Cell)
            {
                this.Select(hti.Row);
            }
        }
    }
}
