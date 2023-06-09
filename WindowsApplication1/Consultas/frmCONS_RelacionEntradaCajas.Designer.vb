<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_RelacionEntradaCajas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.REN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_CTE_DEST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA_CTE_DEST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CTE_DEST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFOLIOENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFOLIOSALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAMODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACANCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIOCANCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESCREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsCajas = New SistemaControlProduccion.dsCajas()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(967, 62)
        Me.Label13.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(993, 22)
        Me.StatusStrip1.TabIndex = 2
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel3.Text = "F3|Buscar"
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
        Me.Label4.Size = New System.Drawing.Size(966, 397)
        Me.Label4.TabIndex = 31
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(654, 3)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(124, 22)
        Me.dtpFechaIni.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(537, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha Inicial"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.Location = New System.Drawing.Point(796, 1)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 57)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btnImprimir)
        Me.Panel8.Controls.Add(Me.txtNomIntroductor)
        Me.Panel8.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.dtpFechaFin)
        Me.Panel8.Controls.Add(Me.btnActualizar)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaIni)
        Me.Panel8.Location = New System.Drawing.Point(14, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(963, 59)
        Me.Panel8.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(874, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 57)
        Me.btnImprimir.TabIndex = 32
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnImprimir, "Imprimir Rendimiento")
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(205, 13)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(275, 26)
        Me.txtNomIntroductor.TabIndex = 2
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(123, 13)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 1
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Introductor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(545, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(654, 31)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(124, 22)
        Me.dtpFechaFin.TabIndex = 6
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
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REN, Me.ID_ESC, Me.IDMOVDataGridViewTextBoxColumn, Me.NOMMOVDataGridViewTextBoxColumn, Me.IDALMDataGridViewTextBoxColumn, Me.NOMALMDataGridViewTextBoxColumn, Me.FOLIODataGridViewTextBoxColumn, Me.IDCTEPRODDataGridViewTextBoxColumn, Me.MARCACTEPRODDataGridViewTextBoxColumn, Me.NOMCTEPRODDataGridViewTextBoxColumn, Me.IDCTEINTRDataGridViewTextBoxColumn, Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.NOMCTEINTRDataGridViewTextBoxColumn, Me.ID_CTE_DEST, Me.MARCA_CTE_DEST, Me.NOM_CTE_DEST, Me.FECHADataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.CAJASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.REFFOLIOENTDataGridViewTextBoxColumn, Me.REFFOLIOSALDataGridViewTextBoxColumn, Me.SACLOTEDataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.FECHAMODDataGridViewTextBoxColumn, Me.FECHACANCDataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.USUARIOCANCDataGridViewTextBoxColumn, Me.IDESCREFDataGridViewTextBoxColumn, Me.ESTATUS})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_RELACION_CAJAS"
        Me.dgvDatos.DataSource = Me.DsCajas
        Me.dgvDatos.Location = New System.Drawing.Point(13, 79)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(964, 395)
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
        Me.NOMALMDataGridViewTextBoxColumn.HeaderText = "ALMACEN"
        Me.NOMALMDataGridViewTextBoxColumn.Name = "NOMALMDataGridViewTextBoxColumn"
        Me.NOMALMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FOLIODataGridViewTextBoxColumn
        '
        Me.FOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.Name = "FOLIODataGridViewTextBoxColumn"
        Me.FOLIODataGridViewTextBoxColumn.ReadOnly = True
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
        Me.MARCACTEPRODDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Name = "MARCACTEPRODDataGridViewTextBoxColumn"
        Me.MARCACTEPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'NOMCTEPRODDataGridViewTextBoxColumn
        '
        Me.NOMCTEPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_PROD"
        Me.NOMCTEPRODDataGridViewTextBoxColumn.HeaderText = "NOM_CTE_PROD"
        Me.NOMCTEPRODDataGridViewTextBoxColumn.Name = "NOMCTEPRODDataGridViewTextBoxColumn"
        Me.NOMCTEPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEPRODDataGridViewTextBoxColumn.Visible = False
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
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "INTROD."
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Name = "MARCACTEINTRDataGridViewTextBoxColumn"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEINTRDataGridViewTextBoxColumn.Width = 60
        '
        'NOMCTEINTRDataGridViewTextBoxColumn
        '
        Me.NOMCTEINTRDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_INTR"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.HeaderText = "INTRODUCTOR"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Name = "NOMCTEINTRDataGridViewTextBoxColumn"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Visible = False
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Width = 150
        '
        'ID_CTE_DEST
        '
        Me.ID_CTE_DEST.DataPropertyName = "ID_CTE_DEST"
        Me.ID_CTE_DEST.HeaderText = "ID_CTE_DEST"
        Me.ID_CTE_DEST.Name = "ID_CTE_DEST"
        Me.ID_CTE_DEST.ReadOnly = True
        Me.ID_CTE_DEST.Visible = False
        '
        'MARCA_CTE_DEST
        '
        Me.MARCA_CTE_DEST.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCA_CTE_DEST.HeaderText = "DESTINO"
        Me.MARCA_CTE_DEST.Name = "MARCA_CTE_DEST"
        Me.MARCA_CTE_DEST.ReadOnly = True
        Me.MARCA_CTE_DEST.Width = 60
        '
        'NOM_CTE_DEST
        '
        Me.NOM_CTE_DEST.DataPropertyName = "NOM_CTE_DEST"
        Me.NOM_CTE_DEST.HeaderText = "NOM_CTE_DEST"
        Me.NOM_CTE_DEST.Name = "NOM_CTE_DEST"
        Me.NOM_CTE_DEST.ReadOnly = True
        Me.NOM_CTE_DEST.Visible = False
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
        Me.HORADataGridViewTextBoxColumn.Visible = False
        '
        'CAJASDataGridViewTextBoxColumn
        '
        Me.CAJASDataGridViewTextBoxColumn.DataPropertyName = "CAJAS"
        Me.CAJASDataGridViewTextBoxColumn.HeaderText = "CAJAS"
        Me.CAJASDataGridViewTextBoxColumn.Name = "CAJASDataGridViewTextBoxColumn"
        Me.CAJASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
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
        'SACLOTEDataGridViewTextBoxColumn
        '
        Me.SACLOTEDataGridViewTextBoxColumn.DataPropertyName = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.HeaderText = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.Name = "SACLOTEDataGridViewTextBoxColumn"
        Me.SACLOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLOTEDataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Width = 300
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
        'ESTATUS
        '
        Me.ESTATUS.DataPropertyName = "ESTATUS"
        Me.ESTATUS.HeaderText = "ESTATUS"
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
        Me.ESTATUS.Visible = False
        '
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCONS_RelacionEntradaCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(993, 509)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCONS_RelacionEntradaCajas"
        Me.ShowInTaskbar = False
        Me.Text = "Relación de Entradas de Cajas"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DsCajas As SistemaControlProduccion.dsCajas
    Friend WithEvents REN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_CTE_DEST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA_CTE_DEST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOM_CTE_DEST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFOLIOENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFOLIOSALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAMODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACANCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIOCANCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESCREFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
