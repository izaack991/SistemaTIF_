Imports System.Data.SqlClient
Public Class frmLogin
    Dim iIdUsuarios As Integer
    Dim iRol As Integer
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnaceptar.Focus()
        End If
    End Sub
    Private Sub UsernameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim L As SqlClient.SqlDataReader
            Dim con As New SqlConnection(modVariablesGlobales.ConnectionString)
            Try
                Dim CM As New SqlClient.SqlCommand("select * from USUARIOS where nombre ='" & Me.UsernameTextBox.Text & "'", con)
                con.Open()
                L = CM.ExecuteReader
                If L.Read Then
                    Me.iIdUsuarios = L("usuario")
                    Me.iRol = L("id_tusu")
                    Me.PasswordTextBox.Enabled = True
                    Me.PasswordTextBox.Focus()
                Else
                    MessageBox.Show("El usuario no existe")
                End If
            Catch ex As Exception
                MessageBox.Show(Err.Description)
            Finally
                con.Close()
                L.Close()
            End Try
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim param As New SqlParameter
        Dim m As New mdiPrincipal(Me.UsernameTextBox.Text, iRol, iIdUsuarios)
        Dim res As Int32 = 0
        'cmd.Connection = conexion
        Dim con As New SqlConnection(modVariablesGlobales.ConnectionString)
        Dim comando As New SqlCommand("", con)
        comando.CommandText = "Sp_LoginUsuario"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@Nombre", UsernameTextBox.Text)
        comando.Parameters.AddWithValue("@pass", PasswordTextBox.Text)
        comando.Parameters.AddWithValue("@result", SqlDbType.Bit)
        comando.Parameters("@result").Direction = ParameterDirection.Output
        Try

            con.Open()
            comando.ExecuteNonQuery()
            res = CInt(comando.Parameters("@result").Value)
            If res = 1 Then
                ' m.Show()
                ' Me.Hide()
                Dim mn As New FRM_MENU_PRINCIPAL(Me.UsernameTextBox.Text, iRol, iIdUsuarios)
                mn.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally

            comando.Dispose()
            'modConexion.Conectar()
            con.Close()
        End Try
       
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Centrar(Me)

        ' Pasar control  
        Centrar(Panel1)
        'modConexion.Conectar()
    End Sub
    Private Sub Centrar(ByVal Objeto As Object)

        ' Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.PrimaryScreen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                frm.Top = (.Height - frm.Height) \ 2
                frm.Left = (.Width - frm.Width) \ 2

            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                .Top = (.Parent.ClientSize.Height - c.Height) \ 2
                .Left = (.Parent.ClientSize.Width - c.Width) \ 2
            End With
        End If
    End Sub
End Class