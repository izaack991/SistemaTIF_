Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class frmCONS_RelacionCortes

    Dim oIntroductor As New clsCliente
    Dim oEspecie As clsEspecies
    Dim iPrimeraVez As Boolean = True
    Dim iMovto As Integer
    Dim bMejorado As Boolean
    Public Sub New(bMejorado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.bMejorado = bMejorado
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmCONS_RelacionCortes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If iPrimeraVez Then
            Me.cmbEspecie.SelectedIndex = 0
        End If
        iPrimeraVez = False
    End Sub
    Private Sub frmCONS_RelacionCortes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.Buscar()
            Case Keys.F5
                Me.DespliegaDatos()
        End Select
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If bMejorado = True Then
            DespliegaDatosM()
        Else
            Me.DespliegaDatos()
        End If
    End Sub
    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlmacen As String

            If Me.cmbEspecie.SelectedIndex = -1 Then
                MessageBox.Show("Primero debe seleccionar una especie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbEspecie.Focus()
                Exit Sub
            End If

            oEspecie = New clsEspecies(Me.cmbEspecie.SelectedValue.ToString.Trim)

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_CAJ
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_CORTES.Clear()

            lSql = "SP_CONS_CORTES 0, 0, '', " & oEspecie.ID_ESPECIE & ", '%', '%', '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "', '%'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_CORTES)

            modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatos)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub DespliegaDatosM()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlmacen As String

            If Me.cmbEspecie.SelectedIndex = -1 Then
                MessageBox.Show("Primero debe seleccionar una especie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbEspecie.Focus()
                Exit Sub
            End If

            oEspecie = New clsEspecies(Me.cmbEspecie.SelectedValue.ToString.Trim)

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_CAJ
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_CORTES.Clear()

            lSql = "SP_CONS_CORTES_MEJORADO 0, 0, '', " & oEspecie.ID_ESPECIE & ", '%', '%', '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "', '%'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_CORTES)
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

        If lID_ESC = 0 Then
            MessageBox.Show("Este corte no ha sido procesado todavía.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim frmCONSULTA_MOVIMIENTO As New frmCONS_Movimiento_EntSal(bMejorado)

        'frmCONSULTA_MOVIMIENTO.MdiParent = mdiPrincipal

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
            miReporte = CType(New crptREP_RelacionCortes, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_CORTES"))
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
                lsTitulo = "CTE_RELCORTES_INTRODUCTOR"
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
    Private Sub frmCONS_RelacionCortes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oEspecie = New clsEspecies()
        Me.CargarCombos()
    End Sub
    Private Sub CargarCombos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim daCatalogo2 As SqlClient.SqlDataAdapter
            Dim lSql As String
            lSql = "EXECUTE SP_CONS_ESPECIES"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_ESPECIES").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_ESPECIES")
            daCatalogo2.Dispose()
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ImprimirReporte()
    End Sub
    Private Sub ImprimirReporte()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim DsCajas As New DataSet

            Me.DsMovimientos.SP_VERIFICA_TRANSFERENCIA.Clear()
            lSql = "SP_VERIFICA_TRANSFERENCIA " & dgvDatos.CurrentRow.Cells(3).Value

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_VERIFICA_TRANSFERENCIA)

            lCmd.Dispose()

            If Me.DsMovimientos.SP_VERIFICA_TRANSFERENCIA.Rows.Count = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Me.DsMovimientos.SP_VERIFICA_CORTE.Clear()
            lSql = "SP_VERIFICA_CORTE " & dgvDatos.CurrentRow.Cells(3).Value
            lCmd.CommandText = lSql
            Dim da1 As New SqlDataAdapter(lCmd)
            da1.Fill(Me.DsMovimientos.SP_VERIFICA_CORTE)



            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crpt_VERICAR_CORTE, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsMovimientos.Tables("SP_VERIFICA_TRANSFERENCIA"))
            miReporte.Subreports(0).SetDataSource(Me.DsMovimientos.Tables("SP_VERIFICA_CORTE"))

            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class