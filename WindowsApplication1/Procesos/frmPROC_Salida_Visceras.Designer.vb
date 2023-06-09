<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_Salida_Visceras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPROC_Salida_Visceras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNomMovto = New System.Windows.Forms.TextBox()
        Me.txtIdMovto = New System.Windows.Forms.TextBox()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.lblIntr = New System.Windows.Forms.Label()
        Me.txtNomDestino = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaDestino = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNomProd = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numPiezas = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.btnPesar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvDatosResumen = New System.Windows.Forms.DataGridView()
        Me.IDMOVDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.ID_EST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACMAYORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACVACIADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACENMANTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIELARETECAMPANADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIELARETESAGARPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DECOMISODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPCONSENTSALXMOVTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CONS_ENTSAL_X_MOVTOTableAdapter = New SistemaControlProduccion.dsSacrificioTableAdapters.SP_CONS_ENTSAL_X_MOVTOTableAdapter()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.numPiezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvDatosResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSENTSALXMOVTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomMovto
        '
        Me.txtNomMovto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomMovto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomMovto.Location = New System.Drawing.Point(8, 59)
        Me.txtNomMovto.MaxLength = 40
        Me.txtNomMovto.Name = "txtNomMovto"
        Me.txtNomMovto.ReadOnly = True
        Me.txtNomMovto.Size = New System.Drawing.Size(298, 26)
        Me.txtNomMovto.TabIndex = 4
        Me.txtNomMovto.TabStop = False
        '
        'txtIdMovto
        '
        Me.txtIdMovto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdMovto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMovto.Location = New System.Drawing.Point(109, 27)
        Me.txtIdMovto.MaxLength = 6
        Me.txtIdMovto.Name = "txtIdMovto"
        Me.txtIdMovto.ReadOnly = True
        Me.txtIdMovto.Size = New System.Drawing.Size(76, 26)
        Me.txtIdMovto.TabIndex = 2
        Me.txtIdMovto.TabStop = False
        Me.txtIdMovto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdMovto.Visible = False
        '
        'lblProductor
        '
        Me.lblProductor.AutoSize = True
        Me.lblProductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductor.Location = New System.Drawing.Point(4, 30)
        Me.lblProductor.Name = "lblProductor"
        Me.lblProductor.Size = New System.Drawing.Size(99, 20)
        Me.lblProductor.TabIndex = 1
        Me.lblProductor.Text = "Movimiento"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(525, 112)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(438, 68)
        Me.Panel11.TabIndex = 8
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.btnAgregar)
        Me.Panel12.Controls.Add(Me.txtPeso)
        Me.Panel12.Controls.Add(Me.Label30)
        Me.Panel12.Location = New System.Drawing.Point(1, 1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(434, 64)
        Me.Panel12.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.SistemaControlProduccion.My.Resources.Resources.inbox_download
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(348, 7)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 47)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.OrangeRed
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.White
        Me.txtPeso.Location = New System.Drawing.Point(161, 7)
        Me.txtPeso.MaxLength = 8
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(181, 47)
        Me.txtPeso.TabIndex = 1
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(87, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(63, 23)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Peso"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(37, 75)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(68, 19)
        Me.lblDestino.TabIndex = 3
        Me.lblDestino.Text = "Destino"
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(193, 40)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(281, 26)
        Me.txtNomIntroductor.TabIndex = 2
        '
        'lblIntr
        '
        Me.lblIntr.AutoSize = True
        Me.lblIntr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntr.Location = New System.Drawing.Point(11, 43)
        Me.lblIntr.Name = "lblIntr"
        Me.lblIntr.Size = New System.Drawing.Size(94, 19)
        Me.lblIntr.TabIndex = 0
        Me.lblIntr.Text = "Introductor"
        '
        'txtNomDestino
        '
        Me.txtNomDestino.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomDestino.Enabled = False
        Me.txtNomDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomDestino.Location = New System.Drawing.Point(193, 72)
        Me.txtNomDestino.MaxLength = 6
        Me.txtNomDestino.Name = "txtNomDestino"
        Me.txtNomDestino.Size = New System.Drawing.Size(281, 26)
        Me.txtNomDestino.TabIndex = 5
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(111, 40)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 1
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaDestino
        '
        Me.txtMarcaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaDestino.Location = New System.Drawing.Point(111, 72)
        Me.txtMarcaDestino.MaxLength = 6
        Me.txtMarcaDestino.Name = "txtMarcaDestino"
        Me.txtMarcaDestino.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaDestino.TabIndex = 4
        Me.txtMarcaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaMov)
        Me.Panel8.Controls.Add(Me.txtIdMovto)
        Me.Panel8.Controls.Add(Me.lblProductor)
        Me.Panel8.Controls.Add(Me.txtNomMovto)
        Me.Panel8.Location = New System.Drawing.Point(12, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(316, 95)
        Me.Panel8.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(-2, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(317, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Movimiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Enabled = False
        Me.dtpFechaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(193, 27)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(113, 26)
        Me.dtpFechaMov.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(319, 97)
        Me.Label13.TabIndex = 26
        '
        'txtNomProd
        '
        Me.txtNomProd.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomProd.Enabled = False
        Me.txtNomProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProd.Location = New System.Drawing.Point(139, 29)
        Me.txtNomProd.MaxLength = 40
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.ReadOnly = True
        Me.txtNomProd.Size = New System.Drawing.Size(246, 26)
        Me.txtNomProd.TabIndex = 3
        '
        'txtCodProd
        '
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(69, 29)
        Me.txtCodProd.MaxLength = 6
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(64, 26)
        Me.txtCodProd.TabIndex = 2
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.numPiezas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCodProd)
        Me.Panel1.Controls.Add(Me.txtNomProd)
        Me.Panel1.Location = New System.Drawing.Point(526, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 95)
        Me.Panel1.TabIndex = 6
        '
        'numPiezas
        '
        Me.numPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPiezas.Location = New System.Drawing.Point(69, 61)
        Me.numPiezas.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numPiezas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPiezas.Name = "numPiezas"
        Me.numPiezas.Size = New System.Drawing.Size(64, 26)
        Me.numPiezas.TabIndex = 5
        Me.numPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPiezas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Piezas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(-1, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos del Producto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(436, 98)
        Me.Label4.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaDestino)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Controls.Add(Me.lblDestino)
        Me.Panel2.Controls.Add(Me.txtNomDestino)
        Me.Panel2.Controls.Add(Me.lblIntr)
        Me.Panel2.Location = New System.Drawing.Point(12, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 130)
        Me.Panel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(509, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos de los clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(509, 133)
        Me.Label6.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtLote)
        Me.Panel4.Location = New System.Drawing.Point(336, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(182, 95)
        Me.Panel4.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(-1, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lote"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(25, 40)
        Me.txtLote.MaxLength = 6
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(125, 32)
        Me.txtLote.TabIndex = 1
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(335, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(185, 97)
        Me.Label12.TabIndex = 33
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 573)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(975, 22)
        Me.StatusStrip1.TabIndex = 37
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "F2|Nuevo"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel2.Text = "F3|Buscar"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(64, 17)
        Me.ToolStripStatusLabel3.Text = "F4|Guardar"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel6.Text = "F5|Pesar"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(116, 17)
        Me.ToolStripStatusLabel7.Text = "F6|Agregar Producto"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(524, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(439, 320)
        Me.Label8.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(510, 226)
        Me.Label9.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(526, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(436, 23)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Detalle de productos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(12, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(506, 23)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Resumen de productos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 478)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(510, 85)
        Me.Label16.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(12, 480)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(506, 23)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Observaciones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 506)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(506, 55)
        Me.txtObservaciones.TabIndex = 5
        '
        'btnPesar
        '
        Me.btnPesar.FlatAppearance.BorderSize = 0
        Me.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesar.Image = Global.SistemaControlProduccion.My.Resources.Resources.bascula4
        Me.btnPesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesar.Location = New System.Drawing.Point(892, 509)
        Me.btnPesar.Name = "btnPesar"
        Me.btnPesar.Size = New System.Drawing.Size(71, 57)
        Me.btnPesar.TabIndex = 12
        Me.btnPesar.Text = "&Pesar"
        Me.btnPesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPesar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(815, 509)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(738, 509)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgvDatosResumen
        '
        Me.dgvDatosResumen.AllowUserToAddRows = False
        Me.dgvDatosResumen.AllowUserToDeleteRows = False
        Me.dgvDatosResumen.AllowUserToOrderColumns = True
        Me.dgvDatosResumen.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvDatosResumen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatosResumen.AutoGenerateColumns = False
        Me.dgvDatosResumen.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosResumen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatosResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMOVDataGridViewTextBoxColumn1, Me.IDALMDataGridViewTextBoxColumn1, Me.MARCACTEDESTDataGridViewTextBoxColumn1, Me.SACLOTEDataGridViewTextBoxColumn1, Me.IDPRODDataGridViewTextBoxColumn1, Me.NOMPRODDataGridViewTextBoxColumn1, Me.PIEZASDataGridViewTextBoxColumn1, Me.PESODataGridViewTextBoxColumn1, Me.TARADataGridViewTextBoxColumn1})
        Me.dgvDatosResumen.DataMember = "SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_RESUMEN_TMP"
        Me.dgvDatosResumen.DataSource = Me.DsSacrificio
        Me.dgvDatosResumen.Location = New System.Drawing.Point(11, 276)
        Me.dgvDatosResumen.Name = "dgvDatosResumen"
        Me.dgvDatosResumen.ReadOnly = True
        Me.dgvDatosResumen.RowHeadersVisible = False
        Me.dgvDatosResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatosResumen.Size = New System.Drawing.Size(508, 197)
        Me.dgvDatosResumen.StandardTab = True
        Me.dgvDatosResumen.TabIndex = 4
        '
        'IDMOVDataGridViewTextBoxColumn1
        '
        Me.IDMOVDataGridViewTextBoxColumn1.DataPropertyName = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn1.HeaderText = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn1.Name = "IDMOVDataGridViewTextBoxColumn1"
        Me.IDMOVDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDMOVDataGridViewTextBoxColumn1.Visible = False
        '
        'IDALMDataGridViewTextBoxColumn1
        '
        Me.IDALMDataGridViewTextBoxColumn1.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn1.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn1.Name = "IDALMDataGridViewTextBoxColumn1"
        Me.IDALMDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDALMDataGridViewTextBoxColumn1.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn1
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.HeaderText = "DEST."
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Name = "MARCACTEDESTDataGridViewTextBoxColumn1"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Width = 60
        '
        'SACLOTEDataGridViewTextBoxColumn1
        '
        Me.SACLOTEDataGridViewTextBoxColumn1.DataPropertyName = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn1.HeaderText = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn1.Name = "SACLOTEDataGridViewTextBoxColumn1"
        Me.SACLOTEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SACLOTEDataGridViewTextBoxColumn1.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn1
        '
        Me.IDPRODDataGridViewTextBoxColumn1.DataPropertyName = "ID_PROD"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IDPRODDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.IDPRODDataGridViewTextBoxColumn1.HeaderText = "PROD."
        Me.IDPRODDataGridViewTextBoxColumn1.Name = "IDPRODDataGridViewTextBoxColumn1"
        Me.IDPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn1.Width = 50
        '
        'NOMPRODDataGridViewTextBoxColumn1
        '
        Me.NOMPRODDataGridViewTextBoxColumn1.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn1.HeaderText = "NOMBRE"
        Me.NOMPRODDataGridViewTextBoxColumn1.Name = "NOMPRODDataGridViewTextBoxColumn1"
        Me.NOMPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn1.Width = 180
        '
        'PIEZASDataGridViewTextBoxColumn1
        '
        Me.PIEZASDataGridViewTextBoxColumn1.DataPropertyName = "PIEZAS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PIEZASDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.PIEZASDataGridViewTextBoxColumn1.HeaderText = "PZAS."
        Me.PIEZASDataGridViewTextBoxColumn1.Name = "PIEZASDataGridViewTextBoxColumn1"
        Me.PIEZASDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn1.Width = 50
        '
        'PESODataGridViewTextBoxColumn1
        '
        Me.PESODataGridViewTextBoxColumn1.DataPropertyName = "PESO"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESODataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.PESODataGridViewTextBoxColumn1.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn1.Name = "PESODataGridViewTextBoxColumn1"
        Me.PESODataGridViewTextBoxColumn1.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn1.Width = 70
        '
        'TARADataGridViewTextBoxColumn1
        '
        Me.TARADataGridViewTextBoxColumn1.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn1.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn1.Name = "TARADataGridViewTextBoxColumn1"
        Me.TARADataGridViewTextBoxColumn1.ReadOnly = True
        Me.TARADataGridViewTextBoxColumn1.Visible = False
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        Me.dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_EST, Me.IDMOVDataGridViewTextBoxColumn, Me.IDALMDataGridViewTextBoxColumn, Me.MARCACTEDESTDataGridViewTextBoxColumn, Me.SACLOTEDataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.IDESDDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.TARADataGridViewTextBoxColumn, Me.FECHAESDDataGridViewTextBoxColumn, Me.HORAESDDataGridViewTextBoxColumn, Me.SACSERIEDataGridViewTextBoxColumn, Me.SACIDDataGridViewTextBoxColumn, Me.SACLADODataGridViewTextBoxColumn, Me.SACSEXODataGridViewTextBoxColumn, Me.SACMAYORDataGridViewTextBoxColumn, Me.SACVACIADADataGridViewTextBoxColumn, Me.SACENMANTADODataGridViewTextBoxColumn, Me.PIELARETECAMPANADataGridViewTextBoxColumn, Me.PIELARETESAGARPADataGridViewTextBoxColumn, Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn, Me.DECOMISODataGridViewTextBoxColumn})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_TMP"
        Me.dgvDatos.DataSource = Me.DsSacrificio
        Me.dgvDatos.Location = New System.Drawing.Point(525, 212)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(437, 291)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 9
        '
        'ID_EST
        '
        Me.ID_EST.DataPropertyName = "ID_EST"
        Me.ID_EST.HeaderText = "ID_EST"
        Me.ID_EST.Name = "ID_EST"
        Me.ID_EST.ReadOnly = True
        Me.ID_EST.Visible = False
        '
        'IDMOVDataGridViewTextBoxColumn
        '
        Me.IDMOVDataGridViewTextBoxColumn.DataPropertyName = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.HeaderText = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.Name = "IDMOVDataGridViewTextBoxColumn"
        Me.IDMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMOVDataGridViewTextBoxColumn.Visible = False
        '
        'IDALMDataGridViewTextBoxColumn
        '
        Me.IDALMDataGridViewTextBoxColumn.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.Name = "IDALMDataGridViewTextBoxColumn"
        Me.IDALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDALMDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.HeaderText = "DEST."
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Name = "MARCACTEDESTDataGridViewTextBoxColumn"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Width = 60
        '
        'SACLOTEDataGridViewTextBoxColumn
        '
        Me.SACLOTEDataGridViewTextBoxColumn.DataPropertyName = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.HeaderText = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.Name = "SACLOTEDataGridViewTextBoxColumn"
        Me.SACLOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLOTEDataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Visible = False
        '
        'IDESDDataGridViewTextBoxColumn
        '
        Me.IDESDDataGridViewTextBoxColumn.DataPropertyName = "ID_ESD"
        Me.IDESDDataGridViewTextBoxColumn.HeaderText = "ID_ESD"
        Me.IDESDDataGridViewTextBoxColumn.Name = "IDESDDataGridViewTextBoxColumn"
        Me.IDESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESDDataGridViewTextBoxColumn.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IDPRODDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "PROD."
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn.Width = 60
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn.Width = 160
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PZAS."
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn.Width = 60
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn.Width = 70
        '
        'TARADataGridViewTextBoxColumn
        '
        Me.TARADataGridViewTextBoxColumn.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn.Name = "TARADataGridViewTextBoxColumn"
        Me.TARADataGridViewTextBoxColumn.ReadOnly = True
        Me.TARADataGridViewTextBoxColumn.Visible = False
        '
        'FECHAESDDataGridViewTextBoxColumn
        '
        Me.FECHAESDDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn.HeaderText = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn.Name = "FECHAESDDataGridViewTextBoxColumn"
        Me.FECHAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAESDDataGridViewTextBoxColumn.Visible = False
        '
        'HORAESDDataGridViewTextBoxColumn
        '
        Me.HORAESDDataGridViewTextBoxColumn.DataPropertyName = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn.HeaderText = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn.Name = "HORAESDDataGridViewTextBoxColumn"
        Me.HORAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAESDDataGridViewTextBoxColumn.Visible = False
        '
        'SACSERIEDataGridViewTextBoxColumn
        '
        Me.SACSERIEDataGridViewTextBoxColumn.DataPropertyName = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.HeaderText = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.Name = "SACSERIEDataGridViewTextBoxColumn"
        Me.SACSERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSERIEDataGridViewTextBoxColumn.Visible = False
        '
        'SACIDDataGridViewTextBoxColumn
        '
        Me.SACIDDataGridViewTextBoxColumn.DataPropertyName = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.HeaderText = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.Name = "SACIDDataGridViewTextBoxColumn"
        Me.SACIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACIDDataGridViewTextBoxColumn.Visible = False
        '
        'SACLADODataGridViewTextBoxColumn
        '
        Me.SACLADODataGridViewTextBoxColumn.DataPropertyName = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.HeaderText = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.Name = "SACLADODataGridViewTextBoxColumn"
        Me.SACLADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLADODataGridViewTextBoxColumn.Visible = False
        '
        'SACSEXODataGridViewTextBoxColumn
        '
        Me.SACSEXODataGridViewTextBoxColumn.DataPropertyName = "SAC_SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.HeaderText = "SAC_SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.Name = "SACSEXODataGridViewTextBoxColumn"
        Me.SACSEXODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSEXODataGridViewTextBoxColumn.Visible = False
        '
        'SACMAYORDataGridViewTextBoxColumn
        '
        Me.SACMAYORDataGridViewTextBoxColumn.DataPropertyName = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.HeaderText = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.Name = "SACMAYORDataGridViewTextBoxColumn"
        Me.SACMAYORDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACMAYORDataGridViewTextBoxColumn.Visible = False
        '
        'SACVACIADADataGridViewTextBoxColumn
        '
        Me.SACVACIADADataGridViewTextBoxColumn.DataPropertyName = "SAC_VACIADA"
        Me.SACVACIADADataGridViewTextBoxColumn.HeaderText = "SAC_VACIADA"
        Me.SACVACIADADataGridViewTextBoxColumn.Name = "SACVACIADADataGridViewTextBoxColumn"
        Me.SACVACIADADataGridViewTextBoxColumn.ReadOnly = True
        Me.SACVACIADADataGridViewTextBoxColumn.Visible = False
        '
        'SACENMANTADODataGridViewTextBoxColumn
        '
        Me.SACENMANTADODataGridViewTextBoxColumn.DataPropertyName = "SAC_ENMANTADO"
        Me.SACENMANTADODataGridViewTextBoxColumn.HeaderText = "SAC_ENMANTADO"
        Me.SACENMANTADODataGridViewTextBoxColumn.Name = "SACENMANTADODataGridViewTextBoxColumn"
        Me.SACENMANTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACENMANTADODataGridViewTextBoxColumn.Visible = False
        '
        'PIELARETECAMPANADataGridViewTextBoxColumn
        '
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.DataPropertyName = "PIEL_ARETE_CAMPANA"
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.HeaderText = "PIEL_ARETE_CAMPANA"
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.Name = "PIELARETECAMPANADataGridViewTextBoxColumn"
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.ReadOnly = True
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.Visible = False
        '
        'PIELARETESAGARPADataGridViewTextBoxColumn
        '
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.DataPropertyName = "PIEL_ARETE_SAGARPA"
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.HeaderText = "PIEL_ARETE_SAGARPA"
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.Name = "PIELARETESAGARPADataGridViewTextBoxColumn"
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.ReadOnly = True
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.Visible = False
        '
        'PIELARETEINTRODUCTORDataGridViewTextBoxColumn
        '
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.DataPropertyName = "PIEL_ARETE_INTRODUCTOR"
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.HeaderText = "PIEL_ARETE_INTRODUCTOR"
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.Name = "PIELARETEINTRODUCTORDataGridViewTextBoxColumn"
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.Visible = False
        '
        'DECOMISODataGridViewTextBoxColumn
        '
        Me.DECOMISODataGridViewTextBoxColumn.DataPropertyName = "DECOMISO"
        Me.DECOMISODataGridViewTextBoxColumn.HeaderText = "DECOMISO"
        Me.DECOMISODataGridViewTextBoxColumn.Name = "DECOMISODataGridViewTextBoxColumn"
        Me.DECOMISODataGridViewTextBoxColumn.ReadOnly = True
        Me.DECOMISODataGridViewTextBoxColumn.Visible = False
        '
        'SPCONSENTSALXMOVTOBindingSource
        '
        Me.SPCONSENTSALXMOVTOBindingSource.DataMember = "SP_CONS_ENTSAL_X_MOVTO"
        Me.SPCONSENTSALXMOVTOBindingSource.DataSource = Me.DsSacrificio
        '
        'SP_CONS_ENTSAL_X_MOVTOTableAdapter
        '
        Me.SP_CONS_ENTSAL_X_MOVTOTableAdapter.ClearBeforeFill = True
        '
        'frmPROC_Salida_Visceras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(975, 595)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvDatosResumen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPesar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPROC_Salida_Visceras"
        Me.ShowInTaskbar = False
        Me.Text = "Registro de salida de visceras por embarque"
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numPiezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvDatosResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSENTSALXMOVTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomMovto As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMovto As System.Windows.Forms.TextBox
    Friend WithEvents lblProductor As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents lblIntr As System.Windows.Forms.Label
    Friend WithEvents txtNomDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaDestino As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNomProd As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnPesar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents numPiezas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvDatosResumen As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents SPCONSENTSALXMOVTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_CONS_ENTSAL_X_MOVTOTableAdapter As SistemaControlProduccion.dsSacrificioTableAdapters.SP_CONS_ENTSAL_X_MOVTOTableAdapter
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents IDMOVDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_EST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACMAYORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACVACIADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACENMANTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIELARETECAMPANADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIELARETESAGARPADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIELARETEINTRODUCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DECOMISODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
