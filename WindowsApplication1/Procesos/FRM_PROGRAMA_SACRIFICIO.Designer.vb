<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PROGRAMA_SACRIFICIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PROGRAMA_SACRIFICIO))
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaDestino = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.txtNomDestino = New System.Windows.Forms.TextBox()
        Me.lblIntr = New System.Windows.Forms.Label()
        Me.txtidsac = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.TxtLote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTHEMBRAS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTMACHOS = New System.Windows.Forms.TextBox()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.DsCatalogos1 = New SistemaControlProduccion.dsCatalogos()
        Me.CHKHEMBRAS = New System.Windows.Forms.CheckBox()
        Me.CHKMACHOS = New System.Windows.Forms.CheckBox()
        Me.CHKMIXTO = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DsCatalogos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.txtNomIntroductor.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNomIntroductor.Location = New System.Drawing.Point(195, 314)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(812, 64)
        Me.txtNomIntroductor.TabIndex = 3
        '
        'txtMarcaDestino
        '
        Me.txtMarcaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaDestino.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.txtMarcaDestino.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMarcaDestino.Location = New System.Drawing.Point(17, 437)
        Me.txtMarcaDestino.MaxLength = 6
        Me.txtMarcaDestino.Name = "txtMarcaDestino"
        Me.txtMarcaDestino.Size = New System.Drawing.Size(174, 64)
        Me.txtMarcaDestino.TabIndex = 5
        Me.txtMarcaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.txtMarcaIntroductor.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(15, 315)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(174, 64)
        Me.txtMarcaIntroductor.TabIndex = 2
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblDestino.ForeColor = System.Drawing.Color.White
        Me.lblDestino.Location = New System.Drawing.Point(5, 378)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(176, 59)
        Me.lblDestino.TabIndex = 4
        Me.lblDestino.Text = "Destino"
        '
        'txtNomDestino
        '
        Me.txtNomDestino.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomDestino.Enabled = False
        Me.txtNomDestino.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.txtNomDestino.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNomDestino.Location = New System.Drawing.Point(197, 437)
        Me.txtNomDestino.MaxLength = 6
        Me.txtNomDestino.Name = "txtNomDestino"
        Me.txtNomDestino.Size = New System.Drawing.Size(810, 64)
        Me.txtNomDestino.TabIndex = 6
        '
        'lblIntr
        '
        Me.lblIntr.AutoSize = True
        Me.lblIntr.Font = New System.Drawing.Font("Segoe UI Semibold", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblIntr.ForeColor = System.Drawing.Color.White
        Me.lblIntr.Location = New System.Drawing.Point(3, 256)
        Me.lblIntr.Name = "lblIntr"
        Me.lblIntr.Size = New System.Drawing.Size(250, 59)
        Me.lblIntr.TabIndex = 1
        Me.lblIntr.Text = "Introductor"
        '
        'txtidsac
        '
        Me.txtidsac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidsac.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidsac.Location = New System.Drawing.Point(1189, 332)
        Me.txtidsac.MaxLength = 6
        Me.txtidsac.Name = "txtidsac"
        Me.txtidsac.Size = New System.Drawing.Size(24, 26)
        Me.txtidsac.TabIndex = 15
        Me.txtidsac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtidsac.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1160, 335)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 18)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Id"
        Me.Label13.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(631, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 59)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Especie"
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DisplayMember = "SP_CONS_ESPECIES.NOMBRE"
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Location = New System.Drawing.Point(641, 191)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(386, 67)
        Me.cmbEspecie.TabIndex = 13
        Me.cmbEspecie.ValueMember = "SP_CONS_ESPECIES.ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(870, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 59)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha"
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(880, 62)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(333, 65)
        Me.dtpFechaMov.TabIndex = 11
        '
        'TxtLote
        '
        Me.TxtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLote.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLote.Location = New System.Drawing.Point(10, 62)
        Me.TxtLote.MaxLength = 6
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.Size = New System.Drawing.Size(174, 65)
        Me.TxtLote.TabIndex = 9
        Me.TxtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 59)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Lote"
        '
        'TXTHEMBRAS
        '
        Me.TXTHEMBRAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTHEMBRAS.Enabled = False
        Me.TXTHEMBRAS.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHEMBRAS.Location = New System.Drawing.Point(433, 191)
        Me.TXTHEMBRAS.MaxLength = 6
        Me.TXTHEMBRAS.Name = "TXTHEMBRAS"
        Me.TXTHEMBRAS.Size = New System.Drawing.Size(174, 65)
        Me.TXTHEMBRAS.TabIndex = 7
        Me.TXTHEMBRAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(419, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 59)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hembras"
        '
        'TXTMACHOS
        '
        Me.TXTMACHOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMACHOS.Enabled = False
        Me.TXTMACHOS.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMACHOS.Location = New System.Drawing.Point(227, 191)
        Me.TXTMACHOS.MaxLength = 6
        Me.TXTMACHOS.Name = "TXTMACHOS"
        Me.TXTMACHOS.Size = New System.Drawing.Size(174, 65)
        Me.TXTMACHOS.TabIndex = 5
        Me.TXTMACHOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCANTIDAD.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(15, 191)
        Me.TXTCANTIDAD.MaxLength = 6
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(174, 65)
        Me.TXTCANTIDAD.TabIndex = 2
        Me.TXTCANTIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(224, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 59)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Machos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 59)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cantidad"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(1069, 286)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(174, 35)
        Me.txtObservaciones.TabIndex = 62
        Me.txtObservaciones.Visible = False
        '
        'DsCatalogos1
        '
        Me.DsCatalogos1.DataSetName = "dsCatalogos"
        Me.DsCatalogos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CHKHEMBRAS
        '
        Me.CHKHEMBRAS.AutoSize = True
        Me.CHKHEMBRAS.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKHEMBRAS.ForeColor = System.Drawing.Color.White
        Me.CHKHEMBRAS.Location = New System.Drawing.Point(621, 53)
        Me.CHKHEMBRAS.Name = "CHKHEMBRAS"
        Me.CHKHEMBRAS.Size = New System.Drawing.Size(220, 63)
        Me.CHKHEMBRAS.TabIndex = 18
        Me.CHKHEMBRAS.Text = "Hembras"
        Me.CHKHEMBRAS.UseVisualStyleBackColor = True
        '
        'CHKMACHOS
        '
        Me.CHKMACHOS.AutoSize = True
        Me.CHKMACHOS.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKMACHOS.ForeColor = System.Drawing.Color.White
        Me.CHKMACHOS.Location = New System.Drawing.Point(409, 53)
        Me.CHKMACHOS.Name = "CHKMACHOS"
        Me.CHKMACHOS.Size = New System.Drawing.Size(196, 63)
        Me.CHKMACHOS.TabIndex = 17
        Me.CHKMACHOS.Text = "Machos"
        Me.CHKMACHOS.UseVisualStyleBackColor = True
        '
        'CHKMIXTO
        '
        Me.CHKMIXTO.AutoSize = True
        Me.CHKMIXTO.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKMIXTO.ForeColor = System.Drawing.Color.White
        Me.CHKMIXTO.Location = New System.Drawing.Point(216, 53)
        Me.CHKMIXTO.Name = "CHKMIXTO"
        Me.CHKMIXTO.Size = New System.Drawing.Size(159, 63)
        Me.CHKMIXTO.TabIndex = 16
        Me.CHKMIXTO.Text = "Mixto"
        Me.CHKMIXTO.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 570)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1255, 94)
        Me.FlowLayoutPanel1.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1028, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 86)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(798, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 86)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtNomIntroductor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtMarcaDestino)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.TxtLote)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblIntr)
        Me.Panel1.Controls.Add(Me.CHKHEMBRAS)
        Me.Panel1.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TXTHEMBRAS)
        Me.Panel1.Controls.Add(Me.txtNomDestino)
        Me.Panel1.Controls.Add(Me.CHKMACHOS)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbEspecie)
        Me.Panel1.Controls.Add(Me.CHKMIXTO)
        Me.Panel1.Controls.Add(Me.lblDestino)
        Me.Panel1.Controls.Add(Me.TXTCANTIDAD)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpFechaMov)
        Me.Panel1.Controls.Add(Me.TXTMACHOS)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(5, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 514)
        Me.Panel1.TabIndex = 69
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SlateGray
        Me.Button4.BackgroundImage = Global.SistemaControlProduccion.My.Resources.Resources.metro_search_11261
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1013, 428)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 83)
        Me.Button4.TabIndex = 68
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SlateGray
        Me.Button3.BackgroundImage = Global.SistemaControlProduccion.My.Resources.Resources.metro_search_11261
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1013, 306)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 83)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1255, 60)
        Me.FlowLayoutPanel2.TabIndex = 70
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.SlateGray
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 55)
        Me.Button5.TabIndex = 3
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FRM_PROGRAMA_SACRIFICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1255, 664)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtidsac)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRM_PROGRAMA_SACRIFICIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsCatalogos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents txtNomDestino As System.Windows.Forms.TextBox
    Friend WithEvents lblIntr As System.Windows.Forms.Label
    Friend WithEvents TxtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTHEMBRAS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTMACHOS As System.Windows.Forms.TextBox
    Friend WithEvents TXTCANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtidsac As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DsCatalogos1 As SistemaControlProduccion.dsCatalogos
    Friend WithEvents CHKHEMBRAS As System.Windows.Forms.CheckBox
    Friend WithEvents CHKMACHOS As System.Windows.Forms.CheckBox
    Friend WithEvents CHKMIXTO As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
