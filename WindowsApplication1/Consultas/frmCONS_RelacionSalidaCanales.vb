Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_RelacionSalidaCanales

    Dim oIntroductor As New clsCliente

    Private Sub frmCONS_RelacionSalidaCanales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.Buscar()
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
                lCodAlmacen = oIntroductor.ID_ALM_CAN
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_RELACION_SALIDA_CANALES 8, '" & lCodAlmacen & "', '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES)

            modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatos)
            modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos)

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

        ' frmCONSULTA_MOVIMIENTO.MdiParent = mdiPrincipal

        frmCONSULTA_MOVIMIENTO.DespliegaDatos(lID_ESC)

        frmCONSULTA_MOVIMIENTO.Show()
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub Imprimir()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptREP_RelacionSalidasCanal, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_ENTSAL_RELACION_SALIDA_CANALES"))
            miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"
            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
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
                lsTitulo = "CTE_RELSALCANALES_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
        End Select

        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()

    End Sub

    Public Sub RegresaBuscarCteIntroductor(ByVal aCodigo As String)
        Me.txtMarcaIntroductor.Text = aCodigo
        Call Me.DespliegaCliente(2)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub dtpFechaIni_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaIni.ValueChanged

    End Sub
End Class