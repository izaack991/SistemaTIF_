
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmPROC_SalidaCanales_x_Transformacion
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente

    Dim oCanal As clsMovimientoEntSal
    Dim iPesadaManual As String

    Dim iPrimeraVez As Boolean = True

    Private Sub frmPROC_SalidaCanales_x_Transformacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If iPrimeraVez Then
            Me.cmbProductos.SelectedIndex = -1
        End If
        iPrimeraVez = False

    End Sub

    Private Sub frmPROC_SalidaCanales_x_Transformacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.Guardar()
            Case Keys.F5
                Me.LeerPeso()
            Case Keys.F6
                Me.AgregarCanal()
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
                lsTitulo = "CTE_SALCANALES_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_SALCANALES_DESTINO"
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

    Public Sub RegresaBuscarCteDestino(ByVal aCodigo As String)
        Me.txtMarcaDestino.Text = aCodigo
        Call Me.DespliegaCliente(3)
    End Sub

    'Public Sub RegresaBuscarProducto(ByVal aCodigo As String)
    '    Me.txtCodProd.Text = aCodigo
    '    Call Me.DespliegaProducto()
    'End Sub

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas generar una salida nueva?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            'Me.txtLote.Focus()
            Me.cmbProductos.Focus()

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

        lblCajasDisponibles.Text = "Canales disponibles"
        lblCanalesSalida.Text = "Canales para la salida"
        lblCodBar.Text = ""

        Me.cmbProductos.SelectedIndex = -1
        Me.cmbProductos.Enabled = True

        Me.dtpFechaMov.Enabled = True
        'Me.txtLote.Text = ""
        'Me.txtLote.Enabled = True

        Me.txtCodBar.BackColor = Color.White
        Me.txtCodBar.Text = ""

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

        oProducto = New clsProductos
        Me.cmbProductos.Enabled = True

        oCanal = New clsMovimientoEntSal

        Me.txtObservaciones.Text = ""

        DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CANAL.Clear()
        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Clear()
    End Sub

    Private Sub frmPROC_SalidaCanales_x_Transformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO SALIDA CANALES X TRANSFORMacion
        oMovAlmacen = New clsMovimientoAlmacen(21)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos

        Me.dtpFechaMov.Value = Today

        Me.CargaProductos()

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
        End If

        If Not goPermisosValidaciones.PesadaManual_SalidaCanales Then Me.txtPeso.ReadOnly = True

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

        If Me.cmbProductos.SelectedIndex = -1 Then
            MessageBox.Show("Primero debe seleccionar un producto para la salida.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Select Case aOpcion
            'Case 1
            '    modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor)
            '    If oProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
            Case 2

                Me.cmbProductos.Enabled = False

                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                If oIntroductor.ID_CLIENTE <> 0 Then
                    Me.DespliegaDatos()
                    Me.txtMarcaDestino.Focus()
                End If
            Case 3
                If oIntroductor.ID_CLIENTE = 0 Then
                    MessageBox.Show("Antes debe seleccionar un introductor/almacén.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                If oDestino.ID_CLIENTE <> 0 Then
                    Me.DespliegaDatos_TMP()
                    Me.txtCodBar.Focus()
                    Me.cmbProductos.Focus()
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
            Dim lFolioGenerado As Integer
            Dim loMovimientoEntSalTMP As New clsMovimientoEntSalDet_TMP

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No ha seleccionado ninguna canal para la salida.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lResp = MessageBox.Show("¿Deseas generar la salida de canales?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            'PROCEDURE SP_ABC_ENTSAL_DESDE_TMP
            '@OPERACION  	CHAR(1),
            '@ID_MOV		INTEGER = 0,
            '@ID_ALM		INTEGER = 0,
            '@ID_CTE_INTR	INTEGER = 0,
            '@ID_CTE_DEST	INTEGER = 0,
            '@FECHA			VARCHAR(10)	= '',
            '@OBSERVACIONES	VARCHAR(200)= '',
            '@USUARIO		INTEGER	= 0,
            '@FOLIO_GENERADO INTEGER	OUTPUT,	
            '@ERRORSP    	VARCHAR(300)OUTPUT  

            lOperacion = "1"    'SALIDA DE CANALES


            loMovimientoEntSalTMP.OPERACION = lOperacion
            loMovimientoEntSalTMP.ID_MOV = oMovAlmacen.ID_MOV
            loMovimientoEntSalTMP.ID_ALM = oIntroductor.ID_ALM_CAN
            loMovimientoEntSalTMP.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            loMovimientoEntSalTMP.ID_CTE_DEST = oDestino.ID_CLIENTE
            loMovimientoEntSalTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loMovimientoEntSalTMP.OBSERVACIONES_FRIO = Me.txtObservaciones.Text.Trim
            loMovimientoEntSalTMP.USUARIO = 0

            If loMovimientoEntSalTMP.Guardar_MovtoAgrupadoTMP(lMensajeResultado, lFolioGenerado) Then
                Me.DespliegaDatos()
                Me.txtPeso.Text = ""
                'Me.txtCodProd.Focus()
                Me.cmbProductos.Focus()
                'Me.Imprimir(oMovAlmacen.ID_MOV, oIntroductor.ID_ALM_CAN, lFolioGenerado)
            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

            'MANDAR A IMPRIMIR
            Me.Limpiar()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Function ValidaDatos() As Boolean
        Try
            ValidaDatos = False

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
                Me.cmbProductos.Focus()
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

            If CDec(Me.txtPeso.Text.Trim) <= 0 Then
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

    'Private Sub txtLote_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        If Me.txtLote.Text.Trim <> "" Then
    '            Dim lID_ESC As Integer
    '            oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
    '            oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
    '            oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
    '            oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_CAN

    '            'lID_ESC = oMovimientoEntSal.ID_x_ENTRADA_LOTE_MOVIMIENTO

    '            If lID_ESC <> 0 Then
    '                oMovimientoEntSal = New clsMovimientoEntSal(lID_ESC)
    '                Me.DespliegaDatos(lID_ESC)
    '            End If
    '            Me.txtLote.Enabled = False
    '            Me.dtpFechaMov.Enabled = False
    '        End If
    '    End If
    'End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            '@ID_MOV	INTEGER,
            '@ID_ALM	INTEGER,
            '@ID_PROD	CHAR(6),
            '@ESTATUS	CHAR(1)	= 'A',
            '@PROCESADO	CHAR(1) = 'N'

            lSql = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CANAL 2, " & oIntroductor.ID_ALM_CAN.ToString & ", '" & Me.cmbProductos.SelectedValue.ToString.Trim & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CANAL.Clear()
            da.Fill(DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CANAL)

            da.Dispose()
            lCmd.Dispose()

            Me.lblCajasDisponibles.Text = "Canales disponibles" & " (" & Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CANAL.Rows.Count & ")"

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub DespliegaDatos_TMP()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            'SP_CONS_ENTSAL_X_MOVTO_TMP
            '@ID_MOV		INTEGER,
            '@ID_ALM		INTEGER

            lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_TMP 21, " & oIntroductor.ID_ALM_CAN.ToString & ", " & oDestino.ID_CLIENTE

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da2 As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Clear()
            da2.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP)

            da2.Dispose()
            lCmd.Dispose()

            Me.FormatoGrid()

            Me.lblCanalesSalida.Text = "Canales para la salida" & " (" & Me.DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Rows.Count & ")"

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub FormatoGrid()
        Dim x As Integer
        Dim y As Integer
        Dim X_ID_ESD As Long
        Dim y_ID_ESD As Long

        For x = 0 To Me.dgvDatos.RowCount - 1
            X_ID_ESD = Me.dgvDatos.Rows(x).Cells("ID_ESD_TMP").Value
            For y = 0 To Me.dgvDisponibles.RowCount - 1
                y_ID_ESD = Me.dgvDisponibles.Rows(y).Cells("ID_ESD").Value
                If X_ID_ESD = y_ID_ESD Then
                    Me.dgvDisponibles.Rows(y).DefaultCellStyle.BackColor = Color.Orange
                End If
            Next
        Next

    End Sub

    Private Sub txtPeso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPeso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Pesar()
            Me.AgregarCanal()
        End If
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, True))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub numPiezas_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then Me.txtPeso.Focus()
    End Sub


    'Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        If oMovimientoEntSal.ID_ESC = 0 Then
    '            MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If

    '        Dim miReporte As ReportDocument = Nothing
    '        miReporte = CType(New crptINV_EntSal, ReportDocument)

    '        'modFuncProc.Imprimir_CrystalReport(oMovimientoEntSal.ID_ESC, DsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)
    '        modFuncProc.Imprimir_CrystalReport(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)

    '    Catch ex As Exception
    '        modGeneral.ManejaExcepcion(ex)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

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

    Private Sub txtCodBar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBar.KeyDown
        If e.KeyCode = Keys.Enter Then Me.Valida_CodBar()
    End Sub

    Private Sub cmbProductos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedValueChanged
        If iPrimeraVez Then Exit Sub
        If Me.cmbProductos.SelectedIndex >= 0 Then
            Me.cmbProductos.Enabled = False
            oProducto = New clsProductos(Me.cmbProductos.SelectedValue.ToString.Trim)
        Else
            oProducto = New clsProductos
        End If
    End Sub

    Private Sub btnCodBar_Click(sender As Object, e As EventArgs) Handles btnCodBar.Click
        Me.Valida_CodBar()
    End Sub

    Private Sub Valida_CodBar()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim lCodBar As String = ""
            Dim lCodBarAux As String = ""
            Dim lProductoEscaneado As String = ""
            Dim i As Integer
            Dim lID_ESD As Long

            Me.txtCodBar.BackColor = Color.White
            oCanal = New clsMovimientoEntSal

            lCodBarAux = Me.txtCodBar.Text.Trim

            Select Case lCodBarAux.Length
                Case 0
                    lCodBar = ""
                Case Is >= 9
                    lCodBar = Microsoft.VisualBasic.Right(lCodBarAux, 9)
                Case Else
                    lCodBar = ""
            End Select

            If lCodBar = "" Then
                MessageBox.Show("No se pudo identificar el código de barras.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Sub
            End If

            oCanal = New clsMovimientoEntSal(3, lCodBar)

            If oCanal.ID_ESD = 0 Then
                MessageBox.Show("No existe una canal activa con el ID proporcionado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Sub
            End If

            If oCanal.PROCESADO = "S" Then
                MessageBox.Show("Esta canal no esta disponible para la salida.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Sub
            End If

            If oCanal.ID_ALM <> oIntroductor.ID_ALM_CAN Then
                MessageBox.Show("Esta canal no pertenece al almacen proporcionado para la salida.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Sub
            End If

            If Me.dgvDatos.RowCount > 0 Then
                For i = 0 To Me.dgvDatos.RowCount - 1
                    lID_ESD = Me.dgvDatos.Rows(i).Cells("ID_ESD_TMP").Value
                    If oCanal.ID_ESD = lID_ESD Then
                        MessageBox.Show("Esta canal ya fue agregada a la salida actual.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txtCodBar.SelectAll()
                        Me.txtCodBar.Focus()
                        Exit Sub
                    End If
                Next
            End If

            Me.txtCodBar.BackColor = Color.LightGreen

            lProductoEscaneado = "Producto: " & oCanal.ID_PROD.ToString.Trim & "/" & oCanal.NOMBRE_PRODUCTO & " - ID: " & oCanal.SAC_SERIE_ID & " - Peso:" & oCanal.PESO

            Me.lblCodBar.Text = lProductoEscaneado

            If Me.txtPeso.ReadOnly = False Then Me.txtPeso.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AgregarCanal()
        Try
            If oCanal.ID_ESD = 0 Then
                MessageBox.Show("No has proporcionado una canal.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.Focus()
                Exit Sub
            End If

            Dim loCanalTMP As New clsMovimientoEntSalDet_TMP
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

            lOperacion = "A"
            
            'PROCEDURE SP_ABC_ENTSAL_TMP
            '@OPERACION  	CHAR(1),
            '@ID_EST		BIGINT = 0,
            '@ID_ESD		BIGINT = 0,
            '@ID_MOV		INTEGER = 0,
            '@ID_ALM		INTEGER = 0,
            '@ID_ALM_DEST	INTEGER = 0,
            '@ID_CTE_DEST	INTEGER = 0,
            '@PIEZAS		INTEGER = 0,
            '@PESO			DECIMAL(8,2)= 0,
            '@TARA			DECIMAL(8,2)= 0,
            '@FECHA			VARCHAR(10) = '',
            '@OBSERVACIONES	VARCHAR(200) = '',
            '@ERRORSP    	VARCHAR(300) OUTPUT

            loCanalTMP.OPERACION = lOperacion
            loCanalTMP.ID_EST = loCanalTMP.ID_EST
            loCanalTMP.ID_ESD = oCanal.ID_ESD
            loCanalTMP.ID_MOV = oMovAlmacen.ID_MOV
            loCanalTMP.ID_ALM = oIntroductor.ID_ALM_CAN
            loCanalTMP.ID_ALM_DEST = oDestino.ID_ALM_CAN
            loCanalTMP.ID_CTE_DEST = oDestino.ID_CLIENTE
            loCanalTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loCanalTMP.PIEZAS_FRIO = 1
            loCanalTMP.PESO_FRIO = Me.txtPeso.Text.Trim
            loCanalTMP.TARA_FRIO = 0

            If loCanalTMP.GuardarCanal(lMensajeResultado, lId_ESC) Then
                Me.DespliegaDatos()
                Me.DespliegaDatos_TMP()
                oCanal = New clsMovimientoEntSal
                Me.txtPeso.Text = ""
                Me.lblCodBar.Text = ""
                Me.txtCodBar.Text = ""
                Me.txtCodBar.Focus()
            Else
                MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgvDatos.RowCount = 0 Then Exit Sub
            Me.EliminaCanalTemporal()
        End If
    End Sub

    Private Sub EliminaCanalTemporal()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim loCanalTMP As New clsMovimientoEntSalDet_TMP
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lId_EST As Long = 0

            lResp = MessageBox.Show("¿Estas seguro de eliminar esta canal de la salida?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            'If Not Me.ValidaDatos() Then Exit Sub

            lId_EST = Me.dgvDatos.CurrentRow.Cells("ID_EST").Value

            lOperacion = "C"

            'PROCEDURE SP_ABC_ENTSAL_TMP
            '@OPERACION  	CHAR(1),
            '@ID_EST		BIGINT = 0,
            '@ID_ESD		BIGINT = 0,
            '@ID_MOV		INTEGER = 0,
            '@ID_ALM		INTEGER = 0,
            '@ID_ALM_DEST	INTEGER = 0,
            '@ID_CTE_DEST	INTEGER = 0,
            '@PIEZAS		INTEGER = 0,
            '@PESO			DECIMAL(8,2)= 0,
            '@TARA			DECIMAL(8,2)= 0,
            '@FECHA			VARCHAR(10) = '',
            '@OBSERVACIONES	VARCHAR(200) = '',
            '@ERRORSP    	VARCHAR(300) OUTPUT

            loCanalTMP.OPERACION = lOperacion
            loCanalTMP.ID_EST = lId_EST
            'loCanalTMP.ID_ESD = oCanal.ID_ESD
            'loCanalTMP.ID_MOV = oMovAlmacen.ID_MOV
            'loCanalTMP.ID_ALM = oIntroductor.ID_ALM_CAN
            'loCanalTMP.ID_ALM_DEST = oDestino.ID_ALM_CAN
            'loCanalTMP.ID_CTEDEST = oDestino.ID_CLIENTE
            'loCanalTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'loCanalTMP.PIEZAS_FRIO = 1
            'loCanalTMP.PESO_FRIO = Me.txtPeso.Text.Trim
            'loCanalTMP.TARA_FRIO = 0

            If loCanalTMP.GuardarCanal(lMensajeResultado, lId_EST) Then
                Me.DespliegaDatos()
                Me.DespliegaDatos_TMP()
                Me.txtPeso.Text = ""
                oCanal = New clsMovimientoEntSal
                Me.lblCodBar.Text = ""
                Me.txtCodBar.Focus()
            End If

            'MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub Imprimir()
    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        If Me.dgvDatos.RowCount = 0 Then
    '            MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If

    '        Dim lCmd As New SqlClient.SqlCommand
    '        Dim lSql As String
    '        Dim lFecha As String
    '        Dim lLote As String

    '        lFecha = Format(Me.dgvDatos.CurrentRow.Cells("FECHA").Value, "dd/MM/yyyy")
    '        lLote = Me.dgvDatos.CurrentRow.Cells("SAC_LOTE").Value

    '        Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES.Clear()

    '        lSql = "EXECUTE SP_CONS_ENTSAL_SALIDA_CANALES 8, 17, 1  '" & lFecha & "', " & lLote

    '        lCmd.Connection = Cnn
    '        lCmd.CommandType = CommandType.Text
    '        lCmd.CommandText = lSql

    '        Dim da As New SqlDataAdapter(lCmd)
    '        da.Fill(Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES)

    '        lCmd.Dispose()

    '        If Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES.Rows.Count = 0 Then
    '            MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If

    '        Dim miReporte As ReportDocument = Nothing
    '        miReporte = CType(New crptCONS_RendimientoSacrificio, ReportDocument)

    '        Dim frmReporte As New frmCRViewer
    '        frmReporte.MdiParent = Me.ParentForm
    '        frmReporte.crViewer.ReportSource = miReporte

    '        miReporte.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_ENTSAL_RELACION_SALIDA_CANALES"))

    '        frmReporte.Show()

    '    Catch ex As Exception
    '        Call modGeneral.ManejaExcepcion(ex)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    Private Sub Imprimir(aID_MOV As Integer, aID_ALM As Integer, aFolio As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String

            Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_SALIDA_CANALES " & aID_MOV & ", " & aID_ALM & ", " & aFolio

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES)

            lCmd.Dispose()

            If Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES.Rows.Count = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptREP_SalidaDeCanales, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsSacrificio.Tables("SP_CONS_ENTSAL_SALIDA_CANALES"))

            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Pesar()
        Me.AgregarCanal()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class