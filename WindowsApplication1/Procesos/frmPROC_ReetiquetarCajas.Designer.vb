<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_ReetiquetarCajas
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.txtNomProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPiezas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnImprimir2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstID = New System.Windows.Forms.ListBox()
        Me.btnPegar = New System.Windows.Forms.Button()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLoteNuevo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkExportacion = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSM = New System.Windows.Forms.TextBox()
        Me.txtIndicaciones = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CHKALSUPER = New System.Windows.Forms.CheckBox()
        Me.DsCajas = New SistemaControlProduccion.dsCajas()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(825, 22)
        Me.StatusStrip1.TabIndex = 37
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "F2|Nuevo"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(185, 17)
        Me.ToolStripStatusLabel4.Text = "F9|Imprimir etiqueta seleccionada"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(174, 17)
        Me.ToolStripStatusLabel5.Text = "F11|Imprimir todas las etiquetas"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(389, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "ID's"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodProd
        '
        Me.txtCodProd.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(498, 51)
        Me.txtCodProd.MaxLength = 40
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(106, 26)
        Me.txtCodProd.TabIndex = 48
        Me.txtCodProd.TabStop = False
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNomProd
        '
        Me.txtNomProd.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProd.Location = New System.Drawing.Point(498, 83)
        Me.txtNomProd.MaxLength = 40
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.ReadOnly = True
        Me.txtNomProd.Size = New System.Drawing.Size(311, 26)
        Me.txtNomProd.TabIndex = 49
        Me.txtNomProd.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(389, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Piezas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPiezas
        '
        Me.txtPiezas.BackColor = System.Drawing.SystemColors.Window
        Me.txtPiezas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiezas.Location = New System.Drawing.Point(498, 115)
        Me.txtPiezas.MaxLength = 40
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.ReadOnly = True
        Me.txtPiezas.Size = New System.Drawing.Size(106, 26)
        Me.txtPiezas.TabIndex = 51
        Me.txtPiezas.TabStop = False
        Me.txtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(389, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Peso"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(498, 147)
        Me.txtPeso.MaxLength = 40
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.Size = New System.Drawing.Size(106, 26)
        Me.txtPeso.TabIndex = 53
        Me.txtPeso.TabStop = False
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.Window
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(498, 179)
        Me.txtFecha.MaxLength = 40
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(106, 26)
        Me.txtFecha.TabIndex = 55
        Me.txtFecha.TabStop = False
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(389, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Fecha"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(389, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(498, 243)
        Me.txtID.MaxLength = 40
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(106, 26)
        Me.txtID.TabIndex = 59
        Me.txtID.TabStop = False
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(550, 330)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(124, 26)
        Me.dtpFecha.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(441, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 23)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Fecha"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnImprimir2
        '
        Me.btnImprimir2.FlatAppearance.BorderSize = 0
        Me.btnImprimir2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir2.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir2.Location = New System.Drawing.Point(741, 536)
        Me.btnImprimir2.Name = "btnImprimir2"
        Me.btnImprimir2.Size = New System.Drawing.Size(72, 63)
        Me.btnImprimir2.TabIndex = 90
        Me.btnImprimir2.Text = "&Todas"
        Me.btnImprimir2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaControlProduccion.My.Resources.Resources.print_printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(663, 536)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 63)
        Me.btnImprimir.TabIndex = 89
        Me.btnImprimir.Text = "&Individual"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(377, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(432, 23)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Caja seleccionada"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(376, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(437, 23)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Actualizar datos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstID
        '
        Me.lstID.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstID.FormattingEnabled = True
        Me.lstID.ItemHeight = 18
        Me.lstID.Items.AddRange(New Object() {""})
        Me.lstID.Location = New System.Drawing.Point(12, 37)
        Me.lstID.Name = "lstID"
        Me.lstID.Size = New System.Drawing.Size(358, 544)
        Me.lstID.TabIndex = 0
        '
        'btnPegar
        '
        Me.btnPegar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPegar.Location = New System.Drawing.Point(12, 587)
        Me.btnPegar.Name = "btnPegar"
        Me.btnPegar.Size = New System.Drawing.Size(358, 23)
        Me.btnPegar.TabIndex = 5
        Me.btnPegar.Text = "Pegar desde el Portapapeles"
        Me.btnPegar.UseVisualStyleBackColor = True
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(498, 211)
        Me.txtLote.MaxLength = 40
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(106, 26)
        Me.txtLote.TabIndex = 57
        Me.txtLote.TabStop = False
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(389, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 23)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Lote"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLoteNuevo
        '
        Me.txtLoteNuevo.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoteNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteNuevo.Location = New System.Drawing.Point(550, 362)
        Me.txtLoteNuevo.MaxLength = 6
        Me.txtLoteNuevo.Name = "txtLoteNuevo"
        Me.txtLoteNuevo.Size = New System.Drawing.Size(124, 26)
        Me.txtLoteNuevo.TabIndex = 84
        Me.txtLoteNuevo.TabStop = False
        Me.txtLoteNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(441, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 23)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Lote"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkExportacion
        '
        Me.chkExportacion.AutoSize = True
        Me.chkExportacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExportacion.Location = New System.Drawing.Point(445, 410)
        Me.chkExportacion.Name = "chkExportacion"
        Me.chkExportacion.Size = New System.Drawing.Size(177, 21)
        Me.chkExportacion.TabIndex = 92
        Me.chkExportacion.Text = "Etiqueta Exportación"
        Me.chkExportacion.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(399, 451)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 22)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Shipping Mark"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSM
        '
        Me.txtSM.BackColor = System.Drawing.SystemColors.Window
        Me.txtSM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSM.Location = New System.Drawing.Point(550, 450)
        Me.txtSM.MaxLength = 12
        Me.txtSM.Name = "txtSM"
        Me.txtSM.Size = New System.Drawing.Size(124, 26)
        Me.txtSM.TabIndex = 94
        Me.txtSM.TabStop = False
        '
        'txtIndicaciones
        '
        Me.txtIndicaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtIndicaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIndicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndicaciones.Location = New System.Drawing.Point(550, 482)
        Me.txtIndicaciones.MaxLength = 30
        Me.txtIndicaciones.Name = "txtIndicaciones"
        Me.txtIndicaciones.Size = New System.Drawing.Size(259, 26)
        Me.txtIndicaciones.TabIndex = 95
        Me.txtIndicaciones.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(416, 486)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 22)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Indicaciones"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CHKALSUPER
        '
        Me.CHKALSUPER.AutoSize = True
        Me.CHKALSUPER.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKALSUPER.Location = New System.Drawing.Point(628, 410)
        Me.CHKALSUPER.Name = "CHKALSUPER"
        Me.CHKALSUPER.Size = New System.Drawing.Size(82, 21)
        Me.CHKALSUPER.TabIndex = 97
        Me.CHKALSUPER.Text = "Alsuper"
        Me.CHKALSUPER.UseVisualStyleBackColor = True
        '
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmPROC_ReetiquetarCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(825, 639)
        Me.Controls.Add(Me.CHKALSUPER)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIndicaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSM)
        Me.Controls.Add(Me.chkExportacion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLoteNuevo)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPegar)
        Me.Controls.Add(Me.lstID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnImprimir2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomProd)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPROC_ReetiquetarCajas"
        Me.ShowInTaskbar = False
        Me.Text = "Cambios"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents txtNomProd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir2 As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstID As System.Windows.Forms.ListBox
    Friend WithEvents btnPegar As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLoteNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkExportacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSM As System.Windows.Forms.TextBox
    Friend WithEvents txtIndicaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CHKALSUPER As System.Windows.Forms.CheckBox
    Friend WithEvents DsCajas As SistemaControlProduccion.dsCajas
End Class
