Imports System.Data
Imports System.Data.SqlClient
Public Class frmPROC_COSTEO
    Dim oCorte As clsCortes
    Dim oIntroductor As New clsCliente
    Dim oMovimientoEntSal As clsMovimientoEntSal
    Dim dTotal As Double
    Dim iIDLOTE As Integer
    Dim dIMPventa As Double
    Private Sub frmPROC_COSTEO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_LOTE_PROCESABLE.TMP_LOTEPROCESABLE' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim b As New frmBusquedaCortes
        b.ShowDialog()
        If b.DataGridView1.RowCount > 0 Then

            oCorte = New clsCortes(b.DsBusCortes.CORTES(b.CORTESBindingSource.Position).ID_CORTE, , , , , , , , , 12)
            'Me.Limpiar()
            If oCorte.ESTADO_CORTE = True Then
                MessageBox.Show("Este corte se encuentra cerrado")
            Else
                Me.txtidcorte.Text = b.DsBusCortes.CORTES(b.CORTESBindingSource.Position).ID_CORTE
                Me.Despliega_Datos_Del_Corte()
                Me.txtIDCorte.SelectAll()
                Me.CARGARMP(b.DsBusCortes.CORTES(b.CORTESBindingSource.Position).ID_CORTE)
            End If

        End If
    End Sub
    Private Sub CARGARMP(ID_CORTE As Integer)
        Dim lCmd As New SqlClient.SqlCommand("")
        Dim lSql As String
        Dim L As SqlDataReader
   
        lSql = "Select SUM(PESO) AS MP From ENTSAL E INNER JOIN ENTSAL_DET D ON E.ID_ESC = D.ID_ESC WHERE ID_MOV = 8 AND ID_CORTE=" & ID_CORTE
        lCmd.Connection = Cnn
        lCmd.CommandType = CommandType.Text
        lCmd.CommandText = lSql
        L = lCmd.ExecuteReader
        Try
            If L.Read Then
                Me.TXTMP.Text = L("MP")
            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally

            L.Close()
        End Try

    End Sub
    Private Sub Despliega_Datos_Del_Corte()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""


        If oCorte.ID_CORTE <> 0 Then

            'Me.txtidcorte.Text = oCorte.ID_CORTE

            oIntroductor = New clsCliente(oCorte.ID_CTE_INTR)
            Me.txtmarcaintroductor.Text = oIntroductor.Marca


            Me.DespliegaCliente(2)


            ' Me.dIMPventa = Format(CDec(CType(Me.DS_LOTE_PROCESABLE.TMP_LOTEPROCESABLE.Compute("sum(Importe_Venta)", Nothing), Double)), "#,##0.00")

            Me.DespliegaDatos(oCorte.ID_ESC)


        End If
    End Sub
    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            'Case 1
            '    modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor)
            '    If oProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtmarcaintroductor, Me.txtnomintroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()


        End Select
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
                Me.txtmarcaintroductor.Text = oIntroductor.Marca
                Me.DespliegaCliente(2)

                'oDestino = New clsCliente(oMovimientoEntSal.ID_CTE_DET)
                'Me.txtMarcaDestino.Text = oDestino.Marca
                'Me.DespliegaCliente(3)





                lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_RESUMEN " & oMovimientoEntSal.ID_ESC

                lCmd.Connection = Cnn
                lCmd.CommandType = CommandType.Text
                lCmd.CommandText = lSql

                Dim da2 As New SqlDataAdapter(lCmd)
                DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Clear()
                da2.Fill(DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN)

                da2.Dispose()
                lCmd.Dispose()
                Me.dIMPventa = Format(CDec(CType(Me.DsSacrificio.SP_CONS_ENTSAL_X_MOVTO_RESUMEN.Compute("sum(IMPORTE_VENTA)", Nothing), Double)), "#,##0.00")
                Me.txtimpventa.Text = dIMPventa
                If Me.txtimpventa.Text <> "0" Then
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        row.Cells(7).Value = CDec(row.Cells(8).Value) / Me.dIMPventa
                        row.Cells(5).Value = ((row.Cells(7).Value) * CDec(Me.TXTTOTAL.Text)) / row.Cells(3).Value
                    Next
                End If

            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub TXTIDINSUMO_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTIDINSUMO.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim B As New frmBusInsumos()
            B.ShowDialog()
            If B.DialogResult = DialogResult.OK Then
                If B.DataGridView1.RowCount > 0 Then
                    Me.TXTIDINSUMO.Text = B.DS_BUSINSUMOS.INSUMOS(B.INSUMOSBindingSource.Position).ID_INSUMO
                    Me.TXTNOMINSUMO.Text = B.DS_BUSINSUMOS.INSUMOS(B.INSUMOSBindingSource.Position).NOMBRE
                    Me.TXTPRECIO.Text = B.DS_BUSINSUMOS.INSUMOS(B.INSUMOSBindingSource.Position).COSTO
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)

        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = "SP_LOTES_PROCESABLES"

        CMD.Parameters.AddWithValue("@OP", 2)
        CMD.Parameters.AddWithValue("@ID_LOTE", Me.iIDLOTE)
        CMD.Parameters.AddWithValue("@ID_INSUMO", Me.TXTIDINSUMO.Text)
        CMD.Parameters.AddWithValue("@CANTIDAD", Me.TXTCANTIDAD.Text)
        CMD.Parameters.AddWithValue("@PRECIO", Me.TXTPRECIO.Text)

        Try
            CON.Open()
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            CON.Close()

        End Try
        Me.TMP_LOTEPROCESABLETableAdapter.Connection.ConnectionString = ConnectionString
        Me.TMP_LOTEPROCESABLETableAdapter.Fill(Me.DS_LOTE_PROCESABLE.TMP_LOTEPROCESABLE)
        Me.dTotal = Format(CDec(CType(Me.DS_LOTE_PROCESABLE.TMP_LOTEPROCESABLE.Compute("sum(Importe)", Nothing), Double)), "#,##0.00")
        Me.TXTTOTAL.Text = dTotal
        Me.TXTIDINSUMO.Clear()
        Me.TXTNOMINSUMO.Clear()
        Me.TXTPRECIO.Clear()
        Me.TXTCANTIDAD.Clear()
    End Sub
    Private Sub CONSECUTIVO_LOTE()

    End Sub
    Private Sub CONSECUTIVO()
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)
        Dim L As SqlDataReader

        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT ISNULL(MAX(ID_LOTE),0) + 1  AS CONSECUTIVO FROM MLOTES_PROCESABLES"
        Try
            CON.Open()
            L = CMD.ExecuteReader
            If L.Read Then
                Me.iIDLOTE = L("CONSECUTIVO")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el consecutivo")
        Finally
            CON.Close()
            L.Close()
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Despliega_Datos_Del_Corte()


    End Sub
End Class