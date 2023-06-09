<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_GanadoEnPie
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoraFin = New System.Windows.Forms.TextBox()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalGanado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.REN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFOLIOENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFOLIOSALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAMODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACANCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIOCANCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESCREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACMAYORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACVACIADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACENMANTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESDREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS_ESD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEL_ARETE_CAMPANA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEL_ARETE_SAGARPA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEL_ARETE_INTRODUCTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DECOMISO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel8.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.cmbProductos)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.btnActualizar)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.txtHoraFin)
        Me.Panel8.Controls.Add(Me.txtHoraInicio)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.txtTotalGanado)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaMov)
        Me.Panel8.Location = New System.Drawing.Point(14, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1108, 59)
        Me.Panel8.TabIndex = 0
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(105, 17)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(151, 24)
        Me.cmbProductos.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Producto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.Location = New System.Drawing.Point(992, 10)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(104, 39)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(465, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inicio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHoraFin
        '
        Me.txtHoraFin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFin.Location = New System.Drawing.Point(688, 16)
        Me.txtHoraFin.MaxLength = 6
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.ReadOnly = True
        Me.txtHoraFin.Size = New System.Drawing.Size(106, 26)
        Me.txtHoraFin.TabIndex = 7
        Me.txtHoraFin.TabStop = False
        Me.txtHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraInicio.Location = New System.Drawing.Point(531, 16)
        Me.txtHoraInicio.MaxLength = 6
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.ReadOnly = True
        Me.txtHoraInicio.Size = New System.Drawing.Size(106, 26)
        Me.txtHoraInicio.TabIndex = 5
        Me.txtHoraInicio.TabStop = False
        Me.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(643, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalGanado
        '
        Me.txtTotalGanado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalGanado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGanado.Location = New System.Drawing.Point(884, 16)
        Me.txtTotalGanado.MaxLength = 6
        Me.txtTotalGanado.Name = "txtTotalGanado"
        Me.txtTotalGanado.ReadOnly = True
        Me.txtTotalGanado.Size = New System.Drawing.Size(91, 26)
        Me.txtTotalGanado.TabIndex = 9
        Me.txtTotalGanado.TabStop = False
        Me.txtTotalGanado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(801, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total ganado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(262, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(335, 16)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaMov.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1112, 62)
        Me.Label13.TabIndex = 28
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1133, 22)
        Me.StatusStrip1.TabIndex = 30
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "F5|Actualizar"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(131, 17)
        Me.ToolStripStatusLabel2.Text = "Doble Click | Ver detalle"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1113, 402)
        Me.Label4.TabIndex = 31
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Lavender
        Me.dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REN, Me.SACLOTEDataGridViewTextBoxColumn, Me.ID_ESC, Me.IDMOVDataGridViewTextBoxColumn, Me.IDALMDataGridViewTextBoxColumn, Me.FOLIODataGridViewTextBoxColumn, Me.IDCTEPRODDataGridViewTextBoxColumn, Me.MARCACTEPRODDataGridViewTextBoxColumn, Me.IDCTEINTRDataGridViewTextBoxColumn, Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.MARCACTEDESTDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.REFFOLIOENTDataGridViewTextBoxColumn, Me.REFFOLIOSALDataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.FECHAMODDataGridViewTextBoxColumn, Me.FECHACANCDataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.USUARIOCANCDataGridViewTextBoxColumn, Me.IDESCREFDataGridViewTextBoxColumn, Me.ESTATUSDataGridViewTextBoxColumn, Me.IDESDDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.TARADataGridViewTextBoxColumn, Me.FECHAESDDataGridViewTextBoxColumn, Me.HORAESDDataGridViewTextBoxColumn, Me.SACSERIEDataGridViewTextBoxColumn, Me.SACIDDataGridViewTextBoxColumn, Me.SACLADODataGridViewTextBoxColumn, Me.SACSEXODataGridViewTextBoxColumn, Me.SACMAYORDataGridViewTextBoxColumn, Me.SACVACIADADataGridViewTextBoxColumn, Me.SACENMANTADODataGridViewTextBoxColumn, Me.OBSERVACIONESESDDataGridViewTextBoxColumn, Me.IDESDREFDataGridViewTextBoxColumn, Me.ESTATUS_ESD, Me.PIEL_ARETE_CAMPANA, Me.PIEL_ARETE_SAGARPA, Me.PIEL_ARETE_INTRODUCTOR, Me.DECOMISO})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_ENCDET_X_FECHA"
        Me.dgvDatos.DataSource = Me.DsSacrificio
        Me.dgvDatos.Location = New System.Drawing.Point(13, 79)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(1111, 400)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 1
        '
        'REN
        '
        Me.REN.Frozen = True
        Me.REN.HeaderText = "#"
        Me.REN.Name = "REN"
        Me.REN.ReadOnly = True
        Me.REN.Width = 40
        '
        'SACLOTEDataGridViewTextBoxColumn
        '
        Me.SACLOTEDataGridViewTextBoxColumn.DataPropertyName = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.Frozen = True
        Me.SACLOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.Name = "SACLOTEDataGridViewTextBoxColumn"
        Me.SACLOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ID_ESC
        '
        Me.ID_ESC.DataPropertyName = "ID_ESC"
        Me.ID_ESC.HeaderText = "ID_ESC"
        Me.ID_ESC.Name = "ID_ESC"
        Me.ID_ESC.ReadOnly = True
        Me.ID_ESC.Visible = False
        '
        'IDMOVDataGridViewTextBoxColumn
        '
        Me.IDMOVDataGridViewTextBoxColumn.DataPropertyName = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.HeaderText = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn.Name = "IDMOVDataGridViewTextBoxColumn"
        Me.IDMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDMOVDataGridViewTextBoxColumn.Visible = False
        '
        'IDALMDataGridViewTextBoxColumn
        '
        Me.IDALMDataGridViewTextBoxColumn.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.Name = "IDALMDataGridViewTextBoxColumn"
        Me.IDALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDALMDataGridViewTextBoxColumn.Visible = False
        '
        'FOLIODataGridViewTextBoxColumn
        '
        Me.FOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.Name = "FOLIODataGridViewTextBoxColumn"
        Me.FOLIODataGridViewTextBoxColumn.ReadOnly = True
        Me.FOLIODataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEPRODDataGridViewTextBoxColumn
        '
        Me.IDCTEPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn.HeaderText = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn.Name = "IDCTEPRODDataGridViewTextBoxColumn"
        Me.IDCTEPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEPRODDataGridViewTextBoxColumn
        '
        Me.MARCACTEPRODDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.HeaderText = "PRODUCTOR"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Name = "MARCACTEPRODDataGridViewTextBoxColumn"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "INTRODUCTOR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Name = "MARCACTEINTRDataGridViewTextBoxColumn"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MARCACTEDESTDataGridViewTextBoxColumn
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.HeaderText = "DESTINO"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.Name = "MARCACTEDESTDataGridViewTextBoxColumn"
        Me.MARCACTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHADataGridViewTextBoxColumn.Visible = False
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "T"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.HORADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.ReadOnly = True
        Me.HORADataGridViewTextBoxColumn.Visible = False
        '
        'REFFOLIOENTDataGridViewTextBoxColumn
        '
        Me.REFFOLIOENTDataGridViewTextBoxColumn.DataPropertyName = "REF_FOLIO_ENT"
        Me.REFFOLIOENTDataGridViewTextBoxColumn.HeaderText = "REF_FOLIO_ENT"
        Me.REFFOLIOENTDataGridViewTextBoxColumn.Name = "REFFOLIOENTDataGridViewTextBoxColumn"
        Me.REFFOLIOENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.REFFOLIOENTDataGridViewTextBoxColumn.Visible = False
        '
        'REFFOLIOSALDataGridViewTextBoxColumn
        '
        Me.REFFOLIOSALDataGridViewTextBoxColumn.DataPropertyName = "REF_FOLIO_SAL"
        Me.REFFOLIOSALDataGridViewTextBoxColumn.HeaderText = "REF_FOLIO_SAL"
        Me.REFFOLIOSALDataGridViewTextBoxColumn.Name = "REFFOLIOSALDataGridViewTextBoxColumn"
        Me.REFFOLIOSALDataGridViewTextBoxColumn.ReadOnly = True
        Me.REFFOLIOSALDataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Visible = False
        '
        'FECHAMODDataGridViewTextBoxColumn
        '
        Me.FECHAMODDataGridViewTextBoxColumn.DataPropertyName = "FECHA_MOD"
        Me.FECHAMODDataGridViewTextBoxColumn.HeaderText = "FECHA_MOD"
        Me.FECHAMODDataGridViewTextBoxColumn.Name = "FECHAMODDataGridViewTextBoxColumn"
        Me.FECHAMODDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAMODDataGridViewTextBoxColumn.Visible = False
        '
        'FECHACANCDataGridViewTextBoxColumn
        '
        Me.FECHACANCDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CANC"
        Me.FECHACANCDataGridViewTextBoxColumn.HeaderText = "FECHA_CANC"
        Me.FECHACANCDataGridViewTextBoxColumn.Name = "FECHACANCDataGridViewTextBoxColumn"
        Me.FECHACANCDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHACANCDataGridViewTextBoxColumn.Visible = False
        '
        'USUARIODataGridViewTextBoxColumn
        '
        Me.USUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO"
        Me.USUARIODataGridViewTextBoxColumn.Name = "USUARIODataGridViewTextBoxColumn"
        Me.USUARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.USUARIODataGridViewTextBoxColumn.Visible = False
        '
        'USUARIOCANCDataGridViewTextBoxColumn
        '
        Me.USUARIOCANCDataGridViewTextBoxColumn.DataPropertyName = "USUARIO_CANC"
        Me.USUARIOCANCDataGridViewTextBoxColumn.HeaderText = "USUARIO_CANC"
        Me.USUARIOCANCDataGridViewTextBoxColumn.Name = "USUARIOCANCDataGridViewTextBoxColumn"
        Me.USUARIOCANCDataGridViewTextBoxColumn.ReadOnly = True
        Me.USUARIOCANCDataGridViewTextBoxColumn.Visible = False
        '
        'IDESCREFDataGridViewTextBoxColumn
        '
        Me.IDESCREFDataGridViewTextBoxColumn.DataPropertyName = "ID_ESC_REF"
        Me.IDESCREFDataGridViewTextBoxColumn.HeaderText = "ID_ESC_REF"
        Me.IDESCREFDataGridViewTextBoxColumn.Name = "IDESCREFDataGridViewTextBoxColumn"
        Me.IDESCREFDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESCREFDataGridViewTextBoxColumn.Visible = False
        '
        'ESTATUSDataGridViewTextBoxColumn
        '
        Me.ESTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.Name = "ESTATUSDataGridViewTextBoxColumn"
        Me.ESTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'IDESDDataGridViewTextBoxColumn
        '
        Me.IDESDDataGridViewTextBoxColumn.DataPropertyName = "ID_ESD"
        Me.IDESDDataGridViewTextBoxColumn.HeaderText = "ID_ESD"
        Me.IDESDDataGridViewTextBoxColumn.Name = "IDESDDataGridViewTextBoxColumn"
        Me.IDESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESDDataGridViewTextBoxColumn.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn
        '
        Me.IDPRODDataGridViewTextBoxColumn.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn.Visible = False
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn.Visible = False
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn.Width = 80
        '
        'TARADataGridViewTextBoxColumn
        '
        Me.TARADataGridViewTextBoxColumn.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn.Name = "TARADataGridViewTextBoxColumn"
        Me.TARADataGridViewTextBoxColumn.ReadOnly = True
        Me.TARADataGridViewTextBoxColumn.Visible = False
        '
        'FECHAESDDataGridViewTextBoxColumn
        '
        Me.FECHAESDDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ESD"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECHAESDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.FECHAESDDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHAESDDataGridViewTextBoxColumn.Name = "FECHAESDDataGridViewTextBoxColumn"
        Me.FECHAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAESDDataGridViewTextBoxColumn.Visible = False
        '
        'HORAESDDataGridViewTextBoxColumn
        '
        Me.HORAESDDataGridViewTextBoxColumn.DataPropertyName = "HORA_ESD"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.NullValue = Nothing
        Me.HORAESDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.HORAESDDataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORAESDDataGridViewTextBoxColumn.Name = "HORAESDDataGridViewTextBoxColumn"
        Me.HORAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAESDDataGridViewTextBoxColumn.Width = 80
        '
        'SACSERIEDataGridViewTextBoxColumn
        '
        Me.SACSERIEDataGridViewTextBoxColumn.DataPropertyName = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.HeaderText = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.Name = "SACSERIEDataGridViewTextBoxColumn"
        Me.SACSERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSERIEDataGridViewTextBoxColumn.Visible = False
        '
        'SACIDDataGridViewTextBoxColumn
        '
        Me.SACIDDataGridViewTextBoxColumn.DataPropertyName = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.HeaderText = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.Name = "SACIDDataGridViewTextBoxColumn"
        Me.SACIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACIDDataGridViewTextBoxColumn.Visible = False
        '
        'SACLADODataGridViewTextBoxColumn
        '
        Me.SACLADODataGridViewTextBoxColumn.DataPropertyName = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.HeaderText = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.Name = "SACLADODataGridViewTextBoxColumn"
        Me.SACLADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLADODataGridViewTextBoxColumn.Visible = False
        '
        'SACSEXODataGridViewTextBoxColumn
        '
        Me.SACSEXODataGridViewTextBoxColumn.DataPropertyName = "SAC_SEXO"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SACSEXODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.SACSEXODataGridViewTextBoxColumn.HeaderText = "SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.Name = "SACSEXODataGridViewTextBoxColumn"
        Me.SACSEXODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSEXODataGridViewTextBoxColumn.Width = 60
        '
        'SACMAYORDataGridViewTextBoxColumn
        '
        Me.SACMAYORDataGridViewTextBoxColumn.DataPropertyName = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.HeaderText = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.Name = "SACMAYORDataGridViewTextBoxColumn"
        Me.SACMAYORDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACMAYORDataGridViewTextBoxColumn.Visible = False
        '
        'SACVACIADADataGridViewTextBoxColumn
        '
        Me.SACVACIADADataGridViewTextBoxColumn.DataPropertyName = "SAC_VACIADA"
        Me.SACVACIADADataGridViewTextBoxColumn.HeaderText = "SAC_VACIADA"
        Me.SACVACIADADataGridViewTextBoxColumn.Name = "SACVACIADADataGridViewTextBoxColumn"
        Me.SACVACIADADataGridViewTextBoxColumn.ReadOnly = True
        Me.SACVACIADADataGridViewTextBoxColumn.Visible = False
        '
        'SACENMANTADODataGridViewTextBoxColumn
        '
        Me.SACENMANTADODataGridViewTextBoxColumn.DataPropertyName = "SAC_ENMANTADO"
        Me.SACENMANTADODataGridViewTextBoxColumn.HeaderText = "SAC_ENMANTADO"
        Me.SACENMANTADODataGridViewTextBoxColumn.Name = "SACENMANTADODataGridViewTextBoxColumn"
        Me.SACENMANTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACENMANTADODataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESESDDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES_ESD"
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES_ESD"
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.Name = "OBSERVACIONESESDDataGridViewTextBoxColumn"
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.Visible = False
        '
        'IDESDREFDataGridViewTextBoxColumn
        '
        Me.IDESDREFDataGridViewTextBoxColumn.DataPropertyName = "ID_ESD_REF"
        Me.IDESDREFDataGridViewTextBoxColumn.HeaderText = "ID_ESD_REF"
        Me.IDESDREFDataGridViewTextBoxColumn.Name = "IDESDREFDataGridViewTextBoxColumn"
        Me.IDESDREFDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESDREFDataGridViewTextBoxColumn.Visible = False
        '
        'ESTATUS_ESD
        '
        Me.ESTATUS_ESD.DataPropertyName = "ESTATUS_ESD"
        Me.ESTATUS_ESD.HeaderText = "ESTATUS_ESD"
        Me.ESTATUS_ESD.Name = "ESTATUS_ESD"
        Me.ESTATUS_ESD.ReadOnly = True
        Me.ESTATUS_ESD.Visible = False
        '
        'PIEL_ARETE_CAMPANA
        '
        Me.PIEL_ARETE_CAMPANA.DataPropertyName = "PIEL_ARETE_CAMPANA"
        Me.PIEL_ARETE_CAMPANA.HeaderText = "ARETE CAMPAÑA"
        Me.PIEL_ARETE_CAMPANA.Name = "PIEL_ARETE_CAMPANA"
        Me.PIEL_ARETE_CAMPANA.ReadOnly = True
        '
        'PIEL_ARETE_SAGARPA
        '
        Me.PIEL_ARETE_SAGARPA.DataPropertyName = "PIEL_ARETE_SAGARPA"
        Me.PIEL_ARETE_SAGARPA.HeaderText = "ARETE SAGARPA"
        Me.PIEL_ARETE_SAGARPA.Name = "PIEL_ARETE_SAGARPA"
        Me.PIEL_ARETE_SAGARPA.ReadOnly = True
        '
        'PIEL_ARETE_INTRODUCTOR
        '
        Me.PIEL_ARETE_INTRODUCTOR.DataPropertyName = "PIEL_ARETE_INTRODUCTOR"
        Me.PIEL_ARETE_INTRODUCTOR.HeaderText = "ARETE INTRODUCTOR"
        Me.PIEL_ARETE_INTRODUCTOR.Name = "PIEL_ARETE_INTRODUCTOR"
        Me.PIEL_ARETE_INTRODUCTOR.ReadOnly = True
        '
        'DECOMISO
        '
        Me.DECOMISO.DataPropertyName = "DECOMISO"
        Me.DECOMISO.FalseValue = "0"
        Me.DECOMISO.HeaderText = "DECOMISO"
        Me.DECOMISO.Name = "DECOMISO"
        Me.DECOMISO.ReadOnly = True
        Me.DECOMISO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DECOMISO.TrueValue = "1"
        Me.DECOMISO.Width = 70
        '
        'frmCONS_GanadoEnPie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1133, 509)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCONS_GanadoEnPie"
        Me.ShowInTaskbar = False
        Me.Text = "Consulta de ganado en pie"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalGanado As System.Windows.Forms.TextBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHoraFin As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraInicio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents REN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFOLIOENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFOLIOSALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAMODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACANCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIOCANCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESCREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACMAYORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACVACIADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACENMANTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESDREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS_ESD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEL_ARETE_CAMPANA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEL_ARETE_SAGARPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEL_ARETE_INTRODUCTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DECOMISO As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
