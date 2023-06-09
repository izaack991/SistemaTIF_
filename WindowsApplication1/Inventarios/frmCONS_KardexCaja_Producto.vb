Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_KardexCaja_Producto

    Dim oIntroductor As New clsCliente
    Dim oProducto As clsProductos

    Private Sub frmCONS_KardexCaja_Producto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.BUSCAR()
            Case Keys.F5
                Me.DespliegaDatos()
        End Select
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.DespliegaDatos()
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
                lsTitulo = "CTE_KARDEXCAJAPROD_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTCODPROD"
                lsTitulo = "PROD_PRODCORTES_KARDEX"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 1
                lValor1 = oIntroductor.ID_CLIENTE.ToString
                lValor2 = 1 'oCorte.ID_ESPECIE.ToString
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

    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            If oIntroductor.ID_CLIENTE = 0 Then
                MessageBox.Show("Debe capturar un introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaIntroductor.Focus()
                Exit Sub
            End If

            If oProducto.ID_PROD_CTE = 0 Then
                MessageBox.Show("Debe capturar un producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodProd.Focus()
                Exit Sub
            End If


            Me.DsInventarios.SP_CONS_KARDEX_CAJA_PRODUCTO.Clear()

            lSql = "SP_CONS_KARDEX_CAJA_PRODUCTO " & oIntroductor.ID_CLIENTE & ", '" & oProducto.ID_PROD_CTE & "', '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsInventarios.SP_CONS_KARDEX_CAJA_PRODUCTO)

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

    'Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs)
    '    Me.ConsultaDetalle()
    'End Sub

    'Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Me.ConsultaDetalle()
    '    End If
    'End Sub

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

    Public Sub RegresaBuscarProducto(ByVal aCodigo As String)
        Me.txtCodProd.Text = aCodigo
        Call Me.DespliegaProducto()
    End Sub

    Private Sub DespliegaProducto()
        oProducto = New clsProductos(oIntroductor.ID_CLIENTE, Me.txtCodProd.Text.Trim)
        If oProducto.ID_PROD <> "" Then
            If oProducto.ID_FAM = 5 Then
                If oProducto.ID_CTE = oIntroductor.ID_CLIENTE Then
                    Me.txtNomProd.Text = oProducto.NOMBRE_PROD_CTE
                    'Me.lblCaducidad.Text = oProducto.DIAS_CADUCIDAD
                    'Me.lblRefrigeracion.Text = oProducto.NOM_REFRIGERACION
                    'Me.lblTxtCaducidad.Visible = True
                    Exit Sub
                Else
                    MessageBox.Show("El producto no pertenece al cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("El producto no pertenece a la familia de cortes.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("El producto no existe ó no pertenece al cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        oProducto = New clsProductos(0)
        Me.txtCodProd.Text = ""
        Me.txtNomProd.Text = ""
        'Me.lblCaducidad.Text = ""
        'Me.lblRefrigeracion.Text = ""
        'Me.lblTxtCaducidad.Visible = False
    End Sub
   
    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DespliegaProducto()
        End If
    End Sub
End Class