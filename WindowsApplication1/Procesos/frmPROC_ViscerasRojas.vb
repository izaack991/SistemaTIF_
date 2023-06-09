Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmPROC_ViscerasRojas
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Dim iUsuario As Integer
    Dim iPesadaManual As String

    Private Sub frmPROC_ViscerasRojas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.Guardar()
            Case Keys.F5
                Me.LeerPeso()
            Case Keys.F7
                'Me.Cancelar()
            Case Keys.F9
                'Me.Imprimir()
        End Select
    End Sub
    Public Sub cargarusuario(ByVal iUsuario As Integer)
        Me.iUsuario = iUsuario
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
                lsTitulo = "CTE_ENTVISCROJA_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_ENTVISCROJA_DESTINO"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTCODPROD"
                lsTitulo = "PROD_VISCERAS_ROJAS"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 1
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
            lResp = MessageBox.Show("¿Deseas iniciar la captura de un lote nuevo?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            Me.txtLote.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()
        oProducto = New clsProductos
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

        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO.Clear()
        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Clear()

        oProducto = New clsProductos

    End Sub

    Private Sub frmPROC_Sacrificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO DE ENTRADA DE VISCERAS ROJAS
        oMovAlmacen = New clsMovimientoAlmacen(9)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos

        Me.dtpFechaMov.Value = Today

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
        End If

        If Not goPermisosValidaciones.PesadaManual_ViscerasRojas Then Me.txtPeso.ReadOnly = True

    End Sub

    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DespliegaProducto()
        End If
    End Sub

    Private Sub DespliegaProducto()
        modFuncProc.DespliegaDescripcionProducto(Me.txtCodProd, Me.txtNomProd, oProducto)
        If oProducto.ID_PROD <> "" Then
            If oProducto.ID_FAM <> 2 Then
                MessageBox.Show("El producto no pertenece a la familia de visceras.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                oProducto = New clsProductos(0)
                Me.txtCodProd.Text = ""
                Me.txtNomProd.Text = ""
            Else
                If oProducto.ID_SFAM <> 1 Then
                    MessageBox.Show("El producto no pertenece a la subfamilia de visceras rojas.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    oProducto = New clsProductos(0)
                    Me.txtCodProd.Text = ""
                    Me.txtNomProd.Text = ""
                Else
                    Me.numPiezas.Focus()
                    'Me.txtCodProd.Enabled = False
                    'Me.txtNomProd.Enabled = False
                End If
            End If
        End If
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
                If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                If oDestino.ID_CLIENTE <> 0 Then
                    'If Me.txtPeso.Enabled = True And Me.txtPeso.ReadOnly = False Then
                    Me.txtCodProd.Focus()
                    'End If
                End If
        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Guardar()
    End Sub

    Private Sub Guardar()
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
            oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_VIS
            oMovimientoEntSal.FOLIO = oMovimientoEntSal.FOLIO
            oMovimientoEntSal.ID_CTE_PROD = oProductor.ID_CLIENTE
            oMovimientoEntSal.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            oMovimientoEntSal.ID_CTE_DEST = oDestino.ID_CLIENTE
            oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.REF_FOLIO_ENT
            'oMovimientoEntSal.REF_FOLIO_SAL
            oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
            oMovimientoEntSal.OBSERVACIONES = Me.txtObservaciones.Text.Trim
            'oMovimientoEntSal.FECHA_MOD
            'oMovimientoEntSal.FECHA_CANC
            oMovimientoEntSal.USUARIO = iUsuario
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
            'oMovimientoEntSal.SAC_SERIE
            'oMovimientoEntSal.SAC_ID
            'oMovimientoEntSal.SAC_LADO
            oMovimientoEntSal.SAC_SEXO = lSexo
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

            If Me.txtLote.Enabled Then
                MessageBox.Show("Debe proporcionar un lote válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtLote.Focus()
                Exit Function
            End If

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
                If Not goPermisosValidaciones.Validacion_LotesSinEntradaVehiculos Then
                    If Not goPermisosValidaciones.ExisteLoteEntrada(Me.txtLote.Text.Trim) Then
                        MessageBox.Show("El lote proporcionado no tiene registro de una entrada de ganado." & vbNewLine & vbNewLine & _
                                         "No puede continuar con la captura.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If

                ' modFuncProc.Muestra_Pertenencia_Lote(Me.txtLote.Text.Trim)

                Dim lID_ESC As Integer
                oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
                oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
                oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
                oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_VIS

                lID_ESC = oMovimientoEntSal.ID_x_ENTRADA_LOTE_MOVIMIENTO

                If lID_ESC <> 0 Then
                    llenardatoslote(Me.txtLote.Text)
                    oMovimientoEntSal = New clsMovimientoEntSal(lID_ESC)
                    Me.DespliegaDatos(lID_ESC)
                    Me.txtLote.Enabled = False
                    Me.dtpFechaMov.Enabled = False
                End If

                If lID_ESC = 0 Then
                    llenardatoslote(Me.txtLote.Text)
                    Me.txtLote.Enabled = False
                    Me.dtpFechaMov.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub llenardatoslote(iLote As Integer)
        Dim l As SqlDataReader
        Dim lCmdi As New SqlClient.SqlCommand()

        Try
            lCmdi.Connection = Cnn
            lCmdi.CommandText = "SP_PROG_SACRIFICIO"
            lCmdi.CommandType = CommandType.StoredProcedure

            lCmdi.Parameters.AddWithValue("@op", 5)
            lCmdi.Parameters.AddWithValue("@sac_lote", Me.txtLote.Text)


            l = lCmdi.ExecuteReader()
            If l.Read Then
                '' Me.txtm.Text = l("MARCA_ORI")
                Me.txtMarcaIntroductor.Text = l("MARCA_ORI")
                Me.txtMarcaDestino.Text = l("MARCA_DEST")

                ' Me.txtMarcaProductor.Enabled = False
               
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Exit Sub
        Finally
            l.Close()
            lCmdi.Dispose()
        End Try
        Me.DespliegaCliente(1)
        Me.DespliegaCliente(2)
        Me.DespliegaCliente(3)
        Me.txtPeso.Focus()
        '  oProducto = New clsProductos(Me.cmbProductos.SelectedValue.ToString.Trim)
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub DespliegaDatos(aID_ESC As Integer)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

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
        If e.KeyCode = Keys.Enter Then Me.Guardar()
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

    Private Sub numPiezas_ValueChanged(sender As Object, e As EventArgs) Handles numPiezas.ValueChanged

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
            Me.Nuevo()
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim bPS As New fRM_BUSQUEDA_PS(Me.dtpFechaMov.Value)
        bPS.ShowDialog()
        If bPS.DataGridView1.Rows.Count > 0 Then
            If bPS.DialogResult = DialogResult.OK Then
                Me.txtLote.Text = bPS.DS_PROG_SACRI.SACRIFICIO(bPS.SACRIFICIOBindingSource.Position).SAC_LOTE
            End If
        End If
        Me.txtLote.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Nuevo()
    End Sub

    Private Sub btnguardarlotefecha_Click(sender As Object, e As EventArgs) Handles btnguardarlotefecha.Click
        Me.Guardar()
    End Sub
End Class