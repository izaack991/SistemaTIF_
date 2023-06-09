<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REV_CALIDAD
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DsSacrificio1 = New SistemaControlProduccion.dsSacrificio()
        Me.SPREVCALIDADBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HORADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECUTIVODIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.DsSacrificio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPREVCALIDADBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HORADataGridViewTextBoxColumn, Me.MARCADataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.SACIDDataGridViewTextBoxColumn, Me.CONSECUTIVODIADataGridViewTextBoxColumn, Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn, Me.LOTEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SPREVCALIDADBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(11, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(954, 392)
        Me.DataGridView1.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(963, 398)
        Me.Label4.TabIndex = 36
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.dtpFechaFin)
        Me.Panel8.Controls.Add(Me.btnActualizar)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaIni)
        Me.Panel8.Location = New System.Drawing.Point(9, 7)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(960, 81)
        Me.Panel8.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(292, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(415, 26)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaFin.TabIndex = 6
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.SistemaControlProduccion.My.Resources.Resources.reload_page
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.Location = New System.Drawing.Point(561, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 54)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(16, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha Inicial"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(148, 27)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaIni.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(964, 84)
        Me.Label13.TabIndex = 35
        '
        'DsSacrificio1
        '
        Me.DsSacrificio1.DataSetName = "dsSacrificio"
        Me.DsSacrificio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPREVCALIDADBindingSource1
        '
        Me.SPREVCALIDADBindingSource1.DataMember = "SP_REV_CALIDAD"
        Me.SPREVCALIDADBindingSource1.DataSource = Me.DsSacrificio1
        '
        'HORADataGridViewTextBoxColumn
        '
        Me.HORADataGridViewTextBoxColumn.DataPropertyName = "HORA"
        Me.HORADataGridViewTextBoxColumn.HeaderText = "HORA"
        Me.HORADataGridViewTextBoxColumn.Name = "HORADataGridViewTextBoxColumn"
        Me.HORADataGridViewTextBoxColumn.ReadOnly = True
        '
        'MARCADataGridViewTextBoxColumn
        '
        Me.MARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.Name = "MARCADataGridViewTextBoxColumn"
        Me.MARCADataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SACIDDataGridViewTextBoxColumn
        '
        Me.SACIDDataGridViewTextBoxColumn.DataPropertyName = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.HeaderText = "ID_CANAL"
        Me.SACIDDataGridViewTextBoxColumn.Name = "SACIDDataGridViewTextBoxColumn"
        Me.SACIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONSECUTIVODIADataGridViewTextBoxColumn
        '
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.DataPropertyName = "CONSECUTIVO_DIA"
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.HeaderText = "CONSECUTIVO_DIA"
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.Name = "CONSECUTIVODIADataGridViewTextBoxColumn"
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSECUTIVODIADataGridViewTextBoxColumn.Width = 150
        '
        'CONSECUTIVOLOTEDataGridViewTextBoxColumn
        '
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.DataPropertyName = "CONSECUTIVO_LOTE"
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.HeaderText = "CONSECUTIVO_LOTE"
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.Name = "CONSECUTIVOLOTEDataGridViewTextBoxColumn"
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSECUTIVOLOTEDataGridViewTextBoxColumn.Width = 150
        '
        'LOTEDataGridViewTextBoxColumn
        '
        Me.LOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.Name = "LOTEDataGridViewTextBoxColumn"
        Me.LOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRM_REV_CALIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 502)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.Name = "FRM_REV_CALIDAD"
        Me.Text = "FRM_REV_CALIDAD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DsSacrificio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPREVCALIDADBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SPREVCALIDADBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsSacrificio1 As SistemaControlProduccion.dsSacrificio
    Friend WithEvents HORADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECUTIVODIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSECUTIVOLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
