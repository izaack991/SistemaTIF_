<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_Mermagrasahueso
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
        Me.LOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PORCENTAJEGRASADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PORCENTAJECARNEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPESOHUESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPESOCARNEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALGRASADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALCARNESGRASADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALGRASASCARNEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPCONSMERMAGHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPCONSMERMAGHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LOTEDataGridViewTextBoxColumn, Me.FECHADataGridViewTextBoxColumn, Me.MARCADataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.PORCENTAJEGRASADataGridViewTextBoxColumn, Me.PORCENTAJECARNEDataGridViewTextBoxColumn, Me.TOTALPESOHUESODataGridViewTextBoxColumn, Me.TOTALPESOCARNEDataGridViewTextBoxColumn, Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn, Me.TOTALGRASADataGridViewTextBoxColumn, Me.TOTALCARNESGRASADataGridViewTextBoxColumn, Me.TOTALGRASASCARNEDataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SPCONSMERMAGHBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(954, 392)
        Me.DataGridView1.TabIndex = 41
        '
        'LOTEDataGridViewTextBoxColumn
        '
        Me.LOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.LOTEDataGridViewTextBoxColumn.Name = "LOTEDataGridViewTextBoxColumn"
        Me.LOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
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
        Me.NOMBREDataGridViewTextBoxColumn.Width = 200
        '
        'PORCENTAJEGRASADataGridViewTextBoxColumn
        '
        Me.PORCENTAJEGRASADataGridViewTextBoxColumn.DataPropertyName = "PORCENTAJEGRASA"
        Me.PORCENTAJEGRASADataGridViewTextBoxColumn.HeaderText = " %CARNE/G"
        Me.PORCENTAJEGRASADataGridViewTextBoxColumn.Name = "PORCENTAJEGRASADataGridViewTextBoxColumn"
        Me.PORCENTAJEGRASADataGridViewTextBoxColumn.ReadOnly = True
        '
        'PORCENTAJECARNEDataGridViewTextBoxColumn
        '
        Me.PORCENTAJECARNEDataGridViewTextBoxColumn.DataPropertyName = "PORCENTAJECARNE"
        Me.PORCENTAJECARNEDataGridViewTextBoxColumn.HeaderText = "%CARNE/H"
        Me.PORCENTAJECARNEDataGridViewTextBoxColumn.Name = "PORCENTAJECARNEDataGridViewTextBoxColumn"
        Me.PORCENTAJECARNEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALPESOHUESODataGridViewTextBoxColumn
        '
        Me.TOTALPESOHUESODataGridViewTextBoxColumn.DataPropertyName = "TOTALPESOHUESO"
        Me.TOTALPESOHUESODataGridViewTextBoxColumn.HeaderText = "TOTALPESOHUESO"
        Me.TOTALPESOHUESODataGridViewTextBoxColumn.Name = "TOTALPESOHUESODataGridViewTextBoxColumn"
        Me.TOTALPESOHUESODataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALPESOHUESODataGridViewTextBoxColumn.Width = 150
        '
        'TOTALPESOCARNEDataGridViewTextBoxColumn
        '
        Me.TOTALPESOCARNEDataGridViewTextBoxColumn.DataPropertyName = "TOTALPESOCARNE"
        Me.TOTALPESOCARNEDataGridViewTextBoxColumn.HeaderText = "TOTALPESOCARNE"
        Me.TOTALPESOCARNEDataGridViewTextBoxColumn.Name = "TOTALPESOCARNEDataGridViewTextBoxColumn"
        Me.TOTALPESOCARNEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALPESOCARNEDataGridViewTextBoxColumn.Width = 150
        '
        'TOTALPESOSINCARNEDataGridViewTextBoxColumn
        '
        Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn.DataPropertyName = "TOTALPESOSINCARNE"
        Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn.HeaderText = "TOTALPESOSINCARNE"
        Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn.Name = "TOTALPESOSINCARNEDataGridViewTextBoxColumn"
        Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALPESOSINCARNEDataGridViewTextBoxColumn.Width = 150
        '
        'TOTALGRASADataGridViewTextBoxColumn
        '
        Me.TOTALGRASADataGridViewTextBoxColumn.DataPropertyName = "TOTALGRASA"
        Me.TOTALGRASADataGridViewTextBoxColumn.HeaderText = "TOTALGRASA"
        Me.TOTALGRASADataGridViewTextBoxColumn.Name = "TOTALGRASADataGridViewTextBoxColumn"
        Me.TOTALGRASADataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALGRASADataGridViewTextBoxColumn.Width = 150
        '
        'TOTALCARNESGRASADataGridViewTextBoxColumn
        '
        Me.TOTALCARNESGRASADataGridViewTextBoxColumn.DataPropertyName = "TOTALCARNESGRASA"
        Me.TOTALCARNESGRASADataGridViewTextBoxColumn.HeaderText = "TOTALCARNESGRASA"
        Me.TOTALCARNESGRASADataGridViewTextBoxColumn.Name = "TOTALCARNESGRASADataGridViewTextBoxColumn"
        Me.TOTALCARNESGRASADataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALCARNESGRASADataGridViewTextBoxColumn.Width = 150
        '
        'TOTALGRASASCARNEDataGridViewTextBoxColumn
        '
        Me.TOTALGRASASCARNEDataGridViewTextBoxColumn.DataPropertyName = "TOTALGRASASCARNE"
        Me.TOTALGRASASCARNEDataGridViewTextBoxColumn.HeaderText = "TOTALGRASASCARNE"
        Me.TOTALGRASASCARNEDataGridViewTextBoxColumn.Name = "TOTALGRASASCARNEDataGridViewTextBoxColumn"
        Me.TOTALGRASASCARNEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALGRASASCARNEDataGridViewTextBoxColumn.Width = 150
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Width = 200
        '
        'SPCONSMERMAGHBindingSource
        '
        Me.SPCONSMERMAGHBindingSource.DataMember = "SP_CONS_MERMAGH"
        Me.SPCONSMERMAGHBindingSource.DataSource = Me.DsSacrificio
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(963, 398)
        Me.Label4.TabIndex = 40
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.dtpFechaFin)
        Me.Panel8.Controls.Add(Me.btnActualizar)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaIni)
        Me.Panel8.Location = New System.Drawing.Point(11, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(960, 81)
        Me.Panel8.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(642, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Label13.Location = New System.Drawing.Point(9, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(964, 84)
        Me.Label13.TabIndex = 39
        '
        'frmCONS_Mermagrasahueso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 488)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.Name = "frmCONS_Mermagrasahueso"
        Me.Text = "frmCONS_Mermagrasahueso"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPCONSMERMAGHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PORCENTAJEGRASADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PORCENTAJECARNEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPESOHUESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPESOCARNEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALPESOSINCARNEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALGRASADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALCARNESGRASADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALGRASASCARNEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SPCONSMERMAGHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
End Class
