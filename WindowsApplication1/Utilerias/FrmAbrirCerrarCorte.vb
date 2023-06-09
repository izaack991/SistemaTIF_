Imports System.Data
Imports System.Data.SqlClient
Public Class FrmAbrirCerrarCorte
    Dim oCorte As clsCortes
    Dim oIntroductor As New clsCliente
    Dim oDestino As New clsCliente
    Private Sub Despliega_Datos_Del_Corte()

        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String = ""


        If oCorte.ID_CORTE <> 0 Then

            Me.txtIDCorte.Text = oCorte.ID_CORTE
            Me.chkestadocorte.Checked = oCorte.ESTADO_CORTE
            oIntroductor = New clsCliente(oCorte.ID_CTE_INTR)
            Me.txtMarcaIntroductor.Text = oIntroductor.Marca
            Me.DespliegaCliente(2)

            oDestino = New clsCliente(oCorte.ID_CTE_DEST)
            Me.txtMarcaDestino.Text = oDestino.Marca
            Me.DespliegaCliente(3)


            Me.txtLote.Text = oCorte.COR_LOTE

        End If
    End Sub
    Private Sub txtIDCorte_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDCorte.KeyDown
        If e.KeyCode = Keys.Enter Then
            oCorte = New clsCortes(Me.txtIDCorte.Text.Trim)
            'Me.Limpiar()
            Me.Despliega_Datos_Del_Corte()
            Me.txtIDCorte.SelectAll()

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim lCmd As New SqlCommand
        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "UPDATE CORTES SET ESTADO_CORTE ='" & Me.chkestadocorte.Checked & "'" & "where ID_CORTE=" & Val(Me.txtIDCorte.Text)
            lCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        Limpiar()
    End Sub
    Private Sub Limpiar()
        Me.txtIDCorte.Clear()
        Me.txtLote.Clear()
        Me.txtMarcaIntroductor.Clear()
        Me.txtNomIntroductor.Clear()
        Me.txtMarcaDestino.Clear()
        Me.txtNomDestino.Clear()
        Me.chkestadocorte.Checked = False
    End Sub
    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            'Case 1
            '    modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor)
            '    If oProductor.ID_CLIENTE <> 0 Then Me.txtMarcaIntroductor.Focus()
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
                'If oIntroductor.ID_CLIENTE <> 0 Then Me.txtMarcaDestino.Focus()
                'If oIntroductor.ID_CLIENTE <> 0 Then
                '    Me.DespliegaDatos1()
                'End If
            Case 3
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaDestino, Me.txtNomDestino, oDestino)
                If oDestino.ID_CLIENTE <> 0 Then
                    'If Me.txtPeso.Enabled = True And Me.txtPeso.ReadOnly = False Then
                    'Me.txtCodProd.Focus()
                    'End If
                End If
        End Select
    End Sub
End Class