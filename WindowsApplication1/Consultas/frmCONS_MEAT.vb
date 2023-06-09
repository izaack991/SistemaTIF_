Imports System.Data
Imports System.Data.SqlClient
Public Class frmCONS_MEAT

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DespliegaDatos()
    End Sub
    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            'Dim lCodAlmacen As String
           
            Me.DsSacrificio.SP_CONS_SAC_MEAT.Clear()

            lSql = "SP_CONS_SAC_MEAT '" & Format(Me.dtpfecha.Value, "dd/MM/yyyy") & "', " & Me.TXTLOTE.Text

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_SAC_MEAT.Clear()
            da.Fill(Me.DsSacrificio.SP_CONS_SAC_MEAT)
            GridControl1.DataSource = da

            da.Dispose()
            lCmd.Dispose()
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub DespliegaDatos1()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            'Dim lCodAlmacen As String

            Me.DsSacrificio.SP_CONS_SAC_MEAT_DESHUESE.Clear()

            lSql = "SP_CONS_SAC_MEAT_DESHUESE 8,26," & Me.TXTSALIDA.Text

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            DsSacrificio.SP_CONS_SAC_MEAT_DESHUESE.Clear()
            da.Fill(Me.DsSacrificio.SP_CONS_SAC_MEAT_DESHUESE)
            GridControl2.DataSource = da

            da.Dispose()
            lCmd.Dispose()
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub TXTLOTE_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTLOTE.KeyUp
        If e.KeyCode = Keys.F2 Then
            Dim bPS As New fRM_BUSQUEDA_PS(Me.dtpfecha.Value)
            bPS.ShowDialog()
            If bPS.DataGridView1.Rows.Count > 0 Then
                If bPS.DialogResult = Windows.Forms.DialogResult.OK Then
                    Me.TXTLOTE.Text = bPS.DS_PROG_SACRI.SACRIFICIO(bPS.SACRIFICIOBindingSource.Position).SAC_LOTE
                End If
            End If
            Me.TXTLOTE.Focus()
        End If
       
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            GridControl1.ExportToXls(SaveFileDialog1.FileName)

        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            GridControl1.ExportToXls(SaveFileDialog2.FileName)

        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.DespliegaDatos1()
    End Sub
End Class