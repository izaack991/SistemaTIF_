Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCAT_Clientes

    Dim oCliente As clsCliente
    Dim iPrimeraVez As Boolean = True
    Dim AnchoPantalla As Integer = My.Computer.Screen.Bounds.Width
    Dim AltoPantalla As Integer = My.Computer.Screen.WorkingArea.Height

    Private Sub frmCAT_Clientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        iPrimeraVez = False
    End Sub

    Private Sub frmCAT_Clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F4
                Me.Guardar()
            Case Keys.F7
                Me.Cancelar()
            Case Keys.F9
                Me.Imprimir()
        End Select
    End Sub

    Private Sub frmCAT_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosIniciales()
        With Me

            .Location = New Point(x:=0, y:=0)
            .Height = AltoPantalla
            .Width = AnchoPantalla
            Me.WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Guardar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Cancelar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Function ValidaDatos() As Boolean

        If Me.txtMarcaCliente.Text = "" Then
            MessageBox.Show("Debe proporcionar la marca del cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtMarcaCliente.Focus()
            Return False
        End If
        If Me.txtNomCliente.Text = "" Then
            MessageBox.Show("Debe proporcionar el nombre del cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtMarcaCliente.Focus()
            Return False
        End If
        If Me.cmbTipoCliente.SelectedIndex < 0 Then
            MessageBox.Show("Debe proporcionar el tipo de cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbTipoCliente.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub Guardar()
        Try
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lCliente As Integer = 0

            lResp = MessageBox.Show("¿Deseas guardar los datos del cliente?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not Me.ValidaDatos() Then Exit Sub

            If oCliente.ID_CLIENTE = 0 Then
                lOperacion = "A"
            Else
                lOperacion = "M"
            End If

            oCliente.Operacion = lOperacion
            oCliente.Marca = Me.txtMarcaCliente.Text.Trim
            oCliente.Nombre = Me.txtNomCliente.Text.Trim
            oCliente.ID_Tipo_Cliente = Me.cmbTipoCliente.SelectedValue
            oCliente.Direccion = Me.txtDireccion.Text.Trim
            oCliente.Colonia = Me.txtColonia.Text.Trim
            oCliente.Municipio = Me.txtMunicipio.Text.Trim
            oCliente.Estado = Me.txtEstado.Text.Trim
            oCliente.Email = Me.txtEmail.Text.Trim
            oCliente.Telefono = Me.txtTelefono.Text.Trim
            oCliente.Celular = Me.txtCelular.Text.Trim
            oCliente.CP = Me.txtCP.Text.Trim
            oCliente.RFC = Me.txtRFC.Text.Trim

            oCliente.Guardar(lMensajeResultado, lCliente)

            If lCliente <> 0 Then
                Me.MostrarDatos()
                Me.DespliegaCliente(lCliente)
            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas capturar un cliente nuevo?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            Me.txtMarcaCliente.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub Cancelar()
        Try
            Dim lCliente As Integer = 0

            If oCliente.ID_CLIENTE = 0 Then
                MessageBox.Show("Debes proprcionar un cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lResp As Integer
            Dim lMensajeResultado As String = ""

            lResp = MessageBox.Show("¿Deseas cancelar este cliente?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            oCliente.Operacion = "C"

            oCliente.Guardar(lMensajeResultado, lCliente)

            If lCliente <> 0 Then
                Me.MostrarDatos()
                Me.DespliegaCliente(lCliente)
            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing
        Dim dtReporte As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCAT_Clientes, ReportDocument)

            Dim oClienteCatalogo As New clsCliente(0)
            dtReporte = oClienteCatalogo.CatalogoClientes
            If dtReporte.Rows.Count > 0 Then
                miReporte.SetDataSource(dtReporte)
                Dim frmReporte As New frmCRViewer
                frmReporte.MdiParent = Me.ParentForm
                frmReporte.crViewer.ReportSource = miReporte
                Me.Cursor = Cursors.Default
                frmReporte.WindowState = FormWindowState.Maximized
                frmReporte.Show()
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("No se encontro información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarDatosIniciales()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo2 As SqlClient.SqlDataAdapter
            Dim lSql As String

            oCliente = New clsCliente(0)

            lSql = "EXECUTE SP_CONS_TIPOS_CLIENTE"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_TIPOS_CLIENTE").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_TIPOS_CLIENTE")

            daCatalogo2.Dispose()

            Me.MostrarDatos()

            Me.cmbTipoCliente.SelectedIndex = -1

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MostrarDatos()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim oClienteCatalogo As New clsCliente(0)

            Me.dgvCatalogo.DataSource = oClienteCatalogo.CatalogoClientes

            Me.FormatoGrid()

            Me.dgvCatalogo.ClearSelection()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgvCatalogo_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo.RowEnter
        If iPrimeraVez Then Exit Sub
        If Me.dgvCatalogo.RowCount > 0 Then
            Me.DespliegaCliente(Me.dgvCatalogo.Rows(e.RowIndex).Cells("id_cte").Value)
        End If
    End Sub

    Private Sub FormatoGrid()
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvCatalogo)
    End Sub
    Private Sub DespliegaCliente(aID_Cliente As Integer)
        Try
            oCliente = New clsCliente(aID_Cliente, "")

            If oCliente.ID_CLIENTE <> 0 Then
                Me.txtMarcaCliente.Text = oCliente.Marca
                Me.txtNomCliente.Text = oCliente.Nombre
                Me.cmbTipoCliente.SelectedValue = oCliente.ID_Tipo_Cliente
                Me.txtDireccion.Text = oCliente.Direccion
                Me.txtColonia.Text = oCliente.Colonia
                Me.txtCP.Text = oCliente.CP
                Me.txtMunicipio.Text = oCliente.Municipio
                Me.txtEstado.Text = oCliente.Estado
                Me.txtEmail.Text = oCliente.Email
                Me.txtTelefono.Text = oCliente.Telefono
                Me.txtCelular.Text = oCliente.Celular
                Me.txtRFC.Text = oCliente.RFC

                modFuncProc.Label_Cancelado(Me.lblEstatus, oCliente.Estatus)

                'Select Case oCliente.Estatus
                '    Case "C"
                '        Me.lblEstatus.BackColor = Color.Red
                '        Me.lblEstatus.ForeColor = Color.Yellow
                '        Me.lblEstatus.Text = "CANCELADA"
                '    Case "A"
                '        Me.lblEstatus.BackColor = Color.LawnGreen
                '        Me.lblEstatus.ForeColor = Color.Black
                '        Me.lblEstatus.Text = "ACTIVA"
                '        'Me.txtMarcaProductor.ReadOnly = True
                '        'Me.txtMarcaIntroductor.ReadOnly = True
                '        'Case "S"
                '        '    Me.lblEstatus.BackColor = Color.Navy
                '        '    Me.lblEstatus.ForeColor = Color.White
                '        '    Me.lblEstatus.Text = "CERRADA"
                '    Case Else
                '        Me.lblEstatus.BackColor = Color.Red
                '        Me.lblEstatus.ForeColor = Color.Yellow
                '        Me.lblEstatus.Text = "NO ESPECIFICADO"
                'End Select

            Else
                Me.Limpiar()
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub Limpiar()
        Me.txtMarcaCliente.Text = ""
        Me.txtNomCliente.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtColonia.Text = ""
        Me.txtMunicipio.Text = ""
        Me.txtEstado.Text = ""
        Me.txtEmail.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtCelular.Text = ""
        Me.txtRFC.Text = ""
        Me.txtCP.Text = ""
        Me.cmbTipoCliente.SelectedIndex = -1
        Me.dgvCatalogo.ClearSelection()

        oCliente = New clsCliente(0)

        'For Each c As Control In Me.Controls
        '    If TypeOf (c) Is TextBox Then
        '        MessageBox.Show(c.Name)
        '        c.Text = ""
        '    End If
        'Next
    End Sub

    Private Sub txtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnTnuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub BtnTguardar_Click(sender As Object, e As EventArgs) Handles BtnTguardar.Click
        Me.Guardar()
    End Sub

    Private Sub BtnTcancelar_Click(sender As Object, e As EventArgs) Handles BtnTcancelar.Click
        Me.Cancelar()
    End Sub

    Private Sub BtnTimprimir_Click(sender As Object, e As EventArgs) Handles BtnTimprimir.Click
        Me.Imprimir()
    End Sub
End Class