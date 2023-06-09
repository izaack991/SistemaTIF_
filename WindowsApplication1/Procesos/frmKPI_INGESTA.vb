Public Class frmKPI_INGESTA
    Dim oEspecie As clsEspecies
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Private Sub frmKPI_INGESTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_PCC1B.PCC1B' Puede moverla o quitarla según sea necesario.


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
        End Select

        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()

    End Sub

    Private Sub frmKPI_INGESTA_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                ' Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                'Me.Guardar()
        End Select
    End Sub
    Private Sub guardar()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim dt As New DataTable()
        'Dim lCodAlmacen As String

        '   Dim CON As New SqlConnection(ConnectionString)
        Try

            lSql = "SP_PCC1B"


            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.StoredProcedure
            lCmd.CommandText = lSql

            lCmd.Parameters.AddWithValue("@op", 1)
            lCmd.Parameters.AddWithValue("@LOTE", Me.TXTLOTE.Text)
            lCmd.Parameters.AddWithValue("@FECHA", Me.dtpFechaMov.Value)
            lCmd.Parameters.AddWithValue("@ID_CTE", oIntroductor.ID_CLIENTE)
            lCmd.Parameters.AddWithValue("@CANT_RESES_INGESTA", Val(Me.TXTCINGESTA.Text))
            lCmd.Parameters.AddWithValue("@CANT_RESES_HECES", Val(Me.TXTCHECES.Text))
            lCmd.Parameters.AddWithValue("@CANT_RECES_LECHE", Val(Me.TXTCLECHE.Text))
            lCmd.Parameters.AddWithValue("@OBSERVACIONES", Me.txtObservaciones.Text)

            lCmd.ExecuteNonQuery()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            MessageBox.Show("Sus datos se guardaron correctamente")
            Me.limpiar()
        End Try
    End Sub
    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
                Me.TXTLOTE.Focus()
                'If oDestino.ID_CLIENTE <> 0 Then
                'End If
        End Select
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.guardar()
    End Sub
    Private Sub limpiar()
        Me.txtMarcaIntroductor.Clear()
        Me.txtNomIntroductor.Clear()
        Me.TXTLOTE.Clear()
        Me.TXTCHECES.Clear()
        Me.TXTCINGESTA.Clear()
        Me.TXTCLECHE.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.limpiar()
    End Sub
End Class