Imports System.Data
Imports System.Data.SqlClient
Public Class fmrPROC_COMPRAS_INSUMOS
    Dim dTotal As Double
    Dim precio As Double

    Private Sub fmrPROC_COMPRAS_INSUMOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_TMPCOMPRAS.TMP_COMPRASMOVTOS' Puede moverla o quitarla según sea necesario.
       
        Me.CONSECUTIVO()
    End Sub
    Private Sub CONSECUTIVO()
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)
        Dim L As SqlDataReader

        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT ISNULL(MAX(ID_COMPRA),0) + 1  AS CONSECUTIVO FROM COMPRAS"
        Try
            CON.Open()
            L = CMD.ExecuteReader
            If L.Read Then
                Me.TXTID.Text = L("CONSECUTIVO")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el consecutivo")
        Finally
            CON.Close()
            L.Close()
        End Try
    End Sub

    Private Sub TXTIDPROV_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTIDPROV.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim B As New frmBusProveedor()
            B.ShowDialog()
            If B.DialogResult = DialogResult.OK Then
                If B.DataGridView1.RowCount > 0 Then
                    Me.TXTIDPROV.Text = B.Ds_Proveedores.CLIENTES(B.CLIENTESBindingSource.Position).ID_CTE
                    Me.TXTNOMPROV.Text = B.Ds_Proveedores.CLIENTES(B.CLIENTESBindingSource.Position).NOMBRE
                    Me.TXTIDINSUMO.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TXTIDINSUMO_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTIDINSUMO.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim B As New frmBusInsumos()
            B.ShowDialog()
            If B.DialogResult = DialogResult.OK Then
                If B.DataGridView1.RowCount > 0 Then
                    Me.TXTIDINSUMO.Text = B.DS_BUSINSUMOS.INSUMOS(B.INSUMOSBindingSource.Position).ID_INSUMO
                    Me.TXTNOMINSUMO.Text = B.DS_BUSINSUMOS.INSUMOS(B.INSUMOSBindingSource.Position).NOMBRE
                    Me.TXTCANTIDAD.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)

        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = "SP_COMPRAS_INSUMOS"

        CMD.Parameters.AddWithValue("@OP", 2)
        CMD.Parameters.AddWithValue("@ID_COMPRA", Me.TXTID.Text)
        CMD.Parameters.AddWithValue("@ID_PROV", Me.TXTIDPROV.Text)
        CMD.Parameters.AddWithValue("@FECHA", Me.DTPFECHA.Value)
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
        Me.TMP_COMPRASMOVTOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.TMP_COMPRASMOVTOSTableAdapter.Fill(Me.DS_TMPCOMPRAS.TMP_COMPRASMOVTOS)
        Me.TXTIDINSUMO.Clear()
        Me.TXTNOMINSUMO.Clear()
        Me.TXTCANTIDAD.Clear()
        Me.TXTPRECIO.Clear()
        Me.dTotal = Format(CDec(CType(Me.DS_TMPCOMPRAS.TMP_COMPRASMOVTOS.Compute("sum(Importe)", Nothing), Double)), "#,##0.00")
        Me.TXTTOTAL.Text = dTotal
    End Sub
    Private Sub GUARDAR()
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)

        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = "SP_COMPRAS_INSUMOS"

        CMD.Parameters.AddWithValue("@OP", 1)
        CMD.Parameters.AddWithValue("@ID_COMPRA", Me.TXTID.Text)
        CMD.Parameters.AddWithValue("@ID_PROV", Me.TXTIDPROV.Text)
        CMD.Parameters.AddWithValue("@FECHA", Me.DTPFECHA.Value)
        CMD.Parameters.AddWithValue("@IMPORTE", Me.TXTTOTAL.Text)

        Try
            CON.Open()
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            CON.Close()

        End Try
        For Each row As DataGridViewRow In DataGridView1.Rows
            precio = CDec(row.Cells(4).Value)
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "UPDATE INSUMOS SET COSTO=" & precio & " WHERE ID_INSUMO=" & row.Cells(0).Value
            Try
                CON.Open()
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(Err.Description)
            Finally
                CON.Close()
            End Try
        Next
        MessageBox.Show("Sus datos se guardaron correctamente")
       
    End Sub

    Private Sub btnguardarlotefecha_Click(sender As Object, e As EventArgs) Handles btnguardarlotefecha.Click
        Me.GUARDAR()
        Me.limpiar()
    End Sub
    Private Sub limpiar()
        Me.CONSECUTIVO()
        Me.TXTIDPROV.Clear()
        Me.TXTNOMPROV.Clear()
        Me.TMP_COMPRASMOVTOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.TMP_COMPRASMOVTOSTableAdapter.Fill(Me.DS_TMPCOMPRAS.TMP_COMPRASMOVTOS)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)

        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = "SP_COMPRAS_INSUMOS"

        CMD.Parameters.AddWithValue("@OP", 3)
        CMD.Parameters.AddWithValue("@ID_COMPRA", Me.DS_TMPCOMPRAS.TMP_COMPRASMOVTOS(TMPCOMPRASMOVTOSBindingSource.Position).ID_COMPRA)
        CMD.Parameters.AddWithValue("@ID_INSUMO", Me.DS_TMPCOMPRAS.TMP_COMPRASMOVTOS(TMPCOMPRASMOVTOSBindingSource.Position).ID_INSUMO)
       

        Try
            CON.Open()
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            CON.Close()

        End Try
        Me.TMP_COMPRASMOVTOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.TMP_COMPRASMOVTOSTableAdapter.Fill(Me.DS_TMPCOMPRAS.TMP_COMPRASMOVTOS)
        Me.TXTIDINSUMO.Clear()
        Me.TXTNOMINSUMO.Clear()
        Me.TXTCANTIDAD.Clear()
        Me.TXTPRECIO.Clear()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Me.limpiar()
    End Sub
End Class