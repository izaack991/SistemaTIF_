Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCONS_INVENTARIOXINTR

    Private Sub frmCONS_INVENTARIOXINTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCajas.SP_INVENTARIO_X_INTRODUCTOR' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.DespliegaDatos()
    End Sub
    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            'Dim lCodAlmacen As String
            Dim lID_MOV As Integer = 1 'ENTRADA GANADO EN PIE

            Me.DsCajas.SP_INVENTARIO_X_INTRODUCTOR.Clear()

            lSql = "SP_INVENTARIO_X_INTRODUCTOR"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsCajas.SP_INVENTARIO_X_INTRODUCTOR)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crpCONS_INVENTARIOCAJASXINTR, ReportDocument)

            If Me.DsCajas.SP_INVENTARIO_X_INTRODUCTOR.Rows.Count > 0 Then
                miReporte.SetDataSource(Me.DsCajas.Tables("SP_INVENTARIO_X_INTRODUCTOR"))


                Dim frmReporte As New frmCRViewer
                frmReporte.MdiParent = Me.ParentForm
                frmReporte.crViewer.ReportSource = miReporte
                Me.Cursor = Cursors.Default
                frmReporte.Show()

            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("No se encontró información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub
End Class