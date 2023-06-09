Option Strict Off
Option Explicit On

Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPROC_ProgramacionCorte
    '    Dim oMovAlmacen As clsMovimientoAlmacen

    Dim oCorte As New clsCortes()

    Dim oEspecie As clsEspecies
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Dim iUsuario As Integer
    Dim iPesadaManual As String

    Private Sub frmPROC_ProgramacionCorte_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F4
                Me.Guardar()
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
                lsTitulo = "CTE_PROGCORTE_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_PROGCORTE_DESTINO"
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

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas iniciar la captura de un lote nuevo?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

            Me.txtMarcaIntroductor.Focus()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()

        Me.dtpFechaMov.Enabled = True
        Me.dtpFechaMov.Value = Today

        Me.txtIDCorte.Text = ""

        Me.txtLote.Text = ""
        Me.txtLote.Enabled = True

        oCorte = New clsCortes

        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""

        oDestino = New clsCliente
        Me.txtMarcaDestino.Text = ""
        Me.txtNomDestino.Text = ""
        Me.txtSM.Text = ""
        Me.txtIndicaciones.Text = ""
        Me.txtObservaciones.Text = ""

        Me.btnGuardarLoteFecha.Enabled = False
        Me.btnGuardarLoteFecha.Visible = False

        Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_SIN_CORTE.Clear()
        Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_CON_CORTE.Clear()

        Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_SIN_CORTE.Clear()
        Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_CON_CORTE.Clear()

    End Sub

    Private Sub frmPROC_ProgramacionCorte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpFechaMov.Value = Today

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
    Public Sub cargarusuario(ByVal iUsuario As Integer)
        Me.iUsuario = iUsuario
    End Sub
    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
            If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
        End If
    End Sub

    Private Sub txtMarcaDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaDestino.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(3)
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                'If oDestino.ID_CLIENTE <> 0 Then
                'End If
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
            Dim lID_CORTE As Integer = 0
            Dim lSexo As String = ""
            Dim lPesoAux As Decimal = 0
            Dim lSacSerie As String = ""
            Dim lSacID As Integer = 0

            lResp = MessageBox.Show("¿Deseas guardar los datos del corte?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not Me.ValidaDatos() Then Exit Sub

            'PROCEDURE SP_ABC_CORTES
            '@OPERACION		CHAR(1),  
            '@ID_CORTE		INTEGER,  
            '@ID_ESPECIE	INTEGER,
            '@ID_CTE_INTR	INTEGER,
            '@ID_CTE_DEST	INTEGER,
            '@COR_LOTE		INTEGER,
            '@FECHA			VARCHAR(10),
            '@SHIPPINGMARK	VARCHAR(10),
            '@INDICACIONES	VARCHAR(30),
            '@OBSERVACIONES	VARCHAR(200),
            '@ERRORSP	VARCHAR(300) OUTPUT  --INDICADOR DE ERROR (VACIO = OK) 

            If oCorte.ID_CORTE = 0 Then
                lOperacion = "A"
            Else
                lOperacion = "M"
            End If

            oCorte.OPERACION = lOperacion
            oCorte.ID_CORTE = oCorte.ID_CORTE
            oCorte.ID_ESPECIE = Me.cmbEspecie.SelectedValue
            oCorte.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            oCorte.ID_CTE_DEST = oDestino.ID_CLIENTE
            oCorte.COR_LOTE = oCorte.COR_LOTE 'toma el consultado, para que no lo modifiquen
            oCorte.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            oCorte.SHIPPINGMARK = Me.txtSM.Text.Trim
            oCorte.INDICACIONES = Me.txtIndicaciones.Text.Trim
            oCorte.OBSERVACIONES = Me.txtObservaciones.Text.Trim.ToUpper
            oCorte.USUARIO = iUsuario


            If oCorte.Guardar(lMensajeResultado, lID_CORTE) Then

                oCorte = New clsCortes(lID_CORTE, , , , , , , , , 12)

                Me.DespliegaDatos()

            End If
            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Function ValidaDatos() As Boolean
        Try
            ValidaDatos = False

            'If Me.txtLote.Text.Trim = "" Then
            '    MessageBox.Show("Debe proporcionar un lote de corte válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLote.Focus()
            '    Exit Function
            'End If

            'If Not IsNumeric(Me.txtLote.Text.Trim) Then
            '    MessageBox.Show("Debe proporcionar un lote de corte válido.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLote.Focus()
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


            Return True
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Private Sub txtLote_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLote.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    oCorte = New clsCortes(Me.txtLote.Text.Trim)
        '    Me.DespliegaDatos()
        '    Me.txtLote.Focus()
        '    Me.txtLote.SelectAll()
        'End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub DespliegaDatos()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""

        If oCorte.ID_CORTE <> 0 Then

            Me.btnGuardarLoteFecha.Enabled = True
            Me.btnGuardarLoteFecha.Visible = True

            Me.txtIDCorte.Text = oCorte.ID_CORTE

            oIntroductor = New clsCliente(oCorte.ID_CTE_INTR)
            Me.txtMarcaIntroductor.Text = oIntroductor.Marca
            Me.DespliegaCliente(2)

            oDestino = New clsCliente(oCorte.ID_CTE_DEST)
            Me.txtMarcaDestino.Text = oDestino.Marca
            Me.DespliegaCliente(3)

            Me.dtpFechaMov.Value = oCorte.FECHA
            Me.txtLote.Text = oCorte.COR_LOTE

            Me.txtSM.Text = oCorte.SHIPPINGMARK
            Me.txtIndicaciones.Text = oCorte.INDICACIONES
            Me.txtObservaciones.Text = oCorte.OBSERVACIONES



            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_SIN_CORTE.Clear()
            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_CON_CORTE.Clear()
            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_SIN_CORTE.Clear()
            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_CON_CORTE.Clear()

            Me.DespliegaSalidasConCorte()
            Me.DespliegaSalidasCajasConCorte()


        End If
    End Sub

    Private Sub txtLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLote.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guardar_Lote_Con_Otra_Fecha()
        Try
            Dim lOperacion As String
            Dim lMensajeResultado As String = ""
            Dim lResp As Integer
            Dim lID_CORTE As Integer = 0
            Dim lSexo As String = ""
            Dim lPesoAux As Decimal = 0
            Dim lSacSerie As String = ""
            Dim lSacID As Integer = 0

            lResp = MessageBox.Show("¿Deseas guardar los datos del corte?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            If Not Me.ValidaDatos() Then Exit Sub

            If Me.dtpFechaMov.Value = oCorte.FECHA Then
                MessageBox.Show("Estas seleccionando la misma fecha de este corte. Debes proporcionar una fecha distinta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.dtpFechaMov.Focus()
                Exit Sub
            End If

            'PROCEDURE SP_ABC_CORTES
            '@OPERACION		CHAR(1),  
            '@ID_CORTE		INTEGER,  
            '@ID_ESPECIE	INTEGER,
            '@ID_CTE_INTR	INTEGER,
            '@ID_CTE_DEST	INTEGER,
            '@COR_LOTE		INTEGER,
            '@FECHA			VARCHAR(10),
            '@OBSERVACIONES	VARCHAR(200),
            '@ERRORSP	VARCHAR(300) OUTPUT  --INDICADOR DE ERROR (VACIO = OK) 

            lOperacion = "L"
            
            oCorte.OPERACION = lOperacion
            oCorte.ID_CORTE = 0
            oCorte.ID_ESPECIE = oCorte.ID_ESPECIE
            oCorte.ID_CTE_INTR = oCorte.ID_CTE_INTR
            oCorte.ID_CTE_DEST = oCorte.ID_CTE_DEST
            oCorte.COR_LOTE = oCorte.COR_LOTE
            oCorte.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            oCorte.OBSERVACIONES = Me.txtObservaciones.Text.Trim.ToUpper
            oCorte.USUARIO = 0


            If oCorte.Guardar(lMensajeResultado, lID_CORTE) Then

                oCorte = New clsCortes(lID_CORTE)

                Me.DespliegaDatos()

            End If

            MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub btnGuardarLoteFecha_Click(sender As Object, e As EventArgs) Handles btnGuardarLoteFecha.Click
        Me.Guardar_Lote_Con_Otra_Fecha()
    End Sub

    Private Sub txtIDCorte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDCorte.KeyDown
        If e.KeyCode = Keys.Enter Then
            oCorte = New clsCortes(Me.txtIDCorte.Text.Trim, , , , , , , , , 12)
            Me.DespliegaDatos()
            'Me.txtLote.Focus()
            Me.txtIDCorte.SelectAll()
        End If
    End Sub

    Private Sub txtIDCorte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDCorte.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.DespliegaSalidasSinCorte()
    End Sub

    Private Sub DespliegaSalidasSinCorte()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlmacen As String

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_CAN
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_SIN_CORTE.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_SIN_CORTE 8, '" & lCodAlmacen & "', '" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_SIN_CORTE)

            modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatos)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub DespliegaSalidasConCorte()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlmacen As String

            Me.Cursor = Cursors.WaitCursor

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_CAN
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_CON_CORTE.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_CON_CORTE 8, '" & lCodAlmacen & "', " & oCorte.ID_CORTE.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CANALES_CON_CORTE)

            modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatos2, "REN2")

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim lResp As Integer
        Dim i As Integer
        Dim lID_ESC As Integer
        Dim lError As Boolean = False


        lResp = MessageBox.Show("¿Deseas agregar a este corte las salidas de canales seleccionadas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        If oCorte.ID_CORTE = 0 Then
            MessageBox.Show("Antes debes seleccionar un corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.dgvDatos.RowCount <= 0 Then
            MessageBox.Show("No hay salidas de canales para agregar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For i = 0 To Me.dgvDatos.SelectedRows.Count - 1
            lID_ESC = Me.dgvDatos.SelectedRows(i).Cells("ID_ESC").Value
            If Not Me.Agregar_SalidaCanales_a_Corte("A", lID_ESC, oCorte.ID_CORTE) Then
                lError = True
            End If
        Next

        Me.DespliegaSalidasSinCorte()
        Me.DespliegaSalidasConCorte()

        If Not lError Then
            MessageBox.Show("La información se guardo con éxito.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Hubo algunos errores, revise la información.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim lResp As Integer
        Dim i As Integer
        Dim lID_ESC As Integer
        Dim lError As Boolean = False


        lResp = MessageBox.Show("¿Deseas eliminar de este corte las salidas de canales seleccionadas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        If oCorte.ID_CORTE = 0 Then
            MessageBox.Show("Antes debes seleccionar un corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.dgvDatos2.RowCount <= 0 Then
            MessageBox.Show("No hay salidas de canales para eliminar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For i = 0 To Me.dgvDatos2.SelectedRows.Count - 1
            lID_ESC = Me.dgvDatos2.SelectedRows(i).Cells("ID_ESC2").Value
            If Not Me.Agregar_SalidaCanales_a_Corte("E", lID_ESC, oCorte.ID_CORTE) Then
                lError = True
            End If
        Next

        Me.DespliegaSalidasSinCorte()
        Me.DespliegaSalidasConCorte()

        If Not lError Then
            MessageBox.Show("La información se guardo con éxito.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Hubo algunos errores, revise la información.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DespliegaSalidasCajasSinCorte()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlmacen As String

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_CAJ
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_SIN_CORTE.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_SIN_CORTE 13, '" & lCodAlmacen & "', '" & Format(Me.dtpFechaIniSM.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaFinSM.Value, "dd/MM/yyyy") & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_SIN_CORTE)

            'modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatosSinSM)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub DespliegaSalidasCajasConCorte()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlmacen As String

            Me.Cursor = Cursors.WaitCursor

            If oIntroductor.Existe Then
                lCodAlmacen = oIntroductor.ID_ALM_CAJ
            Else
                lCodAlmacen = "%"
            End If

            Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_CON_CORTE.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_CON_CORTE 13, '" & lCodAlmacen & "', " & oCorte.ID_CORTE.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsMovimientos.SP_CONS_ENTSAL_RELACION_SALIDA_CAJAS_CON_CORTE)

            'modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatosConSM, "REN2")

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnActualizarSM_Click(sender As Object, e As EventArgs) Handles btnActualizarSM.Click
        Me.DespliegaSalidasCajasSinCorte()
    End Sub

    Private Sub btnAgregarSM_Click(sender As Object, e As EventArgs) Handles btnAgregarSM.Click
        Dim lResp As Integer
        Dim i As Integer
        Dim lID_ESC As Integer
        Dim lError As Boolean = False


        lResp = MessageBox.Show("¿Deseas agregar a este corte las salidas de cajas seleccionadas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        If oCorte.ID_CORTE = 0 Then
            MessageBox.Show("Antes debes seleccionar un corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.dgvDatosSinSM.RowCount <= 0 Then
            MessageBox.Show("No hay salidas de cajas para agregar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For i = 0 To Me.dgvDatosSinSM.SelectedRows.Count - 1
            lID_ESC = Me.dgvDatosSinSM.SelectedRows(i).Cells("ID_ESC_SM").Value
            If Not Me.Agregar_SalidaCanales_a_Corte("A", lID_ESC, oCorte.ID_CORTE) Then
                lError = True
            End If
        Next

        Me.DespliegaSalidasCajasSinCorte()
        Me.DespliegaSalidasCajasConCorte()

        If Not lError Then
            MessageBox.Show("La información se guardo con éxito.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Hubo algunos errores, revise la información.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function Agregar_SalidaCanales_a_Corte(aOperacion As String, aId_ESC As Integer, aID_CORTE As Integer) As Boolean
        Dim lCmd As New SqlClient.SqlCommand
        Dim lp0 As New SqlClient.SqlParameter
        Dim lp1 As New SqlClient.SqlParameter
        Dim lp2 As New SqlClient.SqlParameter
        Dim lp3 As New SqlClient.SqlParameter

        Dim lMensajeResultado As String

        Try

            Agregar_SalidaCanales_a_Corte = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_SALIDAS_CANALES_CORTES"  'FUNCIONA PARA CANALES Y CAJAS
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_SALIDAS_CANALES_CORTES
            '@OPERACION		CHAR(1),
            '@ID_ESC		INTEGER,
            '@ID_CORTE		INTEGER


            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_ESC", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("ID_CORTE", SqlDbType.Int)

            lp1.Value = aOperacion
            lp2.Value = aId_ESC
            lp3.Value = aID_CORTE


            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                lMensajeResultado = "Se produjo un error al guardar."
                Agregar_SalidaCanales_a_Corte = False
            Else
                lMensajeResultado = "La información se guardó correctamente."
                Agregar_SalidaCanales_a_Corte = True
            End If

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function
    Private Sub btnEliminarSM_Click(sender As Object, e As EventArgs) Handles btnEliminarSM.Click
        Dim lResp As Integer
        Dim i As Integer
        Dim lID_ESC As Integer
        Dim lError As Boolean = False


        lResp = MessageBox.Show("¿Deseas eliminar de este corte las salidas de cajas seleccionadas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        If oCorte.ID_CORTE = 0 Then
            MessageBox.Show("Antes debes seleccionar un corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.dgvDatosConSM.RowCount <= 0 Then
            MessageBox.Show("No hay salidas de cajas para eliminar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For i = 0 To Me.dgvDatosConSM.SelectedRows.Count - 1
            lID_ESC = Me.dgvDatosConSM.SelectedRows(i).Cells("ID_ESC_SM2").Value
            If Not Me.Agregar_SalidaCanales_a_Corte("E", lID_ESC, oCorte.ID_CORTE) Then
                lError = True
            End If
        Next

        Me.DespliegaSalidasCajasSinCorte()
        Me.DespliegaSalidasCajasConCorte()

        If Not lError Then
            MessageBox.Show("La información se guardo con éxito.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Hubo algunos errores, revise la información.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.ImprimirSM(oCorte.SHIPPINGMARK)
    End Sub

    Private Sub ImprimirSM(aSHIPPINGMARK As String)
        Try
            Dim myReporte As crptREP_Packing_List = New crptREP_Packing_List
            Dim myReporte2 As crptREP_Packing_List_Classification = New crptREP_Packing_List_Classification
            Dim myReporte3 As crptREP_Packing_List_Lot = New crptREP_Packing_List_Lot
            'Dim myReporte4 As crptREP046 = New crptREP046

            Dim miReporte As ReportDocument = Nothing
            Dim miReporte2 As ReportDocument = Nothing
            Dim miReporte3 As ReportDocument = Nothing
            'Dim miReporte4 As ReportDocument = Nothing

            Dim lFolioCorte As String = ""
            Dim lSql As String

            Me.Cursor = Cursors.WaitCursor

            lFolioCorte = oCorte.SHIPPINGMARK.ToString

            If lFolioCorte = "" Then
                MessageBox.Show("No se ha seleccionado ningún corte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            miReporte = CType(myReporte, ReportDocument)
            miReporte2 = CType(myReporte2, ReportDocument)
            miReporte3 = CType(myReporte3, ReportDocument)
            'miReporte4 = CType(myReporte4, ReportDocument)

            Me.DsMovimientos.Tables("SP_CONS_PACKING_LIST").Clear()

            lSql = "EXECUTE  SP_CONS_PACKING_LIST " & lFolioCorte
            Dim daConsulta As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(lSql, Cnn)
            daConsulta.Fill(Me.DsMovimientos, "SP_CONS_PACKING_LIST")

            miReporte.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_PACKING_LIST"))
            miReporte2.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_PACKING_LIST"))
            miReporte3.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_PACKING_LIST"))
            'miReporte4.SetDataSource(Me.DsMovimientos.Tables("SP_CONS_PACKING_LIST"))

            Dim frmReporte As New frmCRViewer
            Me.Cursor = Cursors.WaitCursor
            With frmReporte
                .MdiParent = Me.ParentForm
                .crViewer.ReportSource = miReporte
                'With miReporte
                '    .SetParameterValue("EMPRESA", oEmpresa.DescEmpresa)
                '    .SetParameterValue("RFC", "RFC-980224-GL0")
                '    .SetParameterValue("DOMICILIO", oEmpresa.Domicilio.ToUpper)
                '    .SetParameterValue("CIUDAD_CP", oEmpresa.DescCiudad.ToUpper + ", C.P. " + oEmpresa.CP)
                '    '.SetParameterValue("TELEFONOS", "TEL. 52" + oEmpresa.Telefono + ", 52 " + oEmpresa.FAX)
                '    .SetParameterValue("TELEFONOS", "TEL. 52 (667) 760 6337, 52 (667) 760 6338")
                'End With
                Me.Cursor = Cursors.Default
                .Show()
            End With

            Dim frmReporte2 As New frmCRViewer
            Me.Cursor = Cursors.WaitCursor
            With frmReporte2
                .MdiParent = Me.ParentForm
                .crViewer.ReportSource = miReporte2
                'With miReporte2
                '    .SetParameterValue("EMPRESA", oEmpresa.DescEmpresa)
                '    .SetParameterValue("RFC", "RFC-980224-GL0")
                '    .SetParameterValue("DOMICILIO", oEmpresa.Domicilio.ToUpper)
                '    .SetParameterValue("CIUDAD_CP", oEmpresa.DescCiudad.ToUpper + ", C.P. " + oEmpresa.CP)
                '    '.SetParameterValue("TELEFONOS", "TEL. 52" + oEmpresa.Telefono + ", 52 " + oEmpresa.FAX)
                '    .SetParameterValue("TELEFONOS", "TEL. 52 (667) 760 6337, 52 (667) 760 6338")
                'End With
                Me.Cursor = Cursors.Default
                .Show()
            End With

            Dim frmReporte3 As New frmCRViewer
            Me.Cursor = Cursors.WaitCursor
            With frmReporte3
                .MdiParent = Me.ParentForm
                .crViewer.ReportSource = miReporte3
                '    With miReporte3
                '        .SetParameterValue("EMPRESA", oEmpresa.DescEmpresa)
                '        .SetParameterValue("RFC", "RFC-980224-GL0")
                '        .SetParameterValue("DOMICILIO", oEmpresa.Domicilio.ToUpper)
                '        .SetParameterValue("CIUDAD_CP", oEmpresa.DescCiudad.ToUpper + ", C.P. " + oEmpresa.CP)
                '        '.SetParameterValue("TELEFONOS", "TEL. 52" + oEmpresa.Telefono + ", 52 " + oEmpresa.FAX)
                '        .SetParameterValue("TELEFONOS", "TEL. 52 (667) 760 6337, 52 (667) 760 6338")
                '    End With
                Me.Cursor = Cursors.Default
                .Show()
            End With

            'Dim frmReporte4 As New frmCRViewer
            'Me.Cursor = Cursors.WaitCursor
            'With frmReporte4
            '    .MdiParent = Me.ParentForm
            '    .crViewer.ReportSource = miReporte4
            '    With miReporte4
            '        .SetParameterValue("EMPRESA", oEmpresa.DescEmpresa)
            '        .SetParameterValue("RFC", "RFC-980224-GL0")
            '        .SetParameterValue("DOMICILIO", oEmpresa.Domicilio.ToUpper)
            '        .SetParameterValue("CIUDAD_CP", oEmpresa.DescCiudad.ToUpper + ", C.P. " + oEmpresa.CP)
            '        '.SetParameterValue("TELEFONOS", "TEL. 52" + oEmpresa.Telefono + ", 52 " + oEmpresa.FAX)
            '        .SetParameterValue("TELEFONOS", "TEL. 52 (667) 760 6337, 52 (667) 760 6338")
            '    End With
            '    Me.Cursor = Cursors.Default
            '    .Show()
            'End With

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
End Class