Imports System.Data
Imports System.Data.SqlClient
Public Class frmPROC_MERMA_GH
    Dim oEspecie As clsEspecies
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)

        End If
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

    Private Sub frmPROC_MERMA_GH_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                ' Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                'Me.Guardar()
        End Select
    End Sub

    Private Sub frmPROC_MERMA_GH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PORC_GRASA_HUESOTableAdapter.Connection.ConnectionString = Cnn.ConnectionString
        'TODO: esta línea de código carga datos en la tabla 'DsMERMA_GH.PORC_GRASA_HUESO' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.limpiar()
    End Sub
    Private Sub guardar()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim dt As New DataTable()
        'Dim lCodAlmacen As String

        '   Dim CON As New SqlConnection(ConnectionString)
        Try

            lSql = "SP_MERMA_HUESO_CARNE"


            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.StoredProcedure
            lCmd.CommandText = lSql

            lCmd.Parameters.AddWithValue("@op", 1)
            lCmd.Parameters.AddWithValue("@LOTE", Me.TXTLOTE.Text)
            lCmd.Parameters.AddWithValue("@FECHA", Me.dtpFechaMov.Value)
            lCmd.Parameters.AddWithValue("@ID_CTE", oIntroductor.ID_CLIENTE)
            lCmd.Parameters.AddWithValue("@PORCENTAJEGRASA", Me.TXTPORCENTAJEGRASA.Text)
            lCmd.Parameters.AddWithValue("@PORCENTAJECARNE", Me.TXTPROCENTAJECARNE.Text)
            lCmd.Parameters.AddWithValue("@TOTALPESOHUESO", Me.TXTPESOHUESO.Text)
            lCmd.Parameters.AddWithValue("@TOTALPESOCARNE", Me.TXTPESOCARNE.Text)
            lCmd.Parameters.AddWithValue("@TOTALPESOSINCARNE", Me.TXTHUESOSCARNE.Text)
            lCmd.Parameters.AddWithValue("@OBSERVACIONES", Me.txtObservaciones.Text)
            lCmd.Parameters.AddWithValue("@TOTALGRASA", Me.TXTPESOGRASA.Text)
            lCmd.Parameters.AddWithValue("@TOTALCARNESGRASA", Me.TXTPESOCARNESGRASA.Text)
            lCmd.Parameters.AddWithValue("@TOTALGRASASCARNE", Me.TXTGRASASCARNE.Text)

            lCmd.ExecuteNonQuery()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            MessageBox.Show("Sus datos se guardaron correctamente")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.guardar()
        Me.limpiar()
    End Sub
    Private Sub limpiar()
        Me.TXTLOTE.Clear()
        Me.txtMarcaIntroductor.Clear()
        Me.txtNomIntroductor.Clear()
        Me.TXTPORCENTAJEGRASA.Clear()
        Me.TXTPROCENTAJECARNE.Clear()
        Me.txtObservaciones.Clear()
        Me.TXTPESOCARNE.Clear()
        Me.TXTPESOCARNESGRASA.Clear()
        Me.TXTPESOGRASA.Clear()
        Me.TXTPESOHUESO.Clear()
        Me.TXTGRASASCARNE.Clear()
        Me.TXTHUESOSCARNE.Clear()
    End Sub

    Private Sub TXTLOTE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTLOTE.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TXTPESOHUESO.Focus()
        End If
    End Sub

    Private Sub TXTPESOCARNE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPESOCARNE.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TXTHUESOSCARNE.Focus()
        End If
    End Sub

    Private Sub TXTPESOHUESO_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPESOHUESO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TXTPESOCARNE.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pcarne As Double
        Dim pgrasa As Double
        pcarne = Format(((CDec(Me.TXTPESOCARNE.Text) / CDec(Me.TXTPESOHUESO.Text)) * 100), "#,##0.00")
        pgrasa = Format(((CDec(Me.TXTPESOCARNESGRASA.Text) / CDec(Me.TXTPESOGRASA.Text)) * 100), "#,##0.00")
        Me.TXTPROCENTAJECARNE.Text = pcarne
        Me.TXTPORCENTAJEGRASA.Text = pgrasa

    End Sub
End Class