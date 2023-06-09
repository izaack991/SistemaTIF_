Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmCONS_Movimiento_EntSal
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oCliente As New clsCliente
    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Dim bMejorado As Boolean
    Dim iIdmov As Integer
    Public Sub New(bMejorado As Boolean)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.bMejorado = bMejorado
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Me.bMejorado = True Then
            iIdmov = 13
        Else
            iIdmov = 8
        End If
    End Sub
    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 0
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaCte, Me.txtNomCte, oCliente)
                If oCliente.Existe Then
                    Dim dt As DataTable

                    dt = oCliente.Almacenes

                    If dt.Rows.Count > 0 Then
                        Me.cmbAlmacenes.DataSource = dt
                        Me.cmbAlmacenes.ValueMember = dt.Columns("ID").ToString
                        Me.cmbAlmacenes.DisplayMember = dt.Columns("NOMBRE").ToString
                        Me.cmbAlmacenes.SelectedIndex = -1
                    End If
                Else
                    Me.cmbAlmacenes.DataSource = Nothing
                End If
        End Select
    End Sub

    Private Sub txtMarcaCte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaCte.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(0)
        End If
    End Sub

    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        If e.KeyCode = Keys.Enter Then
      
            If ValidaDatos() Then Me.DespliegaDatos()

            Me.txtFolio.SelectAll()

        End If
    End Sub

    Public Sub DespliegaDatos(Optional ByVal aID_ESC As Integer = 0)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            Dim lTipoOperacion As String = ""
            Dim lID_ALM As String = ""
            Dim lFolio As String = ""

            If aID_ESC = 0 Then
                lTipoOperacion = Me.cmbTipoEntrada.SelectedIndex + 1
                lID_ALM = Me.cmbAlmacenes.SelectedValue
                lFolio = Me.txtFolio.Text.Trim
                oMovimientoEntSal = New clsMovimientoEntSal(lID_ALM, lTipoOperacion, lFolio)
            Else
                oMovimientoEntSal = New clsMovimientoEntSal(aID_ESC)
            End If

            Me.btnCancelar.Enabled = False

            If oMovimientoEntSal.ID_ESC <> 0 Then

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

                oMovAlmacen = New clsMovimientoAlmacen(oMovimientoEntSal.ID_MOV)

                Dim i As Integer

                For i = 0 To Me.dgvDatos.Columns.Count - 1
                    Me.dgvDatos.Columns(i).Visible = False
                Next

                Select Case oMovimientoEntSal.ID_MOV
                    Case 1, 3 'GANADO EN PIE, PIELES
                        'Me.dgvDatos.Columns("DESTINO").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_PROD").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_INTR").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_DEST").Visible = True
                        Me.dgvDatos.Columns("SAC_LOTE").Visible = True
                        Me.dgvDatos.Columns("ID_PROD").Visible = True
                        Me.dgvDatos.Columns("NOM_PROD").Visible = True
                        Me.dgvDatos.Columns("PIEZAS").Visible = True
                        Me.dgvDatos.Columns("PESO").Visible = True
                        Me.dgvDatos.Columns("TARA").Visible = True
                        Me.dgvDatos.Columns("FECHA_ESD").Visible = True
                        Me.dgvDatos.Columns("HORA_ESD").Visible = True
                        'Me.dgvDatos.Columns("SAC_SERIE").Visible = True
                        'Me.dgvDatos.Columns("SAC_ID").Visible = True
                        'Me.dgvDatos.Columns("SAC_LADO").Visible = True
                        'Me.dgvDatos.Columns("SAC_SEXO").Visible = True
                        'Me.dgvDatos.Columns("SAC_MAYOR").Visible = True
                        'Me.dgvDatos.Columns("SAC_VACIADA").Visible = True
                        'Me.dgvDatos.Columns("SAC_ENMANTADO").Visible = True
                        Me.dgvDatos.Columns("PIEL_ARETE_CAMPANA").Visible = True
                        Me.dgvDatos.Columns("PIEL_ARETE_SAGARPA").Visible = True
                        Me.dgvDatos.Columns("PIEL_ARETE_INTRODUCTOR").Visible = True
                        Me.dgvDatos.Columns("DECOMISO").Visible = True
                        'Me.dgvDatos.Columns("OBSERVACIONES_ESD").Visible = True
                    Case 2, 8, 21 'CANALES
                        'Me.dgvDatos.Columns("DESTINO").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_PROD").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_INTR").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_DEST").Visible = True
                        Me.dgvDatos.Columns("SAC_LOTE").Visible = True
                        Me.dgvDatos.Columns("ID_PROD").Visible = True
                        Me.dgvDatos.Columns("NOM_PROD").Visible = True
                        Me.dgvDatos.Columns("PIEZAS").Visible = True
                        Me.dgvDatos.Columns("PESO").Visible = True
                        Me.dgvDatos.Columns("TARA").Visible = True
                        Me.dgvDatos.Columns("FECHA_ESD").Visible = True
                        Me.dgvDatos.Columns("HORA_ESD").Visible = True
                        'Me.dgvDatos.Columns("SAC_SERIE").Visible = True
                        'Me.dgvDatos.Columns("SAC_ID").Visible = True
                        Me.dgvDatos.Columns("SAC_LOTE_ORIGINAL").Visible = True
                        Me.dgvDatos.Columns("SAC_CONSEC").Visible = True
                        'Me.dgvDatos.Columns("SAC_LADO").Visible = True
                        Me.dgvDatos.Columns("SAC_SEXO").Visible = True
                        Me.dgvDatos.Columns("SAC_MAYOR").Visible = True
                        Me.dgvDatos.Columns("SAC_VACIADA").Visible = True
                        Me.dgvDatos.Columns("SAC_ENMANTADO").Visible = True
                        'Me.dgvDatos.Columns("PIEL_ARETE_CAMPANA").Visible = True
                        'Me.dgvDatos.Columns("PIEL_ARETE_SAGARPA").Visible = True
                        'Me.dgvDatos.Columns("PIEL_ARETE_INTRODUCTOR").Visible = True
                        Me.dgvDatos.Columns("DECOMISO").Visible = True
                        'Me.dgvDatos.Columns("OBSERVACIONES_ESD").Visible = True
                        Me.dgvDatos.Columns("SAC_SERIE_ID").Visible = True
                    Case 12, 13, 15, 17, 18, 19 '12 = CORTE, 13 = SALIDA DE CAJAS POR EMBARQUE, 15 = ENTRADA DE CAJAS POR CANCELACION DE SALIDA, 
                        '17 = ENTRADA DE CAJAS X DEVOLUCION, 18 = ENTRADA DE CAJAS X AJUSTE DE INVENTARIO, , 19 = SALIDA DE CAJAS X AJUSTE DE INVENTARIO
                        Me.dgvDatos.Columns("ID_PRODCTE").Visible = True
                        Me.dgvDatos.Columns("NOMBRE_PRODCTE").Visible = True
                        Me.dgvDatos.Columns("CAJA_SERIE_ID").Visible = True
                        Me.dgvDatos.Columns("PIEZAS").Visible = True
                        Me.dgvDatos.Columns("PESO").Visible = True
                        Me.dgvDatos.Columns("TARA").Visible = True
                        Me.dgvDatos.Columns("COR_LOTE").Visible = True
                        Me.dgvDatos.Columns("CAJA_CODBAR").Visible = True
                        Me.dgvDatos.Columns("FECHA_ESD").Visible = True
                        Me.dgvDatos.Columns("HORA_ESD").Visible = True
                        'Me.dgvDatos.Columns("OBSERVACIONES_ESD").Visible = True
                    Case Else
                        'Me.dgvDatos.Columns("DESTINO").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_PROD").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_INTR").Visible = True
                        'Me.dgvDatos.Columns("MARCA_CTE_DEST").Visible = True
                        Me.dgvDatos.Columns("SAC_LOTE").Visible = True
                        Me.dgvDatos.Columns("ID_PROD").Visible = True
                        Me.dgvDatos.Columns("NOM_PROD").Visible = True
                        Me.dgvDatos.Columns("PIEZAS").Visible = True
                        Me.dgvDatos.Columns("PESO").Visible = True
                        Me.dgvDatos.Columns("TARA").Visible = True
                        Me.dgvDatos.Columns("FECHA_ESD").Visible = True
                        Me.dgvDatos.Columns("HORA_ESD").Visible = True
                        Me.dgvDatos.Columns("OBSERVACIONES_ESD").Visible = True
                End Select

                    Select oMovimientoEntSal.ID_MOV
                    Case 11
                        Me.btnCancelar.Enabled = True
                End Select

                If oMovAlmacen.ID_OPER = 1 Then
                    Me.cmbTipoEntrada.SelectedIndex = 0
                Else
                    Me.cmbTipoEntrada.SelectedIndex = 1
                End If

                Me.txtFolio.Text = oMovimientoEntSal.FOLIO
                If oMovimientoEntSal.ID_MOV = 12 Then   'ENTRADA DE CAJAS POR CORTE
                    Me.txtLote.Text = oMovimientoEntSal.COR_LOTE
                Else
                    Me.txtLote.Text = oMovimientoEntSal.SAC_LOTE
                End If


                oCliente = New clsCliente(oMovimientoEntSal.ID_CTE_INTR)
                Me.txtMarcaCte.Text = oCliente.Marca
                Me.DespliegaCliente(0)

                Me.cmbAlmacenes.SelectedValue = oMovimientoEntSal.ID_ALM

                Me.dtpFechaMov.Value = oMovimientoEntSal.FECHA
                Me.txtNomMovto.Text = oMovimientoEntSal.NOMBRE_MOVIMIENTO

                Me.txtMarcaProductor.Text = oMovimientoEntSal.MARCA_PRODUCTOR
                Me.txtNomProductor.Text = oMovimientoEntSal.NOMBRE_PRODUCTOR

                oIntroductor = New clsCliente(oMovimientoEntSal.ID_CTE_INTR)
                Me.txtMarcaIntroductor.Text = oMovimientoEntSal.MARCA_INTRODUCTOR
                Me.txtNomIntroductor.Text = oMovimientoEntSal.NOMBRE_INTRODUCTOR

                oDestino = New clsCliente(oMovimientoEntSal.ID_CTE_DEST)
                Me.txtMarcaDestino.Text = oMovimientoEntSal.MARCA_DESTINO
                Me.txtNomDestino.Text = oMovimientoEntSal.NOMBRE_DESTINO

                Me.txtObservaciones.Text = oMovimientoEntSal.OBSERVACIONES

                If oMovimientoEntSal.ESTATUS = "A" Then
                    lblVigente.Visible = True
                    lblCancelado.Visible = False
                    btnCancelar.Enabled = True
                Else
                    lblVigente.Visible = False
                    lblCancelado.Visible = True
                    btnCancelar.Enabled = False
                End If

                Select Case oMovimientoEntSal.ID_MOV
                    Case 6, 7, 8, 11, 13, 18, 19, 21
                        '6  = SALIDA DE VISCERAS POR EMBARQUE
                        '7  = SALIDA DE VISCERAS POR DECOMISO
                        '8  = SALIDA DE CANALES POR EMBARQUE
                        '11 = SALIDA DE PIELES
                        '13 = SALIDA DE CAJAS POR EMBARQUE
                        '18 = ENTRADA CAJAS POR AJUSTE DE INVENTARIO
                        '19 = SALIDA CAJAS POR AJUSTE DE INVENTARIO
                        Me.btnCancelar.Enabled = True
                End Select
                Me.FormatoGrid()

            Else
                MessageBox.Show("No se encontró información para el movimiento proporcionado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Limpiar()
            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub FormatoGrid()
        If Me.dgvDatos.Rows.Count = 0 Then Exit Sub

        modFuncProc.FormatoGrid_MarcarDecomiso(Me.dgvDatos)
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos, "ESTATUS_ESD")
        modFuncProc.FormatoGrid_Marca300(Me.dgvDatos, "REV_CALIDAD")
    End Sub
    Private Function ValidaDatos() As Boolean

        ValidaDatos = False

        If Me.cmbTipoEntrada.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar el tipo de movimiento.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbTipoEntrada.Focus()
            Exit Function
        End If
        If Not oCliente.Existe Then
            MessageBox.Show("Debes seleccionar un cliente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtMarcaCte.Focus()
            Exit Function
        End If
        If Me.cmbAlmacenes.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar un tipo de almacén.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbAlmacenes.Focus()
            Exit Function
        End If

        ValidaDatos = True

    End Function

    Private Sub Limpiar()

        oMovimientoEntSal = New clsMovimientoEntSal
        oMovAlmacen = New clsMovimientoAlmacen

        oProductor = New clsCliente
        Me.txtMarcaProductor.Text = ""
        Me.txtNomProductor.Text = ""

        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""

        oDestino = New clsCliente
        Me.txtMarcaDestino.Text = ""
        Me.txtNomDestino.Text = ""

        oProducto = New clsProductos

        Me.txtFolio.Text = ""
        Me.txtLote.Text = ""
        Me.txtObservaciones.Text = ""

        Me.btnCancelar.Enabled = False

        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO.Clear()
        DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Clear()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Limpiar()
    End Sub

    Private Sub txtFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolio.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub Imprimir()
        Try
            Dim miReporte As ReportDocument

            Me.Cursor = Cursors.WaitCursor

            If oMovimientoEntSal.ID_ESC = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Select Case oMovimientoEntSal.ID_MOV
                Case 8  'salida de canales
                    Me.Imprimir_SalidaCanales()
                    Exit Sub
                Case 12 ' ENTRADA DE CAJAS POR CORTE
                    Me.Imprimir_EstudioCorte()
                    Exit Sub
                Case 13, 15 'salida de cajas
                    miReporte = Nothing
                    miReporte = CType(New crptCONS_SalidaCajas, ReportDocument)
                Case Else
                    miReporte = Nothing
                    miReporte = CType(New crptINV_EntSal, ReportDocument)
            End Select

            'modFuncProc.Imprimir_CrystalReport(oMovimientoEntSal.ID_ESC, DsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)
            modFuncProc.Imprimir_CrystalReport(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmCONS_Movimiento_EntSal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.FormatoGrid()
    End Sub

    Private Sub dgvDatos_Sorted(sender As Object, e As EventArgs) Handles dgvDatos.Sorted
        Me.FormatoGrid()
    End Sub
    Private Sub Imprimir_SalidaCanales()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
         
            Me.DsSacrificio.SP_CONS_ENTSAL_SALIDA_CANALES.Clear()

            lSql = "EXECUTE SP_CONS_ENTSAL_SALIDA_CANALES " & oMovimientoEntSal.ID_MOV & ", " & oMovimientoEntSal.ID_ALM & ", " & oMovimientoEntSal.FOLIO

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

    Private Sub Imprimir_EstudioCorte()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String

            Me.DsCajas.SP_CONS_ESTUDIO_CORTE.Clear()
            Me.DsCajas.SP_CONS_ESTUDIO_CORTE_MP.Clear()
            lSql = "EXECUTE SP_CONS_ESTUDIO_CORTE " & oMovimientoEntSal.ID_CORTE.ToString & ",'A'," & iIdmov

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsCajas.SP_CONS_ESTUDIO_CORTE)

            lCmd.Dispose()
            Dim query As String
            Dim comando As New SqlCommand("", Cnn)
            query = "EXECUTE SP_CONS_ESTUDIO_CORTE_MP " & oMovimientoEntSal.ID_CORTE.ToString & ",'A'," & iIdmov
            'oMovimientoEntSal.ID_MOV.ToString
            comando.CommandType = CommandType.Text
            comando.CommandText = query
            Dim da1 As New SqlDataAdapter(comando)
            da1.Fill(Me.DsCajas.SP_CONS_ESTUDIO_CORTE_MP)
            comando.Dispose()
            If Me.DsCajas.SP_CONS_ESTUDIO_CORTE.Rows.Count = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptREP_EstudioCorte, ReportDocument)
            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte
            miReporte.SetDataSource(Me.DsCajas.Tables("SP_CONS_ESTUDIO_CORTE"))
            miReporte.Subreports(0).SetDataSource(Me.DsCajas.Tables("SP_CONS_ESTUDIO_CORTE_MP"))
            frmReporte.Show()
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim frmPassword As New frmUTIL_Contrasena
        Dim oParametros As New clsParametros(17)
        If oMovimientoEntSal.ID_MOV = 13 Then
            frmPassword.ShowDialog(frmUTIL_Contrasena)
            If frmPassword.txtPassword.Text.Trim = oParametros.PASSCAJAS Then
                frmPassword.Dispose()
                Me.Cancelar(oMovimientoEntSal.ID_ESC)
            Else
                frmPassword.Dispose()
                MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        If oMovimientoEntSal.ID_MOV = 8 Or oMovimientoEntSal.ID_MOV = 1 Or oMovimientoEntSal.ID_MOV = 2 Or oMovimientoEntSal.ID_MOV = 3 Then
            frmPassword.ShowDialog(frmUTIL_Contrasena)
            If frmPassword.txtPassword.Text.Trim = oParametros.PASSCANALES Then
                frmPassword.Dispose()
                Me.Cancelar(oMovimientoEntSal.ID_ESC)
            Else
                frmPassword.Dispose()
                MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        If oMovimientoEntSal.ID_MOV = 6 Or oMovimientoEntSal.ID_MOV = 7 Then
            frmPassword.ShowDialog(frmUTIL_Contrasena)
            If frmPassword.txtPassword.Text.Trim = oParametros.PASSVISCERAS Then
                frmPassword.Dispose()
                Me.Cancelar(oMovimientoEntSal.ID_ESC)
            Else
                frmPassword.Dispose()
                MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub Cancelar(ByVal aID_ESC As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim lResp As Integer
            Dim lMensajeResultado As String = ""
            Dim lCmd As New SqlClient.SqlCommand
            Dim lMensaje As String = ""

            Dim lp0 As New SqlClient.SqlParameter
            Dim lp1 As New SqlClient.SqlParameter
            Dim lp2 As New SqlClient.SqlParameter
            Dim lp3 As New SqlClient.SqlParameter
            Dim lpErrorSP As New SqlClient.SqlParameter

            If aID_ESC = 0 Then
                MessageBox.Show("No ha indicado el movimiento que desea cancelar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lResp = MessageBox.Show("¿Estas seguro de cancelar este movimiento?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            Else
                lResp = MessageBox.Show("¿Realmente estas seguro de cancelar este movimiento? Este operación no se podrá deshacer.", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If lResp = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            If oMovimientoEntSal.ID_MOV = 8 Then 'SALIDA DE CANALES POR EMBARQUE
                'PROCEDURE SP_CANCELACION_SALIDA_CAJNALES
                '@ID_ESC		 INTEGER = 0,
                '@USUARIO		 INTEGER = 0,
                '@FOLIO_GENERADO INTEGER OUTPUT,
                '@ERRORSP    	 VARCHAR(300)OUTPUT

                lCmd.Connection = Cnn
                lCmd.CommandText = "SP_CANCELACION_SALIDA_CANALES"
                lCmd.CommandType = CommandType.StoredProcedure

                lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
                lp0.Direction = ParameterDirection.ReturnValue

                lp1 = lCmd.Parameters.Add("ID_ESC", SqlDbType.Int)
                lp2 = lCmd.Parameters.Add("USUARIO", SqlDbType.Int)

                lp3 = lCmd.Parameters.Add("FOLIO_GENERADO", SqlDbType.Int)
                lp3.Direction = ParameterDirection.Output

                lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
                lpErrorSP.Direction = ParameterDirection.Output

                lp1.Value = aID_ESC
                lp2.Value = goUsuario

                lCmd.ExecuteNonQuery()

                If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                    'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                    lMensaje = Trim(lpErrorSP.Value)
                Else
                    lMensaje = "La información se guardó correctamente."
                End If

                lCmd = Nothing

            ElseIf oMovimientoEntSal.ID_MOV = 13 Or oMovimientoEntSal.ID_MOV = 19 Then '13 = SALIDA DE CAJAS POR EMBARQUE, 19 = SALIDA DE CAJAS POR AJUSTE DE INV.
                'PROCEDURE SP_CANCELACION_SALIDA_CAJAS
                '@ID_ESC		 INTEGER = 0,
                '@USUARIO		 INTEGER = 0,
                '@FOLIO_GENERADO INTEGER OUTPUT,
                '@ERRORSP    	 VARCHAR(300)OUTPUT

                lCmd.Connection = Cnn
                lCmd.CommandText = "SP_CANCELACION_SALIDA_CAJAS"
                lCmd.CommandType = CommandType.StoredProcedure

                lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
                lp0.Direction = ParameterDirection.ReturnValue

                lp1 = lCmd.Parameters.Add("ID_ESC", SqlDbType.Int)
                lp2 = lCmd.Parameters.Add("USUARIO", SqlDbType.Int)

                lp3 = lCmd.Parameters.Add("FOLIO_GENERADO", SqlDbType.Int)
                lp3.Direction = ParameterDirection.Output

                lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
                lpErrorSP.Direction = ParameterDirection.Output

                lp1.Value = aID_ESC
                lp2.Value = goUsuario

                lCmd.ExecuteNonQuery()

                If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                    'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                    lMensaje = Trim(lpErrorSP.Value)
                Else
                    lMensaje = "La información se guardó correctamente."
                End If

                lCmd = Nothing

            Else
                'PROCEDURE SP_CONS_ENTSAL_X_MOVTO_CANCELACION
                '@ID_ESC	INTEGER
                '@ERRORSP    VARCHAR(300) OUTPUT

                lCmd.Connection = Cnn
                lCmd.CommandText = "SP_CONS_ENTSAL_X_MOVTO_CANCELACION"
                lCmd.CommandType = CommandType.StoredProcedure

                lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
                lp0.Direction = ParameterDirection.ReturnValue

                lp1 = lCmd.Parameters.Add("ID_ESC", SqlDbType.Int)

                lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
                lpErrorSP.Direction = ParameterDirection.Output

                lp1.Value = aID_ESC

                lCmd.ExecuteNonQuery()

                If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                    'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                    lMensaje = Trim(lpErrorSP.Value)
                Else
                    lMensaje = "La información se guardó correctamente."
                End If

                lCmd = Nothing
            End If

            MessageBox.Show(lMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DespliegaDatos()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmCONS_Movimiento_EntSal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblVigente.Visible = True Then
            lblCancelado.Visible = False
            btnCancelar.Enabled = True
        Else
            lblVigente.Visible = False
            lblCancelado.Visible = True
            btnCancelar.Enabled = False
        End If
    End Sub
End Class