<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_Sacrificio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNomMovto = New System.Windows.Forms.TextBox()
        Me.txtIdMovto = New System.Windows.Forms.TextBox()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.rdbLado2 = New System.Windows.Forms.RadioButton()
        Me.rdbLado1 = New System.Windows.Forms.RadioButton()
        Me.txtKgsLado2 = New System.Windows.Forms.TextBox()
        Me.txtKgsLado1 = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.lblIntr = New System.Windows.Forms.Label()
        Me.txtNomDestino = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.txtNomProductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaDestino = New System.Windows.Forms.TextBox()
        Me.txtMarcaProductor = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
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
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnPesar = New System.Windows.Forms.Button()
        Me.chkDecomiso = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkPesarLado2 = New System.Windows.Forms.CheckBox()
        Me.rdbVaquilla = New System.Windows.Forms.RadioButton()
        Me.rdbHembra = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbMacho = New System.Windows.Forms.RadioButton()
        Me.chkEnmantado = New System.Windows.Forms.CheckBox()
        Me.chkVaciada = New System.Windows.Forms.CheckBox()
        Me.chkMayor = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.REN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSEC_DIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAYORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VACIADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ENMANTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DECOMISO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ESTATUS_ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel11.Location = New System.Drawing.Point(597, 249)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(375, 204)
        Me.Panel11.TabIndex = 8
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.rdbLado2)
        Me.Panel12.Controls.Add(Me.rdbLado1)
        Me.Panel12.Controls.Add(Me.txtKgsLado2)
        Me.Panel12.Controls.Add(Me.txtKgsLado1)
        Me.Panel12.Controls.Add(Me.txtPeso)
        Me.Panel12.Controls.Add(Me.Label30)
        Me.Panel12.Location = New System.Drawing.Point(1, 1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(370, 200)
        Me.Panel12.TabIndex = 0
        '
        'rdbLado2
        '
        Me.rdbLado2.AutoSize = True
        Me.rdbLado2.Enabled = False
        Me.rdbLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLado2.Location = New System.Drawing.Point(70, 157)
        Me.rdbLado2.Name = "rdbLado2"
        Me.rdbLado2.Size = New System.Drawing.Size(82, 24)
        Me.rdbLado2.TabIndex = 10
        Me.rdbLado2.Text = "Lado 2"
        Me.rdbLado2.UseVisualStyleBackColor = True
        '
        'rdbLado1
        '
        Me.rdbLado1.AutoSize = True
        Me.rdbLado1.Checked = True
        Me.rdbLado1.Enabled = False
        Me.rdbLado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLado1.Location = New System.Drawing.Point(70, 116)
        Me.rdbLado1.Name = "rdbLado1"
        Me.rdbLado1.Size = New System.Drawing.Size(82, 24)
        Me.rdbLado1.TabIndex = 9
        Me.rdbLado1.TabStop = True
        Me.rdbLado1.Text = "Lado 1"
        Me.rdbLado1.UseVisualStyleBackColor = True
        '
        'txtKgsLado2
        '
        Me.txtKgsLado2.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsLado2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsLado2.Location = New System.Drawing.Point(168, 146)
        Me.txtKgsLado2.MaxLength = 6
        Me.txtKgsLado2.Name = "txtKgsLado2"
        Me.txtKgsLado2.ReadOnly = True
        Me.txtKgsLado2.Size = New System.Drawing.Size(104, 35)
        Me.txtKgsLado2.TabIndex = 8
        Me.txtKgsLado2.TabStop = False
        Me.txtKgsLado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgsLado1
        '
        Me.txtKgsLado1.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsLado1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsLado1.Location = New System.Drawing.Point(168, 105)
        Me.txtKgsLado1.MaxLength = 6
        Me.txtKgsLado1.Name = "txtKgsLado1"
        Me.txtKgsLado1.ReadOnly = True
        Me.txtKgsLado1.Size = New System.Drawing.Size(104, 35)
        Me.txtKgsLado1.TabIndex = 6
        Me.txtKgsLado1.TabStop = False
        Me.txtKgsLado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.OrangeRed
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.White
        Me.txtPeso.Location = New System.Drawing.Point(96, 41)
        Me.txtPeso.MaxLength = 8
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(181, 47)
        Me.txtPeso.TabIndex = 0
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(-2, 1)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(372, 23)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Información de la bascula"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(37, 98)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(68, 19)
        Me.lblDestino.TabIndex = 6
        Me.lblDestino.Text = "Destino"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Location = New System.Drawing.Point(19, 34)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(86, 19)
        Me.lblProd.TabIndex = 0
        Me.lblProd.Text = "Productor"
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(193, 63)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(339, 26)
        Me.txtNomIntroductor.TabIndex = 5
        '
        'lblIntr
        '
        Me.lblIntr.AutoSize = True
        Me.lblIntr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntr.Location = New System.Drawing.Point(11, 66)
        Me.lblIntr.Name = "lblIntr"
        Me.lblIntr.Size = New System.Drawing.Size(94, 19)
        Me.lblIntr.TabIndex = 3
        Me.lblIntr.Text = "Introductor"
        '
        'txtNomDestino
        '
        Me.txtNomDestino.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomDestino.Enabled = False
        Me.txtNomDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomDestino.Location = New System.Drawing.Point(193, 95)
        Me.txtNomDestino.MaxLength = 6
        Me.txtNomDestino.Name = "txtNomDestino"
        Me.txtNomDestino.Size = New System.Drawing.Size(339, 26)
        Me.txtNomDestino.TabIndex = 8
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(111, 63)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 4
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNomProductor
        '
        Me.txtNomProductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomProductor.Enabled = False
        Me.txtNomProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProductor.Location = New System.Drawing.Point(193, 31)
        Me.txtNomProductor.MaxLength = 6
        Me.txtNomProductor.Name = "txtNomProductor"
        Me.txtNomProductor.Size = New System.Drawing.Size(339, 26)
        Me.txtNomProductor.TabIndex = 2
        '
        'txtMarcaDestino
        '
        Me.txtMarcaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaDestino.Location = New System.Drawing.Point(111, 95)
        Me.txtMarcaDestino.MaxLength = 6
        Me.txtMarcaDestino.Name = "txtMarcaDestino"
        Me.txtMarcaDestino.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaDestino.TabIndex = 7
        Me.txtMarcaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaProductor
        '
        Me.txtMarcaProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaProductor.Location = New System.Drawing.Point(111, 30)
        Me.txtMarcaProductor.MaxLength = 6
        Me.txtMarcaProductor.Name = "txtMarcaProductor"
        Me.txtMarcaProductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaProductor.TabIndex = 1
        Me.txtMarcaProductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbProductos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(597, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 58)
        Me.Panel1.TabIndex = 3
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(148, 17)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(176, 24)
        Me.cmbProductos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(23, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Producto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(596, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 60)
        Me.Label4.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaProductor)
        Me.Panel2.Controls.Add(Me.txtMarcaDestino)
        Me.Panel2.Controls.Add(Me.txtNomProductor)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Controls.Add(Me.lblDestino)
        Me.Panel2.Controls.Add(Me.txtNomDestino)
        Me.Panel2.Controls.Add(Me.lblProd)
        Me.Panel2.Controls.Add(Me.lblIntr)
        Me.Panel2.Location = New System.Drawing.Point(12, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 130)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(578, 23)
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
        Me.Label6.Size = New System.Drawing.Size(580, 133)
        Me.Label6.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtLote)
        Me.Panel4.Location = New System.Drawing.Point(335, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(253, 95)
        Me.Panel4.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(-1, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(253, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lote"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(58, 39)
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
        Me.Label12.Location = New System.Drawing.Point(334, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(257, 97)
        Me.Label12.TabIndex = 33
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(987, 22)
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
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel5.Text = "F9|Imprimir"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel4.Text = "Supr|Cancelar animal"
        '
        'btnPesar
        '
        Me.btnPesar.FlatAppearance.BorderSize = 0
        Me.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesar.Location = New System.Drawing.Point(901, 471)
        Me.btnPesar.Name = "btnPesar"
        Me.btnPesar.Size = New System.Drawing.Size(71, 57)
        Me.btnPesar.TabIndex = 11
        Me.btnPesar.Text = "&Pesar"
        Me.btnPesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPesar.UseVisualStyleBackColor = True
        '
        'chkDecomiso
        '
        Me.chkDecomiso.AutoSize = True
        Me.chkDecomiso.BackColor = System.Drawing.Color.Red
        Me.chkDecomiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDecomiso.ForeColor = System.Drawing.Color.White
        Me.chkDecomiso.Location = New System.Drawing.Point(250, 101)
        Me.chkDecomiso.Name = "chkDecomiso"
        Me.chkDecomiso.Size = New System.Drawing.Size(113, 24)
        Me.chkDecomiso.TabIndex = 8
        Me.chkDecomiso.Text = "Decomisar"
        Me.chkDecomiso.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Guardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(824, 471)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 10
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
        Me.btnNuevo.Image = Global.SistemaControlProduccion.My.Resources.Resources.Nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(747, 471)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.chkPesarLado2)
        Me.Panel3.Controls.Add(Me.rdbVaquilla)
        Me.Panel3.Controls.Add(Me.rdbHembra)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.rdbMacho)
        Me.Panel3.Controls.Add(Me.chkEnmantado)
        Me.Panel3.Controls.Add(Me.chkVaciada)
        Me.Panel3.Controls.Add(Me.chkMayor)
        Me.Panel3.Controls.Add(Me.chkDecomiso)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(598, 76)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 167)
        Me.Panel3.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(232, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1, 99)
        Me.Label10.TabIndex = 6
        '
        'chkPesarLado2
        '
        Me.chkPesarLado2.Checked = True
        Me.chkPesarLado2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPesarLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPesarLado2.Location = New System.Drawing.Point(250, 46)
        Me.chkPesarLado2.Name = "chkPesarLado2"
        Me.chkPesarLado2.Size = New System.Drawing.Size(112, 39)
        Me.chkPesarLado2.TabIndex = 7
        Me.chkPesarLado2.Text = "Pesar Lado 1 y 2"
        Me.chkPesarLado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkPesarLado2.UseVisualStyleBackColor = True
        '
        'rdbVaquilla
        '
        Me.rdbVaquilla.AutoSize = True
        Me.rdbVaquilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVaquilla.Location = New System.Drawing.Point(10, 101)
        Me.rdbVaquilla.Name = "rdbVaquilla"
        Me.rdbVaquilla.Size = New System.Drawing.Size(91, 24)
        Me.rdbVaquilla.TabIndex = 2
        Me.rdbVaquilla.Text = "Vaquilla"
        Me.rdbVaquilla.UseVisualStyleBackColor = True
        '
        'rdbHembra
        '
        Me.rdbHembra.AutoSize = True
        Me.rdbHembra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbHembra.Location = New System.Drawing.Point(10, 71)
        Me.rdbHembra.Name = "rdbHembra"
        Me.rdbHembra.Size = New System.Drawing.Size(90, 24)
        Me.rdbHembra.TabIndex = 1
        Me.rdbHembra.Text = "Hembra"
        Me.rdbHembra.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1, 99)
        Me.Label5.TabIndex = 37
        '
        'rdbMacho
        '
        Me.rdbMacho.AutoSize = True
        Me.rdbMacho.Checked = True
        Me.rdbMacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMacho.Location = New System.Drawing.Point(7, 41)
        Me.rdbMacho.Name = "rdbMacho"
        Me.rdbMacho.Size = New System.Drawing.Size(80, 24)
        Me.rdbMacho.TabIndex = 0
        Me.rdbMacho.TabStop = True
        Me.rdbMacho.Text = "Macho"
        Me.rdbMacho.UseVisualStyleBackColor = True
        '
        'chkEnmantado
        '
        Me.chkEnmantado.AutoSize = True
        Me.chkEnmantado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnmantado.Location = New System.Drawing.Point(109, 101)
        Me.chkEnmantado.Name = "chkEnmantado"
        Me.chkEnmantado.Size = New System.Drawing.Size(120, 24)
        Me.chkEnmantado.TabIndex = 5
        Me.chkEnmantado.Text = "Enmantado"
        Me.chkEnmantado.UseVisualStyleBackColor = True
        '
        'chkVaciada
        '
        Me.chkVaciada.AutoSize = True
        Me.chkVaciada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVaciada.Location = New System.Drawing.Point(109, 71)
        Me.chkVaciada.Name = "chkVaciada"
        Me.chkVaciada.Size = New System.Drawing.Size(93, 24)
        Me.chkVaciada.TabIndex = 4
        Me.chkVaciada.Text = "Vaciada"
        Me.chkVaciada.UseVisualStyleBackColor = True
        '
        'chkMayor
        '
        Me.chkMayor.AutoSize = True
        Me.chkMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMayor.Location = New System.Drawing.Point(109, 41)
        Me.chkMayor.Name = "chkMayor"
        Me.chkMayor.Size = New System.Drawing.Size(77, 24)
        Me.chkMayor.TabIndex = 3
        Me.chkMayor.Text = "> 30m"
        Me.chkMayor.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(-1, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(372, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Caracteristicas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(596, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(376, 170)
        Me.Label9.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 278)
        Me.Label1.TabIndex = 57
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REN, Me.IDESCDataGridViewTextBoxColumn, Me.IDMOVDataGridViewTextBoxColumn, Me.IDALMDataGridViewTextBoxColumn, Me.FOLIODataGridViewTextBoxColumn, Me.IDCTEPRODDataGridViewTextBoxColumn, Me.MARCACTEPRODDataGridViewTextBoxColumn, Me.IDCTEINTRDataGridViewTextBoxColumn, Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.IDCTEDESTDataGridViewTextBoxColumn, Me.MARCACTEDESTDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.LOTEDataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.ESTATUSDataGridViewTextBoxColumn, Me.ID_ESD, Me.IDPRODDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.TARADataGridViewTextBoxColumn, Me.FECHAESDDataGridViewTextBoxColumn, Me.HORAESDDataGridViewTextBoxColumn, Me.CONSEC_DIA, Me.LADO, Me.SERIEDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.SEXODataGridViewTextBoxColumn, Me.MAYORDataGridViewTextBoxColumn, Me.VACIADADataGridViewTextBoxColumn, Me.ENMANTADODataGridViewTextBoxColumn, Me.DECOMISO, Me.ESTATUS_ESD})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL"
        Me.dgvDatos.DataSource = Me.DsSacrificio
        Me.dgvDatos.Location = New System.Drawing.Point(12, 251)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(579, 276)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 56
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'REN
        '
        Me.REN.Frozen = True
        Me.REN.HeaderText = "#"
        Me.REN.Name = "REN"
        Me.REN.ReadOnly = True
        Me.REN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REN.Width = 40
        '
        'IDESCDataGridViewTextBoxColumn
        '
        Me.IDESCDataGridViewTextBoxColumn.DataPropertyName = "ID_ESC"
        Me.IDESCDataGridViewTextBoxColumn.HeaderText = "ID_ESC"
        Me.IDESCDataGridViewTextBoxColumn.Name = "IDESCDataGridViewTextBoxColumn"
        Me.IDESCDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESCDataGridViewTextBoxColumn.Visible = False
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
        'FOLIODataGridViewTextBoxColumn
        '
        Me.FOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.Name = "FOLIODataGridViewTextBoxColumn"
        Me.FOLIODataGridViewTextBoxColumn.ReadOnly = True
        Me.FOLIODataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEPRODDataGridViewTextBoxColumn
        '
        Me.IDCTEPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn.HeaderText = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn.Name = "IDCTEPRODDataGridViewTextBoxColumn"
        Me.IDCTEPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEPRODDataGridViewTextBoxColumn
        '
        Me.MARCACTEPRODDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Name = "MARCACTEPRODDataGridViewTextBoxColumn"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEINTRDataGridViewTextBoxColumn
        '
        Me.IDCTEINTRDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn.HeaderText = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn.Name = "IDCTEINTRDataGridViewTextBoxColumn"
        Me.IDCTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEINTRDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEINTRDataGridViewTextBoxColumn
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Name = "MARCACTEINTRDataGridViewTextBoxColumn"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEDESTDataGridViewTextBoxColumn
        '
        Me.IDCTEDESTDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.HeaderText = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.Name = "IDCTEDESTDataGridViewTextBoxColumn"
        Me.IDCTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEDESTDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.HeaderText = "DESTINO"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Name = "MARCACTEDESTDataGridViewTextBoxColumn"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Width = 60
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn.Visible = False
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.ReadOnly = True
        Me.HORADataGridViewTextBoxColumn.Visible = False
        '
        'LOTEDataGridViewTextBoxColumn
        '
        Me.LOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.Name = "LOTEDataGridViewTextBoxColumn"
        Me.LOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOTEDataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Visible = False
        '
        'ESTATUSDataGridViewTextBoxColumn
        '
        Me.ESTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.Name = "ESTATUSDataGridViewTextBoxColumn"
        Me.ESTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'ID_ESD
        '
        Me.ID_ESD.DataPropertyName = "ID_ESD"
        Me.ID_ESD.HeaderText = "ID_ESD"
        Me.ID_ESD.Name = "ID_ESD"
        Me.ID_ESD.ReadOnly = True
        Me.ID_ESD.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn.Visible = False
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn.Visible = False
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn.Visible = False
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.FECHAESDDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHAESDDataGridViewTextBoxColumn.Name = "FECHAESDDataGridViewTextBoxColumn"
        Me.FECHAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAESDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FECHAESDDataGridViewTextBoxColumn.Width = 80
        '
        'HORAESDDataGridViewTextBoxColumn
        '
        Me.HORAESDDataGridViewTextBoxColumn.DataPropertyName = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORAESDDataGridViewTextBoxColumn.Name = "HORAESDDataGridViewTextBoxColumn"
        Me.HORAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAESDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.HORAESDDataGridViewTextBoxColumn.Width = 80
        '
        'CONSEC_DIA
        '
        Me.CONSEC_DIA.DataPropertyName = "CONSEC_DIA"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CONSEC_DIA.DefaultCellStyle = DataGridViewCellStyle3
        Me.CONSEC_DIA.HeaderText = "CONSEC. DIA"
        Me.CONSEC_DIA.Name = "CONSEC_DIA"
        Me.CONSEC_DIA.ReadOnly = True
        Me.CONSEC_DIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CONSEC_DIA.Width = 80
        '
        'LADO
        '
        Me.LADO.DataPropertyName = "LADO"
        Me.LADO.HeaderText = "LADO"
        Me.LADO.Name = "LADO"
        Me.LADO.ReadOnly = True
        Me.LADO.Width = 40
        '
        'SERIEDataGridViewTextBoxColumn
        '
        Me.SERIEDataGridViewTextBoxColumn.DataPropertyName = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.HeaderText = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.Name = "SERIEDataGridViewTextBoxColumn"
        Me.SERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SERIEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SERIEDataGridViewTextBoxColumn.Width = 50
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'SEXODataGridViewTextBoxColumn
        '
        Me.SEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.HeaderText = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.Name = "SEXODataGridViewTextBoxColumn"
        Me.SEXODataGridViewTextBoxColumn.ReadOnly = True
        Me.SEXODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SEXODataGridViewTextBoxColumn.Width = 60
        '
        'MAYORDataGridViewTextBoxColumn
        '
        Me.MAYORDataGridViewTextBoxColumn.DataPropertyName = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn.FalseValue = "0"
        Me.MAYORDataGridViewTextBoxColumn.HeaderText = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn.Name = "MAYORDataGridViewTextBoxColumn"
        Me.MAYORDataGridViewTextBoxColumn.ReadOnly = True
        Me.MAYORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MAYORDataGridViewTextBoxColumn.TrueValue = "1"
        Me.MAYORDataGridViewTextBoxColumn.Width = 60
        '
        'VACIADADataGridViewTextBoxColumn
        '
        Me.VACIADADataGridViewTextBoxColumn.DataPropertyName = "VACIADA"
        Me.VACIADADataGridViewTextBoxColumn.FalseValue = "0"
        Me.VACIADADataGridViewTextBoxColumn.HeaderText = "VACIADA"
        Me.VACIADADataGridViewTextBoxColumn.Name = "VACIADADataGridViewTextBoxColumn"
        Me.VACIADADataGridViewTextBoxColumn.ReadOnly = True
        Me.VACIADADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VACIADADataGridViewTextBoxColumn.TrueValue = "1"
        Me.VACIADADataGridViewTextBoxColumn.Width = 60
        '
        'ENMANTADODataGridViewTextBoxColumn
        '
        Me.ENMANTADODataGridViewTextBoxColumn.DataPropertyName = "ENMANTADO"
        Me.ENMANTADODataGridViewTextBoxColumn.FalseValue = "0"
        Me.ENMANTADODataGridViewTextBoxColumn.HeaderText = "ENMANTADO"
        Me.ENMANTADODataGridViewTextBoxColumn.Name = "ENMANTADODataGridViewTextBoxColumn"
        Me.ENMANTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ENMANTADODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENMANTADODataGridViewTextBoxColumn.TrueValue = "1"
        '
        'DECOMISO
        '
        Me.DECOMISO.DataPropertyName = "DECOMISO"
        Me.DECOMISO.FalseValue = "0"
        Me.DECOMISO.HeaderText = "DECOMISO"
        Me.DECOMISO.Name = "DECOMISO"
        Me.DECOMISO.ReadOnly = True
        Me.DECOMISO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DECOMISO.TrueValue = "1"
        Me.DECOMISO.Width = 60
        '
        'ESTATUS_ESD
        '
        Me.ESTATUS_ESD.DataPropertyName = "ESTATUS_ESD"
        Me.ESTATUS_ESD.HeaderText = "ESTATUS_ESD"
        Me.ESTATUS_ESD.Name = "ESTATUS_ESD"
        Me.ESTATUS_ESD.ReadOnly = True
        Me.ESTATUS_ESD.Visible = False
        '
        'frmPROC_Sacrificio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(987, 567)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "frmPROC_Sacrificio"
        Me.ShowInTaskbar = False
        Me.Text = "Registro de sacrificio en canal"
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents lblIntr As System.Windows.Forms.Label
    Friend WithEvents txtNomDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaProductor As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnPesar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkDecomiso As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkPesarLado2 As System.Windows.Forms.CheckBox
    Friend WithEvents rdbVaquilla As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHembra As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbMacho As System.Windows.Forms.RadioButton
    Friend WithEvents chkEnmantado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVaciada As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayor As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKgsLado2 As System.Windows.Forms.TextBox
    Friend WithEvents txtKgsLado1 As System.Windows.Forms.TextBox
    Friend WithEvents rdbLado2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLado1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents REN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSEC_DIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAYORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VACIADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ENMANTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DECOMISO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ESTATUS_ESD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
