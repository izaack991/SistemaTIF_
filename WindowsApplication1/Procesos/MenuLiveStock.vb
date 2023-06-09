Public Class MenuLiveStock

    Private Sub BTNHAMBURGUER_Click(sender As Object, e As EventArgs) Handles BTNHAMBURGUER.Click
        PanelMenu.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelMenu.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim os As New frmOrdenSacrificio
        os.Show()
    End Sub

    Private Sub MenuLiveStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modConexion.Conectar()
        Centrar(Me)

        ' Pasar control  
        Centrar(FlowLayoutPanel2)
        Me.LBLHORA.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

        TMHORA.Interval = 1000  ' Un segundo
        TMHORA.Start()
        lblfecha.Text = Date.Now.ToLongDateString
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

    Private Sub TMHORA_Tick(sender As Object, e As EventArgs) Handles TMHORA.Tick
        Me.LBLHORA.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim op As New frmOrdenProduccionPie
        op.Show()
        Me.Hide()
    End Sub
End Class