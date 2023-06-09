Public Class frmOrdenProduccionPie
    Dim sStatus As String
    Private Sub frmOrdenProduccionPie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Centrar(Me)

        ' Pasar control  
        Centrar(Panel1)
        cmbsolicitudes.SelectedIndex = 0
        Select Case cmbsolicitudes.Text
            Case "Abierto"
                sStatus = "A"
            Case "Cerrado"
                sStatus = "C"
        End Select
        SACRIFICIOTableAdapter.Connection.ConnectionString = ConnectionString
        SACRIFICIOTableAdapter.Fill(DS_PROG_SACRI.SACRIFICIO, sStatus, Me.dtpFechaMov.Value.Date)
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

    Private Sub BTNCAPTURAR_Click(sender As Object, e As EventArgs) Handles BTNCAPTURAR.Click
        Dim sac As New frmPROC_Sacrificio
        sac.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim os As New frmOrdenProduccionPie
        os.Show()
        Me.Close()
    End Sub
End Class