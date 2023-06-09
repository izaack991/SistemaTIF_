Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRevisionCajas
    Dim sTexto As String
    Dim sTexto1 As String
    Private Sub frmRevisionCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarverificacion()
    End Sub
    Private Sub llenargrid()
        Me.VERFICAR_CAJASTableAdapter.Connection = Cnn
        Me.VERFICAR_CAJASTableAdapter.Fill(Me.DS_VERFICAR_cAJAS.VERFICAR_CAJAS, Convert.ToString(Me.IDREV.Text), Me.txtlote.Text)
    End Sub
    Private Function Valida_CodBar() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Valida_CodBar = False

            Dim lCodBar As String = ""
            Dim lCodBarAux As String = ""
            Dim lProductoEscaneado As String = ""
            Dim i As Integer
            Dim lID_ESD As Long

            Me.txtCodBar.BackColor = Color.White
            ' oCaja = New clsMovimientoEntSal

            lCodBarAux = Me.txtCodBar.Text.Trim

            Select Case lCodBarAux.Length
                Case 0
                    lCodBar = ""
                Case Is >= 6
                    lCodBar = Microsoft.VisualBasic.Right(lCodBarAux, 6)
                Case Else
                    lCodBar = ""
            End Select

            If lCodBar = "" Then
                MessageBox.Show("No se pudo identificar el código de barras.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtCodBar.SelectAll()
                Me.txtCodBar.Focus()
                Exit Function
            End If
            sTexto = Me.txtCodBar.Text
            sTexto1 = sTexto.Substring(25, 1)
            ' oCaja = New clsMovimientoEntSal(1, lCodBar)


            If Me.dgvDatos.RowCount > 0 Then
                Dim cajaid As String
                For Each row As DataGridViewRow In Me.dgvDatos.Rows
                    'obtenemos el valor de la columna en la variable declarada
                    cajaid = row.Cells(4).Value 'donde (0) es la columna a recorrer
                    If Strings.Right(Me.txtCodBar.Text, 6) = cajaid Then
                        MessageBox.Show("Esta caja ya fue agregada a la salida actual.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.txtCodBar.SelectAll()
                        Me.txtCodBar.Focus()
                        Exit Function
                    End If

                Next

            End If

            Me.txtCodBar.BackColor = Color.LightGreen

            ' lProductoEscaneado = "Producto: " & oCaja.ID_PROD.ToString.Trim & "/" & oCaja.NOMBRE_PRODUCTO & " - ID: " & oCaja.SAC_SERIE_ID & " - Peso:" & oCaja.PESO

            'Me.lblCodBar.Text = lProductoEscaneado

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub txtCodBar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Valida_CodBar() Then
                Me.AgergarCaja()
                Me.txtCodBar.Clear()
            End If
        End If
    End Sub
    Private Sub AgergarCaja()
        Dim lCmd As New SqlCommand
        Try
            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.StoredProcedure
            lCmd.CommandText = "SP_VERFICAR_CAJAS"
            lCmd.Parameters.Clear()
            lCmd.Parameters.AddWithValue("@OP", 1)
            lCmd.Parameters.AddWithValue("@ID_VER", Me.IDREV.Text)
            lCmd.Parameters.AddWithValue("@COR_LOTE", Me.txtlote.Text)
            lCmd.Parameters.AddWithValue("@FECHA", dtpFechaMov.Value)
            lCmd.Parameters.AddWithValue("@CAJA_sERIE", sTexto1)
            lCmd.Parameters.AddWithValue("@CAJA_ID", Strings.Right(Me.txtCodBar.Text, 6))
            lCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        llenargrid()
        lCmd.Dispose()
        Me.txtCodBar.Focus()
    End Sub
    Private Sub cargarverificacion()
        Dim lCmd As New SqlCommand
        Dim l As SqlDataReader
        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "select isnull(max(ID_VER),0) + 1 AS CONSECUTIVO from VERFICAR_CAJAS"
            l = lCmd.ExecuteReader
            If l.Read Then
                Me.IDREV.Text = l("CONSECUTIVO")
                Me.txtCodBar.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            l.Close()
        End Try

    End Sub
    Private Sub BUSCARVERIFICACION()
        Dim lCmd As New SqlCommand
        Dim l As SqlDataReader
        Try
            lCmd.Connection = Cnn
            lCmd.CommandText = "select * from VERFICAR_CAJAS where id_ver =" & Me.IDREV.Text
            l = lCmd.ExecuteReader
            If l.Read Then
                Me.txtlote.Text = l("COR_LOTE")
                dtpFechaMov.Value = l("FECHA")

            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        Finally
            l.Close()
        End Try

    End Sub

    Private Sub IDREV_KeyDown(sender As Object, e As KeyEventArgs) Handles IDREV.KeyDown
        If e.KeyCode = Keys.Enter Then
            BUSCARVERIFICACION()
            llenargrid()
            Me.txtCodBar.Focus()
        End If
        If e.KeyCode = Keys.F3 Then
            Me.Buscar()
            Me.txtCodBar.Focus()
        End If
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
            Case "IDREV"
                lsTitulo = "VERIF_MAESTRO"
                lsCampoBusqueda = "ID_VER"
                liColumnaCodigo = 1
        End Select

        Call frmBusqueda.CachaParametros(lsTitulo, liColumnaCodigo, lsCampoBusqueda, lValor1, lValor2)

        frmBusqueda.ShowDialog()

        Me.BringToFront()

        frmBusqueda.Close()
    End Sub
    Public Sub RegresaBuscarVerificacion(ByVal aCodigo As String)
        Me.IDREV.Text = aCodigo
        Call BUSCARVERIFICACION()
        Call llenargrid()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.ImprimirVerificacion()
    End Sub
    Private Sub ImprimirVerificacion()
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvDatos.RowCount = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim lFecha As String
            Dim lLote As String



            DsCajas1.SP_CONS_VERIFICACION.Clear()

            lSql = "SP_CONS_VERIFICACION " & Me.txtlote.Text

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(Me.DsCajas1.SP_CONS_VERIFICACION)

            lCmd.Dispose()

            If Me.DsCajas1.SP_CONS_VERIFICACION.Rows.Count = 0 Then
                MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptConsVerficacion, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte

            miReporte.SetDataSource(Me.DsCajas1.Tables("SP_CONS_VERIFICACION"))
            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class