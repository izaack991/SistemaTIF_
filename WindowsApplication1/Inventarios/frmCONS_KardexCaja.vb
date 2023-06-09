
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_KardexCaja
    Dim oIntroductor As New clsCliente

    Private Sub frmCONS_KardexCaja_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                'Me.Buscar()
        End Select
    End Sub

    'Private Sub Buscar()
    '    Dim lsTitulo As String = ""
    '    Dim lsCampoBusqueda As String = ""
    '    Dim liColumnaCodigo As Short

    '    Dim iBuscaSucursal As Boolean = False
    '    Dim iBuscaArea As Boolean = False
    '    Dim iBuscaProveedor As Boolean = False

    '    Dim lValor1 As String = ""
    '    Dim lValor2 As String = ""

    '    Select Case Me.ActiveControl.Name.TrimEnd.ToUpper
    '        Case "TXTMARCAINTRODUCTOR"
    '            lsTitulo = "CTE_CONSREGINV_INTRODUCTOR"
    '            lsCampoBusqueda = "NOMBRE"
    '            liColumnaCodigo = 2
    '    End Select

    '    Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

    '    frmBusqueda.ShowDialog()

    '    Me.BringToFront()

    '    frmBusqueda.Close()

    'End Sub

    'Public Sub RegresaBuscarCteIntroductor(ByVal aCodigo As String)
    '    Me.txtMarcaIntroductor.Text = aCodigo
    '    Call Me.DespliegaCliente(2)
    'End Sub

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas limpiar la pantalla?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()

        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""

        DsInventarios.SP_CONS_KARDEX_CAJA.Clear()

    End Sub

    'Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        DespliegaCliente(2)
    '    End If
    'End Sub

    'Private Sub DespliegaCliente(aOpcion As Integer)
    '    Select Case aOpcion
    '        Case 2
    '            modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
    '    End Select
    'End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        Me.Nuevo()
    End Sub

    Public Sub DespliegaDatos(Optional ByVal aCodAlm As String = "", Optional ByVal aFolio As String = "")
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            If Me.txtID.Text.Trim = "" Then
                MessageBox.Show("Debe proporcionar un ID de caja.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtID.Focus()
                Exit Sub
            End If


            'PROCEDURE SP_CONS_KARDEX_CAJA
            '@SERIE_ID	AS VARCHAR(7)

            lSql = "SP_CONS_KARDEX_CAJA '" & Me.txtID.Text.Trim & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)

            DsInventarios.SP_CONS_KARDEX_CAJA.Clear()
            da.Fill(DsInventarios.SP_CONS_KARDEX_CAJA)

            If Me.DsInventarios.SP_CONS_KARDEX_CAJA.Rows.Count > 0 Then
                Me.txtMarcaIntroductor.Text = Me.DsInventarios.SP_CONS_KARDEX_CAJA.Rows(0).Item("MARCA_CTE_INTR")
                Me.txtNomIntroductor.Text = Me.DsInventarios.SP_CONS_KARDEX_CAJA.Rows(0).Item("NOM_CTE_INTR")
            End If

            da.Dispose()
            lCmd.Dispose()


        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaDatos()
        End If
    End Sub

End Class
