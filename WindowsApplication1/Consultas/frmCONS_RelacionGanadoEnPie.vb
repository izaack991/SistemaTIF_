Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_RelacionGanadoEnPie

    Dim oIntroductor As New clsCliente
    Private Sub frmCONS_RelacionGanadoEnPie_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                'Me.BUSCAR()
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
            Dim lCodAlmacen As String

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_GAN
            Else
                lCodAlmacen = "%"
            End If

            Me.DsSacrificio.SP_CONS_ENTSAL_GANADO_FECHA_ALMACEN.Clear()

            lSql = "SP_CONS_ENTSAL_GANADO_FECHA_ALMACEN '" & lCodAlmacen & "', 1, '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'" ', '" & Me.cmbProductos.SelectedValue & "' "

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_GANADO_FECHA_ALMACEN)

            modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatos)

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
        Me.ConsultaDetalle()
    End Sub

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ConsultaDetalle()
        End If
    End Sub

    Private Sub ConsultaDetalle()
        If Me.dgvDatos.RowCount = 0 Then
            Exit Sub
        End If

        Dim lID_ESC As String
        Dim lResp As Integer

        lResp = MessageBox.Show("¿Deseas abrir el detalle de este movimiento?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        lID_ESC = Me.dgvDatos.SelectedRows(0).Cells("ID_ESC").Value

        Dim frmCONSULTA_MOVIMIENTO As New frmCONS_Movimiento_EntSal(False)

        '  frmCONSULTA_MOVIMIENTO.MdiParent = mdiPrincipal

        frmCONSULTA_MOVIMIENTO.DespliegaDatos(lID_ESC)

        frmCONSULTA_MOVIMIENTO.Show()
    End Sub

    Private Sub frmCONS_RelacionGanadoEnPie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.ImprimirRendimiento()
    End Sub

    Private Sub ImprimirRendimiento()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim lFecha As String
            Dim lLote As String

            lFecha = Format(Me.dgvDatos.CurrentRow.Cells("FECHA").Value, "dd/MM/yyyy")
            lLote = Me.dgvDatos.CurrentRow.Cells("SAC_LOTE").Value

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_LOTE_FECHA_RENDIMIENTO.Clear()

            lSql = "SP_CONS_ENTSAL_ENCDET_X_LOTE_FECHA_RENDIMIENTO '" & lFecha & "', " & lLote

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_LOTE_FECHA_RENDIMIENTO)

            lCmd.Dispose()

            If Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_LOTE_FECHA_RENDIMIENTO.Rows.Count = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL.Clear()
            lSql = "SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL '" & lFecha & "', " & lLote
            lCmd.CommandText = lSql
            Dim da1 As New SqlDataAdapter(lCmd)
            da1.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL)

            'Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE.Clear()
            'lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE 1, '" & lFecha & "', " & lLote
            'lCmd.CommandText = lSql
            'Dim da1 As New SqlDataAdapter(lCmd)
            'da1.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE)

            'Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL.Clear()
            'lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL 2, '" & lFecha & "', " & lLote
            'lCmd.CommandText = lSql
            'Dim da2 As New SqlDataAdapter(lCmd)
            'da2.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL)

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_PIEL.Clear()
            lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_PIEL 3, '" & lFecha & "', " & lLote
            lCmd.CommandText = lSql
            Dim da3 As New SqlDataAdapter(lCmd)
            da3.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_PIEL)

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_VISCERAS.Clear()
            lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_VISCERAS '" & lFecha & "', " & lLote
            lCmd.CommandText = lSql
            Dim da4 As New SqlDataAdapter(lCmd)
            da4.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_VISCERAS)


            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptCONS_RendimientoSacrificio, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_LOTE_FECHA_RENDIMIENTO"))
            'miReporte.Subreports(1).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE"))
            'miReporte.Subreports(0).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL"))
            miReporte.Subreports(0).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL"))
            miReporte.Subreports(1).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_PIEL"))
            miReporte.Subreports(2).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_VISCERAS"))
            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub ImprimirRendimiento1()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim lFecha As String
            Dim lLote As String

            lFecha = Format(Me.dgvDatos.CurrentRow.Cells("FECHA").Value, "dd/MM/yyyy")
            lLote = Me.dgvDatos.CurrentRow.Cells("SAC_LOTE").Value

           

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

           
           

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL_RPT.Clear()
            lSql = "SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL_RPT '" & lFecha & "', " & lLote
            lCmd.CommandText = lSql
            Dim da1 As New SqlDataAdapter(lCmd)
            da1.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL_RPT)

          
            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crpt_CONS_DETALLADO_HORA, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_REND_PIE_CANAL_RPT"))
            'miReporte.Subreports(1).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE"))
            'miReporte.Subreports(0).SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL"))
           
            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImprimirRendimiento1()
    End Sub
End Class