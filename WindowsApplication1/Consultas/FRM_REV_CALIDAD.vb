Imports System.Data
Imports System.Data.SqlClient
Public Class FRM_REV_CALIDAD

    Private Sub FRM_REV_CALIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            'Dim lCodAlmacen As String
            Dim lID_MOV As Integer = 8 'ENTRADA GANADO EN PIE

            Me.DsSacrificio1.SP_REV_CALIDAD.Clear()

            lSql = "SP_REV_CALIDAD '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio1.SP_REV_CALIDAD)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        DespliegaDatos()
    End Sub
End Class