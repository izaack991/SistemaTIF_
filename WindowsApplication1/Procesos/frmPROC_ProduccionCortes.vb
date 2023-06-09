Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Public Class frmPROC_ProduccionCortes
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos
    Dim oCorte As clsCortes
    Dim loEtiqueta As clsEtiqueta
    Dim oMovimientoEntSal1 As clsMovimientoEntSal
    Dim oMovAlmacen1 As clsMovimientoAlmacen
    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Dim oCaja As clsMovimientoEntSal
    Dim iPesadaManual As String
    Dim iPrimeraVez As Boolean = True
    Dim iAlmacen As Integer
    Dim iFolio As Integer
    Dim iIdesc As Integer
    Dim r As dsENTSALDET_TMP.ENTSAL_DETRow
    Dim iEsd As Integer
    Dim iUsuario As Integer
    Dim iCEXP As Integer
    Dim bTDOBIEN As Boolean
    Dim oCorteMejorado As clsCortes
    Dim oCajaVerfica As clsMovimientoEntSal
    Dim oCajaVerficasalida As clsMovimientoEntSal

    Private Sub cargaralmacen()
        iAlmacen = oIntroductor.ID_ALM_CAJ
    End Sub
    'Private Sub cargaridesc()
    '    Dim cmd As New SqlCommand("select isnull(max(id_Esc),0) + 1 as id_Esc from entsal", Cnn)
    '    Dim l As SqlDataReader
    '    Try
    '        Cnn.Open()
    '        l = cmd.ExecuteReader
    '        If l.Read Then
    '            iIdesc = l("id_Esc")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(Err.Description)
    '    Finally
    '        Cnn.Close()
    '        l.Close()
    '    End Try
    'End Sub
    'Private Sub cargarfoliosalida()
    '    Dim cmd As New SqlCommand("select ISNULL(MAX(folio),0) as folio from ENTSAL where ID_MOV =13 and ID_CTE_INTR =" & oIntroductor.ID_CLIENTE, Cnn)
    '    Dim l As SqlDataReader
    '    Try
    '        Cnn.Open()
    '        l = cmd.ExecuteReader
    '        If l.Read Then
    '            iFolio = l("folio")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(Err.Description)
    '    Finally
    '        Cnn.Close()
    '    End Try
    'End Sub
    Private Sub frmPROC_ProduccionCortes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                Me.AgregarProducto()
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
            Case Keys.F5
                Me.LeerPeso()
            Case Keys.F6
                '''''''''''''''LeerPesoTara()
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

        Me.chkMayor.Checked = False
        oProducto = New clsProductos
        'Me.cmbProductos.Enabled = True

        oCaja = New clsMovimientoEntSal
        Me.txtSM.Text = ""
        Me.txtIndicaciones.Text = ""
        Me.txtObservaciones.Text = ""

        Me.lblCaducidad.Text = ""
        Me.lblRefrigeracion.Text = ""

        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO.Clear()
        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Clear()


    End Sub

    Private Sub frmPROC_ProduccionCortes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_ENTSAL_DET_MEJ.ENTSAL_DET' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DsENTSALDET_TMP.ENTSAL_DET' Puede moverla o quitarla según sea necesario.
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
        oMovAlmacen1 = New clsMovimientoAlmacen(13)
        oMovimientoEntSal1 = New clsMovimientoEntSal

        Me.CargarDatosIniciales()

        If Not goPermisosValidaciones.PesadaManual_SalaCortes Then Me.txtPeso.ReadOnly = True

    End Sub

    Private Sub CargarDatosIniciales()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo As SqlClient.SqlDataAdapter
            Dim lSql As String

            lSql = "EXECUTE SP_CONS_INF_ETIQUETAS '%', 2"
            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_INF_ETIQUETAS").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_INF_ETIQUETAS")

            daCatalogo.Dispose()

            Me.cmbEtiquetas.SelectedIndex = 0

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub txtCodProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DespliegaProducto()
            Me.numPiezas.Focus()
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
                    Me.iCEXP = oProducto.ID_CEXP
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
    Private Sub DespliegaDatos1()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            '@ID_MOV	INTEGER,
            '@ID_ALM	INTEGER,
            '@ID_PROD	CHAR(6),
            '@ESTATUS	CHAR(1)	= 'A',
            '@PROCESADO	CHAR(1) = 'N'

            lSql = "SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS " & Me.cmbalmacen.SelectedValue

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Clear()
            da.Fill(DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS)

            da.Dispose()
            lCmd.Dispose()

            '  Me.lblCajasDisponibles.Text = "Cajas disponibles" & " (" & Me.DsCajas.SP_CONS_ENTSAL_ENCDET_X_ALMACEN_CAJAS.Rows.Count & ")"

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub
    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            'Case 1
            '    modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor)
            '    If oProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
                If oIntroductor.ID_CLIENTE <> 0 Then
                    Me.DespliegaDatos1()
                End If
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                If oDestino.ID_CLIENTE <> 0 Then
                    'If Me.txtPeso.Enabled = True And Me.txtPeso.ReadOnly = False Then
                    'Me.txtCodProd.Focus()
                    'End If
                End If
        End Select
    End Sub
    Public Sub cargarusuario(ByVal iUsuario As Integer)
        Me.iUsuario = iUsuario
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
                MessageBox.Show("No ha seleccionado ninguna caja para la salida.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lResp = MessageBox.Show("¿Deseas generar la salida de cajas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
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

            lOperacion = "3"    'SALIDA DE CAJAS


            loMovimientoEntSalTMP.OPERACION = lOperacion
            loMovimientoEntSalTMP.ID_MOV = oMovAlmacen.ID_MOV
            loMovimientoEntSalTMP.ID_ALM = Me.cmbalmacen.SelectedValue
            loMovimientoEntSalTMP.ID_CTE_INTR = oIntroductor.ID_CLIENTE
            loMovimientoEntSalTMP.ID_CTE_DEST = oDestino.ID_CLIENTE
            loMovimientoEntSalTMP.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loMovimientoEntSalTMP.FECHA_FRIO = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            loMovimientoEntSalTMP.OBSERVACIONES_FRIO = Me.txtObservaciones.Text.Trim
            loMovimientoEntSalTMP.USUARIO = iUsuario

            If loMovimientoEntSalTMP.Guardar_MovtoAgrupadoTMP(lMensajeResultado, lFolioGenerado) Then
                ' Me.DespliegaDatos(0)
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

           

            oMovimientoEntSal.OPERACION = lOperacion
            oMovimientoEntSal.ID_ESC = oMovimientoEntSal.ID_ESC
            oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
            oMovimientoEntSal.ID_ALM = Me.cmbalmacen.SelectedValue
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
            oMovimientoEntSal.USUARIO = iUsuario
            'oMovimientoEntSal.USUARIO_CANC
            'oMovimientoEntSal.ID_ESC_REF
            'oMovimientoEntSal.ESTATUS
            'oMovimientoEntSal.ID_ESD
            oMovimientoEntSal.ID_CTE_DET = oDestino.ID_CLIENTE
            oMovimientoEntSal.ID_PROD = oProducto.ID_PROD
            oMovimientoEntSal.PIEZAS = Me.numPiezas.Value
            oMovimientoEntSal.PESO = (CDec(Me.txtPeso.Text.Trim) - CDec(Me.TXTTARA.Text.Trim))
            oMovimientoEntSal.TARA = Me.TXTTARA.Text.Trim
            oMovimientoEntSal.FECHA_ESD = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.CAJA_FECHA_ETIQ = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            'oMovimientoEntSal.SAC_SERIE
            'oMovimientoEntSal.SAC_ID
            'oMovimientoEntSal.SAC_LADO
            'oMovimientoEntSal.SAC_SEXO = lSexo
            oMovimientoEntSal.SAC_MAYOR = IIf(Me.chkMayor.Checked, 1, 0)
            'oMovimientoEntSal.SAC_VACIADA
            'oMovimientoEntSal.SAC_ENMANTADO
            'oMovimientoEntSal.PIEL_ARETE_CAMPAÑA = Me.txtAreteCampaña.Text.Trim
            'oMovimientoEntSal.PIEL_ARETE_SAGARPA = Me.txtAreteSAGARPA.Text.Trim
            'oMovimientoEntSal.PIEL_ARETE_INTRODUCTOR = Me.txtAreteIntroductor.Text.Trim
            'oMovimientoEntSal.DECOMISO = IIf(Me.chkDecomiso.Checked, 1, 0)
            'oMovimientoEntSal.OBSERVACIONES_ESD
            'oMovimientoEntSal.ID_ESD_REF
            'oMovimientoEntSal.ESTATUS_ESD
            If oMovimientoEntSal.PESO <= 45 Then
                If oMovimientoEntSal.Guardar(lMensajeResultado, lId_ESC) Then
                    If Me.CHKMEJORADO.Checked = True Then
                        Dim lCmd As New SqlClient.SqlCommand
                        Try
                            lCmd.Connection = Cnn
                            lCmd.CommandText = "SP_GUARDAPRODUCTO_MEJORADO"
                            lCmd.CommandType = CommandType.StoredProcedure

                            lCmd.Parameters.AddWithValue("@op", 1)
                            lCmd.Parameters.AddWithValue("@fecha", Me.dtpFechaMov.Value)
                            lCmd.Parameters.AddWithValue("@ID_CORTE", Me.txtidcortemejorado.Text)
                            lCmd.Parameters.AddWithValue("@COR_LOTE", Me.TXTLOTEMEJORADO.Text)
                            lCmd.Parameters.AddWithValue("@ID_CTE_INTR", oDestino.ID_CLIENTE)
                            lCmd.Parameters.AddWithValue("@ID_PROD", oProducto.ID_PROD)
                            lCmd.Parameters.AddWithValue("@PROD_PADRE", oProducto.ID_PROD_CTE)
                            lCmd.Parameters.AddWithValue("@PESO", (CDec(Me.txtPeso.Text.Trim) - CDec(Me.TXTTARA.Text.Trim)))
                            lCmd.ExecuteNonQuery()

                        Catch ex As Exception
                            Call modGeneral.ManejaExcepcion(ex)
                        End Try
                        Me.DespliegaDatos(lId_ESC)
                        Exit Sub
                    End If
                  
                    If Me.chkbafar.Checked = True Then
                        generaetiqueta(oMovimientoEntSal.ID_ESD)
                        Me.DespliegaDatos(lId_ESC)
                    Else
                        If Me.iCEXP = 0 Then
                            loEtiqueta = New clsEtiqueta(2, oMovimientoEntSal.ID_ESD, 2)
                            If Me.chkIndicaciones.Checked Then
                                'loEtiqueta.Genera_Etiqueta_Cortes(oCorte.INDICACIONES)
                                loEtiqueta.Genera_Etiqueta_Cortes(Me.txtIndicaciones.Text.Trim, True)
                                modGeneral.ImprimirUltimaEtiquetaCorte()
                                'modGeneral.ImprimirUltimaEtiquetaCorte()
                            Else
                                loEtiqueta.Genera_Etiqueta_Cortes()
                                modGeneral.ImprimirUltimaEtiquetaCorte()
                                'modGeneral.ImprimirUltimaEtiquetaCorte()
                            End If
                        Else
                            loEtiqueta = New clsEtiqueta(3, oMovimientoEntSal.ID_ESD, 2)
                            If Me.chkIndicaciones.Checked Then
                                'loEtiqueta.Genera_Etiqueta_Cortes_Exportacion(oCorte.INDICACIONES, oCorte.SHIPPINGMARK)
                                loEtiqueta.Genera_Etiqueta_Cortes_Exportacion(Me.txtIndicaciones.Text.Trim, oCorte.SHIPPINGMARK)
                                modGeneral.ImprimirUltimaEtiquetaCorte()
                                'modGeneral.ImprimirUltimaEtiquetaCorte()
                                ' generaetiqueta(oMovimientoEntSal.ID_ESD, oCorte.SHIPPINGMARK)
                            Else
                                loEtiqueta.Genera_Etiqueta_Cortes_Exportacion("", oCorte.SHIPPINGMARK)
                                'generaetiqueta(oMovimientoEntSal.ID_ESD, oCorte.SHIPPINGMARK)
                                modGeneral.ImprimirUltimaEtiquetaCorte()
                                'modGeneral.ImprimirUltimaEtiquetaCorte()
                            End If
                        End If

                        Me.DespliegaDatos(lId_ESC)

                        Me.txtPeso.Text = ""
                        Me.txtCodProd.Focus()
                    End If
                End If
            Else
                If MessageBox.Show("La caja es mayor a 45 kg esta seguro que desea agregarla?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    If MessageBox.Show("La caja pesa arriba del promedio estas seguro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        If oMovimientoEntSal.Guardar(lMensajeResultado, lId_ESC) Then
                            If Me.CHKMEJORADO.Checked = True Then
                                Dim lCmd As New SqlClient.SqlCommand
                                Try
                                    lCmd.Connection = Cnn
                                    lCmd.CommandText = "SP_GUARDAPRODUCTO_MEJORADO"
                                    lCmd.CommandType = CommandType.StoredProcedure

                                    lCmd.Parameters.AddWithValue("@op", 1)
                                    lCmd.Parameters.AddWithValue("@fecha", Me.dtpFechaMov.Value)
                                    lCmd.Parameters.AddWithValue("@ID_CORTE", Me.txtidcortemejorado.Text)
                                    lCmd.Parameters.AddWithValue("@COR_LOTE", Me.TXTLOTEMEJORADO.Text)
                                    lCmd.Parameters.AddWithValue("@ID_CTE_INTR", oDestino.ID_CLIENTE)
                                    lCmd.Parameters.AddWithValue("@ID_PROD", oProducto.ID_PROD)
                                    lCmd.Parameters.AddWithValue("@PROD_PADRE", oProducto.ID_PROD_CTE)
                                    lCmd.Parameters.AddWithValue("@PESO", (CDec(Me.txtPeso.Text.Trim) - CDec(Me.TXTTARA.Text.Trim)))
                                    lCmd.ExecuteNonQuery()

                                Catch ex As Exception
                                    Call modGeneral.ManejaExcepcion(ex)
                                End Try
                                Me.DespliegaDatos(lId_ESC)
                                Exit Sub
                            End If
                            If Me.chkbafar.Checked = True Then
                                generaetiqueta(oMovimientoEntSal.ID_ESD)
                            Else
                                If Me.iCEXP = 0 Then
                                    loEtiqueta = New clsEtiqueta(2, oMovimientoEntSal.ID_ESD, 2)
                                    If Me.chkIndicaciones.Checked Then
                                        'loEtiqueta.Genera_Etiqueta_Cortes(oCorte.INDICACIONES)
                                        loEtiqueta.Genera_Etiqueta_Cortes(Me.txtIndicaciones.Text.Trim, True)
                                        modGeneral.ImprimirUltimaEtiquetaCorte()
                                        'modGeneral.ImprimirUltimaEtiquetaCorte()
                                    Else
                                        loEtiqueta.Genera_Etiqueta_Cortes()
                                        modGeneral.ImprimirUltimaEtiquetaCorte()
                                        'modGeneral.ImprimirUltimaEtiquetaCorte()
                                    End If
                                Else
                                    loEtiqueta = New clsEtiqueta(3, oMovimientoEntSal.ID_ESD, 2)
                                    If Me.chkIndicaciones.Checked Then
                                        'loEtiqueta.Genera_Etiqueta_Cortes_Exportacion(oCorte.INDICACIONES, oCorte.SHIPPINGMARK)
                                        loEtiqueta.Genera_Etiqueta_Cortes_Exportacion(Me.txtIndicaciones.Text.Trim, oCorte.SHIPPINGMARK)
                                        modGeneral.ImprimirUltimaEtiquetaCorte()
                                        'modGeneral.ImprimirUltimaEtiquetaCorte()
                                        ' generaetiqueta(oMovimientoEntSal.ID_ESD, oCorte.SHIPPINGMARK)
                                    Else
                                        loEtiqueta.Genera_Etiqueta_Cortes_Exportacion(, oCorte.SHIPPINGMARK)
                                        'generaetiqueta(oMovimientoEntSal.ID_ESD, oCorte.SHIPPINGMARK)
                                        modGeneral.ImprimirUltimaEtiquetaCorte()
                                        'modGeneral.ImprimirUltimaEtiquetaCorte()
                                    End If
                                End If

                                Me.DespliegaDatos(lId_ESC)

                                Me.txtPeso.Text = ""
                                Me.txtCodProd.Focus()
                            End If
                        End If
                    End If
                End If
            End If

            'MessageBox.Show(lMensajeResultado, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub generaetiqueta(iIdesd As Integer)
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String

        Me.DsCajas.SP_IMPRIMIR_ET_EXP.Clear()

        lSql = " exec SP_IMPRIMIR_ET_EXP '" & iIdesd & "'"

        lCmd.Connection = Cnn
        lCmd.CommandType = CommandType.Text
        lCmd.CommandText = lSql

        Dim da As New SqlDataAdapter(lCmd)
        da.Fill(Me.DsCajas.SP_IMPRIMIR_ET_EXP)

        lCmd.Dispose()

        If Me.DsCajas.SP_IMPRIMIR_ET_EXP.Rows.Count = 0 Then
            MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim miReporte As ReportDocument = Nothing
        miReporte = CType(New crpt_IMP_ETIQ_PROD, ReportDocument)

        miReporte.SetDataSource(Me.DsCajas.Tables("SP_IMPRIMIR_ET_EXP"))
        Dim frmReporte As New frmCRViewer
        frmReporte.MdiParent = Me.ParentForm
        frmReporte.crViewer.ReportSource = miReporte

        'frmReporte.Show()
        'Dim CrExportOptions As ExportOptions
        'Dim CrDiskFileDestinationOptions As New  _
        'DiskFileDestinationOptions()
        'Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        'CrDiskFileDestinationOptions.DiskFileName = _
        '                            "D:\ETIQUETAS\crystalExport.pdf"
        'CrExportOptions = miReporte.ExportOptions
        'With CrExportOptions
        '    .ExportDestinationType = ExportDestinationType.DiskFile
        '    .ExportFormatType = ExportFormatType.PortableDocFormat
        '    .DestinationOptions = CrDiskFileDestinationOptions
        '    .FormatOptions = CrFormatTypeOptions
        'End With
        miReporte.PrintToPrinter(1, False, 0, 1)
        Me.txtPeso.Text = ""
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
    Private Sub llenaralmacen()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim dt As New DataTable()
        Dim dsalmacenes As New DataSet
        Dim Da As New SqlDataAdapter

        lCmd.Connection = Cnn

        With lCmd
            .CommandType = CommandType.Text
            .CommandText = "Select * From ALMACENES WHERE ID_CTE=" & oIntroductor.ID_CLIENTE & " and NOMBRE = 'CAJAS TEMPORAL' OR NOMBRE LIKE '%GRASA%' ORDER BY NOMBRE"
            .Connection = Cnn
        End With
        Da.SelectCommand = lCmd
        dt = New DataTable
        Da.Fill(dt)
        With Me.cmbalmacen
            .DataSource = dt
            .DisplayMember = "NOMBRE"
            .ValueMember = "ID_ALM"
        End With

    End Sub
    Private Sub FormatoGrid()
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos, "ESTATUS_ESD")
    End Sub
    'Private Sub FormatoGrid1()
    '    Dim x As Integer
    '    Dim y As Integer
    '    Dim X_ID_ESD As Long
    '    Dim y_ID_ESD As Long

    '    For x = 0 To Me.dgvdatos1.RowCount - 1
    '        X_ID_ESD = Me.dgvdatos1.Rows(x).Cells("ID_ESD_TMP").Value
    '        For y = 0 To Me.dgvDisponibles.RowCount - 1
    '            y_ID_ESD = Me.dgvDisponibles.Rows(y).Cells("ID_ESD").Value
    '            If X_ID_ESD = y_ID_ESD Then
    '                Me.dgvDisponibles.Rows(y).DefaultCellStyle.BackColor = Color.Orange
    '            End If
    '        Next
    '    Next

    'End Sub

    Private Function ValidaDatos1() As Boolean
        Try
            ValidaDatos1 = False

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
    Private Sub btnCodBar_Click(sender As Object, e As EventArgs)
        'If Me.Valida_CodBar() Then
        '    Me.agregarcajas()
        'End If
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
        If e.KeyCode = Keys.Enter Then
            Me.txtPeso.Focus()
        End If
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
    Private Sub LeerPesoTara()
        Try
            Dim ldcPeso As Decimal = 0
            Dim lsPeso As String = ""

            Me.Cursor = Cursors.WaitCursor

            lsPeso = modFuncProc.ReceiveSerialData()

            If IsNumeric(lsPeso) Then
                Me.Pesartara(CDec(lsPeso))
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
    Private Sub Pesartara(Optional ByVal aPeso As Decimal = -999)
        Try

            Dim ldcPeso As Decimal

            If aPeso = -999 Then
                If Not IsNumeric(Me.TXTTARA.Text.Trim) Then
                    MsgBox("El peso proporcionado manualmente no es válido." & vbNewLine & vbNewLine & "Capture el peso e intente de nuevo.", MsgBoxStyle.Exclamation, gProyecto)
                    Me.TXTTARA.SelectAll()
                    Me.TXTTARA.Focus()
                    Exit Sub
                Else
                    ldcPeso = CDec(Me.TXTTARA.Text.Trim)
                End If
                iPesadaManual = "M"
            Else
                ldcPeso = aPeso
                iPesadaManual = ""
            End If

            If ldcPeso <> 0 Then
                Me.TXTTARA.Text = Format(ldcPeso, "#,##0.00")
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
        Me.validadcajasalmacen(Strings.Right(Me.dgvDatos.CurrentRow.Cells("CAJA_SERIE_ID").Value, 6))
        ' Me.validadcajasalmacensala(Strings.Right(Me.dgvDatos.CurrentRow.Cells("CAJA_SERIE_ID").Value, 6))
        If bTDOBIEN = True Then
            Dim frmPassword As New frmUTIL_Contrasena
            Dim oParametros As New clsParametros(17)
            If Me.txtIdMovto.Text = 12 Then
                frmPassword.ShowDialog(frmUTIL_Contrasena)
                If frmPassword.txtPassword.Text.Trim = oParametros.CAD2 Then
                    frmPassword.Dispose()
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
                    loMovimientoAlmacen.ID_MOV = 12
                    loMovimientoAlmacen.ID_ESD = Me.dgvDatos.CurrentRow.Cells("ID_ESD").Value
                    loMovimientoAlmacen.OPERACION = "D"
                    loMovimientoAlmacen.CAJA_ID = Strings.Right(Me.dgvDatos.CurrentRow.Cells("CAJA_SERIE_ID").Value, 6)

                    If loMovimientoAlmacen.Guardar(lMensaje) Then
                        Me.DespliegaDatos(oMovimientoEntSal.ID_ESC)
                    Else
                        MessageBox.Show(lMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    frmPassword.Dispose()
                    MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Else
            MessageBox.Show("Es necesario transferir la caja para cancelar")

            Exit Sub

        End If

    End Sub
    Private Sub validadcajasalmacen(id_caja As Integer)
        oCajaVerfica = New clsMovimientoEntSal(1, "A" & id_caja)
        oCajaVerficasalida = New clsMovimientoEntSal(2, "A" & id_caja)

        If oCajaVerfica.NOMBRE_ALMACEN = "CAJAS" Or oCajaVerficasalida.NOMBRE_ALMACEN = "CAJAS" Then
            MessageBox.Show("Esta caja se encuentra en almacen de producto terminado o ya se le dio salida")
            bTDOBIEN = False
        Else
            bTDOBIEN = True
        End If
    End Sub
    Private Sub validadcajasalmacensala(id_caja As Integer)
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim l As SqlDataReader
        
        lSql = "select top 1 caja_id from entsal_det d " & _
        "inner join entsal e on d.id_esc = e.id_Esc " & _
        "inner join movimientos m on e.id_mov = m.id_mov " & _
        "inner join almacenes a on E.id_alm = a.id_alm " & _
        "where E.id_mov in (12,25) and a.nombre like '%TEMPORAL%' and caja_id =" & id_caja & "ORDER BY d.HORA DESC"
        lCmd.Connection = Cnn
        lCmd.CommandType = CommandType.StoredProcedure
        lCmd.CommandText = lSql
        l = lCmd.ExecuteReader
        Try
            If l.Read Then
                bTDOBIEN = True
            Else
                bTDOBIEN = False
            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally

            l.Close()
        End Try
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
            oCorte = New clsCortes(Me.txtIDCorte.Text.Trim, , , , , , , , , 12)
            'Me.Limpiar()
            If oCorte.ESTADO_CORTE = True Then
                MessageBox.Show("Este corte se encuentra cerrado")
            Else

                Me.Despliega_Datos_Del_Corte()
                Me.txtIDCorte.SelectAll()
                Me.txtCodProd.Focus()
            End If

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
            llenaralmacen()

            Me.DespliegaCliente(2)

            oDestino = New clsCliente(oCorte.ID_CTE_DEST)
            Me.txtMarcaDestino.Text = oDestino.Marca
            Me.DespliegaCliente(3)

            Me.dtpFechaMov.Value = oCorte.FECHA
            Me.txtLote.Text = oCorte.COR_LOTE

            Me.txtSM.Text = oCorte.SHIPPINGMARK
            Me.txtIndicaciones.Text = oCorte.INDICACIONES
            Me.txtObservaciones.Text = oCorte.OBSERVACIONES

            Me.txtCodProd.Enabled = True

            Me.DespliegaDatos(oCorte.ID_ESC)
            Me.CHKMEJORADO.Checked = False
            Me.txtidcortemejorado.Clear()
            Me.TXTLOTEMEJORADO.Clear()
        Else
            Me.txtCodProd.Enabled = False
        End If
    End Sub
    Private Sub Despliega_Datos_Del_Cortemejorado()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""

        ' Me.Limpiar()

        If oCorteMejorado.ID_CORTE <> 0 Then

            Me.txtidcortemejorado.Text = oCorteMejorado.ID_CORTE

            Me.TXTLOTEMEJORADO.Text = oCorteMejorado.COR_LOTE

        Else
            Me.txtCodProd.Enabled = False
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarProducto()
    End Sub
    Private Sub txtIDCorte_KeyUp(sender As Object, e As KeyEventArgs) Handles txtIDCorte.KeyUp
        If e.KeyCode = Keys.Enter Then
            cargaralmacen()
            'cargarfoliosalida()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidcortemejorado.KeyDown
        If e.KeyCode = Keys.Enter Then
            oCorteMejorado = New clsCortes(Me.txtidcortemejorado.Text.Trim)
            'Me.Limpiar()
            Me.Despliega_Datos_Del_Cortemejorado()
            
        End If
    End Sub

    Private Sub CHKMEJORADO_CheckedChanged(sender As Object, e As EventArgs) Handles CHKMEJORADO.CheckedChanged
        If Me.CHKMEJORADO.Checked = True Then
            Me.txtidcortemejorado.Enabled = True
            Me.TXTLOTEMEJORADO.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ImprimirReporte()
    End Sub
    Private Sub ImprimirReporte()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String

            Me.DsCajas.SP_REPORTE_MEJORADO.Clear()

            lSql = "SP_REPORTE_MEJORADO " & Val(Me.txtIDCorte.Text)

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsCajas.SP_REPORTE_MEJORADO)

            lCmd.Dispose()

            If Me.DsCajas.SP_REPORTE_MEJORADO.Rows.Count = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Me.DsCajas.SP_MP_MEJORADO.Clear()
            lSql = "SP_MP_MEJORADO " & Val(Me.txtIDCorte.Text)
            lCmd.CommandText = lSql
            Dim da1 As New SqlDataAdapter(lCmd)
            da1.Fill(Me.DsCajas.SP_MP_MEJORADO)

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crpt_MEJORADO, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsCajas.Tables("SP_REPORTE_MEJORADO"))
            miReporte.Subreports(0).SetDataSource(Me.DsCajas.Tables("SP_MP_MEJORADO"))

            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BTNAGREGARMP_Click(sender As Object, e As EventArgs) Handles BTNAGREGARMP.Click
        If Me.TXTFOLIO.Text <> "" Then
            Me.guardar_MP()
        End If
    End Sub

    Private Sub TXTFOLIO_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTFOLIO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ENTSAL_DETTableAdapter1.Fill(Me.DS_ENTSAL_DET_MEJ.ENTSAL_DET, Me.TXTFOLIO.Text, oIntroductor.ID_CLIENTE)
        End If
    End Sub
    Private Sub guardar_MP()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String
        Dim dt As New DataTable()
        'Dim lCodAlmacen As String

        '   Dim CON As New SqlConnection(ConnectionString)
        Try

            lSql = "SP_AGREGA_CAJAS_MEJORADO"


            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.StoredProcedure
            lCmd.CommandText = lSql

            lCmd.Parameters.AddWithValue("@op", 1)
            lCmd.Parameters.AddWithValue("@COR_LOTE", Me.txtLote.Text)

            lCmd.Parameters.AddWithValue("@ID_CORTE", Me.txtIDCorte.Text)
            lCmd.Parameters.AddWithValue("@ID_CTE", oIntroductor.ID_CLIENTE)
            lCmd.Parameters.AddWithValue("@FOLIO", Me.TXTFOLIO.Text)

            lCmd.ExecuteNonQuery()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            MessageBox.Show("Sus datos se guardaron correctamente")
            'Me.Limpiar()
        End Try
    End Sub
End Class