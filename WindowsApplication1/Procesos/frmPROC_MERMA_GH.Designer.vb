<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_MERMA_GH
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTGRASASCARNE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTPESOCARNESGRASA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTPESOGRASA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTHUESOSCARNE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTPESOCARNE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTPESOHUESO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTPROCENTAJECARNE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTPORCENTAJEGRASA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTLOTE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.lblIntr = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PORCGRASAHUESOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMERMA_GH = New SistemaControlProduccion.dsMERMA_GH()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PORC_GRASA_HUESOTableAdapter = New SistemaControlProduccion.dsMERMA_GHTableAdapters.PORC_GRASA_HUESOTableAdapter()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PORCGRASAHUESOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMERMA_GH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TXTGRASASCARNE)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TXTPESOCARNESGRASA)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TXTPESOGRASA)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TXTHUESOSCARNE)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TXTPESOCARNE)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TXTPESOHUESO)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TXTPROCENTAJECARNE)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TXTPORCENTAJEGRASA)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TXTLOTE)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dtpFechaMov)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Controls.Add(Me.lblIntr)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 193)
        Me.Panel2.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(378, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Grasa s/carne"
        '
        'TXTGRASASCARNE
        '
        Me.TXTGRASASCARNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTGRASASCARNE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGRASASCARNE.Location = New System.Drawing.Point(497, 155)
        Me.TXTGRASASCARNE.MaxLength = 6
        Me.TXTGRASASCARNE.Name = "TXTGRASASCARNE"
        Me.TXTGRASASCARNE.Size = New System.Drawing.Size(76, 26)
        Me.TXTGRASASCARNE.TabIndex = 22
        Me.TXTGRASASCARNE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(202, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Peso carne"
        '
        'TXTPESOCARNESGRASA
        '
        Me.TXTPESOCARNESGRASA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPESOCARNESGRASA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPESOCARNESGRASA.Location = New System.Drawing.Point(299, 155)
        Me.TXTPESOCARNESGRASA.MaxLength = 6
        Me.TXTPESOCARNESGRASA.Name = "TXTPESOCARNESGRASA"
        Me.TXTPESOCARNESGRASA.Size = New System.Drawing.Size(76, 26)
        Me.TXTPESOCARNESGRASA.TabIndex = 20
        Me.TXTPESOCARNESGRASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 19)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Peso grasa"
        '
        'TXTPESOGRASA
        '
        Me.TXTPESOGRASA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPESOGRASA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPESOGRASA.Location = New System.Drawing.Point(120, 155)
        Me.TXTPESOGRASA.MaxLength = 6
        Me.TXTPESOGRASA.Name = "TXTPESOGRASA"
        Me.TXTPESOGRASA.Size = New System.Drawing.Size(76, 26)
        Me.TXTPESOGRASA.TabIndex = 18
        Me.TXTPESOGRASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(378, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Hueso s/carne"
        '
        'TXTHUESOSCARNE
        '
        Me.TXTHUESOSCARNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTHUESOSCARNE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHUESOSCARNE.Location = New System.Drawing.Point(497, 123)
        Me.TXTHUESOSCARNE.MaxLength = 6
        Me.TXTHUESOSCARNE.Name = "TXTHUESOSCARNE"
        Me.TXTHUESOSCARNE.Size = New System.Drawing.Size(76, 26)
        Me.TXTHUESOSCARNE.TabIndex = 16
        Me.TXTHUESOSCARNE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(202, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Peso carne"
        '
        'TXTPESOCARNE
        '
        Me.TXTPESOCARNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPESOCARNE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPESOCARNE.Location = New System.Drawing.Point(299, 123)
        Me.TXTPESOCARNE.MaxLength = 6
        Me.TXTPESOCARNE.Name = "TXTPESOCARNE"
        Me.TXTPESOCARNE.Size = New System.Drawing.Size(76, 26)
        Me.TXTPESOCARNE.TabIndex = 14
        Me.TXTPESOCARNE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Peso hueso"
        '
        'TXTPESOHUESO
        '
        Me.TXTPESOHUESO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPESOHUESO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPESOHUESO.Location = New System.Drawing.Point(120, 123)
        Me.TXTPESOHUESO.MaxLength = 6
        Me.TXTPESOHUESO.Name = "TXTPESOHUESO"
        Me.TXTPESOHUESO.Size = New System.Drawing.Size(76, 26)
        Me.TXTPESOHUESO.TabIndex = 12
        Me.TXTPESOHUESO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(434, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "% C/G"
        '
        'TXTPROCENTAJECARNE
        '
        Me.TXTPROCENTAJECARNE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPROCENTAJECARNE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPROCENTAJECARNE.Location = New System.Drawing.Point(497, 91)
        Me.TXTPROCENTAJECARNE.MaxLength = 6
        Me.TXTPROCENTAJECARNE.Name = "TXTPROCENTAJECARNE"
        Me.TXTPROCENTAJECARNE.Size = New System.Drawing.Size(76, 26)
        Me.TXTPROCENTAJECARNE.TabIndex = 10
        Me.TXTPROCENTAJECARNE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "% C/H"
        '
        'TXTPORCENTAJEGRASA
        '
        Me.TXTPORCENTAJEGRASA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPORCENTAJEGRASA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPORCENTAJEGRASA.Location = New System.Drawing.Point(299, 91)
        Me.TXTPORCENTAJEGRASA.MaxLength = 6
        Me.TXTPORCENTAJEGRASA.Name = "TXTPORCENTAJEGRASA"
        Me.TXTPORCENTAJEGRASA.Size = New System.Drawing.Size(76, 26)
        Me.TXTPORCENTAJEGRASA.TabIndex = 8
        Me.TXTPORCENTAJEGRASA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Lote"
        '
        'TXTLOTE
        '
        Me.TXTLOTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTLOTE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLOTE.Location = New System.Drawing.Point(120, 91)
        Me.TXTLOTE.MaxLength = 6
        Me.TXTLOTE.Name = "TXTLOTE"
        Me.TXTLOTE.Size = New System.Drawing.Size(76, 26)
        Me.TXTLOTE.TabIndex = 6
        Me.TXTLOTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(120, 27)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(113, 26)
        Me.dtpFechaMov.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(580, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos de Introductor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(202, 59)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(371, 26)
        Me.txtNomIntroductor.TabIndex = 3
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(120, 59)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 2
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIntr
        '
        Me.lblIntr.AutoSize = True
        Me.lblIntr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntr.Location = New System.Drawing.Point(20, 62)
        Me.lblIntr.Name = "lblIntr"
        Me.lblIntr.Size = New System.Drawing.Size(94, 19)
        Me.lblIntr.TabIndex = 1
        Me.lblIntr.Text = "Introductor"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(582, 196)
        Me.Label6.TabIndex = 6
        '
        'PORCGRASAHUESOBindingSource
        '
        Me.PORCGRASAHUESOBindingSource.DataMember = "PORC_GRASA_HUESO"
        Me.PORCGRASAHUESOBindingSource.DataSource = Me.DsMERMA_GH
        '
        'DsMERMA_GH
        '
        Me.DsMERMA_GH.DataSetName = "dsMERMA_GH"
        Me.DsMERMA_GH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(524, 390)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 15
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
        Me.btnNuevo.Location = New System.Drawing.Point(458, 390)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'PORC_GRASA_HUESOTableAdapter
        '
        Me.PORC_GRASA_HUESOTableAdapter.ClearBeforeFill = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(13, 238)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(580, 146)
        Me.txtObservaciones.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(13, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(580, 23)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Observaciones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 210)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(584, 176)
        Me.Label16.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaControlProduccion.My.Resources.Resources.inbox_download
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(387, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 57)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Calcular"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPROC_MERMA_GH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmPROC_MERMA_GH"
        Me.Text = "frmPROC_MERMA_GH"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PORCGRASAHUESOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMERMA_GH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents lblIntr As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTPORCENTAJEGRASA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTLOTE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsMERMA_GH As SistemaControlProduccion.dsMERMA_GH
    Friend WithEvents PORCGRASAHUESOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PORC_GRASA_HUESOTableAdapter As SistemaControlProduccion.dsMERMA_GHTableAdapters.PORC_GRASA_HUESOTableAdapter
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTPROCENTAJECARNE As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTHUESOSCARNE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTPESOCARNE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTPESOHUESO As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTGRASASCARNE As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTPESOCARNESGRASA As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTPESOGRASA As System.Windows.Forms.TextBox
End Class
