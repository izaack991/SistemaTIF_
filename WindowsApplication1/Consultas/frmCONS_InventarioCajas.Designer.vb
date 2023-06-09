<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_InventarioCajas
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnImprimir2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCajasDisponibles = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DsCajas = New SistemaControlProduccion.dsCajas()
        Me.dgvDisponibles = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotCajas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIASCADUCIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACADUCIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJACODBARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbalmori = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(95, 26)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(300, 26)
        Me.txtNomIntroductor.TabIndex = 2
        Me.txtNomIntroductor.TabStop = False
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(13, 26)
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
        Me.Panel1.Controls.Add(Me.cmbEspecie)
        Me.Panel1.Controls.Add(Me.cmbProductos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 82)
        Me.Panel1.TabIndex = 0
        '
        'cmbEspecie
        '
        Me.cmbEspecie.DataSource = Me.DsCatalogos
        Me.cmbEspecie.DisplayMember = "SP_CONS_ESPECIES.NOMBRE"
        Me.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecie.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEspecie.FormattingEnabled = True
        Me.cmbEspecie.Location = New System.Drawing.Point(30, 33)
        Me.cmbEspecie.Name = "cmbEspecie"
        Me.cmbEspecie.Size = New System.Drawing.Size(202, 24)
        Me.cmbEspecie.TabIndex = 6
        Me.cmbEspecie.ValueMember = "SP_CONS_ESPECIES.ID"
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(111, 53)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(35, 24)
        Me.cmbProductos.TabIndex = 0
        Me.cmbProductos.Visible = False
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
        Me.Label2.Text = "Datos de la especie"
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
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cmbalmori)
        Me.Panel2.Controls.Add(Me.btnImprimir2)
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Controls.Add(Me.chkTodos)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Location = New System.Drawing.Point(283, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(696, 83)
        Me.Panel2.TabIndex = 3
        '
        'btnImprimir2
        '
        Me.btnImprimir2.FlatAppearance.BorderSize = 0
        Me.btnImprimir2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir2.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir2.Location = New System.Drawing.Point(619, 14)
        Me.btnImprimir2.Name = "btnImprimir2"
        Me.btnImprimir2.Size = New System.Drawing.Size(72, 63)
        Me.btnImprimir2.TabIndex = 88
        Me.btnImprimir2.Text = "&Resumen"
        Me.btnImprimir2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(541, 15)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 63)
        Me.btnImprimir.TabIndex = 87
        Me.btnImprimir.Text = "&Detalle"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.FlatAppearance.BorderSize = 0
        Me.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAtualizar.Location = New System.Drawing.Point(463, 14)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(72, 63)
        Me.btnAtualizar.TabIndex = 4
        Me.btnAtualizar.Text = "&Actualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(401, 32)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        Me.chkTodos.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(622, 23)
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
        Me.Label6.Size = New System.Drawing.Size(699, 86)
        Me.Label6.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(665, 501)
        Me.Label9.TabIndex = 41
        '
        'lblCajasDisponibles
        '
        Me.lblCajasDisponibles.BackColor = System.Drawing.SystemColors.Control
        Me.lblCajasDisponibles.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajasDisponibles.ForeColor = System.Drawing.Color.Maroon
        Me.lblCajasDisponibles.Location = New System.Drawing.Point(12, 104)
        Me.lblCajasDisponibles.Name = "lblCajasDisponibles"
        Me.lblCajasDisponibles.Size = New System.Drawing.Size(661, 23)
        Me.lblCajasDisponibles.TabIndex = 5
        Me.lblCajasDisponibles.Text = "Inventario (Detalle)"
        Me.lblCajasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1187, 22)
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
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvDisponibles
        '
        Me.dgvDisponibles.AllowUserToAddRows = False
        Me.dgvDisponibles.AllowUserToDeleteRows = False
        Me.dgvDisponibles.AllowUserToOrderColumns = True
        Me.dgvDisponibles.AllowUserToResizeRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.Lavender
        Me.dgvDisponibles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvDisponibles.AutoGenerateColumns = False
        Me.dgvDisponibles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisponibles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvDisponibles.ColumnHeadersHeight = 34
        Me.dgvDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.LOTEDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.IDPRODCTEDataGridViewTextBoxColumn, Me.NOMBREPRODCTEDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.TARADataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.CONSECLOTEDataGridViewTextBoxColumn, Me.DIASCADUCIDADDataGridViewTextBoxColumn, Me.FECHACADUCIDADDataGridViewTextBoxColumn, Me.CAJAFECHAETIQDataGridViewTextBoxColumn, Me.CAJACODBARDataGridViewTextBoxColumn, Me.UBICACION})
        Me.dgvDisponibles.DataMember = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS"
        Me.dgvDisponibles.DataSource = Me.DsCajas
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDisponibles.DefaultCellStyle = DataGridViewCellStyle27
        Me.dgvDisponibles.Location = New System.Drawing.Point(11, 130)
        Me.dgvDisponibles.Name = "dgvDisponibles"
        Me.dgvDisponibles.ReadOnly = True
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisponibles.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvDisponibles.RowHeadersVisible = False
        Me.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisponibles.Size = New System.Drawing.Size(663, 471)
        Me.dgvDisponibles.StandardTab = True
        Me.dgvDisponibles.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(681, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Inventario (Resumen)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(679, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(498, 501)
        Me.Label5.TabIndex = 44
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.Lavender
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.CAJAS, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.DataGridView1.DataMember = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN"
        Me.DataGridView1.DataSource = Me.DsCajas
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridView1.Location = New System.Drawing.Point(681, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(494, 471)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 45
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_ALM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_ALM"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID_CTE_INTR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID_CTE_INTR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MARCA_CTE_INTR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "INTR."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ID_PROD"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PROD. ORIGINAL"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "NOM_PROD"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PRODUCTO ORIGINAL"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ID_PRODCTE"
        Me.DataGridViewTextBoxColumn19.HeaderText = "PROD. CTE."
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 60
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NOMBRE_PRODCTE"
        Me.DataGridViewTextBoxColumn20.HeaderText = "PRODUCTO"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 200
        '
        'CAJAS
        '
        Me.CAJAS.DataPropertyName = "CAJAS"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CAJAS.DefaultCellStyle = DataGridViewCellStyle31
        Me.CAJAS.HeaderText = "CAJAS"
        Me.CAJAS.Name = "CAJAS"
        Me.CAJAS.ReadOnly = True
        Me.CAJAS.Width = 40
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PIEZAS"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn21.HeaderText = "PIEZAS"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 50
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PESO"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn22.HeaderText = "PESO"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 50
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TARA"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewTextBoxColumn23.HeaderText = "TARA"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTotCajas)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(985, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 83)
        Me.Panel3.TabIndex = 46
        '
        'txtTotCajas
        '
        Me.txtTotCajas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotCajas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCajas.Location = New System.Drawing.Point(24, 34)
        Me.txtTotCajas.MaxLength = 6
        Me.txtTotCajas.Name = "txtTotCajas"
        Me.txtTotCajas.ReadOnly = True
        Me.txtTotCajas.Size = New System.Drawing.Size(145, 26)
        Me.txtTotCajas.TabIndex = 0
        Me.txtTotCajas.TabStop = False
        Me.txtTotCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(-1, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total de Cajas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(984, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 86)
        Me.Label8.TabIndex = 47
        '
        'MARCACTEINTRDataGridViewTextBoxColumn
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "INTR."
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Name = "MARCACTEINTRDataGridViewTextBoxColumn"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LOTEDataGridViewTextBoxColumn
        '
        Me.LOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.Name = "LOTEDataGridViewTextBoxColumn"
        Me.LOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "PROD. ORIGINAL"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDPRODCTEDataGridViewTextBoxColumn
        '
        Me.IDPRODCTEDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODCTE"
        Me.IDPRODCTEDataGridViewTextBoxColumn.HeaderText = "PROD. CTE"
        Me.IDPRODCTEDataGridViewTextBoxColumn.Name = "IDPRODCTEDataGridViewTextBoxColumn"
        Me.IDPRODCTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREPRODCTEDataGridViewTextBoxColumn
        '
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PRODCTE"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.HeaderText = "PRODUCTO"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.Name = "NOMBREPRODCTEDataGridViewTextBoxColumn"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TARADataGridViewTextBoxColumn
        '
        Me.TARADataGridViewTextBoxColumn.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn.Name = "TARADataGridViewTextBoxColumn"
        Me.TARADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAIDDataGridViewTextBoxColumn
        '
        Me.CAJAIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.Name = "CAJAIDDataGridViewTextBoxColumn"
        Me.CAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONSECLOTEDataGridViewTextBoxColumn
        '
        Me.CONSECLOTEDataGridViewTextBoxColumn.DataPropertyName = "CONSEC_LOTE"
        Me.CONSECLOTEDataGridViewTextBoxColumn.HeaderText = "CONSEC_LOTE"
        Me.CONSECLOTEDataGridViewTextBoxColumn.Name = "CONSECLOTEDataGridViewTextBoxColumn"
        Me.CONSECLOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DIASCADUCIDADDataGridViewTextBoxColumn
        '
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.DataPropertyName = "DIAS_CADUCIDAD"
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.HeaderText = "DIAS_CADUCIDAD"
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.Name = "DIASCADUCIDADDataGridViewTextBoxColumn"
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHACADUCIDADDataGridViewTextBoxColumn
        '
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CADUCIDAD"
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.HeaderText = "FECHA_CADUCIDAD"
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.Name = "FECHACADUCIDADDataGridViewTextBoxColumn"
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAFECHAETIQDataGridViewTextBoxColumn
        '
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.DataPropertyName = "CAJA_FECHA_ETIQ"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.HeaderText = "FECHA ETIQUETA"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.Name = "CAJAFECHAETIQDataGridViewTextBoxColumn"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJACODBARDataGridViewTextBoxColumn
        '
        Me.CAJACODBARDataGridViewTextBoxColumn.DataPropertyName = "CAJA_CODBAR"
        Me.CAJACODBARDataGridViewTextBoxColumn.HeaderText = "CODIGO BARRAS"
        Me.CAJACODBARDataGridViewTextBoxColumn.Name = "CAJACODBARDataGridViewTextBoxColumn"
        Me.CAJACODBARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UBICACION
        '
        Me.UBICACION.DataPropertyName = "UBICACION"
        Me.UBICACION.HeaderText = "UBICACION"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        '
        'cmbalmori
        '
        Me.cmbalmori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmori.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbalmori.FormattingEnabled = True
        Me.cmbalmori.Location = New System.Drawing.Point(95, 54)
        Me.cmbalmori.Name = "cmbalmori"
        Me.cmbalmori.Size = New System.Drawing.Size(300, 24)
        Me.cmbalmori.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(9, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 23)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Alm."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCONS_InventarioCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1187, 639)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvDisponibles)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblCajasDisponibles)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCONS_InventarioCajas"
        Me.ShowInTaskbar = False
        Me.Text = "Inventario de Cajas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCajasDisponibles As System.Windows.Forms.Label
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DsCatalogos As SistemaControlProduccion.dsCatalogos
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents DsCajas As SistemaControlProduccion.dsCajas
    Friend WithEvents dgvDisponibles As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTotCajas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir2 As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbalmori As System.Windows.Forms.ComboBox
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREPRODCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASCADUCIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACADUCIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAFECHAETIQDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJACODBARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICACION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
