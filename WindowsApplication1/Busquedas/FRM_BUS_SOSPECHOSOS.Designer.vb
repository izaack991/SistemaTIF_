<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_BUS_SOSPECHOSOS
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACMAYORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECUTIVODIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOSPECHOSODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ENTSALDETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_SOSPECHOSOS = New SistemaControlProduccion.DS_SOSPECHOSOS()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.ENTSAL_DETTableAdapter = New SistemaControlProduccion.DS_SOSPECHOSOSTableAdapters.ENTSAL_DETTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTSALDETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_SOSPECHOSOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDESDDataGridViewTextBoxColumn, Me.IDESCDataGridViewTextBoxColumn, Me.PESODataGridViewTextBoxColumn, Me.HORADataGridViewTextBoxColumn, Me.SACSERIEDataGridViewTextBoxColumn, Me.SACIDDataGridViewTextBoxColumn, Me.SACLADODataGridViewTextBoxColumn, Me.SACSEXODataGridViewTextBoxColumn, Me.SACMAYORDataGridViewTextBoxColumn, Me.CONSECUTIVODIADataGridViewTextBoxColumn, Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn, Me.ESTATUSDataGridViewTextBoxColumn, Me.SOSPECHOSODataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ENTSALDETBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(667, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IDESDDataGridViewTextBoxColumn
        '
        Me.IDESDDataGridViewTextBoxColumn.DataPropertyName = "ID_ESD"
        Me.IDESDDataGridViewTextBoxColumn.HeaderText = "ID_ESD"
        Me.IDESDDataGridViewTextBoxColumn.Name = "IDESDDataGridViewTextBoxColumn"
        Me.IDESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESDDataGridViewTextBoxColumn.Visible = False
        Me.IDESDDataGridViewTextBoxColumn.Width = 80
        '
        'IDESCDataGridViewTextBoxColumn
        '
        Me.IDESCDataGridViewTextBoxColumn.DataPropertyName = "ID_ESC"
        Me.IDESCDataGridViewTextBoxColumn.HeaderText = "ID_ESC"
        Me.IDESCDataGridViewTextBoxColumn.Name = "IDESCDataGridViewTextBoxColumn"
        Me.IDESCDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDESCDataGridViewTextBoxColumn.Visible = False
        '
        'PESODataGridViewTextBoxColumn
        '
        Me.PESODataGridViewTextBoxColumn.DataPropertyName = "PESO"
        Me.PESODataGridViewTextBoxColumn.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn.Name = "PESODataGridViewTextBoxColumn"
        Me.PESODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn.Visible = False
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.ReadOnly = True
        '
        'SACSERIEDataGridViewTextBoxColumn
        '
        Me.SACSERIEDataGridViewTextBoxColumn.DataPropertyName = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.HeaderText = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.Name = "SACSERIEDataGridViewTextBoxColumn"
        Me.SACSERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSERIEDataGridViewTextBoxColumn.Width = 80
        '
        'SACIDDataGridViewTextBoxColumn
        '
        Me.SACIDDataGridViewTextBoxColumn.DataPropertyName = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.HeaderText = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.Name = "SACIDDataGridViewTextBoxColumn"
        Me.SACIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACIDDataGridViewTextBoxColumn.Width = 80
        '
        'SACLADODataGridViewTextBoxColumn
        '
        Me.SACLADODataGridViewTextBoxColumn.DataPropertyName = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.HeaderText = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.Name = "SACLADODataGridViewTextBoxColumn"
        Me.SACLADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLADODataGridViewTextBoxColumn.Width = 80
        '
        'SACSEXODataGridViewTextBoxColumn
        '
        Me.SACSEXODataGridViewTextBoxColumn.DataPropertyName = "SAC_SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.HeaderText = "SAC_SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.Name = "SACSEXODataGridViewTextBoxColumn"
        Me.SACSEXODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSEXODataGridViewTextBoxColumn.Width = 80
        '
        'SACMAYORDataGridViewTextBoxColumn
        '
        Me.SACMAYORDataGridViewTextBoxColumn.DataPropertyName = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.HeaderText = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.Name = "SACMAYORDataGridViewTextBoxColumn"
        Me.SACMAYORDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACMAYORDataGridViewTextBoxColumn.Width = 80
        '
        'CONSECUTIVODIADataGridViewTextBoxColumn
        '
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.DataPropertyName = "CONSECUTIVO_DIA"
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.HeaderText = "CONS_DIA"
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.Name = "CONSECUTIVODIADataGridViewTextBoxColumn"
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.Width = 80
        '
        'CONSECUTIVOLOTEDataGridViewTextBoxColumn
        '
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.DataPropertyName = "CONSECUTIVO_LOTE"
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.HeaderText = "CONS_LOTE"
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.Name = "CONSECUTIVOLOTEDataGridViewTextBoxColumn"
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.Width = 80
        '
        'ESTATUSDataGridViewTextBoxColumn
        '
        Me.ESTATUSDataGridViewTextBoxColumn.DataPropertyName = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.HeaderText = "ESTATUS"
        Me.ESTATUSDataGridViewTextBoxColumn.Name = "ESTATUSDataGridViewTextBoxColumn"
        Me.ESTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTATUSDataGridViewTextBoxColumn.Width = 80
        '
        'SOSPECHOSODataGridViewCheckBoxColumn
        '
        Me.SOSPECHOSODataGridViewCheckBoxColumn.DataPropertyName = "SOSPECHOSO"
        Me.SOSPECHOSODataGridViewCheckBoxColumn.HeaderText = "SOSPECHOSO"
        Me.SOSPECHOSODataGridViewCheckBoxColumn.Name = "SOSPECHOSODataGridViewCheckBoxColumn"
        Me.SOSPECHOSODataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ENTSALDETBindingSource
        '
        Me.ENTSALDETBindingSource.DataMember = "ENTSAL_DET"
        Me.ENTSALDETBindingSource.DataSource = Me.DS_SOSPECHOSOS
        '
        'DS_SOSPECHOSOS
        '
        Me.DS_SOSPECHOSOS.DataSetName = "DS_SOSPECHOSOS"
        Me.DS_SOSPECHOSOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.Location = New System.Drawing.Point(533, 196)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNACEPTAR.TabIndex = 1
        Me.BTNACEPTAR.Text = "ACEPTAR"
        Me.BTNACEPTAR.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Location = New System.Drawing.Point(614, 196)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNCANCELAR.TabIndex = 2
        Me.BTNCANCELAR.Text = "CANCELAR"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'ENTSAL_DETTableAdapter
        '
        Me.ENTSAL_DETTableAdapter.ClearBeforeFill = True
        '
        'FRM_BUS_SOSPECHOSOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 228)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRM_BUS_SOSPECHOSOS"
        Me.Text = "FRM_BUS_SOSPECHOSOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTSALDETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_SOSPECHOSOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents DS_SOSPECHOSOS As SistemaControlProduccion.DS_SOSPECHOSOS
    Friend WithEvents ENTSALDETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ENTSAL_DETTableAdapter As SistemaControlProduccion.DS_SOSPECHOSOSTableAdapters.ENTSAL_DETTableAdapter
    Friend WithEvents IDESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACMAYORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECUTIVODIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECUTIVOLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOSPECHOSODataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
