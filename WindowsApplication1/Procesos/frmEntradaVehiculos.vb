Imports CrystalDecisions.CrystalReports.Engine

Public Class frmEntradaVehiculos

    Dim oEntrada As clsEntrada
    Dim oCteProductor As clsCliente
    Dim oCteIntroductor As clsCliente
    Dim oCteProveedor As clsCliente
    Dim iPesadaManual As String
    Dim iOperacion As String = ""

    Private Sub frmEntradaVehiculos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                'CANCELAR
                Me.Cancelar()
            Case Keys.F9
                'IMPRIMIR
                Me.Imprimir()
        End Select
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Nuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.txtObservaciones.Text <> "" Then
            Me.Guardar()
        Else
            MessageBox.Show("Favor de llenar el campo observaciones")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Cancelar()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
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

    Private Sub Pesar(Optional ByVal aPeso As Decimal = -99999)
        Try

            Dim ldcPeso As Decimal

            If aPeso = -99999 Then
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

    Private Sub frmEntradaVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosIniciales()
        Me.txtFolio.Focus()
        oEntrada = New clsEntrada(0)
        oCteProductor = New clsCliente(0)
        oCteIntroductor = New clsCliente(0)
        oCteProveedor = New clsCliente(0)
        iPesadaManual = ""

        If Not goPermisosValidaciones.PesadaManual_EntradaVehiculos Then Me.txtPeso.ReadOnly = True
    End Sub

    Private Sub CargarDatosIniciales()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo As SqlClient.SqlDataAdapter
            Dim lSql As String

            lSql = "EXECUTE SP_CONS_TIPOS_ENTRADA_VEHICULOS 0, '%'"
            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_TIPOS_ENTRADA_VEHICULOS").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_TIPOS_ENTRADA_VEHICULOS")

            lSql = "EXECUTE SP_CONS_ESPECIES 0, '%'"
            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_ESPECIES").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_ESPECIES")

            lSql = "EXECUTE SP_CONS_TIPOS_VEHICULO 0, '%'"
            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_TIPOS_VEHICULO").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_TIPOS_VEHICULO")

            lSql = "EXECUTE SP_CONS_MARCAS_VEHICULOS 0, '%'"
            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_MARCAS_VEHICULOS").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_MARCAS_VEHICULOS")

            daCatalogo.Dispose()

            Me.cmbTipoEntrada.SelectedIndex = 0
            Me.cmbEspecie.SelectedIndex = -1
            Me.cmbTipoGanado.SelectedIndex = -1
            Me.cmbTipoVehiculo.SelectedIndex = -1
            Me.cmbMarcaVehiculo.SelectedIndex = -1

            Me.txtTotalCabezasGuia.Text = "0"
            Me.txtTotalCabezas.Text = "0"

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecie.SelectedIndexChanged

        Try
            Dim lSql As String
            Dim daCatalogo As SqlClient.SqlDataAdapter
            Dim lID_Especie As Integer

            If Me.cmbEspecie.SelectedIndex = -1 Then Exit Sub

            lID_Especie = CInt(Me.cmbEspecie.SelectedValue)

            lSql = "EXECUTE SP_CONS_TIPO_GANADO " & lID_Especie & ", 0, '%'"

            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_TIPO_GANADO").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_TIPO_GANADO")

            daCatalogo.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbTipoEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoEntrada.SelectedIndexChanged
        Select Case Me.cmbTipoEntrada.SelectedIndex
            Case 0, 1
                'ENTRADA DE GANADO / ENTRADA DE EMBARQUES

                If Me.cmbTipoEntrada.SelectedIndex = 0 Then
                    'ENTRADA DE GANADO 
                    panelGanado.Enabled = True
                Else
                    'ENTRADA DE EMBARQUES
                    panelGanado.Enabled = False
                End If

                Me.lblProductor.Visible = True
                Me.txtMarcaProductor.Visible = True
                Me.txtNomProductor.Visible = True

                Me.lblIntroductor.Visible = True
                Me.txtMarcaIntroductor.Visible = True
                Me.txtNomIntroductor.Visible = True

                Me.lblProveedor.Visible = False
                Me.txtMarcaProveedor.Visible = False
                Me.txtNomProveedor.Visible = False

            Case 2
                'ENTRADA DE SERVICIOS
                panelGanado.Enabled = False

                Me.lblProductor.Visible = False
                Me.txtMarcaProductor.Visible = False
                Me.txtNomProductor.Visible = False

                Me.lblIntroductor.Visible = False
                Me.txtMarcaIntroductor.Visible = False
                Me.txtNomIntroductor.Visible = False

                Me.lblProveedor.Visible = True
                Me.txtMarcaProveedor.Visible = True
                Me.txtNomProveedor.Visible = True
        End Select

        Me.Limpiar_PanelGanado()

    End Sub

    Private Sub Limpiar()
        Me.Limpiar_PanelPrincipal()
        Me.Limpiar_PanelGanado()
        Me.Limpiar_PanelVehiculos()
        Me.Limpiar_PanelPeso()
        Me.HabilitaControles(True)
        oEntrada = New clsEntrada(0)
    End Sub

    Private Sub Limpiar_PanelPrincipal()
        Me.cmbTipoEntrada.SelectedIndex = 0
        Me.txtMarcaProductor.Text = ""
        Me.txtNomProductor.Text = ""
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""
        Me.txtMarcaProveedor.Text = ""
        Me.txtNomProveedor.Text = ""
        Me.txtOrigen.Text = ""

        'FECHAS
        Me.dtpFechaSacrificio.Value = Today
        Me.dtpFechaEntrada.Value = "01/01/1900"
        Me.dtpHoraEntrada.Value = "01/01/1900 00:00:00"
        Me.dtpFechaSalida.Value = "01/01/1900"
        Me.dtpHoraSalida.Value = "01/01/1900 00:00:00"

        Me.txtObservaciones.Text = ""

        oCteProductor = New clsCliente(0)
        oCteIntroductor = New clsCliente(0)
        oCteProveedor = New clsCliente(0)
    End Sub

    Private Sub Limpiar_PanelGanado()

        Me.cmbEspecie.SelectedIndex = -1
        Me.cmbTipoGanado.SelectedIndex = -1

        Me.dtpFechaSacrificio.Value = Today

        Me.txtCZM.Text = ""
        Me.txtFleje.Text = ""

        Me.txtNumGuia.Text = ""
        Me.txtPesoGuia.Text = ""
        Me.txtNumHembrasGuia.Text = ""
        Me.txtNumMachosGuia.Text = ""
        Me.txtTotalCabezasGuia.Text = "0"

        Me.txtLote.Text = ""

        Me.txtHembras.Text = ""
        Me.txtVaquillas.Text = ""
        Me.txtMachos.Text = ""
        Me.txtToretes.Text = ""
        Me.txtTotalCabezas.Text = "0"

        Me.txtCorrales.Text = ""

    End Sub

    Private Sub Limpiar_PanelVehiculos()
        Me.cmbTipoVehiculo.SelectedIndex = -1
        Me.cmbMarcaVehiculo.SelectedIndex = -1
        Me.txtPlacas.Text = ""
        Me.txtConductor.Text = ""
    End Sub

    Private Sub Limpiar_PanelPeso()
        Me.txtPeso.Text = ""
        Me.txtKgsEntrada.Text = ""
        Me.txtKgsSalida.Text = ""
        Me.txtKgsNeto.Text = ""
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress, txtPesoGuia.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, True))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim lFolio As String
            lFolio = Me.txtFolio.Text.Trim
            If lFolio <> "" Then
                If IsNumeric(lFolio) Then
                    Me.DespliegaDatos(lFolio)
                End If
            End If
        End If
    End Sub

    Private Sub DespliegaDatos(aID_Entrada As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Limpiar()

            oEntrada = New clsEntrada(aID_Entrada)

            If oEntrada.ID_ENTRADA = 0 Then
                MessageBox.Show("No existe el folio proporcionado", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.txtFolio.Text = aID_Entrada

            Me.cmbTipoEntrada.SelectedValue = oEntrada.ID_Tipo_Entrada
            Me.cmbTipoEntrada.Enabled = False

            Select Case oEntrada.ID_Tipo_Entrada
                Case 1, 2 'GANADO / EMBARQUES
                    Me.txtMarcaProductor.Text = oEntrada.Marca_Cte_Productor
                    'Me.txtNomProductor.Text = oEntrada.Nom_Cte_Productor

                    Me.txtMarcaIntroductor.Text = oEntrada.Marca_Cte_Introductor
                    'Me.txtNomIntroductor.Text = oEntrada.Nom_Cte_Introductor
                    Call Me.DespliegaCliente(1)
                    Call Me.DespliegaCliente(2)
                Case 3  'SERVICIOS
                    Me.txtMarcaProveedor.Text = oEntrada.Marca_Cte_Proveedor
                    'Me.txtNomProveedor.Text = oEntrada.Nom_Cte_Proveedor
                    Call Me.DespliegaCliente(3)
            End Select

            ''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''' PANEL GANADO '''''
            ''''''''''''''''''''''''''''''''''''''
            If oEntrada.ID_Tipo_Entrada = 1 Then
                Me.cmbEspecie.SelectedValue = oEntrada.ID_Especie
                Me.cmbTipoGanado.SelectedValue = oEntrada.ID_Tipo_Ganado
                Me.dtpFechaSacrificio.Value = oEntrada.FECHA_SACRIFICIO
                Me.txtLote.Text = oEntrada.LOTE
                Me.txtCZM.Text = oEntrada.FOLIO_CZM
                Me.txtFleje.Text = oEntrada.FLEJE
                '''''''''GUIA
                Me.txtNumGuia.Text = oEntrada.NUM_GUIA
                Me.txtPesoGuia.Text = Format(oEntrada.PESO_GUIA, "#,##0.00")
                Me.txtNumMachosGuia.Text = oEntrada.NUM_MACHOS_GUIA
                Me.txtNumHembrasGuia.Text = oEntrada.NUM_HEMBRAS_GUIA
                Me.txtTotalCabezasGuia.Text = oEntrada.TOTAL_ANIMALES_GUIA
                '''''''' RASTRO
                Me.txtMachos.Text = oEntrada.NUM_MACHOS
                Me.txtHembras.Text = oEntrada.NUM_HEMBRAS
                Me.txtToretes.Text = oEntrada.NUM_TORETES
                Me.txtVaquillas.Text = oEntrada.NUM_VAQUILLAS
                Me.txtTotalCabezas.Text = oEntrada.TOTAL_ANIMALES
                Me.txtCorrales.Text = oEntrada.CORRALES
            End If
            '''''''''''''''''''''''''''''''''''''''''''
            Me.dtpFechaEntrada.Value = oEntrada.FECHA_ENTRADA
            Me.dtpHoraEntrada.Value = oEntrada.HORA_ENTRADA

            'If oEntrada.FECHA_SALIDA <> "01/01/1900" Then
            Me.dtpFechaSalida.Value = oEntrada.FECHA_SALIDA
            Me.dtpHoraSalida.Value = oEntrada.HORA_SALIDA
            'End If

            Me.txtKgsEntrada.Text = Format(oEntrada.PESO_ENTRADA, "#,##0.00")
            Me.txtKgsSalida.Text = Format(oEntrada.PESO_SALIDA, "#,##0.00")
            Me.txtKgsNeto.Text = Format(oEntrada.PESO_NETO, "#,##0.00")

            Me.txtConductor.Text = oEntrada.CONDUCTOR
            Me.txtPlacas.Text = oEntrada.PLACAS
            Me.txtObservaciones.Text = oEntrada.OBSERVACIONES
            Me.txtOrigen.Text = oEntrada.ORIGEN

            Me.cmbTipoVehiculo.SelectedValue = oEntrada.ID_Tipo_Vehiculo
            Me.cmbMarcaVehiculo.SelectedValue = oEntrada.ID_Marca_Vehiculo

            Me.lblEstatus.Visible = True

            Select Case oEntrada.ESTATUS
                Case "C"
                    Me.lblEstatus.BackColor = Color.Red
                    Me.lblEstatus.ForeColor = Color.Yellow
                    Me.lblEstatus.Text = "CANCELADA"
                Case "A"
                    Me.lblEstatus.BackColor = Color.LawnGreen
                    Me.lblEstatus.ForeColor = Color.Black
                    Me.lblEstatus.Text = "ACTIVA"
                    'Me.txtMarcaProductor.ReadOnly = True
                    'Me.txtMarcaIntroductor.ReadOnly = True
                    'Case "S"
                    '    Me.lblEstatus.BackColor = Color.Navy
                    '    Me.lblEstatus.ForeColor = Color.White
                    '    Me.lblEstatus.Text = "CERRADA"
                Case Else
                    Me.lblEstatus.BackColor = Color.Red
                    Me.lblEstatus.ForeColor = Color.Yellow
                    Me.lblEstatus.Text = "NO ESPECIFICADO"
            End Select

            Me.HabilitaControles(False)

            If oEntrada.ESTATUS = "A" And oEntrada.PESO_SALIDA = 0 Then
                Me.HabilitaControlesParaSalida()
            End If

            Me.txtFolio.SelectAll()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub HabilitaControlesParaSalida()
        Dim lHabilitar As Boolean = False

        'PANEL PRINCIPAL
        Me.cmbTipoEntrada.Enabled = lHabilitar
        Me.txtMarcaProductor.Enabled = True
        Me.txtMarcaIntroductor.Enabled = True
        Me.txtMarcaProveedor.Enabled = True
        Me.txtOrigen.Enabled = True

        'PANEL GANADO
        Me.cmbEspecie.Enabled = True
        Me.cmbTipoGanado.Enabled = True
        Me.dtpFechaSacrificio.Enabled = True
        Me.txtCZM.Enabled = True
        Me.txtFleje.Enabled = True
        Me.txtNumGuia.Enabled = True
        Me.txtPesoGuia.Enabled = True
        Me.txtNumHembrasGuia.Enabled = True
        Me.txtNumMachosGuia.Enabled = True
        Me.txtHembras.Enabled = True
        Me.txtVaquillas.Enabled = True
        Me.txtMachos.Enabled = True
        Me.txtToretes.Enabled = True
        Me.txtCorrales.Enabled = True

        'PANEL VEHICULO
        Me.cmbTipoVehiculo.Enabled = True
        Me.cmbMarcaVehiculo.Enabled = True
        Me.txtPlacas.Enabled = True
        Me.txtConductor.Enabled = True

        'PANEL PESO
        'Me.txtPeso.Enabled = lHabilitar

        'PANEL OBSERVACIONES
        Me.txtObservaciones.Enabled = True

    End Sub

    Private Sub HabilitaControles(ByVal aHabilitar As Boolean)
        'PANEL PRINCIPAL
        Me.cmbTipoEntrada.Enabled = aHabilitar
        Me.txtMarcaProductor.Enabled = aHabilitar
        'Me.txtNomProductor.Enabled = aHabilitar
        Me.txtMarcaIntroductor.Enabled = aHabilitar
        'Me.txtNomIntroductor.Enabled = aHabilitar
        Me.txtMarcaProveedor.Enabled = aHabilitar
        'Me.txtNomProveedor.Enabled = aHabilitar
        Me.txtOrigen.Enabled = aHabilitar

        'PANEL GANADO
        Me.cmbEspecie.Enabled = aHabilitar
        Me.cmbTipoGanado.Enabled = aHabilitar
        Me.dtpFechaSacrificio.Enabled = aHabilitar
        Me.txtCZM.Enabled = aHabilitar
        Me.txtFleje.Enabled = aHabilitar
        Me.txtNumGuia.Enabled = aHabilitar
        Me.txtPesoGuia.Enabled = aHabilitar
        Me.txtNumHembrasGuia.Enabled = aHabilitar
        Me.txtNumMachosGuia.Enabled = aHabilitar
        'Me.txtTotalCabezasGuia.Enabled = aHabilitar
        'Me.txtLote.Enabled = aHabilitar
        Me.txtHembras.Enabled = aHabilitar
        Me.txtVaquillas.Enabled = aHabilitar
        Me.txtMachos.Enabled = aHabilitar
        Me.txtToretes.Enabled = aHabilitar
        'Me.txtTotalCabezas.Enabled = aHabilitar
        Me.txtCorrales.Enabled = aHabilitar

        'PANEL VEHICULO
        Me.cmbTipoVehiculo.Enabled = aHabilitar
        Me.cmbMarcaVehiculo.Enabled = aHabilitar
        Me.txtPlacas.Enabled = aHabilitar
        Me.txtConductor.Enabled = aHabilitar

        'PANEL PESO
        'Me.txtPeso.Enabled = aHabilitar
        'Me.txtKgsEntrada.Enabled = aHabilitar
        'Me.txtKgsSalida.Enabled = aHabilitar
        'Me.txtKgsNeto.Enabled = aHabilitar

        'PANEL OBSERVACIONES
        Me.txtObservaciones.Enabled = aHabilitar

    End Sub

    Private Sub Nuevo()
        Dim lResp As Integer
        lResp = MessageBox.Show("¿Deseas limpiar la pantalla?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If
        Me.Limpiar()
        Me.txtFolio.Text = ""
        'Me.txtFolio.Tag = ""
        Me.cmbTipoEntrada.Enabled = True
        Me.txtFolio.Focus()

    End Sub

    Private Function ValidaDatos(Optional aOpcion As Integer = 1)
        Try
            'aOpcion = 1 'valida datos para guardar entrada
            'aOpcion = 2 'validadatos para guardar salida
            'aOpcion = 3 'valida datos para canelar entrada

            If oEntrada.ESTATUS = "C" Then
                MessageBox.Show("No es posible modificar una entrada cancelada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFolio.Focus()
                Return False
            End If
            If oEntrada.PESO_SALIDA <> 0 Then
                MessageBox.Show("No es posible modificar una entrada ya terminada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFolio.Focus()
                Return False
            End If

            If oCteProductor.ID_CLIENTE = 0 And (aOpcion = 1 Or aOpcion = 2) Then
                MessageBox.Show("Debes capturar el productor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaProductor.Focus()
                Return False
            End If
            If oCteIntroductor.ID_CLIENTE = 0 And (aOpcion = 1 Or aOpcion = 2) Then
                MessageBox.Show("Debes capturar el introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaIntroductor.Focus()
                Return False
            End If
            If oCteProveedor.ID_CLIENTE = 0 And (aOpcion = 3) Then
                MessageBox.Show("Debes capturar el proveedor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtMarcaProveedor.Focus()
                Return False
            End If

            If Me.cmbEspecie.SelectedIndex < 0 And (aOpcion = 1) Then
                MessageBox.Show("Debes seleccionar una especie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbEspecie.Focus()
                Return False
            End If
            If Me.cmbTipoGanado.SelectedIndex < 0 And (aOpcion = 1) Then
                MessageBox.Show("Debes seleccionar el tipo de ganado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbEspecie.Focus()
                Return False
            End If
            If CInt(Me.txtTotalCabezasGuia.Text.Trim) = 0 And (aOpcion = 1) Then
                MessageBox.Show("Debes proporcionar la cantidad de cabezas de ganado que indica la guía.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNumMachosGuia.Focus()
                Return False
            End If
            If Me.txtPesoGuia.Text.Trim = "" And (aOpcion = 1) Then
                MessageBox.Show("Debes proporcionar el peso indicado en la guía.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPesoGuia.Focus()
                Return False
            End If
            If Not IsNumeric(Me.txtPesoGuia.Text.Trim) And (aOpcion = 1) Then
                MessageBox.Show("Debes proporcionar el peso válido para la guía.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPesoGuia.Focus()
                Return False
            End If
            If CInt(Me.txtTotalCabezas.Text.Trim) = 0 And (aOpcion = 1) Then
                MessageBox.Show("Debes proporcionar la cantidad de cabezas de ganado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtHembras.Focus()
                Return False
            End If
            If Me.cmbTipoVehiculo.SelectedIndex < 0 And (aOpcion = 1 Or aOpcion = 2 Or aOpcion = 3) Then
                MessageBox.Show("Debes seleccionar un tipo de vehículo.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbTipoVehiculo.Focus()
                Return False
            End If
            If Me.cmbMarcaVehiculo.SelectedIndex < 0 And (aOpcion = 1 Or aOpcion = 2 Or aOpcion = 3) Then
                MessageBox.Show("Debes seleccionar la marca del vehículo.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cmbMarcaVehiculo.Focus()
                Return False
            End If
            If Me.txtPlacas.Text.Trim = "" And (aOpcion = 1 Or aOpcion = 2 Or aOpcion = 3) Then
                MessageBox.Show("Debes proporcionar las placas del vehículo.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPlacas.Focus()
                Return False
            End If
            If Me.txtConductor.Text.Trim = "" And (aOpcion = 1 Or aOpcion = 2 Or aOpcion = 3) Then
                MessageBox.Show("Debes proporcionar el conductor del vehículo.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtConductor.Focus()
                Return False
            End If
            If iOperacion = "A" And Me.txtPeso.Text.Trim = "" And (aOpcion = 1 Or aOpcion = 2 Or aOpcion = 3) Then
                MessageBox.Show("Debes proporcionar el peso de entrada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPeso.Focus()
                Return False
            End If
            If iOperacion = "A" And Not IsNumeric(Me.txtPeso.Text.Trim) And (aOpcion = 1 Or aOpcion = 2 Or aOpcion = 3) Then
                MessageBox.Show("Debes proporcionar el peso válido para la entrada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtPeso.Focus()
                Return False
            Else
                If iOperacion = "A" Then Me.txtPeso.Text = Format(CDec(Me.txtPeso.Text.Trim), "###,##0.00")
            End If

            Return True
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Private Sub Guardar()
        Try
            Dim lResp As Integer
            Dim lOperacion As String

            If oEntrada.ID_ENTRADA = 0 Then
                lOperacion = "A"
            Else
                lOperacion = "M"
            End If

            iOperacion = lOperacion

            Select Case Me.cmbTipoEntrada.SelectedValue
                Case 1
                    If Not Me.ValidaDatos(1) Then Exit Sub
                Case 2
                    If Not Me.ValidaDatos(2) Then Exit Sub
                Case 3
                    If Not Me.ValidaDatos(3) Then Exit Sub
            End Select

            lResp = MessageBox.Show("¿Deseas guadar la entrada?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            oEntrada.ID_Tipo_Entrada = Me.cmbTipoEntrada.SelectedValue

            Select Case oEntrada.ID_Tipo_Entrada
                Case 1, 2 'GANADO / EMBARQUES
                    oEntrada.ID_Cte_Productor = oCteProductor.ID_CLIENTE
                    oEntrada.ID_Cte_Introductor = oCteIntroductor.ID_CLIENTE
                Case 3  'SERVICIOS
                    oEntrada.ID_Cte_Proveedor = oCteProveedor.ID_CLIENTE
            End Select

            oEntrada.ORIGEN = Me.txtOrigen.Text.Trim

            ''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''' PANEL GANADO '''''
            ''''''''''''''''''''''''''''''''''''''

            If Me.cmbTipoEntrada.SelectedValue = 1 Then
                oEntrada.ID_Especie = Me.cmbEspecie.SelectedValue
                oEntrada.ID_Tipo_Ganado = Me.cmbTipoGanado.SelectedValue
                oEntrada.FECHA_SACRIFICIO = Format(Me.dtpFechaSacrificio.Value, "dd/MM/yyyy")
                'oEntrada.LOTE=0
                oEntrada.FOLIO_CZM = Me.txtCZM.Text.Trim
                oEntrada.FLEJE = Me.txtFleje.Text.Trim
                '''''''''GUIA
                oEntrada.NUM_GUIA = Me.txtNumGuia.Text.Trim
                oEntrada.PESO_GUIA = IIf(Me.txtPesoGuia.Text.Trim = "", 0, Me.txtPesoGuia.Text.Trim)
                oEntrada.NUM_MACHOS_GUIA = IIf(Me.txtNumMachosGuia.Text.Trim = "", 0, Me.txtNumMachosGuia.Text.Trim)
                oEntrada.NUM_HEMBRAS_GUIA = IIf(Me.txtNumHembrasGuia.Text.Trim = "", 0, Me.txtNumHembrasGuia.Text.Trim)
                '''''''' RASTRO
                oEntrada.NUM_MACHOS = IIf(Me.txtMachos.Text.Trim = "", 0, Me.txtMachos.Text.Trim)
                oEntrada.NUM_HEMBRAS = IIf(Me.txtHembras.Text.Trim = "", 0, Me.txtHembras.Text.Trim)
                oEntrada.NUM_TORETES = IIf(Me.txtToretes.Text.Trim = "", 0, Me.txtToretes.Text.Trim)
                oEntrada.NUM_VAQUILLAS = IIf(Me.txtVaquillas.Text.Trim = "", 0, Me.txtVaquillas.Text.Trim)
                oEntrada.CORRALES = Me.txtCorrales.Text.Trim



            End If

            '''''''' ALTA DE PESO y FECHA ENTRADA
            If lOperacion = "A" Then
                oEntrada.PESO_ENTRADA = CDec(Me.txtPeso.Text.Trim)
                oEntrada.FECHA_ENTRADA = Format(Me.dtpFechaEntrada.Value, "dd/MM/yyyy")
            End If
            '''''''''''''''''''''''''''''''''''''''''''
            '''''''' MODIFICACION DE PESO Y FECHA SALIDA
            If lOperacion = "M" And oEntrada.PESO_SALIDA = 0 And Me.txtPeso.Text.Trim <> "" Then
                oEntrada.PESO_SALIDA = CDec(Me.txtPeso.Text.Trim)
                oEntrada.FECHA_SALIDA = Format(Today, "dd/MM/yyyy")
                'oEntrada.PESO_NETO = IIf(Me.txtKgsNeto.Text.Trim = "", 0, Me.txtKgsNeto.Text.Trim)
            End If

            'VEHICULO
            oEntrada.ID_Tipo_Vehiculo = Me.cmbTipoVehiculo.SelectedValue
            oEntrada.ID_Marca_Vehiculo = Me.cmbMarcaVehiculo.SelectedValue
            oEntrada.CONDUCTOR = Me.txtConductor.Text.Trim
            oEntrada.PLACAS = Me.txtPlacas.Text.Trim

            oEntrada.OBSERVACIONES = Me.txtObservaciones.Text.Trim

            'oEntrada.ESTATUS
            Dim lMensajeResulatado As String = ""
            oEntrada.Guardar(lMensajeResulatado, oEntrada.ID_ENTRADA, lOperacion)
            If oEntrada.ID_ENTRADA <> 0 Then
                Me.DespliegaDatos(oEntrada.ID_ENTRADA)
            End If

            MessageBox.Show(lMensajeResulatado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Cancelar()
        Try
            Dim lResp As Integer
            Dim lOperacion As String

            If oEntrada.ID_ENTRADA = 0 Then
                MessageBox.Show("Debes proporcionar el folio de entrada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFolio.Focus()
                Exit Sub
            Else
                lOperacion = "C"
            End If

            If oEntrada.ESTATUS = "C" Then
                MessageBox.Show("Esta entrada ya esta cancelada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtFolio.Focus()
                Exit Sub
            End If

            lResp = MessageBox.Show("¿Estas seguro de cancelar la entrada?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim lMensajeResulatado As String = ""
            oEntrada.Guardar(lMensajeResulatado, oEntrada.ID_ENTRADA, "C")
            If oEntrada.ID_ENTRADA <> 0 Then
                Me.DespliegaDatos(oEntrada.ID_ENTRADA)
            End If

            MessageBox.Show(lMensajeResulatado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

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
                lsTitulo = "CTE_ENTVEH_PRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCAINTRODUCTOR"
                lsTitulo = "CTE_ENTVEH_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCAPROVEEDOR"
                lsTitulo = "CTE_ENTVEH_PROVEEDOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case Else
                Exit Sub
        End Select


        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()


    End Sub

    Public Sub RegresaBuscarCteProductor(ByVal aCodigo As String)
        Me.txtMarcaProductor.Text = aCodigo
        Call Me.DespliegaCliente(1)
    End Sub

    Public Sub RegresaBuscarCteIntroductor(ByVal aCodigo As String)
        Me.txtMarcaIntroductor.Text = aCodigo
        Call Me.DespliegaCliente(2)
    End Sub

    Public Sub RegresaBuscarCteProveedor(ByVal aCodigo As String)
        Me.txtMarcaProveedor.Text = aCodigo
        Call Me.DespliegaCliente(3)
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 1
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oCteProductor)
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oCteIntroductor)
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProveedor, Me.txtNomProveedor, oCteProveedor)
        End Select
    End Sub

    Private Sub txtMarcaProductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaProductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.DespliegaCliente(1)
            If Me.oCteProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
        End If
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.DespliegaCliente(2)
            If Me.oCteIntroductor.ID_CLIENTE <> 0 Then Me.txtOrigen.Focus()
        End If
    End Sub

    Private Sub txtMarcaProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.DespliegaCliente(3)
            If Me.oCteProveedor.ID_CLIENTE <> 0 Then Me.txtOrigen.Focus()
        End If
    End Sub

    Private Sub txtNumMachosGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumMachosGuia.KeyPress, txtNumHembrasGuia.KeyPress, _
                    txtHembras.KeyPress, txtVaquillas.KeyPress, txtMachos.KeyPress, txtToretes.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumMachosGuia_Leave(sender As Object, e As EventArgs) Handles txtNumMachosGuia.Leave, txtNumHembrasGuia.Leave
        Me.SumaCabezasGuia()
    End Sub

    Private Sub SumaCabezasGuia()
        Dim lMachos As Integer
        Dim lHembras As Integer

        If Me.txtNumMachosGuia.Text.Trim = "" Then
            lMachos = 0
        Else
            lMachos = CInt(Me.txtNumMachosGuia.Text.Trim)
        End If


        If Me.txtNumHembrasGuia.Text.Trim = "" Then
            lHembras = 0
        Else
            lHembras = CInt(Me.txtNumHembrasGuia.Text.Trim)
        End If

        Me.txtTotalCabezasGuia.Text = lMachos + lHembras

    End Sub

    Private Sub txtMachos_Leave(sender As Object, e As EventArgs) Handles txtMachos.Leave, txtToretes.Leave, txtHembras.Leave, txtVaquillas.Leave
        Me.SumaCabezas()
    End Sub

    Private Sub SumaCabezas()
        Dim lMachos As Integer
        Dim lToretes As Integer
        Dim lHembras As Integer
        Dim lVaquillas As Integer

        If Me.txtMachos.Text.Trim = "" Then
            lMachos = 0
        Else
            lMachos = CInt(Me.txtMachos.Text.Trim)
        End If

        If Me.txtToretes.Text.Trim = "" Then
            lToretes = 0
        Else
            lToretes = CInt(Me.txtToretes.Text.Trim)
        End If

        If Me.txtHembras.Text.Trim = "" Then
            lHembras = 0
        Else
            lHembras = CInt(Me.txtHembras.Text.Trim)
        End If

        If Me.txtVaquillas.Text.Trim = "" Then
            lVaquillas = 0
        Else
            lVaquillas = CInt(Me.txtVaquillas.Text.Trim)
        End If

        Me.txtTotalCabezas.Text = lMachos + lToretes + lHembras + lVaquillas
    End Sub

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing
        'Dim dtReporte As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCAT_EntradaIndividual, ReportDocument)

            'Dim oClienteCatalogo As New clsCliente(0)
            'dtReporte = oEntrada.dt_ENTRADA
            If oEntrada.dt_ENTRADA.Rows.Count > 0 Then
                miReporte.SetDataSource(oEntrada.dt_ENTRADA)
                Dim frmReporte As New frmCRViewer
                frmReporte.MdiParent = Me.ParentForm
                frmReporte.crViewer.ReportSource = miReporte
                Me.Cursor = Cursors.Default
                frmReporte.WindowState = FormWindowState.Maximized
                frmReporte.Show()
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("No se encontro información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

  
End Class