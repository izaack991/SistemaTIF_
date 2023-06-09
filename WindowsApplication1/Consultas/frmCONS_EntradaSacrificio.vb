Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_EntradaSacrificio

    Dim oIntroductor As New clsCliente
    Dim iCorte As Integer

    Dim lID_MOV As Integer = 2


    Private Sub frmCONS_EntradaSacrificio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
            'Dim lCodAlmacen As String
            Dim lCodCte As String
            'ENTRADA CANALES POR SACRIFICIO

            If oIntroductor.Existe Then
                lCodCte = oIntroductor.ID_CLIENTE
            Else
                lCodCte = "%"
            End If

            Me.DsSacrificio.SP_CONS_ENTSAL_COBRANZA_CANAL.Clear()


            lSql = "SP_CONS_ENTSAL_COBRANZA_CANAL " & lID_MOV & ", '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "', '" & Me.cmbProductos.SelectedValue & "', '" & lCodCte & "'" & ",'A'," & "'" & Me.iCorte & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_COBRANZA_CANAL)

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
        ' Me.ConsultaDetalle()
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

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frmCONS_EntradaSacrificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargaProductos()
    End Sub

    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "SP_CONS_PRODUCTOS '', '%', 1"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            Me.cmbProductos.DataSource = dt
            Me.cmbProductos.DisplayMember = "NOMBRE"
            Me.cmbProductos.ValueMember = "ID_PROD"

            lCmd.Dispose()

            'Me.cmbProductos.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir(1)
    End Sub
    Private Sub btnImprimir2_Click(sender As Object, e As EventArgs) Handles btnImprimir2.Click
        Me.Imprimir(2)
    End Sub

    Private Sub Imprimir(Optional aOpcion As Integer = 1)
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            If aOpcion = 1 Then
                'cobranza
                miReporte = CType(New crptCONS_Cobranza_Canales, ReportDocument)
               
            End If
            If aOpcion = 2 Then
                'rendimientos
                miReporte = CType(New crptCONS_Canales_Entrada, ReportDocument)
               
            End If
            If aOpcion = 3 Then
                'cobranza grafico
                miReporte = CType(New crptGraficaSacrificio, ReportDocument)
               
            End If
            If Me.DsSacrificio.SP_CONS_ENTSAL_COBRANZA_CANAL.Rows.Count > 0 Then
                miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_COBRANZA_CANAL"))
                If Me.chkcorte.Checked Then
                    miReporte.DataDefinition.FormulaFields("TIPO_RESUMEN").Text = "'RESUMEN DE CANALES A CORTE'"
                    miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"
                Else
                    miReporte.DataDefinition.FormulaFields("TIPO_RESUMEN").Text = "'RESUMEN DE SACRIFICIO'"
                    miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"
                End If


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
                lsTitulo = "CTE_RELENTCANALES_INTRODUCTOR"
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


    Private Sub btnimprimir3_Click(sender As Object, e As EventArgs) Handles btnimprimir3.Click
        Imprimir(3)
    End Sub

    Private Sub chkcorte_CheckedChanged(sender As Object, e As EventArgs) Handles chkcorte.CheckedChanged
        If Me.chkcorte.Checked = True Then
            iCorte = 1
            Me.lID_MOV = 8
        Else
            iCorte = Nothing
            Me.lID_MOV = 2
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.DespliegaDatos()
    End Sub

    Private Sub GroupBox2_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox2.Paint
        ' Establecemos el color del borde
        '
        Dim borderColor As Color = Color.White

        ' Referenciamos el control GroupBox
        '
        Dim gb As GroupBox = DirectCast(sender, GroupBox)

        Dim tSize As Size = _
           TextRenderer.MeasureText(gb.Text, gb.Font)

        Dim borderRect As Rectangle = e.ClipRectangle
        borderRect.Y = CInt((borderRect.Y + (tSize.Height / 2)))
        borderRect.Height = _
           CInt((borderRect.Height - (tSize.Height / 2)))
        ControlPaint.DrawBorder(e.Graphics, borderRect, _
                                borderColor, ButtonBorderStyle.Solid)

        Dim textRect As Rectangle = e.ClipRectangle
        textRect.X = (textRect.X + 6)
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height

        e.Graphics.FillRectangle( _
           New SolidBrush(gb.BackColor), textRect)

        e.Graphics.DrawString( _
           gb.Text, gb.Font, New SolidBrush(gb.ForeColor), textRect)
    End Sub
End Class