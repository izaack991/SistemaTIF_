<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAT_Productos
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbCuarto = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbRefrigeracion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSubfamilia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFamilia = New System.Windows.Forms.ComboBox()
        Me.numDiasCaducidad = New System.Windows.Forms.NumericUpDown()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomProd = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.ID_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS_CAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_REF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESPECIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_ESPECIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_FAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_FAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_SFAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_SFAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CUARTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CEXP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbClasifExp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDiasCaducidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 586)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(878, 22)
        Me.StatusStrip1.TabIndex = 7
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
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Cancelar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(718, 526)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 57)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.cmbClasifExp)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.cmbCuarto)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.cmbRefrigeracion)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.cmbSubfamilia)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.cmbFamilia)
        Me.Panel8.Controls.Add(Me.numDiasCaducidad)
        Me.Panel8.Controls.Add(Me.lblEstatus)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.cmbEspecie)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.txtNomProd)
        Me.Panel8.Controls.Add(Me.txtCodProd)
        Me.Panel8.Controls.Add(Me.lblProductor)
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(15, 11)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(848, 158)
        Me.Panel8.TabIndex = 0
        '
        'cmbCuarto
        '
        Me.cmbCuarto.DataSource = Me.DsCatalogos
        Me.cmbCuarto.DisplayMember = "SP_CONS_CUARTOS.NOMBRE"
        Me.cmbCuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuarto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuarto.FormattingEnabled = True
        Me.cmbCuarto.Location = New System.Drawing.Point(616, 100)
        Me.cmbCuarto.Name = "cmbCuarto"
        Me.cmbCuarto.Size = New System.Drawing.Size(185, 24)
        Me.cmbCuarto.TabIndex = 16
        Me.cmbCuarto.ValueMember = "SP_CONS_CUARTOS.ID"
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(549, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cuarto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Refrigeración"
        '
        'cmbRefrigeracion
        '
        Me.cmbRefrigeracion.DataSource = Me.DsCatalogos
        Me.cmbRefrigeracion.DisplayMember = "SP_CONS_REFRIGERACION.NOMBRE"
        Me.cmbRefrigeracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRefrigeracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefrigeracion.FormattingEnabled = True
        Me.cmbRefrigeracion.Location = New System.Drawing.Point(342, 74)
        Me.cmbRefrigeracion.Name = "cmbRefrigeracion"
        Me.cmbRefrigeracion.Size = New System.Drawing.Size(146, 24)
        Me.cmbRefrigeracion.TabIndex = 8
        Me.cmbRefrigeracion.ValueMember = "SP_CONS_REFRIGERACION.ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(521, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Subfamilia"
        '
        'cmbSubfamilia
        '
        Me.cmbSubfamilia.DataSource = Me.DsCatalogos
        Me.cmbSubfamilia.DisplayMember = "SP_CONS_SUBFAMILIAS.NOMBRE"
        Me.cmbSubfamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubfamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubfamilia.FormattingEnabled = True
        Me.cmbSubfamilia.Location = New System.Drawing.Point(616, 70)
        Me.cmbSubfamilia.Name = "cmbSubfamilia"
        Me.cmbSubfamilia.Size = New System.Drawing.Size(185, 24)
        Me.cmbSubfamilia.TabIndex = 14
        Me.cmbSubfamilia.ValueMember = "SP_CONS_SUBFAMILIAS.ID_SFAM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(547, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Familia"
        '
        'cmbFamilia
        '
        Me.cmbFamilia.DataSource = Me.DsCatalogos
        Me.cmbFamilia.DisplayMember = "SP_CONS_FAMILIAS.NOMBRE"
        Me.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(616, 40)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(185, 24)
        Me.cmbFamilia.TabIndex = 12
        Me.cmbFamilia.ValueMember = "SP_CONS_FAMILIAS.ID"
        '
        'numDiasCaducidad
        '
        Me.numDiasCaducidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiasCaducidad.Location = New System.Drawing.Point(164, 72)
        Me.numDiasCaducidad.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numDiasCaducidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDiasCaducidad.Name = "numDiasCaducidad"
        Me.numDiasCaducidad.Size = New System.Drawing.Size(54, 26)
        Me.numDiasCaducidad.TabIndex = 6
        Me.numDiasCaducidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDiasCaducidad.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'lblEstatus
        '
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.Location = New System.Drawing.Point(259, 6)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(229, 26)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "Estatus"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Días Caducidad"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Especie"
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DataSource = Me.DsCatalogos
        Me.cmbEspecie.DisplayMember = "SP_CONS_ESPECIES.NOMBRE"
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Location = New System.Drawing.Point(616, 10)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(185, 24)
        Me.cmbEspecie.TabIndex = 10
        Me.cmbEspecie.ValueMember = "SP_CONS_ESPECIES.ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'txtNomProd
        '
        Me.txtNomProd.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProd.Location = New System.Drawing.Point(104, 38)
        Me.txtNomProd.MaxLength = 40
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.Size = New System.Drawing.Size(384, 26)
        Me.txtNomProd.TabIndex = 4
        '
        'txtCodProd
        '
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(104, 6)
        Me.txtCodProd.MaxLength = 6
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(76, 26)
        Me.txtCodProd.TabIndex = 1
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProductor
        '
        Me.lblProductor.AutoSize = True
        Me.lblProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductor.Location = New System.Drawing.Point(33, 10)
        Me.lblProductor.Name = "lblProductor"
        Me.lblProductor.Size = New System.Drawing.Size(65, 19)
        Me.lblProductor.TabIndex = 0
        Me.lblProductor.Text = "Código"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.Imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(795, 526)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 6
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
        Me.btnGuardar.Location = New System.Drawing.Point(641, 526)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 4
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
        Me.btnNuevo.Location = New System.Drawing.Point(564, 526)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(854, 164)
        Me.Label12.TabIndex = 7
        '
        'dgvCatalogo
        '
        Me.dgvCatalogo.AllowUserToAddRows = False
        Me.dgvCatalogo.AllowUserToDeleteRows = False
        Me.dgvCatalogo.AllowUserToOrderColumns = True
        Me.dgvCatalogo.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        Me.dgvCatalogo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCatalogo.AutoGenerateColumns = False
        Me.dgvCatalogo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCatalogo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_PROD, Me.NOMBRE, Me.DIAS_CAD, Me.ID_REF, Me.NOM_REF, Me.ID_ESPECIE, Me.NOM_ESPECIE, Me.ID_FAM, Me.NOM_FAM, Me.ID_SFAM, Me.NOM_SFAM, Me.NOM_CUARTO, Me.NOM_CEXP, Me.ESTATUS})
        Me.dgvCatalogo.DataMember = "SP_CONS_PRODUCTOS"
        Me.dgvCatalogo.DataSource = Me.DsCatalogos
        Me.dgvCatalogo.Location = New System.Drawing.Point(14, 179)
        Me.dgvCatalogo.Name = "dgvCatalogo"
        Me.dgvCatalogo.ReadOnly = True
        Me.dgvCatalogo.RowHeadersVisible = False
        Me.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCatalogo.Size = New System.Drawing.Size(849, 341)
        Me.dgvCatalogo.StandardTab = True
        Me.dgvCatalogo.TabIndex = 2
        '
        'ID_PROD
        '
        Me.ID_PROD.DataPropertyName = "ID_PROD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID_PROD.DefaultCellStyle = DataGridViewCellStyle8
        Me.ID_PROD.HeaderText = "CODIGO"
        Me.ID_PROD.Name = "ID_PROD"
        Me.ID_PROD.ReadOnly = True
        Me.ID_PROD.Width = 70
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 250
        '
        'DIAS_CAD
        '
        Me.DIAS_CAD.DataPropertyName = "DIAS_CAD"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DIAS_CAD.DefaultCellStyle = DataGridViewCellStyle9
        Me.DIAS_CAD.HeaderText = "DIAS CAD."
        Me.DIAS_CAD.Name = "DIAS_CAD"
        Me.DIAS_CAD.ReadOnly = True
        Me.DIAS_CAD.Width = 90
        '
        'ID_REF
        '
        Me.ID_REF.DataPropertyName = "ID_REF"
        Me.ID_REF.HeaderText = "ID_REF"
        Me.ID_REF.Name = "ID_REF"
        Me.ID_REF.ReadOnly = True
        Me.ID_REF.Visible = False
        '
        'NOM_REF
        '
        Me.NOM_REF.DataPropertyName = "NOM_REF"
        Me.NOM_REF.HeaderText = "REFRIGERACION"
        Me.NOM_REF.Name = "NOM_REF"
        Me.NOM_REF.ReadOnly = True
        '
        'ID_ESPECIE
        '
        Me.ID_ESPECIE.DataPropertyName = "ID_ESPECIE"
        Me.ID_ESPECIE.HeaderText = "ID_ESPECIE"
        Me.ID_ESPECIE.Name = "ID_ESPECIE"
        Me.ID_ESPECIE.ReadOnly = True
        Me.ID_ESPECIE.Visible = False
        '
        'NOM_ESPECIE
        '
        Me.NOM_ESPECIE.DataPropertyName = "NOM_ESPECIE"
        Me.NOM_ESPECIE.HeaderText = "ESPECIE"
        Me.NOM_ESPECIE.Name = "NOM_ESPECIE"
        Me.NOM_ESPECIE.ReadOnly = True
        Me.NOM_ESPECIE.Width = 80
        '
        'ID_FAM
        '
        Me.ID_FAM.DataPropertyName = "ID_FAM"
        Me.ID_FAM.HeaderText = "ID_FAM"
        Me.ID_FAM.Name = "ID_FAM"
        Me.ID_FAM.ReadOnly = True
        Me.ID_FAM.Visible = False
        '
        'NOM_FAM
        '
        Me.NOM_FAM.DataPropertyName = "NOM_FAM"
        Me.NOM_FAM.HeaderText = "FAMILIA"
        Me.NOM_FAM.Name = "NOM_FAM"
        Me.NOM_FAM.ReadOnly = True
        '
        'ID_SFAM
        '
        Me.ID_SFAM.DataPropertyName = "ID_SFAM"
        Me.ID_SFAM.HeaderText = "ID_SFAM"
        Me.ID_SFAM.Name = "ID_SFAM"
        Me.ID_SFAM.ReadOnly = True
        Me.ID_SFAM.Visible = False
        '
        'NOM_SFAM
        '
        Me.NOM_SFAM.DataPropertyName = "NOM_SFAM"
        Me.NOM_SFAM.HeaderText = "SUBFAMILIA"
        Me.NOM_SFAM.Name = "NOM_SFAM"
        Me.NOM_SFAM.ReadOnly = True
        Me.NOM_SFAM.Width = 120
        '
        'NOM_CUARTO
        '
        Me.NOM_CUARTO.DataPropertyName = "NOM_CUARTO"
        Me.NOM_CUARTO.HeaderText = "CUARTO"
        Me.NOM_CUARTO.Name = "NOM_CUARTO"
        Me.NOM_CUARTO.ReadOnly = True
        '
        'NOM_CEXP
        '
        Me.NOM_CEXP.DataPropertyName = "NOM_CEXP"
        Me.NOM_CEXP.HeaderText = "NOM_CEXP"
        Me.NOM_CEXP.Name = "NOM_CEXP"
        Me.NOM_CEXP.ReadOnly = True
        Me.NOM_CEXP.Visible = False
        '
        'ESTATUS
        '
        Me.ESTATUS.DataPropertyName = "ESTATUS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ESTATUS.DefaultCellStyle = DataGridViewCellStyle10
        Me.ESTATUS.HeaderText = "ESTATUS"
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
        Me.ESTATUS.Width = 60
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(854, 347)
        Me.Label13.TabIndex = 1
        '
        'cmbClasifExp
        '
        Me.cmbClasifExp.DataSource = Me.DsCatalogos
        Me.cmbClasifExp.DisplayMember = "SP_CONS_CLASIFICACION_EXP.NOMBRE"
        Me.cmbClasifExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasifExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClasifExp.FormattingEnabled = True
        Me.cmbClasifExp.Location = New System.Drawing.Point(616, 129)
        Me.cmbClasifExp.Name = "cmbClasifExp"
        Me.cmbClasifExp.Size = New System.Drawing.Size(185, 24)
        Me.cmbClasifExp.TabIndex = 18
        Me.cmbClasifExp.ValueMember = "SP_CONS_CLASIFICACION_EXP.ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(516, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Clasif. Exp."
        '
        'frmCAT_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(878, 608)
        Me.Controls.Add(Me.dgvCatalogo)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCAT_Productos"
        Me.Text = "Productos"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDiasCaducidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomProd As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents lblProductor As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents numDiasCaducidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbSubfamilia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbRefrigeracion As System.Windows.Forms.ComboBox
    Friend WithEvents ID_CESP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbCuarto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ID_PROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAS_CAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_REF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESPECIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_ESPECIE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_FAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_FAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_SFAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_SFAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CUARTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CEXP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbClasifExp As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
