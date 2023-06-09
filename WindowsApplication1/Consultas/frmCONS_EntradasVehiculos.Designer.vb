<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_EntradasVehiculos
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rdbEntrada = New System.Windows.Forms.RadioButton()
        Me.rdbSacrificio = New System.Windows.Forms.RadioButton()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaSac = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReimpresion = New System.Windows.Forms.Button()
        Me.chkEspecieTodos = New System.Windows.Forms.CheckBox()
        Me.cmdGenerar = New System.Windows.Forms.Button()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtNomProductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaProductor = New System.Windows.Forms.TextBox()
        Me.lblIntr = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.cmbTipoEntrada = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.lblEspecie = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomProveedor = New System.Windows.Forms.TextBox()
        Me.txtMarcaProveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.REN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTEVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMTEVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CTE_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA_CTE_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CTE_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CTE_INTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA_CTE_INTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CTE_INTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CTE_PROV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA_CTE_PROV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CTE_PROV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTGANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMTGANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHASACRIFICIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAENTRADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAENTRADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHASALIDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORASALIDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOENTRADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOSALIDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESONETODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMMACHOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMTORETESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTMACHOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMHEMBRASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMVAQUILLASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTHEMBRASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTANIMALESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMGUIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOGUIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVEHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMVEHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMVEHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMMVEHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONDUCTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLACASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORRALESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIOCZMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FLEJEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESADA_MANUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbEntrada
        '
        Me.rdbEntrada.AutoSize = True
        Me.rdbEntrada.Location = New System.Drawing.Point(8, 91)
        Me.rdbEntrada.Name = "rdbEntrada"
        Me.rdbEntrada.Size = New System.Drawing.Size(62, 17)
        Me.rdbEntrada.TabIndex = 3
        Me.rdbEntrada.Text = "Entrada"
        Me.rdbEntrada.UseVisualStyleBackColor = True
        '
        'rdbSacrificio
        '
        Me.rdbSacrificio.AutoSize = True
        Me.rdbSacrificio.Checked = True
        Me.rdbSacrificio.Location = New System.Drawing.Point(8, 36)
        Me.rdbSacrificio.Name = "rdbSacrificio"
        Me.rdbSacrificio.Size = New System.Drawing.Size(68, 17)
        Me.rdbSacrificio.TabIndex = 1
        Me.rdbSacrificio.TabStop = True
        Me.rdbSacrificio.Text = "Sacrificio"
        Me.rdbSacrificio.UseVisualStyleBackColor = True
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(172, 76)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(99, 23)
        Me.dtpFechaIni.TabIndex = 5
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(172, 104)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(99, 23)
        Me.dtpFechaFin.TabIndex = 7
        '
        'dtpFechaSac
        '
        Me.dtpFechaSac.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSac.Location = New System.Drawing.Point(172, 33)
        Me.dtpFechaSac.Name = "dtpFechaSac"
        Me.dtpFechaSac.Size = New System.Drawing.Size(99, 23)
        Me.dtpFechaSac.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Final"
        '
        'btnReimpresion
        '
        Me.btnReimpresion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimpresion.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnReimpresion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReimpresion.Location = New System.Drawing.Point(496, 51)
        Me.btnReimpresion.Name = "btnReimpresion"
        Me.btnReimpresion.Size = New System.Drawing.Size(175, 50)
        Me.btnReimpresion.TabIndex = 18
        Me.btnReimpresion.Text = "Imprimir &Recibo"
        Me.btnReimpresion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReimpresion.UseVisualStyleBackColor = True
        '
        'chkEspecieTodos
        '
        Me.chkEspecieTodos.AutoSize = True
        Me.chkEspecieTodos.Location = New System.Drawing.Point(111, 61)
        Me.chkEspecieTodos.Name = "chkEspecieTodos"
        Me.chkEspecieTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkEspecieTodos.TabIndex = 4
        Me.chkEspecieTodos.Text = "Todas"
        Me.chkEspecieTodos.UseVisualStyleBackColor = True
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Search
        Me.cmdGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGenerar.Location = New System.Drawing.Point(496, 3)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(175, 50)
        Me.cmdGenerar.TabIndex = 17
        Me.cmdGenerar.Text = "&Buscar Entradas"
        Me.cmdGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGenerar.UseVisualStyleBackColor = True
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVistaPrevia.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVistaPrevia.Location = New System.Drawing.Point(496, 99)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(175, 50)
        Me.btnVistaPrevia.TabIndex = 19
        Me.btnVistaPrevia.Text = "Imprimir &Consulta"
        Me.btnVistaPrevia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(190, 118)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(288, 23)
        Me.txtNomIntroductor.TabIndex = 11
        '
        'txtNomProductor
        '
        Me.txtNomProductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomProductor.Enabled = False
        Me.txtNomProductor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProductor.Location = New System.Drawing.Point(190, 90)
        Me.txtNomProductor.MaxLength = 6
        Me.txtNomProductor.Name = "txtNomProductor"
        Me.txtNomProductor.Size = New System.Drawing.Size(288, 23)
        Me.txtNomProductor.TabIndex = 8
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(108, 118)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 23)
        Me.txtMarcaIntroductor.TabIndex = 10
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaProductor
        '
        Me.txtMarcaProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaProductor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaProductor.Location = New System.Drawing.Point(108, 90)
        Me.txtMarcaProductor.MaxLength = 6
        Me.txtMarcaProductor.Name = "txtMarcaProductor"
        Me.txtMarcaProductor.Size = New System.Drawing.Size(76, 23)
        Me.txtMarcaProductor.TabIndex = 7
        Me.txtMarcaProductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIntr
        '
        Me.lblIntr.AutoSize = True
        Me.lblIntr.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntr.Location = New System.Drawing.Point(8, 121)
        Me.lblIntr.Name = "lblIntr"
        Me.lblIntr.Size = New System.Drawing.Size(87, 16)
        Me.lblIntr.TabIndex = 9
        Me.lblIntr.Text = "Introductor"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Location = New System.Drawing.Point(8, 97)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(78, 16)
        Me.lblProd.TabIndex = 6
        Me.lblProd.Text = "Productor"
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(391, 52)
        Me.txtLote.MaxLength = 6
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(87, 26)
        Me.txtLote.TabIndex = 13
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.DataSource = Me.DsCatalogos
        Me.cmbTipoEntrada.DisplayMember = "SP_CONS_TIPOS_ENTRADA_VEHICULOS.NOMBRE"
        Me.cmbTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.FormattingEnabled = True
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(111, 27)
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(264, 24)
        Me.cmbTipoEntrada.TabIndex = 2
        Me.cmbTipoEntrada.ValueMember = "SP_CONS_TIPOS_ENTRADA_VEHICULOS.ID"
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Tipo Entrada"
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DataSource = Me.DsCatalogos
        Me.cmbEspecie.DisplayMember = "SP_CONS_ESPECIES.NOMBRE"
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Location = New System.Drawing.Point(173, 57)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(202, 24)
        Me.cmbEspecie.TabIndex = 5
        Me.cmbEspecie.ValueMember = "SP_CONS_ESPECIES.ID"
        '
        'lblEspecie
        '
        Me.lblEspecie.AutoSize = True
        Me.lblEspecie.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecie.ForeColor = System.Drawing.Color.Black
        Me.lblEspecie.Location = New System.Drawing.Point(8, 57)
        Me.lblEspecie.Name = "lblEspecie"
        Me.lblEspecie.Size = New System.Drawing.Size(64, 16)
        Me.lblEspecie.TabIndex = 3
        Me.lblEspecie.Text = "Especie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Lote"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(287, 153)
        Me.Label13.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.rdbEntrada)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaFin)
        Me.Panel8.Controls.Add(Me.rdbSacrificio)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.dtpFechaIni)
        Me.Panel8.Controls.Add(Me.dtpFechaSac)
        Me.Panel8.Location = New System.Drawing.Point(13, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(285, 151)
        Me.Panel8.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(-1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblProv)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtLote)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblEspecie)
        Me.Panel1.Controls.Add(Me.cmbEspecie)
        Me.Panel1.Controls.Add(Me.chkEspecieTodos)
        Me.Panel1.Controls.Add(Me.btnReimpresion)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.cmdGenerar)
        Me.Panel1.Controls.Add(Me.cmbTipoEntrada)
        Me.Panel1.Controls.Add(Me.btnVistaPrevia)
        Me.Panel1.Controls.Add(Me.lblProd)
        Me.Panel1.Controls.Add(Me.txtNomIntroductor)
        Me.Panel1.Controls.Add(Me.lblIntr)
        Me.Panel1.Controls.Add(Me.txtNomProductor)
        Me.Panel1.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel1.Controls.Add(Me.txtNomProveedor)
        Me.Panel1.Controls.Add(Me.txtMarcaProductor)
        Me.Panel1.Controls.Add(Me.txtMarcaProveedor)
        Me.Panel1.Location = New System.Drawing.Point(305, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 151)
        Me.Panel1.TabIndex = 3
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProv.Location = New System.Drawing.Point(19, 97)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(83, 16)
        Me.lblProv.TabIndex = 14
        Me.lblProv.Text = "Proveedor"
        Me.lblProv.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos opcionales para la búsqueda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomProveedor
        '
        Me.txtNomProveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomProveedor.Enabled = False
        Me.txtNomProveedor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProveedor.Location = New System.Drawing.Point(190, 91)
        Me.txtNomProveedor.MaxLength = 6
        Me.txtNomProveedor.Name = "txtNomProveedor"
        Me.txtNomProveedor.Size = New System.Drawing.Size(288, 23)
        Me.txtNomProveedor.TabIndex = 16
        Me.txtNomProveedor.Visible = False
        '
        'txtMarcaProveedor
        '
        Me.txtMarcaProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaProveedor.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaProveedor.Location = New System.Drawing.Point(108, 90)
        Me.txtMarcaProveedor.MaxLength = 6
        Me.txtMarcaProveedor.Name = "txtMarcaProveedor"
        Me.txtMarcaProveedor.Size = New System.Drawing.Size(76, 23)
        Me.txtMarcaProveedor.TabIndex = 15
        Me.txtMarcaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMarcaProveedor.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(678, 153)
        Me.Label8.TabIndex = 2
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
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
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REN, Me.ID_ENT, Me.IDTEVDataGridViewTextBoxColumn, Me.NOMTEVDataGridViewTextBoxColumn, Me.ID_CTE_PROD, Me.MARCA_CTE_PROD, Me.NOM_CTE_PROD, Me.ID_CTE_INTR, Me.MARCA_CTE_INTR, Me.NOM_CTE_INTR, Me.ID_CTE_PROV, Me.MARCA_CTE_PROV, Me.NOM_CTE_PROV, Me.IDESPECIEDataGridViewTextBoxColumn, Me.NOMESPECIEDataGridViewTextBoxColumn, Me.IDTGANDataGridViewTextBoxColumn, Me.NOMTGANDataGridViewTextBoxColumn, Me.LOTEDataGridViewTextBoxColumn, Me.FECHASACRIFICIODataGridViewTextBoxColumn, Me.FECHAENTRADADataGridViewTextBoxColumn, Me.HORAENTRADADataGridViewTextBoxColumn, Me.FECHASALIDADataGridViewTextBoxColumn, Me.HORASALIDADataGridViewTextBoxColumn, Me.PESOENTRADADataGridViewTextBoxColumn, Me.PESOSALIDADataGridViewTextBoxColumn, Me.PESONETODataGridViewTextBoxColumn, Me.NUMMACHOSGUIADataGridViewTextBoxColumn, Me.NUMHEMBRASGUIADataGridViewTextBoxColumn, Me.TOTANIMALESGUIADataGridViewTextBoxColumn, Me.NUMMACHOSDataGridViewTextBoxColumn, Me.NUMTORETESDataGridViewTextBoxColumn, Me.TOTMACHOSDataGridViewTextBoxColumn, Me.NUMHEMBRASDataGridViewTextBoxColumn, Me.NUMVAQUILLASDataGridViewTextBoxColumn, Me.TOTHEMBRASDataGridViewTextBoxColumn, Me.TOTANIMALESDataGridViewTextBoxColumn, Me.ORIGENDataGridViewTextBoxColumn, Me.NUMGUIADataGridViewTextBoxColumn, Me.PESOGUIADataGridViewTextBoxColumn, Me.IDVEHDataGridViewTextBoxColumn, Me.NOMVEHDataGridViewTextBoxColumn, Me.IDMVEHDataGridViewTextBoxColumn, Me.NOMMVEHDataGridViewTextBoxColumn, Me.CONDUCTORDataGridViewTextBoxColumn, Me.PLACASDataGridViewTextBoxColumn, Me.CORRALESDataGridViewTextBoxColumn, Me.FOLIOCZMDataGridViewTextBoxColumn, Me.FLEJEDataGridViewTextBoxColumn, Me.PESADA_MANUAL, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.ESTATUS})
        Me.dgvDatos.DataMember = "SP_CONS_ENTRADAS"
        Me.dgvDatos.DataSource = Me.DsCatalogos
        Me.dgvDatos.Location = New System.Drawing.Point(13, 162)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(967, 399)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 4
        '
        'REN
        '
        Me.REN.HeaderText = "#"
        Me.REN.Name = "REN"
        Me.REN.ReadOnly = True
        Me.REN.Width = 40
        '
        'ID_ENT
        '
        Me.ID_ENT.DataPropertyName = "ID_ENT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID_ENT.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID_ENT.HeaderText = "FOLIO"
        Me.ID_ENT.Name = "ID_ENT"
        Me.ID_ENT.ReadOnly = True
        Me.ID_ENT.Width = 70
        '
        'IDTEVDataGridViewTextBoxColumn
        '
        Me.IDTEVDataGridViewTextBoxColumn.DataPropertyName = "ID_TEV"
        Me.IDTEVDataGridViewTextBoxColumn.HeaderText = "ID_TEV"
        Me.IDTEVDataGridViewTextBoxColumn.Name = "IDTEVDataGridViewTextBoxColumn"
        Me.IDTEVDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDTEVDataGridViewTextBoxColumn.Visible = False
        '
        'NOMTEVDataGridViewTextBoxColumn
        '
        Me.NOMTEVDataGridViewTextBoxColumn.DataPropertyName = "NOM_TEV"
        Me.NOMTEVDataGridViewTextBoxColumn.HeaderText = "TIPO ENTRADA"
        Me.NOMTEVDataGridViewTextBoxColumn.Name = "NOMTEVDataGridViewTextBoxColumn"
        Me.NOMTEVDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMTEVDataGridViewTextBoxColumn.Width = 80
        '
        'ID_CTE_PROD
        '
        Me.ID_CTE_PROD.DataPropertyName = "ID_CTE_PROD"
        Me.ID_CTE_PROD.HeaderText = "ID_CTE_PROD"
        Me.ID_CTE_PROD.Name = "ID_CTE_PROD"
        Me.ID_CTE_PROD.ReadOnly = True
        Me.ID_CTE_PROD.Visible = False
        '
        'MARCA_CTE_PROD
        '
        Me.MARCA_CTE_PROD.DataPropertyName = "MARCA_CTE_PROD"
        Me.MARCA_CTE_PROD.HeaderText = "MARCA PROD."
        Me.MARCA_CTE_PROD.Name = "MARCA_CTE_PROD"
        Me.MARCA_CTE_PROD.ReadOnly = True
        Me.MARCA_CTE_PROD.Width = 60
        '
        'NOM_CTE_PROD
        '
        Me.NOM_CTE_PROD.DataPropertyName = "NOM_CTE_PROD"
        Me.NOM_CTE_PROD.HeaderText = "NOMBRE PRODUCTOR"
        Me.NOM_CTE_PROD.Name = "NOM_CTE_PROD"
        Me.NOM_CTE_PROD.ReadOnly = True
        '
        'ID_CTE_INTR
        '
        Me.ID_CTE_INTR.DataPropertyName = "ID_CTE_INTR"
        Me.ID_CTE_INTR.HeaderText = "ID_CTE_INTR"
        Me.ID_CTE_INTR.Name = "ID_CTE_INTR"
        Me.ID_CTE_INTR.ReadOnly = True
        Me.ID_CTE_INTR.Visible = False
        '
        'MARCA_CTE_INTR
        '
        Me.MARCA_CTE_INTR.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCA_CTE_INTR.HeaderText = "MARCA INTR."
        Me.MARCA_CTE_INTR.Name = "MARCA_CTE_INTR"
        Me.MARCA_CTE_INTR.ReadOnly = True
        Me.MARCA_CTE_INTR.Width = 60
        '
        'NOM_CTE_INTR
        '
        Me.NOM_CTE_INTR.DataPropertyName = "NOM_CTE_INTR"
        Me.NOM_CTE_INTR.HeaderText = "NOMBRE INTRODUCTOR"
        Me.NOM_CTE_INTR.Name = "NOM_CTE_INTR"
        Me.NOM_CTE_INTR.ReadOnly = True
        '
        'ID_CTE_PROV
        '
        Me.ID_CTE_PROV.DataPropertyName = "ID_CTE_PROV"
        Me.ID_CTE_PROV.HeaderText = "ID_CTE_PROV"
        Me.ID_CTE_PROV.Name = "ID_CTE_PROV"
        Me.ID_CTE_PROV.ReadOnly = True
        Me.ID_CTE_PROV.Visible = False
        '
        'MARCA_CTE_PROV
        '
        Me.MARCA_CTE_PROV.DataPropertyName = "MARCA_CTE_PROV"
        Me.MARCA_CTE_PROV.HeaderText = "MARCA PROV"
        Me.MARCA_CTE_PROV.Name = "MARCA_CTE_PROV"
        Me.MARCA_CTE_PROV.ReadOnly = True
        Me.MARCA_CTE_PROV.Visible = False
        Me.MARCA_CTE_PROV.Width = 60
        '
        'NOM_CTE_PROV
        '
        Me.NOM_CTE_PROV.DataPropertyName = "NOM_CTE_PROV"
        Me.NOM_CTE_PROV.HeaderText = "NOMBRE PROVEEDOR"
        Me.NOM_CTE_PROV.Name = "NOM_CTE_PROV"
        Me.NOM_CTE_PROV.ReadOnly = True
        Me.NOM_CTE_PROV.Visible = False
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
        Me.NOMESPECIEDataGridViewTextBoxColumn.Width = 80
        '
        'IDTGANDataGridViewTextBoxColumn
        '
        Me.IDTGANDataGridViewTextBoxColumn.DataPropertyName = "ID_TGAN"
        Me.IDTGANDataGridViewTextBoxColumn.HeaderText = "ID_TGAN"
        Me.IDTGANDataGridViewTextBoxColumn.Name = "IDTGANDataGridViewTextBoxColumn"
        Me.IDTGANDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDTGANDataGridViewTextBoxColumn.Visible = False
        '
        'NOMTGANDataGridViewTextBoxColumn
        '
        Me.NOMTGANDataGridViewTextBoxColumn.DataPropertyName = "NOM_TGAN"
        Me.NOMTGANDataGridViewTextBoxColumn.HeaderText = "TIPO GANADO"
        Me.NOMTGANDataGridViewTextBoxColumn.Name = "NOMTGANDataGridViewTextBoxColumn"
        Me.NOMTGANDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMTGANDataGridViewTextBoxColumn.Width = 80
        '
        'LOTEDataGridViewTextBoxColumn
        '
        Me.LOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.Name = "LOTEDataGridViewTextBoxColumn"
        Me.LOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LOTEDataGridViewTextBoxColumn.Width = 60
        '
        'FECHASACRIFICIODataGridViewTextBoxColumn
        '
        Me.FECHASACRIFICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_SACRIFICIO"
        Me.FECHASACRIFICIODataGridViewTextBoxColumn.HeaderText = "FECHA SACRIFICIO"
        Me.FECHASACRIFICIODataGridViewTextBoxColumn.Name = "FECHASACRIFICIODataGridViewTextBoxColumn"
        Me.FECHASACRIFICIODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHASACRIFICIODataGridViewTextBoxColumn.Width = 80
        '
        'FECHAENTRADADataGridViewTextBoxColumn
        '
        Me.FECHAENTRADADataGridViewTextBoxColumn.DataPropertyName = "FECHA_ENTRADA"
        Me.FECHAENTRADADataGridViewTextBoxColumn.HeaderText = "FECHA ENTRADA"
        Me.FECHAENTRADADataGridViewTextBoxColumn.Name = "FECHAENTRADADataGridViewTextBoxColumn"
        Me.FECHAENTRADADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAENTRADADataGridViewTextBoxColumn.Width = 80
        '
        'HORAENTRADADataGridViewTextBoxColumn
        '
        Me.HORAENTRADADataGridViewTextBoxColumn.DataPropertyName = "HORA_ENTRADA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.HORAENTRADADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.HORAENTRADADataGridViewTextBoxColumn.HeaderText = "HORA ENTRADA"
        Me.HORAENTRADADataGridViewTextBoxColumn.Name = "HORAENTRADADataGridViewTextBoxColumn"
        Me.HORAENTRADADataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAENTRADADataGridViewTextBoxColumn.Width = 80
        '
        'FECHASALIDADataGridViewTextBoxColumn
        '
        Me.FECHASALIDADataGridViewTextBoxColumn.DataPropertyName = "FECHA_SALIDA"
        Me.FECHASALIDADataGridViewTextBoxColumn.HeaderText = "FECHA SALIDA"
        Me.FECHASALIDADataGridViewTextBoxColumn.Name = "FECHASALIDADataGridViewTextBoxColumn"
        Me.FECHASALIDADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHASALIDADataGridViewTextBoxColumn.Width = 80
        '
        'HORASALIDADataGridViewTextBoxColumn
        '
        Me.HORASALIDADataGridViewTextBoxColumn.DataPropertyName = "HORA_SALIDA"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "t"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.HORASALIDADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.HORASALIDADataGridViewTextBoxColumn.HeaderText = "HORA SALIDA"
        Me.HORASALIDADataGridViewTextBoxColumn.Name = "HORASALIDADataGridViewTextBoxColumn"
        Me.HORASALIDADataGridViewTextBoxColumn.ReadOnly = True
        Me.HORASALIDADataGridViewTextBoxColumn.Width = 80
        '
        'PESOENTRADADataGridViewTextBoxColumn
        '
        Me.PESOENTRADADataGridViewTextBoxColumn.DataPropertyName = "PESO_ENTRADA"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESOENTRADADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PESOENTRADADataGridViewTextBoxColumn.HeaderText = "PESO ENTRADA"
        Me.PESOENTRADADataGridViewTextBoxColumn.Name = "PESOENTRADADataGridViewTextBoxColumn"
        Me.PESOENTRADADataGridViewTextBoxColumn.ReadOnly = True
        Me.PESOENTRADADataGridViewTextBoxColumn.Width = 80
        '
        'PESOSALIDADataGridViewTextBoxColumn
        '
        Me.PESOSALIDADataGridViewTextBoxColumn.DataPropertyName = "PESO_SALIDA"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESOSALIDADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PESOSALIDADataGridViewTextBoxColumn.HeaderText = "PESO SALIDA"
        Me.PESOSALIDADataGridViewTextBoxColumn.Name = "PESOSALIDADataGridViewTextBoxColumn"
        Me.PESOSALIDADataGridViewTextBoxColumn.ReadOnly = True
        Me.PESOSALIDADataGridViewTextBoxColumn.Width = 80
        '
        'PESONETODataGridViewTextBoxColumn
        '
        Me.PESONETODataGridViewTextBoxColumn.DataPropertyName = "PESO_NETO"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESONETODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PESONETODataGridViewTextBoxColumn.HeaderText = "PESO NETO"
        Me.PESONETODataGridViewTextBoxColumn.Name = "PESONETODataGridViewTextBoxColumn"
        Me.PESONETODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESONETODataGridViewTextBoxColumn.Width = 80
        '
        'NUMMACHOSGUIADataGridViewTextBoxColumn
        '
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn.DataPropertyName = "NUM_MACHOS_GUIA"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn.HeaderText = "MACHOS GUIA"
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn.Name = "NUMMACHOSGUIADataGridViewTextBoxColumn"
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMMACHOSGUIADataGridViewTextBoxColumn.Width = 60
        '
        'NUMHEMBRASGUIADataGridViewTextBoxColumn
        '
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn.DataPropertyName = "NUM_HEMBRAS_GUIA"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn.HeaderText = "HEMBRAS GUIA"
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn.Name = "NUMHEMBRASGUIADataGridViewTextBoxColumn"
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMHEMBRASGUIADataGridViewTextBoxColumn.Width = 60
        '
        'TOTANIMALESGUIADataGridViewTextBoxColumn
        '
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn.DataPropertyName = "TOT_ANIMALES_GUIA"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn.HeaderText = "ANIMALES GUIA"
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn.Name = "TOTANIMALESGUIADataGridViewTextBoxColumn"
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTANIMALESGUIADataGridViewTextBoxColumn.Width = 60
        '
        'NUMMACHOSDataGridViewTextBoxColumn
        '
        Me.NUMMACHOSDataGridViewTextBoxColumn.DataPropertyName = "NUM_MACHOS"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMMACHOSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.NUMMACHOSDataGridViewTextBoxColumn.HeaderText = "MACHOS"
        Me.NUMMACHOSDataGridViewTextBoxColumn.Name = "NUMMACHOSDataGridViewTextBoxColumn"
        Me.NUMMACHOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMMACHOSDataGridViewTextBoxColumn.Width = 60
        '
        'NUMTORETESDataGridViewTextBoxColumn
        '
        Me.NUMTORETESDataGridViewTextBoxColumn.DataPropertyName = "NUM_TORETES"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMTORETESDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.NUMTORETESDataGridViewTextBoxColumn.HeaderText = "TORETES"
        Me.NUMTORETESDataGridViewTextBoxColumn.Name = "NUMTORETESDataGridViewTextBoxColumn"
        Me.NUMTORETESDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMTORETESDataGridViewTextBoxColumn.Width = 60
        '
        'TOTMACHOSDataGridViewTextBoxColumn
        '
        Me.TOTMACHOSDataGridViewTextBoxColumn.DataPropertyName = "TOT_MACHOS"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTMACHOSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.TOTMACHOSDataGridViewTextBoxColumn.HeaderText = "TOTAL MACHOS"
        Me.TOTMACHOSDataGridViewTextBoxColumn.Name = "TOTMACHOSDataGridViewTextBoxColumn"
        Me.TOTMACHOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTMACHOSDataGridViewTextBoxColumn.Width = 60
        '
        'NUMHEMBRASDataGridViewTextBoxColumn
        '
        Me.NUMHEMBRASDataGridViewTextBoxColumn.DataPropertyName = "NUM_HEMBRAS"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMHEMBRASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.NUMHEMBRASDataGridViewTextBoxColumn.HeaderText = "HEMBRAS"
        Me.NUMHEMBRASDataGridViewTextBoxColumn.Name = "NUMHEMBRASDataGridViewTextBoxColumn"
        Me.NUMHEMBRASDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMHEMBRASDataGridViewTextBoxColumn.Width = 60
        '
        'NUMVAQUILLASDataGridViewTextBoxColumn
        '
        Me.NUMVAQUILLASDataGridViewTextBoxColumn.DataPropertyName = "NUM_VAQUILLAS"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMVAQUILLASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.NUMVAQUILLASDataGridViewTextBoxColumn.HeaderText = "VAQUILLAS"
        Me.NUMVAQUILLASDataGridViewTextBoxColumn.Name = "NUMVAQUILLASDataGridViewTextBoxColumn"
        Me.NUMVAQUILLASDataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMVAQUILLASDataGridViewTextBoxColumn.Width = 60
        '
        'TOTHEMBRASDataGridViewTextBoxColumn
        '
        Me.TOTHEMBRASDataGridViewTextBoxColumn.DataPropertyName = "TOT_HEMBRAS"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTHEMBRASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.TOTHEMBRASDataGridViewTextBoxColumn.HeaderText = "TOTAL HEMBRAS"
        Me.TOTHEMBRASDataGridViewTextBoxColumn.Name = "TOTHEMBRASDataGridViewTextBoxColumn"
        Me.TOTHEMBRASDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTHEMBRASDataGridViewTextBoxColumn.Width = 60
        '
        'TOTANIMALESDataGridViewTextBoxColumn
        '
        Me.TOTANIMALESDataGridViewTextBoxColumn.DataPropertyName = "TOT_ANIMALES"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TOTANIMALESDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.TOTANIMALESDataGridViewTextBoxColumn.HeaderText = "TOTAL ANIMALES"
        Me.TOTANIMALESDataGridViewTextBoxColumn.Name = "TOTANIMALESDataGridViewTextBoxColumn"
        Me.TOTANIMALESDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTANIMALESDataGridViewTextBoxColumn.Width = 60
        '
        'ORIGENDataGridViewTextBoxColumn
        '
        Me.ORIGENDataGridViewTextBoxColumn.DataPropertyName = "ORIGEN"
        Me.ORIGENDataGridViewTextBoxColumn.HeaderText = "ORIGEN"
        Me.ORIGENDataGridViewTextBoxColumn.Name = "ORIGENDataGridViewTextBoxColumn"
        Me.ORIGENDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NUMGUIADataGridViewTextBoxColumn
        '
        Me.NUMGUIADataGridViewTextBoxColumn.DataPropertyName = "NUM_GUIA"
        Me.NUMGUIADataGridViewTextBoxColumn.HeaderText = "NUM. GUIA"
        Me.NUMGUIADataGridViewTextBoxColumn.Name = "NUMGUIADataGridViewTextBoxColumn"
        Me.NUMGUIADataGridViewTextBoxColumn.ReadOnly = True
        Me.NUMGUIADataGridViewTextBoxColumn.Width = 60
        '
        'PESOGUIADataGridViewTextBoxColumn
        '
        Me.PESOGUIADataGridViewTextBoxColumn.DataPropertyName = "PESO_GUIA"
        Me.PESOGUIADataGridViewTextBoxColumn.HeaderText = "PESO GUIA"
        Me.PESOGUIADataGridViewTextBoxColumn.Name = "PESOGUIADataGridViewTextBoxColumn"
        Me.PESOGUIADataGridViewTextBoxColumn.ReadOnly = True
        Me.PESOGUIADataGridViewTextBoxColumn.Width = 60
        '
        'IDVEHDataGridViewTextBoxColumn
        '
        Me.IDVEHDataGridViewTextBoxColumn.DataPropertyName = "ID_VEH"
        Me.IDVEHDataGridViewTextBoxColumn.HeaderText = "ID_VEH"
        Me.IDVEHDataGridViewTextBoxColumn.Name = "IDVEHDataGridViewTextBoxColumn"
        Me.IDVEHDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDVEHDataGridViewTextBoxColumn.Visible = False
        '
        'NOMVEHDataGridViewTextBoxColumn
        '
        Me.NOMVEHDataGridViewTextBoxColumn.DataPropertyName = "NOM_VEH"
        Me.NOMVEHDataGridViewTextBoxColumn.HeaderText = "TIPO VEHICULO"
        Me.NOMVEHDataGridViewTextBoxColumn.Name = "NOMVEHDataGridViewTextBoxColumn"
        Me.NOMVEHDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDMVEHDataGridViewTextBoxColumn
        '
        Me.IDMVEHDataGridViewTextBoxColumn.DataPropertyName = "ID_MVEH"
        Me.IDMVEHDataGridViewTextBoxColumn.HeaderText = "ID_MVEH"
        Me.IDMVEHDataGridViewTextBoxColumn.Name = "IDMVEHDataGridViewTextBoxColumn"
        Me.IDMVEHDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMVEHDataGridViewTextBoxColumn.Visible = False
        '
        'NOMMVEHDataGridViewTextBoxColumn
        '
        Me.NOMMVEHDataGridViewTextBoxColumn.DataPropertyName = "NOM_MVEH"
        Me.NOMMVEHDataGridViewTextBoxColumn.HeaderText = "MARCA VEHICULO"
        Me.NOMMVEHDataGridViewTextBoxColumn.Name = "NOMMVEHDataGridViewTextBoxColumn"
        Me.NOMMVEHDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMMVEHDataGridViewTextBoxColumn.Width = 80
        '
        'CONDUCTORDataGridViewTextBoxColumn
        '
        Me.CONDUCTORDataGridViewTextBoxColumn.DataPropertyName = "CONDUCTOR"
        Me.CONDUCTORDataGridViewTextBoxColumn.HeaderText = "CONDUCTOR"
        Me.CONDUCTORDataGridViewTextBoxColumn.Name = "CONDUCTORDataGridViewTextBoxColumn"
        Me.CONDUCTORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PLACASDataGridViewTextBoxColumn
        '
        Me.PLACASDataGridViewTextBoxColumn.DataPropertyName = "PLACAS"
        Me.PLACASDataGridViewTextBoxColumn.HeaderText = "PLACAS"
        Me.PLACASDataGridViewTextBoxColumn.Name = "PLACASDataGridViewTextBoxColumn"
        Me.PLACASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CORRALESDataGridViewTextBoxColumn
        '
        Me.CORRALESDataGridViewTextBoxColumn.DataPropertyName = "CORRALES"
        Me.CORRALESDataGridViewTextBoxColumn.HeaderText = "CORRALES"
        Me.CORRALESDataGridViewTextBoxColumn.Name = "CORRALESDataGridViewTextBoxColumn"
        Me.CORRALESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FOLIOCZMDataGridViewTextBoxColumn
        '
        Me.FOLIOCZMDataGridViewTextBoxColumn.DataPropertyName = "FOLIO_CZM"
        Me.FOLIOCZMDataGridViewTextBoxColumn.HeaderText = "FOLIO CZM"
        Me.FOLIOCZMDataGridViewTextBoxColumn.Name = "FOLIOCZMDataGridViewTextBoxColumn"
        Me.FOLIOCZMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FOLIOCZMDataGridViewTextBoxColumn.Width = 80
        '
        'FLEJEDataGridViewTextBoxColumn
        '
        Me.FLEJEDataGridViewTextBoxColumn.DataPropertyName = "FLEJE"
        Me.FLEJEDataGridViewTextBoxColumn.HeaderText = "FLEJE"
        Me.FLEJEDataGridViewTextBoxColumn.Name = "FLEJEDataGridViewTextBoxColumn"
        Me.FLEJEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FLEJEDataGridViewTextBoxColumn.Width = 60
        '
        'PESADA_MANUAL
        '
        Me.PESADA_MANUAL.DataPropertyName = "PESADA_MANUAL"
        Me.PESADA_MANUAL.HeaderText = "PESADA_MANUAL"
        Me.PESADA_MANUAL.Name = "PESADA_MANUAL"
        Me.PESADA_MANUAL.ReadOnly = True
        Me.PESADA_MANUAL.Visible = False
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Width = 200
        '
        'ESTATUS
        '
        Me.ESTATUS.DataPropertyName = "ESTATUS"
        Me.ESTATUS.HeaderText = "ESTATUS"
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
        Me.ESTATUS.Width = 60
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(970, 403)
        Me.Label5.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 573)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(989, 22)
        Me.StatusStrip1.TabIndex = 6
        '
        'frmCONS_EntradasVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(989, 595)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCONS_EntradasVehiculos"
        Me.ShowInTaskbar = False
        Me.Text = "Consulta de entradas / salidas de vehiculos"
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSacrificio As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaSac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReimpresion As System.Windows.Forms.Button
    Friend WithEvents chkEspecieTodos As System.Windows.Forms.CheckBox
    Friend WithEvents cmdGenerar As System.Windows.Forms.Button
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaProductor As System.Windows.Forms.TextBox
    Friend WithEvents lblIntr As System.Windows.Forms.Label
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoEntrada As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents lblEspecie As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DsCatalogos As SistemaControlProduccion.dsCatalogos
    Friend WithEvents lblProv As System.Windows.Forms.Label
    Friend WithEvents txtMarcaProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProveedor As System.Windows.Forms.TextBox
    Friend WithEvents REN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTEVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMTEVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_CTE_PROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA_CTE_PROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CTE_PROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_CTE_INTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA_CTE_INTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CTE_INTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_CTE_PROV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA_CTE_PROV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CTE_PROV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESPECIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMESPECIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTGANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMTGANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHASACRIFICIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAENTRADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAENTRADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHASALIDADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORASALIDADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOENTRADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOSALIDADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESONETODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMMACHOSGUIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMHEMBRASGUIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTANIMALESGUIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMMACHOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMTORETESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTMACHOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMHEMBRASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMVAQUILLASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTHEMBRASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTANIMALESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMGUIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOGUIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDVEHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMVEHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMVEHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMMVEHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONDUCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CORRALESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIOCZMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLEJEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESADA_MANUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
