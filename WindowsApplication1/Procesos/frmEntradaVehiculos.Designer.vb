<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaVehiculos
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNomProveedor = New System.Windows.Forms.TextBox()
        Me.txtMarcaProveedor = New System.Windows.Forms.TextBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtNomProductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaProductor = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIntroductor = New System.Windows.Forms.Label()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.cmbTipoEntrada = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblPesadaManual = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.panelGanado = New System.Windows.Forms.Panel()
        Me.txtPesoGuia = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNumGuia = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.txtMachos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHembras = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotalCabezas = New System.Windows.Forms.TextBox()
        Me.txtVaquillas = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblHembras = New System.Windows.Forms.Label()
        Me.txtToretes = New System.Windows.Forms.TextBox()
        Me.lblMachos = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotalCabezasGuia = New System.Windows.Forms.TextBox()
        Me.txtNumHembrasGuia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumMachosGuia = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFleje = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCZM = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCorrales = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoGanado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbMarcaVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.txtPlacas = New System.Windows.Forms.TextBox()
        Me.txtConductor = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtKgsNeto = New System.Windows.Forms.TextBox()
        Me.txtKgsSalida = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtKgsEntrada = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPesar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panelGanado.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(191, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 19)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Tipo de entrada"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos generales para registro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNomProveedor)
        Me.Panel1.Controls.Add(Me.txtMarcaProveedor)
        Me.Panel1.Controls.Add(Me.lblProveedor)
        Me.Panel1.Controls.Add(Me.txtFolio)
        Me.Panel1.Controls.Add(Me.txtOrigen)
        Me.Panel1.Controls.Add(Me.txtNomIntroductor)
        Me.Panel1.Controls.Add(Me.txtNomProductor)
        Me.Panel1.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel1.Controls.Add(Me.txtMarcaProductor)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblIntroductor)
        Me.Panel1.Controls.Add(Me.lblProductor)
        Me.Panel1.Controls.Add(Me.cmbTipoEntrada)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 161)
        Me.Panel1.TabIndex = 0
        '
        'txtNomProveedor
        '
        Me.txtNomProveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProveedor.Location = New System.Drawing.Point(191, 79)
        Me.txtNomProveedor.MaxLength = 6
        Me.txtNomProveedor.Name = "txtNomProveedor"
        Me.txtNomProveedor.ReadOnly = True
        Me.txtNomProveedor.Size = New System.Drawing.Size(396, 26)
        Me.txtNomProveedor.TabIndex = 9
        Me.txtNomProveedor.TabStop = False
        Me.txtNomProveedor.Visible = False
        '
        'txtMarcaProveedor
        '
        Me.txtMarcaProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaProveedor.Location = New System.Drawing.Point(109, 79)
        Me.txtMarcaProveedor.MaxLength = 6
        Me.txtMarcaProveedor.Name = "txtMarcaProveedor"
        Me.txtMarcaProveedor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaProveedor.TabIndex = 8
        Me.txtMarcaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMarcaProveedor.Visible = False
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(17, 82)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(89, 19)
        Me.lblProveedor.TabIndex = 7
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.Visible = False
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(109, 31)
        Me.txtFolio.MaxLength = 6
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(76, 26)
        Me.txtFolio.TabIndex = 0
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOrigen
        '
        Me.txtOrigen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.Location = New System.Drawing.Point(109, 127)
        Me.txtOrigen.MaxLength = 40
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(478, 26)
        Me.txtOrigen.TabIndex = 14
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(191, 95)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.ReadOnly = True
        Me.txtNomIntroductor.Size = New System.Drawing.Size(396, 26)
        Me.txtNomIntroductor.TabIndex = 12
        Me.txtNomIntroductor.TabStop = False
        '
        'txtNomProductor
        '
        Me.txtNomProductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProductor.Location = New System.Drawing.Point(191, 63)
        Me.txtNomProductor.MaxLength = 6
        Me.txtNomProductor.Name = "txtNomProductor"
        Me.txtNomProductor.ReadOnly = True
        Me.txtNomProductor.Size = New System.Drawing.Size(396, 26)
        Me.txtNomProductor.TabIndex = 6
        Me.txtNomProductor.TabStop = False
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(109, 95)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 11
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaProductor
        '
        Me.txtMarcaProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaProductor.Location = New System.Drawing.Point(109, 63)
        Me.txtMarcaProductor.MaxLength = 6
        Me.txtMarcaProductor.Name = "txtMarcaProductor"
        Me.txtMarcaProductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaProductor.TabIndex = 5
        Me.txtMarcaProductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(43, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 19)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Folio"
        '
        'lblIntroductor
        '
        Me.lblIntroductor.AutoSize = True
        Me.lblIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntroductor.Location = New System.Drawing.Point(9, 98)
        Me.lblIntroductor.Name = "lblIntroductor"
        Me.lblIntroductor.Size = New System.Drawing.Size(94, 19)
        Me.lblIntroductor.TabIndex = 10
        Me.lblIntroductor.Text = "Introductor"
        '
        'lblProductor
        '
        Me.lblProductor.AutoSize = True
        Me.lblProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductor.Location = New System.Drawing.Point(17, 66)
        Me.lblProductor.Name = "lblProductor"
        Me.lblProductor.Size = New System.Drawing.Size(86, 19)
        Me.lblProductor.TabIndex = 4
        Me.lblProductor.Text = "Productor"
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.DataSource = Me.DsCatalogos
        Me.cmbTipoEntrada.DisplayMember = "SP_CONS_TIPOS_ENTRADA_VEHICULOS.NOMBRE"
        Me.cmbTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.FormattingEnabled = True
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(325, 33)
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(262, 24)
        Me.cmbTipoEntrada.TabIndex = 3
        Me.cmbTipoEntrada.ValueMember = "SP_CONS_TIPOS_ENTRADA_VEHICULOS.ID"
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 165)
        Me.Panel2.TabIndex = 0
        '
        'lblEstatus
        '
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.Location = New System.Drawing.Point(4, 30)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(346, 23)
        Me.lblEstatus.TabIndex = 62
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Maroon
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(639, 12)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(359, 166)
        Me.Panel7.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblPesadaManual)
        Me.Panel8.Controls.Add(Me.lblEstatus)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.dtpHoraSalida)
        Me.Panel8.Controls.Add(Me.dtpFechaSalida)
        Me.Panel8.Controls.Add(Me.dtpHoraEntrada)
        Me.Panel8.Controls.Add(Me.dtpFechaEntrada)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(1, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(355, 161)
        Me.Panel8.TabIndex = 45
        '
        'lblPesadaManual
        '
        Me.lblPesadaManual.BackColor = System.Drawing.Color.Yellow
        Me.lblPesadaManual.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesadaManual.Location = New System.Drawing.Point(4, 129)
        Me.lblPesadaManual.Name = "lblPesadaManual"
        Me.lblPesadaManual.Size = New System.Drawing.Size(343, 23)
        Me.lblPesadaManual.TabIndex = 69
        Me.lblPesadaManual.Text = "Pesada Manual"
        Me.lblPesadaManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPesadaManual.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Salida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 19)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Entrada"
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Enabled = False
        Me.dtpHoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraSalida.Location = New System.Drawing.Point(217, 93)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(124, 26)
        Me.dtpHoraSalida.TabIndex = 68
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Enabled = False
        Me.dtpFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(87, 93)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaSalida.TabIndex = 67
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.Enabled = False
        Me.dtpHoraEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(217, 61)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(124, 26)
        Me.dtpHoraEntrada.TabIndex = 65
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.Enabled = False
        Me.dtpFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(87, 61)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaEntrada.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(352, 23)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Estatus / Fecha"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Maroon
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.panelGanado)
        Me.Panel5.Location = New System.Drawing.Point(12, 183)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(621, 259)
        Me.Panel5.TabIndex = 1
        '
        'panelGanado
        '
        Me.panelGanado.BackColor = System.Drawing.SystemColors.Control
        Me.panelGanado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGanado.Controls.Add(Me.txtPesoGuia)
        Me.panelGanado.Controls.Add(Me.Label36)
        Me.panelGanado.Controls.Add(Me.txtNumGuia)
        Me.panelGanado.Controls.Add(Me.Label35)
        Me.panelGanado.Controls.Add(Me.Label5)
        Me.panelGanado.Controls.Add(Me.txtLote)
        Me.panelGanado.Controls.Add(Me.txtMachos)
        Me.panelGanado.Controls.Add(Me.Label17)
        Me.panelGanado.Controls.Add(Me.txtHembras)
        Me.panelGanado.Controls.Add(Me.Label18)
        Me.panelGanado.Controls.Add(Me.txtTotalCabezas)
        Me.panelGanado.Controls.Add(Me.txtVaquillas)
        Me.panelGanado.Controls.Add(Me.Label22)
        Me.panelGanado.Controls.Add(Me.lblHembras)
        Me.panelGanado.Controls.Add(Me.txtToretes)
        Me.panelGanado.Controls.Add(Me.lblMachos)
        Me.panelGanado.Controls.Add(Me.Label16)
        Me.panelGanado.Controls.Add(Me.txtTotalCabezasGuia)
        Me.panelGanado.Controls.Add(Me.txtNumHembrasGuia)
        Me.panelGanado.Controls.Add(Me.Label9)
        Me.panelGanado.Controls.Add(Me.Label12)
        Me.panelGanado.Controls.Add(Me.txtNumMachosGuia)
        Me.panelGanado.Controls.Add(Me.Label15)
        Me.panelGanado.Controls.Add(Me.Label8)
        Me.panelGanado.Controls.Add(Me.txtFleje)
        Me.panelGanado.Controls.Add(Me.Label26)
        Me.panelGanado.Controls.Add(Me.txtCZM)
        Me.panelGanado.Controls.Add(Me.Label25)
        Me.panelGanado.Controls.Add(Me.txtCorrales)
        Me.panelGanado.Controls.Add(Me.Label14)
        Me.panelGanado.Controls.Add(Me.Label13)
        Me.panelGanado.Controls.Add(Me.dtpFechaSacrificio)
        Me.panelGanado.Controls.Add(Me.Label3)
        Me.panelGanado.Controls.Add(Me.cmbTipoGanado)
        Me.panelGanado.Controls.Add(Me.Label4)
        Me.panelGanado.Controls.Add(Me.Label6)
        Me.panelGanado.Controls.Add(Me.cmbEspecie)
        Me.panelGanado.Location = New System.Drawing.Point(1, 1)
        Me.panelGanado.Name = "panelGanado"
        Me.panelGanado.Size = New System.Drawing.Size(617, 255)
        Me.panelGanado.TabIndex = 0
        '
        'txtPesoGuia
        '
        Me.txtPesoGuia.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoGuia.Location = New System.Drawing.Point(208, 188)
        Me.txtPesoGuia.MaxLength = 6
        Me.txtPesoGuia.Name = "txtPesoGuia"
        Me.txtPesoGuia.Size = New System.Drawing.Size(87, 23)
        Me.txtPesoGuia.TabIndex = 16
        Me.txtPesoGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(169, 191)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(36, 15)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Peso"
        '
        'txtNumGuia
        '
        Me.txtNumGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumGuia.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGuia.Location = New System.Drawing.Point(55, 188)
        Me.txtNumGuia.MaxLength = 10
        Me.txtNumGuia.Name = "txtNumGuia"
        Me.txtNumGuia.Size = New System.Drawing.Size(105, 23)
        Me.txtNumGuia.TabIndex = 14
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 191)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(52, 15)
        Me.Label35.TabIndex = 13
        Me.Label35.Text = "Número"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Lote"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(413, 92)
        Me.txtLote.MaxLength = 6
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(174, 26)
        Me.txtLote.TabIndex = 24
        Me.txtLote.TabStop = False
        '
        'txtMachos
        '
        Me.txtMachos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMachos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachos.Location = New System.Drawing.Point(382, 124)
        Me.txtMachos.MaxLength = 6
        Me.txtMachos.Name = "txtMachos"
        Me.txtMachos.Size = New System.Drawing.Size(49, 26)
        Me.txtMachos.TabIndex = 30
        Me.txtMachos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(310, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 19)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Toretes"
        '
        'txtHembras
        '
        Me.txtHembras.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHembras.Location = New System.Drawing.Point(538, 124)
        Me.txtHembras.MaxLength = 7
        Me.txtHembras.Name = "txtHembras"
        Me.txtHembras.Size = New System.Drawing.Size(49, 26)
        Me.txtHembras.TabIndex = 26
        Me.txtHembras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(454, 159)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 19)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Vaquillas"
        '
        'txtTotalCabezas
        '
        Me.txtTotalCabezas.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalCabezas.Enabled = False
        Me.txtTotalCabezas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCabezas.Location = New System.Drawing.Point(496, 191)
        Me.txtTotalCabezas.MaxLength = 6
        Me.txtTotalCabezas.Name = "txtTotalCabezas"
        Me.txtTotalCabezas.Size = New System.Drawing.Size(91, 26)
        Me.txtTotalCabezas.TabIndex = 34
        Me.txtTotalCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVaquillas
        '
        Me.txtVaquillas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVaquillas.Location = New System.Drawing.Point(538, 156)
        Me.txtVaquillas.MaxLength = 6
        Me.txtVaquillas.Name = "txtVaquillas"
        Me.txtVaquillas.Size = New System.Drawing.Size(49, 26)
        Me.txtVaquillas.TabIndex = 28
        Me.txtVaquillas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(444, 194)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 19)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Total"
        '
        'lblHembras
        '
        Me.lblHembras.AutoSize = True
        Me.lblHembras.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHembras.Location = New System.Drawing.Point(454, 127)
        Me.lblHembras.Name = "lblHembras"
        Me.lblHembras.Size = New System.Drawing.Size(78, 19)
        Me.lblHembras.TabIndex = 25
        Me.lblHembras.Text = "Hembras"
        Me.ToolTip1.SetToolTip(Me.lblHembras, "Bovinos = Vacas")
        '
        'txtToretes
        '
        Me.txtToretes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToretes.Location = New System.Drawing.Point(382, 156)
        Me.txtToretes.MaxLength = 6
        Me.txtToretes.Name = "txtToretes"
        Me.txtToretes.Size = New System.Drawing.Size(49, 26)
        Me.txtToretes.TabIndex = 32
        Me.txtToretes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMachos
        '
        Me.lblMachos.AutoSize = True
        Me.lblMachos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachos.Location = New System.Drawing.Point(307, 127)
        Me.lblMachos.Name = "lblMachos"
        Me.lblMachos.Size = New System.Drawing.Size(69, 19)
        Me.lblMachos.TabIndex = 29
        Me.lblMachos.Text = "Machos"
        Me.ToolTip1.SetToolTip(Me.lblMachos, "Bovinos = Toros")
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(301, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(286, 23)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Información del rastro"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCabezasGuia
        '
        Me.txtTotalCabezasGuia.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTotalCabezasGuia.Enabled = False
        Me.txtTotalCabezasGuia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCabezasGuia.Location = New System.Drawing.Point(245, 220)
        Me.txtTotalCabezasGuia.MaxLength = 6
        Me.txtTotalCabezasGuia.Name = "txtTotalCabezasGuia"
        Me.txtTotalCabezasGuia.Size = New System.Drawing.Size(48, 26)
        Me.txtTotalCabezasGuia.TabIndex = 22
        Me.txtTotalCabezasGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumHembrasGuia
        '
        Me.txtNumHembrasGuia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumHembrasGuia.Location = New System.Drawing.Point(160, 220)
        Me.txtNumHembrasGuia.MaxLength = 6
        Me.txtNumHembrasGuia.Name = "txtNumHembrasGuia"
        Me.txtNumHembrasGuia.Size = New System.Drawing.Size(41, 26)
        Me.txtNumHembrasGuia.TabIndex = 20
        Me.txtNumHembrasGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(206, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(101, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Hembras"
        '
        'txtNumMachosGuia
        '
        Me.txtNumMachosGuia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumMachosGuia.Location = New System.Drawing.Point(55, 220)
        Me.txtNumMachosGuia.MaxLength = 6
        Me.txtNumMachosGuia.Name = "txtNumMachosGuia"
        Me.txtNumMachosGuia.Size = New System.Drawing.Size(41, 26)
        Me.txtNumMachosGuia.TabIndex = 18
        Me.txtNumMachosGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 227)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Machos"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(5, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Información de la guía"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFleje
        '
        Me.txtFleje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFleje.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFleje.Location = New System.Drawing.Point(137, 128)
        Me.txtFleje.MaxLength = 15
        Me.txtFleje.Name = "txtFleje"
        Me.txtFleje.Size = New System.Drawing.Size(156, 26)
        Me.txtFleje.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(78, 130)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 19)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Fleje"
        '
        'txtCZM
        '
        Me.txtCZM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCZM.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCZM.Location = New System.Drawing.Point(137, 95)
        Me.txtCZM.MaxLength = 15
        Me.txtCZM.Name = "txtCZM"
        Me.txtCZM.Size = New System.Drawing.Size(156, 26)
        Me.txtCZM.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(33, 98)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 19)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Folio C.Z.M."
        '
        'txtCorrales
        '
        Me.txtCorrales.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrales.Location = New System.Drawing.Point(318, 223)
        Me.txtCorrales.MaxLength = 20
        Me.txtCorrales.Multiline = True
        Me.txtCorrales.Name = "txtCorrales"
        Me.txtCorrales.Size = New System.Drawing.Size(269, 26)
        Me.txtCorrales.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(321, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 19)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Corrales"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 19)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Fecha Sacrificio"
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(139, 61)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(156, 26)
        Me.dtpFechaSacrificio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(616, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Información del ganado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipoGanado
        '
        Me.cmbTipoGanado.DataSource = Me.DsCatalogos
        Me.cmbTipoGanado.DisplayMember = "SP_CONS_TIPO_GANADO.NOMBRE"
        Me.cmbTipoGanado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoGanado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoGanado.FormattingEnabled = True
        Me.cmbTipoGanado.Location = New System.Drawing.Point(431, 31)
        Me.cmbTipoGanado.Name = "cmbTipoGanado"
        Me.cmbTipoGanado.Size = New System.Drawing.Size(156, 24)
        Me.cmbTipoGanado.TabIndex = 5
        Me.cmbTipoGanado.ValueMember = "SP_CONS_TIPO_GANADO.ID_TGAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo de ganado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(61, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Especie"
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DataSource = Me.DsCatalogos
        Me.cmbEspecie.DisplayMember = "SP_CONS_ESPECIES.NOMBRE"
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Location = New System.Drawing.Point(137, 31)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(156, 24)
        Me.cmbEspecie.TabIndex = 3
        Me.cmbEspecie.ValueMember = "SP_CONS_ESPECIES.ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 446)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(621, 120)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cmbMarcaVehiculo)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.cmbTipoVehiculo)
        Me.Panel4.Controls.Add(Me.txtPlacas)
        Me.Panel4.Controls.Add(Me.txtConductor)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(617, 116)
        Me.Panel4.TabIndex = 45
        '
        'cmbMarcaVehiculo
        '
        Me.cmbMarcaVehiculo.DataSource = Me.DsCatalogos
        Me.cmbMarcaVehiculo.DisplayMember = "SP_CONS_MARCAS_VEHICULOS.NOMBRE"
        Me.cmbMarcaVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarcaVehiculo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarcaVehiculo.FormattingEnabled = True
        Me.cmbMarcaVehiculo.Location = New System.Drawing.Point(382, 38)
        Me.cmbMarcaVehiculo.Name = "cmbMarcaVehiculo"
        Me.cmbMarcaVehiculo.Size = New System.Drawing.Size(207, 26)
        Me.cmbMarcaVehiculo.TabIndex = 4
        Me.cmbMarcaVehiculo.ValueMember = "SP_CONS_MARCAS_VEHICULOS.ID"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(321, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 19)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Marca"
        '
        'cmbTipoVehiculo
        '
        Me.cmbTipoVehiculo.DataSource = Me.DsCatalogos
        Me.cmbTipoVehiculo.DisplayMember = "SP_CONS_TIPOS_VEHICULO.NOMBRE"
        Me.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoVehiculo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoVehiculo.FormattingEnabled = True
        Me.cmbTipoVehiculo.Location = New System.Drawing.Point(82, 38)
        Me.cmbTipoVehiculo.Name = "cmbTipoVehiculo"
        Me.cmbTipoVehiculo.Size = New System.Drawing.Size(224, 26)
        Me.cmbTipoVehiculo.TabIndex = 2
        Me.cmbTipoVehiculo.ValueMember = "SP_CONS_TIPOS_VEHICULO.ID"
        '
        'txtPlacas
        '
        Me.txtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacas.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacas.Location = New System.Drawing.Point(85, 75)
        Me.txtPlacas.MaxLength = 10
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(103, 23)
        Me.txtPlacas.TabIndex = 6
        '
        'txtConductor
        '
        Me.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConductor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConductor.Location = New System.Drawing.Point(305, 76)
        Me.txtConductor.MaxLength = 30
        Me.txtConductor.Multiline = True
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(287, 22)
        Me.txtConductor.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(20, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 19)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Placas"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(238, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 19)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Chofer"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(33, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 19)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Tipo"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(614, 23)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Datos del vehículo"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Delete
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(772, 572)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 57)
        Me.btnCancelar.TabIndex = 83
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(926, 572)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 84
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(695, 572)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 82
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
        Me.btnNuevo.Image = Global.SistemaControlProduccion.My.Resources.Resources.new_doc
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(618, 570)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 81
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Maroon
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(639, 446)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(359, 120)
        Me.Panel9.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.txtObservaciones)
        Me.Panel10.Controls.Add(Me.Label29)
        Me.Panel10.Location = New System.Drawing.Point(1, 1)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(355, 116)
        Me.Panel10.TabIndex = 45
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(5, 24)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(342, 86)
        Me.txtObservaciones.TabIndex = 80
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Maroon
        Me.Label29.Location = New System.Drawing.Point(0, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(351, 23)
        Me.Label29.TabIndex = 79
        Me.Label29.Text = "Observaciones"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 638)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1009, 22)
        Me.StatusStrip1.TabIndex = 88
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
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel4.Text = "F7|Cancelar"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel5.Text = "F9|Imprimir"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(639, 183)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(359, 259)
        Me.Panel11.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label34)
        Me.Panel12.Controls.Add(Me.txtPeso)
        Me.Panel12.Controls.Add(Me.txtKgsNeto)
        Me.Panel12.Controls.Add(Me.txtKgsSalida)
        Me.Panel12.Controls.Add(Me.Label31)
        Me.Panel12.Controls.Add(Me.Label32)
        Me.Panel12.Controls.Add(Me.txtKgsEntrada)
        Me.Panel12.Controls.Add(Me.Label33)
        Me.Panel12.Controls.Add(Me.Label30)
        Me.Panel12.Location = New System.Drawing.Point(1, 1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(355, 255)
        Me.Panel12.TabIndex = 45
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 70)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(130, 22)
        Me.Label34.TabIndex = 71
        Me.Label34.Text = "Kgs. báscula"
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.OrangeRed
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.White
        Me.txtPeso.Location = New System.Drawing.Point(151, 53)
        Me.txtPeso.MaxLength = 8
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(184, 47)
        Me.txtPeso.TabIndex = 72
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgsNeto
        '
        Me.txtKgsNeto.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsNeto.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsNeto.Location = New System.Drawing.Point(185, 194)
        Me.txtKgsNeto.MaxLength = 6
        Me.txtKgsNeto.Name = "txtKgsNeto"
        Me.txtKgsNeto.ReadOnly = True
        Me.txtKgsNeto.Size = New System.Drawing.Size(119, 32)
        Me.txtKgsNeto.TabIndex = 78
        Me.txtKgsNeto.TabStop = False
        Me.txtKgsNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgsSalida
        '
        Me.txtKgsSalida.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsSalida.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsSalida.Location = New System.Drawing.Point(185, 156)
        Me.txtKgsSalida.MaxLength = 6
        Me.txtKgsSalida.Name = "txtKgsSalida"
        Me.txtKgsSalida.ReadOnly = True
        Me.txtKgsSalida.Size = New System.Drawing.Size(119, 32)
        Me.txtKgsSalida.TabIndex = 76
        Me.txtKgsSalida.TabStop = False
        Me.txtKgsSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(75, 198)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 22)
        Me.Label31.TabIndex = 77
        Me.Label31.Text = "Kgs. Neto"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(60, 160)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(114, 22)
        Me.Label32.TabIndex = 75
        Me.Label32.Text = "Kgs. Salida"
        '
        'txtKgsEntrada
        '
        Me.txtKgsEntrada.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsEntrada.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsEntrada.Location = New System.Drawing.Point(185, 118)
        Me.txtKgsEntrada.MaxLength = 6
        Me.txtKgsEntrada.Name = "txtKgsEntrada"
        Me.txtKgsEntrada.ReadOnly = True
        Me.txtKgsEntrada.Size = New System.Drawing.Size(119, 32)
        Me.txtKgsEntrada.TabIndex = 74
        Me.txtKgsEntrada.TabStop = False
        Me.txtKgsEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(44, 122)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(130, 22)
        Me.Label33.TabIndex = 73
        Me.Label33.Text = "Kgs. Entrada"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(0, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(356, 23)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "Información de la bascula"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPesar
        '
        Me.btnPesar.FlatAppearance.BorderSize = 0
        Me.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesar.Image = Global.SistemaControlProduccion.My.Resources.Resources.bascula4
        Me.btnPesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesar.Location = New System.Drawing.Point(849, 572)
        Me.btnPesar.Name = "btnPesar"
        Me.btnPesar.Size = New System.Drawing.Size(71, 57)
        Me.btnPesar.TabIndex = 89
        Me.btnPesar.Text = "&Pesar"
        Me.btnPesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPesar.UseVisualStyleBackColor = True
        '
        'frmEntradaVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1009, 660)
        Me.Controls.Add(Me.btnPesar)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmEntradaVehiculos"
        Me.Text = "Entrada de Vehículos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.panelGanado.ResumeLayout(False)
        Me.panelGanado.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaProductor As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblIntroductor As System.Windows.Forms.Label
    Friend WithEvents lblProductor As System.Windows.Forms.Label
    Friend WithEvents cmbTipoEntrada As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents panelGanado As System.Windows.Forms.Panel
    Friend WithEvents txtMachos As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtHembras As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCabezas As System.Windows.Forms.TextBox
    Friend WithEvents txtVaquillas As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblHembras As System.Windows.Forms.Label
    Friend WithEvents txtToretes As System.Windows.Forms.TextBox
    Friend WithEvents lblMachos As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCabezasGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtNumHembrasGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumMachosGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFleje As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtCZM As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCorrales As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoGanado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmbMarcaVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents txtConductor As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtKgsNeto As System.Windows.Forms.TextBox
    Friend WithEvents txtKgsSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtKgsEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents DsCatalogos As SistemaControlProduccion.dsCatalogos
    Friend WithEvents txtNomProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents lblPesadaManual As System.Windows.Forms.Label
    Friend WithEvents txtNumGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtPesoGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPesar As System.Windows.Forms.Button
End Class
