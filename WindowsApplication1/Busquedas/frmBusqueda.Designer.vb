<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
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
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dsBusqueda = New System.Data.DataSet()
        Me.BITACORA = New System.Data.DataTable()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.CLIENTES = New System.Data.DataTable()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.ProductosCTE = New System.Data.DataTable()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VERIF_MAESTRO = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dsBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BITACORA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosCTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VERIF_MAESTRO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.AllowUserToOrderColumns = True
        Me.dgvBusqueda.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvBusqueda.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBusqueda.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(7, 40)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.ReadOnly = True
        Me.dgvBusqueda.RowHeadersVisible = False
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(593, 335)
        Me.dgvBusqueda.StandardTab = True
        Me.dgvBusqueda.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.AcceptsReturn = True
        Me.txtBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.Window
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusqueda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBusqueda.Location = New System.Drawing.Point(82, 12)
        Me.txtBusqueda.MaxLength = 0
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBusqueda.Size = New System.Drawing.Size(523, 22)
        Me.txtBusqueda.TabIndex = 1
        '
        'lblBusqueda
        '
        Me.lblBusqueda.BackColor = System.Drawing.SystemColors.Control
        Me.lblBusqueda.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBusqueda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBusqueda.Location = New System.Drawing.Point(3, 13)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBusqueda.Size = New System.Drawing.Size(73, 18)
        Me.lblBusqueda.TabIndex = 0
        Me.lblBusqueda.Text = "Buscar:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 378)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(607, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(306, 17)
        Me.ToolStripStatusLabel1.Text = "Seleccione un registro y presione Enter ó haga doble clic."
        '
        'dsBusqueda
        '
        Me.dsBusqueda.DataSetName = "dsBusqueda"
        Me.dsBusqueda.Tables.AddRange(New System.Data.DataTable() {Me.BITACORA, Me.DataTable1, Me.DataTable2, Me.CLIENTES, Me.ProductosCTE, Me.VERIF_MAESTRO})
        '
        'BITACORA
        '
        Me.BITACORA.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn17, Me.DataColumn18, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.BITACORA.TableName = "BITACORA"
        '
        'DataColumn17
        '
        Me.DataColumn17.Caption = "CODIGO"
        Me.DataColumn17.ColumnName = "ID_BITACORA"
        '
        'DataColumn18
        '
        Me.DataColumn18.Caption = "FECHA"
        Me.DataColumn18.ColumnName = "FECHA"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "AREA"
        Me.DataColumn1.ColumnName = "DESC_AREA"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "ESPECIE"
        Me.DataColumn2.ColumnName = "DESC_ESPECIE"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "OBSERVACIONES"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ESTATUS"
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable1.TableName = "PREOPERATIVO"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FOLIO"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FECHA"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "OBSERVACIONES"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn14})
        Me.DataTable2.TableName = "PRODUCTOS"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "CODIGO"
        Me.DataColumn8.ColumnName = "ID_PROD"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "PRODUCTO"
        Me.DataColumn9.ColumnName = "NOMBRE"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "FAMILIA"
        Me.DataColumn10.ColumnName = "NOM_FAM"
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "SUB FAMILIA"
        Me.DataColumn14.ColumnName = "NOM_SFAM"
        '
        'CLIENTES
        '
        Me.CLIENTES.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.CLIENTES.TableName = "CLIENTES"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "ID_CTE"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "MARCA"
        Me.DataColumn12.ColumnName = "MARCA"
        '
        'DataColumn13
        '
        Me.DataColumn13.Caption = "NOMBRE"
        Me.DataColumn13.ColumnName = "NOMBRE"
        '
        'ProductosCTE
        '
        Me.ProductosCTE.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.ProductosCTE.TableName = "ProductosCTE"
        '
        'DataColumn15
        '
        Me.DataColumn15.Caption = "CODIGO"
        Me.DataColumn15.ColumnName = "ID_PROD_CTE"
        '
        'DataColumn16
        '
        Me.DataColumn16.Caption = "NOMBRE"
        Me.DataColumn16.ColumnName = "NOMBRE_PROD_CTE"
        '
        'DataColumn19
        '
        Me.DataColumn19.Caption = "FAMILIA"
        Me.DataColumn19.ColumnName = "NOM_FAM"
        '
        'DataColumn20
        '
        Me.DataColumn20.Caption = "SUBFAMILIA"
        Me.DataColumn20.ColumnName = "NOM_SFAM"
        '
        'DataColumn21
        '
        Me.DataColumn21.Caption = "CLIENTE"
        Me.DataColumn21.ColumnName = "MARCA_CTE"
        '
        'BindingSource
        '
        Me.BindingSource.DataSource = Me.dsBusqueda
        Me.BindingSource.Position = 0
        '
        'VERIF_MAESTRO
        '
        Me.VERIF_MAESTRO.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.VERIF_MAESTRO.TableName = "VERIF_MAESTRO"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ID_VER"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "COR_LOTE"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "FECHA"
        '
        'frmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 400)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBusqueda"
        Me.ShowInTaskbar = False
        Me.Text = "Busqueda"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dsBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BITACORA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosCTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VERIF_MAESTRO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Public WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Public WithEvents lblBusqueda As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dsBusqueda As System.Data.DataSet
    Friend WithEvents BITACORA As System.Data.DataTable
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents CLIENTES As System.Data.DataTable
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosCTE As System.Data.DataTable
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents VERIF_MAESTRO As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
End Class
