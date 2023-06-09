<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_COSTEO
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPROC_COSTEO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTMP = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnomintroductor = New System.Windows.Forms.TextBox()
        Me.txtmarcaintroductor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcorte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTIDINSUMO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTPRECIO = New System.Windows.Forms.TextBox()
        Me.TXTNOMINSUMO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.IDINSUMODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMPLOTEPROCESABLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_LOTE_PROCESABLE = New SistemaControlProduccion.DS_LOTE_PROCESABLE()
        Me.TMP_LOTEPROCESABLETableAdapter = New SistemaControlProduccion.DS_LOTE_PROCESABLETableAdapters.TMP_LOTEPROCESABLETableAdapter()
        Me.txtimpventa = New System.Windows.Forms.TextBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SPCONSENTSALXMOVTORESUMENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.IDPRODCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO_VTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FACTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE_VENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMPLOTEPROCESABLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_LOTE_PROCESABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSENTSALXMOVTORESUMENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KG. Materia Prima"
        '
        'TXTMP
        '
        Me.TXTMP.Location = New System.Drawing.Point(104, 67)
        Me.TXTMP.Name = "TXTMP"
        Me.TXTMP.Size = New System.Drawing.Size(100, 20)
        Me.TXTMP.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SimpleButton3)
        Me.GroupBox1.Controls.Add(Me.txtimpventa)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtnomintroductor)
        Me.GroupBox1.Controls.Add(Me.txtmarcaintroductor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.txtidcorte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTMP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(953, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos a procesar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(259, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(69, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lote"
        '
        'txtnomintroductor
        '
        Me.txtnomintroductor.Location = New System.Drawing.Point(334, 67)
        Me.txtnomintroductor.Name = "txtnomintroductor"
        Me.txtnomintroductor.Size = New System.Drawing.Size(247, 20)
        Me.txtnomintroductor.TabIndex = 8
        '
        'txtmarcaintroductor
        '
        Me.txtmarcaintroductor.Location = New System.Drawing.Point(259, 67)
        Me.txtmarcaintroductor.Name = "txtmarcaintroductor"
        Me.txtmarcaintroductor.Size = New System.Drawing.Size(69, 20)
        Me.txtmarcaintroductor.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cliente"
        '
        'txtidcorte
        '
        Me.txtidcorte.Location = New System.Drawing.Point(104, 29)
        Me.txtidcorte.Name = "txtidcorte"
        Me.txtidcorte.Size = New System.Drawing.Size(100, 20)
        Me.txtidcorte.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id_corte"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(953, 329)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del lote"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(938, 304)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(930, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PRODUCTOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPRODCTEDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.CAJAS, Me.COSTO, Me.PRECIO_VTA, Me.FACTOR, Me.IMPORTE_VENTA})
        Me.DataGridView1.DataSource = Me.SPCONSENTSALXMOVTORESUMENBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(921, 269)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TXTTOTAL)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TXTPRECIO)
        Me.TabPage2.Controls.Add(Me.TXTNOMINSUMO)
        Me.TabPage2.Controls.Add(Me.SimpleButton2)
        Me.TabPage2.Controls.Add(Me.TXTCANTIDAD)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TXTIDINSUMO)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(930, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INSUMOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(636, 13)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(69, 20)
        Me.TXTCANTIDAD.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(586, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cantidad"
        '
        'TXTIDINSUMO
        '
        Me.TXTIDINSUMO.Location = New System.Drawing.Point(91, 13)
        Me.TXTIDINSUMO.Name = "TXTIDINSUMO"
        Me.TXTIDINSUMO.Size = New System.Drawing.Size(84, 20)
        Me.TXTIDINSUMO.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID Insumo"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDINSUMODataGridViewTextBoxColumn, Me.NOMBRE, Me.CANTIDADDataGridViewTextBoxColumn, Me.PRECIODataGridViewTextBoxColumn, Me.IMPORTEDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TMPLOTEPROCESABLEBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(6, 47)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Size = New System.Drawing.Size(908, 225)
        Me.DataGridView2.TabIndex = 0
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 250
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(452, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "PRECIO"
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.Enabled = False
        Me.TXTPRECIO.Location = New System.Drawing.Point(505, 13)
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(75, 20)
        Me.TXTPRECIO.TabIndex = 13
        '
        'TXTNOMINSUMO
        '
        Me.TXTNOMINSUMO.Location = New System.Drawing.Point(181, 13)
        Me.TXTNOMINSUMO.Name = "TXTNOMINSUMO"
        Me.TXTNOMINSUMO.Size = New System.Drawing.Size(265, 20)
        Me.TXTNOMINSUMO.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(754, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "IMPORTE"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Location = New System.Drawing.Point(817, 13)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(107, 20)
        Me.TXTTOTAL.TabIndex = 19
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(711, 7)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(36, 32)
        Me.SimpleButton2.TabIndex = 11
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(334, 23)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(36, 32)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'IDINSUMODataGridViewTextBoxColumn
        '
        Me.IDINSUMODataGridViewTextBoxColumn.DataPropertyName = "ID_INSUMO"
        Me.IDINSUMODataGridViewTextBoxColumn.HeaderText = "ID_INSUMO"
        Me.IDINSUMODataGridViewTextBoxColumn.Name = "IDINSUMODataGridViewTextBoxColumn"
        Me.IDINSUMODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        Me.CANTIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIODataGridViewTextBoxColumn
        '
        Me.PRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.Name = "PRECIODataGridViewTextBoxColumn"
        Me.PRECIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'IMPORTEDataGridViewTextBoxColumn
        '
        Me.IMPORTEDataGridViewTextBoxColumn.DataPropertyName = "IMPORTE"
        Me.IMPORTEDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.IMPORTEDataGridViewTextBoxColumn.Name = "IMPORTEDataGridViewTextBoxColumn"
        Me.IMPORTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TMPLOTEPROCESABLEBindingSource
        '
        Me.TMPLOTEPROCESABLEBindingSource.DataMember = "TMP_LOTEPROCESABLE"
        Me.TMPLOTEPROCESABLEBindingSource.DataSource = Me.DS_LOTE_PROCESABLE
        '
        'DS_LOTE_PROCESABLE
        '
        Me.DS_LOTE_PROCESABLE.DataSetName = "DS_LOTE_PROCESABLE"
        Me.DS_LOTE_PROCESABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TMP_LOTEPROCESABLETableAdapter
        '
        Me.TMP_LOTEPROCESABLETableAdapter.ClearBeforeFill = True
        '
        'txtimpventa
        '
        Me.txtimpventa.Location = New System.Drawing.Point(630, 63)
        Me.txtimpventa.Name = "txtimpventa"
        Me.txtimpventa.Size = New System.Drawing.Size(69, 20)
        Me.txtimpventa.TabIndex = 11
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(376, 23)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(36, 32)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'SPCONSENTSALXMOVTORESUMENBindingSource
        '
        Me.SPCONSENTSALXMOVTORESUMENBindingSource.DataMember = "SP_CONS_ENTSAL_X_MOVTO_RESUMEN"
        Me.SPCONSENTSALXMOVTORESUMENBindingSource.DataSource = Me.DsSacrificio
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.EnforceConstraints = False
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDPRODCTEDataGridViewTextBoxColumn
        '
        Me.IDPRODCTEDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODCTE"
        Me.IDPRODCTEDataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.IDPRODCTEDataGridViewTextBoxColumn.Name = "IDPRODCTEDataGridViewTextBoxColumn"
        Me.IDPRODCTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "PRODUCTO"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn.Width = 250
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAS
        '
        Me.CAJAS.DataPropertyName = "CAJAS"
        Me.CAJAS.HeaderText = "CAJAS"
        Me.CAJAS.Name = "CAJAS"
        Me.CAJAS.ReadOnly = True
        '
        'COSTO
        '
        Me.COSTO.HeaderText = "COSTO"
        Me.COSTO.Name = "COSTO"
        Me.COSTO.ReadOnly = True
        '
        'PRECIO_VTA
        '
        Me.PRECIO_VTA.DataPropertyName = "PRECIO_VTA"
        Me.PRECIO_VTA.HeaderText = "PRECIO_VTA"
        Me.PRECIO_VTA.Name = "PRECIO_VTA"
        Me.PRECIO_VTA.ReadOnly = True
        '
        'FACTOR
        '
        Me.FACTOR.HeaderText = "FACTOR"
        Me.FACTOR.Name = "FACTOR"
        Me.FACTOR.ReadOnly = True
        Me.FACTOR.Visible = False
        '
        'IMPORTE_VENTA
        '
        Me.IMPORTE_VENTA.DataPropertyName = "IMPORTE_VENTA"
        Me.IMPORTE_VENTA.HeaderText = "IMPORTE_VENTA"
        Me.IMPORTE_VENTA.Name = "IMPORTE_VENTA"
        Me.IMPORTE_VENTA.ReadOnly = True
        '
        'frmPROC_COSTEO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 459)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPROC_COSTEO"
        Me.Text = "frmPROC_COSTEO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMPLOTEPROCESABLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_LOTE_PROCESABLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSENTSALXMOVTORESUMENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTMP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidcorte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtnomintroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtmarcaintroductor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SPCONSENTSALXMOVTORESUMENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXTCANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTIDINSUMO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DS_LOTE_PROCESABLE As SistemaControlProduccion.DS_LOTE_PROCESABLE
    Friend WithEvents TMPLOTEPROCESABLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TMP_LOTEPROCESABLETableAdapter As SistemaControlProduccion.DS_LOTE_PROCESABLETableAdapters.TMP_LOTEPROCESABLETableAdapter
    Friend WithEvents IDINSUMODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOMINSUMO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents txtimpventa As System.Windows.Forms.TextBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IDPRODCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COSTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_VTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE_VENTA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
