<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_SacrificioSospechos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPROC_SacrificioSospechos))
        Me.txtNomMovto = New System.Windows.Forms.TextBox()
        Me.txtIdMovto = New System.Windows.Forms.TextBox()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.rdbLado2 = New System.Windows.Forms.RadioButton()
        Me.rdbLado1 = New System.Windows.Forms.RadioButton()
        Me.txtKgsLado2 = New System.Windows.Forms.TextBox()
        Me.txtKgsLado1 = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
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
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
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
        Me.chkingesta = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttemperatura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkPesarLado2 = New System.Windows.Forms.CheckBox()
        Me.rdbVaquilla = New System.Windows.Forms.RadioButton()
        Me.rdbHembra = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbMacho = New System.Windows.Forms.RadioButton()
        Me.chkEnmantado = New System.Windows.Forms.CheckBox()
        Me.chkVaciada = New System.Windows.Forms.CheckBox()
        Me.chkMayor = New System.Windows.Forms.CheckBox()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAYORDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VACIADADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECDIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMPERATURADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REVCALIDADDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
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
        Me.REV_CALIDAD = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnguardarlotefecha = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CHKSOSPECHOSO = New System.Windows.Forms.CheckBox()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        'rdbLado2
        '
        Me.rdbLado2.AutoSize = True
        Me.rdbLado2.Enabled = False
        Me.rdbLado2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLado2.Location = New System.Drawing.Point(457, 32)
        Me.rdbLado2.Name = "rdbLado2"
        Me.rdbLado2.Size = New System.Drawing.Size(77, 27)
        Me.rdbLado2.TabIndex = 10
        Me.rdbLado2.Text = "Lado 2"
        Me.rdbLado2.UseVisualStyleBackColor = True
        '
        'rdbLado1
        '
        Me.rdbLado1.AutoSize = True
        Me.rdbLado1.Checked = True
        Me.rdbLado1.Enabled = False
        Me.rdbLado1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLado1.Location = New System.Drawing.Point(204, 32)
        Me.rdbLado1.Name = "rdbLado1"
        Me.rdbLado1.Size = New System.Drawing.Size(77, 27)
        Me.rdbLado1.TabIndex = 9
        Me.rdbLado1.TabStop = True
        Me.rdbLado1.Text = "Lado 1"
        Me.rdbLado1.UseVisualStyleBackColor = True
        '
        'txtKgsLado2
        '
        Me.txtKgsLado2.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsLado2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsLado2.Location = New System.Drawing.Point(551, 19)
        Me.txtKgsLado2.MaxLength = 6
        Me.txtKgsLado2.Name = "txtKgsLado2"
        Me.txtKgsLado2.ReadOnly = True
        Me.txtKgsLado2.Size = New System.Drawing.Size(141, 48)
        Me.txtKgsLado2.TabIndex = 8
        Me.txtKgsLado2.TabStop = False
        Me.txtKgsLado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgsLado1
        '
        Me.txtKgsLado1.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsLado1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsLado1.Location = New System.Drawing.Point(291, 18)
        Me.txtKgsLado1.MaxLength = 6
        Me.txtKgsLado1.Name = "txtKgsLado1"
        Me.txtKgsLado1.ReadOnly = True
        Me.txtKgsLado1.Size = New System.Drawing.Size(141, 48)
        Me.txtKgsLado1.TabIndex = 6
        Me.txtKgsLado1.TabStop = False
        Me.txtKgsLado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.OrangeRed
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.White
        Me.txtPeso.Location = New System.Drawing.Point(6, 19)
        Me.txtPeso.MaxLength = 8
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(181, 47)
        Me.txtPeso.TabIndex = 0
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Location = New System.Drawing.Point(13, 63)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(76, 18)
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
        Me.txtNomProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProductor.Location = New System.Drawing.Point(187, 60)
        Me.txtNomProductor.MaxLength = 6
        Me.txtNomProductor.Name = "txtNomProductor"
        Me.txtNomProductor.Size = New System.Drawing.Size(426, 26)
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
        Me.txtMarcaProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaProductor.Location = New System.Drawing.Point(105, 59)
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
        Me.Panel8.Controls.Add(Me.txtIdMovto)
        Me.Panel8.Controls.Add(Me.lblProductor)
        Me.Panel8.Controls.Add(Me.txtNomMovto)
        Me.Panel8.Location = New System.Drawing.Point(1145, 251)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(83, 55)
        Me.Panel8.TabIndex = 0
        Me.Panel8.Visible = False
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
        Me.dtpFechaMov.Location = New System.Drawing.Point(457, 16)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(156, 26)
        Me.dtpFechaMov.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1144, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 57)
        Me.Label13.TabIndex = 26
        Me.Label13.Visible = False
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(105, 19)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(176, 24)
        Me.cmbProductos.TabIndex = 2
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
        Me.Panel2.Location = New System.Drawing.Point(866, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(83, 68)
        Me.Panel2.TabIndex = 4
        Me.Panel2.Visible = False
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
        Me.Label6.Location = New System.Drawing.Point(865, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 71)
        Me.Label6.TabIndex = 4
        Me.Label6.Visible = False
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(333, 17)
        Me.txtLote.MaxLength = 6
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(76, 26)
        Me.txtLote.TabIndex = 1
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
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
        Me.btnPesar.Image = Global.SistemaControlProduccion.My.Resources.Resources.bascula4
        Me.btnPesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesar.Location = New System.Drawing.Point(1167, 438)
        Me.btnPesar.Name = "btnPesar"
        Me.btnPesar.Size = New System.Drawing.Size(71, 57)
        Me.btnPesar.TabIndex = 11
        Me.btnPesar.Text = "&Pesar"
        Me.btnPesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPesar.UseVisualStyleBackColor = True
        Me.btnPesar.Visible = False
        '
        'chkDecomiso
        '
        Me.chkDecomiso.AutoSize = True
        Me.chkDecomiso.BackColor = System.Drawing.Color.Transparent
        Me.chkDecomiso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDecomiso.ForeColor = System.Drawing.Color.Black
        Me.chkDecomiso.Location = New System.Drawing.Point(386, 80)
        Me.chkDecomiso.Name = "chkDecomiso"
        Me.chkDecomiso.Size = New System.Drawing.Size(104, 22)
        Me.chkDecomiso.TabIndex = 8
        Me.chkDecomiso.Text = "Decomisar"
        Me.chkDecomiso.UseVisualStyleBackColor = False
        Me.chkDecomiso.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(1090, 438)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SistemaControlProduccion.My.Resources.Resources.new_doc
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(1013, 438)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        Me.btnNuevo.Visible = False
        '
        'chkingesta
        '
        Me.chkingesta.AutoSize = True
        Me.chkingesta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkingesta.Location = New System.Drawing.Point(386, 48)
        Me.chkingesta.Name = "chkingesta"
        Me.chkingesta.Size = New System.Drawing.Size(77, 22)
        Me.chkingesta.TabIndex = 38
        Me.chkingesta.Text = "Ingesta"
        Me.chkingesta.UseVisualStyleBackColor = True
        Me.chkingesta.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(563, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 23)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Temperatura:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label14.Visible = False
        '
        'txttemperatura
        '
        Me.txttemperatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttemperatura.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttemperatura.Location = New System.Drawing.Point(580, 49)
        Me.txttemperatura.MaxLength = 6
        Me.txttemperatura.Name = "txttemperatura"
        Me.txttemperatura.Size = New System.Drawing.Size(125, 32)
        Me.txttemperatura.TabIndex = 2
        Me.txttemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttemperatura.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(380, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1, 99)
        Me.Label10.TabIndex = 6
        Me.Label10.Visible = False
        '
        'chkPesarLado2
        '
        Me.chkPesarLado2.Checked = True
        Me.chkPesarLado2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPesarLado2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPesarLado2.Location = New System.Drawing.Point(386, 9)
        Me.chkPesarLado2.Name = "chkPesarLado2"
        Me.chkPesarLado2.Size = New System.Drawing.Size(169, 39)
        Me.chkPesarLado2.TabIndex = 7
        Me.chkPesarLado2.Text = "Pesar Lado 1 y 2"
        Me.chkPesarLado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkPesarLado2.UseVisualStyleBackColor = True
        Me.chkPesarLado2.Visible = False
        '
        'rdbVaquilla
        '
        Me.rdbVaquilla.AutoSize = True
        Me.rdbVaquilla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVaquilla.Location = New System.Drawing.Point(1186, 189)
        Me.rdbVaquilla.Name = "rdbVaquilla"
        Me.rdbVaquilla.Size = New System.Drawing.Size(81, 22)
        Me.rdbVaquilla.TabIndex = 2
        Me.rdbVaquilla.Text = "Vaquilla"
        Me.rdbVaquilla.UseVisualStyleBackColor = True
        Me.rdbVaquilla.Visible = False
        '
        'rdbHembra
        '
        Me.rdbHembra.AutoSize = True
        Me.rdbHembra.Enabled = False
        Me.rdbHembra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbHembra.Location = New System.Drawing.Point(6, 65)
        Me.rdbHembra.Name = "rdbHembra"
        Me.rdbHembra.Size = New System.Drawing.Size(82, 22)
        Me.rdbHembra.TabIndex = 1
        Me.rdbHembra.Text = "Hembra"
        Me.rdbHembra.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1, 99)
        Me.Label5.TabIndex = 37
        Me.Label5.Visible = False
        '
        'rdbMacho
        '
        Me.rdbMacho.AutoSize = True
        Me.rdbMacho.Checked = True
        Me.rdbMacho.Enabled = False
        Me.rdbMacho.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMacho.Location = New System.Drawing.Point(6, 25)
        Me.rdbMacho.Name = "rdbMacho"
        Me.rdbMacho.Size = New System.Drawing.Size(73, 22)
        Me.rdbMacho.TabIndex = 0
        Me.rdbMacho.TabStop = True
        Me.rdbMacho.Text = "Macho"
        Me.rdbMacho.UseVisualStyleBackColor = True
        '
        'chkEnmantado
        '
        Me.chkEnmantado.AutoSize = True
        Me.chkEnmantado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnmantado.Location = New System.Drawing.Point(272, 80)
        Me.chkEnmantado.Name = "chkEnmantado"
        Me.chkEnmantado.Size = New System.Drawing.Size(77, 22)
        Me.chkEnmantado.TabIndex = 5
        Me.chkEnmantado.Text = "Kosher"
        Me.chkEnmantado.UseVisualStyleBackColor = True
        Me.chkEnmantado.Visible = False
        '
        'chkVaciada
        '
        Me.chkVaciada.AutoSize = True
        Me.chkVaciada.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVaciada.Location = New System.Drawing.Point(272, 49)
        Me.chkVaciada.Name = "chkVaciada"
        Me.chkVaciada.Size = New System.Drawing.Size(85, 22)
        Me.chkVaciada.TabIndex = 4
        Me.chkVaciada.Text = "Vaciada"
        Me.chkVaciada.UseVisualStyleBackColor = True
        Me.chkVaciada.Visible = False
        '
        'chkMayor
        '
        Me.chkMayor.AutoSize = True
        Me.chkMayor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMayor.Location = New System.Drawing.Point(272, 19)
        Me.chkMayor.Name = "chkMayor"
        Me.chkMayor.Size = New System.Drawing.Size(71, 22)
        Me.chkMayor.TabIndex = 3
        Me.chkMayor.Text = "> 30m"
        Me.chkMayor.UseVisualStyleBackColor = True
        Me.chkMayor.Visible = False
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
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.NOMPRODDataGridViewTextBoxColumn1, Me.SEXO, Me.PESODataGridViewTextBoxColumn1, Me.HORADataGridViewTextBoxColumn1, Me.MARCACTEINTRDataGridViewTextBoxColumn1, Me.MARCACTEDESTDataGridViewTextBoxColumn1, Me.SERIEDataGridViewTextBoxColumn1, Me.IDDataGridViewTextBoxColumn1, Me.SEXODataGridViewTextBoxColumn1, Me.MAYORDataGridViewTextBoxColumn1, Me.VACIADADataGridViewTextBoxColumn1, Me.CONSECDIADataGridViewTextBoxColumn, Me.LADODataGridViewTextBoxColumn, Me.TEMPERATURADataGridViewTextBoxColumn, Me.REVCALIDADDataGridViewCheckBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ESTATUS})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL"
        Me.dgvDatos.DataSource = Me.DsSacrificio
        Me.dgvDatos.Location = New System.Drawing.Point(12, 242)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(1346, 276)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_ESD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_ESD"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NOMPRODDataGridViewTextBoxColumn1
        '
        Me.NOMPRODDataGridViewTextBoxColumn1.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn1.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn1.Name = "NOMPRODDataGridViewTextBoxColumn1"
        Me.NOMPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn1.Width = 180
        '
        'SEXO
        '
        Me.SEXO.DataPropertyName = "SEXO"
        Me.SEXO.HeaderText = "SEXO"
        Me.SEXO.Name = "SEXO"
        Me.SEXO.ReadOnly = True
        Me.SEXO.Visible = False
        '
        'PESODataGridViewTextBoxColumn1
        '
        Me.PESODataGridViewTextBoxColumn1.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn1.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn1.Name = "PESODataGridViewTextBoxColumn1"
        Me.PESODataGridViewTextBoxColumn1.ReadOnly = True
        '
        'HORADataGridViewTextBoxColumn1
        '
        Me.HORADataGridViewTextBoxColumn1.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn1.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn1.Name = "HORADataGridViewTextBoxColumn1"
        Me.HORADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MARCACTEINTRDataGridViewTextBoxColumn1
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.HeaderText = "MARCA INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.Name = "MARCACTEINTRDataGridViewTextBoxColumn1"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MARCACTEDESTDataGridViewTextBoxColumn1
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.HeaderText = "MARCA DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Name = "MARCACTEDESTDataGridViewTextBoxColumn1"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SERIEDataGridViewTextBoxColumn1
        '
        Me.SERIEDataGridViewTextBoxColumn1.DataPropertyName = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn1.HeaderText = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn1.Name = "SERIEDataGridViewTextBoxColumn1"
        Me.SERIEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SERIEDataGridViewTextBoxColumn1.Width = 50
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SEXODataGridViewTextBoxColumn1
        '
        Me.SEXODataGridViewTextBoxColumn1.DataPropertyName = "SEXO"
        Me.SEXODataGridViewTextBoxColumn1.HeaderText = "SEXO"
        Me.SEXODataGridViewTextBoxColumn1.Name = "SEXODataGridViewTextBoxColumn1"
        Me.SEXODataGridViewTextBoxColumn1.ReadOnly = True
        Me.SEXODataGridViewTextBoxColumn1.Width = 50
        '
        'MAYORDataGridViewTextBoxColumn1
        '
        Me.MAYORDataGridViewTextBoxColumn1.DataPropertyName = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn1.HeaderText = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn1.Name = "MAYORDataGridViewTextBoxColumn1"
        Me.MAYORDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MAYORDataGridViewTextBoxColumn1.Width = 50
        '
        'VACIADADataGridViewTextBoxColumn1
        '
        Me.VACIADADataGridViewTextBoxColumn1.DataPropertyName = "VACIADA"
        Me.VACIADADataGridViewTextBoxColumn1.HeaderText = "VACIADA"
        Me.VACIADADataGridViewTextBoxColumn1.Name = "VACIADADataGridViewTextBoxColumn1"
        Me.VACIADADataGridViewTextBoxColumn1.ReadOnly = True
        Me.VACIADADataGridViewTextBoxColumn1.Width = 70
        '
        'CONSECDIADataGridViewTextBoxColumn
        '
        Me.CONSECDIADataGridViewTextBoxColumn.DataPropertyName = "CONSEC_DIA"
        Me.CONSECDIADataGridViewTextBoxColumn.HeaderText = "CONSEC_DIA"
        Me.CONSECDIADataGridViewTextBoxColumn.Name = "CONSECDIADataGridViewTextBoxColumn"
        Me.CONSECDIADataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSECDIADataGridViewTextBoxColumn.Width = 80
        '
        'LADODataGridViewTextBoxColumn
        '
        Me.LADODataGridViewTextBoxColumn.DataPropertyName = "LADO"
        Me.LADODataGridViewTextBoxColumn.HeaderText = "LADO"
        Me.LADODataGridViewTextBoxColumn.Name = "LADODataGridViewTextBoxColumn"
        Me.LADODataGridViewTextBoxColumn.ReadOnly = True
        Me.LADODataGridViewTextBoxColumn.Width = 50
        '
        'TEMPERATURADataGridViewTextBoxColumn
        '
        Me.TEMPERATURADataGridViewTextBoxColumn.DataPropertyName = "TEMPERATURA"
        Me.TEMPERATURADataGridViewTextBoxColumn.HeaderText = "TEMPERATURA"
        Me.TEMPERATURADataGridViewTextBoxColumn.Name = "TEMPERATURADataGridViewTextBoxColumn"
        Me.TEMPERATURADataGridViewTextBoxColumn.ReadOnly = True
        '
        'REVCALIDADDataGridViewCheckBoxColumn
        '
        Me.REVCALIDADDataGridViewCheckBoxColumn.DataPropertyName = "REV_CALIDAD"
        Me.REVCALIDADDataGridViewCheckBoxColumn.HeaderText = "REV_CALIDAD"
        Me.REVCALIDADDataGridViewCheckBoxColumn.Name = "REVCALIDADDataGridViewCheckBoxColumn"
        Me.REVCALIDADDataGridViewCheckBoxColumn.ReadOnly = True
        Me.REVCALIDADDataGridViewCheckBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ESTATUS_ESD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ESTATUS_ESD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DECOMISO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DECOMISO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'ESTATUS
        '
        Me.ESTATUS.DataPropertyName = "ESTATUS"
        Me.ESTATUS.HeaderText = "ESTATUS"
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
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
        Me.REN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.REN.Width = 40
        '
        'IDESCDataGridViewTextBoxColumn
        '
        Me.IDESCDataGridViewTextBoxColumn.DataPropertyName = "ID_ESC"
        Me.IDESCDataGridViewTextBoxColumn.HeaderText = "ID_ESC"
        Me.IDESCDataGridViewTextBoxColumn.Name = "IDESCDataGridViewTextBoxColumn"
        Me.IDESCDataGridViewTextBoxColumn.Visible = False
        '
        'IDMOVDataGridViewTextBoxColumn
        '
        Me.IDMOVDataGridViewTextBoxColumn.DataPropertyName = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.HeaderText = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.Name = "IDMOVDataGridViewTextBoxColumn"
        Me.IDMOVDataGridViewTextBoxColumn.Visible = False
        '
        'IDALMDataGridViewTextBoxColumn
        '
        Me.IDALMDataGridViewTextBoxColumn.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.Name = "IDALMDataGridViewTextBoxColumn"
        Me.IDALMDataGridViewTextBoxColumn.Visible = False
        '
        'FOLIODataGridViewTextBoxColumn
        '
        Me.FOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.Name = "FOLIODataGridViewTextBoxColumn"
        Me.FOLIODataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEPRODDataGridViewTextBoxColumn
        '
        Me.IDCTEPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn.HeaderText = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn.Name = "IDCTEPRODDataGridViewTextBoxColumn"
        Me.IDCTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEPRODDataGridViewTextBoxColumn
        '
        Me.MARCACTEPRODDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Name = "MARCACTEPRODDataGridViewTextBoxColumn"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEINTRDataGridViewTextBoxColumn
        '
        Me.IDCTEINTRDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn.HeaderText = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn.Name = "IDCTEINTRDataGridViewTextBoxColumn"
        Me.IDCTEINTRDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEINTRDataGridViewTextBoxColumn
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Name = "MARCACTEINTRDataGridViewTextBoxColumn"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEDESTDataGridViewTextBoxColumn
        '
        Me.IDCTEDESTDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.HeaderText = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.Name = "IDCTEDESTDataGridViewTextBoxColumn"
        Me.IDCTEDESTDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.HeaderText = "DESTINO"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Name = "MARCACTEDESTDataGridViewTextBoxColumn"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Width = 60
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.Visible = False
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.Visible = False
        '
        'LOTEDataGridViewTextBoxColumn
        '
        Me.LOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.Name = "LOTEDataGridViewTextBoxColumn"
        Me.LOTEDataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Visible = False
        '
        'ESTATUSDataGridViewTextBoxColumn
        '
        Me.ESTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.Name = "ESTATUSDataGridViewTextBoxColumn"
        Me.ESTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'ID_ESD
        '
        Me.ID_ESD.DataPropertyName = "ID_ESD"
        Me.ID_ESD.HeaderText = "ID_ESD"
        Me.ID_ESD.Name = "ID_ESD"
        Me.ID_ESD.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.Visible = False
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.Visible = False
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.Visible = False
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PESODataGridViewTextBoxColumn.Width = 70
        '
        'TARADataGridViewTextBoxColumn
        '
        Me.TARADataGridViewTextBoxColumn.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn.Name = "TARADataGridViewTextBoxColumn"
        Me.TARADataGridViewTextBoxColumn.Visible = False
        '
        'FECHAESDDataGridViewTextBoxColumn
        '
        Me.FECHAESDDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHAESDDataGridViewTextBoxColumn.Name = "FECHAESDDataGridViewTextBoxColumn"
        Me.FECHAESDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FECHAESDDataGridViewTextBoxColumn.Width = 80
        '
        'HORAESDDataGridViewTextBoxColumn
        '
        Me.HORAESDDataGridViewTextBoxColumn.DataPropertyName = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORAESDDataGridViewTextBoxColumn.Name = "HORAESDDataGridViewTextBoxColumn"
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
        Me.CONSEC_DIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CONSEC_DIA.Width = 80
        '
        'LADO
        '
        Me.LADO.DataPropertyName = "LADO"
        Me.LADO.HeaderText = "LADO"
        Me.LADO.Name = "LADO"
        Me.LADO.Width = 40
        '
        'SERIEDataGridViewTextBoxColumn
        '
        Me.SERIEDataGridViewTextBoxColumn.DataPropertyName = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.HeaderText = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.Name = "SERIEDataGridViewTextBoxColumn"
        Me.SERIEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SERIEDataGridViewTextBoxColumn.Width = 50
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'SEXODataGridViewTextBoxColumn
        '
        Me.SEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.HeaderText = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.Name = "SEXODataGridViewTextBoxColumn"
        Me.SEXODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SEXODataGridViewTextBoxColumn.Width = 60
        '
        'MAYORDataGridViewTextBoxColumn
        '
        Me.MAYORDataGridViewTextBoxColumn.DataPropertyName = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn.FalseValue = "0"
        Me.MAYORDataGridViewTextBoxColumn.HeaderText = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn.Name = "MAYORDataGridViewTextBoxColumn"
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
        Me.ENMANTADODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENMANTADODataGridViewTextBoxColumn.TrueValue = "1"
        '
        'DECOMISO
        '
        Me.DECOMISO.DataPropertyName = "DECOMISO"
        Me.DECOMISO.FalseValue = "0"
        Me.DECOMISO.HeaderText = "DECOMISO"
        Me.DECOMISO.Name = "DECOMISO"
        Me.DECOMISO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DECOMISO.TrueValue = "1"
        Me.DECOMISO.Width = 60
        '
        'ESTATUS_ESD
        '
        Me.ESTATUS_ESD.DataPropertyName = "ESTATUS_ESD"
        Me.ESTATUS_ESD.HeaderText = "ESTATUS_ESD"
        Me.ESTATUS_ESD.Name = "ESTATUS_ESD"
        Me.ESTATUS_ESD.Visible = False
        '
        'REV_CALIDAD
        '
        Me.REV_CALIDAD.DataPropertyName = "ID_ESC"
        Me.REV_CALIDAD.HeaderText = "REV_CALIDAD"
        Me.REV_CALIDAD.Name = "REV_CALIDAD"
        Me.REV_CALIDAD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.REV_CALIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.btnguardarlotefecha})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 39)
        Me.ToolStrip1.TabIndex = 58
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_New_32x32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnguardarlotefecha
        '
        Me.btnguardarlotefecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnguardarlotefecha.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_Save_32x32
        Me.btnguardarlotefecha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnguardarlotefecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnguardarlotefecha.Name = "btnguardarlotefecha"
        Me.btnguardarlotefecha.Size = New System.Drawing.Size(36, 36)
        Me.btnguardarlotefecha.Text = "ToolStripButton1"
        Me.btnguardarlotefecha.ToolTipText = "Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNomProductor)
        Me.GroupBox1.Controls.Add(Me.dtpFechaMov)
        Me.GroupBox1.Controls.Add(Me.lblProd)
        Me.GroupBox1.Controls.Add(Me.txtMarcaProductor)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.cmbProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 109)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del lote"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(415, 15)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(36, 32)
        Me.SimpleButton1.TabIndex = 56
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.txtKgsLado1)
        Me.GroupBox2.Controls.Add(Me.rdbLado1)
        Me.GroupBox2.Controls.Add(Me.rdbLado2)
        Me.GroupBox2.Controls.Add(Me.txtKgsLado2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1346, 79)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Peso"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.CHKSOSPECHOSO)
        Me.GroupBox3.Controls.Add(Me.chkMayor)
        Me.GroupBox3.Controls.Add(Me.chkVaciada)
        Me.GroupBox3.Controls.Add(Me.chkEnmantado)
        Me.GroupBox3.Controls.Add(Me.rdbMacho)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txttemperatura)
        Me.GroupBox3.Controls.Add(Me.chkingesta)
        Me.GroupBox3.Controls.Add(Me.rdbHembra)
        Me.GroupBox3.Controls.Add(Me.chkDecomiso)
        Me.GroupBox3.Controls.Add(Me.chkPesarLado2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(647, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(711, 109)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del registro"
        '
        'CHKSOSPECHOSO
        '
        Me.CHKSOSPECHOSO.AutoSize = True
        Me.CHKSOSPECHOSO.Checked = True
        Me.CHKSOSPECHOSO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKSOSPECHOSO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSOSPECHOSO.Location = New System.Drawing.Point(104, 48)
        Me.CHKSOSPECHOSO.Name = "CHKSOSPECHOSO"
        Me.CHKSOSPECHOSO.Size = New System.Drawing.Size(141, 22)
        Me.CHKSOSPECHOSO.TabIndex = 39
        Me.CHKSOSPECHOSO.Text = "SOSPECHOSO"
        Me.CHKSOSPECHOSO.UseVisualStyleBackColor = True
        '
        'frmPROC_SacrificioSospechos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 567)
        Me.Controls.Add(Me.rdbVaquilla)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnPesar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPROC_SacrificioSospechos"
        Me.ShowInTaskbar = False
        Me.Text = "Registro de sacrificio en canal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomMovto As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMovto As System.Windows.Forms.TextBox
    Friend WithEvents lblProductor As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkPesarLado2 As System.Windows.Forms.CheckBox
    Friend WithEvents rdbVaquilla As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHembra As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbMacho As System.Windows.Forms.RadioButton
    Friend WithEvents chkEnmantado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVaciada As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayor As System.Windows.Forms.CheckBox
    Friend WithEvents txtKgsLado2 As System.Windows.Forms.TextBox
    Friend WithEvents txtKgsLado1 As System.Windows.Forms.TextBox
    Friend WithEvents rdbLado2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLado1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txttemperatura As System.Windows.Forms.TextBox
    Friend WithEvents chkingesta As System.Windows.Forms.CheckBox
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
    Friend WithEvents REV_CALIDAD As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnguardarlotefecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAYORDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VACIADADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECDIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEMPERATURADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REVCALIDADDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHKSOSPECHOSO As System.Windows.Forms.CheckBox
End Class
