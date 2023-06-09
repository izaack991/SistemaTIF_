Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_RelacionInventarios

    Dim oIntroductor As New clsCliente


    Private Sub frmCONS_RelacionInventarios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

            If oIntroductor.ID_CLIENTE = 0 Then
                MessageBox.Show("Debe capturar un introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaIntroductor.Focus()
                Exit Sub
            End If

            lCodAlmacen = oIntroductor.ID_ALM_CAJ

            Me.DsInventarios.SP_CONS_RELACION_REGISTRO_INVENTARIOS.Clear()

            lSql = "SP_CONS_RELACION_REGISTRO_INVENTARIOS '" & lCodAlmacen & "', '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "', '%'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsInventarios.SP_CONS_RELACION_REGISTRO_INVENTARIOS)

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

        Dim lIDAlm As String
        Dim lFolio As String
        Dim lResp As Integer

        lResp = MessageBox.Show("¿Deseas abrir el detalle de este movimiento?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        lIDAlm = oIntroductor.ID_ALM_CAJ
        lFolio = Me.dgvDatos.SelectedRows(0).Cells("FOLIO").Value

        Dim frmCONS_RegistroInventario As New frmCONS_RegistroInventario

        frmCONS_RegistroInventario.MdiParent = mdiPrincipal

        frmCONS_RegistroInventario.DespliegaDatos(lIDAlm, lFolio)

        frmCONS_RegistroInventario.Show()
    End Sub

    'Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
    '    Me.Imprimir()
    'End Sub

    'Private Sub Imprimir()
    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        If Me.dgvDatos.RowCount = 0 Then
    '            MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If

    '        Dim miReporte As ReportDocument = Nothing
    '        miReporte = CType(New crptREP_RelacionSalidasCajas, ReportDocument)

    '        Dim frmReporte As New frmCRViewer
    '        frmReporte.MdiParent = Me.ParentForm
    '        frmReporte.crViewer.ReportSource = miReporte

    '        miReporte.SetDataSource(Me.dsInventarios.Tables("SP_CONS_RELACION_REGISTRO_INVENTARIOS"))
    '        miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"
    '        frmReporte.Show()

    '    Catch ex As Exception
    '        Call modGeneral.ManejaExcepcion(ex)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
   
End Class