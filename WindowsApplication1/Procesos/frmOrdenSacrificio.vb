Public Class frmOrdenSacrificio
    Dim sStatus As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCAPTURAR.Click
        Dim PS As New FRM_PROGRAMA_SACRIFICIO(False)
        PS.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

 

    Private Sub frmOrdenSacrificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cmbsolicitudes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsolicitudes.SelectedIndexChanged
        ' cmbsolicitudes.SelectedIndex = 0
        Select cmbsolicitudes.Text
            Case "Abierto"
                sStatus = "A"
            Case "Cerrado"
                sStatus = "C"
        End Select

        SACRIFICIOTableAdapter.Connection.ConnectionString = ConnectionString
        SACRIFICIOTableAdapter.Fill(DS_PROG_SACRI.SACRIFICIO, sStatus, Me.dtpFechaMov.Value.Date)

    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        If DataGridView1.RowCount = 0 Then
            Dim war As New frmWarning
            war.Label1.Text = "No Hay datos a modificar"
            war.Label1.Font = New Font(war.Label1.Font.Name, 20)
            war.OK_Button.Text = "OK"
            war.TableLayoutPanel1.Location = New Point(147, 308)
            war.Cancel_Button.Visible = False
            war.ShowDialog()
            Exit Sub
        Else
            Dim PS As New FRM_PROGRAMA_SACRIFICIO(True)
            PS.txtidsac.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).ID_SAC
            PS.TxtLote.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).SAC_LOTE
            PS.TXTCANTIDAD.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).CANTIDAD
            PS.TXTHEMBRAS.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).HEMBRAS
            PS.TXTMACHOS.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).MACHOS
            PS.cmbEspecie.SelectedValue = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).ID_ESPECIE
            PS.txtMarcaIntroductor.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).MARCA_CTE
            PS.txtMarcaDestino.Text = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).MARCA_DEST
            PS.CHKMIXTO.Checked = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).BMIXTO
            PS.CHKHEMBRAS.Checked = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).BHEMBRAS
            PS.CHKMACHOS.Checked = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).BMACHOS
            PS.dtpFechaMov.Value = Me.DS_PROG_SACRI.SACRIFICIO(SACRIFICIOBindingSource.Position).FECHA
            PS.DespliegaCliente(2)
            PS.DespliegaCliente(3)
            PS.ShowDialog()
            Me.Hide()
        End If
      
    End Sub
End Class