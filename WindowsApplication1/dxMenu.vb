Public Class dxMenu
    Dim AnchoPantalla As Integer = My.Computer.Screen.Bounds.Width
    Dim AltoPantalla As Integer = My.Computer.Screen.WorkingArea.Height
    Public Sub New(ByVal sNombre As String, ByVal iRol As Integer, ByVal iIdUsuario As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        Dim op As New frmCAT_Clientes
        op.Show()
        Me.Hide()
    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click
        Dim op As New frmCAT_Clientes
        op.IsMdiContainer = True
        op.Show()
    End Sub

    Private Sub dxMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        modConexion.Conectar()

        Dim lFechaVencimiento As String = "15/12/2015"
        Dim lFechaProrroga As String = "18/12/2015"
        Dim lDiasRestantes As Integer = 0

        Dim myVersion As System.Version = Nothing

        Dim lServidor As New clsServidor()

        With Me

            .Location = New Point(x:=0, y:=0)
            .Height = AltoPantalla
            .Width = AnchoPantalla
            Me.WindowState = FormWindowState.Maximized
        End With
        'If CDate(lServidor.FECHA) > CDate(lFechaProrroga) Then
        '    MessageBox.Show("La licencia de prueba ha expirado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End
        'End If

        'If CDate(lServidor.FECHA) > CDate(lFechaVencimiento) Then
        '    lDiasRestantes = DateDiff(DateInterval.Day, CDate(lServidor.FECHA), CDate(lFechaProrroga)) + 1
        '    MessageBox.Show("La licencia de prueba ha expirado." & vbNewLine & vbNewLine & "Restan " & lDiasRestantes.ToString & " dias de uso.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        'If lServidor.Equipo_Local = "SYSMASTER" Then
        '    EmbarqueToolStripMenuItem.Visible = True
        'Else
        '    EmbarqueToolStripMenuItem.Visible = False
        'End If

        'If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
        '    With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
        '        Me.Text = "V" & .Major & "." & .Minor & "." & .Build
        '    End With
        'End If

        'If Not IsNothing(ApplicationDeployment.IsNetworkDeployed) Then
        '    If ApplicationDeployment.IsNetworkDeployed Then
        'myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
        '    End If
        'End If

        'Me.lblVersion.Text = "v" & myVersion.ToString


    End Sub

    Private Sub FluentDesignFormControl1_Click(sender As Object, e As EventArgs) Handles FluentDesignFormControl1.Click

    End Sub
End Class
