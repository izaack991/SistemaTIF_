Imports System.Data
Imports System.Data.SqlClient
Imports SistemaControlProduccion.frmOrdenSacrificio
Public Class FRM_PROGRAMA_SACRIFICIO
    Dim oCorte As New clsCortes()

    Dim oEspecie As clsEspecies
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Dim iUsuario As Integer
    Dim iPesadaManual As String
    Dim oProducto As clsProductos
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim bModifica As Boolean
    Public Sub New(bModifica As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.bModifica = bModifica
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
            If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
        End If
    End Sub
    Private Sub txtMarcaDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaDestino.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(3)
        End If
    End Sub

    Private Sub FRM_PROGRAMA_SACRIFICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Centrar(Me)

        ' Pasar control  
        Centrar(Panel1)
      
        'TODO: esta línea de código carga datos en la tabla 'DS_PROG_SACRI.SACRIFICIO' Puede moverla o quitarla según sea necesario.
        ' Me.SACRIFICIOTableAdapter.Connection.ConnectionString = ConnectionString
        ' Me.SACRIFICIOTableAdapter.Fill(Me.DS_PROG_SACRI.SACRIFICIO, Me.dtpFechaMov.Value)
        oMovAlmacen = New clsMovimientoAlmacen(2)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos


        'Me.dtpFechaMov.Value = Today

        Me.CargaProductos()

        If bModifica = True Then

        Else

            Me.consecutivo()
            consecutivo_lote()
        End If

        llenaralmacen()
    End Sub
    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable() 'GANADO EN CANAL

            lSql = "SP_CONS_PRODUCTOS '', '%', 1"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            Me.cmbEspecie.DataSource = dt
            Me.cmbEspecie.DisplayMember = "NOMBRE"
            Me.cmbEspecie.ValueMember = "ID_PROD"

            lCmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargarCombos()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo2 As SqlClient.SqlDataAdapter
            Dim lSql As String

            lSql = "EXECUTE SP_CONS_ESPECIES"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos1.Tables("SP_CONS_ESPECIES").Clear()
            daCatalogo2.Fill(DsCatalogos1, "SP_CONS_ESPECIES")

            daCatalogo2.Dispose()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Public Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                'If oDestino.ID_CLIENTE <> 0 Then
                'End If
        End Select
    End Sub

    Private Sub FRM_PROGRAMA_SACRIFICIO_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.Guardar()
        End Select
    End Sub
    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas iniciar la captura de un lote nuevo?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            Me.txtMarcaIntroductor.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
   
    Private Sub Buscar()
        Dim lsTitulo As String = ""
        Dim lsCampoBusqueda As String = ""
        Dim liColumnaCodigo As Short

        Dim iBuscaSucursal As Boolean = False
        Dim iBuscaArea As Boolean = False
        Dim iBuscaProveedor As Boolean = False

        Dim lValor1 As String = ""
        Dim lValor2 As String = ""

        Select Case Me.ActiveControl.Name.TrimEnd.ToUpper
            Case "TXTMARCAINTRODUCTOR"
                lsTitulo = "CTE_PROGCORTE_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_PROGCORTE_DESTINO"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
        End Select

        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()

    End Sub
    Private Sub Guardar()

        Dim lOperacion As String
        Dim lMensajeResultado As String = ""
        Dim lResp As Integer
        Dim lID_CORTE As Integer = 0
        Dim lSexo As String = ""
        Dim lPesoAux As Decimal = 0
        Dim lSacSerie As String = ""
        Dim lSacID As Integer = 0
      
        lResp = MessageBox.Show("¿Deseas guardar los datos del corte?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not Me.ValidaDatos() Then Exit Sub

        Dim lCmd As New SqlClient.SqlCommand
        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_PROG_SACRIFICIO"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.AddWithValue("@op", 1)
            lCmd.Parameters.AddWithValue("@ID_SAC", Me.txtidsac.Text)
            lCmd.Parameters.AddWithValue("@ID_ESPECIE", Me.cmbEspecie.SelectedValue)
            lCmd.Parameters.AddWithValue("@ID_CTE_INTR", oIntroductor.ID_CLIENTE)
            lCmd.Parameters.AddWithValue("@ID_CTE_DEST", oDestino.ID_CLIENTE)
            lCmd.Parameters.AddWithValue("@SAC_LOTE", Me.TxtLote.Text)
            lCmd.Parameters.AddWithValue("@FECHA", Me.dtpFechaMov.Value)
            lCmd.Parameters.AddWithValue("@OBSERVACIONES", Me.txtObservaciones.Text)
            lCmd.Parameters.AddWithValue("@ESTATUS", "A")
            lCmd.Parameters.AddWithValue("@ESTADO_SAC", True)
            lCmd.Parameters.AddWithValue("@CANTIDAD", Me.TXTCANTIDAD.Text)
            lCmd.Parameters.AddWithValue("@MACHOS", Me.TXTMACHOS.Text)
            lCmd.Parameters.AddWithValue("@HEMBRAS", Me.TXTHEMBRAS.Text)
            lCmd.Parameters.AddWithValue("@BMIXTO", Me.CHKMIXTO.Checked)
            lCmd.Parameters.AddWithValue("@BHEMBRAS", Me.CHKHEMBRAS.Checked)
            lCmd.Parameters.AddWithValue("@BMACHOS", Me.CHKMACHOS.Checked)
            lCmd.ExecuteNonQuery()
            ' Me.SACRIFICIOTableAdapter.Fill(Me.DS_PROG_SACRI.SACRIFICIO, Me.dtpFechaMov.Value)
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Exit Sub
        Finally
            ' MessageBox.Show("Sus datos se guardaron correctamente")
            limpiar()

        End Try
        Dim success As New frmSuccess
        success.ShowDialog()
        If success.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim os As New frmOrdenSacrificio
            os.Show()
            Me.Close()
        End If
        
    End Sub
    Private Sub llenaralmacen()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim dt As New DataTable()
        Dim dsalmacenes As New DataSet
        Dim Da As New SqlDataAdapter

        lCmd.Connection = Cnn

        With lCmd
            .CommandType = CommandType.Text
            .CommandText = "Select * From ESPECIES"
            .Connection = Cnn
        End With
        Da.SelectCommand = lCmd
        dt = New DataTable
        Da.Fill(dt)
        With Me.cmbEspecie
            .DataSource = dt
            .DisplayMember = "NOMBRE"
            .ValueMember = "ID_ESPECIE"
        End With

    End Sub
   
    Private Sub consecutivo()
        Dim l As SqlDataReader
        Dim lCmd As New SqlClient.SqlCommand()

        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_PROG_SACRIFICIO"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.AddWithValue("@op", 3)

            l = lCmd.ExecuteReader()
            If l.Read Then
                Me.txtidsac.Text = l("ID_SAC")
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Exit Sub
        Finally
            l.Close()
        End Try

    End Sub
    Private Sub consecutivo_lote()
        Dim l As SqlDataReader
        Dim lCmd As New SqlClient.SqlCommand()

        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_PROG_SACRIFICIO"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.AddWithValue("@op", 4)

            l = lCmd.ExecuteReader()
            If l.Read Then
                Me.TxtLote.Text = l("SAC_LOTE")
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Exit Sub
        Finally
            l.Close()
        End Try

    End Sub
    Private Sub DespliegaDatos()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""

        If oCorte.ID_CORTE <> 0 Then

            'Me.btnguardarlotefecha.Enabled = True
            'Me.btnguardarlotefecha.Visible = True

            Me.txtidsac.Text = oCorte.ID_CORTE

            oIntroductor = New clsCliente(oCorte.ID_CTE_INTR)
            Me.txtMarcaIntroductor.Text = oIntroductor.Marca
            Me.DespliegaCliente(2)

            oDestino = New clsCliente(oCorte.ID_CTE_DEST)
            Me.txtMarcaDestino.Text = oDestino.Marca
            Me.DespliegaCliente(3)

            Me.dtpFechaMov.Value = oCorte.FECHA
            Me.TxtLote.Text = oCorte.COR_LOTE

            Me.txtObservaciones.Text = oCorte.OBSERVACIONES
        End If
    End Sub
    Private Function ValidaDatos() As Boolean
        Try
            ValidaDatos = False

            'If Me.txtLote.Text.Trim = "" Then
            '    MessageBox.Show("Debe proporcionar un lote de corte válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLote.Focus()
            '    Exit Function
            'End If

            'If Not IsNumeric(Me.txtLote.Text.Trim) Then
            '    MessageBox.Show("Debe proporcionar un lote de corte válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLote.Focus()
            '    Exit Function
            'End If

            If Not oIntroductor.Existe Then
                MessageBox.Show("Debe proporcionar un introductor válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaIntroductor.Focus()
                Exit Function
            End If

            If Not oDestino.Existe Then
                MessageBox.Show("Debe proporcionar un destino válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaDestino.Focus()
                Exit Function
            End If
            If Me.CHKMIXTO.Checked = True Then
                If CDec(Me.TXTCANTIDAD.Text) <> (CDec(Me.TXTHEMBRAS.Text) + CDec(Me.TXTMACHOS.Text)) Then
                    MessageBox.Show("La cantidad no coincide con la programacion")
                    Exit Function
                End If
            End If
            If Me.CHKHEMBRAS.Checked = True Then
                If CDec(Me.TXTCANTIDAD.Text) <> CDec(Me.TXTHEMBRAS.Text) Then
                    MessageBox.Show("La cantidad no coincide con la programacion")
                    Exit Function
                End If
            End If
            If Me.CHKMACHOS.Checked = True Then
                If CDec(Me.TXTCANTIDAD.Text) <> CDec(Me.TXTMACHOS.Text) Then
                    MessageBox.Show("La cantidad no coincide con la programacion")
                    Exit Function
                End If
            End If
            Return True
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function
    Private Sub cmbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecie.SelectedIndexChanged
        If Me.cmbEspecie.SelectedIndex < 0 Then
            oProducto = New clsProductos
        Else
            Me.cmbEspecie.Enabled = True
            oProducto = New clsProductos(Me.cmbEspecie.SelectedValue.ToString.Trim)
        End If
    End Sub
    Private Sub limpiar()
        Me.txtidsac.Clear()
        Me.TxtLote.Clear()
        Me.TXTCANTIDAD.Clear()
        Me.TXTHEMBRAS.Clear()
        Me.TXTMACHOS.Clear()
        Me.txtMarcaDestino.Clear()
        Me.txtMarcaIntroductor.Clear()
        Me.txtNomDestino.Clear()
        Me.txtNomIntroductor.Clear()
        Me.txtObservaciones.Clear()
        consecutivo()
        consecutivo_lote()
        Me.CHKHEMBRAS.Checked = False
        Me.CHKMACHOS.Checked = False
        Me.CHKMIXTO.Checked = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Me.consecutivo()
        Me.consecutivo_lote()
    End Sub

    Private Sub dtpFechaMov_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaMov.ValueChanged
        ' Me.SACRIFICIOTableAdapter.Fill(Me.DS_PROG_SACRI.SACRIFICIO, Me.dtpFechaMov.Value)
    End Sub

    'Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    Me.txtidsac.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).ID_SAC
    '    Me.TxtLote.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).SAC_LOTE
    '    Me.TXTCANTIDAD.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).CANTIDAD
    '    Me.TXTHEMBRAS.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).HEMBRAS
    '    Me.TXTMACHOS.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).MACHOS
    '    Me.cmbEspecie.SelectedValue = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).ID_ESPECIE
    '    Me.txtMarcaIntroductor.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).MARCA_CTE
    '    Me.txtMarcaDestino.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).MARCA_DEST
    '    Me.CHKMIXTO.Checked = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).BMIXTO
    '    Me.CHKHEMBRAS.Checked = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).BHEMBRAS
    '    Me.CHKMACHOS.Checked = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).BMACHOS
    '    Me.DespliegaCliente(2)
    '    Me.DespliegaCliente(3)
    'End Sub

    Private Sub CHKMIXTO_CheckedChanged(sender As Object, e As EventArgs) Handles CHKMIXTO.CheckedChanged
        If Me.CHKMIXTO.Checked = True Then
            Me.TXTHEMBRAS.Enabled = True
            Me.TXTMACHOS.Enabled = True
            Me.CHKHEMBRAS.Checked = False
            Me.CHKMACHOS.Checked = False

        Else
            Me.TXTHEMBRAS.Enabled = False
            Me.TXTMACHOS.Enabled = False
            Me.CHKHEMBRAS.Checked = False
            Me.CHKMACHOS.Checked = False
            Me.TXTHEMBRAS.Clear()
            Me.TXTMACHOS.Clear()
        End If
    End Sub

    Private Sub CHKMACHOS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKMACHOS.CheckedChanged
        If Me.CHKMACHOS.Checked = True Then
            Me.TXTMACHOS.Enabled = True
            Me.TXTHEMBRAS.Enabled = False
            Me.CHKMIXTO.Checked = False
            Me.CHKHEMBRAS.Checked = False
        Else
            Me.TXTMACHOS.Enabled = False
            Me.TXTHEMBRAS.Enabled = False
            Me.CHKMIXTO.Checked = False
            Me.CHKHEMBRAS.Checked = False
            Me.TXTHEMBRAS.Clear()
            Me.TXTMACHOS.Clear()
        End If
    End Sub

    Private Sub CHKHEMBRAS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKHEMBRAS.CheckedChanged
        If Me.CHKHEMBRAS.Checked = True Then
            Me.TXTMACHOS.Enabled = False
            Me.TXTHEMBRAS.Enabled = True
            Me.CHKMIXTO.Checked = False
            Me.CHKMACHOS.Checked = False
        Else
            Me.TXTMACHOS.Enabled = False
            Me.TXTHEMBRAS.Enabled = False
            Me.CHKMIXTO.Checked = False
            Me.CHKMACHOS.Checked = False
            Me.TXTHEMBRAS.Clear()
            Me.TXTMACHOS.Clear()
        End If
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim war As New frmWarning
        war.ShowDialog()
        If war.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Guardar()
        End If

    End Sub

  
    Private Sub BTNMINIMIZAR_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNMAXIMIZAR_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BTNCERRAR_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2

            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CancelaLote()
    End Sub
    Private Sub CancelaLote()
        Dim lCmd As New SqlClient.SqlCommand

        lCmd.Connection = Cnn
        lCmd.CommandType = CommandType.Text
        lCmd.CommandText = "UPDATE SACRIFICIO SET ESTADO_SAC = 0 WHERE SAC_LOTE=" & Me.TxtLote.Text

        Try

            lCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
        Dim os As New frmOrdenSacrificio
        os.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bus As New frmBusProveedor
        bus.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bus As New frmBusProveedor()
        bus.ShowDialog()
    End Sub
End Class