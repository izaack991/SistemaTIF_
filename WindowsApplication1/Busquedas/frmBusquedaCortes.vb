Public Class frmBusquedaCortes

    Private Sub frmBusquedaCortes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsBusCortes.CORTES' Puede moverla o quitarla según sea necesario.
        CORTESTableAdapter.Connection.ConnectionString = ConnectionString
        Me.CORTESTableAdapter.Fill(Me.DsBusCortes.CORTES, Me.TextBox1.Text, (Me.dtpfecha.Value).Month, (dtpfecha.Value).Year)

    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CORTESTableAdapter.Connection.ConnectionString = ConnectionString
        Me.CORTESTableAdapter.Fill(Me.DsBusCortes.CORTES, Me.TextBox1.Text, (Me.dtpfecha.Value).Month, (dtpfecha.Value).Year)

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class