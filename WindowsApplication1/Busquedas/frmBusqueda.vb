Public Class frmBusqueda

    Dim isSql As String
    Dim isTitulo As String
    Dim isCampoBusqueda As String
    Dim isCampoValor1 As String
    Dim isCampoValor2 As String
    Dim iiColumnaCodigo As Integer
    Dim isFormaOrigen As String

    Public Sub CachaParametros(ByVal asTitulo As String, ByVal aiColumnaCodigo As Short, ByVal asCampoBusqueda As String, Optional ByVal asCampoValor1 As String = "", _
                        Optional ByVal asCampoValor2 As String = "", Optional ByVal aFormaOrigen As String = "")
        isTitulo = UCase(asTitulo)
        isCampoBusqueda = asCampoBusqueda
        isCampoValor1 = asCampoValor1
        isCampoValor2 = asCampoValor2
        iiColumnaCodigo = aiColumnaCodigo
        isFormaOrigen = aFormaOrigen

    End Sub

    Private Sub frmBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub frmBusqueda2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lsTitulo As String = ""
        Dim lsTabla As String = ""

        Try
            Select Case UCase(isTitulo)
                Case "PROD_POR_FAMILIA"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS '', '%', '" & isCampoValor1 & "', '" & isCampoValor2 & "'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOS"
                Case "PROD_VISCERAS_ROJAS"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS '', '%', '2', '1'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOS"
                Case "PROD_VISCERAS_VERDES"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS '', '%', '2', '2'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOS"
                Case "PROD_SALIDA_VISCERAS", "PROD_SALIDA_VISCERAS_2", "PROD_SALIDA_VISCERAS_DEC"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS '', '%', '2', '%'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOS"
                Case "PROD_SALIDA_PIEL"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS '', '%', '4', '%'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOS"
                Case "PROD_PRODCORTES", "PROD_PRODCORTES_KARDEX"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS_X_CTE '" & isCampoValor1 & "', '', '" & isCampoValor2 & "', '5', '%', 'A'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOSCTE"
                Case "PROD_PRODCAT", "PROD_PRODCORTES_KARDEX"
                    isSql = "EXECUTE SP_CONS_PRODUCTOS_X_CTE '" & isCampoValor1 & "', '', '" & isCampoValor2 & "', '5', '%', 'A'"
                    lsTitulo = "Productos"
                    lsTabla = "PRODUCTOSCTE"
                Case "CTE_GANPIE_PRODUCTOR", "CTE_GANPIE_INTRODUCTOR", "CTE_GANPIE_DESTINO", _
                    "CTE_PIELES_PRODUCTOR", "CTE_PIELES_INTRODUCTOR", "CTE_PIELES_DESTINO", _
                    "CTE_SAC_PRODUCTOR", "CTE_SAC_INTRODUCTOR", "CTE_SAC_DESTINO", _
                    "CTE_ENTVEH_PRODUCTOR", "CTE_ENTVEH_INTRODUCTOR", "CTE_ENTVEH_PROVEEDOR", _
                    "CTE_ENTVISCROJA_INTRODUCTOR", "CTE_ENTVISCROJA_DESTINO", _
                    "CTE_SALPRODVISCERA_INTRODUCTOR", "CTE_SALPRODVISCERA_DESTINO", _
                    "CTE_ENTVISCVERDE_INTRODUCTOR", "CTE_ENTVISCVERDE_DESTINO", _
                    "CTE_SALVISCERA_INTRODUCTOR", "CTE_SALVISCERA_DESTINO", _
                    "CTE_DECVISCERA_INTRODUCTOR", "CTE_DECVISCERA_DESTINO", _
                    "CTE_SALCANALES_INTRODUCTOR", "CTE_SALCANALES_DESTINO", _
                    "CTE_INVCANALES_INTRODUCTOR", "CTE_INVVISCERAS_INTRODUCTOR", "CTE_INVPIELES_INTRODUCTOR", "CTE_INVCAJAS_INTRODUCTOR", _
                    "CTE_SALPRODPIEL_INTRODUCTOR", "CTE_SALPRODPIEL_DESTINO", _
                    "CTE_RELSALCANALES_INTRODUCTOR", "CTE_RELSALPIELES_INTRODUCTOR", "CTE_RELSALVISCERAS_INTRODUCTOR", _
                    "CTE_RELENTCANALES_INTRODUCTOR", "CTE_RELENTVISCERAS_INTRODUCTOR", "CTE_RELENTPIELES_INTRODUCTOR", _
                    "CTE_CATPRODCORTES", "CTE_PROGCORTE_INTRODUCTOR", "CTE_PROGCORTE_DESTINO", _
                    "CTE_PRODCORTES_INTRODUCTOR", "CTE_PRODCORTES_DESTINO", "CTE_RELCORTES_INTRODUCTOR", _
                    "CTE_SALCAJAS_INTRODUCTOR", "CTE_SALCAJAS_DESTINO", "CTE_ENTCAJAS_INTRODUCTOR", "CTE_ENTCAJAS_DESTINO", _
                    "CTE_CONSREGINV_INTRODUCTOR", "CTE_KARDEXCAJAPROD_INTRODUCTOR", "CTE_CONSANALISISINV_INTRODUCTOR"
                    isSql = "SP_CONS_CLIENTES"
                    lsTitulo = "Cliente"
                    lsTabla = "CLIENTES"
                Case "VERIF_MAESTRO"
                    isSql = "EXECUTE SP_VERFICAR_CAJAS 2"
                    lsTitulo = "VERIF_MAESTRO"
                    lsTabla = "VERIF_MAESTRO"
                Case "PROG SACRIFICIO"
                    isSql = "EXECUTE SP_PROG_SACRIFICIO 6,0,0,0,0,0," & "'" & isCampoValor1 & "'" & ",NULL,NULL,0,0,0,0,0,0,0"
                    lsTitulo = "SACRIFICIO"
                    lsTabla = "SACRIFICIO"
            End Select

            Dim da1 As New SqlClient.SqlDataAdapter(isSql, Cnn)
            Me.BindingSource.DataMember = Me.dsBusqueda.Tables(lsTabla).ToString
            Me.dgvBusqueda.DataSource = Me.BindingSource.DataSource
            Me.dgvBusqueda.DataMember = Me.BindingSource.DataMember

            da1.Fill(Me.dsBusqueda, lsTabla)

            Call Me.FormatoGrid(lsTitulo)

            Me.Text = Me.Text & " - " & lsTitulo

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub FormatoGrid(ByVal asTitulo As String)
        Select Case UCase(isTitulo)
            Case "PROD_VISCERAS_ROJAS", "PROD_VISCERAS_VERDES", "PROD_SALIDA_VISCERAS", "PROD_SALIDA_VISCERAS_DEC", _
                "PROD_POR_FAMILIA", "PROD_SALIDA_PIEL"
                With Me.dgvBusqueda
                    Dim i As Integer
                    .Columns(0).HeaderText = "CODIGO"
                    .Columns(0).Width = 60
                    .Columns(1).HeaderText = "PRODUCTO"
                    .Columns(1).Width = 200
                    .Columns(2).HeaderText = "FAMILIA"
                    .Columns(2).Width = 100
                    .Columns(3).HeaderText = "SUBFAMILIA"
                    .Columns(3).Width = 120
                    For i = 4 To .Columns.Count - 1
                        .Columns(i).Visible = False
                    Next
                End With
            Case "PROD_PRODCORTES", "PROD_PRODCORTES_KARDEX"
                With Me.dgvBusqueda
                    Dim i As Integer
                    .Columns(0).HeaderText = "CODIGO"
                    .Columns(0).Width = 60
                    .Columns(1).HeaderText = "PRODUCTO"
                    .Columns(1).Width = 200
                    .Columns(2).HeaderText = "FAMILIA"
                    .Columns(2).Width = 100
                    .Columns(3).HeaderText = "SUBFAMILIA"
                    .Columns(3).Width = 120
                    .Columns(4).HeaderText = "CLIENTE"
                    .Columns(4).Width = 60
                    For i = 5 To .Columns.Count - 1
                        .Columns(i).Visible = False
                    Next
                End With
            Case "CTE_GANPIE_PRODUCTOR", "CTE_GANPIE_INTRODUCTOR", "CTE_GANPIE_DESTINO", _
                    "CTE_PIELES_PRODUCTOR", "CTE_PIELES_INTRODUCTOR", "CTE_PIELES_DESTINO", _
                    "CTE_SAC_PRODUCTOR", "CTE_SAC_INTRODUCTOR", "CTE_SAC_DESTINO", _
                    "CTE_ENTVEH_PRODUCTOR", "CTE_ENTVEH_INTRODUCTOR", "CTE_ENTVEH_PROVEEDOR", _
                    "CTE_ENTVISCROJA_INTRODUCTOR", "CTE_ENTVISCROJA_DESTINO", _
                    "CTE_SALPRODVISCERA_INTRODUCTOR", "CTE_SALPRODVISCERA_DESTINO", _
                    "CTE_ENTVISCVERDE_INTRODUCTOR", "CTE_ENTVISCVERDE_DESTINO", _
                    "CTE_SALVISCERA_INTRODUCTOR", "CTE_SALVISCERA_DESTINO", _
                    "CTE_DECVISCERA_INTRODUCTOR", "CTE_DECVISCERA_DESTINO", _
                    "CTE_SALCANALES_INTRODUCTOR", "CTE_SALCANALES_DESTINO", _
                    "CTE_INVCANALES_INTRODUCTOR", "CTE_INVVISCERAS_INTRODUCTOR", "CTE_INVPIELES_INTRODUCTOR", "CTE_INVCAJAS_INTRODUCTOR", _
                    "CTE_SALPRODPIEL_INTRODUCTOR", "CTE_SALPRODPIEL_DESTINO", _
                    "CTE_RELSALCANALES_INTRODUCTOR", "CTE_RELSALPIELES_INTRODUCTOR", "CTE_RELSALVISCERAS_INTRODUCTOR", _
                    "CTE_RELENTCANALES_INTRODUCTOR", "CTE_RELENTVISCERAS_INTRODUCTOR", "CTE_RELENTPIELES_INTRODUCTOR", _
                    "CTE_CATPRODCORTES", "CTE_PROGCORTE_INTRODUCTOR", "CTE_PROGCORTE_DESTINO", _
                    "CTE_PRODCORTES_INTRODUCTOR", "CTE_PRODCORTES_DESTINO", "CTE_RELCORTES_INTRODUCTOR", _
                    "CTE_SALCAJAS_INTRODUCTOR", "CTE_SALCAJAS_DESTINO", "CTE_ENTCAJAS_INTRODUCTOR", "CTE_ENTCAJAS_DESTINO", _
                    "CTE_CONSREGINV_INTRODUCTOR", "CTE_KARDEXCAJAPROD_INTRODUCTOR""", "CTE_CONSANALISISINV_INTRODUCTOR"
                With Me.dgvBusqueda
                    Dim i As Integer
                    .Columns(0).Width = 60
                    .Columns(0).Visible = False
                    .Columns(1).Width = 60
                    .Columns(1).HeaderText = "MARCA"
                    .Columns(2).Width = 300
                    .Columns(2).HeaderText = "NOMBRE"
                    For i = 3 To .Columns.Count - 1
                        .Columns(i).Visible = False
                    Next
                End With
            Case "VERIF_MAESTRO"
                With Me.dgvBusqueda
                    Dim i As Integer
                    .Columns(0).HeaderText = "ID_VER"
                    .Columns(0).Width = 80
                    .Columns(1).HeaderText = "COR_LOTE"
                    .Columns(1).Width = 80
                    .Columns(2).HeaderText = "FECHA"
                    .Columns(2).Width = 100
                    For i = 3 To .Columns.Count - 1
                        .Columns(i).Visible = False
                    Next
                End With
        End Select
    End Sub

    Private Sub dgvDatos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBusqueda.DoubleClick
        Call SeleccionaRegistro()
    End Sub

    Private Sub dgvDatos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.SeleccionaRegistro()
        End If
    End Sub

    Private Sub SeleccionaRegistro()
        Dim lsCodigo As String
        'Dim frm As Form

        lsCodigo = Me.dgvBusqueda.CurrentRow.Cells(iiColumnaCodigo - 1).Value

        Select Case UCase(isTitulo)
            Case "PROD_VISCERAS_ROJAS"
                frmPROC_ViscerasRojas.RegresaBuscarProducto(lsCodigo)
            Case "PROD_VISCERAS_VERDES"
                frmPROC_ViscerasVerdes.RegresaBuscarProducto(lsCodigo)
                'Case "PROD_SALIDA_VISCERAS"
                '    frmPROC_SalidaVisceras.RegresaBuscarProducto(lsCodigo)
            Case "PROD_SALIDA_VISCERAS_DEC"
                frmPROC_Salida_ViscerasDecomisos.RegresaBuscarProducto(lsCodigo)
            Case "CTE_GANPIE_PRODUCTOR"
                frmPROC_GanadoEnPie.RegresaBuscarCteProductor(lsCodigo)
            Case "CTE_GANPIE_INTRODUCTOR"
                frmPROC_GanadoEnPie.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_GANPIE_DESTINO"
                frmPROC_GanadoEnPie.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_ENTVEH_PRODUCTOR"
                frmEntradaVehiculos.RegresaBuscarCteProductor(lsCodigo)
            Case "CTE_ENTVEH_INTRODUCTOR"
                frmEntradaVehiculos.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_ENTVEH_PROVEEDOR"
                frmEntradaVehiculos.RegresaBuscarCteProveedor(lsCodigo)
            Case "CTE_PIELES_PRODUCTOR"
                frmPROC_Pieles.RegresaBuscarCteProductor(lsCodigo)
            Case "CTE_PIELES_INTRODUCTOR"
                frmPROC_Pieles.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_PIELES_DESTINO"
                frmPROC_Pieles.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_SAC_PRODUCTOR"
                frmPROC_Sacrificio.RegresaBuscarCteProductor(lsCodigo)
            Case "CTE_SAC_INTRODUCTOR"
                frmPROC_Sacrificio.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_SAC_DESTINO"
                frmPROC_Sacrificio.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_ENTVISCROJA_INTRODUCTOR"
                frmPROC_ViscerasRojas.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_ENTVISCROJA_DESTINO"
                frmPROC_ViscerasRojas.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_SALPRODVISCERA_INTRODUCTOR"
                frmPROC_Salida_Visceras.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_SALPRODVISCERA_DESTINO"
                frmPROC_Salida_Visceras.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_ENTVISCVERDE_INTRODUCTOR"
                frmPROC_ViscerasVerdes.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_ENTVISCVERDE_DESTINO"
                frmPROC_ViscerasVerdes.RegresaBuscarCteDestino(lsCodigo)
                'Case "CTE_SALVISCERA_INTRODUCTOR"
                '    frmPROC_SalidaVisceras.RegresaBuscarCteIntroductor(lsCodigo)
                'Case "CTE_SALVISCERA_DESTINO"
                '    frmPROC_SalidaVisceras.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_DECVISCERA_INTRODUCTOR"
                frmPROC_Salida_ViscerasDecomisos.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_DECVISCERA_DESTINO"
                frmPROC_Salida_ViscerasDecomisos.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_SALCANALES_INTRODUCTOR"
                frmPROC_SalidaCanales.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_SALCANALES_DESTINO"
                frmPROC_SalidaCanales.RegresaBuscarCteDestino(lsCodigo)
            Case "PROD_SALIDA_VISCERAS_2"
                frmPROC_Salida_Visceras.RegresaBuscarProducto(lsCodigo)
            Case "CTE_INVCANALES_INTRODUCTOR"
                frmCONS_InventarioCanales.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_INVVISCERAS_INTRODUCTOR"
                frmCONS_InventarioVisceras.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_INVPIELES_INTRODUCTOR"
                frmCONS_InventarioPieles.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_INVCAJAS_INTRODUCTOR"
                frmCONS_InventarioCajas.RegresaBuscarCteIntroductor(lsCodigo)
            Case "PROD_SALIDA_PIEL"
                frmPROC_Salida_Pieles.RegresaBuscarProducto(lsCodigo)
            Case "CTE_SALPRODPIEL_INTRODUCTOR"
                frmPROC_Salida_Pieles.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_SALPRODPIEL_DESTINO"
                frmPROC_Salida_Pieles.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_RELSALPIELES_INTRODUCTOR"
                frmCONS_RelacionSalidaPieles.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_RELSALVISCERAS_INTRODUCTOR"
                frmCONS_SalidaVisceras.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_RELSALCANALES_INTRODUCTOR"
                frmCONS_RelacionSalidaCanales.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_RELENTCANALES_INTRODUCTOR"
                frmCONS_EntradaSacrificio.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_RELENTVISCERAS_INTRODUCTOR"
                frmCONS_EntradaVisceras.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_RELENTPIELES_INTRODUCTOR"
                frmCONS_EntradaPieles.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_CATPRODCORTES"
                frmCAT_ProductosCte.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_PROGCORTE_INTRODUCTOR"
                frmPROC_ProgramacionCorte.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_PROGCORTE_DESTINO"
                frmPROC_ProgramacionCorte.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_PRODCORTES_INTRODUCTOR"
                frmPROC_ProduccionCortes.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_PRODCORTES_DESTINO"
                frmPROC_ProduccionCortes.RegresaBuscarCteDestino(lsCodigo)
            Case "PROD_PRODCORTES"
                frmPROC_ProduccionCortes.RegresaBuscarProducto(lsCodigo)
            Case "PROD_PRODCAT"
                frmCAT_ProductosCte.RegresaBuscarProductoCatalogo(lsCodigo)
            Case "CTE_RELCORTES_INTRODUCTOR"
                Dim cc As New frmCONS_RelacionCortes(False)
                cc.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_SALCAJAS_INTRODUCTOR"
                frmPROC_SalidaCajas.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_SALCAJAS_DESTINO"
                frmPROC_SalidaCajas.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_ENTCAJAS_INTRODUCTOR"
                frmPROC_EntradaCajas_xDev.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_ENTCAJAS_DESTINO"
                frmPROC_EntradaCajas_xDev.RegresaBuscarCteDestino(lsCodigo)
            Case "CTE_CONSREGINV_INTRODUCTOR"
                frmCONS_RegistroInventario.RegresaBuscarCteIntroductor(lsCodigo)
            Case "CTE_KARDEXCAJAPROD_INTRODUCTOR"
                frmCONS_KardexCaja_Producto.RegresaBuscarCteIntroductor(lsCodigo)
            Case "PROD_PRODCORTES_KARDEX"
                frmCONS_KardexCaja_Producto.RegresaBuscarProducto(lsCodigo)
            Case "CTE_CONSANALISISINV_INTRODUCTOR"
                frmINV_AjusteDeInventario.RegresaBuscarCteIntroductor(lsCodigo)
            Case "VERIF_MAESTRO"
                frmRevisionCajas.RegresaBuscarVerificacion(lsCodigo)
        End Select
        Me.Close()
    End Sub

    Private Sub txtBusqueda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyUp
        If Trim(Me.txtBusqueda.Text) <> "" Then
            Me.BindingSource.Filter = isCampoBusqueda & " like '" & Me.txtBusqueda.Text & "%'"
            Me.dgvBusqueda.DataSource = Me.BindingSource
            Call Me.FormatoGrid(isTitulo)
        Else
            Me.BindingSource.RemoveFilter()
        End If
    End Sub
End Class