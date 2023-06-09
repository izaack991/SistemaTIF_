Imports System.Data.SqlClient

Public Class frmCONS_GanadoEnPie


    Private Sub frmCONS_GanadoEnPie_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    End Sub

    Private Sub CargaProductos()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            'Dim lDR As SqlDataReader = Nothing
            Dim dt As New DataTable()
            Dim lID_Movto As Integer = 1    'ENTRADA DE GANADO EN PIE

            lSql = "SP_CONS_PRODUCTOS '', '%', 3"

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
            Dim dt As New DataTable()
            Dim lID_Movto As Integer = 1    'ENTRADA DE GANADO EN PIE

            Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA.Clear()

            lSql = "SP_CONS_ENTSAL_ENCDET_X_FECHA " & lID_Movto & ", '" & Format(Me.dtpFechaMov.Value, "dd/MM/yyyy") & "', '" & Format(Me.dtpFechaMov.Value, "dd/MM/yyyy") & "', '" & Me.cmbProductos.SelectedValue & "' "

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql


            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA)

            If Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA.Rows.Count > 0 Then Me.FormatoGrid()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub FormatoGrid()
        Dim I As Integer
        Dim lTotal As Integer = 0

        For I = 0 To Me.dgvDatos.RowCount - 1
            Me.dgvDatos.Rows(I).Cells("REN").Value = I + 1
            lTotal = lTotal + IIf(Me.dgvDatos.Rows(I).Cells("ESTATUS_ESD").Value = "A", 1, 0)
        Next

        Me.txtTotalGanado.Text = lTotal
        Me.txtHoraInicio.Text = Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA.Compute("min(hora_esd)", "id_esc>0")
        Me.txtHoraFin.Text = Me.DsSacrificio.SP_CONS_ENTSAL_ENCDET_X_FECHA.Compute("max(hora_esd)", "id_esc>0")

        modFuncProc.FormatoGrid_MarcarDecomiso(Me.dgvDatos)
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvDatos, "ESTATUS_ESD")

    End Sub

    Private Sub dgvDatos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDatos.DoubleClick
        If Me.dgvDatos.Rows.Count = 0 Then Exit Sub

        Dim lID_ESC As Integer

        lID_ESC = Me.dgvDatos.SelectedRows(0).Cells("ID_ESC").Value
        modFuncProc.ConsultaMovimientoAlmacen(lID_ESC)
    End Sub

End Class