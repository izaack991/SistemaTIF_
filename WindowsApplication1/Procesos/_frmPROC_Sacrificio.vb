Imports System.Data.SqlClient

Public Class frmPROC_Sacrificio
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente

    Dim iPesadaManual As String

    Private Sub frmPROC_Sacrificio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.Guardar()
            Case Keys.F5
                Me.Pesar()
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
            Case "TXTMARCAPRODUCTOR"
                lsTitulo = "CTE_SAC_PRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCAINTRODUCTOR"
                lsTitulo = "CTE_SAC_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_SAC_DESTINO"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
        End Select

        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()

        'Me.txtCodProd.Focus()

    End Sub

    Public Sub RegresaBuscarCteProductor(ByVal aCodigo As String)
        Me.txtMarcaProductor.Text = aCodigo
        Call Me.DespliegaCliente(1)
    End Sub

    Public Sub RegresaBuscarCteIntroductor(ByVal aCodigo As String)
        Me.txtMarcaIntroductor.Text = aCodigo
        Call Me.DespliegaCliente(2)
    End Sub

    Public Sub RegresaBuscarCteDestino(ByVal aCodigo As String)
        Me.txtMarcaDestino.Text = aCodigo
        Call Me.DespliegaCliente(3)
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



        'Me.txtCodProd.Text = ""
        'Me.txtNomProd.Text = ""
        'Me.txtCodProd.Enabled = True
        'Me.txtNomProd.Enabled = True

        Me.dtpFechaMov.Enabled = True
        Me.txtLote.Text = ""
        Me.txtLote.Enabled = True

        oProductor = New clsCliente
        Me.txtMarcaProductor.Text = ""
        Me.txtNomProductor.Text = ""

        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""

        oDestino = New clsCliente
        Me.txtMarcaDestino.Text = ""
        Me.txtNomDestino.Text = ""

        Me.txtPeso.Text = ""
        Me.txtKgsLado1.Text = ""
        Me.txtKgsLado2.Text = ""

        Me.cmbProductos.Enabled = True
        Me.cmbProductos.SelectedIndex = -1
        oProducto = New clsProductos

        Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL.Clear()

    End Sub

    Private Sub frmPROC_Sacrificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO DE ENTRADA DE CANALES- SACRIFICIO
        oMovAlmacen = New clsMovimientoAlmacen(2)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos

        Me.dtpFechaMov.Value = Today

        Me.CargaProductos()

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
        End If
    End Sub

    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable() 'GANADO EN CANAL

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
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        Me.DespliegaProducto()
    '    End If
    'End Sub

    'Private Sub DespliegaProducto()
    '    modFuncProc.DespliegaDescripcionProducto(Me.txtCodProd, Me.txtNomProd, oProducto)
    '    If oProducto.ID_PROD <> 0 Then
    '        If oProducto.ID_FAM <> 1 Then
    '            MessageBox.Show("El producto no pertenece a la familia de canales.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            oProducto = New clsProductos(0)
    '            Me.txtCodProd.Text = ""
    '            Me.txtNomProd.Text = ""
    '        Else
    '            Me.txtCodProd.Enabled = False
    '            Me.txtNomProd.Enabled = False
    '        End If
    '    End If
    'End Sub

    Private Sub txtMarcaProductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaProductor.KeyDown
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
            Case 1
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor)
                If oProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                If oDestino.ID_CLIENTE <> 0 Then
                    If Me.txtPeso.Enabled = True And Me.txtPeso.ReadOnly = False Then
                        Me.txtPeso.Focus()
                    End If
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
            Dim lResp As Integer
            Dim lId_ESC As Integer = 0
            Dim lSexo As String = ""
            Dim lPesoAux As Decimal = 0
            Dim lSacSerie As String = ""
            Dim lSacID As Integer = 0

            lResp = MessageBox.Show("¿Deseas guardar los datos de la pesada?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not Me.ValidaDatos() Then Exit Sub

            If oMovimientoEntSal.ID_ESC = 0 Then
                lOperacion = "A"
            Else
                lOperacion = "A"
            End If

            If Me.rdbMacho.Checked Then
                lSexo = "M"
            ElseIf Me.rdbHembra.Checked Then
                lSexo = "H"
            ElseIf Me.rdbVaquilla.Checked Then
                lSexo = "V"
            End If

            oMovimientoEntSal.OPERACION = lOperacion
            oMovimientoEntSal.ID_ESC = oMovimientoEntSal.ID_ESC
            oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
            oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_CAN
            oMovimientoEntSal.FOLIO = oMovimientoEntSal.FOLIO
            oMovimientoEntSal.ID_CTE_PROD = oProductor.ID_CLIENTE
            oMovimientoEntSal.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            oMovimientoEntSal.ID_CTE_DEST = oDestino.ID_CLIENTE
            oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.REF_FOLIO_ENT
            'oMovimientoEntSal.REF_FOLIO_SAL
            oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
            'oMovimientoEntSal.OBSERVACIONES
            'oMovimientoEntSal.FECHA_MOD
            'oMovimientoEntSal.FECHA_CANC
            oMovimientoEntSal.USUARIO = 0
            'oMovimientoEntSal.USUARIO_CANC
            'oMovimientoEntSal.ID_ESC_REF
            'oMovimientoEntSal.ESTATUS
            'oMovimientoEntSal.ID_ESD
            oMovimientoEntSal.ID_CTE_DET = oDestino.ID_CLIENTE
            oMovimientoEntSal.ID_PROD = oProducto.ID_PROD
            oMovimientoEntSal.PIEZAS = 1
            oMovimientoEntSal.PESO = Me.txtPeso.Text.Trim
            oMovimientoEntSal.TARA = 0
            oMovimientoEntSal.FECHA_ESD = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            oMovimientoEntSal.SAC_SERIE = oMovimientoEntSal.SAC_SERIE
            oMovimientoEntSal.SAC_ID = oMovimientoEntSal.SAC_ID
            If Me.chkPesarLado2.Checked Then
                oMovimientoEntSal.SAC_LADO = IIf(Me.rdbLado1.Checked, 1, 2)
            Else
                oMovimientoEntSal.SAC_LADO = 1
            End If
            oMovimientoEntSal.SAC_SEXO = lSexo
            oMovimientoEntSal.SAC_MAYOR = IIf(Me.chkMayor.Checked, 1, 0)
            oMovimientoEntSal.SAC_VACIADA = IIf(Me.chkVaciada.Checked, 1, 0)
            oMovimientoEntSal.SAC_ENMANTADO = IIf(Me.chkEnmantado.Checked, 1, 0)
            'oMovimientoEntSal.PIEL_ARETE_CAMPAÑA = Me.txtAreteCampaña.Text.Trim
            'oMovimientoEntSal.PIEL_ARETE_SAGARPA = Me.txtAreteSAGARPA.Text.Trim
            'oMovimientoEntSal.PIEL_ARETE_INTRODUCTOR = Me.txtAreteIntroductor.Text.Trim
            oMovimientoEntSal.DECOMISO = IIf(Me.chkDecomiso.Checked, 1, 0)
            'oMovimientoEntSal.OBSERVACIONES_ESD
            'oMovimientoEntSal.ID_ESD_REF
            'oMovimientoEntSal.ESTATUS_ESD

            If oMovimientoEntSal.Guardar(lMensajeResultado, lId_ESC) Then

                lPesoAux = CDec(Me.txtPeso.Text.Trim)

                Me.txtPeso.Text = ""
                lSacSerie = oMovimientoEntSal.SAC_SERIE
                lSacID = oMovimientoEntSal.SAC_ID

                oMovimientoEntSal = New clsMovimientoEntSal(lId_ESC)

                oMovimientoEntSal.SAC_SERIE = lSacSerie
                oMovimientoEntSal.SAC_ID = lSacID

                If rdbLado1.Checked Then
                    Me.txtKgsLado1.Text = lPesoAux
                Else
                    Me.txtKgsLado2.Text = lPesoAux
                End If

                Me.DespliegaDatos()

            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

            If rdbLado1.Checked Then
                Me.rdbLado2.Checked = True
            Else
                Me.txtKgsLado1.Text = ""
                Me.txtKgsLado2.Text = ""
                Me.rdbLado1.Checked = True
            End If

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

            If Not oProductor.Existe Then
                MessageBox.Show("Debe proporcionar un productor válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaProductor.Focus()
                Exit Function
            End If

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
                'Me.txtCodProd.Focus()
                If Me.cmbProductos.Enabled Then Me.cmbProductos.Focus()
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
                Dim lID_ESC As Integer
                oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
                oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
                oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV

                lID_ESC = oMovimientoEntSal.ID_x_ENTRADA_LOTE_MOVIMIENTO

                If lID_ESC <> 0 Then
                    oMovimientoEntSal = New clsMovimientoEntSal(lID_ESC)
                    Me.DespliegaDatos()
                End If
                Me.txtLote.Enabled = False
                Me.dtpFechaMov.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub DespliegaDatos()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""

        If oMovimientoEntSal.ID_ESC <> 0 Then
            oProductor = New clsCliente(oMovimientoEntSal.ID_CTE_PROD)
            Me.txtMarcaProductor.Text = oProductor.Marca
            Me.DespliegaCliente(1)

            oIntroductor = New clsCliente(oMovimientoEntSal.ID_CTE_INTR)
            Me.txtMarcaIntroductor.Text = oIntroductor.Marca
            Me.DespliegaCliente(2)

            oDestino = New clsCliente(oMovimientoEntSal.ID_CTE_PROD)
            Me.txtMarcaDestino.Text = oDestino.Marca
            Me.DespliegaCliente(3)

            Me.cmbProductos.SelectedValue = oMovimientoEntSal.ID_PROD
            oProducto = New clsProductos(Me.cmbProductos.SelectedValue.ToString.Trim)
            Me.cmbProductos.Enabled = False

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL.Clear()
            lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL 2, '" & oMovimientoEntSal.FECHA & "', " & oMovimientoEntSal.SAC_LOTE & ", '%'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da1 As New SqlDataAdapter(lCmd)
            da1.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL)

            If Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_CANAL_INDIVIDUAL.Rows.Count > 0 Then Me.FormatoGrid()

        End If
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, True))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProductos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbProductos.SelectionChangeCommitted
        If Me.cmbProductos.SelectedIndex < 0 Then
            oProducto = New clsProductos
        Else
            Me.cmbProductos.Enabled = False
            oProducto = New clsProductos(Me.cmbProductos.SelectedValue.ToString.Trim)
        End If
    End Sub

    Private Sub FormatoGrid()
        Dim i As Integer

        Me.dgvDatos.Sort(Me.dgvDatos.Columns("ID_ESD"), System.ComponentModel.ListSortDirection.Descending)

        For i = 0 To Me.dgvDatos.RowCount - 1
            Me.dgvDatos.Rows(i).Cells("REN").Value = (Me.dgvDatos.RowCount) - i

            modFuncProc.FormatoGrid_MarcarDecomiso(Me.dgvDatos)
            modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos, "ESTATUS_ESD")
        Next
    End Sub

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown
        Dim i As Integer
        Dim lSePuedeBorrar As Boolean = False

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

        If Me.dgvDatos.CurrentRow.Index > 0 Then
            i = Me.dgvDatos.CurrentRow.Index - 1

            Do
                If Me.dgvDatos.Rows(i).Cells("ESTATUS_ESD").Value = "A" Then
                    MessageBox.Show("Solo es posible cancelar la ultima canal activa.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If i = 0 Then Exit Do

                i = i - 1
            Loop
        End If

        Dim loMovimientoAlmacen As New clsMovimientoEntSal()
        Dim lMensaje As String = ""

        loMovimientoAlmacen.ID_ESD = Me.dgvDatos.CurrentRow.Cells("ID_ESD").Value
        loMovimientoAlmacen.OPERACION = "D"
        If loMovimientoAlmacen.Guardar(lMensaje) Then
            Me.txtKgsLado1.Text = ""
            Me.txtKgsLado2.Text = ""
            Me.rdbLado1.Checked = True

            Me.DespliegaDatos()
        Else
            MessageBox.Show(lMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPesar_Click(sender As Object, e As EventArgs) Handles btnPesar.Click
        Me.Pesar()
    End Sub

    Private Sub Pesar()
        Dim ldcPeso As Decimal
        Dim lsPeso As String = ""

        If Me.txtPeso.ReadOnly = False Then
            If Not IsNumeric(Me.txtPeso.Text.Trim) Then
                MsgBox("El peso proporcionado manualmente no es válido." & vbNewLine & vbNewLine & "Capture el peso e intente de nuevo.", MsgBoxStyle.Exclamation, gProyecto)
                Me.txtPeso.SelectAll()
                Me.txtPeso.Focus()
                iPesadaManual = "M"
            Else
                Me.txtPeso.Text = Format(CDec(Me.txtPeso.Text.Trim), "###,##0.00")
            End If
            Exit Sub
        Else
            iPesadaManual = ""
        End If

        lsPeso = modFuncProc.ReceiveSerialData()
        ldcPeso = CDec(lsPeso)

        If ldcPeso <> 0 Then
            Me.txtPeso.Text = Format(ldcPeso, "#,##0.00")
        Else
            MsgBox("No se pudo leer el peso de la báscula." & vbNewLine & vbNewLine & "Capture el peso e intente de nuevo.", MsgBoxStyle.Exclamation, gProyecto)
            Me.txtPeso.Text = ""
        End If
    End Sub

End Class