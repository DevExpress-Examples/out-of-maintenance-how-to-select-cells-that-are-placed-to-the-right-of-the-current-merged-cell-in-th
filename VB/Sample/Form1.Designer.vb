Imports Microsoft.VisualBasic
Imports System
Namespace Sample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Sample.NorthwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.productsTableAdapter = New Sample.NorthwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(616, 239)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.AllowCellMerge = True
'			Me.gridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.gridView1_RowCellStyle);
			' 
			' colProductID
			' 
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.OptionsColumn.ReadOnly = True
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colSupplierID
			' 
			Me.colSupplierID.FieldName = "SupplierID"
			Me.colSupplierID.Name = "colSupplierID"
			Me.colSupplierID.Visible = True
			Me.colSupplierID.VisibleIndex = 2
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 3
			' 
			' colQuantityPerUnit
			' 
			Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
			Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
			Me.colQuantityPerUnit.Visible = True
			Me.colQuantityPerUnit.VisibleIndex = 4
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 5
			' 
			' colUnitsInStock
			' 
			Me.colUnitsInStock.FieldName = "UnitsInStock"
			Me.colUnitsInStock.Name = "colUnitsInStock"
			Me.colUnitsInStock.Visible = True
			Me.colUnitsInStock.VisibleIndex = 6
			' 
			' colUnitsOnOrder
			' 
			Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
			Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
			Me.colUnitsOnOrder.Visible = True
			Me.colUnitsOnOrder.VisibleIndex = 7
			' 
			' colReorderLevel
			' 
			Me.colReorderLevel.FieldName = "ReorderLevel"
			Me.colReorderLevel.Name = "colReorderLevel"
			Me.colReorderLevel.Visible = True
			Me.colReorderLevel.VisibleIndex = 8
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(616, 239)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "XtraForm1"
'			Me.Load += New System.EventHandler(Me.XtraForm1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private northwindDataSet As NorthwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As NorthwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

