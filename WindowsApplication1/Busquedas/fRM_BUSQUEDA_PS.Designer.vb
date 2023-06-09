<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRM_BUSQUEDA_PS
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMORIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MACHOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HEMBRASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPECIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BMIXTODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BHEMBRASDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BMACHOSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SACRIFICIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROG_SACRI = New SistemaControlProduccion.DS_PROG_SACRI()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SACRIFICIOTableAdapter = New SistemaControlProduccion.DS_PROG_SACRITableAdapters.SACRIFICIOTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SACRIFICIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROG_SACRI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(110, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(449, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FILTRO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHADataGridViewTextBoxColumn, Me.SACLOTEDataGridViewTextBoxColumn, Me.NOMORIGENDataGridViewTextBoxColumn, Me.NOMDESTDataGridViewTextBoxColumn, Me.CANTIDADDataGridViewTextBoxColumn, Me.MACHOSDataGridViewTextBoxColumn, Me.HEMBRASDataGridViewTextBoxColumn, Me.ESPECIEDataGridViewTextBoxColumn, Me.BMIXTODataGridViewCheckBoxColumn, Me.BHEMBRASDataGridViewCheckBoxColumn, Me.BMACHOSDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.SACRIFICIOBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(640, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'FECHADataGridViewTextBoxColumn
        '
        Me.FECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECHADataGridViewTextBoxColumn.Name = "FECHADataGridViewTextBoxColumn"
        Me.FECHADataGridViewTextBoxColumn.ReadOnly = True
        '
        'SACLOTEDataGridViewTextBoxColumn
        '
        Me.SACLOTEDataGridViewTextBoxColumn.DataPropertyName = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.HeaderText = "LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.Name = "SACLOTEDataGridViewTextBoxColumn"
        Me.SACLOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMORIGENDataGridViewTextBoxColumn
        '
        Me.NOMORIGENDataGridViewTextBoxColumn.DataPropertyName = "NOM_ORIGEN"
        Me.NOMORIGENDataGridViewTextBoxColumn.HeaderText = "NOM_ORIGEN"
        Me.NOMORIGENDataGridViewTextBoxColumn.Name = "NOMORIGENDataGridViewTextBoxColumn"
        Me.NOMORIGENDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMDESTDataGridViewTextBoxColumn
        '
        Me.NOMDESTDataGridViewTextBoxColumn.DataPropertyName = "NOM_DEST"
        Me.NOMDESTDataGridViewTextBoxColumn.HeaderText = "NOM_DEST"
        Me.NOMDESTDataGridViewTextBoxColumn.Name = "NOMDESTDataGridViewTextBoxColumn"
        Me.NOMDESTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        Me.CANTIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MACHOSDataGridViewTextBoxColumn
        '
        Me.MACHOSDataGridViewTextBoxColumn.DataPropertyName = "MACHOS"
        Me.MACHOSDataGridViewTextBoxColumn.HeaderText = "MACHOS"
        Me.MACHOSDataGridViewTextBoxColumn.Name = "MACHOSDataGridViewTextBoxColumn"
        Me.MACHOSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HEMBRASDataGridViewTextBoxColumn
        '
        Me.HEMBRASDataGridViewTextBoxColumn.DataPropertyName = "HEMBRAS"
        Me.HEMBRASDataGridViewTextBoxColumn.HeaderText = "HEMBRAS"
        Me.HEMBRASDataGridViewTextBoxColumn.Name = "HEMBRASDataGridViewTextBoxColumn"
        Me.HEMBRASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESPECIEDataGridViewTextBoxColumn
        '
        Me.ESPECIEDataGridViewTextBoxColumn.DataPropertyName = "ESPECIE"
        Me.ESPECIEDataGridViewTextBoxColumn.HeaderText = "ESPECIE"
        Me.ESPECIEDataGridViewTextBoxColumn.Name = "ESPECIEDataGridViewTextBoxColumn"
        Me.ESPECIEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BMIXTODataGridViewCheckBoxColumn
        '
        Me.BMIXTODataGridViewCheckBoxColumn.DataPropertyName = "BMIXTO"
        Me.BMIXTODataGridViewCheckBoxColumn.HeaderText = "BMIXTO"
        Me.BMIXTODataGridViewCheckBoxColumn.Name = "BMIXTODataGridViewCheckBoxColumn"
        Me.BMIXTODataGridViewCheckBoxColumn.ReadOnly = True
        '
        'BHEMBRASDataGridViewCheckBoxColumn
        '
        Me.BHEMBRASDataGridViewCheckBoxColumn.DataPropertyName = "BHEMBRAS"
        Me.BHEMBRASDataGridViewCheckBoxColumn.HeaderText = "BHEMBRAS"
        Me.BHEMBRASDataGridViewCheckBoxColumn.Name = "BHEMBRASDataGridViewCheckBoxColumn"
        Me.BHEMBRASDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'BMACHOSDataGridViewCheckBoxColumn
        '
        Me.BMACHOSDataGridViewCheckBoxColumn.DataPropertyName = "BMACHOS"
        Me.BMACHOSDataGridViewCheckBoxColumn.HeaderText = "BMACHOS"
        Me.BMACHOSDataGridViewCheckBoxColumn.Name = "BMACHOSDataGridViewCheckBoxColumn"
        Me.BMACHOSDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SACRIFICIOBindingSource
        '
        Me.SACRIFICIOBindingSource.DataMember = "SACRIFICIO"
        Me.SACRIFICIOBindingSource.DataSource = Me.DS_PROG_SACRI
        '
        'DS_PROG_SACRI
        '
        Me.DS_PROG_SACRI.DataSetName = "DS_PROG_SACRI"
        Me.DS_PROG_SACRI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(488, 226)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 3
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(578, 226)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'SACRIFICIOTableAdapter
        '
        Me.SACRIFICIOTableAdapter.ClearBeforeFill = True
        '
        'fRM_BUSQUEDA_PS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(676, 261)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "fRM_BUSQUEDA_PS"
        Me.Text = "fRM_BUSQUEDA_PS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SACRIFICIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROG_SACRI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents SACRIFICIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_PROG_SACRI As SistemaControlProduccion.DS_PROG_SACRI
    Friend WithEvents SACRIFICIOTableAdapter As SistemaControlProduccion.DS_PROG_SACRITableAdapters.SACRIFICIOTableAdapter
    Friend WithEvents FECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMORIGENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MACHOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HEMBRASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESPECIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BMIXTODataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BHEMBRASDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BMACHOSDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
