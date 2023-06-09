Imports CrystalDecisions.CrystalReports.Engine

Public Class frmCAT_Subfamilias

    Dim daCatalogo As SqlClient.SqlDataAdapter
    Dim iPrimeraVez As Boolean = True
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

    Private Sub frmCAT_Subfamilias_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        iPrimeraVez = False
        'Me.dgvCatalogo.ClearSelection()
    End Sub

    Private Sub frmCAT_Subfamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MostrarFamilias()
    End Sub

    Private Sub Guardar(aOperacion As String)
        Dim lRes As Integer = 0
        Dim lMensaje As String = ""

        Dim lID As Integer = 0
        Dim lID_SFAM As Integer = 0
        Dim lsDescripcion As String = ""

        Try
            lID = Me.dgvCatalogo.SelectedRows(0).Cells("ID").Value

            Select Case aOperacion
                Case "A"
                    lMensaje = "¿Esta seguro de dar de alta la nueva subfamilia?"
                Case "M"
                    lMensaje = "¿Esta seguro de modificar el nombre de la subfamilia?"
                    lID_SFAM = Me.dgvCatalogo2.SelectedRows(0).Cells("ID_SFAM").Value
                Case "C"
                    lMensaje = "¿Esta seguro de cancelar la subfamilia?"
                    lID_SFAM = Me.dgvCatalogo2.SelectedRows(0).Cells("ID_SFAM").Value
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
            Dim pID_FAM As New SqlClient.SqlParameter
            Dim pID_SFAM As New SqlClient.SqlParameter
            Dim pDescripcion As New SqlClient.SqlParameter
            Dim pReturn As New SqlClient.SqlParameter
            Dim pErrorSP As New SqlClient.SqlParameter

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_SUBFAMILIAS"
            lCmd.CommandType = CommandType.StoredProcedure

            '
            'DECLARACION DE PARAMETROS EN EL STORED PROCEDURE
            '
            '   PROCEDURE SP_ABC_SUBFAMILIAS
            '@OPERACION     CHAR(1),
            '@ID_FAM        INTEGER,
            '@ID_SFAM       INTEGER,
            '@NOMBRE 	    VARCHAR(20),
            '@ERRORSP       VARCHAR(300) OUTPUT 

            pReturn = lCmd.Parameters.Add("Return", SqlDbType.Int)
            pReturn.Direction = ParameterDirection.ReturnValue
            pOperacion = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            pID_FAM = lCmd.Parameters.Add("ID_FAM", SqlDbType.Int)
            pID_SFAM = lCmd.Parameters.Add("ID_SFAM", SqlDbType.Int)
            pDescripcion = lCmd.Parameters.Add("NOMBRE", SqlDbType.VarChar, 30)
            pErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            pErrorSP.Direction = ParameterDirection.Output

            pOperacion.Value = aOperacion
            pID_FAM.Value = lID
            pID_SFAM.Value = lID_SFAM
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

    Private Sub MostrarFamilias()
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

    Private Sub MostrarDatos()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim lSql As String
            Dim lIdFamilia As Integer

            DsCatalogos.Tables("SP_CONS_SUBFAMILIAS").Clear()
            Me.txtNombre.Text = ""

            If Me.dgvCatalogo.RowCount > 0 Then

                If Not IsNothing(Me.dgvCatalogo.CurrentRow) Then

                    lIdFamilia = CInt(Me.dgvCatalogo.SelectedRows(0).Cells("ID").Value)

                    lSql = "EXECUTE SP_CONS_SUBFAMILIAS " & lIdFamilia & ", 0, '%'"

                    daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
                    daCatalogo.Fill(DsCatalogos, "SP_CONS_SUBFAMILIAS")

                End If

            End If
            Me.FormatoGrid()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgvCatalogo_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCatalogo.RowEnter
        If Me.dgvCatalogo.RowCount > 0 Then
            'If Not iPrimeraVez Then
            Me.MostrarDatos()
            'End If
        End If
    End Sub

    Private Sub Imprimir()
        Dim miReporte As ReportDocument = Nothing
        Dim lSql As String
        Try
            Me.Cursor = Cursors.WaitCursor

            miReporte = CType(New crptCAT_Subfamilias, ReportDocument)

            DsCatalogos.Tables("SP_CAT_SUBFAMILIAS").Clear()
            lSql = "EXECUTE SP_CAT_SUBFAMILIAS"
            daCatalogo = New SqlClient.SqlDataAdapter(lSql, Cnn)
            daCatalogo.Fill(DsCatalogos, "SP_CAT_SUBFAMILIAS")

            If DsCatalogos.Tables("SP_CAT_SUBFAMILIAS").Rows.Count > 0 Then
                miReporte.SetDataSource(DsCatalogos.Tables("SP_CAT_SUBFAMILIAS"))
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

    Private Sub FormatoGrid()
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvCatalogo)
        modFuncProc.FormatoGrid_MarcarCancelados(Me.dgvCatalogo2, "ESTATUS_SFAM")
    End Sub

    Private Sub dgvCatalogo2_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo2.RowEnter
        If Me.dgvCatalogo2.RowCount > 0 Then
            Me.txtNombre.Text = Me.dgvCatalogo2.Rows(e.RowIndex).Cells("NOMBRE_SFAM").Value.ToString.Trim
        End If
    End Sub
End Class