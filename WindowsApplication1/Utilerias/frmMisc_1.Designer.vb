<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisc_1
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtKgsLado2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtKgsLado1 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
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
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Maroon
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(32, 120)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(291, 227)
        Me.Panel7.TabIndex = 49
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(1, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(287, 221)
        Me.Panel8.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(288, 23)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Datos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Cancelar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(163, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 57)
        Me.btnCancelar.TabIndex = 48
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
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.Imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(240, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 49
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
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Guardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(86, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "&Modificar"
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
        Me.btnNuevo.Location = New System.Drawing.Point(9, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 46
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 369)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 129)
        Me.Label13.TabIndex = 50
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Maroon
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(362, 26)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(302, 272)
        Me.Panel11.TabIndex = 51
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.txtPeso)
        Me.Panel12.Controls.Add(Me.txtKgsLado2)
        Me.Panel12.Controls.Add(Me.Label32)
        Me.Panel12.Controls.Add(Me.txtKgsLado1)
        Me.Panel12.Controls.Add(Me.Label33)
        Me.Panel12.Controls.Add(Me.Label30)
        Me.Panel12.Location = New System.Drawing.Point(1, 1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(298, 268)
        Me.Panel12.TabIndex = 0
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.OrangeRed
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.White
        Me.txtPeso.Location = New System.Drawing.Point(55, 60)
        Me.txtPeso.MaxLength = 8
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(181, 47)
        Me.txtPeso.TabIndex = 0
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgsLado2
        '
        Me.txtKgsLado2.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsLado2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsLado2.Location = New System.Drawing.Point(132, 174)
        Me.txtKgsLado2.MaxLength = 6
        Me.txtKgsLado2.Name = "txtKgsLado2"
        Me.txtKgsLado2.ReadOnly = True
        Me.txtKgsLado2.Size = New System.Drawing.Size(104, 35)
        Me.txtKgsLado2.TabIndex = 4
        Me.txtKgsLado2.TabStop = False
        Me.txtKgsLado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(59, 185)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 19)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "LADO 2"
        '
        'txtKgsLado1
        '
        Me.txtKgsLado1.BackColor = System.Drawing.Color.PaleGreen
        Me.txtKgsLado1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgsLado1.Location = New System.Drawing.Point(132, 133)
        Me.txtKgsLado1.MaxLength = 6
        Me.txtKgsLado1.Name = "txtKgsLado1"
        Me.txtKgsLado1.ReadOnly = True
        Me.txtKgsLado1.Size = New System.Drawing.Size(104, 35)
        Me.txtKgsLado1.TabIndex = 2
        Me.txtKgsLado1.TabStop = False
        Me.txtKgsLado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(59, 144)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 19)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "LADO 1"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(-2, 1)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(295, 23)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "Información de la bascula"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(391, 313)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(577, 197)
        Me.Panel3.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(327, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(2, 99)
        Me.Label10.TabIndex = 40
        '
        'chkPesarLado2
        '
        Me.chkPesarLado2.AutoSize = True
        Me.chkPesarLado2.Checked = True
        Me.chkPesarLado2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPesarLado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPesarLado2.Location = New System.Drawing.Point(370, 65)
        Me.chkPesarLado2.Name = "chkPesarLado2"
        Me.chkPesarLado2.Size = New System.Drawing.Size(162, 24)
        Me.chkPesarLado2.TabIndex = 6
        Me.chkPesarLado2.Text = "Pesar Lado 1 y 2"
        Me.chkPesarLado2.UseVisualStyleBackColor = True
        '
        'rdbVaquilla
        '
        Me.rdbVaquilla.AutoSize = True
        Me.rdbVaquilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVaquilla.Location = New System.Drawing.Point(48, 101)
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
        Me.rdbHembra.Location = New System.Drawing.Point(48, 71)
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
        Me.Label5.Location = New System.Drawing.Point(152, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(2, 99)
        Me.Label5.TabIndex = 37
        '
        'rdbMacho
        '
        Me.rdbMacho.AutoSize = True
        Me.rdbMacho.Checked = True
        Me.rdbMacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMacho.Location = New System.Drawing.Point(45, 41)
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
        Me.chkEnmantado.Location = New System.Drawing.Point(193, 101)
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
        Me.chkVaciada.Location = New System.Drawing.Point(193, 71)
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
        Me.chkMayor.Location = New System.Drawing.Point(193, 41)
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
        Me.Label8.Size = New System.Drawing.Size(576, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Caracteristicas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(389, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(581, 200)
        Me.Label9.TabIndex = 53
        '
        'frmMisc_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 507)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "frmMisc_1"
        Me.Text = "frmMisc_1"
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtKgsLado2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtKgsLado1 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
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
End Class
