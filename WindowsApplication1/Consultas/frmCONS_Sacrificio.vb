Imports System.Data.SqlClient

Public Class frmCONS_Sacrificio

    Private Sub frmCONS_Sacrificio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F5
                Me.DespliegaDatos()
        End Select
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.DespliegaDatos()
    End Sub

    Private Sub frmCONS_GanadoEnPie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargaProductos()
        Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_CANAL.Clear()
    End Sub

    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "SP_CONS_PRODUCTOS '', '%', 1"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            Me.cmbProductos.DataSource = dt
            Me.cmbProductos.DisplayMember = "NOMBRE"
            Me.cmbProductos.ValueMember = "ID_PROD"

            lCmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DespliegaDatos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            'Dim lDR As SqlDataReader = Nothing
            Dim dt As New DataTable()
            Dim lID_Movto As Integer = 2    'ENTRADA CANALES POR SACRIFICIO

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_CANAL.Clear()

            lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA_CANAL " & lID_Movto & ", '" & Format(Me.dtpFechaMov.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaMov.Value, "dd/MM/yyyy") & "', '" & Me.cmbProductos.SelectedValue.ToString.Trim & "' "

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_CANAL)

            Me.FormatoGrid()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub FormatoGrid()
        Dim i As Short
        'Dim x As Short
        Dim lsHoraIni As String
        Dim lsHoraFin As String
        Dim lTotal As Integer = 0
        Dim oParametros As New clsParametros(1)
        
        If Me.dgvDatos.Rows.Count > 0 Then


            For i = 0 To Me.dgvDatos.Rows.Count - 1

                Me.dgvDatos.Rows(i).Cells("REN").Value = i + 1
                Me.dgvDatos.Rows(i).HeaderCell.Value = i + 1
                Me.dgvDatos.RowHeadersDefaultCellStyle.BackColor = Color.Red

                If Me.cmbProductos.SelectedValue = 3 Then 'BOVINO
                    If Me.dgvDatos.Rows(i).Cells("DIF_PESO").Value > oParametros.ENT1 Then
                        Me.dgvDatos.Rows(i).Cells("DIF_PESO").Style.ForeColor = Color.White
                        Me.dgvDatos.Rows(i).Cells("DIF_PESO").Style.BackColor = Color.Red
                    Else
                        Me.dgvDatos.Rows(i).Cells("DIF_PESO").Style.ForeColor = Color.Black
                        Me.dgvDatos.Rows(i).Cells("DIF_PESO").Style.BackColor = Me.dgvDatos.Rows(i).Cells(8).Style.BackColor
                    End If
                End If
                lTotal = lTotal + IIf(Me.dgvDatos.Rows(i).Cells("ESTATUS_ESD").Value = "A", 1, 0)
            Next i

            lsHoraIni = Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_CANAL.Compute("min(hora_det)", "id_esc>0")
            lsHoraFin = Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA_CANAL.Compute("max(hora_det)", "id_esc>0")

        Else
            lsHoraIni = ""
            lsHoraFin = ""
            lTotal = 0
        End If
        Me.txtHoraInicio.Text = lsHoraIni
        Me.txtHoraFin.Text = lsHoraFin
        Me.txtTotalGanado.Text = lTotal.ToString

        Me.dgvDatos.ClearSelection()

        Application.DoEvents()

        'modFuncProc.FormatoGrid_MarcarDecomiso(Me.dgvDatos)
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos, "ESTATUS_ESD")


    End Sub

    Private Sub dgvDatos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.ColumnHeaderMouseClick
        Me.FormatoGrid()
    End Sub


    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick
        If Me.dgvDatos.Rows.Count = 0 Then Exit Sub

        Dim lID_ESC As Integer

        lID_ESC = Me.dgvDatos.SelectedRows(0).Cells("ID_ESC").Value
        modFuncProc.ConsultaMovimientoAlmacen(lID_ESC)

    End Sub
End Class