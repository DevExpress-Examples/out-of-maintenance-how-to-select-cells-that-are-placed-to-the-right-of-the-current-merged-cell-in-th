using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView1.FocusedColumnChanged += gridView1_FocusedColumnChanged;
        }

        private void gridView1_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e) {
            RefreshRow(gridView1.FocusedRowHandle, e.PrevFocusedColumn);
            RefreshRow(gridView1.FocusedRowHandle, e.FocusedColumn);
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            RefreshRow(e.PrevFocusedRowHandle, gridView1.FocusedColumn);
            RefreshRow(e.FocusedRowHandle, gridView1.FocusedColumn);
        }

        private void RefreshRow(int rowHandle, GridColumn column) {
            if(!gridView1.IsValidRowHandle(rowHandle) || column == null) return;
            List<GridColumn> columns = gridView1.VisibleColumns.OfType<GridColumn>().Where(x => x.VisibleIndex > column.VisibleIndex).ToList();
            GridCellInfoCollection cells = GetMergeCells(rowHandle, column);
            if(cells != null)
                foreach(GridCellInfo cell in cells)
                    foreach(GridColumn col in columns)
                        gridView1.RefreshRowCell(cell.RowHandle, col);
        }

        private GridCellInfoCollection GetMergeCells(int rowHandle, GridColumn column) {
            GridViewInfo viewInfo = gridView1.GetViewInfo() as GridViewInfo;
            GridDataRowInfo rowInfo = viewInfo.GetGridRowInfo(rowHandle) as GridDataRowInfo;
            if(rowInfo != null) {
                GridCellInfo cellInfo = rowInfo.Cells[column];
                if(cellInfo != null && cellInfo.IsMerged)
                    return cellInfo.MergedCell.MergedCells;
            }
            return null;
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e) {
            GridCellInfoCollection cells = GetMergeCells(gridView1.FocusedRowHandle, gridView1.FocusedColumn);
            if(cells != null)
                foreach(GridCellInfo cell in cells)
                    if(cell.RowHandle == e.RowHandle && e.Column.VisibleIndex > gridView1.FocusedColumn.VisibleIndex)
                        e.Appearance.BackColor = Color.Orange;
        }

        private void XtraForm1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
        }
    }
}
