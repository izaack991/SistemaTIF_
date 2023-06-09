Imports System.Data
Imports System.Data.SqlClient
Public Class frmListaPrecios
    Dim sIdProd As String
    Dim precio As Double

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)

        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = "SP_LISTAS_PRECIOS"

        CMD.Parameters.AddWithValue("@OP", 2)
        CMD.Parameters.AddWithValue("@ID_LISTA", Me.TXTID.Text)
        CMD.Parameters.AddWithValue("@ID_PROD", Me.sIdProd)
        CMD.Parameters.AddWithValue("@PRECIO", Me.TXTPRECIO.Text)
        CMD.Parameters.AddWithValue("@ID_CTE", Me.TXTIDCLIENTE.Text)
        CMD.Parameters.AddWithValue("@FECHA", Me.DTPFECHA.Value)
        Try
            CON.Open()
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            CON.Close()

        End Try
        Me.TMP_LISTA_PRECIOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.TMP_LISTA_PRECIOSTableAdapter.Fill(Me.DS_TMP_LISTA_PRECIOS.TMP_LISTA_PRECIOS, Me.TXTID.Text)
        Me.TXTIDINSUMO.Clear()
        Me.TXTNOMINSUMO.Clear()
        Me.TXTPRECIO.Clear()
        Me.TXTIDINSUMO.Focus()
    End Sub

    Private Sub TXTIDPROV_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTIDCLIENTE.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim B As New frmBusProveedor()
            B.ShowDialog()
            If B.DialogResult = Windows.Forms.DialogResult.OK Then
                If B.DataGridView1.RowCount > 0 Then
                    Me.TXTIDCLIENTE.Text = B.Ds_Proveedores.CLIENTES(B.CLIENTESBindingSource.Position).ID_CTE
                    Me.TXTNOCLIENTE.Text = B.Ds_Proveedores.CLIENTES(B.CLIENTESBindingSource.Position).NOMBRE
                    Me.TXTIDINSUMO.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnguardarlotefecha_Click(sender As Object, e As EventArgs) Handles btnguardarlotefecha.Click
        Me.GUARDAR()
        Me.LIMPIAR()
    End Sub
    Private Sub CONSECUTIVO()
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)
        Dim L As SqlDataReader

        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT ISNULL(MAX(ID_LISTA),0) + 1  AS CONSECUTIVO FROM MLISTA_PRECIOS"
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

    Private Sub frmListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_TMP_LISTA_PRECIOS.TMP_LISTA_PRECIOS' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DS_LISTA_PRECIOS.LISTA_PRECIOS' Puede moverla o quitarla según sea necesario.

        Me.CONSECUTIVO()
    End Sub

    Private Sub TXTIDINSUMO_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTIDINSUMO.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim b As New frmBusProdListaPrec(Me.TXTIDCLIENTE.Text)
            b.ShowDialog()
            If b.DialogResult = Windows.Forms.DialogResult.OK Then
                If b.DataGridView1.RowCount > 0 Then
                    Me.TXTIDINSUMO.Text = b.DS_BUS_PROD_CTE.PRODUCTOS_CTE(b.PRODUCTOSCTEBindingSource.Position).ID_PRODCTE
                    Me.sIdProd = b.DS_BUS_PROD_CTE.PRODUCTOS_CTE(b.PRODUCTOSCTEBindingSource.Position).ID_PROD
                    Me.TXTNOMINSUMO.Text = b.DS_BUS_PROD_CTE.PRODUCTOS_CTE(b.PRODUCTOSCTEBindingSource.Position).NOMBRE
                End If
            End If
        End If
        Me.TXTPRECIO.Focus()
       
    End Sub
    Private Sub GUARDAR()
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)

        CMD.CommandType = CommandType.StoredProcedure
        CMD.CommandText = "SP_LISTAS_PRECIOS"

        CMD.Parameters.AddWithValue("@OP", 1)
        CMD.Parameters.AddWithValue("@ID_LISTA", Me.TXTID.Text)
        CMD.Parameters.AddWithValue("@NOMBRE", Me.TXTNOMLISTA.Text)
        CMD.Parameters.AddWithValue("@FECHA", DTPFECHA.Value)
        CMD.Parameters.AddWithValue("@ID_CTE", Me.TXTIDCLIENTE.Text)

        Try
            CON.Open()
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            CON.Close()
        End Try
        For Each row As DataGridViewRow In DataGridView1.Rows
            precio = CDec(row.Cells(3).Value)
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "UPDATE PRODUCTOS_CTE SET PRECIO=" & precio & " WHERE ID_PROD='" & row.Cells(0).Value & "'"
            Try
                CON.Open()
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(Err.Description)
            Finally
                CON.Close()
            End Try
        Next
    End Sub
    Private Sub LIMPIAR()
        Me.CONSECUTIVO()
        Me.TXTID.Clear()
        Me.TXTNOCLIENTE.Clear()
        Me.TXTIDCLIENTE.Clear()
        Me.TXTNOMLISTA.Clear()
    End Sub
End Class