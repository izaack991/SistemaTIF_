<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaPrecios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnguardarlotefecha = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTNOCLIENTE = New System.Windows.Forms.TextBox()
        Me.TXTIDCLIENTE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.DTPFECHA = New System.Windows.Forms.DateTimePicker()
        Me.TXTNOMLISTA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTPRECIO = New System.Windows.Forms.TextBox()
        Me.TXTNOMINSUMO = New System.Windows.Forms.TextBox()
        Me.TXTIDINSUMO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_PROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PRODCTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMPLISTAPRECIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_TMP_LISTA_PRECIOS = New SistemaControlProduccion.DS_TMP_LISTA_PRECIOS()
        Me.TMP_LISTA_PRECIOSTableAdapter = New SistemaControlProduccion.DS_TMP_LISTA_PRECIOSTableAdapters.TMP_LISTA_PRECIOSTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMPLISTAPRECIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TMP_LISTA_PRECIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.btnguardarlotefecha})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 39)
        Me.ToolStrip1.TabIndex = 61
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TXTNOCLIENTE)
        Me.GroupBox1.Controls.Add(Me.TXTIDCLIENTE)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTID)
        Me.GroupBox1.Controls.Add(Me.DTPFECHA)
        Me.GroupBox1.Controls.Add(Me.TXTNOMLISTA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 142)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'TXTNOCLIENTE
        '
        Me.TXTNOCLIENTE.Location = New System.Drawing.Point(180, 96)
        Me.TXTNOCLIENTE.Name = "TXTNOCLIENTE"
        Me.TXTNOCLIENTE.Size = New System.Drawing.Size(356, 20)
        Me.TXTNOCLIENTE.TabIndex = 2
        '
        'TXTIDCLIENTE
        '
        Me.TXTIDCLIENTE.Location = New System.Drawing.Point(99, 96)
        Me.TXTIDCLIENTE.Name = "TXTIDCLIENTE"
        Me.TXTIDCLIENTE.Size = New System.Drawing.Size(75, 20)
        Me.TXTIDCLIENTE.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FECHA"
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(99, 44)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(75, 20)
        Me.TXTID.TabIndex = 4
        '
        'DTPFECHA
        '
        Me.DTPFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFECHA.Location = New System.Drawing.Point(99, 19)
        Me.DTPFECHA.Name = "DTPFECHA"
        Me.DTPFECHA.Size = New System.Drawing.Size(135, 20)
        Me.DTPFECHA.TabIndex = 3
        '
        'TXTNOMLISTA
        '
        Me.TXTNOMLISTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOMLISTA.Location = New System.Drawing.Point(99, 70)
        Me.TXTNOMLISTA.Name = "TXTNOMLISTA"
        Me.TXTNOMLISTA.Size = New System.Drawing.Size(437, 20)
        Me.TXTNOMLISTA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.SimpleButton2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TXTPRECIO)
        Me.GroupBox2.Controls.Add(Me.TXTNOMINSUMO)
        Me.GroupBox2.Controls.Add(Me.TXTIDINSUMO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(773, 327)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(675, 19)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(36, 32)
        Me.SimpleButton2.TabIndex = 17
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(541, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "PRECIO"
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.Location = New System.Drawing.Point(594, 25)
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(75, 20)
        Me.TXTPRECIO.TabIndex = 13
        '
        'TXTNOMINSUMO
        '
        Me.TXTNOMINSUMO.Location = New System.Drawing.Point(180, 25)
        Me.TXTNOMINSUMO.Name = "TXTNOMINSUMO"
        Me.TXTNOMINSUMO.Size = New System.Drawing.Size(356, 20)
        Me.TXTNOMINSUMO.TabIndex = 15
        '
        'TXTIDINSUMO
        '
        Me.TXTIDINSUMO.Location = New System.Drawing.Point(99, 25)
        Me.TXTIDINSUMO.Name = "TXTIDINSUMO"
        Me.TXTIDINSUMO.Size = New System.Drawing.Size(75, 20)
        Me.TXTIDINSUMO.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "PRODUCTO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_PROD, Me.ID_PRODCTE, Me.NOMBRE, Me.PRECIODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TMPLISTAPRECIOSBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(761, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'ID_PROD
        '
        Me.ID_PROD.DataPropertyName = "ID_PROD"
        Me.ID_PROD.HeaderText = "ID_PROD"
        Me.ID_PROD.Name = "ID_PROD"
        Me.ID_PROD.ReadOnly = True
        Me.ID_PROD.Visible = False
        '
        'ID_PRODCTE
        '
        Me.ID_PRODCTE.DataPropertyName = "ID_PRODCTE"
        Me.ID_PRODCTE.HeaderText = "ID_PRODCTE"
        Me.ID_PRODCTE.Name = "ID_PRODCTE"
        Me.ID_PRODCTE.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 350
        '
        'PRECIODataGridViewTextBoxColumn
        '
        Me.PRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.Name = "PRECIODataGridViewTextBoxColumn"
        Me.PRECIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TMPLISTAPRECIOSBindingSource
        '
        Me.TMPLISTAPRECIOSBindingSource.DataMember = "TMP_LISTA_PRECIOS"
        Me.TMPLISTAPRECIOSBindingSource.DataSource = Me.DS_TMP_LISTA_PRECIOS
        '
        'DS_TMP_LISTA_PRECIOS
        '
        Me.DS_TMP_LISTA_PRECIOS.DataSetName = "DS_TMP_LISTA_PRECIOS"
        Me.DS_TMP_LISTA_PRECIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TMP_LISTA_PRECIOSTableAdapter
        '
        Me.TMP_LISTA_PRECIOSTableAdapter.ClearBeforeFill = True
        '
        'frmListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 541)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmListaPrecios"
        Me.Text = "frmListaPrecios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMPLISTAPRECIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TMP_LISTA_PRECIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnguardarlotefecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTID As System.Windows.Forms.TextBox
    Friend WithEvents DTPFECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTNOMLISTA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOMINSUMO As System.Windows.Forms.TextBox
    Friend WithEvents TXTIDINSUMO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXTNOCLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents TXTIDCLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DS_TMP_LISTA_PRECIOS As SistemaControlProduccion.DS_TMP_LISTA_PRECIOS
    Friend WithEvents TMPLISTAPRECIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TMP_LISTA_PRECIOSTableAdapter As SistemaControlProduccion.DS_TMP_LISTA_PRECIOSTableAdapters.TMP_LISTA_PRECIOSTableAdapter
    Friend WithEvents ID_PROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PRODCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
