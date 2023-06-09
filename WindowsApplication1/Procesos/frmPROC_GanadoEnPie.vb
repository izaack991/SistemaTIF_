﻿Imports System.Data.SqlClient

Public Class frmPROC_GanadoEnPie
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim oMovAlmacen As clsMovimientoAlmacen
    Dim oProducto As clsProductos

    Dim oProductor As New clsCliente
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente

    Dim iPesadaManual As String
    Dim iUsuario As Integer
    Dim dTOTAL_CANTIDAD As Double
    Dim dTOTAL_MACHOS As Double
    Dim dTOTAL_HEMBRAS As Double
    Dim iHEMBRAS As Integer
    Dim iMACHOS As Integer
    Dim bHembras As Boolean
    Dim bMachos As Boolean
    Dim bMixto As Boolean
    Dim bPShembras As Boolean
    Dim bPSmachos As Boolean
    Private Sub frmPROC_GanadoEnPie_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                lsTitulo = "CTE_GANPIE_PRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCAINTRODUCTOR"
                lsTitulo = "CTE_GANPIE_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
            Case "TXTMARCADESTINO"
                lsTitulo = "CTE_GANPIE_DESTINO"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
                'Case "TXTLOTE"
                '    lsTitulo = "LOTES_SACRIFICIO"
                '    lsCampoBusqueda = "NOM_ORIGEN"
                '    'liColumnaCodigo = 3
                '    lValor1 = dtpFechaMov.Value
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
    Public Sub cargarusuario(ByVal iUsuario As Integer)
        Me.iUsuario = iUsuario
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

        Me.cmbProductos.SelectedIndex = -1
        Me.cmbProductos.Enabled = True

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

        Me.txtAreteCampaña.Text = ""
        Me.txtAreteSAGARPA.Text = ""
        Me.txtAreteIntroductor.Text = ""

        Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE.Clear()

        Me.txtPeso.Text = ""
        rdbHembra.Enabled = False
        Me.rdbMacho.Enabled = False
        Me.rdbVaquilla.Enabled = False

    End Sub

    Private Sub frmPROC_Sacrificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGA EL MOVIMIENTO DE REGISTRO DE GANADO EN PIE
        oMovAlmacen = New clsMovimientoAlmacen(1)
        oMovimientoEntSal = New clsMovimientoEntSal
        oProducto = New clsProductos

        Me.dtpFechaMov.Value = Today

        Me.CargaProductos()

        If oMovAlmacen.Existe Then
            Me.txtIdMovto.Text = oMovAlmacen.ID_MOV
            Me.txtNomMovto.Text = oMovAlmacen.Nombre_Movimiento
        End If

        If Not goPermisosValidaciones.PesadaManual_GanadoEnPie Then Me.txtPeso.ReadOnly = True
        Me.txtLote.Focus()
    End Sub

    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            'Dim lDR As SqlDataReader = Nothing
            Dim dt As New DataTable()
            Dim lID_Movto As Integer = 1    'ENTRADA DE GANADO EN PIE

            lSql = "SP_CONS_PRODUCTOS '', '%', 3"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            Me.cmbProductos.DataSource = dt
            Me.cmbProductos.DisplayMember = "NOMBRE"
            Me.cmbProductos.ValueMember = "ID_PROD"

            lCmd.Dispose()

            Me.cmbProductos.SelectedIndex = -1
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
    '        If oProducto.ID_FAM <> 3 Then
    '            MessageBox.Show("El producto no pertenece a la familia de ganado en pie.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

            lResp = MessageBox.Show("¿Deseas guardar los datos de la pesada?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            If Me.rdbMacho.Checked = True Then
                lSexo = "M"
            Else
                lSexo = "H"
            End If

            If Not Me.ValidaDatos() Then Exit Sub

            If oMovimientoEntSal.ID_ESC = 0 Then
                lOperacion = "A"
            Else
                lOperacion = "A"
            End If

           

            If lSexo = "H" And bHembras = True Then
                MessageBox.Show("La cantidad de hembras excede a las programadas en el lote")
                Exit Sub
            End If
            If lSexo = "M" And bMachos = True Then
                MessageBox.Show("La cantidad de machos excede a los programados en el lote")
                Exit Sub
            End If
            oMovimientoEntSal.OPERACION = lOperacion
            oMovimientoEntSal.ID_ESC = oMovimientoEntSal.ID_ESC
            oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
            oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_GAN
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
            oMovimientoEntSal.USUARIO = Me.iUsuario
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
            'oMovimientoEntSal.SAC_SERIE
            'oMovimientoEntSal.SAC_ID
            'oMovimientoEntSal.SAC_LADO
            oMovimientoEntSal.SAC_SEXO = lSexo
            'oMovimientoEntSal.SAC_MAYOR
            'oMovimientoEntSal.SAC_VACIADA
            'oMovimientoEntSal.SAC_ENMANTADO
            oMovimientoEntSal.PIEL_ARETE_CAMPAÑA = Me.txtAreteCampaña.Text.Trim
            oMovimientoEntSal.PIEL_ARETE_SAGARPA = Me.txtAreteSAGARPA.Text.Trim
            oMovimientoEntSal.PIEL_ARETE_INTRODUCTOR = Me.txtAreteIntroductor.Text.Trim
            oMovimientoEntSal.DECOMISO = IIf(Me.chkDecomiso.Checked, 1, 0)
            oMovimientoEntSal.TEMPERATURA = ""

            'oMovimientoEntSal.OBSERVACIONES_ESD
            'oMovimientoEntSal.ID_ESD_REF
            'oMovimientoEntSal.ESTATUS_ESD

            If oMovimientoEntSal.Guardar(lMensajeResultado, lId_ESC) Then
                oMovimientoEntSal = New clsMovimientoEntSal(lId_ESC)
                Me.txtPeso.Text = ""
                Me.txtAreteCampaña.Text = ""
                Me.txtAreteSAGARPA.Text = ""
                Me.txtAreteIntroductor.Text = ""
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
            Dim dCANTIDAD As Double
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
            iHEMBRAS = 0
            iMACHOS = 0
            dCANTIDAD = 0
            If Me.dgvDatos.RowCount > 0 Then
                Dim sSEXO As String
                Dim lEstatus As String
                For Each fila As DataGridViewRow In Me.dgvDatos.Rows
                    sSEXO = fila.Cells("SEXO").Value
                    lEstatus = fila.Cells(24).Value
                    If sSEXO = "H" And lEstatus = "A" Then
                        iHEMBRAS = iHEMBRAS + 1
                    End If
                    If sSEXO = "M" And lEstatus = "A" Then
                        iMACHOS = iMACHOS + 1
                    End If
                Next
               
            End If

            If bPShembras = True Then
                If iHEMBRAS < Me.dTOTAL_HEMBRAS Then

                Else
                    MessageBox.Show("La cantidad de animales excede a los programados en el lote")
                    Exit Function
                    bHembras = True
                End If
            End If
            If bPSmachos = True Then
                If iMACHOS < Me.dTOTAL_MACHOS Then
                Else
                    MessageBox.Show("La cantidad de animales excede a los programados en el lote")
                    Exit Function
                    bMachos = True
                End If
            End If
            If bMixto = True Then
                dCANTIDAD = iMACHOS + iHEMBRAS
                If dCANTIDAD < dTOTAL_CANTIDAD Then

                Else
                    MessageBox.Show("La cantidad de animales excede a los programados en el lote")
                    Exit Function
                End If

               
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
                'If Not goPermisosValidaciones.Validacion_LotesSinEntradaVehiculos Then
                '    If Not goPermisosValidaciones.ExisteLoteEntrada(Me.txtLote.Text.Trim) Then
                '        MessageBox.Show("El lote proporcionado no tiene registro de una entrada de ganado." & vbNewLine & vbNewLine & _
                '                         "No puede continuar con la captura.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        Exit Sub
                '    End If
                'End If

                ' modFuncProc.Muestra_Pertenencia_Lote(Me.txtLote.Text.Trim)

                Dim lID_ESC As Integer
                oMovimientoEntSal.FECHA = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
                oMovimientoEntSal.SAC_LOTE = Me.txtLote.Text.Trim
                oMovimientoEntSal.ID_MOV = oMovAlmacen.ID_MOV
                oMovimientoEntSal.ID_ALM = oIntroductor.ID_ALM_GAN

                lID_ESC = oMovimientoEntSal.ID_x_ENTRADA_LOTE_MOVIMIENTO

                If lID_ESC <> 0 Then
                    llenardatoslote(Me.txtLote.Text)
                    oMovimientoEntSal = New clsMovimientoEntSal(lID_ESC)

                    Me.DespliegaDatos()

                    Me.txtLote.Enabled = False
                    Me.dtpFechaMov.Enabled = False
                    Me.txtPeso.Focus()
                End If
                Me.CargarcantidadesLote()
               
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
                Me.txtMarcaProductor.Text = l("MARCA_ORI")
                Me.txtMarcaIntroductor.Text = l("MARCA_ORI")
                Me.txtMarcaDestino.Text = l("MARCA_DEST")
                Me.cmbProductos.SelectedValue = l("ID_ESPECIE")
                Me.cmbProductos.Enabled = False
                Me.txtMarcaProductor.Enabled = False
                 bMixto = l("BMIXTO")
                bPShembras = l("BHEMBRAS")
                bPSmachos = l("BMACHOS")
                If bMixto = True Then
                    Me.rdbHembra.Enabled = True
                    Me.rdbMacho.Enabled = True
                    Me.rdbVaquilla.Enabled = False
                End If
                If bPShembras = True Then
                    Me.rdbHembra.Checked = True
                    Me.rdbMacho.Checked = False
                    Me.rdbVaquilla.Checked = False
                    Me.rdbHembra.Enabled = True
                    Me.rdbMacho.Enabled = False
                End If
                If bPSmachos = True Then
                    Me.rdbHembra.Checked = False
                    Me.rdbMacho.Checked = True
                    Me.rdbVaquilla.Checked = False
                    Me.rdbHembra.Enabled = False
                    Me.rdbMacho.Enabled = True
                End If
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
        oProducto = New clsProductos(Me.cmbProductos.SelectedValue.ToString.Trim)
    End Sub
    Private Sub CargarcantidadesLote()
        Dim l As SqlDataReader
        Dim lCmd As New SqlClient.SqlCommand()

        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_PROG_SACRIFICIO"
            lCmd.CommandType = CommandType.StoredProcedure

            lCmd.Parameters.AddWithValue("@op", 5)
            lCmd.Parameters.AddWithValue("@sac_lote", Me.txtLote.Text)
            l = lCmd.ExecuteReader()
            If l.Read Then
                Me.dTOTAL_CANTIDAD = l("CANTIDAD")
                Me.dTOTAL_MACHOS = l("MACHOS")
                Me.dTOTAL_HEMBRAS = l("HEMBRAS")
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Exit Sub
        Finally
            l.Close()
        End Try

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

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE.Clear()
            lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE 1, '" & oMovimientoEntSal.FECHA & "', " & oMovimientoEntSal.SAC_LOTE & ", '%'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da1 As New SqlDataAdapter(lCmd)
            da1.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE)

            If Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_LOTE_GANPIE.Rows.Count > 0 Then Me.FormatoGrid()
            lCmd.Dispose()
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

    Private Sub dgvDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatos.KeyDown

        If Me.dgvDatos.RowCount = 0 Then Exit Sub

        If e.KeyCode <> Keys.Delete Then Exit Sub
        Dim frmPassword As New frmUTIL_Contrasena
        Dim oParametros As New clsParametros(17)
        If Me.txtIdMovto.Text = 1 Then
            frmPassword.ShowDialog(frmUTIL_Contrasena)
            If frmPassword.txtPassword.Text.Trim = oParametros.PASSCANALES Then
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

                loMovimientoAlmacen.ID_ESD = Me.dgvDatos.CurrentRow.Cells("ID_ESD").Value
                loMovimientoAlmacen.OPERACION = "D"
                loMovimientoAlmacen.USUARIO = Me.iUsuario
                loMovimientoAlmacen.USUARIO_CANC = Me.iUsuario
                If loMovimientoAlmacen.Guardar(lMensaje) Then
                    Me.DespliegaDatos()
                Else
                    MessageBox.Show(lMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                frmPassword.Dispose()
                MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
       
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

    Private Sub txtLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLote.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPeso_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPeso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Guardar()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Nuevo()
    End Sub

    Private Sub btnguardarlotefecha_Click(sender As Object, e As EventArgs) Handles btnguardarlotefecha.Click
        Me.Guardar()
    End Sub

    Private Sub txtLote_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLote.KeyUp
        If e.KeyCode = Keys.F3 Then
            Dim bPS As New fRM_BUSQUEDA_PS(Me.dtpFechaMov.Value)
            bPS.ShowDialog()
            If bPS.DataGridView1.Rows.Count > 0 Then
                If bPS.DialogResult = Windows.Forms.DialogResult.OK Then
                    Me.txtLote.Text = bPS.DS_PROG_SACRI.SACRIFICIO(bPS.SACRIFICIOBindingSource.Position).SAC_LOTE
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim bPS As New fRM_BUSQUEDA_PS(Me.dtpFechaMov.Value)
        bPS.ShowDialog()
        If bPS.DataGridView1.Rows.Count > 0 Then
            If bPS.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.txtLote.Text = bPS.DS_PROG_SACRI.SACRIFICIO(bPS.SACRIFICIOBindingSource.Position).SAC_LOTE
            End If
        End If
        Me.txtLote.Focus()
    End Sub
End Class