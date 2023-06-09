<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_INVENTARIOXINTR
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DsCajas = New SistemaControlProduccion.dsCajas()
        Me.SPINVENTARIOXINTRODUCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_INVENTARIO_X_INTRODUCTORTableAdapter = New SistemaControlProduccion.dsCajasTableAdapters.SP_INVENTARIO_X_INTRODUCTORTableAdapter()
        Me.MARCACTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KILOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPINVENTARIOXINTRODUCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btnImprimir)
        Me.Panel8.Controls.Add(Me.btnActualizar)
        Me.Panel8.Location = New System.Drawing.Point(12, 22)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(518, 81)
        Me.Panel8.TabIndex = 1
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(106, 14)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 53)
        Me.btnImprimir.TabIndex = 86
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.Location = New System.Drawing.Point(15, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 54)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCACTEINTRDataGridViewTextBoxColumn, Me.NOMCTEINTRDataGridViewTextBoxColumn, Me.CAJASDataGridViewTextBoxColumn, Me.KILOSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SPINVENTARIOXINTRODUCTORBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(518, 379)
        Me.DataGridView1.TabIndex = 2
        '
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPINVENTARIOXINTRODUCTORBindingSource
        '
        Me.SPINVENTARIOXINTRODUCTORBindingSource.DataMember = "SP_INVENTARIO_X_INTRODUCTOR"
        Me.SPINVENTARIOXINTRODUCTORBindingSource.DataSource = Me.DsCajas
        '
        'SP_INVENTARIO_X_INTRODUCTORTableAdapter
        '
        Me.SP_INVENTARIO_X_INTRODUCTORTableAdapter.ClearBeforeFill = True
        '
        'MARCACTEINTRDataGridViewTextBoxColumn
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn.HeaderText = "MARCA"
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
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Width = 250
        '
        'CAJASDataGridViewTextBoxColumn
        '
        Me.CAJASDataGridViewTextBoxColumn.DataPropertyName = "CAJAS"
        Me.CAJASDataGridViewTextBoxColumn.HeaderText = "CAJAS"
        Me.CAJASDataGridViewTextBoxColumn.Name = "CAJASDataGridViewTextBoxColumn"
        Me.CAJASDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJASDataGridViewTextBoxColumn.Width = 70
        '
        'KILOSDataGridViewTextBoxColumn
        '
        Me.KILOSDataGridViewTextBoxColumn.DataPropertyName = "KILOS"
        Me.KILOSDataGridViewTextBoxColumn.HeaderText = "KILOS"
        Me.KILOSDataGridViewTextBoxColumn.Name = "KILOSDataGridViewTextBoxColumn"
        Me.KILOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.KILOSDataGridViewTextBoxColumn.Width = 90
        '
        'frmCONS_INVENTARIOXINTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 515)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel8)
        Me.MaximizeBox = False
        Me.Name = "frmCONS_INVENTARIOXINTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCONS_INVENTARIOXINTR"
        Me.Panel8.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPINVENTARIOXINTRODUCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsCajas As SistemaControlProduccion.dsCajas
    Friend WithEvents SPINVENTARIOXINTRODUCTORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_INVENTARIO_X_INTRODUCTORTableAdapter As SistemaControlProduccion.dsCajasTableAdapters.SP_INVENTARIO_X_INTRODUCTORTableAdapter
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KILOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
