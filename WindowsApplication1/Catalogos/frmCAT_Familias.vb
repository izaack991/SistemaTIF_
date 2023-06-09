Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCAT_Familias

    Dim daCatalogo As SqlClient.SqlDataAdapter

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Guardar("A")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Guardar("M")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Guardar("C")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir()
    End Sub


    Private Sub Guardar(aOperacion As String)
        Dim lRes As Integer = 0
        Dim lMensaje As String = ""

        Dim lID As Integer = 0
        Dim lsDescripcion As String = ""

        Try
            Select Case aOperacion
                Case "A"
                    lMensaje = "¿Esta seguro de dar de alta la nueva familia?"
                Case "M"
                    lMensaje = "¿Esta seguro de modificar el nombre de la familia?"
                    lID = Me.dgvCatalogo.SelectedRows(0).Cells("ID").Value
                Case "C"
                    lMensaje = "¿Esta seguro de cancelar la familia?"
                    lID = Me.dgvCatalogo.SelectedRows(0).Cells("ID").Value
            End Select

            lRes = MessageBox.Show(lMensaje, gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Me.txtNombre.Text.Trim = "" Then
                MessageBox.Show("Debe capturar el nombre.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombre.Focus()
                Exit Sub
            End If

            If lRes = MsgBoxResult.No Then Exit Sub

            Me.Cursor = Cursors.WaitCursor


            lsDescripcion = Me.txtNombre.Text.Trim

            Dim lCmd As New SqlClient.SqlCommand
            Dim pOperacion As New SqlClient.SqlParameter
            Dim pID As New SqlClient.SqlParameter
            Dim pDescripcion As New SqlClient.SqlParameter
            Dim pReturn As New SqlClient.SqlParameter
            Dim pErrorSP As New SqlClient.SqlParameter

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_FAMILIAS"
            lCmd.CommandType = CommandType.StoredProcedure

            '
            'DECLARACION DE PARAMETROS EN EL STORED PROCEDURE
            '
            '   PROCEDURE SP_ABC_FAMILIAS
            '	@OPERACION  	CHAR(1),
            '	@CODIGO     	INTEGER = NULL,
            '	@DESCRIPCION 	VARCHAR(30),
            '	@ERRORSP    	VARCHAR(8000) OUTPUT  --INDICADOR DE ERROR (VACIO = OK)

            pReturn = lCmd.Parameters.Add("Return", SqlDbType.Int)
            pReturn.Direction = ParameterDirection.ReturnValue
            pOperacion = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            pID = lCmd.Parameters.Add("ID", SqlDbType.Int)
            pDescripcion = lCmd.Parameters.Add("NOMBRE", SqlDbType.VarChar, 30)
            pErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            pErrorSP.Direction = ParameterDirection.Output

            pOperacion.Value = aOperacion
            pID.Value = lID
            pDescripcion.Value = lsDescripcion.Trim

            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If pReturn.Value = 1 Then 'Se produjo un error controlado desde el stored procedure
                MsgBox(Trim(pErrorSP.Value), MsgBoxStyle.Exclamation, gProyecto)
                Exit Sub
            End If


            'Call Limpiar()

            Call MostrarDatos()


            Call modFuncProc.msgInformacionGuardada(Me)

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MostrarDatos()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim lSql As String

            lSql = "EXECUTE SP_CONS_FAMILIAS 0, '%'"

            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_FAMILIAS").Clear()
            daCatalogo.Fill(DsCatalogos, "SP_CONS_FAMILIAS")

            Me.FormatoGrid()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgvCatalogo_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCatalogo.RowEnter
        If Me.dgvCatalogo.RowCount > 0 Then
            Me.txtNombre.Text = Me.dgvCatalogo.Rows(e.RowIndex).Cells("NOMBRE").Value.ToString.Trim
        End If
    End Sub

    Private Sub frmCAT_Familias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MostrarDatos()
    End Sub

    Private Sub FormatoGrid()
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvCatalogo)
    End Sub

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCAT_Familias, ReportDocument)
            If DsCatalogos.Tables("SP_CONS_FAMILIAS").Rows.Count > 0 Then
                miReporte.SetDataSource(DsCatalogos.Tables("SP_CONS_FAMILIAS"))
                Dim frmReporte As New frmCRViewer
                frmReporte.MdiParent = Me.ParentForm
                frmReporte.crViewer.ReportSource = miReporte
                Me.Cursor = Cursors.Default
                frmReporte.Show()
            Else
                Me.Cursor = Cursors.Default
                MessageBox.Show("No se encontro información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


End Class