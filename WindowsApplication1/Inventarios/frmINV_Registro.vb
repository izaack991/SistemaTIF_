
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmINV_Registro
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente

    Dim oCaja As clsMovimientoEntSal
    Dim iPesadaManual As String

    Dim iPrimeraVez As Boolean = True

    Private Sub frmINV_Registro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'If iPrimeraVez Then
        '    Me.cmbProductos.SelectedIndex = -1
        'End If
        'iPrimeraVez = False

    End Sub

    Private Sub frmINV_Registro_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.Guardar()
            Case Keys.F5
                'Case Keys.F6
                '    Me.AgregarCaja()
            Case Keys.F7
                ' Me.Cancelar()
            Case Keys.F9
                'Me.Imprimir()
            Case Keys.F11
                EliminaCajaTemporalTotal()
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
                lsTitulo = "CTE_ENTCAJAS_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_ENTCAJAS_DESTINO"
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

    'Public Sub RegresaBuscarCteDestino(ByVal aCodigo As String)
    '    Me.txtMarcaDestino.Text = aCodigo
    '    Call Me.DespliegaCliente(3)
    'End Sub

    'Public Sub RegresaBuscarProducto(ByVal aCodigo As String)
    '    Me.txtCodProd.Text = aCodigo
    '    Call Me.DespliegaProducto()
    'End Sub

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas registrar un nuevo inventario?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()
        oProducto = New clsProductos

        lblCanalesSalida.Text = "Cajas para el inventario"
        lblCodBar.Text = ""


        Me.dtpFechaMov.Enabled = True

        Me.txtCodBar.BackColor = Color.White
        Me.txtCodBar.Text = ""


        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""

        oProducto = New clsProductos

        oCaja = New clsMovimientoEntSal

        Me.txtObservaciones.Text = ""

        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Clear()
    End Sub

    Private Sub frmINV_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO MOVTO TEMPORAL DE INVENTARIO
        oMovAlmacen = New clsMovimientoAlmacen(20)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos

        Me.dtpFechaMov.Value = Today

        'Me.CargaProductos()

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
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

    Private Sub txtMarcaDestino_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(3)
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)

        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                If oIntroductor.ID_CLIENTE <> 0 Then
                    Me.DespliegaDatos_TMP()
                    Me.txtCodBar.Focus()
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
                MessageBox.Show("No ha seleccionado ninguna caja para la entrada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lResp = MessageBox.Show("¿Deseas generar la entrada de cajas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
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

            lOperacion = "5"    'MOVTO TEMPORAL DE INVENTARIO

            loMovimientoEntSalTMP.OPERACION = lOperacion
            loMovimientoEntSalTMP.ID_MOV = oMovAlmacen.ID_MOV
            loMovimientoEntSalTMP.ID_ALM = oIntroductor.ID_ALM_CAJ
            loMovimientoEntSalTMP.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            loMovimientoEntSalTMP.ID_CTE_DEST = oDestino.ID_CLIENTE
            loMovimientoEntSalTMP.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loMovimientoEntSalTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loMovimientoEntSalTMP.OBSERVACIONES_FRIO = Me.txtObservaciones.Text.Trim
            loMovimientoEntSalTMP.USUARIO = 0

            If loMovimientoEntSalTMP.Guardar_MovtoAgrupadoTMP(lMensajeResultado, lFolioGenerado) Then
                'Me.DespliegaDatos()
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
            'If Not oDestino.Existe Then
            '    MessageBox.Show("Debe proporcionar un destino válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtMarcaDestino.Focus()
            '    Exit Function
            'End If
            'If Not oProducto.Existe Then
            '    MessageBox.Show("Debe proporcionar un producto válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    'Me.cmbProductos.Focus()
            '    Exit Function
            'End If
            Return True
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    'Private Sub DespliegaDatos()
    '    Try
    '        Dim lCmd As New SqlClient.SqlCommand
    '        Dim lSql As String
    '        Dim dt As New DataTable()

    '        '@ID_MOV	INTEGER,
    '        '@ID_ALM	INTEGER,
    '        '@ID_PROD	CHAR(6),
    '        '@ESTATUS	CHAR(1)	= 'A',
    '        '@PROCESADO	CHAR(1) = 'N'

    '        lSql = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS " & oIntroductor.ID_ALM_CAJ.ToString 

    '        lCmd.Connection = Cnn
    '        lCmd.CommandType = CommandType.Text
    '        lCmd.CommandText = lSql

    '        Dim da As New SqlDataAdapter(lCmd)
    '        DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Clear()
    '        da.Fill(DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS)

    '        da.Dispose()
    '        lCmd.Dispose()

    '        'Me.lblCajasDisponibles.Text = "Cajas disponibles" & " (" & Me.DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Rows.Count & ")"

    '    Catch ex As Exception
    '        modGeneral.ManejaExcepcion(ex)
    '    End Try

    'End Sub
    Private Sub DespliegaDatos_TMP()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            'SP_CONS_ENTSAL_X_MOVTO_TMP
            '@ID_MOV		INTEGER,
            '@ID_ALM		INTEGER

            lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_TMP 20, " & oIntroductor.ID_ALM_CAJ.ToString & ", " & oIntroductor.ID_CLIENTE & "," & "0,0"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da2 As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Clear()
            da2.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP)

            da2.Dispose()
            lCmd.Dispose()

            Me.FormatoGrid()

            Me.lblCanalesSalida.Text = "Cajas para el inventario " & " (" & Me.DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_TMP.Rows.Count & ")"

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub FormatoGrid()
        Dim x As Integer
        'Dim y As Integer
        Dim X_ID_ESD As Long
        'Dim y_ID_ESD As Long

        For x = 0 To Me.dgvDatos.RowCount - 1
            X_ID_ESD = Me.dgvDatos.Rows(x).Cells("ID_ESD_TMP").Value
            'For y = 0 To Me.dgvDisponibles.RowCount - 1
            '    y_ID_ESD = Me.dgvDisponibles.Rows(y).Cells("ID_ESD").Value
            '    If X_ID_ESD = y_ID_ESD Then
            '        Me.dgvDisponibles.Rows(y).DefaultCellStyle.BackColor = Color.Orange
            '    End If
            'Next
        Next

    End Sub

    Private Sub txtCodBar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Valida_CodBar() Then
                Me.AgregarCaja()
            End If
        End If
    End Sub

    Private Sub btnCodBar_Click(sender As Object, e As EventArgs) Handles btnCodBar.Click
        If Me.Valida_CodBar() Then
            Me.AgregarCaja()
        End If
    End Sub

    Private Function Valida_CodBar() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Valida_CodBar = False

            Dim lCodBar As String = ""
            Dim lCodBarAux As String = ""
            Dim lProductoEscaneado As String = ""
            Dim i As Integer
            Dim lID_ESD As Long

            Me.txtCodBar.BackColor = Color.White
            oCaja = New clsMovimientoEntSal

            lCodBarAux = Me.txtCodBar.Text.Trim

            Select Case lCodBarAux.Length
                Case 0
                    lCodBar = ""
                Case Is >= 7
                    lCodBar = Microsoft.VisualBasic.Right(lCodBarAux, 7)
                Case Else
                    lCodBar = ""
            End Select

            If lCodBar = "" Then
                MessageBox.Show("No se pudo identificar el código de barras." & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If

            oCaja = New clsMovimientoEntSal(91, lCodBar) '91 = buscar caja de origen

            If oCaja.ID_ESD = 0 Then
                MessageBox.Show("No existe una caja para entrada con el ID proporcionado." & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If

            'If oCaja.PROCESADO = "S" Then
            '    MessageBox.Show("Esta caja no esta disponible para la entrada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtCodBar.SelectAll()
            '    Me.txtCodBar.Focus()
            '    Exit Function
            'End If

            If oCaja.ID_ALM <> oIntroductor.ID_ALM_CAJ Then
                MessageBox.Show("Esta caja no pertenece al almacen proporcionado para la entrada." & lCodBar & " esta caja le pertenece al introductor " & oCaja.ID_CTE_INTR, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If
           
            If Me.dgvDatos.RowCount > 0 Then
                For i = 0 To Me.dgvDatos.RowCount - 1
                    lID_ESD = Me.dgvDatos.Rows(i).Cells("ID_ESD_TMP").Value
                    If oCaja.ID_ESD = lID_ESD Then
                        MessageBox.Show("Esta caja ya fue agregada al movimiento actual." & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txtCodBar.SelectAll()
                        Me.txtCodBar.Focus()
                        Exit Function
                    End If
                Next
            End If

            Me.txtCodBar.BackColor = Color.LightGreen

            lProductoEscaneado = "Producto: " & oCaja.ID_PROD.ToString.Trim & "/" & oCaja.NOMBRE_PRODUCTO & " - ID: " & oCaja.SAC_SERIE_ID & " - Peso:" & oCaja.PESO

            Me.lblCodBar.Text = lProductoEscaneado

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function
    Private Sub AgregarCaja()
        Try
            If oCaja.ID_ESD = 0 Then
                MessageBox.Show("No has proporcionado una caja.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.Focus()
                Exit Sub
            End If

            Dim loCajaTMP As New clsMovimientoEntSalDet_TMP
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            'Dim lResp As Integer
            Dim lId_ESC As Integer = 0


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

            loCajaTMP.OPERACION = lOperacion
            loCajaTMP.ID_EST = loCajaTMP.ID_EST
            loCajaTMP.ID_ESD = oCaja.ID_ESD
            loCajaTMP.ID_MOV = oMovAlmacen.ID_MOV
            loCajaTMP.ID_ALM = oIntroductor.ID_ALM_CAJ
            loCajaTMP.ID_ALM_DEST = oDestino.ID_ALM_CAJ
            loCajaTMP.ID_CTE_DEST = oIntroductor.ID_CLIENTE
            loCajaTMP.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loCajaTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loCajaTMP.PIEZAS = oCaja.PIEZAS
            loCajaTMP.PESO = oCaja.PESO
            loCajaTMP.TARA = oCaja.TARA
            loCajaTMP.ID_PED = 0
            If loCajaTMP.GuardarCanal(lMensajeResultado, lId_ESC) Then
                'Me.DespliegaDatos()
                Me.DespliegaDatos_TMP()
                oCaja = New clsMovimientoEntSal
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

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgvDatos.RowCount = 0 Then Exit Sub
            Me.EliminaCajaTemporal()
        End If
    End Sub
    Private Sub EliminaCajaTemporal()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim loCajaTMP As New clsMovimientoEntSalDet_TMP
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lId_EST As Long = 0

            lResp = MessageBox.Show("¿Estas seguro de eliminar esta caja del registro?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
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

            loCajaTMP.OPERACION = lOperacion
            loCajaTMP.ID_EST = lId_EST
            'loCajaTMP.ID_ESD = oCaja.ID_ESD
            'loCajaTMP.ID_MOV = oMovAlmacen.ID_MOV
            'loCajaTMP.ID_ALM = oIntroductor.ID_ALM_CAN
            'loCajaTMP.ID_ALM_DEST = oDestino.ID_ALM_CAN
            'loCajaTMP.ID_CTEDEST = oDestino.ID_CLIENTE
            'loCajaTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'loCajaTMP.PIEZAS_FRIO = 1
            'loCajaTMP.PESO_FRIO = Me.txtPeso.Text.Trim
            'loCajaTMP.TARA_FRIO = 0

            If loCajaTMP.GuardarCanal(lMensajeResultado, lId_EST) Then
                'Me.DespliegaDatos()
                Me.DespliegaDatos_TMP()
                oCaja = New clsMovimientoEntSal
                Me.lblCodBar.Text = ""
                Me.txtCodBar.Focus()
            End If

            'MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgvDatos.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub EliminaCajaTemporalTotal()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim loCajaTMP As New clsMovimientoEntSalDet_TMP
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lId_EST As Long = 0

            lResp = MessageBox.Show("¿Estas seguro de eliminar esta caja del registro?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            'If Not Me.ValidaDatos() Then Exit Sub

            lId_EST = Me.dgvDatos.CurrentRow.Cells("ID_EST").Value

            lOperacion = "D"

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

            loCajaTMP.OPERACION = lOperacion
            'loCajaTMP.ID_EST = lId_EST
            'loCajaTMP.ID_ESD = oCaja.ID_ESD
            loCajaTMP.ID_MOV = oMovAlmacen.ID_MOV
            'loCajaTMP.ID_ALM = oIntroductor.ID_ALM_CAN
            'loCajaTMP.ID_ALM_DEST = oDestino.ID_ALM_CAN
            loCajaTMP.ID_CTE_DEST = oIntroductor.ID_CLIENTE
            'loCajaTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'loCajaTMP.PIEZAS_FRIO = 1
            'loCajaTMP.PESO_FRIO = Me.txtPeso.Text.Trim
            'loCajaTMP.TARA_FRIO = 0

            If loCajaTMP.GuardarCanal(lMensajeResultado, 0) Then
                'Me.DespliegaDatos()
                Me.DespliegaDatos_TMP()
                oCaja = New clsMovimientoEntSal
                Me.lblCodBar.Text = ""
                Me.txtCodBar.Focus()
            End If

            'MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgvDatos.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnPegar_Click(sender As Object, e As EventArgs) Handles btnPegar.Click
        Dim words As String() = Clipboard.GetText.Split(vbCrLf)
        For Each word As String In words
            lstID.Items.Add(word.Trim())
        Next
    End Sub
    Private Sub AgregarCajas()
        Try
            'If Me.lstID.SelectedIndex < 0 Then Exit Sub

            Dim i As Integer
            Dim lCodBar As String
            Dim lRes As Integer

            lRes = MessageBox.Show("¿Deseas importar los ID's al registro de inventario?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If lRes = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            For i = 0 To Me.lstID.Items.Count - 1
                lCodBar = Me.lstID.Items(i)
                If lCodBar.Trim <> "" Then
                    If Me.Valida_CodBar1(lCodBar) Then
                        Me.AgregarCaja()
                        Application.DoEvents()
                    End If
                End If
            Next

            MessageBox.Show("Se importaron los ID's.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Function Valida_CodBar1(Optional ByVal aCodBar As String = "") As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Valida_CodBar1 = False

            Dim lCodBar As String = ""
            Dim lCodBarAux As String = ""
            Dim lProductoEscaneado As String = ""
            Dim i As Integer
            Dim lID_ESD As Long

            Me.txtCodBar.BackColor = Color.White
            oCaja = New clsMovimientoEntSal

            If aCodBar = "" Then
                lCodBarAux = Me.txtCodBar.Text.Trim
            Else
                lCodBarAux = aCodBar
            End If


            Select Case lCodBarAux.Length
                Case 0
                    lCodBar = ""
                Case Is >= 7
                    lCodBar = Microsoft.VisualBasic.Right(lCodBarAux, 7)
                Case Else
                    lCodBar = ""
            End Select

            If lCodBar = "" Then
                MessageBox.Show("No se pudo identificar el código de barras. " & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If

            oCaja = New clsMovimientoEntSal(1, lCodBar)

            If oCaja.ID_ESD = 0 Then
                MessageBox.Show("No existe una caja activa con el ID proporcionado. " & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If

            If oCaja.PROCESADO = "S" Then
                MessageBox.Show("Esta caja no esta disponible para la salida. " & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If

            If oCaja.ID_ALM <> oIntroductor.ID_ALM_CAJ Then
                MessageBox.Show("Esta caja no pertenece al almacen proporcionado para la salida. " & lCodBar & " esta caja le pertenece al introductor " & oCaja.ID_CTE_INTR, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If

            If Me.dgvDatos.RowCount > 0 Then
                For i = 0 To Me.dgvDatos.RowCount - 1
                    lID_ESD = Me.dgvDatos.Rows(i).Cells("ID_ESD_TMP").Value
                    If oCaja.ID_ESD = lID_ESD Then
                        MessageBox.Show("Esta caja ya fue agregada a la salida actual. " & lCodBar, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txtCodBar.SelectAll()
                        Me.txtCodBar.Focus()
                        Exit Function
                    End If
                Next
            End If

            Me.txtCodBar.BackColor = Color.LightGreen

            lProductoEscaneado = "Producto: " & oCaja.ID_PROD.ToString.Trim & "/" & oCaja.NOMBRE_PRODUCTO & " - ID: " & oCaja.SAC_SERIE_ID & " - Peso:" & oCaja.PESO

            Me.lblCodBar.Text = lProductoEscaneado

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarCajas()
    End Sub
End Class