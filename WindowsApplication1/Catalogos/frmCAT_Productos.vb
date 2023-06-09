Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCAT_Productos

    Dim oProducto As clsProductos
    Dim iPrimeraVez As Boolean = True

    Private Sub frmCAT_Clientes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        iPrimeraVez = False
    End Sub

    Private Sub frmCAT_Clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F4
                Me.Guardar()
            Case Keys.F7
                Me.Cancelar()
            Case Keys.F9
                Me.Imprimir()
        End Select
    End Sub

    Private Sub frmCAT_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosIniciales()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Guardar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Cancelar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Function ValidaDatos() As Boolean
        If Me.txtNomProd.Text = "" Then
            MessageBox.Show("Debe proporcionar el nombre del producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCodProd.Focus()
            Return False
        End If
        If Me.cmbRefrigeracion.SelectedIndex < 0 Then
            MessageBox.Show("Debe proporcionar el tipo de refrigeración del producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbEspecie.Focus()
            Return False
        End If
        If Me.cmbEspecie.SelectedIndex < 0 Then
            MessageBox.Show("Debe proporcionar la especie del producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbEspecie.Focus()
            Return False
        End If
        If Me.cmbFamilia.SelectedIndex < 0 Then
            MessageBox.Show("Debe proporcionar la familia del producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbFamilia.Focus()
            Return False
        End If
        If Me.cmbFamilia.SelectedValue = 5 Then 'FAMILIA DE CORTES
            MessageBox.Show("Para dar de alta productos de la familia de cortes debe ingresar a la opción de productos por cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbFamilia.Focus()
            Return False
        End If
        If Me.cmbSubfamilia.SelectedIndex < 0 Then
            MessageBox.Show("Debe proporcionar la subfamilia del producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbSubfamilia.Focus()
            Return False
        End If
        If Me.cmbCuarto.SelectedIndex < 0 Then
            MessageBox.Show("Debe proporcionar el cuarto al que pertenece el producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.cmbCuarto.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Guardar()
        Try
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lProd As String = ""

            lResp = MessageBox.Show("¿Deseas guardar los datos del producto?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not Me.ValidaDatos() Then Exit Sub

            If Not oProducto.Existe Then
                lOperacion = "A"
            Else
                lOperacion = "M"
            End If

            oProducto.Operacion = lOperacion
            oProducto.NOMBRE = Me.txtNomProd.Text.Trim.ToUpper
            oProducto.DIAS_CADUCIDAD = Me.numDiasCaducidad.Value
            oProducto.ID_REF = Me.cmbRefrigeracion.SelectedValue
            oProducto.ID_ESPECIE = Me.cmbEspecie.SelectedValue
            oProducto.ID_FAM = Me.cmbFamilia.SelectedValue
            oProducto.ID_SFAM = Me.cmbSubfamilia.SelectedValue
            oProducto.ID_CUARTO = Me.cmbCuarto.SelectedValue
            oProducto.ID_CEXP = Me.cmbClasifExp.SelectedValue

            oProducto.Guardar(lMensajeResultado, lProd)

            If lProd <> "" Then
                Me.MostrarDatos()
                Me.DespliegaDatos(lProd)
            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas capturar un producto nuevo?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            Me.txtCodProd.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Cancelar()
        Try
            Dim lProducto As String = ""

            If Not oProducto.Existe Then
                MessageBox.Show("Debes proprcionar un producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lResp As Integer
            Dim lMensajeResultado As String = ""

            lResp = MessageBox.Show("¿Deseas cancelar este producto?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            oProducto.Operacion = "C"

            oProducto.Guardar(lMensajeResultado, lProducto)

            If lProducto <> 0 Then
                Me.MostrarDatos()
                Me.DespliegaDatos(lProducto)
            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing
        Dim dtReporte As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCAT_Productos, ReportDocument)

            Dim oProductoCatalogo As New clsProductos
            dtReporte = oProductoCatalogo.Catalogo
            If dtReporte.Rows.Count > 0 Then
                miReporte.SetDataSource(dtReporte)
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

    Private Sub CargarDatosIniciales()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo2 As SqlClient.SqlDataAdapter
            Dim lSql As String

            oProducto = New clsProductos

            lSql = "EXECUTE SP_CONS_REFRIGERACION"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_REFRIGERACION").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_REFRIGERACION")

            daCatalogo2.Dispose()

            lSql = "EXECUTE SP_CONS_ESPECIES"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_ESPECIES").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_ESPECIES")

            daCatalogo2.Dispose()

            lSql = "EXECUTE SP_CONS_FAMILIAS"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_FAMILIAS").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_FAMILIAS")

            daCatalogo2.Dispose()

            lSql = "EXECUTE SP_CONS_CUARTOS"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_CUARTOS").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_CUARTOS")

            daCatalogo2.Dispose()

            lSql = "EXECUTE SP_CONS_CLASIFICACION_EXP"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_CLASIFICACION_EXP").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_CLASIFICACION_EXP")

            daCatalogo2.Dispose()

            Me.Limpiar()

            Me.MostrarDatos()

            Me.cmbEspecie.SelectedIndex = -1
            Me.cmbCuarto.SelectedIndex = -1

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MostrarDatos()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim oProducto As New clsProductos

            Me.dgvCatalogo.DataSource = oProducto.Catalogo(, , , , , , "%")

            Me.FormatoGrid()

            Me.dgvCatalogo.ClearSelection()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgvCatalogo_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo.RowEnter
        If iPrimeraVez Then Exit Sub
        If Me.dgvCatalogo.RowCount > 0 Then
            Me.DespliegaDatos(Me.dgvCatalogo.Rows(e.RowIndex).Cells("ID_PROD").Value)
        End If
    End Sub

    Private Sub FormatoGrid()
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvCatalogo)
    End Sub
    Private Sub DespliegaDatos(aID As String)
        Try
            oProducto = New clsProductos(aID)

            If oProducto.ID_PROD <> "" Then
                Me.txtCodProd.Text = oProducto.ID_PROD
                Me.txtNomProd.Text = oProducto.NOMBRE
                Me.cmbEspecie.SelectedValue = oProducto.ID_ESPECIE
                Me.cmbFamilia.SelectedValue = oProducto.ID_FAM
                Me.Cargar_Subfamilia()
                Me.cmbSubfamilia.SelectedValue = oProducto.ID_SFAM
                Me.cmbCuarto.SelectedValue = oProducto.ID_CUARTO
                Me.cmbClasifExp.SelectedValue = oProducto.ID_CEXP
                Me.cmbRefrigeracion.SelectedValue = oProducto.ID_REF
                Me.numDiasCaducidad.Value = oProducto.DIAS_CADUCIDAD

                modFuncProc.Label_Cancelado(Me.lblEstatus, oProducto.ESTATUS)

            Else
                Me.Limpiar()
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub Limpiar()
        Me.txtCodProd.Text = ""
        Me.txtNomProd.Text = ""
        Me.numDiasCaducidad.Value = 45

        Me.cmbRefrigeracion.SelectedIndex = -1
        Me.cmbEspecie.SelectedIndex = -1
        Me.cmbFamilia.SelectedIndex = -1
        Me.cmbSubfamilia.SelectedIndex = -1
        Me.cmbCuarto.SelectedIndex = -1
        Me.cmbClasifExp.SelectedIndex = -1

        Me.dgvCatalogo.ClearSelection()

        oProducto = New clsProductos

    End Sub

    Private Sub cmbFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFamilia.SelectedIndexChanged
        Me.Cargar_Subfamilia()
       
    End Sub

    Private Sub Cargar_Subfamilia()
        Try
            If Me.cmbFamilia.SelectedIndex = -1 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo2 As SqlClient.SqlDataAdapter
            Dim lSql As String

            lSql = "EXECUTE SP_CONS_SUBFAMILIAS '" & Me.cmbFamilia.SelectedValue & "'"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_SUBFAMILIAS").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_SUBFAMILIAS")

            If oProducto.ID_SFAM <> 0 Then
                Me.cmbSubfamilia.SelectedValue = oProducto.ID_SFAM
            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class