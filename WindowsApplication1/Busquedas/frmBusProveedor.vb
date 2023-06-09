Imports System.Windows.Forms

Public Class frmBusProveedor
    Dim id_tcte As Integer
 
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmBusProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ds_Proveedores.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Connection.ConnectionString = ConnectionString
        Me.CLIENTESTableAdapter.Fill(Me.Ds_Proveedores.CLIENTES, Me.TXTFILTRO.Text)

    End Sub

    Private Sub TXTFILTRO_TextChanged(sender As Object, e As EventArgs) Handles TXTFILTRO.TextChanged
        Me.CLIENTESTableAdapter.Fill(Me.Ds_Proveedores.CLIENTES, Me.TXTFILTRO.Text)
    End Sub
End Class
