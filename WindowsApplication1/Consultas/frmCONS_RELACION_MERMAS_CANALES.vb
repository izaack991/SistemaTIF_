Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCONS_RELACION_MERMAS_CANALES

    Private Sub frmCONS_RELACION_MERMAS_CANALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            'Dim lCodAlmacen As String
            Dim lID_MOV As Integer = 8 'ENTRADA GANADO EN PIE

            Me.DsSacrificio.SP_RELACION_DE_MERMAS_CANALES.Clear()

            lSql = "SP_RELACION_DE_MERMAS_CANALES " & lID_MOV & ", '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_RELACION_DE_MERMAS_CANALES)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.DespliegaDatos()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub
    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crpCONS_REL_MERMA_CANALES, ReportDocument)

            If Me.DsSacrificio.SP_RELACION_DE_MERMAS_CANALES.Rows.Count > 0 Then
                miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_RELACION_DE_MERMAS_CANALES"))
                '    miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

                Dim frmReporte As New frmCRViewer
                frmReporte.MdiParent = Me.ParentForm
                frmReporte.crViewer.ReportSource = miReporte
                Me.Cursor = Cursors.Default
                frmReporte.WindowState = FormWindowState.Maximized
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
End Class