Imports System.Windows.Forms

Public Class frmBusInsumos

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmBusInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_BUSINSUMOS.INSUMOS' Puede moverla o quitarla según sea necesario.
        Me.INSUMOSTableAdapter.Connection.ConnectionString = ConnectionString
        Me.INSUMOSTableAdapter.Fill(Me.DS_BUSINSUMOS.INSUMOS, Me.TXTFILTRO.Text)

    End Sub

    Private Sub TXTFILTRO_TextChanged(sender As Object, e As EventArgs) Handles TXTFILTRO.TextChanged
        Me.INSUMOSTableAdapter.Fill(Me.DS_BUSINSUMOS.INSUMOS, Me.TXTFILTRO.Text)
    End Sub
End Class
