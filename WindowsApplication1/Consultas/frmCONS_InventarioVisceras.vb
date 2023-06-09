
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_InventarioVisceras
    Dim oProducto As clsProductos
    Dim oEspecie As clsEspecies
    Dim oIntroductor As New clsCliente

    'Dim oCanal As clsMovimientoEntSal
    'Dim iPesadaManual As String

    Dim iPrimeraVez As Boolean = True

    Private Sub frmCONS_InventarioVisceras_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If iPrimeraVez Then
            'Me.cmbProductos.SelectedIndex = 0
            Me.cmbEspecie.SelectedIndex = 0
        End If
        iPrimeraVez = False

    End Sub

    Private Sub frmCONS_InventarioVisceras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                lsTitulo = "CTE_INVVISCERAS_INTRODUCTOR"
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

        oProducto = New clsProductos

        'Me.cmbProductos.Enabled = True
        'Me.cmbProductos.SelectedIndex = 0

        'Me.cmbEspecie.SelectedIndex = 0

        DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_VISCERAS.Clear()

    End Sub

    Private Sub frmCONS_InventarioVisceras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    'Private Sub CargaProductos()
    '    Try
    '        Dim lCmd As New SqlClient.SqlCommand
    '        Dim lSql As String
    '        Dim dt As New DataTable() 'GANADO EN CANAL

    '        lSql = "SP_CONS_PRODUCTOS '', '%', 1"

    '        lCmd.Connection = Cnn
    '        lCmd.CommandType = CommandType.Text
    '        lCmd.CommandText = lSql

    '        Dim da As New SqlDataAdapter(lCmd)
    '        da.Fill(dt)

    '        Me.cmbProductos.DataSource = dt
    '        Me.cmbProductos.DisplayMember = "NOMBRE"
    '        Me.cmbProductos.ValueMember = "ID_PROD"

    '        lCmd.Dispose()

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Me.DespliegaProducto()
    '    End If
    'End Sub

    'Private Sub DespliegaProducto()
    '    modFuncProc.DespliegaDescripcionProducto(Me.txtCodProd, Me.txtNomProd, oProducto)
    '    If oProducto.ID_PROD <> 0 Then
    '        If oProducto.ID_FAM <> 2 Then
    '            MessageBox.Show("El producto no pertenece a la familia de visceras.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            oProducto = New clsProductos(0)
    '            Me.txtCodProd.Text = ""
    '            Me.txtNomProd.Text = ""
    '        Else
    '            Me.numPiezas.Focus()
    '            'Me.txtCodProd.Enabled = False
    '            'Me.txtNomProd.Enabled = False
    '        End If
    '    End If
    'End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)

        'If Me.cmbProductos.SelectedIndex = -1 Then
        '    MessageBox.Show("Primero debe seleccionar un producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If

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
                lCodAlm = oIntroductor.ID_ALM_VIS.ToString
            End If

            oEspecie = New clsEspecies(Me.cmbEspecie.SelectedValue.ToString.Trim)

            lSql = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_VISCERAS '" & lCodAlm & "', '" & oEspecie.ID_ESPECIE.ToString & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_VISCERAS.Clear()
            da.Fill(DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_VISCERAS)

            da.Dispose()
            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    'Private Sub cmbProductos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedValueChanged
    '    If iPrimeraVez Then Exit Sub
    '    If Me.cmbProductos.SelectedIndex >= 0 Then
    '        'Me.cmbProductos.Enabled = False
    '        oProducto = New clsProductos(Me.cmbProductos.SelectedValue.ToString.Trim)
    '        Me.Limpiar()
    '    Else
    '        oProducto = New clsProductos
    '    End If
    'End Sub
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
        'If Me.cmbProductos.SelectedIndex < 0 Then
        '    MessageBox.Show("Debe seleccionar un producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    'Me.cmbProductos.Focus()
        '    Me.cmbEspecie.Focus()
        '    Exit Sub
        'End If

        If Me.cmbEspecie.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar una especie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.cmbProductos.Focus()
            Me.cmbEspecie.Focus()
            Exit Sub
        End If


        If Me.chkTodos.Checked Then
            Me.DespliegaDatos()
        Else
            If oIntroductor.ID_CLIENTE = 0 Then
                MessageBox.Show("Debe capturar un introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.DespliegaDatos()
            End If
        End If
    End Sub

End Class
