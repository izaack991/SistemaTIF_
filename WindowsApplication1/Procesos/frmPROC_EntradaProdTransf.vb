Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmPROC_EntradaProdTransf
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos
    Dim oCorte As clsCortes
    Dim loEtiqueta As clsEtiqueta

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente

    Dim iPesadaManual As String

    Private Sub frmPROC_EntradaProdTransf_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.AgregarProducto()
            Case Keys.F5
                Me.LeerPeso()
            Case Keys.F7
                'Me.Cancelar()
            Case Keys.F9
                'Me.Imprimir()
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
                lsTitulo = "CTE_PRODCORTES_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_PRODCORTES_DESTINO"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTCODPROD"
                lsTitulo = "PROD_PRODCORTES"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 1
                lValor1 = oIntroductor.ID_CLIENTE.ToString
                lValor2 = oCorte.ID_ESPECIE.ToString
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

    Public Sub RegresaBuscarCteDestino(ByVal aCodigo As String)
        Me.txtMarcaDestino.Text = aCodigo
        Call Me.DespliegaCliente(3)
    End Sub

    Public Sub RegresaBuscarProducto(ByVal aCodigo As String)
        Me.txtCodProd.Text = aCodigo
        Call Me.DespliegaProducto()
    End Sub

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas iniciar la captura de un lote de corte nuevo?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            oCorte = New clsCortes
            Me.Limpiar()

            Me.txtLote.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()

        oProducto = New clsProductos
        oMovimientoEntSal = New clsMovimientoEntSal

        Me.txtCodProd.Text = ""
        Me.txtNomProd.Text = ""
        Me.txtCodProd.Enabled = True
        Me.txtNomProd.Enabled = True

        Me.dtpFechaMov.Enabled = True
        Me.txtLote.Text = ""
        Me.txtLote.Enabled = True

        'oProductor = New clsCliente
        'Me.txtMarcaProductor.Text = ""
        'Me.txtNomProductor.Text = ""

        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""

        oDestino = New clsCliente
        Me.txtMarcaDestino.Text = ""
        Me.txtNomDestino.Text = ""

        Me.txtPeso.Text = ""

        Me.lblCaducidad.Text = ""
        Me.lblRefrigeracion.Text = ""

        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO.Clear()
        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Clear()


    End Sub

    Private Sub frmPROC_EntradaProdTransf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO DE ENTRADA DE CAJAS POR CORTE
        oMovAlmacen = New clsMovimientoAlmacen(12)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos
        oCorte = New clsCortes

        Me.dtpFechaMov.Value = Today

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
        End If

        If Not goPermisosValidaciones.PesadaManual_SalaCortes Then Me.txtPeso.ReadOnly = True

    End Sub

    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DespliegaProducto()
        End If
    End Sub

    Private Sub DespliegaProducto()
        oProducto = New clsProductos(oIntroductor.ID_CLIENTE, Me.txtCodProd.Text.Trim)
        If oProducto.ID_PROD <> "" Then
            If oProducto.ID_FAM = 5 Then
                If oProducto.ID_CTE = oIntroductor.ID_CLIENTE Then
                    Me.txtNomProd.Text = oProducto.NOMBRE_PROD_CTE
                    Me.lblCaducidad.Text = oProducto.DIAS_CADUCIDAD
                    Me.lblRefrigeracion.Text = oProducto.NOM_REFRIGERACION
                    Me.lblTxtCaducidad.Visible = True
                    Exit Sub
                Else
                    MessageBox.Show("El producto no pertenece al cliente del corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("El producto no pertenece a la familia de cortes.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("El producto no existe ó no pertenece al cliente del corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        oProducto = New clsProductos(0)
        Me.txtCodProd.Text = ""
        Me.txtNomProd.Text = ""
        Me.lblCaducidad.Text = ""
        Me.lblRefrigeracion.Text = ""
        Me.lblTxtCaducidad.Visible = False
    End Sub

    Private Sub txtMarcaProductor_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(1)
        End If
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
        End If
    End Sub

    Private Sub txtMarcaDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaDestino.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(3)
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            'Case 1
            '    modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor)
            '    If oProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                If oDestino.ID_CLIENTE <> 0 Then
                    'If Me.txtPeso.Enabled = True And Me.txtPeso.ReadOnly = False Then
                    'Me.txtCodProd.Focus()
                    'End If
                End If
        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Guardar()
    End Sub

    Private Sub Guardar()

    End Sub
    Private Sub AgregarProducto()
        Try
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            'Dim lResp As Integer
            Dim lId_ESC As Integer = 0
            Dim lSexo As String = ""

            'lResp = MessageBox.Show("¿Deseas guardar los datos de la pesada?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'If lResp = MsgBoxResult.No Then
            '    Exit Sub
            'End If

            If Not Me.ValidaDatos() Then Exit Sub

            If oMovimientoEntSal.ID_ESC = 0 Then
                lOperacion = "A"
            Else
                lOperacion = "A"
            End If

            'If Me.rdbMacho.Checked Then
            '    lSexo = "M"
            'ElseIf Me.rdbHembra.Checked Then
            '    lSexo = "H"
            'ElseIf Me.rdbVaquilla.Checked Then
            '    lSexo = "V"
            'End If

            oMovimientoEntSal.OPERACION = lOperacion
            oMovimientoEntSal.ID_ESC = oMovimientoEntSal.ID_ESC
            oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
            oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_CAJ
            oMovimientoEntSal.FOLIO = oMovimientoEntSal.FOLIO
            'oMovimientoEntSal.ID_CTE_PROD = oProductor.ID_CLIENTE
            oMovimientoEntSal.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            oMovimientoEntSal.ID_CTE_DEST = oDestino.ID_CLIENTE
            oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.REF_FOLIO_ENT
            'oMovimientoEntSal.REF_FOLIO_SAL
            'oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
            oMovimientoEntSal.COR_LOTE = Me.txtLote.Text.Trim
            oMovimientoEntSal.ID_CORTE = Me.txtIDCorte.Text.Trim
            oMovimientoEntSal.OBSERVACIONES = Me.txtObservaciones.Text.Trim
            'oMovimientoEntSal.FECHA_MOD
            'oMovimientoEntSal.FECHA_CANC
            oMovimientoEntSal.USUARIO = 0
            'oMovimientoEntSal.USUARIO_CANC
            'oMovimientoEntSal.ID_ESC_REF
            'oMovimientoEntSal.ESTATUS
            'oMovimientoEntSal.ID_ESD
            oMovimientoEntSal.ID_CTE_DET = oDestino.ID_CLIENTE
            oMovimientoEntSal.ID_PROD = oProducto.ID_PROD
            oMovimientoEntSal.PIEZAS = Me.numPiezas.Value
            oMovimientoEntSal.PESO = Me.txtPeso.Text.Trim
            oMovimientoEntSal.TARA = 0
            oMovimientoEntSal.FECHA_ESD = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.CAJA_FECHA_ETIQ = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.SAC_SERIE
            'oMovimientoEntSal.SAC_ID
            'oMovimientoEntSal.SAC_LADO
            'oMovimientoEntSal.SAC_SEXO = lSexo
            'oMovimientoEntSal.SAC_MAYOR
            'oMovimientoEntSal.SAC_VACIADA
            'oMovimientoEntSal.SAC_ENMANTADO
            'oMovimientoEntSal.PIEL_ARETE_CAMPAÑA = Me.txtAreteCampaña.Text.Trim
            'oMovimientoEntSal.PIEL_ARETE_SAGARPA = Me.txtAreteSAGARPA.Text.Trim
            'oMovimientoEntSal.PIEL_ARETE_INTRODUCTOR = Me.txtAreteIntroductor.Text.Trim
            'oMovimientoEntSal.DECOMISO = IIf(Me.chkDecomiso.Checked, 1, 0)
            'oMovimientoEntSal.OBSERVACIONES_ESD
            'oMovimientoEntSal.ID_ESD_REF
            'oMovimientoEntSal.ESTATUS_ESD

            If oMovimientoEntSal.Guardar(lMensajeResultado, lId_ESC) Then

                loEtiqueta = New clsEtiqueta(2, oMovimientoEntSal.ID_ESD)
                loEtiqueta.Genera_Etiqueta_Cortes()
                modGeneral.ImprimirUltimaEtiquetaSacrificio()

                Me.DespliegaDatos(lId_ESC)

                Me.txtPeso.Text = ""
                Me.txtCodProd.Focus()
            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Function ValidaDatos() As Boolean
        Try
            ValidaDatos = False

            'If Me.txtLote.Enabled Then
            '    MessageBox.Show("Debe proporcionar un lote válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLote.Focus()
            '    Exit Function
            'End If

            'If Not oProductor.Existe Then
            '    MessageBox.Show("Debe proporcionar un productor válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtMarcaProductor.Focus()
            '    Exit Function
            'End If

            If Not oIntroductor.Existe Then
                MessageBox.Show("Debe proporcionar un introductor válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaIntroductor.Focus()
                Exit Function
            End If

            If Not oDestino.Existe Then
                MessageBox.Show("Debe proporcionar un destino válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaDestino.Focus()
                Exit Function
            End If

            If Not oProducto.Existe Then
                MessageBox.Show("Debe proporcionar un producto válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodProd.Focus()
                Exit Function
            End If

            If Me.txtPeso.Text.Trim = "" Then
                MessageBox.Show("Debe proporcionar un peso válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPeso.Focus()
                Exit Function
            End If

            If Not IsNumeric(Me.txtPeso.Text.Trim) Then
                MessageBox.Show("Debe proporcionar un peso válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPeso.Focus()
                Exit Function
            End If

            Return True
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Private Sub txtLote_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLote.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtLote.Text.Trim <> "" Then
                oCorte = New clsCortes()
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub DespliegaDatos(aID_ESC As Integer)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            If aID_ESC = 0 Then Exit Sub

            oMovimientoEntSal = New clsMovimientoEntSal(aID_ESC)
            If oMovimientoEntSal.ID_ESC <> 0 Then
                'oProductor = New clsCliente(oMovimientoEntSal.ID_CTE_PROD)
                'Me.txtMarcaProductor.Text = oProductor.Marca
                'Me.DespliegaCliente(1)

                oIntroductor = New clsCliente(oMovimientoEntSal.ID_CTE_INTR)
                Me.txtMarcaIntroductor.Text = oIntroductor.Marca
                Me.DespliegaCliente(2)

                'oDestino = New clsCliente(oMovimientoEntSal.ID_CTE_DET)
                'Me.txtMarcaDestino.Text = oDestino.Marca
                'Me.DespliegaCliente(3)

                Me.txtObservaciones.Text = oMovimientoEntSal.OBSERVACIONES

                lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO " & oMovimientoEntSal.ID_ESC

                lCmd.Connection = Cnn
                lCmd.CommandType = CommandType.Text
                lCmd.CommandText = lSql

                Dim da As New SqlDataAdapter(lCmd)
                DsSacrificio.SP_CONS_ENTSAL_X_MOVTO.Clear()
                da.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO)

                da.Dispose()
                lCmd.Dispose()

                lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_RESUMEN " & oMovimientoEntSal.ID_ESC

                lCmd.Connection = Cnn
                lCmd.CommandType = CommandType.Text
                lCmd.CommandText = lSql

                Dim da2 As New SqlDataAdapter(lCmd)
                DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Clear()
                da2.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN)

                da2.Dispose()
                lCmd.Dispose()

                If Me.dgvDatos.RowCount > 0 Then Me.FormatoGrid()

            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub FormatoGrid()
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos, "ESTATUS_ESD")
    End Sub
    Private Sub txtPeso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPeso.KeyDown
        If e.KeyCode = Keys.Enter Then Me.AgregarProducto()
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, True))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub numPiezas_KeyDown(sender As Object, e As KeyEventArgs) Handles numPiezas.KeyDown
        If e.KeyCode = Keys.Enter Then Me.txtPeso.Focus()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor

            If oMovimientoEntSal.ID_ESC = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptINV_EntSal, ReportDocument)

            'modFuncProc.Imprimir_CrystalReport(oMovimientoEntSal.ID_ESC, DsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)
            modFuncProc.Imprimir_CrystalReport(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnPesar_Click(sender As Object, e As EventArgs) Handles btnPesar.Click
        Me.LeerPeso()
    End Sub

    Private Sub LeerPeso()
        Try
            Dim ldcPeso As Decimal = 0
            Dim lsPeso As String = ""

            Me.Cursor = Cursors.WaitCursor

            lsPeso = modFuncProc.ReceiveSerialData()

            If IsNumeric(lsPeso) Then
                Me.Pesar(CDec(lsPeso))
            Else
                MsgBox("El peso proporcionado no es válido." & vbNewLine & vbNewLine & "Lea el peso de la báscula e intente de nuevo.", MsgBoxStyle.Exclamation, gProyecto)
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Pesar(Optional ByVal aPeso As Decimal = -999)
        Try

            Dim ldcPeso As Decimal

            If aPeso = -999 Then
                If Not IsNumeric(Me.txtPeso.Text.Trim) Then
                    MsgBox("El peso proporcionado manualmente no es válido." & vbNewLine & vbNewLine & "Capture el peso e intente de nuevo.", MsgBoxStyle.Exclamation, gProyecto)
                    Me.txtPeso.SelectAll()
                    Me.txtPeso.Focus()
                    Exit Sub
                Else
                    ldcPeso = CDec(Me.txtPeso.Text.Trim)
                End If
                iPesadaManual = "M"
            Else
                ldcPeso = aPeso
                iPesadaManual = ""
            End If

            If ldcPeso <> 0 Then
                Me.txtPeso.Text = Format(ldcPeso, "#,##0.00")
            Else
                MsgBox("No se pudo leer el peso de la báscula." & vbNewLine & vbNewLine & "Capture el peso e intente de nuevo.", MsgBoxStyle.Exclamation, gProyecto)
                Me.txtPeso.Text = ""
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown

        If Me.dgvDatos.RowCount = 0 Then Exit Sub

        If e.KeyCode <> Keys.Delete Then Exit Sub

        Dim lResp As Integer
        lResp = MessageBox.Show("¿Deseas cancelar el registro seleccionado?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        lResp = MessageBox.Show("¿REALMENTE deseas cancelar el registro seleccionado?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim loMovimientoAlmacen As New clsMovimientoEntSal()
        Dim lMensaje As String = ""

        loMovimientoAlmacen.ID_ESD = Me.dgvDatos.CurrentRow.Cells("ID_ESD").Value
        loMovimientoAlmacen.OPERACION = "D"
        If loMovimientoAlmacen.Guardar(lMensaje) Then
            Me.DespliegaDatos(oMovimientoEntSal.ID_ESC)
        Else
            MessageBox.Show(lMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtIDCorte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDCorte.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDCorte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDCorte.KeyDown
        If e.KeyCode = Keys.Enter Then
            oCorte = New clsCortes(Me.txtIDCorte.Text.Trim)
            'Me.Limpiar()
            Me.Despliega_Datos_Del_Corte()
            Me.txtIDCorte.SelectAll()
        End If
    End Sub

    Private Sub Despliega_Datos_Del_Corte()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""

        Me.Limpiar()

        If oCorte.ID_CORTE <> 0 Then

            Me.txtIDCorte.Text = oCorte.ID_CORTE

            oIntroductor = New clsCliente(oCorte.ID_CTE_INTR)
            Me.txtMarcaIntroductor.Text = oIntroductor.Marca
            Me.DespliegaCliente(2)

            oDestino = New clsCliente(oCorte.ID_CTE_DEST)
            Me.txtMarcaDestino.Text = oDestino.Marca
            Me.DespliegaCliente(3)

            Me.dtpFechaMov.Value = oCorte.FECHA
            Me.txtLote.Text = oCorte.COR_LOTE

            Me.txtObservaciones.Text = oCorte.OBSERVACIONES

            Me.txtCodProd.Enabled = True

            Me.DespliegaDatos(oCorte.ID_ESC)
        Else
            Me.txtCodProd.Enabled = False
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarProducto()
    End Sub

End Class