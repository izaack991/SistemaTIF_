Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmPROC_Salida_Visceras
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Dim iUsuario As Integer
    Dim iPesadaManual As String

    Private Sub frmPROC_Salida_Visceras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                Me.AgregarProducto()
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
                lsTitulo = "CTE_SALPRODVISCERA_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_SALPRODVISCERA_DESTINO"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTCODPROD"
                lsTitulo = "PROD_SALIDA_VISCERAS_2"
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
        'Me.txtNomProd.Enabled = True

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

        oProducto = New clsProductos

        Me.txtObservaciones.Text = ""

        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_RESUMEN_TMP.Clear()
        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_TMP.Clear()

    End Sub
    Public Sub cargarusuario(ByVal iUsuario As Integer)
        Me.iUsuario = iUsuario
    End Sub
    Private Sub frmPROC_Salida_Visceras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO SALIDA DE VISCERAS POR EMBARQUE
        oMovAlmacen = New clsMovimientoAlmacen(6)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos

        Me.dtpFechaMov.Value = Today

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
        End If

        If Not goPermisosValidaciones.PesadaManual_SalidaVisceras Then Me.txtPeso.ReadOnly = True

    End Sub

    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DespliegaProducto()
        End If
    End Sub

    Private Sub DespliegaProducto()
        modFuncProc.DespliegaDescripcionProducto(Me.txtCodProd, Me.txtNomProd, oProducto)
        If oProducto.ID_PROD <> 0 Then
            If oProducto.ID_FAM <> 2 Then
                MessageBox.Show("El producto no pertenece a la familia de visceras.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                oProducto = New clsProductos(0)
                Me.txtCodProd.Text = ""
                Me.txtNomProd.Text = ""
            Else
                Me.numPiezas.Focus()
                'Me.txtCodProd.Enabled = False
                'Me.txtNomProd.Enabled = False
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
                    Me.DespliegaDatos_TMP()
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
            Dim loMovimientoEntSalTMP As New clsMovimientoEntSalDet_Productos_TMP

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No ha seleccionado ningún producto para la salida.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lResp = MessageBox.Show("¿Deseas generar la salida?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
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

            lOperacion = "2"    'SALIDA DE PRODUCTOS


            loMovimientoEntSalTMP.OPERACION = lOperacion
            loMovimientoEntSalTMP.ID_MOV = oMovAlmacen.ID_MOV
            loMovimientoEntSalTMP.ID_ALM = oIntroductor.ID_ALM_VIS
            loMovimientoEntSalTMP.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            loMovimientoEntSalTMP.ID_CTE_DEST = oDestino.ID_CLIENTE
            loMovimientoEntSalTMP.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loMovimientoEntSalTMP.OBSERVACIONES = Me.txtObservaciones.Text.Trim
            loMovimientoEntSalTMP.USUARIO = iUsuario

            If loMovimientoEntSalTMP.Guardar_MovtoAgrupadoTMP(lMensajeResultado, lFolioGenerado) Then
                'Me.DespliegaDatos()
                Me.txtPeso.Text = ""
                'Me.txtCodProd.Focus()
                'Me.cmbProductos.Focus()
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
                modFuncProc.Muestra_Pertenencia_Lote(Me.txtLote.Text.Trim)
                'Dim lID_ESC As Integer
                'oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
                'oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
                'oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
                'oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_VIS

                'lID_ESC = oMovimientoEntSal.ID_x_ENTRADA_LOTE_MOVIMIENTO

                'If lID_ESC <> 0 Then
                '    oMovimientoEntSal = New clsMovimientoEntSal(lID_ESC)
                '    Me.DespliegaDatos(lID_ESC)
                'End If
                Me.txtLote.Enabled = False
                Me.dtpFechaMov.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
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


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarProducto()
    End Sub

    Private Sub AgregarProducto()
        Try

            If Not oIntroductor.Existe Then
                MessageBox.Show("No has proporcionado un introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaIntroductor.Focus()
                Exit Sub
            End If

            If Not oDestino.Existe Then
                MessageBox.Show("No has proporcionado un cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaDestino.Focus()
                Exit Sub
            End If

            If Not oProducto.Existe Then
                MessageBox.Show("No has proporcionado un producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodProd.Focus()
                Exit Sub
            End If

            Dim loProductoTMP As New clsMovimientoEntSalDet_Productos_TMP
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lId_ESC As Integer = 0
            Dim lSexo As String = ""

            
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
            '@SAC_LOTE		INTEGER		= NULL,
            '@ID_PROD		VARCHAR(6)	= NULL,
            '@ERRORSP    	VARCHAR(300) OUTPUT

            loProductoTMP.OPERACION = lOperacion
            loProductoTMP.ID_EST = loProductoTMP.ID_EST
            loProductoTMP.ID_ESD = 0
            loProductoTMP.ID_MOV = oMovAlmacen.ID_MOV
            loProductoTMP.ID_ALM = oIntroductor.ID_ALM_VIS
            loProductoTMP.ID_ALM_DEST = oDestino.ID_ALM_VIS
            loProductoTMP.ID_CTE_DEST = oDestino.ID_CLIENTE
            loProductoTMP.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loProductoTMP.ID_PROD = oProducto.ID_PROD
            loProductoTMP.PIEZAS = Me.numPiezas.Value
            loProductoTMP.PESO = Me.txtPeso.Text.Trim
            loProductoTMP.TARA = 0
            loProductoTMP.SAC_LOTE = Me.txtLote.Text.Trim

            If loProductoTMP.GuardarProducto(lMensajeResultado, lId_ESC) Then
                Me.DespliegaDatos_TMP()
                Me.txtPeso.Text = ""
                Me.numPiezas.Value = 1
                oProducto = New clsProductos
                Me.txtCodProd.Text = ""
                Me.txtNomProd.Text = ""
                Me.txtCodProd.Focus()
            Else
                MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

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

            lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_TMP 6, " & oIntroductor.ID_ALM_VIS.ToString & ", " & oDestino.ID_CLIENTE

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_TMP.Clear()
            da.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_TMP)

            da.Dispose()
            lCmd.Dispose()

            lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_RESUMEN_TMP 6, " & oIntroductor.ID_ALM_VIS.ToString & ", " & oDestino.ID_CLIENTE

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da2 As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_RESUMEN_TMP.Clear()
            da2.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_PRODUCTOS_RESUMEN_TMP)

            da2.Dispose()
            lCmd.Dispose()

            'Me.FormatoGrid()

            'Me.lblCanalesSalida.Text = "Canales para la salida" & " (" & Me.DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Rows.Count & ")"

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgvDatos.RowCount = 0 Then Exit Sub
            Me.EliminaProductoTemporal()
        End If
    End Sub

    Private Sub EliminaProductoTemporal()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim loProductoTMP As New clsMovimientoEntSalDet_Productos_TMP
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lId_EST As Long = 0

            lResp = MessageBox.Show("¿Estas seguro de eliminar este producto de la salida?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
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

            loProductoTMP.OPERACION = lOperacion
            loProductoTMP.ID_EST = lId_EST
            'loCanalTMP.ID_ESD = oCanal.ID_ESD
            'loCanalTMP.ID_MOV = oMovAlmacen.ID_MOV
            'loCanalTMP.ID_ALM = oIntroductor.ID_ALM_CAN
            'loCanalTMP.ID_ALM_DEST = oDestino.ID_ALM_CAN
            'loCanalTMP.ID_CTEDEST = oDestino.ID_CLIENTE
            'loCanalTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'loCanalTMP.PIEZAS_FRIO = 1
            'loCanalTMP.PESO_FRIO = Me.txtPeso.Text.Trim
            'loCanalTMP.TARA_FRIO = 0

            If loProductoTMP.GuardarProducto(lMensajeResultado, lId_EST) Then
                Me.DespliegaDatos_TMP()
                Me.txtPeso.Text = ""
                Me.numPiezas.Value = 1
                oProducto = New clsProductos
                Me.txtCodProd.Text = ""
                Me.txtNomProd.Text = ""
                Me.txtCodProd.Focus()
            End If

            'MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class