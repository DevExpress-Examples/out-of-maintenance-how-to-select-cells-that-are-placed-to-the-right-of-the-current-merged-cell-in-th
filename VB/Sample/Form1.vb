Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Sample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
			AddHandler gridView1.FocusedRowChanged, AddressOf gridView1_FocusedRowChanged
			AddHandler gridView1.FocusedColumnChanged, AddressOf gridView1_FocusedColumnChanged
		End Sub

		Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As FocusedColumnChangedEventArgs)
			RefreshRow(gridView1.FocusedRowHandle, e.PrevFocusedColumn)
			RefreshRow(gridView1.FocusedRowHandle, e.FocusedColumn)
		End Sub

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
			RefreshRow(e.PrevFocusedRowHandle, gridView1.FocusedColumn)
			RefreshRow(e.FocusedRowHandle, gridView1.FocusedColumn)
		End Sub

		Private Sub RefreshRow(ByVal rowHandle As Integer, ByVal column As GridColumn)
			If (Not gridView1.IsValidRowHandle(rowHandle)) OrElse column Is Nothing Then
				Return
			End If
			Dim columns As List(Of GridColumn) = gridView1.VisibleColumns.OfType(Of GridColumn)().Where(Function(x) x.VisibleIndex > column.VisibleIndex).ToList()
			Dim cells As GridCellInfoCollection = GetMergeCells(rowHandle, column)
			If cells IsNot Nothing Then
				For Each cell As GridCellInfo In cells
					For Each col As GridColumn In columns
						gridView1.RefreshRowCell(cell.RowHandle, col)
					Next col
				Next cell
			End If
		End Sub

		Private Function GetMergeCells(ByVal rowHandle As Integer, ByVal column As GridColumn) As GridCellInfoCollection
			Dim viewInfo As GridViewInfo = TryCast(gridView1.GetViewInfo(), GridViewInfo)
			Dim rowInfo As GridDataRowInfo = TryCast(viewInfo.GetGridRowInfo(rowHandle), GridDataRowInfo)
			If rowInfo IsNot Nothing Then
				Dim cellInfo As GridCellInfo = rowInfo.Cells(column)
				If cellInfo IsNot Nothing AndAlso cellInfo.IsMerged Then
					Return cellInfo.MergedCell.MergedCells
				End If
			End If
			Return Nothing
		End Function

		Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridView1.RowCellStyle
			Dim cells As GridCellInfoCollection = GetMergeCells(gridView1.FocusedRowHandle, gridView1.FocusedColumn)
			If cells IsNot Nothing Then
				For Each cell As GridCellInfo In cells
					If cell.RowHandle = e.RowHandle AndAlso e.Column.VisibleIndex > gridView1.FocusedColumn.VisibleIndex Then
						e.Appearance.BackColor = Color.Orange
					End If
				Next cell
			End If
		End Sub

		Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.northwindDataSet.Products)
		End Sub
	End Class
End Namespace
