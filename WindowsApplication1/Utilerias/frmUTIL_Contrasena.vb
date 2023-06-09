Public Class frmUTIL_Contrasena

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Owner.Tag = Me.txtPassword.Text.Trim
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Owner.Tag = Me.txtPassword.Text.Trim
        Me.Close()
    End Sub
End Class