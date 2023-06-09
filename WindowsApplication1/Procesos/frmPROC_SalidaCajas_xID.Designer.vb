<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPROC_SalidaCajas_xID
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNomMovto = New System.Windows.Forms.TextBox()
        Me.txtIdMovto = New System.Windows.Forms.TextBox()
        Me.lblProductor = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.txtNomIntroductor = New System.Windows.Forms.TextBox()
        Me.lblIntr = New System.Windows.Forms.Label()
        Me.txtNomDestino = New System.Windows.Forms.TextBox()
        Me.txtMarcaIntroductor = New System.Windows.Forms.TextBox()
        Me.txtMarcaDestino = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCanalesSalida = New System.Windows.Forms.Label()
        Me.lblCajasDisponibles = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCodBar = New System.Windows.Forms.Label()
        Me.btnCodBar = New System.Windows.Forms.Button()
        Me.txtCodBar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DsMovimientos = New SistemaControlProduccion.dsMovimientos()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.ID_EST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESD_TMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMOVDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEPRODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEINTRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEINTRDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEINTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEDESTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEDETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEDETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMPRODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACLADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACSEXODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACMAYORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACVACIADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SACENMANTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIELARETECAMPANADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIELARETESAGARPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DECOMISODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUSESDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDALMDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMALMDESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCTEDESTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCACTEDESTDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCTEDESTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESOFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARAFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONESFRIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPRODCTEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIEZASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORLOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASERIEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASERIEIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAESDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORAESDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJACODBARDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsSacrificio = New SistemaControlProduccion.dsSacrificio()
        Me.DsCajas = New SistemaControlProduccion.dsCajas()
        Me.lstID = New System.Windows.Forms.ListBox()
        Me.btnPegar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnPesar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DsMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomMovto
        '
        Me.txtNomMovto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomMovto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomMovto.Location = New System.Drawing.Point(116, 40)
        Me.txtNomMovto.MaxLength = 40
        Me.txtNomMovto.Name = "txtNomMovto"
        Me.txtNomMovto.ReadOnly = True
        Me.txtNomMovto.Size = New System.Drawing.Size(336, 26)
        Me.txtNomMovto.TabIndex = 4
        Me.txtNomMovto.TabStop = False
        '
        'txtIdMovto
        '
        Me.txtIdMovto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdMovto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMovto.Location = New System.Drawing.Point(116, 8)
        Me.txtIdMovto.MaxLength = 6
        Me.txtIdMovto.Name = "txtIdMovto"
        Me.txtIdMovto.ReadOnly = True
        Me.txtIdMovto.Size = New System.Drawing.Size(76, 26)
        Me.txtIdMovto.TabIndex = 2
        Me.txtIdMovto.TabStop = False
        Me.txtIdMovto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdMovto.Visible = False
        '
        'lblProductor
        '
        Me.lblProductor.AutoSize = True
        Me.lblProductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductor.Location = New System.Drawing.Point(11, 43)
        Me.lblProductor.Name = "lblProductor"
        Me.lblProductor.Size = New System.Drawing.Size(99, 20)
        Me.lblProductor.TabIndex = 1
        Me.lblProductor.Text = "Movimiento"
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(37, 68)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(68, 19)
        Me.lblDestino.TabIndex = 3
        Me.lblDestino.Text = "Destino"
        '
        'txtNomIntroductor
        '
        Me.txtNomIntroductor.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomIntroductor.Enabled = False
        Me.txtNomIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomIntroductor.Location = New System.Drawing.Point(193, 33)
        Me.txtNomIntroductor.MaxLength = 6
        Me.txtNomIntroductor.Name = "txtNomIntroductor"
        Me.txtNomIntroductor.Size = New System.Drawing.Size(340, 26)
        Me.txtNomIntroductor.TabIndex = 2
        '
        'lblIntr
        '
        Me.lblIntr.AutoSize = True
        Me.lblIntr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntr.Location = New System.Drawing.Point(11, 36)
        Me.lblIntr.Name = "lblIntr"
        Me.lblIntr.Size = New System.Drawing.Size(94, 19)
        Me.lblIntr.TabIndex = 0
        Me.lblIntr.Text = "Introductor"
        '
        'txtNomDestino
        '
        Me.txtNomDestino.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNomDestino.Enabled = False
        Me.txtNomDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomDestino.Location = New System.Drawing.Point(193, 65)
        Me.txtNomDestino.MaxLength = 6
        Me.txtNomDestino.Name = "txtNomDestino"
        Me.txtNomDestino.Size = New System.Drawing.Size(340, 26)
        Me.txtNomDestino.TabIndex = 5
        '
        'txtMarcaIntroductor
        '
        Me.txtMarcaIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIntroductor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIntroductor.Location = New System.Drawing.Point(111, 33)
        Me.txtMarcaIntroductor.MaxLength = 6
        Me.txtMarcaIntroductor.Name = "txtMarcaIntroductor"
        Me.txtMarcaIntroductor.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaIntroductor.TabIndex = 1
        Me.txtMarcaIntroductor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaDestino
        '
        Me.txtMarcaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaDestino.Location = New System.Drawing.Point(111, 65)
        Me.txtMarcaDestino.MaxLength = 6
        Me.txtMarcaDestino.Name = "txtMarcaDestino"
        Me.txtMarcaDestino.Size = New System.Drawing.Size(76, 26)
        Me.txtMarcaDestino.TabIndex = 4
        Me.txtMarcaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.dtpFechaMov)
        Me.Panel8.Controls.Add(Me.txtIdMovto)
        Me.Panel8.Controls.Add(Me.lblProductor)
        Me.Panel8.Controls.Add(Me.txtNomMovto)
        Me.Panel8.Location = New System.Drawing.Point(12, 12)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(590, 95)
        Me.Panel8.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(-2, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(590, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Movimiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaMov
        '
        Me.dtpFechaMov.Enabled = False
        Me.dtpFechaMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMov.Location = New System.Drawing.Point(458, 40)
        Me.dtpFechaMov.Name = "dtpFechaMov"
        Me.dtpFechaMov.Size = New System.Drawing.Size(113, 26)
        Me.dtpFechaMov.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(593, 97)
        Me.Label13.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNomIntroductor)
        Me.Panel2.Controls.Add(Me.txtMarcaDestino)
        Me.Panel2.Controls.Add(Me.txtMarcaIntroductor)
        Me.Panel2.Controls.Add(Me.lblDestino)
        Me.Panel2.Controls.Add(Me.txtNomDestino)
        Me.Panel2.Controls.Add(Me.lblIntr)
        Me.Panel2.Location = New System.Drawing.Point(12, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 108)
        Me.Panel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-2, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(590, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos de los clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(593, 111)
        Me.Label6.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1058, 22)
        Me.StatusStrip1.TabIndex = 37
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "F2|Nuevo"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel2.Text = "F3|Buscar"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel3.Text = "F4|Guardar/Cerrar salida"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel6.Text = "F5|Pesar"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(95, 17)
        Me.ToolStripStatusLabel7.Text = "F6|Agregar Cajas"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel4.Text = "F7|Cancelar"
        Me.ToolStripStatusLabel4.Visible = False
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel8.Text = "F9|Imprimir"
        Me.ToolStripStatusLabel8.Visible = False
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(96, 17)
        Me.ToolStripStatusLabel5.Text = "F10|Importar ID's"
        Me.ToolStripStatusLabel5.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(608, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(438, 440)
        Me.Label8.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(593, 303)
        Me.Label9.TabIndex = 4
        '
        'lblCanalesSalida
        '
        Me.lblCanalesSalida.BackColor = System.Drawing.SystemColors.Control
        Me.lblCanalesSalida.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanalesSalida.ForeColor = System.Drawing.Color.Maroon
        Me.lblCanalesSalida.Location = New System.Drawing.Point(610, 114)
        Me.lblCanalesSalida.Name = "lblCanalesSalida"
        Me.lblCanalesSalida.Size = New System.Drawing.Size(435, 23)
        Me.lblCanalesSalida.TabIndex = 42
        Me.lblCanalesSalida.Text = "Cajas para la salida"
        Me.lblCanalesSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCajasDisponibles
        '
        Me.lblCajasDisponibles.BackColor = System.Drawing.SystemColors.Control
        Me.lblCajasDisponibles.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajasDisponibles.ForeColor = System.Drawing.Color.Maroon
        Me.lblCajasDisponibles.Location = New System.Drawing.Point(12, 227)
        Me.lblCajasDisponibles.Name = "lblCajasDisponibles"
        Me.lblCajasDisponibles.Size = New System.Drawing.Size(589, 23)
        Me.lblCajasDisponibles.TabIndex = 5
        Me.lblCajasDisponibles.Text = "Cajas disponibles"
        Me.lblCajasDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 529)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(593, 85)
        Me.Label16.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(12, 531)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(589, 23)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Observaciones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 557)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(589, 55)
        Me.txtObservaciones.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCodBar)
        Me.Panel3.Controls.Add(Me.btnCodBar)
        Me.Panel3.Controls.Add(Me.txtCodBar)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(609, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 95)
        Me.Panel3.TabIndex = 45
        '
        'lblCodBar
        '
        Me.lblCodBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodBar.Location = New System.Drawing.Point(5, 63)
        Me.lblCodBar.Name = "lblCodBar"
        Me.lblCodBar.Size = New System.Drawing.Size(425, 20)
        Me.lblCodBar.TabIndex = 7
        Me.lblCodBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCodBar
        '
        Me.btnCodBar.Location = New System.Drawing.Point(364, 31)
        Me.btnCodBar.Name = "btnCodBar"
        Me.btnCodBar.Size = New System.Drawing.Size(24, 26)
        Me.btnCodBar.TabIndex = 6
        Me.btnCodBar.Text = "..."
        Me.btnCodBar.UseVisualStyleBackColor = True
        '
        'txtCodBar
        '
        Me.txtCodBar.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodBar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBar.Location = New System.Drawing.Point(60, 31)
        Me.txtCodBar.MaxLength = 40
        Me.txtCodBar.Name = "txtCodBar"
        Me.txtCodBar.Size = New System.Drawing.Size(298, 26)
        Me.txtCodBar.TabIndex = 5
        Me.txtCodBar.TabStop = False
        Me.txtCodBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(-1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de barras"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(608, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(437, 98)
        Me.Label5.TabIndex = 44
        '
        'DsMovimientos
        '
        Me.DsMovimientos.DataSetName = "dsMovimientos"
        Me.DsMovimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.AllowUserToOrderColumns = True
        Me.dgvDatos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatos.AutoGenerateColumns = False
        Me.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_EST, Me.ID_ESD_TMP, Me.IDMOVDataGridViewTextBoxColumn1, Me.NOMMOVDataGridViewTextBoxColumn, Me.IDALMDataGridViewTextBoxColumn1, Me.NOMALMDataGridViewTextBoxColumn, Me.IDCTEPRODDataGridViewTextBoxColumn1, Me.MARCACTEPRODDataGridViewTextBoxColumn1, Me.NOMCTEPRODDataGridViewTextBoxColumn, Me.IDCTEINTRDataGridViewTextBoxColumn1, Me.MARCACTEINTRDataGridViewTextBoxColumn1, Me.NOMCTEINTRDataGridViewTextBoxColumn, Me.IDCTEDESTDataGridViewTextBoxColumn1, Me.MARCACTEDESTDataGridViewTextBoxColumn1, Me.NOMCTEDESTDataGridViewTextBoxColumn, Me.SACLOTEDataGridViewTextBoxColumn, Me.IDCTEDETDataGridViewTextBoxColumn, Me.MARCACTEDETDataGridViewTextBoxColumn, Me.NOMCTEDETDataGridViewTextBoxColumn, Me.IDPRODDataGridViewTextBoxColumn1, Me.NOMPRODDataGridViewTextBoxColumn1, Me.SACSERIEDataGridViewTextBoxColumn, Me.SACIDDataGridViewTextBoxColumn, Me.SACLADODataGridViewTextBoxColumn, Me.SERIEIDDataGridViewTextBoxColumn, Me.SACSEXODataGridViewTextBoxColumn, Me.SACMAYORDataGridViewTextBoxColumn, Me.SACVACIADADataGridViewTextBoxColumn, Me.SACENMANTADODataGridViewTextBoxColumn, Me.PIELARETECAMPANADataGridViewTextBoxColumn, Me.PIELARETESAGARPADataGridViewTextBoxColumn, Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn, Me.DECOMISODataGridViewTextBoxColumn, Me.OBSERVACIONESESDDataGridViewTextBoxColumn, Me.ESTATUSESDDataGridViewTextBoxColumn1, Me.IDALMDESTDataGridViewTextBoxColumn, Me.NOMALMDESTDataGridViewTextBoxColumn, Me.IDCTEDESTDataGridViewTextBoxColumn2, Me.MARCACTEDESTDataGridViewTextBoxColumn2, Me.NOMCTEDESTDataGridViewTextBoxColumn1, Me.PIEZASFRIODataGridViewTextBoxColumn, Me.PESOFRIODataGridViewTextBoxColumn, Me.TARAFRIODataGridViewTextBoxColumn, Me.FECHAFRIODataGridViewTextBoxColumn, Me.HORAFRIODataGridViewTextBoxColumn, Me.OBSERVACIONESFRIODataGridViewTextBoxColumn, Me.IDPRODCTEDataGridViewTextBoxColumn1, Me.NOMBREPRODCTEDataGridViewTextBoxColumn1, Me.PIEZASDataGridViewTextBoxColumn1, Me.PESODataGridViewTextBoxColumn1, Me.TARADataGridViewTextBoxColumn1, Me.CORLOTEDataGridViewTextBoxColumn, Me.CAJASERIEDataGridViewTextBoxColumn1, Me.CAJAIDDataGridViewTextBoxColumn1, Me.CAJASERIEIDDataGridViewTextBoxColumn1, Me.CAJAFECHAETIQDataGridViewTextBoxColumn1, Me.FECHAESDDataGridViewTextBoxColumn1, Me.HORAESDDataGridViewTextBoxColumn1, Me.CAJACODBARDataGridViewTextBoxColumn1})
        Me.dgvDatos.DataMember = "SP_CONS_ENTSAL_X_MOVTO_TMP"
        Me.dgvDatos.DataSource = Me.DsSacrificio
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDatos.Location = New System.Drawing.Point(609, 140)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDatos.RowHeadersVisible = False
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(436, 411)
        Me.dgvDatos.StandardTab = True
        Me.dgvDatos.TabIndex = 9
        '
        'ID_EST
        '
        Me.ID_EST.DataPropertyName = "ID_EST"
        Me.ID_EST.HeaderText = "ID_EST"
        Me.ID_EST.Name = "ID_EST"
        Me.ID_EST.ReadOnly = True
        Me.ID_EST.Visible = False
        '
        'ID_ESD_TMP
        '
        Me.ID_ESD_TMP.DataPropertyName = "ID_ESD"
        Me.ID_ESD_TMP.HeaderText = "ID_ESD"
        Me.ID_ESD_TMP.Name = "ID_ESD_TMP"
        Me.ID_ESD_TMP.ReadOnly = True
        Me.ID_ESD_TMP.Visible = False
        '
        'IDMOVDataGridViewTextBoxColumn1
        '
        Me.IDMOVDataGridViewTextBoxColumn1.DataPropertyName = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn1.HeaderText = "ID_MOV"
        Me.IDMOVDataGridViewTextBoxColumn1.Name = "IDMOVDataGridViewTextBoxColumn1"
        Me.IDMOVDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDMOVDataGridViewTextBoxColumn1.Visible = False
        '
        'NOMMOVDataGridViewTextBoxColumn
        '
        Me.NOMMOVDataGridViewTextBoxColumn.DataPropertyName = "NOM_MOV"
        Me.NOMMOVDataGridViewTextBoxColumn.HeaderText = "NOM_MOV"
        Me.NOMMOVDataGridViewTextBoxColumn.Name = "NOMMOVDataGridViewTextBoxColumn"
        Me.NOMMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMMOVDataGridViewTextBoxColumn.Visible = False
        '
        'IDALMDataGridViewTextBoxColumn1
        '
        Me.IDALMDataGridViewTextBoxColumn1.DataPropertyName = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn1.HeaderText = "ID_ALM"
        Me.IDALMDataGridViewTextBoxColumn1.Name = "IDALMDataGridViewTextBoxColumn1"
        Me.IDALMDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDALMDataGridViewTextBoxColumn1.Visible = False
        '
        'NOMALMDataGridViewTextBoxColumn
        '
        Me.NOMALMDataGridViewTextBoxColumn.DataPropertyName = "NOM_ALM"
        Me.NOMALMDataGridViewTextBoxColumn.HeaderText = "NOM_ALM"
        Me.NOMALMDataGridViewTextBoxColumn.Name = "NOMALMDataGridViewTextBoxColumn"
        Me.NOMALMDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMALMDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEPRODDataGridViewTextBoxColumn1
        '
        Me.IDCTEPRODDataGridViewTextBoxColumn1.DataPropertyName = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn1.HeaderText = "ID_CTE_PROD"
        Me.IDCTEPRODDataGridViewTextBoxColumn1.Name = "IDCTEPRODDataGridViewTextBoxColumn1"
        Me.IDCTEPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDCTEPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'MARCACTEPRODDataGridViewTextBoxColumn1
        '
        Me.MARCACTEPRODDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn1.HeaderText = "MARCA_CTE_PROD"
        Me.MARCACTEPRODDataGridViewTextBoxColumn1.Name = "MARCACTEPRODDataGridViewTextBoxColumn1"
        Me.MARCACTEPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MARCACTEPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'NOMCTEPRODDataGridViewTextBoxColumn
        '
        Me.NOMCTEPRODDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_PROD"
        Me.NOMCTEPRODDataGridViewTextBoxColumn.HeaderText = "NOM_CTE_PROD"
        Me.NOMCTEPRODDataGridViewTextBoxColumn.Name = "NOMCTEPRODDataGridViewTextBoxColumn"
        Me.NOMCTEPRODDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEPRODDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEINTRDataGridViewTextBoxColumn1
        '
        Me.IDCTEINTRDataGridViewTextBoxColumn1.DataPropertyName = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn1.HeaderText = "ID_CTE_INTR"
        Me.IDCTEINTRDataGridViewTextBoxColumn1.Name = "IDCTEINTRDataGridViewTextBoxColumn1"
        Me.IDCTEINTRDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDCTEINTRDataGridViewTextBoxColumn1.Visible = False
        '
        'MARCACTEINTRDataGridViewTextBoxColumn1
        '
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.HeaderText = "MARCA_CTE_INTR"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.Name = "MARCACTEINTRDataGridViewTextBoxColumn1"
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MARCACTEINTRDataGridViewTextBoxColumn1.Visible = False
        '
        'NOMCTEINTRDataGridViewTextBoxColumn
        '
        Me.NOMCTEINTRDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_INTR"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.HeaderText = "NOM_CTE_INTR"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Name = "NOMCTEINTRDataGridViewTextBoxColumn"
        Me.NOMCTEINTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEINTRDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEDESTDataGridViewTextBoxColumn1
        '
        Me.IDCTEDESTDataGridViewTextBoxColumn1.DataPropertyName = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn1.HeaderText = "ID_CTE_DEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn1.Name = "IDCTEDESTDataGridViewTextBoxColumn1"
        Me.IDCTEDESTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDCTEDESTDataGridViewTextBoxColumn1.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn1
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.DataPropertyName = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.HeaderText = "MARCA_CTE_DEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Name = "MARCACTEDESTDataGridViewTextBoxColumn1"
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn1.Visible = False
        '
        'NOMCTEDESTDataGridViewTextBoxColumn
        '
        Me.NOMCTEDESTDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_DEST"
        Me.NOMCTEDESTDataGridViewTextBoxColumn.HeaderText = "NOM_CTE_DEST"
        Me.NOMCTEDESTDataGridViewTextBoxColumn.Name = "NOMCTEDESTDataGridViewTextBoxColumn"
        Me.NOMCTEDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEDESTDataGridViewTextBoxColumn.Visible = False
        '
        'SACLOTEDataGridViewTextBoxColumn
        '
        Me.SACLOTEDataGridViewTextBoxColumn.DataPropertyName = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.HeaderText = "SAC_LOTE"
        Me.SACLOTEDataGridViewTextBoxColumn.Name = "SACLOTEDataGridViewTextBoxColumn"
        Me.SACLOTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLOTEDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEDETDataGridViewTextBoxColumn
        '
        Me.IDCTEDETDataGridViewTextBoxColumn.DataPropertyName = "ID_CTE_DET"
        Me.IDCTEDETDataGridViewTextBoxColumn.HeaderText = "ID_CTE_DET"
        Me.IDCTEDETDataGridViewTextBoxColumn.Name = "IDCTEDETDataGridViewTextBoxColumn"
        Me.IDCTEDETDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDCTEDETDataGridViewTextBoxColumn.Visible = False
        '
        'MARCACTEDETDataGridViewTextBoxColumn
        '
        Me.MARCACTEDETDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CTE_DET"
        Me.MARCACTEDETDataGridViewTextBoxColumn.HeaderText = "MARCA_CTE_DET"
        Me.MARCACTEDETDataGridViewTextBoxColumn.Name = "MARCACTEDETDataGridViewTextBoxColumn"
        Me.MARCACTEDETDataGridViewTextBoxColumn.ReadOnly = True
        Me.MARCACTEDETDataGridViewTextBoxColumn.Visible = False
        '
        'NOMCTEDETDataGridViewTextBoxColumn
        '
        Me.NOMCTEDETDataGridViewTextBoxColumn.DataPropertyName = "NOM_CTE_DET"
        Me.NOMCTEDETDataGridViewTextBoxColumn.HeaderText = "NOM_CTE_DET"
        Me.NOMCTEDETDataGridViewTextBoxColumn.Name = "NOMCTEDETDataGridViewTextBoxColumn"
        Me.NOMCTEDETDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMCTEDETDataGridViewTextBoxColumn.Visible = False
        '
        'IDPRODDataGridViewTextBoxColumn1
        '
        Me.IDPRODDataGridViewTextBoxColumn1.DataPropertyName = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn1.HeaderText = "ID_PROD"
        Me.IDPRODDataGridViewTextBoxColumn1.Name = "IDPRODDataGridViewTextBoxColumn1"
        Me.IDPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'NOMPRODDataGridViewTextBoxColumn1
        '
        Me.NOMPRODDataGridViewTextBoxColumn1.DataPropertyName = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn1.HeaderText = "NOM_PROD"
        Me.NOMPRODDataGridViewTextBoxColumn1.Name = "NOMPRODDataGridViewTextBoxColumn1"
        Me.NOMPRODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NOMPRODDataGridViewTextBoxColumn1.Visible = False
        '
        'SACSERIEDataGridViewTextBoxColumn
        '
        Me.SACSERIEDataGridViewTextBoxColumn.DataPropertyName = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.HeaderText = "SAC_SERIE"
        Me.SACSERIEDataGridViewTextBoxColumn.Name = "SACSERIEDataGridViewTextBoxColumn"
        Me.SACSERIEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSERIEDataGridViewTextBoxColumn.Visible = False
        '
        'SACIDDataGridViewTextBoxColumn
        '
        Me.SACIDDataGridViewTextBoxColumn.DataPropertyName = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.HeaderText = "SAC_ID"
        Me.SACIDDataGridViewTextBoxColumn.Name = "SACIDDataGridViewTextBoxColumn"
        Me.SACIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACIDDataGridViewTextBoxColumn.Visible = False
        '
        'SACLADODataGridViewTextBoxColumn
        '
        Me.SACLADODataGridViewTextBoxColumn.DataPropertyName = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.HeaderText = "SAC_LADO"
        Me.SACLADODataGridViewTextBoxColumn.Name = "SACLADODataGridViewTextBoxColumn"
        Me.SACLADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACLADODataGridViewTextBoxColumn.Visible = False
        '
        'SERIEIDDataGridViewTextBoxColumn
        '
        Me.SERIEIDDataGridViewTextBoxColumn.DataPropertyName = "SERIE_ID"
        Me.SERIEIDDataGridViewTextBoxColumn.HeaderText = "SERIE_ID"
        Me.SERIEIDDataGridViewTextBoxColumn.Name = "SERIEIDDataGridViewTextBoxColumn"
        Me.SERIEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SERIEIDDataGridViewTextBoxColumn.Visible = False
        '
        'SACSEXODataGridViewTextBoxColumn
        '
        Me.SACSEXODataGridViewTextBoxColumn.DataPropertyName = "SAC_SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.HeaderText = "SAC_SEXO"
        Me.SACSEXODataGridViewTextBoxColumn.Name = "SACSEXODataGridViewTextBoxColumn"
        Me.SACSEXODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACSEXODataGridViewTextBoxColumn.Visible = False
        '
        'SACMAYORDataGridViewTextBoxColumn
        '
        Me.SACMAYORDataGridViewTextBoxColumn.DataPropertyName = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.HeaderText = "SAC_MAYOR"
        Me.SACMAYORDataGridViewTextBoxColumn.Name = "SACMAYORDataGridViewTextBoxColumn"
        Me.SACMAYORDataGridViewTextBoxColumn.ReadOnly = True
        Me.SACMAYORDataGridViewTextBoxColumn.Visible = False
        '
        'SACVACIADADataGridViewTextBoxColumn
        '
        Me.SACVACIADADataGridViewTextBoxColumn.DataPropertyName = "SAC_VACIADA"
        Me.SACVACIADADataGridViewTextBoxColumn.HeaderText = "SAC_VACIADA"
        Me.SACVACIADADataGridViewTextBoxColumn.Name = "SACVACIADADataGridViewTextBoxColumn"
        Me.SACVACIADADataGridViewTextBoxColumn.ReadOnly = True
        Me.SACVACIADADataGridViewTextBoxColumn.Visible = False
        '
        'SACENMANTADODataGridViewTextBoxColumn
        '
        Me.SACENMANTADODataGridViewTextBoxColumn.DataPropertyName = "SAC_ENMANTADO"
        Me.SACENMANTADODataGridViewTextBoxColumn.HeaderText = "SAC_ENMANTADO"
        Me.SACENMANTADODataGridViewTextBoxColumn.Name = "SACENMANTADODataGridViewTextBoxColumn"
        Me.SACENMANTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.SACENMANTADODataGridViewTextBoxColumn.Visible = False
        '
        'PIELARETECAMPANADataGridViewTextBoxColumn
        '
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.DataPropertyName = "PIEL_ARETE_CAMPANA"
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.HeaderText = "PIEL_ARETE_CAMPANA"
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.Name = "PIELARETECAMPANADataGridViewTextBoxColumn"
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.ReadOnly = True
        Me.PIELARETECAMPANADataGridViewTextBoxColumn.Visible = False
        '
        'PIELARETESAGARPADataGridViewTextBoxColumn
        '
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.DataPropertyName = "PIEL_ARETE_SAGARPA"
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.HeaderText = "PIEL_ARETE_SAGARPA"
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.Name = "PIELARETESAGARPADataGridViewTextBoxColumn"
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.ReadOnly = True
        Me.PIELARETESAGARPADataGridViewTextBoxColumn.Visible = False
        '
        'PIELARETEINTRODUCTORDataGridViewTextBoxColumn
        '
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.DataPropertyName = "PIEL_ARETE_INTRODUCTOR"
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.HeaderText = "PIEL_ARETE_INTRODUCTOR"
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.Name = "PIELARETEINTRODUCTORDataGridViewTextBoxColumn"
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.ReadOnly = True
        Me.PIELARETEINTRODUCTORDataGridViewTextBoxColumn.Visible = False
        '
        'DECOMISODataGridViewTextBoxColumn
        '
        Me.DECOMISODataGridViewTextBoxColumn.DataPropertyName = "DECOMISO"
        Me.DECOMISODataGridViewTextBoxColumn.HeaderText = "DECOMISO"
        Me.DECOMISODataGridViewTextBoxColumn.Name = "DECOMISODataGridViewTextBoxColumn"
        Me.DECOMISODataGridViewTextBoxColumn.ReadOnly = True
        Me.DECOMISODataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESESDDataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES_ESD"
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES_ESD"
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.Name = "OBSERVACIONESESDDataGridViewTextBoxColumn"
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESESDDataGridViewTextBoxColumn.Visible = False
        '
        'ESTATUSESDDataGridViewTextBoxColumn1
        '
        Me.ESTATUSESDDataGridViewTextBoxColumn1.DataPropertyName = "ESTATUS_ESD"
        Me.ESTATUSESDDataGridViewTextBoxColumn1.HeaderText = "ESTATUS_ESD"
        Me.ESTATUSESDDataGridViewTextBoxColumn1.Name = "ESTATUSESDDataGridViewTextBoxColumn1"
        Me.ESTATUSESDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ESTATUSESDDataGridViewTextBoxColumn1.Visible = False
        '
        'IDALMDESTDataGridViewTextBoxColumn
        '
        Me.IDALMDESTDataGridViewTextBoxColumn.DataPropertyName = "ID_ALM_DEST"
        Me.IDALMDESTDataGridViewTextBoxColumn.HeaderText = "ID_ALM_DEST"
        Me.IDALMDESTDataGridViewTextBoxColumn.Name = "IDALMDESTDataGridViewTextBoxColumn"
        Me.IDALMDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDALMDESTDataGridViewTextBoxColumn.Visible = False
        '
        'NOMALMDESTDataGridViewTextBoxColumn
        '
        Me.NOMALMDESTDataGridViewTextBoxColumn.DataPropertyName = "NOM_ALM_DEST"
        Me.NOMALMDESTDataGridViewTextBoxColumn.HeaderText = "NOM_ALM_DEST"
        Me.NOMALMDESTDataGridViewTextBoxColumn.Name = "NOMALMDESTDataGridViewTextBoxColumn"
        Me.NOMALMDESTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOMALMDESTDataGridViewTextBoxColumn.Visible = False
        '
        'IDCTEDESTDataGridViewTextBoxColumn2
        '
        Me.IDCTEDESTDataGridViewTextBoxColumn2.DataPropertyName = "ID_CTEDEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn2.HeaderText = "ID_CTEDEST"
        Me.IDCTEDESTDataGridViewTextBoxColumn2.Name = "IDCTEDESTDataGridViewTextBoxColumn2"
        Me.IDCTEDESTDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IDCTEDESTDataGridViewTextBoxColumn2.Visible = False
        '
        'MARCACTEDESTDataGridViewTextBoxColumn2
        '
        Me.MARCACTEDESTDataGridViewTextBoxColumn2.DataPropertyName = "MARCA_CTEDEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn2.HeaderText = "MARCA_CTEDEST"
        Me.MARCACTEDESTDataGridViewTextBoxColumn2.Name = "MARCACTEDESTDataGridViewTextBoxColumn2"
        Me.MARCACTEDESTDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MARCACTEDESTDataGridViewTextBoxColumn2.Visible = False
        '
        'NOMCTEDESTDataGridViewTextBoxColumn1
        '
        Me.NOMCTEDESTDataGridViewTextBoxColumn1.DataPropertyName = "NOM_CTEDEST"
        Me.NOMCTEDESTDataGridViewTextBoxColumn1.HeaderText = "NOM_CTEDEST"
        Me.NOMCTEDESTDataGridViewTextBoxColumn1.Name = "NOMCTEDESTDataGridViewTextBoxColumn1"
        Me.NOMCTEDESTDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NOMCTEDESTDataGridViewTextBoxColumn1.Visible = False
        '
        'PIEZASFRIODataGridViewTextBoxColumn
        '
        Me.PIEZASFRIODataGridViewTextBoxColumn.DataPropertyName = "PIEZAS_FRIO"
        Me.PIEZASFRIODataGridViewTextBoxColumn.HeaderText = "PIEZAS_FRIO"
        Me.PIEZASFRIODataGridViewTextBoxColumn.Name = "PIEZASFRIODataGridViewTextBoxColumn"
        Me.PIEZASFRIODataGridViewTextBoxColumn.ReadOnly = True
        Me.PIEZASFRIODataGridViewTextBoxColumn.Visible = False
        '
        'PESOFRIODataGridViewTextBoxColumn
        '
        Me.PESOFRIODataGridViewTextBoxColumn.DataPropertyName = "PESO_FRIO"
        Me.PESOFRIODataGridViewTextBoxColumn.HeaderText = "PESO_FRIO"
        Me.PESOFRIODataGridViewTextBoxColumn.Name = "PESOFRIODataGridViewTextBoxColumn"
        Me.PESOFRIODataGridViewTextBoxColumn.ReadOnly = True
        Me.PESOFRIODataGridViewTextBoxColumn.Visible = False
        '
        'TARAFRIODataGridViewTextBoxColumn
        '
        Me.TARAFRIODataGridViewTextBoxColumn.DataPropertyName = "TARA_FRIO"
        Me.TARAFRIODataGridViewTextBoxColumn.HeaderText = "TARA_FRIO"
        Me.TARAFRIODataGridViewTextBoxColumn.Name = "TARAFRIODataGridViewTextBoxColumn"
        Me.TARAFRIODataGridViewTextBoxColumn.ReadOnly = True
        Me.TARAFRIODataGridViewTextBoxColumn.Visible = False
        '
        'FECHAFRIODataGridViewTextBoxColumn
        '
        Me.FECHAFRIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_FRIO"
        Me.FECHAFRIODataGridViewTextBoxColumn.HeaderText = "FECHA_FRIO"
        Me.FECHAFRIODataGridViewTextBoxColumn.Name = "FECHAFRIODataGridViewTextBoxColumn"
        Me.FECHAFRIODataGridViewTextBoxColumn.ReadOnly = True
        Me.FECHAFRIODataGridViewTextBoxColumn.Visible = False
        '
        'HORAFRIODataGridViewTextBoxColumn
        '
        Me.HORAFRIODataGridViewTextBoxColumn.DataPropertyName = "HORA_FRIO"
        Me.HORAFRIODataGridViewTextBoxColumn.HeaderText = "HORA_FRIO"
        Me.HORAFRIODataGridViewTextBoxColumn.Name = "HORAFRIODataGridViewTextBoxColumn"
        Me.HORAFRIODataGridViewTextBoxColumn.ReadOnly = True
        Me.HORAFRIODataGridViewTextBoxColumn.Visible = False
        '
        'OBSERVACIONESFRIODataGridViewTextBoxColumn
        '
        Me.OBSERVACIONESFRIODataGridViewTextBoxColumn.DataPropertyName = "OBSERVACIONES_FRIO"
        Me.OBSERVACIONESFRIODataGridViewTextBoxColumn.HeaderText = "OBSERVACIONES_FRIO"
        Me.OBSERVACIONESFRIODataGridViewTextBoxColumn.Name = "OBSERVACIONESFRIODataGridViewTextBoxColumn"
        Me.OBSERVACIONESFRIODataGridViewTextBoxColumn.ReadOnly = True
        Me.OBSERVACIONESFRIODataGridViewTextBoxColumn.Visible = False
        '
        'IDPRODCTEDataGridViewTextBoxColumn1
        '
        Me.IDPRODCTEDataGridViewTextBoxColumn1.DataPropertyName = "ID_PRODCTE"
        Me.IDPRODCTEDataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.IDPRODCTEDataGridViewTextBoxColumn1.Name = "IDPRODCTEDataGridViewTextBoxColumn1"
        Me.IDPRODCTEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDPRODCTEDataGridViewTextBoxColumn1.Width = 60
        '
        'NOMBREPRODCTEDataGridViewTextBoxColumn1
        '
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE_PRODCTE"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn1.HeaderText = "PRODUCTO"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn1.Name = "NOMBREPRODCTEDataGridViewTextBoxColumn1"
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NOMBREPRODCTEDataGridViewTextBoxColumn1.Width = 200
        '
        'PIEZASDataGridViewTextBoxColumn1
        '
        Me.PIEZASDataGridViewTextBoxColumn1.DataPropertyName = "PIEZAS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PIEZASDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.PIEZASDataGridViewTextBoxColumn1.HeaderText = "PIEZAS"
        Me.PIEZASDataGridViewTextBoxColumn1.Name = "PIEZASDataGridViewTextBoxColumn1"
        Me.PIEZASDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PIEZASDataGridViewTextBoxColumn1.Width = 60
        '
        'PESODataGridViewTextBoxColumn1
        '
        Me.PESODataGridViewTextBoxColumn1.DataPropertyName = "PESO"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PESODataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.PESODataGridViewTextBoxColumn1.HeaderText = "PESO"
        Me.PESODataGridViewTextBoxColumn1.Name = "PESODataGridViewTextBoxColumn1"
        Me.PESODataGridViewTextBoxColumn1.ReadOnly = True
        Me.PESODataGridViewTextBoxColumn1.Width = 60
        '
        'TARADataGridViewTextBoxColumn1
        '
        Me.TARADataGridViewTextBoxColumn1.DataPropertyName = "TARA"
        Me.TARADataGridViewTextBoxColumn1.HeaderText = "TARA"
        Me.TARADataGridViewTextBoxColumn1.Name = "TARADataGridViewTextBoxColumn1"
        Me.TARADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CORLOTEDataGridViewTextBoxColumn
        '
        Me.CORLOTEDataGridViewTextBoxColumn.DataPropertyName = "COR_LOTE"
        Me.CORLOTEDataGridViewTextBoxColumn.HeaderText = "COR_LOTE"
        Me.CORLOTEDataGridViewTextBoxColumn.Name = "CORLOTEDataGridViewTextBoxColumn"
        Me.CORLOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJASERIEDataGridViewTextBoxColumn1
        '
        Me.CAJASERIEDataGridViewTextBoxColumn1.DataPropertyName = "CAJA_SERIE"
        Me.CAJASERIEDataGridViewTextBoxColumn1.HeaderText = "CAJA_SERIE"
        Me.CAJASERIEDataGridViewTextBoxColumn1.Name = "CAJASERIEDataGridViewTextBoxColumn1"
        Me.CAJASERIEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CAJASERIEDataGridViewTextBoxColumn1.Visible = False
        '
        'CAJAIDDataGridViewTextBoxColumn1
        '
        Me.CAJAIDDataGridViewTextBoxColumn1.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn1.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn1.Name = "CAJAIDDataGridViewTextBoxColumn1"
        Me.CAJAIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CAJAIDDataGridViewTextBoxColumn1.Visible = False
        '
        'CAJASERIEIDDataGridViewTextBoxColumn1
        '
        Me.CAJASERIEIDDataGridViewTextBoxColumn1.DataPropertyName = "CAJA_SERIE_ID"
        Me.CAJASERIEIDDataGridViewTextBoxColumn1.HeaderText = "CAJA_SERIE_ID"
        Me.CAJASERIEIDDataGridViewTextBoxColumn1.Name = "CAJASERIEIDDataGridViewTextBoxColumn1"
        Me.CAJASERIEIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CAJAFECHAETIQDataGridViewTextBoxColumn1
        '
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn1.DataPropertyName = "CAJA_FECHA_ETIQ"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn1.HeaderText = "CAJA_FECHA_ETIQ"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn1.Name = "CAJAFECHAETIQDataGridViewTextBoxColumn1"
        Me.CAJAFECHAETIQDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FECHAESDDataGridViewTextBoxColumn1
        '
        Me.FECHAESDDataGridViewTextBoxColumn1.DataPropertyName = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn1.HeaderText = "FECHA_ESD"
        Me.FECHAESDDataGridViewTextBoxColumn1.Name = "FECHAESDDataGridViewTextBoxColumn1"
        Me.FECHAESDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'HORAESDDataGridViewTextBoxColumn1
        '
        Me.HORAESDDataGridViewTextBoxColumn1.DataPropertyName = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn1.HeaderText = "HORA_ESD"
        Me.HORAESDDataGridViewTextBoxColumn1.Name = "HORAESDDataGridViewTextBoxColumn1"
        Me.HORAESDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CAJACODBARDataGridViewTextBoxColumn1
        '
        Me.CAJACODBARDataGridViewTextBoxColumn1.DataPropertyName = "CAJA_CODBAR"
        Me.CAJACODBARDataGridViewTextBoxColumn1.HeaderText = "CAJA_CODBAR"
        Me.CAJACODBARDataGridViewTextBoxColumn1.Name = "CAJACODBARDataGridViewTextBoxColumn1"
        Me.CAJACODBARDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DsSacrificio
        '
        Me.DsSacrificio.DataSetName = "dsSacrificio"
        Me.DsSacrificio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstID
        '
        Me.lstID.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstID.FormattingEnabled = True
        Me.lstID.ItemHeight = 18
        Me.lstID.Items.AddRange(New Object() {""})
        Me.lstID.Location = New System.Drawing.Point(11, 252)
        Me.lstID.Name = "lstID"
        Me.lstID.Size = New System.Drawing.Size(590, 274)
        Me.lstID.TabIndex = 6
        '
        'btnPegar
        '
        Me.btnPegar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPegar.Location = New System.Drawing.Point(609, 557)
        Me.btnPegar.Name = "btnPegar"
        Me.btnPegar.Size = New System.Drawing.Size(113, 55)
        Me.btnPegar.TabIndex = 47
        Me.btnPegar.Text = "Pegar &ID's desde el Portapapeles"
        Me.btnPegar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(728, 557)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(76, 55)
        Me.btnAgregar.TabIndex = 48
        Me.btnAgregar.Text = "Agregar Cajas"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnPesar
        '
        Me.btnPesar.FlatAppearance.BorderSize = 0
        Me.btnPesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesar.Image = Global.SistemaControlProduccion.My.Resources.Resources.bascula4
        Me.btnPesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesar.Location = New System.Drawing.Point(977, 557)
        Me.btnPesar.Name = "btnPesar"
        Me.btnPesar.Size = New System.Drawing.Size(71, 57)
        Me.btnPesar.TabIndex = 12
        Me.btnPesar.Text = "&Pesar"
        Me.btnPesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPesar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SistemaControlProduccion.My.Resources.Resources.Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(900, 557)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 57)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SistemaControlProduccion.My.Resources.Resources.new_doc
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(823, 557)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 57)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmPROC_SalidaCajas_xID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1058, 639)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnPegar)
        Me.Controls.Add(Me.lstID)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblCajasDisponibles)
        Me.Controls.Add(Me.lblCanalesSalida)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnPesar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPROC_SalidaCajas_xID"
        Me.ShowInTaskbar = False
        Me.Text = "Registro de salida de cajas por embarque por ID"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DsMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSacrificio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomMovto As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMovto As System.Windows.Forms.TextBox
    Friend WithEvents lblProductor As System.Windows.Forms.Label
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents txtNomIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents lblIntr As System.Windows.Forms.Label
    Friend WithEvents txtNomDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents txtMarcaDestino As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnPesar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCanalesSalida As System.Windows.Forms.Label
    Friend WithEvents lblCajasDisponibles As System.Windows.Forms.Label
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCodBar As System.Windows.Forms.Button
    Friend WithEvents txtCodBar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents lblCodBar As System.Windows.Forms.Label
    Friend WithEvents OBSFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsMovimientos As SistemaControlProduccion.dsMovimientos
    Friend WithEvents DsCajas As SistemaControlProduccion.dsCajas
    Friend WithEvents DsSacrificio As SistemaControlProduccion.dsSacrificio
    Friend WithEvents lstID As System.Windows.Forms.ListBox
    Friend WithEvents btnPegar As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents ID_EST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESD_TMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMOVDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEPRODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEINTRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEINTRDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEINTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEDESTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEDETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEDETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMPRODDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACLADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACSEXODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACMAYORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACVACIADADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SACENMANTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIELARETECAMPANADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIELARETESAGARPADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIELARETEINTRODUCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DECOMISODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESESDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTATUSESDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDALMDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMALMDESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDCTEDESTDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCACTEDESTDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCTEDESTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARAFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONESFRIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPRODCTEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREPRODCTEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIEZASDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CORLOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJASERIEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJASERIEIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAFECHAETIQDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAESDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORAESDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJACODBARDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
