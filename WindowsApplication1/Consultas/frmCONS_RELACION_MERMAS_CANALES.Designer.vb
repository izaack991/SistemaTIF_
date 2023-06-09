<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONS_RELACION_MERMAS_CANALES
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.SPRELACIONDEMERMASCANALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RELACION_DE_MERMAS_CANALESTableAdapter = New SistemaControlProduccion.dsSacrificioTableAdapters.SP_RELACION_DE_MERMAS_CANALESTableAdapter()
        Me.FoliosalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEORIGINALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaentradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiascuartoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASFRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOCALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOPIELESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MERMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPRELACIONDEMERMASCANALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.btnImprimir)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.dtpFechaFin)
        Me.Panel8.Controls.Add(Me.btnActualizar)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaIni)
        Me.Panel8.Location = New System.Drawing.Point(12, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(960, 81)
        Me.Panel8.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(642, 13)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 53)
        Me.btnImprimir.TabIndex = 86
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        Me.Label13.Location = New System.Drawing.Point(10, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(964, 84)
        Me.Label13.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(963, 398)
        Me.Label4.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoliosalidaDataGridViewTextBoxColumn, Me.SACLOTEORIGINALDataGridViewTextBoxColumn, Me.FechaentradaDataGridViewTextBoxColumn, Me.FechasalidaDataGridViewTextBoxColumn, Me.DiascuartoDataGridViewTextBoxColumn, Me.MARCADataGridViewTextBoxColumn, Me.PIEZASFRDataGridViewTextBoxColumn, Me.PESOCALDataGridViewTextBoxColumn, Me.PESOFRIODataGridViewTextBoxColumn, Me.PESOPIELESDataGridViewTextBoxColumn, Me.MERMADataGridViewTextBoxColumn, Me.SEXODataGridViewTextBoxColumn, Me.OBSERVACIONESDataGridViewTextBoxColumn, Me.SALADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SPRELACIONDEMERMASCANALESBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(954, 392)
        Me.DataGridView1.TabIndex = 33
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPRELACIONDEMERMASCANALESBindingSource
        '
        Me.SPRELACIONDEMERMASCANALESBindingSource.DataMember = "SP_RELACION_DE_MERMAS_CANALES"
        Me.SPRELACIONDEMERMASCANALESBindingSource.DataSource = Me.DsSacrificio
        '
        'SP_RELACION_DE_MERMAS_CANALESTableAdapter
        '
        Me.SP_RELACION_DE_MERMAS_CANALESTableAdapter.ClearBeforeFill = True
        '
        'FoliosalidaDataGridViewTextBoxColumn
        '
        Me.FoliosalidaDataGridViewTextBoxColumn.DataPropertyName = "folio_salida"
        Me.FoliosalidaDataGridViewTextBoxColumn.HeaderText = "folio_salida"
        Me.FoliosalidaDataGridViewTextBoxColumn.Name = "FoliosalidaDataGridViewTextBoxColumn"
        Me.FoliosalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SACLOTEORIGINALDataGridViewTextBoxColumn
        '
        Me.SACLOTEORIGINALDataGridViewTextBoxColumn.DataPropertyName = "SAC_LOTE_ORIGINAL"
        Me.SACLOTEORIGINALDataGridViewTextBoxColumn.HeaderText = "SAC_LOTE_ORIGINAL"
        Me.SACLOTEORIGINALDataGridViewTextBoxColumn.Name = "SACLOTEORIGINALDataGridViewTextBoxColumn"
        Me.SACLOTEORIGINALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaentradaDataGridViewTextBoxColumn
        '
        Me.FechaentradaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrada"
        Me.FechaentradaDataGridViewTextBoxColumn.HeaderText = "fecha_entrada"
        Me.FechaentradaDataGridViewTextBoxColumn.Name = "FechaentradaDataGridViewTextBoxColumn"
        Me.FechaentradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechasalidaDataGridViewTextBoxColumn
        '
        Me.FechasalidaDataGridViewTextBoxColumn.DataPropertyName = "fecha_salida"
        Me.FechasalidaDataGridViewTextBoxColumn.HeaderText = "fecha_salida"
        Me.FechasalidaDataGridViewTextBoxColumn.Name = "FechasalidaDataGridViewTextBoxColumn"
        Me.FechasalidaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiascuartoDataGridViewTextBoxColumn
        '
        Me.DiascuartoDataGridViewTextBoxColumn.DataPropertyName = "dias_cuarto"
        Me.DiascuartoDataGridViewTextBoxColumn.HeaderText = "dias_cuarto"
        Me.DiascuartoDataGridViewTextBoxColumn.Name = "DiascuartoDataGridViewTextBoxColumn"
        Me.DiascuartoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MARCADataGridViewTextBoxColumn
        '
        Me.MARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.Name = "MARCADataGridViewTextBoxColumn"
        Me.MARCADataGridViewTextBoxColumn.ReadOnly = True
        '
        'PIEZASFRDataGridViewTextBoxColumn
        '
        Me.PIEZASFRDataGridViewTextBoxColumn.DataPropertyName = "PIEZAS_FR"
        Me.PIEZASFRDataGridViewTextBoxColumn.HeaderText = "PIEZAS_FR"
        Me.PIEZASFRDataGridViewTextBoxColumn.Name = "PIEZASFRDataGridViewTextBoxColumn"
        Me.PIEZASFRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESOCALDataGridViewTextBoxColumn
        '
        Me.PESOCALDataGridViewTextBoxColumn.DataPropertyName = "PESO_CAL"
        Me.PESOCALDataGridViewTextBoxColumn.HeaderText = "PESO_CAL"
        Me.PESOCALDataGridViewTextBoxColumn.Name = "PESOCALDataGridViewTextBoxColumn"
        Me.PESOCALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESOFRIODataGridViewTextBoxColumn
        '
        Me.PESOFRIODataGridViewTextBoxColumn.DataPropertyName = "PESO_FRIO"
        Me.PESOFRIODataGridViewTextBoxColumn.HeaderText = "PESO_FRIO"
        Me.PESOFRIODataGridViewTextBoxColumn.Name = "PESOFRIODataGridViewTextBoxColumn"
        Me.PESOFRIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PESOPIELESDataGridViewTextBoxColumn
        '
        Me.PESOPIELESDataGridViewTextBoxColumn.DataPropertyName = "PESO_PIELES"
        Me.PESOPIELESDataGridViewTextBoxColumn.HeaderText = "PESO_PIELES"
        Me.PESOPIELESDataGridViewTextBoxColumn.Name = "PESOPIELESDataGridViewTextBoxColumn"
        Me.PESOPIELESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MERMADataGridViewTextBoxColumn
        '
        Me.MERMADataGridViewTextBoxColumn.DataPropertyName = "MERMA"
        Me.MERMADataGridViewTextBoxColumn.HeaderText = "MERMA"
        Me.MERMADataGridViewTextBoxColumn.Name = "MERMADataGridViewTextBoxColumn"
        Me.MERMADataGridViewTextBoxColumn.ReadOnly = True
        '
        'SEXODataGridViewTextBoxColumn
        '
        Me.SEXODataGridViewTextBoxColumn.DataPropertyName = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.HeaderText = "SEXO"
        Me.SEXODataGridViewTextBoxColumn.Name = "SEXODataGridViewTextBoxColumn"
        Me.SEXODataGridViewTextBoxColumn.ReadOnly = True
        '
        'OBSERVACIONESDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.Name = "OBSERVACIONESDataGridViewTextBoxColumn"
        Me.OBSERVACIONESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALADataGridViewTextBoxColumn
        '
        Me.SALADataGridViewTextBoxColumn.DataPropertyName = "SALA"
        Me.SALADataGridViewTextBoxColumn.HeaderText = "SALA"
        Me.SALADataGridViewTextBoxColumn.Name = "SALADataGridViewTextBoxColumn"
        Me.SALADataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCONS_RELACION_MERMAS_CANALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 503)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.Name = "frmCONS_RELACION_MERMAS_CANALES"
        Me.Text = "frmCONS_RELACION_MERMAS_CANALES"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPRELACIONDEMERMASCANALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FoliosalidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEORIGINALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaentradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechasalidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiascuartoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASFRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOCALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOPIELESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MERMADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SPRELACIONDEMERMASCANALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents SP_RELACION_DE_MERMAS_CANALESTableAdapter As SistemaControlProduccion.dsSacrificioTableAdapters.SP_RELACION_DE_MERMAS_CANALESTableAdapter
End Class
