<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_MEAT
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCONS_MEAT))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SPCONSSACMEATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProveedorID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaProduccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoteProduccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoEtiqueta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArticuloId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAreteRFID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoPie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoCaliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDecomisado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacenID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTLOTE = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTSALIDA = New System.Windows.Forms.TextBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SPCONSSACMEATDESHUESEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProveedorID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProveedor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaProduccion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoteProduccion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoEtiqueta1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArticuloID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAreteRFID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoPie1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoCaliente1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPesoFrio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacenID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SP_CONS_SAC_MEATTableAdapter = New SistemaControlProduccion.dsSacrificioTableAdapters.SP_CONS_SAC_MEATTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SP_CONS_SAC_MEAT_DESHUESETableAdapter = New SistemaControlProduccion.dsSacrificioTableAdapters.SP_CONS_SAC_MEAT_DESHUESETableAdapter()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSSACMEATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSSACMEATDESHUESEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.SPCONSSACMEATBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(6, 47)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1052, 506)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SPCONSSACMEATBindingSource
        '
        Me.SPCONSSACMEATBindingSource.DataMember = "SP_CONS_SAC_MEAT"
        Me.SPCONSSACMEATBindingSource.DataSource = Me.DsSacrificio
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProveedorID, Me.colProveedor, Me.colFechaProduccion, Me.colLoteProduccion, Me.colCodigoEtiqueta, Me.colArticuloId, Me.colAreteRFID, Me.colPesoPie, Me.colPesoCaliente, Me.colDecomisado, Me.colAlmacenID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProveedorID
        '
        Me.colProveedorID.FieldName = "ProveedorID"
        Me.colProveedorID.Name = "colProveedorID"
        Me.colProveedorID.Visible = True
        Me.colProveedorID.VisibleIndex = 0
        '
        'colProveedor
        '
        Me.colProveedor.FieldName = "Proveedor"
        Me.colProveedor.Name = "colProveedor"
        Me.colProveedor.Visible = True
        Me.colProveedor.VisibleIndex = 1
        '
        'colFechaProduccion
        '
        Me.colFechaProduccion.FieldName = "FechaProduccion"
        Me.colFechaProduccion.Name = "colFechaProduccion"
        Me.colFechaProduccion.Visible = True
        Me.colFechaProduccion.VisibleIndex = 2
        '
        'colLoteProduccion
        '
        Me.colLoteProduccion.FieldName = "LoteProduccion"
        Me.colLoteProduccion.Name = "colLoteProduccion"
        Me.colLoteProduccion.Visible = True
        Me.colLoteProduccion.VisibleIndex = 3
        '
        'colCodigoEtiqueta
        '
        Me.colCodigoEtiqueta.FieldName = "CodigoEtiqueta"
        Me.colCodigoEtiqueta.Name = "colCodigoEtiqueta"
        Me.colCodigoEtiqueta.Visible = True
        Me.colCodigoEtiqueta.VisibleIndex = 4
        '
        'colArticuloId
        '
        Me.colArticuloId.FieldName = "ArticuloId"
        Me.colArticuloId.Name = "colArticuloId"
        Me.colArticuloId.Visible = True
        Me.colArticuloId.VisibleIndex = 5
        '
        'colAreteRFID
        '
        Me.colAreteRFID.FieldName = "AreteRFID"
        Me.colAreteRFID.Name = "colAreteRFID"
        Me.colAreteRFID.Visible = True
        Me.colAreteRFID.VisibleIndex = 6
        '
        'colPesoPie
        '
        Me.colPesoPie.FieldName = "PesoPie"
        Me.colPesoPie.Name = "colPesoPie"
        Me.colPesoPie.Visible = True
        Me.colPesoPie.VisibleIndex = 7
        '
        'colPesoCaliente
        '
        Me.colPesoCaliente.FieldName = "PesoCaliente"
        Me.colPesoCaliente.Name = "colPesoCaliente"
        Me.colPesoCaliente.Visible = True
        Me.colPesoCaliente.VisibleIndex = 8
        '
        'colDecomisado
        '
        Me.colDecomisado.FieldName = "Decomisado"
        Me.colDecomisado.Name = "colDecomisado"
        Me.colDecomisado.Visible = True
        Me.colDecomisado.VisibleIndex = 9
        '
        'colAlmacenID
        '
        Me.colAlmacenID.FieldName = "AlmacenID"
        Me.colAlmacenID.Name = "colAlmacenID"
        Me.colAlmacenID.Visible = True
        Me.colAlmacenID.VisibleIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1072, 585)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SimpleButton2)
        Me.TabPage1.Controls.Add(Me.dtpfecha)
        Me.TabPage1.Controls.Add(Me.SimpleButton1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TXTLOTE)
        Me.TabPage1.Controls.Add(Me.GridControl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1064, 559)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sacrificio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(323, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(39, 34)
        Me.SimpleButton2.TabIndex = 5
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(174, 21)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(98, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(278, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(39, 34)
        Me.SimpleButton1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOTE"
        '
        'TXTLOTE
        '
        Me.TXTLOTE.Location = New System.Drawing.Point(68, 21)
        Me.TXTLOTE.Name = "TXTLOTE"
        Me.TXTLOTE.Size = New System.Drawing.Size(100, 20)
        Me.TXTLOTE.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SimpleButton3)
        Me.TabPage2.Controls.Add(Me.SimpleButton4)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TXTSALIDA)
        Me.TabPage2.Controls.Add(Me.GridControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1064, 559)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salida canales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(326, 6)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(39, 34)
        Me.SimpleButton3.TabIndex = 9
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(281, 6)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(39, 34)
        Me.SimpleButton4.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(177, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SALIDA"
        '
        'TXTSALIDA
        '
        Me.TXTSALIDA.Location = New System.Drawing.Point(71, 15)
        Me.TXTSALIDA.Name = "TXTSALIDA"
        Me.TXTSALIDA.Size = New System.Drawing.Size(100, 20)
        Me.TXTSALIDA.TabIndex = 5
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.SPCONSSACMEATDESHUESEBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(6, 51)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1052, 502)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'SPCONSSACMEATDESHUESEBindingSource
        '
        Me.SPCONSSACMEATDESHUESEBindingSource.DataMember = "SP_CONS_SAC_MEAT_DESHUESE"
        Me.SPCONSSACMEATDESHUESEBindingSource.DataSource = Me.DsSacrificio
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProveedorID1, Me.colProveedor1, Me.colFechaProduccion1, Me.colLoteProduccion1, Me.colCodigoEtiqueta1, Me.colArticuloID1, Me.colAreteRFID1, Me.colPesoPie1, Me.colPesoCaliente1, Me.colPesoFrio, Me.colAlmacenID1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colProveedorID1
        '
        Me.colProveedorID1.FieldName = "ProveedorID"
        Me.colProveedorID1.Name = "colProveedorID1"
        Me.colProveedorID1.Visible = True
        Me.colProveedorID1.VisibleIndex = 0
        '
        'colProveedor1
        '
        Me.colProveedor1.FieldName = "Proveedor"
        Me.colProveedor1.Name = "colProveedor1"
        Me.colProveedor1.Visible = True
        Me.colProveedor1.VisibleIndex = 1
        '
        'colFechaProduccion1
        '
        Me.colFechaProduccion1.FieldName = "FechaProduccion"
        Me.colFechaProduccion1.Name = "colFechaProduccion1"
        Me.colFechaProduccion1.Visible = True
        Me.colFechaProduccion1.VisibleIndex = 2
        '
        'colLoteProduccion1
        '
        Me.colLoteProduccion1.FieldName = "LoteProduccion"
        Me.colLoteProduccion1.Name = "colLoteProduccion1"
        Me.colLoteProduccion1.Visible = True
        Me.colLoteProduccion1.VisibleIndex = 3
        '
        'colCodigoEtiqueta1
        '
        Me.colCodigoEtiqueta1.FieldName = "CodigoEtiqueta"
        Me.colCodigoEtiqueta1.Name = "colCodigoEtiqueta1"
        Me.colCodigoEtiqueta1.Visible = True
        Me.colCodigoEtiqueta1.VisibleIndex = 4
        '
        'colArticuloID1
        '
        Me.colArticuloID1.FieldName = "ArticuloID"
        Me.colArticuloID1.Name = "colArticuloID1"
        Me.colArticuloID1.Visible = True
        Me.colArticuloID1.VisibleIndex = 5
        '
        'colAreteRFID1
        '
        Me.colAreteRFID1.FieldName = "AreteRFID"
        Me.colAreteRFID1.Name = "colAreteRFID1"
        Me.colAreteRFID1.Visible = True
        Me.colAreteRFID1.VisibleIndex = 6
        '
        'colPesoPie1
        '
        Me.colPesoPie1.FieldName = "PesoPie"
        Me.colPesoPie1.Name = "colPesoPie1"
        Me.colPesoPie1.Visible = True
        Me.colPesoPie1.VisibleIndex = 7
        '
        'colPesoCaliente1
        '
        Me.colPesoCaliente1.FieldName = "PesoCaliente"
        Me.colPesoCaliente1.Name = "colPesoCaliente1"
        Me.colPesoCaliente1.Visible = True
        Me.colPesoCaliente1.VisibleIndex = 8
        '
        'colPesoFrio
        '
        Me.colPesoFrio.FieldName = "PesoFrio"
        Me.colPesoFrio.Name = "colPesoFrio"
        Me.colPesoFrio.Visible = True
        Me.colPesoFrio.VisibleIndex = 9
        '
        'colAlmacenID1
        '
        Me.colAlmacenID1.FieldName = "AlmacenID"
        Me.colAlmacenID1.Name = "colAlmacenID1"
        Me.colAlmacenID1.Visible = True
        Me.colAlmacenID1.VisibleIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1064, 559)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Deshuese"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SP_CONS_SAC_MEATTableAdapter
        '
        Me.SP_CONS_SAC_MEATTableAdapter.ClearBeforeFill = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Archivos Excel | *.xls"
        '
        'SP_CONS_SAC_MEAT_DESHUESETableAdapter
        '
        Me.SP_CONS_SAC_MEAT_DESHUESETableAdapter.ClearBeforeFill = True
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.Filter = "Archivos Excel | *.xls"
        '
        'frmCONS_MEAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1096, 609)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmCONS_MEAT"
        Me.Text = "frmCONS_MEAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSSACMEATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSSACMEATDESHUESEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTLOTE As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents SPCONSSACMEATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents colProveedorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProduccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoteProduccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoEtiqueta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArticuloId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAreteRFID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoPie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoCaliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDecomisado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacenID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_CONS_SAC_MEATTableAdapter As SistemaControlProduccion.dsSacrificioTableAdapters.SP_CONS_SAC_MEATTableAdapter
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTSALIDA As System.Windows.Forms.TextBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SPCONSSACMEATDESHUESEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colProveedorID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProveedor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProduccion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoteProduccion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoEtiqueta1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArticuloID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAreteRFID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoPie1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoCaliente1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPesoFrio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacenID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SP_CONS_SAC_MEAT_DESHUESETableAdapter As SistemaControlProduccion.dsSacrificioTableAdapters.SP_CONS_SAC_MEAT_DESHUESETableAdapter
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
End Class
