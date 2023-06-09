<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAT_ProductosCte
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CHKMP = New System.Windows.Forms.CheckBox()
        Me.TXTNOMPRODPADRE = New System.Windows.Forms.TextBox()
        Me.TXTPRODPADRE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbClasifExp = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCuarto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreProdCte = New System.Windows.Forms.TextBox()
        Me.txtCodProdCte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrefijo = New System.Windows.Forms.TextBox()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IDCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRECTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PROD_CTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIASCADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMFAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSFAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMSFAMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CUARTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS_PROD_CTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCEXPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCEXPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROD_PADRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROD_MP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 591)
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
        Me.btnCancelar.Location = New System.Drawing.Point(718, 531)
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
        Me.Panel8.Controls.Add(Me.CHKMP)
        Me.Panel8.Controls.Add(Me.TXTNOMPRODPADRE)
        Me.Panel8.Controls.Add(Me.TXTPRODPADRE)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.cmbClasifExp)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.cmbCuarto)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.txtNombreProdCte)
        Me.Panel8.Controls.Add(Me.txtCodProdCte)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.txtPrefijo)
        Me.Panel8.Controls.Add(Me.txtNomIntroductor)
        Me.Panel8.Controls.Add(Me.txtMarcaIntroductor)
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
        Me.Panel8.Size = New System.Drawing.Size(848, 201)
        Me.Panel8.TabIndex = 0
        '
        'CHKMP
        '
        Me.CHKMP.AutoSize = True
        Me.CHKMP.Location = New System.Drawing.Point(109, 142)
        Me.CHKMP.Name = "CHKMP"
        Me.CHKMP.Size = New System.Drawing.Size(47, 20)
        Me.CHKMP.TabIndex = 29
        Me.CHKMP.Text = "MP"
        Me.CHKMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHKMP.UseVisualStyleBackColor = True
        '
        'TXTNOMPRODPADRE
        '
        Me.TXTNOMPRODPADRE.BackColor = System.Drawing.SystemColors.Window
        Me.TXTNOMPRODPADRE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMPRODPADRE.Location = New System.Drawing.Point(191, 111)
        Me.TXTNOMPRODPADRE.MaxLength = 40
        Me.TXTNOMPRODPADRE.Name = "TXTNOMPRODPADRE"
        Me.TXTNOMPRODPADRE.Size = New System.Drawing.Size(302, 26)
        Me.TXTNOMPRODPADRE.TabIndex = 28
        '
        'TXTPRODPADRE
        '
        Me.TXTPRODPADRE.BackColor = System.Drawing.SystemColors.Window
        Me.TXTPRODPADRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPRODPADRE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRODPADRE.Location = New System.Drawing.Point(109, 111)
        Me.TXTPRODPADRE.MaxLength = 4
        Me.TXTPRODPADRE.Name = "TXTPRODPADRE"
        Me.TXTPRODPADRE.Size = New System.Drawing.Size(76, 26)
        Me.TXTPRODPADRE.TabIndex = 27
        Me.TXTPRODPADRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Producto Padre"
        '
        'cmbClasifExp
        '
        Me.cmbClasifExp.DataSource = Me.DsCatalogos
        Me.cmbClasifExp.DisplayMember = "SP_CONS_CLASIFICACION_EXP.NOMBRE"
        Me.cmbClasifExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClasifExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClasifExp.FormattingEnabled = True
        Me.cmbClasifExp.Location = New System.Drawing.Point(621, 168)
        Me.cmbClasifExp.Name = "cmbClasifExp"
        Me.cmbClasifExp.Size = New System.Drawing.Size(185, 24)
        Me.cmbClasifExp.TabIndex = 25
        Me.cmbClasifExp.ValueMember = "SP_CONS_CLASIFICACION_EXP.ID"
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.EnforceConstraints = False
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(521, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Clasif. Exp."
        '
        'cmbCuarto
        '
        Me.cmbCuarto.DataSource = Me.DsCatalogos
        Me.cmbCuarto.DisplayMember = "SP_CONS_CUARTOS.NOMBRE"
        Me.cmbCuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuarto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuarto.FormattingEnabled = True
        Me.cmbCuarto.Location = New System.Drawing.Point(621, 138)
        Me.cmbCuarto.Name = "cmbCuarto"
        Me.cmbCuarto.Size = New System.Drawing.Size(185, 24)
        Me.cmbCuarto.TabIndex = 23
        Me.cmbCuarto.ValueMember = "SP_CONS_CUARTOS.ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Cuarto"
        '
        'txtNombreProdCte
        '
        Me.txtNombreProdCte.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreProdCte.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProdCte.Location = New System.Drawing.Point(191, 79)
        Me.txtNombreProdCte.MaxLength = 40
        Me.txtNombreProdCte.Name = "txtNombreProdCte"
        Me.txtNombreProdCte.Size = New System.Drawing.Size(302, 26)
        Me.txtNombreProdCte.TabIndex = 21
        '
        'txtCodProdCte
        '
        Me.txtCodProdCte.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodProdCte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProdCte.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProdCte.Location = New System.Drawing.Point(109, 79)
        Me.txtCodProdCte.MaxLength = 4
        Me.txtCodProdCte.Name = "txtCodProdCte"
        Me.txtCodProdCte.Size = New System.Drawing.Size(76, 26)
        Me.txtCodProdCte.TabIndex = 20
        Me.txtCodProdCte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(557, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Prefijo"
        '
        'txtPrefijo
        '
        Me.txtPrefijo.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPrefijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrefijo.Enabled = False
        Me.txtPrefijo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefijo.Location = New System.Drawing.Point(621, 13)
        Me.txtPrefijo.MaxLength = 2
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.ReadOnly = True
        Me.txtPrefijo.Size = New System.Drawing.Size(76, 26)
        Me.txtPrefijo.TabIndex = 4
        Me.txtPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(191, 13)
        Me.txtNomIntroductor.MaxLength = 60
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(302, 26)
        Me.txtNomIntroductor.TabIndex = 2
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(109, 13)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 1
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(29, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cliente"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Refrigeración"
        '
        'cmbRefrigeracion
        '
        Me.cmbRefrigeracion.DataSource = Me.DsCatalogos
        Me.cmbRefrigeracion.DisplayMember = "SP_CONS_REFRIGERACION.NOMBRE"
        Me.cmbRefrigeracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRefrigeracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefrigeracion.FormattingEnabled = True
        Me.cmbRefrigeracion.Location = New System.Drawing.Point(347, 164)
        Me.cmbRefrigeracion.Name = "cmbRefrigeracion"
        Me.cmbRefrigeracion.Size = New System.Drawing.Size(146, 24)
        Me.cmbRefrigeracion.TabIndex = 13
        Me.cmbRefrigeracion.ValueMember = "SP_CONS_REFRIGERACION.ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(526, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Subfamilia"
        '
        'cmbSubfamilia
        '
        Me.cmbSubfamilia.DataSource = Me.DsCatalogos
        Me.cmbSubfamilia.DisplayMember = "SP_CONS_SUBFAMILIAS.NOMBRE"
        Me.cmbSubfamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubfamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubfamilia.FormattingEnabled = True
        Me.cmbSubfamilia.Location = New System.Drawing.Point(621, 108)
        Me.cmbSubfamilia.Name = "cmbSubfamilia"
        Me.cmbSubfamilia.Size = New System.Drawing.Size(185, 24)
        Me.cmbSubfamilia.TabIndex = 19
        Me.cmbSubfamilia.ValueMember = "SP_CONS_SUBFAMILIAS.ID_SFAM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Familia"
        '
        'cmbFamilia
        '
        Me.cmbFamilia.DataSource = Me.DsCatalogos
        Me.cmbFamilia.DisplayMember = "SP_CONS_FAMILIAS.NOMBRE"
        Me.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(621, 78)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(185, 24)
        Me.cmbFamilia.TabIndex = 17
        Me.cmbFamilia.ValueMember = "SP_CONS_FAMILIAS.ID"
        '
        'numDiasCaducidad
        '
        Me.numDiasCaducidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiasCaducidad.Location = New System.Drawing.Point(169, 164)
        Me.numDiasCaducidad.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numDiasCaducidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDiasCaducidad.Name = "numDiasCaducidad"
        Me.numDiasCaducidad.Size = New System.Drawing.Size(54, 26)
        Me.numDiasCaducidad.TabIndex = 11
        Me.numDiasCaducidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDiasCaducidad.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'lblEstatus
        '
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.Location = New System.Drawing.Point(704, 13)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(139, 26)
        Me.lblEstatus.TabIndex = 7
        Me.lblEstatus.Text = "Estatus"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Días Caducidad"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(545, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Especie"
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DataSource = Me.DsCatalogos
        Me.cmbEspecie.DisplayMember = "SP_CONS_ESPECIES.NOMBRE"
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Location = New System.Drawing.Point(621, 48)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(185, 24)
        Me.cmbEspecie.TabIndex = 15
        Me.cmbEspecie.ValueMember = "SP_CONS_ESPECIES.ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Producto/Cliente"
        '
        'txtNomProd
        '
        Me.txtNomProd.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomProd.Enabled = False
        Me.txtNomProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProd.Location = New System.Drawing.Point(191, 45)
        Me.txtNomProd.MaxLength = 40
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.ReadOnly = True
        Me.txtNomProd.Size = New System.Drawing.Size(302, 26)
        Me.txtNomProd.TabIndex = 9
        '
        'txtCodProd
        '
        Me.txtCodProd.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(109, 45)
        Me.txtCodProd.MaxLength = 6
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(76, 26)
        Me.txtCodProd.TabIndex = 6
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProductor
        '
        Me.lblProductor.AutoSize = True
        Me.lblProductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductor.Location = New System.Drawing.Point(38, 48)
        Me.lblProductor.Name = "lblProductor"
        Me.lblProductor.Size = New System.Drawing.Size(65, 19)
        Me.lblProductor.TabIndex = 5
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
        Me.btnImprimir.Location = New System.Drawing.Point(795, 531)
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
        Me.btnGuardar.Location = New System.Drawing.Point(641, 531)
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
        Me.btnNuevo.Location = New System.Drawing.Point(564, 531)
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
        Me.Label12.Size = New System.Drawing.Size(854, 207)
        Me.Label12.TabIndex = 7
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCatalogo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCTEDataGridViewTextBoxColumn, Me.MARCACTEDataGridViewTextBoxColumn, Me.NOMBRECTEDataGridViewTextBoxColumn, Me.ID_PROD_CTE, Me.NOMBREPRODCTEDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.DIASCADDataGridViewTextBoxColumn, Me.IDESPECIEDataGridViewTextBoxColumn, Me.NOMESPECIEDataGridViewTextBoxColumn, Me.IDFAMDataGridViewTextBoxColumn, Me.NOMFAMDataGridViewTextBoxColumn, Me.IDSFAMDataGridViewTextBoxColumn, Me.NOMSFAMDataGridViewTextBoxColumn, Me.NOM_CUARTO, Me.ESTATUS_PROD_CTE, Me.IDREFDataGridViewTextBoxColumn, Me.NOMREFDataGridViewTextBoxColumn, Me.IDCEXPDataGridViewTextBoxColumn, Me.NOMCEXPDataGridViewTextBoxColumn, Me.ESTATUSDataGridViewTextBoxColumn, Me.PROD_PADRE, Me.PROD_MP})
        Me.dgvCatalogo.DataMember = "SP_CONS_PRODUCTOS_X_CTE"
        Me.dgvCatalogo.DataSource = Me.DsCatalogos
        Me.dgvCatalogo.Location = New System.Drawing.Point(14, 222)
        Me.dgvCatalogo.Name = "dgvCatalogo"
        Me.dgvCatalogo.ReadOnly = True
        Me.dgvCatalogo.RowHeadersVisible = False
        Me.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCatalogo.Size = New System.Drawing.Size(849, 303)
        Me.dgvCatalogo.StandardTab = True
        Me.dgvCatalogo.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(854, 309)
        Me.Label13.TabIndex = 1
        '
        'IDCTEDataGridViewTextBoxColumn
        '
        Me.IDCTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE"
        Me.IDCTEDataGridViewTextBoxColumn.HeaderText = "ID_CTE"
        Me.IDCTEDataGridViewTextBoxColumn.Name = "IDCTEDataGridViewTextBoxColumn"
        Me.IDCTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDataGridViewTextBoxColumn
        '
        Me.MARCACTEDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE"
        Me.MARCACTEDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE"
        Me.MARCACTEDataGridViewTextBoxColumn.Name = "MARCACTEDataGridViewTextBoxColumn"
        Me.MARCACTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEDataGridViewTextBoxColumn.Visible = False
        '
        'NOMBRECTEDataGridViewTextBoxColumn
        '
        Me.NOMBRECTEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CTE"
        Me.NOMBRECTEDataGridViewTextBoxColumn.HeaderText = "NOMBRE_CTE"
        Me.NOMBRECTEDataGridViewTextBoxColumn.Name = "NOMBRECTEDataGridViewTextBoxColumn"
        Me.NOMBRECTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBRECTEDataGridViewTextBoxColumn.Visible = False
        '
        'ID_PROD_CTE
        '
        Me.ID_PROD_CTE.DataPropertyName = "ID_PROD_CTE"
        Me.ID_PROD_CTE.HeaderText = "CODIGO"
        Me.ID_PROD_CTE.Name = "ID_PROD_CTE"
        Me.ID_PROD_CTE.ReadOnly = True
        Me.ID_PROD_CTE.Width = 60
        '
        'NOMBREPRODCTEDataGridViewTextBoxColumn
        '
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PROD_CTE"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.HeaderText = "PRODUCTO"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.Name = "NOMBREPRODCTEDataGridViewTextBoxColumn"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.Width = 250
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn.Visible = False
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Visible = False
        '
        'DIASCADDataGridViewTextBoxColumn
        '
        Me.DIASCADDataGridViewTextBoxColumn.DataPropertyName = "DIAS_CAD"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DIASCADDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DIASCADDataGridViewTextBoxColumn.HeaderText = "DIAS CADUCIDAD"
        Me.DIASCADDataGridViewTextBoxColumn.Name = "DIASCADDataGridViewTextBoxColumn"
        Me.DIASCADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDESPECIEDataGridViewTextBoxColumn
        '
        Me.IDESPECIEDataGridViewTextBoxColumn.DataPropertyName = "ID_ESPECIE"
        Me.IDESPECIEDataGridViewTextBoxColumn.HeaderText = "ID_ESPECIE"
        Me.IDESPECIEDataGridViewTextBoxColumn.Name = "IDESPECIEDataGridViewTextBoxColumn"
        Me.IDESPECIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESPECIEDataGridViewTextBoxColumn.Visible = False
        '
        'NOMESPECIEDataGridViewTextBoxColumn
        '
        Me.NOMESPECIEDataGridViewTextBoxColumn.DataPropertyName = "NOM_ESPECIE"
        Me.NOMESPECIEDataGridViewTextBoxColumn.HeaderText = "ESPECIE"
        Me.NOMESPECIEDataGridViewTextBoxColumn.Name = "NOMESPECIEDataGridViewTextBoxColumn"
        Me.NOMESPECIEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDFAMDataGridViewTextBoxColumn
        '
        Me.IDFAMDataGridViewTextBoxColumn.DataPropertyName = "ID_FAM"
        Me.IDFAMDataGridViewTextBoxColumn.HeaderText = "ID_FAM"
        Me.IDFAMDataGridViewTextBoxColumn.Name = "IDFAMDataGridViewTextBoxColumn"
        Me.IDFAMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDFAMDataGridViewTextBoxColumn.Visible = False
        '
        'NOMFAMDataGridViewTextBoxColumn
        '
        Me.NOMFAMDataGridViewTextBoxColumn.DataPropertyName = "NOM_FAM"
        Me.NOMFAMDataGridViewTextBoxColumn.HeaderText = "FAMILIA"
        Me.NOMFAMDataGridViewTextBoxColumn.Name = "NOMFAMDataGridViewTextBoxColumn"
        Me.NOMFAMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDSFAMDataGridViewTextBoxColumn
        '
        Me.IDSFAMDataGridViewTextBoxColumn.DataPropertyName = "ID_SFAM"
        Me.IDSFAMDataGridViewTextBoxColumn.HeaderText = "ID_SFAM"
        Me.IDSFAMDataGridViewTextBoxColumn.Name = "IDSFAMDataGridViewTextBoxColumn"
        Me.IDSFAMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDSFAMDataGridViewTextBoxColumn.Visible = False
        '
        'NOMSFAMDataGridViewTextBoxColumn
        '
        Me.NOMSFAMDataGridViewTextBoxColumn.DataPropertyName = "NOM_SFAM"
        Me.NOMSFAMDataGridViewTextBoxColumn.HeaderText = "SUBFAMILIA"
        Me.NOMSFAMDataGridViewTextBoxColumn.Name = "NOMSFAMDataGridViewTextBoxColumn"
        Me.NOMSFAMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOM_CUARTO
        '
        Me.NOM_CUARTO.DataPropertyName = "NOM_CUARTO"
        Me.NOM_CUARTO.HeaderText = "CUARTO"
        Me.NOM_CUARTO.Name = "NOM_CUARTO"
        Me.NOM_CUARTO.ReadOnly = True
        '
        'ESTATUS_PROD_CTE
        '
        Me.ESTATUS_PROD_CTE.DataPropertyName = "ESTATUS_PROD_CTE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ESTATUS_PROD_CTE.DefaultCellStyle = DataGridViewCellStyle4
        Me.ESTATUS_PROD_CTE.HeaderText = "ESTATUS"
        Me.ESTATUS_PROD_CTE.Name = "ESTATUS_PROD_CTE"
        Me.ESTATUS_PROD_CTE.ReadOnly = True
        Me.ESTATUS_PROD_CTE.Width = 60
        '
        'IDREFDataGridViewTextBoxColumn
        '
        Me.IDREFDataGridViewTextBoxColumn.DataPropertyName = "ID_REF"
        Me.IDREFDataGridViewTextBoxColumn.HeaderText = "ID_REF"
        Me.IDREFDataGridViewTextBoxColumn.Name = "IDREFDataGridViewTextBoxColumn"
        Me.IDREFDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDREFDataGridViewTextBoxColumn.Visible = False
        '
        'NOMREFDataGridViewTextBoxColumn
        '
        Me.NOMREFDataGridViewTextBoxColumn.DataPropertyName = "NOM_REF"
        Me.NOMREFDataGridViewTextBoxColumn.HeaderText = "NOM_REF"
        Me.NOMREFDataGridViewTextBoxColumn.Name = "NOMREFDataGridViewTextBoxColumn"
        Me.NOMREFDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMREFDataGridViewTextBoxColumn.Visible = False
        '
        'IDCEXPDataGridViewTextBoxColumn
        '
        Me.IDCEXPDataGridViewTextBoxColumn.DataPropertyName = "ID_CEXP"
        Me.IDCEXPDataGridViewTextBoxColumn.HeaderText = "ID_CEXP"
        Me.IDCEXPDataGridViewTextBoxColumn.Name = "IDCEXPDataGridViewTextBoxColumn"
        Me.IDCEXPDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCEXPDataGridViewTextBoxColumn.Visible = False
        '
        'NOMCEXPDataGridViewTextBoxColumn
        '
        Me.NOMCEXPDataGridViewTextBoxColumn.DataPropertyName = "NOM_CEXP"
        Me.NOMCEXPDataGridViewTextBoxColumn.HeaderText = "NOM_CEXP"
        Me.NOMCEXPDataGridViewTextBoxColumn.Name = "NOMCEXPDataGridViewTextBoxColumn"
        Me.NOMCEXPDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCEXPDataGridViewTextBoxColumn.Visible = False
        '
        'ESTATUSDataGridViewTextBoxColumn
        '
        Me.ESTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.Name = "ESTATUSDataGridViewTextBoxColumn"
        Me.ESTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'PROD_PADRE
        '
        Me.PROD_PADRE.DataPropertyName = "PROD_PADRE"
        Me.PROD_PADRE.HeaderText = "PROD_PADRE"
        Me.PROD_PADRE.Name = "PROD_PADRE"
        Me.PROD_PADRE.ReadOnly = True
        '
        'PROD_MP
        '
        Me.PROD_MP.DataPropertyName = "PROD_MP"
        Me.PROD_MP.HeaderText = "PROD_MP"
        Me.PROD_MP.Name = "PROD_MP"
        Me.PROD_MP.ReadOnly = True
        '
        'frmCAT_ProductosCte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(878, 613)
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
        Me.KeyPreview = True
        Me.Name = "frmCAT_ProductosCte"
        Me.Text = "Productos para Sala de Cortes"
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
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreProdCte As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProdCte As System.Windows.Forms.TextBox
    Friend WithEvents ID_CESP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbCuarto As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbClasifExp As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMPRODPADRE As System.Windows.Forms.TextBox
    Friend WithEvents TXTPRODPADRE As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CHKMP As System.Windows.Forms.CheckBox
    Friend WithEvents IDCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRECTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PROD_CTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREPRODCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASCADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESPECIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMESPECIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDFAMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMFAMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSFAMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMSFAMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CUARTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS_PROD_CTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCEXPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCEXPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROD_PADRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROD_MP As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
