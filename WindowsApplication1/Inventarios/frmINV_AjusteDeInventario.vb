
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmINV_AjusteDeInventario
    Dim oIntroductor As New clsCliente
    Dim lHayCajasParaSalida As Boolean = False
    Dim lHayCajasParaEntrada As Boolean = False
    Dim iUsuario As Integer

    Private Sub frmINV_AjusteDeInventario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F3
                Me.Buscar()
        End Select
    End Sub

    Private Sub Buscar()
        Dim lsTitulo As String = ""
        Dim lsCampoBusqueda As String = ""
        Dim liColumnaCodigo As Short

        Dim iBuscaSucursal As Boolean = False
        Dim iBuscaArea As Boolean = False
        Dim iBuscaProveedor As Boolean = False

        Dim lValor1 As String = ""
        Dim lValor2 As String = ""

        Select Case Me.ActiveControl.Name.TrimEnd.ToUpper
            Case "TXTMARCAINTRODUCTOR"
                lsTitulo = "CTE_CONSANALISISINV_INTRODUCTOR"
                lsCampoBusqueda = "NOMBRE"
                liColumnaCodigo = 2
        End Select

        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()

    End Sub

    Public Sub RegresaBuscarCteIntroductor(ByVal aCodigo As String)
        Me.txtMarcaIntroductor.Text = aCodigo
        Call Me.DespliegaCliente(2)
    End Sub

    Private Sub Nuevo()
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas limpiar la pantalla?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Limpiar()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub Limpiar()

        oIntroductor = New clsCliente
        Me.txtMarcaIntroductor.Text = ""
        Me.txtNomIntroductor.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtFolio.Text = ""

        Me.dtpFechaMov.Value = Today

        DsInventarios.SP_CONS_ANALISIS_INVENTARIO.Clear()

    End Sub

    Private Sub txtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaDatos()
        End If
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            DespliegaCliente(2)
            DespliegaDatos()
        End If
    End Sub

    Private Sub DespliegaCliente(aOpcion As Integer)
        Select Case aOpcion
            Case 2
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
        End Select
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        Me.Nuevo()
    End Sub

    Public Sub DespliegaDatos(Optional ByVal aCodAlm As String = "", Optional ByVal aFolio As String = "")
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()
            Dim lCodAlm As String
            Dim lFolio As String

            If aCodAlm = "" Then
                If oIntroductor.ID_CLIENTE = 0 Then
                    MessageBox.Show("Debe capturar un introductor.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtMarcaIntroductor.Focus()
                    Exit Sub
                End If
                lCodAlm = oIntroductor.ID_ALM_CAJ
            Else
                lCodAlm = aCodAlm
            End If

            If aFolio = "" Then
                If Me.txtFolio.Text.Trim = "" Then
                    MessageBox.Show("Debe proporcionar un folio.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtFolio.Focus()
                    Exit Sub
                End If
                lFolio = Me.txtFolio.Text.Trim
            Else
                lFolio = aFolio
            End If

            'PROCEDURE SP_CONS_ANALISIS_INVENTARIO
            '@ID_ALM	VARCHAR(6),
            '@FOLIO	INTEGER

            lSql = "SP_CONS_ANALISIS_INVENTARIO'" & lCodAlm & "'," & lFolio

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)

            Me.txtObservaciones.Text = ""
            DsInventarios.SP_CONS_ANALISIS_INVENTARIO.Clear()
            da.Fill(DsInventarios.SP_CONS_ANALISIS_INVENTARIO)

            If Me.DsInventarios.SP_CONS_ANALISIS_INVENTARIO.Rows.Count > 0 Then
                Me.dtpFechaMov.Value = Me.DsInventarios.SP_CONS_ANALISIS_INVENTARIO.Rows(1).Item("F_FECHA")
                Me.FormatoGrid()
                If Me.DsInventarios.SP_CONS_ANALISIS_INVENTARIO.Rows(1).Item("F_ESTATUS") = "A" Then
                    Me.btnGuardar.Enabled = True
                Else
                    Me.btnGuardar.Enabled = False
                End If
            Else
                Me.btnGuardar.Enabled = False
            End If

            da.Dispose()
            lCmd.Dispose()


        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub FormatoGrid()
        Dim i As Integer

        lHayCajasParaSalida = False
        lHayCajasParaEntrada = False

        For i = 0 To Me.dgvDatos.RowCount - 1
            If Me.dgvDatos.Rows(i).Cells("T_ID_ESC").Value = "0" Then
                Me.dgvDatos.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                lHayCajasParaEntrada = True
            End If
            If Me.dgvDatos.Rows(i).Cells("F_ID_ESC").Value = "0" Then
                Me.dgvDatos.Rows(i).DefaultCellStyle.BackColor = Color.LightCoral
                lHayCajasParaSalida = True
            End If
        Next

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim frmPassword As New frmUTIL_Contrasena
        Dim oParametros As New clsParametros(17)

        frmPassword.ShowDialog(frmUTIL_Contrasena)
        If frmPassword.txtPassword.Text.Trim = oParametros.CAD1 Then
            frmPassword.Dispose()
            Me.Guardar()
        Else
            frmPassword.Dispose()
            MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guardar()
        Try
            Dim lResp As Integer

            Dim lCmd As New SqlClient.SqlCommand
            Dim lp0 As New SqlClient.SqlParameter
            Dim lp1 As New SqlClient.SqlParameter
            Dim lp2 As New SqlClient.SqlParameter
            Dim lp3 As New SqlClient.SqlParameter
            Dim lp4 As New SqlClient.SqlParameter
            Dim lp5 As New SqlClient.SqlParameter
            Dim lp6 As New SqlClient.SqlParameter
            Dim lp7 As New SqlClient.SqlParameter
            Dim lp8 As New SqlClient.SqlParameter
            Dim lp9 As New SqlClient.SqlParameter
            Dim lp10 As New SqlClient.SqlParameter
            Dim lp11 As New SqlClient.SqlParameter
            Dim lp12 As New SqlClient.SqlParameter
            Dim lp13 As New SqlClient.SqlParameter
            Dim lpErrorSP As New SqlClient.SqlParameter

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No ha seleccionado ninguna caja para la entrada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (Not lHayCajasParaEntrada) And (Not lHayCajasParaSalida) Then
                MessageBox.Show("No hay ajustes por hacer.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lResp = MessageBox.Show("¿Deseas generar el ajuste de inventario?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            lResp = MessageBox.Show("¿Realmente deseas generar el ajuste de inventario?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.No Then
                Exit Sub
            End If

            'PROCEDURE SP_ABC_AJUSTE_INVENTARIO
            '	@ID_ALM				INTEGER,
            '	@FOLIO_INV_FISICO	INTEGER,
            '	@FECHA				VARCHAR(10) = '',
            '	@ID_ESPECIE			INTEGER = 1,
            '	@OBSERVACIONES		VARCHAR(200) = '',
            '	@USUARIO			INTEGER,
            '	@ERRORSP    	    VARCHAR(300)OUTPUT

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_AJUSTE_INVENTARIO"
            lCmd.CommandType = CommandType.StoredProcedure

            lp1 = lCmd.Parameters.Add("ID_ALM", SqlDbType.Int)
            lp2 = lCmd.Parameters.Add("FOLIO_INV_FISICO", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("FECHA", SqlDbType.VarChar, 10)
            lp4 = lCmd.Parameters.Add("ID_ESPECIE", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.VarChar, 200)
            lp6 = lCmd.Parameters.Add("USUARIO", SqlDbType.Int)

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output


            lp1.Value = oIntroductor.ID_ALM_CAJ
            lp2.Value = Me.DsInventarios.SP_CONS_ANALISIS_INVENTARIO.Rows(1).Item("F_FOLIO_INV")
            lp3.Value = Format(Me.dtpFechaMov.Value, "dd/MM/yyyy")
            lp4.Value = 1
            lp5.Value = Me.txtObservaciones.Text.Trim
            lp6.Value = iUsuario

            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                MessageBox.Show(lpErrorSP.Value, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("La información se guardó correctamente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            lCmd = Nothing

            'MANDAR A IMPRIMIR
            Me.Limpiar()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Public Sub cargarusuario(ByVal iUsuario As Integer)
        Me.iUsuario = iUsuario
    End Sub
    Private Sub frmINV_AjusteDeInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
