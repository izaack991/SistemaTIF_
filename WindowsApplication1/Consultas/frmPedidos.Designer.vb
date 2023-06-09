<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DsCajas = New SistemaControlProduccion.dsCajas()
        Me.DsCajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SppedidosconsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_pedidos_consultaTableAdapter = New SistemaControlProduccion.dsCajasTableAdapters.sp_pedidos_consultaTableAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SppedidosconsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(36, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Fecha:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(116, 26)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(124, 26)
        Me.dtpFechaIni.TabIndex = 6
        '
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsCajasBindingSource
        '
        Me.DsCajasBindingSource.DataSource = Me.DsCajas
        Me.DsCajasBindingSource.Position = 0
        '
        'SppedidosconsultaBindingSource
        '
        Me.SppedidosconsultaBindingSource.DataMember = "sp_pedidos_consulta"
        Me.SppedidosconsultaBindingSource.DataSource = Me.DsCajasBindingSource
        '
        'Sp_pedidos_consultaTableAdapter
        '
        Me.Sp_pedidos_consultaTableAdapter.ClearBeforeFill = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(267, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(71, 53)
        Me.btnImprimir.TabIndex = 87
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 97)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "frmPedidos"
        Me.Text = "frmPedidos"
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SppedidosconsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsCajas As SistemaControlProduccion.dsCajas
    Friend WithEvents DsCajasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SppedidosconsultaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_pedidos_consultaTableAdapter As SistemaControlProduccion.dsCajasTableAdapters.sp_pedidos_consultaTableAdapter
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
