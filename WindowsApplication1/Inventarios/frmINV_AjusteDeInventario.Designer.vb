<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmINV_AjusteDeInventario
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
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCajasDisponibles = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.FIDINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNOMALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIDCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FMARCACTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNOMCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFOLIOINVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_ID_ESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCODPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNOMBPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFECHAETIQDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F_ID_ESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCODPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNOMBPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFECHAETIQDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsInventarios = New SistemaControlProduccion.dsInventarios()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtNomIntroductor.Size = New System.Drawing.Size(324, 26)
        Me.txtNomIntroductor.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Location = New System.Drawing.Point(11, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 83)
        Me.Panel2.TabIndex = 0
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(13, 34)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 0
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(435, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Datos del introductor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(441, 86)
        Me.Label6.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1160, 438)
        Me.Label9.TabIndex = 41
        '
        'lblCajasDisponibles
        '
        Me.lblCajasDisponibles.BackColor = System.Drawing.SystemColors.Control
        Me.lblCajasDisponibles.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajasDisponibles.ForeColor = System.Drawing.Color.Maroon
        Me.lblCajasDisponibles.Location = New System.Drawing.Point(12, 104)
        Me.lblCajasDisponibles.Name = "lblCajasDisponibles"
        Me.lblCajasDisponibles.Size = New System.Drawing.Size(1156, 23)
        Me.lblCajasDisponibles.TabIndex = 4
        Me.lblCajasDisponibles.Text = "Inventario"
        Me.lblCajasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1180, 22)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.dtpFechaMov)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtFolio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(457, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 83)
        Me.Panel1.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(194, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 20)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Fecha"
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(259, 37)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(113, 26)
        Me.dtpFechaMov.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Folio"
        '
        'txtFolio
        '
        Me.txtFolio.BackColor = System.Drawing.Color.LightYellow
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(70, 34)
        Me.txtFolio.MaxLength = 6
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(114, 29)
        Me.txtFolio.TabIndex = 1
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(-2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del inventario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(456, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 86)
        Me.Label2.TabIndex = 1
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
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIDINVDataGridViewTextBoxColumn, Me.FIDALMDataGridViewTextBoxColumn, Me.FNOMALMDataGridViewTextBoxColumn, Me.FIDCTEDataGridViewTextBoxColumn, Me.FMARCACTEDataGridViewTextBoxColumn, Me.FNOMCTEDataGridViewTextBoxColumn, Me.FFOLIOINVDataGridViewTextBoxColumn, Me.F_FECHA, Me.F_ESTATUS, Me.T_ID_ESC, Me.TCODPRODDataGridViewTextBoxColumn, Me.TNOMBPRODDataGridViewTextBoxColumn, Me.TPIEZASDataGridViewTextBoxColumn, Me.TPESODataGridViewTextBoxColumn, Me.TFECHAETIQDataGridViewTextBoxColumn, Me.TCAJAIDDataGridViewTextBoxColumn, Me.F_ID_ESC, Me.FCODPRODDataGridViewTextBoxColumn, Me.FNOMBPRODDataGridViewTextBoxColumn, Me.FPIEZASDataGridViewTextBoxColumn, Me.FPESODataGridViewTextBoxColumn, Me.FFECHAETIQDataGridViewTextBoxColumn, Me.FCAJAIDDataGridViewTextBoxColumn})
        Me.dgvDatos.DataMember = "SP_CONS_ANALISIS_INVENTARIO"
        Me.dgvDatos.DataSource = Me.DsInventarios
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDatos.Location = New System.Drawing.Point(11, 130)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(1158, 420)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 7
        '
        'FIDINVDataGridViewTextBoxColumn
        '
        Me.FIDINVDataGridViewTextBoxColumn.DataPropertyName = "F_ID_INV"
        Me.FIDINVDataGridViewTextBoxColumn.HeaderText = "F_ID_INV"
        Me.FIDINVDataGridViewTextBoxColumn.Name = "FIDINVDataGridViewTextBoxColumn"
        Me.FIDINVDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIDINVDataGridViewTextBoxColumn.Visible = False
        '
        'FIDALMDataGridViewTextBoxColumn
        '
        Me.FIDALMDataGridViewTextBoxColumn.DataPropertyName = "F_ID_ALM"
        Me.FIDALMDataGridViewTextBoxColumn.HeaderText = "F_ID_ALM"
        Me.FIDALMDataGridViewTextBoxColumn.Name = "FIDALMDataGridViewTextBoxColumn"
        Me.FIDALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIDALMDataGridViewTextBoxColumn.Visible = False
        '
        'FNOMALMDataGridViewTextBoxColumn
        '
        Me.FNOMALMDataGridViewTextBoxColumn.DataPropertyName = "F_NOM_ALM"
        Me.FNOMALMDataGridViewTextBoxColumn.HeaderText = "F_NOM_ALM"
        Me.FNOMALMDataGridViewTextBoxColumn.Name = "FNOMALMDataGridViewTextBoxColumn"
        Me.FNOMALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNOMALMDataGridViewTextBoxColumn.Visible = False
        '
        'FIDCTEDataGridViewTextBoxColumn
        '
        Me.FIDCTEDataGridViewTextBoxColumn.DataPropertyName = "F_ID_CTE"
        Me.FIDCTEDataGridViewTextBoxColumn.HeaderText = "F_ID_CTE"
        Me.FIDCTEDataGridViewTextBoxColumn.Name = "FIDCTEDataGridViewTextBoxColumn"
        Me.FIDCTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIDCTEDataGridViewTextBoxColumn.Visible = False
        '
        'FMARCACTEDataGridViewTextBoxColumn
        '
        Me.FMARCACTEDataGridViewTextBoxColumn.DataPropertyName = "F_MARCA_CTE"
        Me.FMARCACTEDataGridViewTextBoxColumn.HeaderText = "F_MARCA_CTE"
        Me.FMARCACTEDataGridViewTextBoxColumn.Name = "FMARCACTEDataGridViewTextBoxColumn"
        Me.FMARCACTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FMARCACTEDataGridViewTextBoxColumn.Visible = False
        '
        'FNOMCTEDataGridViewTextBoxColumn
        '
        Me.FNOMCTEDataGridViewTextBoxColumn.DataPropertyName = "F_NOM_CTE"
        Me.FNOMCTEDataGridViewTextBoxColumn.HeaderText = "F_NOM_CTE"
        Me.FNOMCTEDataGridViewTextBoxColumn.Name = "FNOMCTEDataGridViewTextBoxColumn"
        Me.FNOMCTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNOMCTEDataGridViewTextBoxColumn.Visible = False
        '
        'FFOLIOINVDataGridViewTextBoxColumn
        '
        Me.FFOLIOINVDataGridViewTextBoxColumn.DataPropertyName = "F_FOLIO_INV"
        Me.FFOLIOINVDataGridViewTextBoxColumn.HeaderText = "F_FOLIO_INV"
        Me.FFOLIOINVDataGridViewTextBoxColumn.Name = "FFOLIOINVDataGridViewTextBoxColumn"
        Me.FFOLIOINVDataGridViewTextBoxColumn.ReadOnly = True
        Me.FFOLIOINVDataGridViewTextBoxColumn.Visible = False
        '
        'F_FECHA
        '
        Me.F_FECHA.DataPropertyName = "F_FECHA"
        Me.F_FECHA.HeaderText = "F_FECHA"
        Me.F_FECHA.Name = "F_FECHA"
        Me.F_FECHA.ReadOnly = True
        Me.F_FECHA.Visible = False
        '
        'F_ESTATUS
        '
        Me.F_ESTATUS.DataPropertyName = "F_ESTATUS"
        Me.F_ESTATUS.HeaderText = "F_ESTATUS"
        Me.F_ESTATUS.Name = "F_ESTATUS"
        Me.F_ESTATUS.ReadOnly = True
        Me.F_ESTATUS.Visible = False
        '
        'T_ID_ESC
        '
        Me.T_ID_ESC.DataPropertyName = "T_ID_ESC"
        Me.T_ID_ESC.HeaderText = "T_ID_ESC"
        Me.T_ID_ESC.Name = "T_ID_ESC"
        Me.T_ID_ESC.ReadOnly = True
        Me.T_ID_ESC.Visible = False
        '
        'TCODPRODDataGridViewTextBoxColumn
        '
        Me.TCODPRODDataGridViewTextBoxColumn.DataPropertyName = "T_CODPROD"
        Me.TCODPRODDataGridViewTextBoxColumn.HeaderText = "T_CODPROD"
        Me.TCODPRODDataGridViewTextBoxColumn.Name = "TCODPRODDataGridViewTextBoxColumn"
        Me.TCODPRODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TNOMBPRODDataGridViewTextBoxColumn
        '
        Me.TNOMBPRODDataGridViewTextBoxColumn.DataPropertyName = "T_NOMBPROD"
        Me.TNOMBPRODDataGridViewTextBoxColumn.HeaderText = "T_NOMBPROD"
        Me.TNOMBPRODDataGridViewTextBoxColumn.Name = "TNOMBPRODDataGridViewTextBoxColumn"
        Me.TNOMBPRODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TPIEZASDataGridViewTextBoxColumn
        '
        Me.TPIEZASDataGridViewTextBoxColumn.DataPropertyName = "T_PIEZAS"
        Me.TPIEZASDataGridViewTextBoxColumn.HeaderText = "T_PIEZAS"
        Me.TPIEZASDataGridViewTextBoxColumn.Name = "TPIEZASDataGridViewTextBoxColumn"
        Me.TPIEZASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TPESODataGridViewTextBoxColumn
        '
        Me.TPESODataGridViewTextBoxColumn.DataPropertyName = "T_PESO"
        Me.TPESODataGridViewTextBoxColumn.HeaderText = "T_PESO"
        Me.TPESODataGridViewTextBoxColumn.Name = "TPESODataGridViewTextBoxColumn"
        Me.TPESODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TFECHAETIQDataGridViewTextBoxColumn
        '
        Me.TFECHAETIQDataGridViewTextBoxColumn.DataPropertyName = "T_FECHA_ETIQ"
        Me.TFECHAETIQDataGridViewTextBoxColumn.HeaderText = "T_FECHA_ETIQ"
        Me.TFECHAETIQDataGridViewTextBoxColumn.Name = "TFECHAETIQDataGridViewTextBoxColumn"
        Me.TFECHAETIQDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TCAJAIDDataGridViewTextBoxColumn
        '
        Me.TCAJAIDDataGridViewTextBoxColumn.DataPropertyName = "T_CAJA_ID"
        Me.TCAJAIDDataGridViewTextBoxColumn.HeaderText = "T_CAJA_ID"
        Me.TCAJAIDDataGridViewTextBoxColumn.Name = "TCAJAIDDataGridViewTextBoxColumn"
        Me.TCAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'F_ID_ESC
        '
        Me.F_ID_ESC.DataPropertyName = "F_ID_ESC"
        Me.F_ID_ESC.HeaderText = "F_ID_ESC"
        Me.F_ID_ESC.Name = "F_ID_ESC"
        Me.F_ID_ESC.ReadOnly = True
        Me.F_ID_ESC.Visible = False
        '
        'FCODPRODDataGridViewTextBoxColumn
        '
        Me.FCODPRODDataGridViewTextBoxColumn.DataPropertyName = "F_CODPROD"
        Me.FCODPRODDataGridViewTextBoxColumn.HeaderText = "F_CODPROD"
        Me.FCODPRODDataGridViewTextBoxColumn.Name = "FCODPRODDataGridViewTextBoxColumn"
        Me.FCODPRODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FNOMBPRODDataGridViewTextBoxColumn
        '
        Me.FNOMBPRODDataGridViewTextBoxColumn.DataPropertyName = "F_NOMBPROD"
        Me.FNOMBPRODDataGridViewTextBoxColumn.HeaderText = "F_NOMBPROD"
        Me.FNOMBPRODDataGridViewTextBoxColumn.Name = "FNOMBPRODDataGridViewTextBoxColumn"
        Me.FNOMBPRODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FPIEZASDataGridViewTextBoxColumn
        '
        Me.FPIEZASDataGridViewTextBoxColumn.DataPropertyName = "F_PIEZAS"
        Me.FPIEZASDataGridViewTextBoxColumn.HeaderText = "F_PIEZAS"
        Me.FPIEZASDataGridViewTextBoxColumn.Name = "FPIEZASDataGridViewTextBoxColumn"
        Me.FPIEZASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FPESODataGridViewTextBoxColumn
        '
        Me.FPESODataGridViewTextBoxColumn.DataPropertyName = "F_PESO"
        Me.FPESODataGridViewTextBoxColumn.HeaderText = "F_PESO"
        Me.FPESODataGridViewTextBoxColumn.Name = "FPESODataGridViewTextBoxColumn"
        Me.FPESODataGridViewTextBoxColumn.ReadOnly = True
        '
        'FFECHAETIQDataGridViewTextBoxColumn
        '
        Me.FFECHAETIQDataGridViewTextBoxColumn.DataPropertyName = "F_FECHA_ETIQ"
        Me.FFECHAETIQDataGridViewTextBoxColumn.HeaderText = "F_FECHA_ETIQ"
        Me.FFECHAETIQDataGridViewTextBoxColumn.Name = "FFECHAETIQDataGridViewTextBoxColumn"
        Me.FFECHAETIQDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FCAJAIDDataGridViewTextBoxColumn
        '
        Me.FCAJAIDDataGridViewTextBoxColumn.DataPropertyName = "F_CAJA_ID"
        Me.FCAJAIDDataGridViewTextBoxColumn.HeaderText = "F_CAJA_ID"
        Me.FCAJAIDDataGridViewTextBoxColumn.Name = "FCAJAIDDataGridViewTextBoxColumn"
        Me.FCAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DsInventarios
        '
        Me.DsInventarios.DataSetName = "dsInventarios"
        Me.DsInventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightCoral
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(854, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 29)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "CAJAS PARA ELABORAR SALIDA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGreen
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(854, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 29)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "CAJAS PARA ELABORAR ENTRADA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(1097, 38)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 42
        Me.btnGuardar.Text = "&Ajustar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(11, 580)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(1157, 34)
        Me.txtObservaciones.TabIndex = 47
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(11, 554)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1157, 23)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Observaciones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 552)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1161, 64)
        Me.Label16.TabIndex = 45
        '
        'frmINV_AjusteDeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1180, 639)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblCajasDisponibles)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmINV_AjusteDeInventario"
        Me.ShowInTaskbar = False
        Me.Text = "Consulta de un registro de inventario"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCajasDisponibles As System.Windows.Forms.Label
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsInventarios As SistemaControlProduccion.dsInventarios
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FIDINVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNOMALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIDCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FMARCACTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNOMCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFOLIOINVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_ID_ESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCODPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNOMBPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFECHAETIQDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents F_ID_ESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCODPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNOMBPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFECHAETIQDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
