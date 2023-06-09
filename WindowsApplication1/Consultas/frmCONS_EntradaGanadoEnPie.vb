Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_EntradaGanadoEnPie

    Dim oIntroductor As New clsCliente


    Private Sub frmCONS_EntradaGanadoEnPie_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                Me.DespliegaDatos()
        End Select
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
            Dim lCodCte As String
            Dim lID_MOV As Integer = 1 'ENTRADA GANADO EN PIE

            If oIntroductor.Existe Then
                lCodCte = oIntroductor.ID_CLIENTE
            Else
                lCodCte = "%"
            End If

            Me.DsSacrificio.SP_CONS_ENTSAL_COBRANZA_CANAL.Clear()

            lSql = "SP_CONS_ENTSAL_COBRANZA_CANAL " & lID_MOV & ", '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "', '" & Me.cmbProductos.SelectedValue & "', '" & lCodCte & "' "

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_COBRANZA_CANAL)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                If oIntroductor.ID_CLIENTE <> 0 Then Me.dtpFechaIni.Focus()
        End Select
    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick
        'Me.ConsultaDetalle()
    End Sub

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Me.ConsultaDetalle()
        End If
    End Sub

    'Private Sub ConsultaDetalle()
    '    If Me.dgvDatos.RowCount = 0 Then
    '        Exit Sub
    '    End If

    '    Dim lID_ESC As String
    '    Dim lResp As Integer

    '    lResp = MessageBox.Show("¿Deseas abrir el detalle de este movimiento?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
    '    If lResp = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    lID_ESC = Me.dgvDatos.SelectedRows(0).Cells("ID_ESC").Value

    '    Dim frmCONSULTA_MOVIMIENTO As New frmCONS_Movimiento_EntSal

    '    frmCONSULTA_MOVIMIENTO.MdiParent = mdiPrincipal

    '    frmCONSULTA_MOVIMIENTO.DespliegaDatos(lID_ESC)

    '    frmCONSULTA_MOVIMIENTO.Show()
    'End Sub

    Private Sub frmCONS_EntradaGanadoEnPie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargaProductos()
    End Sub

    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "SP_CONS_PRODUCTOS '', '%', 3"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            Me.cmbProductos.DataSource = dt
            Me.cmbProductos.DisplayMember = "NOMBRE"
            Me.cmbProductos.ValueMember = "ID_PROD"

            lCmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCONS_Cobranza_GanadoPie, ReportDocument)

            If Me.DsSacrificio.SP_CONS_ENTSAL_COBRANZA_CANAL.Rows.Count > 0 Then
                miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_COBRANZA_CANAL"))
                miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

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

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.DespliegaDatos()
    End Sub

    Private Sub btnguardarlotefecha_Click(sender As Object, e As EventArgs) Handles btnguardarlotefecha.Click
        Me.Imprimir()
    End Sub
End Class