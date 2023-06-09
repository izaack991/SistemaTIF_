Public Class FRM_BUS_SOSPECHOSOS

    Private Sub FRM_BUS_SOSPECHOSOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ENTSAL_DETTableAdapter.Connection.ConnectionString = ConnectionString
        'TODO: esta línea de código carga datos en la tabla 'DS_SOSPECHOSOS.ENTSAL_DET' Puede moverla o quitarla según sea necesario.
        Me.ENTSAL_DETTableAdapter.Fill(Me.DS_SOSPECHOSOS.ENTSAL_DET)

    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub
End Class