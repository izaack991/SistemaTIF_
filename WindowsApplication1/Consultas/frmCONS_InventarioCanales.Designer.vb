<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_InventarioCanales
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCajasDisponibles = New System.Windows.Forms.Label()
        Me.dgvDisponibles = New System.Windows.Forms.DataGridView()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.DsMovimientos = New SistemaControlProduccion.dsMovimientos()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ID_ESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAESDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAESDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECDIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAYORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VACIADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ENMANTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DECOMISO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ESTATUS_ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCESADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(95, 34)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(302, 26)
        Me.txtNomIntroductor.TabIndex = 2
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(13, 34)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 1
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbProductos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 82)
        Me.Panel1.TabIndex = 0
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(11, 33)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(237, 24)
        Me.cmbProductos.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(-1, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos del Producto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 85)
        Me.Label4.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.chkTodos)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Location = New System.Drawing.Point(283, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 83)
        Me.Panel2.TabIndex = 3
        '
        'btnAtualizar
        '
        Me.btnAtualizar.FlatAppearance.BorderSize = 0
        Me.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAtualizar.Location = New System.Drawing.Point(408, 15)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(72, 57)
        Me.btnAtualizar.TabIndex = 4
        Me.btnAtualizar.Text = "Actualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(486, 15)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(341, 64)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(563, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos del introductor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(565, 86)
        Me.Label6.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(837, 489)
        Me.Label9.TabIndex = 41
        '
        'lblCajasDisponibles
        '
        Me.lblCajasDisponibles.BackColor = System.Drawing.SystemColors.Control
        Me.lblCajasDisponibles.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajasDisponibles.ForeColor = System.Drawing.Color.Maroon
        Me.lblCajasDisponibles.Location = New System.Drawing.Point(12, 104)
        Me.lblCajasDisponibles.Name = "lblCajasDisponibles"
        Me.lblCajasDisponibles.Size = New System.Drawing.Size(833, 23)
        Me.lblCajasDisponibles.TabIndex = 5
        Me.lblCajasDisponibles.Text = "Canales disponibles"
        Me.lblCajasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDisponibles
        '
        Me.dgvDisponibles.AllowUserToAddRows = False
        Me.dgvDisponibles.AllowUserToDeleteRows = False
        Me.dgvDisponibles.AllowUserToOrderColumns = True
        Me.dgvDisponibles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvDisponibles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDisponibles.AutoGenerateColumns = False
        Me.dgvDisponibles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisponibles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ESC, Me.ID_MOV, Me.ID_ALM, Me.FOLIODataGridViewTextBoxColumn1, Me.IDCTEPRODDataGridViewTextBoxColumn1, Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1, Me.IDCTEINTRDataGridViewTextBoxColumn1, Me.MARCACTEINTRDataGridViewTextBoxColumn1, Me.IDCTEDESTDataGridViewTextBoxColumn, Me.MARCACTEDESTDataGridViewTextBoxColumn1, Me.FECHADataGridViewTextBoxColumn1, Me.HORADataGridViewTextBoxColumn1, Me.LOTE, Me.OBSERVACIONESDataGridViewTextBoxColumn1, Me.ESTATUSDataGridViewTextBoxColumn1, Me.ID_ESD, Me.ID_PROD, Me.PIEZASDataGridViewTextBoxColumn1, Me.PESODataGridViewTextBoxColumn1, Me.TARADataGridViewTextBoxColumn1, Me.FECHAESDDataGridViewTextBoxColumn1, Me.HORAESDDataGridViewTextBoxColumn1, Me.CONSECDIADataGridViewTextBoxColumn, Me.SERIEDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.LADODataGridViewTextBoxColumn, Me.SERIEIDDataGridViewTextBoxColumn, Me.SEXODataGridViewTextBoxColumn, Me.MAYORDataGridViewTextBoxColumn, Me.VACIADADataGridViewTextBoxColumn, Me.ENMANTADODataGridViewTextBoxColumn, Me.DECOMISO, Me.ESTATUS_ESD, Me.PROCESADODataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn1})
        Me.dgvDisponibles.DataMember = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CANAL"
        Me.dgvDisponibles.DataSource = Me.DsSacrificio
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDisponibles.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDisponibles.Location = New System.Drawing.Point(11, 130)
        Me.dgvDisponibles.Name = "dgvDisponibles"
        Me.dgvDisponibles.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisponibles.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDisponibles.RowHeadersVisible = False
        Me.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisponibles.Size = New System.Drawing.Size(835, 471)
        Me.dgvDisponibles.StandardTab = True
        Me.dgvDisponibles.TabIndex = 6
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsMovimientos
        '
        Me.DsMovimientos.DataSetName = "dsMovimientos"
        Me.DsMovimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip1.TabIndex = 7
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel3.Text = "F2|Nuevo"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "F3|Buscar"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel2.Text = "F5|Actualizar"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel4.Text = "F9|Imprimir"
        '
        'ID_ESC
        '
        Me.ID_ESC.DataPropertyName = "ID_ESC"
        Me.ID_ESC.HeaderText = "ID_ESC"
        Me.ID_ESC.Name = "ID_ESC"
        Me.ID_ESC.ReadOnly = True
        Me.ID_ESC.Visible = False
        '
        'ID_MOV
        '
        Me.ID_MOV.DataPropertyName = "ID_MOV"
        Me.ID_MOV.HeaderText = "ID_MOV"
        Me.ID_MOV.Name = "ID_MOV"
        Me.ID_MOV.ReadOnly = True
        Me.ID_MOV.Visible = False
        '
        'ID_ALM
        '
        Me.ID_ALM.DataPropertyName = "ID_ALM"
        Me.ID_ALM.HeaderText = "ID_ALM"
        Me.ID_ALM.Name = "ID_ALM"
        Me.ID_ALM.ReadOnly = True
        Me.ID_ALM.Visible = False
        '
        'FOLIODataGridViewTextBoxColumn1
        '
        Me.FOLIODataGridViewTextBoxColumn1.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn1.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn1.Name = "FOLIODataGridViewTextBoxColumn1"
        Me.FOLIODataGridViewTextBoxColumn1.ReadOnly = True
        Me.FOLIODataGridViewTextBoxColumn1.Visible = False
        '
        'IDCTEPRODDataGridViewTextBoxColumn1
        '
        Me.IDCTEPRODDataGridViewTextBoxColumn1.DataPropertyName = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn1.HeaderText = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn1.Name = "IDCTEPRODDataGridViewTextBoxColumn1"
        Me.IDCTEPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDCTEPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1
        '
        Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_PROD"
        Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1.HeaderText = "MARCA_CTE_PROD"
        Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1.Name = "MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1"
        Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'IDCTEINTRDataGridViewTextBoxColumn1
        '
        Me.IDCTEINTRDataGridViewTextBoxColumn1.DataPropertyName = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn1.HeaderText = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn1.Name = "IDCTEINTRDataGridViewTextBoxColumn1"
        Me.IDCTEINTRDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDCTEINTRDataGridViewTextBoxColumn1.Visible = False
        '
        'MARCACTEINTRDataGridViewTextBoxColumn1
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_INTR"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.HeaderText = "INTRODUCTOR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.Name = "MARCACTEINTRDataGridViewTextBoxColumn1"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IDCTEDESTDataGridViewTextBoxColumn
        '
        Me.IDCTEDESTDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.HeaderText = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.Name = "IDCTEDESTDataGridViewTextBoxColumn"
        Me.IDCTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEDESTDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn1
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.HeaderText = "DESTINO"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Name = "MARCACTEDESTDataGridViewTextBoxColumn1"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Width = 70
        '
        'FECHADataGridViewTextBoxColumn1
        '
        Me.FECHADataGridViewTextBoxColumn1.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn1.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn1.Name = "FECHADataGridViewTextBoxColumn1"
        Me.FECHADataGridViewTextBoxColumn1.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn1.Width = 80
        '
        'HORADataGridViewTextBoxColumn1
        '
        Me.HORADataGridViewTextBoxColumn1.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn1.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn1.Name = "HORADataGridViewTextBoxColumn1"
        Me.HORADataGridViewTextBoxColumn1.ReadOnly = True
        Me.HORADataGridViewTextBoxColumn1.Visible = False
        '
        'LOTE
        '
        Me.LOTE.DataPropertyName = "LOTE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.LOTE.DefaultCellStyle = DataGridViewCellStyle4
        Me.LOTE.HeaderText = "LOTE"
        Me.LOTE.Name = "LOTE"
        Me.LOTE.ReadOnly = True
        Me.LOTE.Width = 50
        '
        'OBSERVACIONESDataGridViewTextBoxColumn1
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn1.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn1.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn1.Name = "OBSERVACIONESDataGridViewTextBoxColumn1"
        Me.OBSERVACIONESDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn1.Visible = False
        '
        'ESTATUSDataGridViewTextBoxColumn1
        '
        Me.ESTATUSDataGridViewTextBoxColumn1.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn1.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn1.Name = "ESTATUSDataGridViewTextBoxColumn1"
        Me.ESTATUSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ESTATUSDataGridViewTextBoxColumn1.Visible = False
        '
        'ID_ESD
        '
        Me.ID_ESD.DataPropertyName = "ID_ESD"
        Me.ID_ESD.HeaderText = "ID_ESD"
        Me.ID_ESD.Name = "ID_ESD"
        Me.ID_ESD.ReadOnly = True
        Me.ID_ESD.Visible = False
        '
        'ID_PROD
        '
        Me.ID_PROD.DataPropertyName = "ID_PROD"
        Me.ID_PROD.HeaderText = "ID_PROD"
        Me.ID_PROD.Name = "ID_PROD"
        Me.ID_PROD.ReadOnly = True
        Me.ID_PROD.Visible = False
        '
        'PIEZASDataGridViewTextBoxColumn1
        '
        Me.PIEZASDataGridViewTextBoxColumn1.DataPropertyName = "PIEZAS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PIEZASDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.PIEZASDataGridViewTextBoxColumn1.HeaderText = "PZAS"
        Me.PIEZASDataGridViewTextBoxColumn1.Name = "PIEZASDataGridViewTextBoxColumn1"
        Me.PIEZASDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn1.Visible = False
        Me.PIEZASDataGridViewTextBoxColumn1.Width = 50
        '
        'PESODataGridViewTextBoxColumn1
        '
        Me.PESODataGridViewTextBoxColumn1.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn1.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn1.Name = "PESODataGridViewTextBoxColumn1"
        Me.PESODataGridViewTextBoxColumn1.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn1.Width = 60
        '
        'TARADataGridViewTextBoxColumn1
        '
        Me.TARADataGridViewTextBoxColumn1.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn1.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn1.Name = "TARADataGridViewTextBoxColumn1"
        Me.TARADataGridViewTextBoxColumn1.ReadOnly = True
        Me.TARADataGridViewTextBoxColumn1.Visible = False
        Me.TARADataGridViewTextBoxColumn1.Width = 50
        '
        'FECHAESDDataGridViewTextBoxColumn1
        '
        Me.FECHAESDDataGridViewTextBoxColumn1.DataPropertyName = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn1.HeaderText = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn1.Name = "FECHAESDDataGridViewTextBoxColumn1"
        Me.FECHAESDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FECHAESDDataGridViewTextBoxColumn1.Visible = False
        '
        'HORAESDDataGridViewTextBoxColumn1
        '
        Me.HORAESDDataGridViewTextBoxColumn1.DataPropertyName = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn1.HeaderText = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn1.Name = "HORAESDDataGridViewTextBoxColumn1"
        Me.HORAESDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.HORAESDDataGridViewTextBoxColumn1.Visible = False
        '
        'CONSECDIADataGridViewTextBoxColumn
        '
        Me.CONSECDIADataGridViewTextBoxColumn.DataPropertyName = "CONSEC_DIA"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CONSECDIADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CONSECDIADataGridViewTextBoxColumn.HeaderText = "CONSEC."
        Me.CONSECDIADataGridViewTextBoxColumn.Name = "CONSECDIADataGridViewTextBoxColumn"
        Me.CONSECDIADataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSECDIADataGridViewTextBoxColumn.Width = 60
        '
        'SERIEDataGridViewTextBoxColumn
        '
        Me.SERIEDataGridViewTextBoxColumn.DataPropertyName = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.HeaderText = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.Name = "SERIEDataGridViewTextBoxColumn"
        Me.SERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SERIEDataGridViewTextBoxColumn.Visible = False
        Me.SERIEDataGridViewTextBoxColumn.Width = 50
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'LADODataGridViewTextBoxColumn
        '
        Me.LADODataGridViewTextBoxColumn.DataPropertyName = "LADO"
        Me.LADODataGridViewTextBoxColumn.HeaderText = "LADO"
        Me.LADODataGridViewTextBoxColumn.Name = "LADODataGridViewTextBoxColumn"
        Me.LADODataGridViewTextBoxColumn.ReadOnly = True
        Me.LADODataGridViewTextBoxColumn.Visible = False
        Me.LADODataGridViewTextBoxColumn.Width = 50
        '
        'SERIEIDDataGridViewTextBoxColumn
        '
        Me.SERIEIDDataGridViewTextBoxColumn.DataPropertyName = "SERIE_ID"
        Me.SERIEIDDataGridViewTextBoxColumn.HeaderText = "SERIE_ID"
        Me.SERIEIDDataGridViewTextBoxColumn.Name = "SERIEIDDataGridViewTextBoxColumn"
        Me.SERIEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SERIEIDDataGridViewTextBoxColumn.Width = 80
        '
        'SEXODataGridViewTextBoxColumn
        '
        Me.SEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.HeaderText = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.Name = "SEXODataGridViewTextBoxColumn"
        Me.SEXODataGridViewTextBoxColumn.ReadOnly = True
        Me.SEXODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SEXODataGridViewTextBoxColumn.Width = 40
        '
        'MAYORDataGridViewTextBoxColumn
        '
        Me.MAYORDataGridViewTextBoxColumn.DataPropertyName = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn.FalseValue = "0"
        Me.MAYORDataGridViewTextBoxColumn.HeaderText = "MAYOR"
        Me.MAYORDataGridViewTextBoxColumn.Name = "MAYORDataGridViewTextBoxColumn"
        Me.MAYORDataGridViewTextBoxColumn.ReadOnly = True
        Me.MAYORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MAYORDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MAYORDataGridViewTextBoxColumn.TrueValue = "1"
        Me.MAYORDataGridViewTextBoxColumn.Width = 50
        '
        'VACIADADataGridViewTextBoxColumn
        '
        Me.VACIADADataGridViewTextBoxColumn.DataPropertyName = "VACIADA"
        Me.VACIADADataGridViewTextBoxColumn.FalseValue = "0"
        Me.VACIADADataGridViewTextBoxColumn.HeaderText = "VACIADA"
        Me.VACIADADataGridViewTextBoxColumn.Name = "VACIADADataGridViewTextBoxColumn"
        Me.VACIADADataGridViewTextBoxColumn.ReadOnly = True
        Me.VACIADADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VACIADADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VACIADADataGridViewTextBoxColumn.TrueValue = "1"
        Me.VACIADADataGridViewTextBoxColumn.Width = 60
        '
        'ENMANTADODataGridViewTextBoxColumn
        '
        Me.ENMANTADODataGridViewTextBoxColumn.DataPropertyName = "ENMANTADO"
        Me.ENMANTADODataGridViewTextBoxColumn.FalseValue = "0"
        Me.ENMANTADODataGridViewTextBoxColumn.HeaderText = "KOSHER"
        Me.ENMANTADODataGridViewTextBoxColumn.Name = "ENMANTADODataGridViewTextBoxColumn"
        Me.ENMANTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ENMANTADODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENMANTADODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ENMANTADODataGridViewTextBoxColumn.TrueValue = "1"
        Me.ENMANTADODataGridViewTextBoxColumn.Width = 80
        '
        'DECOMISO
        '
        Me.DECOMISO.DataPropertyName = "DECOMISO"
        Me.DECOMISO.FalseValue = "0"
        Me.DECOMISO.HeaderText = "DECOMISO"
        Me.DECOMISO.Name = "DECOMISO"
        Me.DECOMISO.ReadOnly = True
        Me.DECOMISO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DECOMISO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DECOMISO.TrueValue = "1"
        Me.DECOMISO.Width = 80
        '
        'ESTATUS_ESD
        '
        Me.ESTATUS_ESD.DataPropertyName = "ESTATUS_ESD"
        Me.ESTATUS_ESD.HeaderText = "ESTATUS_ESD"
        Me.ESTATUS_ESD.Name = "ESTATUS_ESD"
        Me.ESTATUS_ESD.ReadOnly = True
        Me.ESTATUS_ESD.Visible = False
        '
        'PROCESADODataGridViewTextBoxColumn
        '
        Me.PROCESADODataGridViewTextBoxColumn.DataPropertyName = "PROCESADO"
        Me.PROCESADODataGridViewTextBoxColumn.HeaderText = "PROCESADO"
        Me.PROCESADODataGridViewTextBoxColumn.Name = "PROCESADODataGridViewTextBoxColumn"
        Me.PROCESADODataGridViewTextBoxColumn.ReadOnly = True
        Me.PROCESADODataGridViewTextBoxColumn.Visible = False
        '
        'NOMPRODDataGridViewTextBoxColumn1
        '
        Me.NOMPRODDataGridViewTextBoxColumn1.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn1.Name = "NOMPRODDataGridViewTextBoxColumn1"
        Me.NOMPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'frmCONS_InventarioCanales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(859, 639)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblCajasDisponibles)
        Me.Controls.Add(Me.dgvDisponibles)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCONS_InventarioCanales"
        Me.ShowInTaskbar = False
        Me.Text = "Inventario de canales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvDisponibles As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCajasDisponibles As System.Windows.Forms.Label
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsMovimientos As SistemaControlProduccion.dsMovimientos
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ID_ESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_MOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCAMARCA_CTE_PRODCTEPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAESDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAESDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECDIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAYORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VACIADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ENMANTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DECOMISO As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ESTATUS_ESD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROCESADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
