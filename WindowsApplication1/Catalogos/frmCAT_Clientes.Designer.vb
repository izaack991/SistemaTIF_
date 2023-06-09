<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAT_Clientes
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.txtMarcaCliente = New System.Windows.Forms.TextBox()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.ID_CTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_TCTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_TCTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLONIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CELULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 937)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1584, 32)
        Me.StatusStrip1.TabIndex = 7
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 25)
        Me.ToolStripStatusLabel1.Text = "F2|Nuevo"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 25)
        Me.ToolStripStatusLabel2.Text = "F3|Buscar"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(98, 25)
        Me.ToolStripStatusLabel3.Text = "F4|Guardar"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(101, 25)
        Me.ToolStripStatusLabel4.Text = "F7|Cancelar"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(103, 25)
        Me.ToolStripStatusLabel5.Text = "F9|Imprimir"
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Cancelar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(1388, 151)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 81)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'lblEstatus
        '
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.Location = New System.Drawing.Point(191, 35)
        Me.lblEstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(344, 38)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "Estatus"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFC.Location = New System.Drawing.Point(640, 226)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(236, 28)
        Me.txtRFC.TabIndex = 24
        '
        'txtCP
        '
        Me.txtCP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(390, 184)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(145, 28)
        Me.txtCP.TabIndex = 10
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.SystemColors.Window
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(640, 179)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCelular.MaxLength = 12
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(236, 28)
        Me.txtCelular.TabIndex = 22
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(640, 133)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(236, 28)
        Me.txtTelefono.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(640, 85)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(236, 28)
        Me.txtEmail.TabIndex = 18
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(390, 227)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEstado.MaxLength = 20
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(145, 28)
        Me.txtEstado.TabIndex = 14
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.SystemColors.Window
        Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Location = New System.Drawing.Point(115, 228)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMunicipio.MaxLength = 30
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(161, 28)
        Me.txtMunicipio.TabIndex = 12
        '
        'txtColonia
        '
        Me.txtColonia.BackColor = System.Drawing.SystemColors.Window
        Me.txtColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(115, 181)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtColonia.MaxLength = 30
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(161, 28)
        Me.txtColonia.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(115, 135)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDireccion.MaxLength = 40
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(420, 28)
        Me.txtDireccion.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(577, 231)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 22)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "RFC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(347, 188)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "CP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(557, 185)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 22)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(543, 138)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(564, 92)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 22)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 233)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Municipio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 187)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Colonia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(578, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tipo"
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.DataSource = Me.DsCatalogos
        Me.cmbTipoCliente.DisplayMember = "SP_CONS_TIPOS_CLIENTE.NOMBRE"
        Me.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCliente.FormattingEnabled = True
        Me.cmbTipoCliente.Location = New System.Drawing.Point(640, 41)
        Me.cmbTipoCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.Size = New System.Drawing.Size(354, 30)
        Me.cmbTipoCliente.TabIndex = 16
        Me.cmbTipoCliente.ValueMember = "SP_CONS_TIPOS_CLIENTE.ID"
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'txtNomCliente
        '
        Me.txtNomCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCliente.Location = New System.Drawing.Point(115, 87)
        Me.txtNomCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomCliente.MaxLength = 60
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.Size = New System.Drawing.Size(420, 28)
        Me.txtNomCliente.TabIndex = 4
        '
        'txtMarcaCliente
        '
        Me.txtMarcaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaCliente.Location = New System.Drawing.Point(115, 41)
        Me.txtMarcaCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMarcaCliente.MaxLength = 6
        Me.txtMarcaCliente.Name = "txtMarcaCliente"
        Me.txtMarcaCliente.Size = New System.Drawing.Size(75, 28)
        Me.txtMarcaCliente.TabIndex = 1
        Me.txtMarcaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProductor
        '
        Me.lblProductor.AutoSize = True
        Me.lblProductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductor.Location = New System.Drawing.Point(42, 45)
        Me.lblProductor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductor.Name = "lblProductor"
        Me.lblProductor.Size = New System.Drawing.Size(59, 22)
        Me.lblProductor.TabIndex = 0
        Me.lblProductor.Text = "Marca"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.Imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(1503, 151)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(68, 81)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Guardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(1273, 151)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(68, 81)
        Me.btnGuardar.TabIndex = 4
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
        Me.btnNuevo.Image = Global.SistemaControlProduccion.My.Resources.Resources.Nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(1157, 151)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 81)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        Me.btnNuevo.Visible = False
        '
        'dgvCatalogo
        '
        Me.dgvCatalogo.AllowUserToAddRows = False
        Me.dgvCatalogo.AllowUserToDeleteRows = False
        Me.dgvCatalogo.AllowUserToOrderColumns = True
        Me.dgvCatalogo.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvCatalogo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCatalogo.AutoGenerateColumns = False
        Me.dgvCatalogo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCatalogo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CTE, Me.MARCA, Me.NOMBRE, Me.ID_TCTE, Me.NOM_TCTE, Me.DIRECCION, Me.COLONIA, Me.MUNICIPIO, Me.ESTADO, Me.EMAIL, Me.TELEFONO, Me.CELULAR, Me.CP, Me.RFC, Me.ESTATUS})
        Me.dgvCatalogo.DataMember = "SP_CONS_CLIENTES"
        Me.dgvCatalogo.DataSource = Me.DsCatalogos
        Me.dgvCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCatalogo.Location = New System.Drawing.Point(2, 29)
        Me.dgvCatalogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvCatalogo.Name = "dgvCatalogo"
        Me.dgvCatalogo.ReadOnly = True
        Me.dgvCatalogo.RowHeadersVisible = False
        Me.dgvCatalogo.RowHeadersWidth = 62
        Me.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCatalogo.Size = New System.Drawing.Size(1580, 587)
        Me.dgvCatalogo.StandardTab = True
        Me.dgvCatalogo.TabIndex = 2
        '
        'ID_CTE
        '
        Me.ID_CTE.DataPropertyName = "ID_CTE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID_CTE.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID_CTE.HeaderText = "ID"
        Me.ID_CTE.MinimumWidth = 8
        Me.ID_CTE.Name = "ID_CTE"
        Me.ID_CTE.ReadOnly = True
        Me.ID_CTE.Width = 50
        '
        'MARCA
        '
        Me.MARCA.DataPropertyName = "MARCA"
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.MinimumWidth = 8
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        Me.MARCA.Width = 60
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 8
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 220
        '
        'ID_TCTE
        '
        Me.ID_TCTE.DataPropertyName = "ID_TCTE"
        Me.ID_TCTE.HeaderText = "ID_TCTE"
        Me.ID_TCTE.MinimumWidth = 8
        Me.ID_TCTE.Name = "ID_TCTE"
        Me.ID_TCTE.ReadOnly = True
        Me.ID_TCTE.Visible = False
        Me.ID_TCTE.Width = 150
        '
        'NOM_TCTE
        '
        Me.NOM_TCTE.DataPropertyName = "NOM_TCTE"
        Me.NOM_TCTE.HeaderText = "TIPO CTE"
        Me.NOM_TCTE.MinimumWidth = 8
        Me.NOM_TCTE.Name = "NOM_TCTE"
        Me.NOM_TCTE.ReadOnly = True
        Me.NOM_TCTE.Width = 150
        '
        'DIRECCION
        '
        Me.DIRECCION.DataPropertyName = "DIRECCION"
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.MinimumWidth = 8
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Width = 150
        '
        'COLONIA
        '
        Me.COLONIA.DataPropertyName = "COLONIA"
        Me.COLONIA.HeaderText = "COLONIA"
        Me.COLONIA.MinimumWidth = 8
        Me.COLONIA.Name = "COLONIA"
        Me.COLONIA.ReadOnly = True
        Me.COLONIA.Width = 150
        '
        'MUNICIPIO
        '
        Me.MUNICIPIO.DataPropertyName = "MUNICIPIO"
        Me.MUNICIPIO.HeaderText = "MUNICIPIO"
        Me.MUNICIPIO.MinimumWidth = 8
        Me.MUNICIPIO.Name = "MUNICIPIO"
        Me.MUNICIPIO.ReadOnly = True
        Me.MUNICIPIO.Width = 150
        '
        'ESTADO
        '
        Me.ESTADO.DataPropertyName = "ESTADO"
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.MinimumWidth = 8
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 150
        '
        'EMAIL
        '
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.MinimumWidth = 8
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        Me.EMAIL.Width = 80
        '
        'TELEFONO
        '
        Me.TELEFONO.DataPropertyName = "TELEFONO"
        Me.TELEFONO.HeaderText = "TELEFONO"
        Me.TELEFONO.MinimumWidth = 8
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.ReadOnly = True
        Me.TELEFONO.Width = 80
        '
        'CELULAR
        '
        Me.CELULAR.DataPropertyName = "CELULAR"
        Me.CELULAR.HeaderText = "CELULAR"
        Me.CELULAR.MinimumWidth = 8
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        Me.CELULAR.Width = 150
        '
        'CP
        '
        Me.CP.DataPropertyName = "CP"
        Me.CP.HeaderText = "CP"
        Me.CP.MinimumWidth = 8
        Me.CP.Name = "CP"
        Me.CP.ReadOnly = True
        Me.CP.Width = 150
        '
        'RFC
        '
        Me.RFC.DataPropertyName = "RFC"
        Me.RFC.HeaderText = "RFC"
        Me.RFC.MinimumWidth = 80
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
        Me.RFC.Width = 150
        '
        'ESTATUS
        '
        Me.ESTATUS.DataPropertyName = "ESTATUS"
        Me.ESTATUS.HeaderText = "ESTATUS"
        Me.ESTATUS.MinimumWidth = 80
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
        Me.ESTATUS.Width = 150
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNomCliente)
        Me.GroupControl1.Controls.Add(Me.lblEstatus)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.btnImprimir)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.btnNuevo)
        Me.GroupControl1.Controls.Add(Me.txtRFC)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txtCP)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txtCelular)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtTelefono)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.cmbTipoCliente)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.txtEstado)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txtMarcaCliente)
        Me.GroupControl1.Controls.Add(Me.txtMunicipio)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.lblProductor)
        Me.GroupControl1.Controls.Add(Me.txtColonia)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1584, 271)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos de clientes"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.dgvCatalogo)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1584, 618)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Listado de clientes"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1584, 41)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_New_32x32
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_Save_32x32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Guardar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.SistemaControlProduccion.My.Resources.Resources.Cancel_32x32
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1584, 278)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupControl2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 319)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1584, 618)
        Me.Panel2.TabIndex = 10
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_Printing_Print_32x32
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "Imprimir"
        '
        'frmCAT_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 969)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCAT_Clientes"
        Me.Text = "Clientes"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsCatalogos As SistemaControlProduccion.dsCatalogos
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblProductor As System.Windows.Forms.Label
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents ID_CTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_TCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_TCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLONIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStripButton4 As ToolStripButton
End Class
