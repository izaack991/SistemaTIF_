Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmPedidos

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Imprimir()
    End Sub
    Private Sub Imprimir()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim lFecha As String

            Me.DsCajas.sp_pedidos_consulta.Clear()

            lSql = "sp_pedidos_consulta '" & dtpFechaIni.Value.Date & "','" & Me.dtpFechaIni.Value.Date & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsCajas.sp_pedidos_consulta)

            lCmd.Dispose()

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptPedidos, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsCajas.Tables("sp_pedidos_consulta"))
           
            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class