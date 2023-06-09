Imports System.Data
Imports System.Data.SqlClient
Public Class frmGenerarArchivos

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cargarpedidos()
    End Sub
    Private Sub cargarpedidos()
        If Cnn.State = ConnectionState.Open Then
            Cnn.Close()
        End If
        Dim cmd As New SqlCommand("", Cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_bulk_surtido"
        Try
            Cnn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Las cajas se agregaron correctamente")
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            Cnn.Close()
        End Try
    End Sub
    Private Sub generarcatalogos()
        Const fic As String = "C:\dat\generararchivos.bat"
        Try
            If (IO.File.Exists(fic)) Then
                Process.Start(fic)
            End If
            My.Computer.FileSystem.MoveFile("C:\dat\almacenes.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\almacenes.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\clasificaciones.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\clasificaciones.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\clientes.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\clientes.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\inventario.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\inventario.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\movimientos.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\movimientos.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\pedidosd.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\pedidosd.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\pedidosm.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\pedidosm.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\productosd.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\productosd.dat", True)
            My.Computer.FileSystem.MoveFile("C:\dat\productosm.dat", "Equipo\Honeywell Dolphin 99EX\IPSM\Honeywell\Surtido\productosm.dat", True)
            MessageBox.Show("Generacion exitosa")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generarcatalogos()
    End Sub
End Class