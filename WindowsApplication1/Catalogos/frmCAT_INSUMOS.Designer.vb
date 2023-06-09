<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAT_INSUMOS
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnguardarlotefecha = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DS_CATINSUMOS = New SistemaControlProduccion.DS_CATINSUMOS()
        Me.INSUMOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INSUMOSTableAdapter = New SistemaControlProduccion.DS_CATINSUMOSTableAdapters.INSUMOSTableAdapter()
        Me.IDINSUMODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CATINSUMOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSUMOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.btnguardarlotefecha})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(862, 39)
        Me.ToolStrip1.TabIndex = 59
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_New_32x32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnguardarlotefecha
        '
        Me.btnguardarlotefecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnguardarlotefecha.Image = Global.SistemaControlProduccion.My.Resources.Resources.Action_Save_32x32
        Me.btnguardarlotefecha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnguardarlotefecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnguardarlotefecha.Name = "btnguardarlotefecha"
        Me.btnguardarlotefecha.Size = New System.Drawing.Size(36, 36)
        Me.btnguardarlotefecha.Text = "ToolStripButton1"
        Me.btnguardarlotefecha.ToolTipText = "Guardar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ID:"
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(72, 58)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(63, 20)
        Me.TXTID.TabIndex = 61
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOMBRE.Location = New System.Drawing.Point(72, 84)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(266, 20)
        Me.TXTNOMBRE.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "NOMBRE:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDINSUMODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.INSUMOSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.Size = New System.Drawing.Size(835, 150)
        Me.DataGridView1.TabIndex = 64
        '
        'DS_CATINSUMOS
        '
        Me.DS_CATINSUMOS.DataSetName = "DS_CATINSUMOS"
        Me.DS_CATINSUMOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INSUMOSBindingSource
        '
        Me.INSUMOSBindingSource.DataMember = "INSUMOS"
        Me.INSUMOSBindingSource.DataSource = Me.DS_CATINSUMOS
        '
        'INSUMOSTableAdapter
        '
        Me.INSUMOSTableAdapter.ClearBeforeFill = True
        '
        'IDINSUMODataGridViewTextBoxColumn
        '
        Me.IDINSUMODataGridViewTextBoxColumn.DataPropertyName = "ID_INSUMO"
        Me.IDINSUMODataGridViewTextBoxColumn.HeaderText = "ID_INSUMO"
        Me.IDINSUMODataGridViewTextBoxColumn.Name = "IDINSUMODataGridViewTextBoxColumn"
        Me.IDINSUMODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMBREDataGridViewTextBoxColumn.Width = 300
        '
        'frmCAT_INSUMOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 365)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCAT_INSUMOS"
        Me.Text = "frmCAT_INSUMOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CATINSUMOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSUMOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnguardarlotefecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTID As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DS_CATINSUMOS As SistemaControlProduccion.DS_CATINSUMOS
    Friend WithEvents INSUMOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INSUMOSTableAdapter As SistemaControlProduccion.DS_CATINSUMOSTableAdapters.INSUMOSTableAdapter
    Friend WithEvents IDINSUMODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
