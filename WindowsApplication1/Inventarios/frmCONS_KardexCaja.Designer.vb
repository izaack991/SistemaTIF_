<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_KardexCaja
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCajasDisponibles = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDisponibles = New System.Windows.Forms.DataGridView()
        Me.DsInventarios = New SistemaControlProduccion.dsInventarios()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MOVIMIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIOCANCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCORTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASERIEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIASCADUCIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHACADUCIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJACODBARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
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
        Me.txtNomIntroductor.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Location = New System.Drawing.Point(343, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 83)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Location = New System.Drawing.Point(-1, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(438, 84)
        Me.Panel3.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 34)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 26)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(-2, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(435, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Datos del introductor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(95, 34)
        Me.TextBox2.MaxLength = 6
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(324, 26)
        Me.TextBox2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, -3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(441, 86)
        Me.Label7.TabIndex = 6
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Enabled = False
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(13, 34)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 3
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
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos del introductor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(342, 9)
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
        Me.Label9.Size = New System.Drawing.Size(1051, 489)
        Me.Label9.TabIndex = 41
        '
        'lblCajasDisponibles
        '
        Me.lblCajasDisponibles.BackColor = System.Drawing.SystemColors.Control
        Me.lblCajasDisponibles.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajasDisponibles.ForeColor = System.Drawing.Color.Maroon
        Me.lblCajasDisponibles.Location = New System.Drawing.Point(12, 104)
        Me.lblCajasDisponibles.Name = "lblCajasDisponibles"
        Me.lblCajasDisponibles.Size = New System.Drawing.Size(1047, 23)
        Me.lblCajasDisponibles.TabIndex = 5
        Me.lblCajasDisponibles.Text = "Inventario"
        Me.lblCajasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1071, 22)
        Me.StatusStrip1.TabIndex = 7
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel3.Text = "F2|Nuevo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 83)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightYellow
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(118, 34)
        Me.txtID.MaxLength = 7
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(114, 29)
        Me.txtID.TabIndex = 1
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(-2, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos de la caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 86)
        Me.Label2.TabIndex = 43
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
        Me.dgvDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MOVIMIENTO, Me.IDALMDataGridViewTextBoxColumn, Me.NOMALMDataGridViewTextBoxColumn, Me.FOLIODataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.USUARIODataGridViewTextBoxColumn, Me.USUARIOCANCDataGridViewTextBoxColumn, Me.ESTATUS, Me.IDCORTEDataGridViewTextBoxColumn, Me.CORLOTEDataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.IDESDDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.IDPRODCTEDataGridViewTextBoxColumn, Me.NOMBREPRODCTEDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.LBSDataGridViewTextBoxColumn, Me.TARADataGridViewTextBoxColumn, Me.CAJASERIEIDDataGridViewTextBoxColumn, Me.CAJAFECHAETIQDataGridViewTextBoxColumn, Me.HORAESDDataGridViewTextBoxColumn, Me.DIASCADUCIDADDataGridViewTextBoxColumn, Me.FECHACADUCIDADDataGridViewTextBoxColumn, Me.FECHAESDDataGridViewTextBoxColumn, Me.CAJASERIEDataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn, Me.CAJACODBARDataGridViewTextBoxColumn})
        Me.dgvDisponibles.DataMember = "SP_CONS_KARDEX_CAJA"
        Me.dgvDisponibles.DataSource = Me.DsInventarios
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDisponibles.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDisponibles.Location = New System.Drawing.Point(11, 130)
        Me.dgvDisponibles.Name = "dgvDisponibles"
        Me.dgvDisponibles.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisponibles.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDisponibles.RowHeadersVisible = False
        Me.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisponibles.Size = New System.Drawing.Size(1049, 471)
        Me.dgvDisponibles.StandardTab = True
        Me.dgvDisponibles.TabIndex = 6
        '
        'DsInventarios
        '
        Me.DsInventarios.DataSetName = "dsInventarios"
        Me.DsInventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(789, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(270, 84)
        Me.Panel4.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(-2, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(788, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(273, 86)
        Me.Label10.TabIndex = 45
        '
        'MOVIMIENTO
        '
        Me.MOVIMIENTO.DataPropertyName = "NOM_MOV"
        Me.MOVIMIENTO.HeaderText = "MOVIMIENTO"
        Me.MOVIMIENTO.Name = "MOVIMIENTO"
        Me.MOVIMIENTO.ReadOnly = True
        Me.MOVIMIENTO.Width = 200
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
        'FOLIODataGridViewTextBoxColumn
        '
        Me.FOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FOLIODataGridViewTextBoxColumn.Name = "FOLIODataGridViewTextBoxColumn"
        Me.FOLIODataGridViewTextBoxColumn.ReadOnly = True
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
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.ReadOnly = True
        Me.HORADataGridViewTextBoxColumn.Visible = False
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
        'ESTATUS
        '
        Me.ESTATUS.DataPropertyName = "ESTATUS"
        Me.ESTATUS.HeaderText = "ESTATUS"
        Me.ESTATUS.Name = "ESTATUS"
        Me.ESTATUS.ReadOnly = True
        Me.ESTATUS.Visible = False
        '
        'IDCORTEDataGridViewTextBoxColumn
        '
        Me.IDCORTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CORTE"
        Me.IDCORTEDataGridViewTextBoxColumn.HeaderText = "ID CORTE"
        Me.IDCORTEDataGridViewTextBoxColumn.Name = "IDCORTEDataGridViewTextBoxColumn"
        Me.IDCORTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCORTEDataGridViewTextBoxColumn.Width = 80
        '
        'CORLOTEDataGridViewTextBoxColumn
        '
        Me.CORLOTEDataGridViewTextBoxColumn.DataPropertyName = "COR_LOTE"
        Me.CORLOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.CORLOTEDataGridViewTextBoxColumn.Name = "CORLOTEDataGridViewTextBoxColumn"
        Me.CORLOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CORLOTEDataGridViewTextBoxColumn.Width = 60
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Visible = False
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
        Me.IDPRODDataGridViewTextBoxColumn.Width = 80
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn.Visible = False
        '
        'IDPRODCTEDataGridViewTextBoxColumn
        '
        Me.IDPRODCTEDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODCTE"
        Me.IDPRODCTEDataGridViewTextBoxColumn.HeaderText = "COD. PROD."
        Me.IDPRODCTEDataGridViewTextBoxColumn.Name = "IDPRODCTEDataGridViewTextBoxColumn"
        Me.IDPRODCTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODCTEDataGridViewTextBoxColumn.Width = 70
        '
        'NOMBREPRODCTEDataGridViewTextBoxColumn
        '
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PRODCTE"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.HeaderText = "PRODUCTO"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.Name = "NOMBREPRODCTEDataGridViewTextBoxColumn"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn.Width = 200
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PIEZASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn.Width = 40
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn.Width = 50
        '
        'LBSDataGridViewTextBoxColumn
        '
        Me.LBSDataGridViewTextBoxColumn.DataPropertyName = "LBS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.LBSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.LBSDataGridViewTextBoxColumn.HeaderText = "LBS"
        Me.LBSDataGridViewTextBoxColumn.Name = "LBSDataGridViewTextBoxColumn"
        Me.LBSDataGridViewTextBoxColumn.ReadOnly = True
        Me.LBSDataGridViewTextBoxColumn.Visible = False
        '
        'TARADataGridViewTextBoxColumn
        '
        Me.TARADataGridViewTextBoxColumn.DataPropertyName = "TARA"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TARADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TARADataGridViewTextBoxColumn.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn.Name = "TARADataGridViewTextBoxColumn"
        Me.TARADataGridViewTextBoxColumn.ReadOnly = True
        Me.TARADataGridViewTextBoxColumn.Width = 50
        '
        'CAJASERIEIDDataGridViewTextBoxColumn
        '
        Me.CAJASERIEIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_SERIE_ID"
        Me.CAJASERIEIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.CAJASERIEIDDataGridViewTextBoxColumn.Name = "CAJASERIEIDDataGridViewTextBoxColumn"
        Me.CAJASERIEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJASERIEIDDataGridViewTextBoxColumn.Width = 60
        '
        'CAJAFECHAETIQDataGridViewTextBoxColumn
        '
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.DataPropertyName = "CAJA_FECHA_ETIQ"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.HeaderText = "FECHA PROD."
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.Name = "CAJAFECHAETIQDataGridViewTextBoxColumn"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn.Width = 80
        '
        'HORAESDDataGridViewTextBoxColumn
        '
        Me.HORAESDDataGridViewTextBoxColumn.DataPropertyName = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn.HeaderText = "FECHA MOV."
        Me.HORAESDDataGridViewTextBoxColumn.Name = "HORAESDDataGridViewTextBoxColumn"
        Me.HORAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAESDDataGridViewTextBoxColumn.Width = 140
        '
        'DIASCADUCIDADDataGridViewTextBoxColumn
        '
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.DataPropertyName = "DIAS_CADUCIDAD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.HeaderText = "DIAS CAD."
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.Name = "DIASCADUCIDADDataGridViewTextBoxColumn"
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.ReadOnly = True
        Me.DIASCADUCIDADDataGridViewTextBoxColumn.Width = 60
        '
        'FECHACADUCIDADDataGridViewTextBoxColumn
        '
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CADUCIDAD"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.HeaderText = "FECHA CAD."
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.Name = "FECHACADUCIDADDataGridViewTextBoxColumn"
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHACADUCIDADDataGridViewTextBoxColumn.Width = 80
        '
        'FECHAESDDataGridViewTextBoxColumn
        '
        Me.FECHAESDDataGridViewTextBoxColumn.DataPropertyName = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn.HeaderText = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn.Name = "FECHAESDDataGridViewTextBoxColumn"
        Me.FECHAESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAESDDataGridViewTextBoxColumn.Visible = False
        '
        'CAJASERIEDataGridViewTextBoxColumn
        '
        Me.CAJASERIEDataGridViewTextBoxColumn.DataPropertyName = "CAJA_SERIE"
        Me.CAJASERIEDataGridViewTextBoxColumn.HeaderText = "CAJA_SERIE"
        Me.CAJASERIEDataGridViewTextBoxColumn.Name = "CAJASERIEDataGridViewTextBoxColumn"
        Me.CAJASERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJASERIEDataGridViewTextBoxColumn.Visible = False
        '
        'CAJAIDDataGridViewTextBoxColumn
        '
        Me.CAJAIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.Name = "CAJAIDDataGridViewTextBoxColumn"
        Me.CAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAIDDataGridViewTextBoxColumn.Visible = False
        '
        'CAJACODBARDataGridViewTextBoxColumn
        '
        Me.CAJACODBARDataGridViewTextBoxColumn.DataPropertyName = "CAJA_CODBAR"
        Me.CAJACODBARDataGridViewTextBoxColumn.HeaderText = "CODBAR"
        Me.CAJACODBARDataGridViewTextBoxColumn.Name = "CAJACODBARDataGridViewTextBoxColumn"
        Me.CAJACODBARDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJACODBARDataGridViewTextBoxColumn.Width = 160
        '
        'frmCONS_KardexCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1071, 639)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblCajasDisponibles)
        Me.Controls.Add(Me.dgvDisponibles)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCONS_KardexCaja"
        Me.ShowInTaskbar = False
        Me.Text = "Kardex por caja"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvDisponibles As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCajasDisponibles As System.Windows.Forms.Label
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents DsInventarios As SistemaControlProduccion.dsInventarios
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MOVIMIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FOLIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIOCANCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCORTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CORLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREPRODCTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJASERIEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAFECHAETIQDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASCADUCIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHACADUCIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJASERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJACODBARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
