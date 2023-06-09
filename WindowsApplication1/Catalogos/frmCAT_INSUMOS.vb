Imports System.Data
Imports System.Data.SqlClient
Public Class frmCAT_INSUMOS
    Dim iConsecutivo As String
    Private Sub frmCAT_INSUMOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_CATINSUMOS.INSUMOS' Puede moverla o quitarla según sea necesario.
        Me.INSUMOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.INSUMOSTableAdapter.Fill(Me.DS_CATINSUMOS.INSUMOS)
        Me.CONSECUTIVO()
    End Sub
    Private Sub guardar()
        Dim con As New SqlConnection(ConnectionString)
        Dim cmd As New SqlCommand("", con)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_INSUMOS"
        cmd.Parameters.AddWithValue("@OP", 1)
        cmd.Parameters.AddWithValue("@ID_INSUMO", Me.TXTID.Text)
        cmd.Parameters.AddWithValue("@NOMBRE", Me.TXTNOMBRE.Text)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el insumo")
        Finally
            con.Close()
            Me.TXTID.Clear()
            Me.TXTNOMBRE.Clear()
        End Try
        Me.INSUMOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.INSUMOSTableAdapter.Fill(Me.DS_CATINSUMOS.INSUMOS)
    End Sub

    Private Sub btnguardarlotefecha_Click(sender As Object, e As EventArgs) Handles btnguardarlotefecha.Click
        Me.guardar()
        Me.CONSECUTIVO()
    End Sub
    Private Sub CONSECUTIVO()
        Dim CON As New SqlConnection(ConnectionString)
        Dim CMD As New SqlCommand("", CON)
        Dim L As SqlDataReader

        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT ISNULL(MAX(ID_INSUMO),'') + 1 AS CONSECUTIVO FROM INSUMOS"
        Try
            CON.Open()
            L = CMD.ExecuteReader
            If L.Read Then
                Me.TXTID.Text = L("CONSECUTIVO")
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener el consecutivo")
        Finally
            CON.Close()
            L.Close()

        End Try
       

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.TXTID.Text = Me.DS_CATINSUMOS.INSUMOS(Me.INSUMOSBindingSource.Position).ID_INSUMO
        Me.TXTNOMBRE.Text = Me.DS_CATINSUMOS.INSUMOS(Me.INSUMOSBindingSource.Position).NOMBRE
    End Sub
End Class