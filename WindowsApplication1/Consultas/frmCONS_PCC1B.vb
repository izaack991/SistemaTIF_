Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmCONS_PCC1B
    Dim oIntroductor As New clsCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Imprimir()
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

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCONS_PCC1B, ReportDocument)

            If Me.DsSacrificio.SP_CONS_PCC1B.Rows.Count > 0 Then
                miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_PCC1B"))


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
    Private Sub Imprimirgrafico()
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptSUB_CONS_PCC1B, ReportDocument)

            If Me.DsSacrificio.SP_CONS_PCC1B.Rows.Count > 0 Then
                miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_PCC1B"))


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
    Private Sub DespliegaDatos(OP As Integer)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            'Dim lCodAlmacen As String
            Dim lID_MOV As Integer = 8 'ENTRADA GANADO EN PIE

            Me.DsSacrificio.SP_CONS_PCC1B.Clear()
            If OP = 1 Then
                lSql = "SP_CONS_PCC1B " & OP & ",'" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"
            Else
                lSql = "SP_CONS_PCC1B " & OP & ",'" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'," & oIntroductor.ID_CLIENTE

            End If

            
            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_PCC1B)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.txtMarcaIntroductor.Text <> "" Then
            Me.DespliegaDatos(2)
        Else
            Me.DespliegaDatos(1)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Imprimirgrafico()
    End Sub

    Private Sub frmCONS_PCC1B_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()

                'If oDestino.ID_CLIENTE <> 0 Then
                'End If
        End Select
    End Sub

    Private Sub frmCONS_PCC1B_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                ' Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                'Me.Guardar()
        End Select
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
        End If
    End Sub
End Class