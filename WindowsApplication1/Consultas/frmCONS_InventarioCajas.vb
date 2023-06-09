
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_InventarioCajas
    Dim oProducto As clsProductos
    Dim oEspecie As clsEspecies
    Dim oIntroductor As New clsCliente

    'Dim oCanal As clsMovimientoEntSal
    'Dim iPesadaManual As String

    Dim iPrimeraVez As Boolean = True

    Private Sub frmCONS_InventarioCajas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If iPrimeraVez Then
            'Me.cmbProductos.SelectedIndex = 0
            Me.cmbEspecie.SelectedIndex = 0
        End If
        iPrimeraVez = False

    End Sub

    Private Sub frmCONS_InventarioCajas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
                'Case Keys.F4
                '    Me.Guardar()
                'Case Keys.F5
                '    Me.Pesar()
                'Case Keys.F6
                '    Me.AgregarCanal()
                'Case Keys.F7
                '    'Me.Cancelar()
                'Case Keys.F9
                '    'Me.Imprimir()
        End Select
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
                lsTitulo = "CTE_INVCAJAS_INTRODUCTOR"
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

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas limpiar la pantalla?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            'Me.cmbProductos.Focus()
            Me.cmbEspecie.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()
        
        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""
        Me.txtTotCajas.Text = ""

        oProducto = New clsProductos

        'Me.cmbProductos.Enabled = True
        'Me.cmbProductos.SelectedIndex = 0

        'Me.cmbEspecie.SelectedIndex = 0

        DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Clear()
        DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN.Clear()

    End Sub

    Private Sub frmCONS_InventarioCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)

        If Me.cmbEspecie.SelectedIndex = -1 Then
            MessageBox.Show("Primero debe seleccionar una especie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Select Case aOpcion
            Case 2

                'Me.cmbProductos.Enabled = False

                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                If oIntroductor.ID_CLIENTE <> 0 Then
                    Me.chkTodos.Checked = False
                    Me.llenaralmacenorigen()
                    Me.Actualizar()
                End If
        End Select
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        Me.Nuevo()
    End Sub

    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlm As String

            '@ID_MOV	INTEGER,
            '@ID_ALM	INTEGER,
            '@ID_PROD	CHAR(6),
            '@ESTATUS	CHAR(1)	= 'A',
            '@PROCESADO	CHAR(1) = 'N'

            If Me.chkTodos.Checked Then
                lCodAlm = "%"
            Else
                lCodAlm = oIntroductor.ID_ALM_CAJ.ToString
            End If

            oEspecie = New clsEspecies(Me.cmbEspecie.SelectedValue.ToString.Trim)

            lSql = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS '" & cmbalmori.SelectedValue.ToString & "', " & oEspecie.ID_ESPECIE.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Clear()
            da.Fill(DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS)

            lSql = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN '" & cmbalmori.SelectedValue.ToString & "', " & oEspecie.ID_ESPECIE.ToString
            lCmd.CommandText = lSql

            Dim da2 As New SqlDataAdapter(lCmd)
            DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN.Clear()
            da2.Fill(DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN)

            da.Dispose()
            lCmd.Dispose()

            Me.txtTotCajas.Text = Me.dgvDisponibles.RowCount


        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub cmbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecie.SelectedIndexChanged
        If iPrimeraVez Then Exit Sub
        If Me.cmbEspecie.SelectedIndex >= 0 Then
            'oEspecie = New clsEspecies(Me.cmbEspecie.SelectedValue.ToString.Trim)
            Me.Limpiar()
        Else
            oEspecie = New clsEspecies()
        End If
    End Sub

    Private Sub Imprimir(aID_MOV As Integer, aID_ALM As Integer, aFolio As Integer)
        'Try
        '    Me.Cursor = Cursors.WaitCursor

        '    Dim lCmd As New SqlClient.SqlCommand
        '    Dim lSql As String

        '    Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES.Clear()

        '    lSql = "EXECUTE SP_CONS_ENTSAL_SALIDA_CANALES " & aID_MOV & ", " & aID_ALM & ", " & aFolio

        '    lCmd.Connection = Cnn
        '    lCmd.CommandType = CommandType.Text
        '    lCmd.CommandText = lSql

        '    Dim da As New SqlDataAdapter(lCmd)
        '    da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES)

        '    lCmd.Dispose()

        '    If Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES.Rows.Count = 0 Then
        '        MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If

        '    Dim miReporte As ReportDocument = Nothing
        '    miReporte = CType(New crptREP_SalidaDeCanales, ReportDocument)

        '    Dim frmReporte As New frmCRViewer
        '    frmReporte.MdiParent = Me.ParentForm
        '    frmReporte.crViewer.ReportSource = miReporte

        '    miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_SALIDA_CANALES"))

        '    frmReporte.Show()

        'Catch ex As Exception
        '    Call modGeneral.ManejaExcepcion(ex)
        'Finally
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Me.Actualizar()
    End Sub

    Private Sub Actualizar()
        
        If Me.cmbEspecie.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar una especie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbEspecie.Focus()
            Exit Sub
        End If

        'If Me.chkTodos.Checked Then
        '    Me.DespliegaDatos()
        'Else
        If oIntroductor.ID_CLIENTE = 0 Then
            MessageBox.Show("Debe capturar un introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtMarcaIntroductor.Focus()
        Else
            Me.DespliegaDatos()
        End If
        'End If
    End Sub
    Private Sub llenaralmacenorigen()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim dt As New DataTable()
        Dim dsalmacenes As New DataSet
        Dim Da As New SqlDataAdapter

        lCmd.Connection = Cnn

        With lCmd
            .CommandType = CommandType.Text
            .CommandText = "Select * From ALMACENES WHERE NOMBRE LIKE '%CAJAS%' AND ID_CTE=" & oIntroductor.ID_CLIENTE
            .Connection = Cnn
        End With
        Da.SelectCommand = lCmd
        dt = New DataTable
        Da.Fill(dt)
        With Me.cmbalmori
            .DataSource = dt
            .DisplayMember = "NOMBRE"
            .ValueMember = "ID_ALM"
        End With

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub btnImprimir2_Click(sender As Object, e As EventArgs) Handles btnImprimir2.Click
        Me.Imprimir(2)
    End Sub

    Private Sub Imprimir(Optional aOpcion As Integer = 1)
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            If aOpcion = 1 Then
                'detalle
                If Me.DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Rows.Count > 0 Then
                    miReporte = CType(New crptINV_Cajas, ReportDocument)
                    miReporte.SetDataSource(Me.DsCajas.Tables("SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS"))
                Else
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("No se encontró información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


            Else
                'resumen
                If Me.DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN.Rows.Count > 0 Then
                    miReporte = CType(New crptINV_Cajas_Resumen, ReportDocument)
                    miReporte.SetDataSource(Me.DsCajas.Tables("SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS_RESUMEN"))
                Else
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("No se encontró información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            Me.Cursor = Cursors.Default
            frmReporte.WindowState = FormWindowState.Maximized
            frmReporte.Show()


        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbalmori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbalmori.SelectedIndexChanged
        DespliegaDatos()
    End Sub
End Class
