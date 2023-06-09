<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_InventarioVisceras
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
        Me.cmbEspecie = New System.Windows.Forms.ComboBox()
        Me.DsCatalogos = New SistemaControlProduccion.dsCatalogos()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.dgvDisponibles = New System.Windows.Forms.DataGridView()
        Me.IDALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.Panel1.SuspendLayout()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.btnAtualizar)
        Me.Panel2.Controls.Add(Me.chkTodos)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Location = New System.Drawing.Point(283, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 83)
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
        Me.btnAtualizar.Location = New System.Drawing.Point(480, 12)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(72, 57)
        Me.btnAtualizar.TabIndex = 4
        Me.btnAtualizar.Text = "&Actualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(425, 41)
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
        Me.Label3.Size = New System.Drawing.Size(505, 23)
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
        Me.Label6.Size = New System.Drawing.Size(567, 86)
        Me.Label6.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(837, 501)
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
        Me.lblCajasDisponibles.Text = "Inventario"
        Me.lblCajasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
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
        Me.dgvDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDALMDataGridViewTextBoxColumn, Me.IDCTEINTRDataGridViewTextBoxColumn, Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.ESTATUSDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn, Me.NOMPRODDataGridViewTextBoxColumn, Me.PIEZASDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.TARADataGridViewTextBoxColumn})
        Me.dgvDisponibles.DataMember = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_VISCERAS"
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
        'IDALMDataGridViewTextBoxColumn
        '
        Me.IDALMDataGridViewTextBoxColumn.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn.Name = "IDALMDataGridViewTextBoxColumn"
        Me.IDALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDALMDataGridViewTextBoxColumn.Visible = False
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IDPRODDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.IDPRODDataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.IDPRODDataGridViewTextBoxColumn.Name = "IDPRODDataGridViewTextBoxColumn"
        Me.IDPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn.Width = 70
        '
        'NOMPRODDataGridViewTextBoxColumn
        '
        Me.NOMPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn.HeaderText = "PRODUCTO"
        Me.NOMPRODDataGridViewTextBoxColumn.Name = "NOMPRODDataGridViewTextBoxColumn"
        Me.NOMPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn.Width = 300
        '
        'PIEZASDataGridViewTextBoxColumn
        '
        Me.PIEZASDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PIEZASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PIEZASDataGridViewTextBoxColumn.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn.Name = "PIEZASDataGridViewTextBoxColumn"
        Me.PIEZASDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn.Width = 60
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PESODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn.Width = 70
        '
        'TARADataGridViewTextBoxColumn
        '
        Me.TARADataGridViewTextBoxColumn.DataPropertyName = "TARA"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TARADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TARADataGridViewTextBoxColumn.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn.Name = "TARADataGridViewTextBoxColumn"
        Me.TARADataGridViewTextBoxColumn.ReadOnly = True
        Me.TARADataGridViewTextBoxColumn.Width = 60
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCONS_InventarioVisceras
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
        Me.Name = "frmCONS_InventarioVisceras"
        Me.ShowInTaskbar = False
        Me.Text = "Inventario de visceras"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents IDALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsCatalogos As SistemaControlProduccion.dsCatalogos
    Friend WithEvents cmbEspecie As System.Windows.Forms.ComboBox
End Class
