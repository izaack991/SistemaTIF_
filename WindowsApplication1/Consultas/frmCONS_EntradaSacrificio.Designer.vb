<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_EntradaSacrificio
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.chkcorte = New System.Windows.Forms.CheckBox()
        Me.btnimprimir3 = New System.Windows.Forms.Button()
        Me.btnImprimir2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.REN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAC_LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANALESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO_ENTRADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO_SALIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESO_NETO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CABEZAS_ENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RENDIMIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.DsCatalogosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 2
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "F5|Actualizar"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(680, 21)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaIni.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(548, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha Inicial"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.Location = New System.Drawing.Point(1216, 212)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(71, 63)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'chkcorte
        '
        Me.chkcorte.AutoSize = True
        Me.chkcorte.Location = New System.Drawing.Point(820, 37)
        Me.chkcorte.Name = "chkcorte"
        Me.chkcorte.Size = New System.Drawing.Size(57, 17)
        Me.chkcorte.TabIndex = 88
        Me.chkcorte.Text = "Corte?"
        Me.chkcorte.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkcorte.UseVisualStyleBackColor = True
        '
        'btnimprimir3
        '
        Me.btnimprimir3.FlatAppearance.BorderSize = 0
        Me.btnimprimir3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnimprimir3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir3.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir3.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnimprimir3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnimprimir3.Location = New System.Drawing.Point(179, 8)
        Me.btnimprimir3.Name = "btnimprimir3"
        Me.btnimprimir3.Size = New System.Drawing.Size(44, 53)
        Me.btnimprimir3.TabIndex = 87
        Me.btnimprimir3.Text = "&Grafico"
        Me.btnimprimir3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir3.UseVisualStyleBackColor = True
        '
        'btnImprimir2
        '
        Me.btnImprimir2.FlatAppearance.BorderSize = 0
        Me.btnImprimir2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir2.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir2.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir2.Location = New System.Drawing.Point(4, 8)
        Me.btnImprimir2.Name = "btnImprimir2"
        Me.btnImprimir2.Size = New System.Drawing.Size(71, 53)
        Me.btnImprimir2.TabIndex = 86
        Me.btnImprimir2.Text = "&Rendimiento"
        Me.btnImprimir2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(87, 8)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 53)
        Me.btnImprimir.TabIndex = 85
        Me.btnImprimir.Text = "&Cobranza"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(135, 22)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(394, 24)
        Me.cmbProductos.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Producto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(217, 52)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(312, 26)
        Me.txtNomIntroductor.TabIndex = 2
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(135, 52)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 1
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Introductor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(557, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(680, 53)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaFin.TabIndex = 6
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.Lavender
        Me.dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dgvDatos.ColumnHeadersHeight = 40
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REN, Me.SAC_LOTE, Me.IDMOVDataGridViewTextBoxColumn, Me.NOMMOVDataGridViewTextBoxColumn, Me.IDALMDataGridViewTextBoxColumn, Me.NOMALMDataGridViewTextBoxColumn, Me.IDCTEINTRDataGridViewTextBoxColumn, Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.NOMCTEINTRDataGridViewTextBoxColumn, Me.IDCTEDESTDataGridViewTextBoxColumn, Me.MARCACTEDESTDataGridViewTextBoxColumn, Me.NOMCTEDESTDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.ESTATUSDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.CANALESDataGridViewTextBoxColumn, Me.PESO, Me.PESO_ENTRADA, Me.PESO_SALIDA, Me.PESO_NETO, Me.CABEZAS_ENT, Me.RENDIMIENTO})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_COBRANZA_CANAL"
        Me.dgvDatos.DataSource = Me.DsSacrificio
        Me.dgvDatos.Location = New System.Drawing.Point(12, 145)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(1331, 330)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 1
        '
        'REN
        '
        Me.REN.HeaderText = "#"
        Me.REN.Name = "REN"
        Me.REN.ReadOnly = True
        Me.REN.Width = 40
        '
        'SAC_LOTE
        '
        Me.SAC_LOTE.DataPropertyName = "SAC_LOTE"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "N0"
        DataGridViewCellStyle33.NullValue = Nothing
        Me.SAC_LOTE.DefaultCellStyle = DataGridViewCellStyle33
        Me.SAC_LOTE.HeaderText = "LOTE"
        Me.SAC_LOTE.Name = "SAC_LOTE"
        Me.SAC_LOTE.ReadOnly = True
        Me.SAC_LOTE.Width = 60
        '
        'IDMOVDataGridViewTextBoxColumn
        '
        Me.IDMOVDataGridViewTextBoxColumn.DataPropertyName = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.HeaderText = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.Name = "IDMOVDataGridViewTextBoxColumn"
        Me.IDMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMOVDataGridViewTextBoxColumn.Visible = False
        '
        'NOMMOVDataGridViewTextBoxColumn
        '
        Me.NOMMOVDataGridViewTextBoxColumn.DataPropertyName = "NOM_MOV"
        Me.NOMMOVDataGridViewTextBoxColumn.HeaderText = "NOM_MOV"
        Me.NOMMOVDataGridViewTextBoxColumn.Name = "NOMMOVDataGridViewTextBoxColumn"
        Me.NOMMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMMOVDataGridViewTextBoxColumn.Visible = False
        '
        'IDALMDataGridViewTextBoxColumn
        '
        Me.IDALMDataGridViewTextBoxColumn.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.Name = "IDALMDataGridViewTextBoxColumn"
        Me.IDALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDALMDataGridViewTextBoxColumn.Visible = False
        '
        'NOMALMDataGridViewTextBoxColumn
        '
        Me.NOMALMDataGridViewTextBoxColumn.DataPropertyName = "NOM_ALM"
        Me.NOMALMDataGridViewTextBoxColumn.HeaderText = "NOM_ALM"
        Me.NOMALMDataGridViewTextBoxColumn.Name = "NOMALMDataGridViewTextBoxColumn"
        Me.NOMALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMALMDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEINTRDataGridViewTextBoxColumn
        '
        Me.IDCTEINTRDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn.HeaderText = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn.Name = "IDCTEINTRDataGridViewTextBoxColumn"
        Me.IDCTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEINTRDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEINTRDataGridViewTextBoxColumn
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "MARCA INTR."
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Name = "MARCACTEINTRDataGridViewTextBoxColumn"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Width = 120
        '
        'NOMCTEINTRDataGridViewTextBoxColumn
        '
        Me.NOMCTEINTRDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_INTR"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.HeaderText = "NOMBRE INTRODUCTOR"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Name = "NOMCTEINTRDataGridViewTextBoxColumn"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Width = 180
        '
        'IDCTEDESTDataGridViewTextBoxColumn
        '
        Me.IDCTEDESTDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.HeaderText = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn.Name = "IDCTEDESTDataGridViewTextBoxColumn"
        Me.IDCTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEDESTDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.HeaderText = "MARCA DEST."
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Name = "MARCACTEDESTDataGridViewTextBoxColumn"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Width = 120
        '
        'NOMCTEDESTDataGridViewTextBoxColumn
        '
        Me.NOMCTEDESTDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_DEST"
        Me.NOMCTEDESTDataGridViewTextBoxColumn.HeaderText = "NOMBRE DESTINO"
        Me.NOMCTEDESTDataGridViewTextBoxColumn.Name = "NOMCTEDESTDataGridViewTextBoxColumn"
        Me.NOMCTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEDESTDataGridViewTextBoxColumn.Width = 180
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTATUSDataGridViewTextBoxColumn
        '
        Me.ESTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.Name = "ESTATUSDataGridViewTextBoxColumn"
        Me.ESTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn.Visible = False
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn.Visible = False
        '
        'CANALESDataGridViewTextBoxColumn
        '
        Me.CANALESDataGridViewTextBoxColumn.DataPropertyName = "CANALES"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N2"
        DataGridViewCellStyle34.NullValue = Nothing
        Me.CANALESDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle34
        Me.CANALESDataGridViewTextBoxColumn.HeaderText = "CANALES"
        Me.CANALESDataGridViewTextBoxColumn.Name = "CANALESDataGridViewTextBoxColumn"
        Me.CANALESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESO
        '
        Me.PESO.DataPropertyName = "PESO"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "N2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.PESO.DefaultCellStyle = DataGridViewCellStyle35
        Me.PESO.HeaderText = "PESO"
        Me.PESO.Name = "PESO"
        Me.PESO.ReadOnly = True
        '
        'PESO_ENTRADA
        '
        Me.PESO_ENTRADA.DataPropertyName = "PESO_ENTRADA"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.Format = "N2"
        Me.PESO_ENTRADA.DefaultCellStyle = DataGridViewCellStyle36
        Me.PESO_ENTRADA.HeaderText = "PESO ENTRADA"
        Me.PESO_ENTRADA.Name = "PESO_ENTRADA"
        Me.PESO_ENTRADA.ReadOnly = True
        Me.PESO_ENTRADA.Width = 120
        '
        'PESO_SALIDA
        '
        Me.PESO_SALIDA.DataPropertyName = "PESO_SALIDA"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle37.Format = "N2"
        Me.PESO_SALIDA.DefaultCellStyle = DataGridViewCellStyle37
        Me.PESO_SALIDA.HeaderText = "PESO SALIDA"
        Me.PESO_SALIDA.Name = "PESO_SALIDA"
        Me.PESO_SALIDA.ReadOnly = True
        '
        'PESO_NETO
        '
        Me.PESO_NETO.DataPropertyName = "PESO_NETO"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle38.Format = "N2"
        Me.PESO_NETO.DefaultCellStyle = DataGridViewCellStyle38
        Me.PESO_NETO.HeaderText = "PESO NETO"
        Me.PESO_NETO.Name = "PESO_NETO"
        Me.PESO_NETO.ReadOnly = True
        '
        'CABEZAS_ENT
        '
        Me.CABEZAS_ENT.DataPropertyName = "CABEZAS_ENT"
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle39.Format = "N0"
        DataGridViewCellStyle39.NullValue = Nothing
        Me.CABEZAS_ENT.DefaultCellStyle = DataGridViewCellStyle39
        Me.CABEZAS_ENT.HeaderText = "CABEZAS"
        Me.CABEZAS_ENT.Name = "CABEZAS_ENT"
        Me.CABEZAS_ENT.ReadOnly = True
        '
        'RENDIMIENTO
        '
        Me.RENDIMIENTO.DataPropertyName = "RENDIMIENTO"
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle40.Format = "N2"
        DataGridViewCellStyle40.NullValue = Nothing
        Me.RENDIMIENTO.DefaultCellStyle = DataGridViewCellStyle40
        Me.RENDIMIENTO.HeaderText = "RENDIMIENTO"
        Me.RENDIMIENTO.Name = "RENDIMIENTO"
        Me.RENDIMIENTO.ReadOnly = True
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNomIntroductor)
        Me.GroupBox1.Controls.Add(Me.chkcorte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMarcaIntroductor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbProductos)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1331, 84)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 65)
        Me.ToolStrip1.TabIndex = 90
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_Refresh_32x32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "Imprimir rendimiento"
        Me.ToolStripButton2.ToolTipText = "Actualizar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnImprimir2)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.btnimprimir3)
        Me.GroupBox2.Location = New System.Drawing.Point(59, -5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1311, 70)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        '
        'frmCONS_EntradaSacrificio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCONS_EntradaSacrificio"
        Me.ShowInTaskbar = False
        Me.Text = "Resumen de sacrificio - Canales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsCatalogosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents REN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SAC_LOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANALESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESO_ENTRADA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESO_SALIDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESO_NETO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CABEZAS_ENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RENDIMIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir2 As System.Windows.Forms.Button
    Friend WithEvents btnimprimir3 As System.Windows.Forms.Button
    Friend WithEvents chkcorte As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
