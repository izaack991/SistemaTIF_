
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class frmPROC_ReetiquetarCajas

    Dim oCaja As clsMovimientoEntSal
    Dim oEtiqueta As clsEtiqueta

    Private Sub frmPROC_ReetiquetarCajas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Nuevo()
            Case Keys.F9
                Me.Imprimir_Individual()
            Case Keys.F11
                Me.Imprimir_Todas()
        End Select
    End Sub

    Private Sub Nuevo()
        Me.lstID.Items.Clear()
        Me.Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txtCodProd.Text = ""
        Me.txtNomProd.Text = ""
        Me.txtPiezas.Text = ""
        Me.txtPeso.Text = ""
        Me.txtFecha.Text = ""
        Me.txtLote.Text = ""
        Me.txtID.Text = ""
    End Sub

    Private Function Valida_CodBar(aCodBar As String) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Valida_CodBar = False

            Dim lCodBar As String = ""
            Dim lCodBarAux As String = ""
           
            oCaja = New clsMovimientoEntSal

            lCodBarAux = aCodBar

            Select Case lCodBarAux.Length
                Case 0
                    lCodBar = ""
                Case Is >= 7
                    lCodBar = Microsoft.VisualBasic.Right(lCodBarAux, 7)
                Case Else
                    lCodBar = ""
            End Select

            Me.Limpiar()

            If lCodBar = "" Then
                MessageBox.Show("No se pudo identificar el código de barras.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If

            oCaja = New clsMovimientoEntSal(1, lCodBar)

            If oCaja.ID_ESD = 0 Then
                MessageBox.Show("No existe una caja activa con el ID proporcionado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If

            Me.txtCodProd.Text = oCaja.ID_PROD.ToString.Trim
            Me.txtNomProd.Text = oCaja.NOMBRE_PRODUCTO
            Me.txtPiezas.Text = oCaja.PIEZAS
            Me.txtPeso.Text = oCaja.PESO
            Me.txtFecha.Text = oCaja.FECHA_ESD
            Me.txtLote.Text = oCaja.COR_LOTE
            Me.txtID.Text = oCaja.CAJA_SERIE_ID

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub Imprimir_Individual()
        Try
            If Me.CHKALSUPER.Checked = True Then
                generaetiqueta(oCaja.ID_ESD)
            Else

                Me.Cursor = Cursors.WaitCursor

                If oCaja.ID_ESD = 0 Then Exit Sub

                Dim lLote As String

                If Me.txtLoteNuevo.Text.Trim = "" Then
                    lLote = ""
                Else
                    lLote = Me.txtLoteNuevo.Text.Trim
                End If

                If Me.chkExportacion.Checked Then
                    oEtiqueta = New clsEtiqueta(3, oCaja.ID_ESD, 2)
                    'oEtiqueta.Reetiquetar_Etiqueta_Cortes_Exportacion(Me.txtIndicaciones.Text.Trim, Me.txtSM.Text.Trim, Me.dtpFecha.Value, lLote)
                    oEtiqueta.Reetiquetar_Etiqueta_Cortes_Exportacion(Me.txtIndicaciones.Text.Trim, Me.txtSM.Text.Trim, dtpFecha.Value, Me.txtLoteNuevo.Text)
                Else
                    oEtiqueta = New clsEtiqueta(2, oCaja.ID_ESD, 2)
                    oEtiqueta.Reetiquetar_Etiqueta_Cortes(Me.dtpFecha.Value, lLote)
                End If

                modGeneral.ImprimirUltimaEtiquetaCorte()
            End If

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub generaetiqueta(iIdesd As Integer)
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String

        Me.DsCajas.SP_IMPRIMIR_ET_EXP.Clear()

        lSql = " exec SP_IMPRIMIR_ET_EXP '" & iIdesd & "'"

        lCmd.Connection = Cnn
        lCmd.CommandType = CommandType.Text
        lCmd.CommandText = lSql

        Dim da As New SqlDataAdapter(lCmd)
        da.Fill(Me.DsCajas.SP_IMPRIMIR_ET_EXP)

        lCmd.Dispose()

        If Me.DsCajas.SP_IMPRIMIR_ET_EXP.Rows.Count = 0 Then
            MessageBox.Show("No hay información para mostrar.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim miReporte As ReportDocument = Nothing
        miReporte = CType(New crpt_IMP_ETIQ_PROD, ReportDocument)

        miReporte.SetDataSource(Me.DsCajas.Tables("SP_IMPRIMIR_ET_EXP"))
        Dim frmReporte As New frmCRViewer
        frmReporte.MdiParent = Me.ParentForm
        frmReporte.crViewer.ReportSource = miReporte

        'frmReporte.Show()
        'Dim CrExportOptions As ExportOptions
        'Dim CrDiskFileDestinationOptions As New  _
        'DiskFileDestinationOptions()
        'Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        'CrDiskFileDestinationOptions.DiskFileName = _
        '                            "D:\ETIQUETAS\crystalExport.pdf"
        'CrExportOptions = miReporte.ExportOptions
        'With CrExportOptions
        '    .ExportDestinationType = ExportDestinationType.DiskFile
        '    .ExportFormatType = ExportFormatType.PortableDocFormat
        '    .DestinationOptions = CrDiskFileDestinationOptions
        '    .FormatOptions = CrFormatTypeOptions
        'End With
        miReporte.PrintToPrinter(1, False, 0, 1)
        Me.txtPeso.Text = ""
    End Sub
    Private Sub Imprimir_Todas()
        Try
            Dim i As Integer
            Dim lCodBar As String
            Dim lRes As Integer

            lRes = MessageBox.Show("¿Esta seguro de imprimir todas las etiquetas?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If lRes = MsgBoxResult.No Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            For i = 0 To Me.lstID.Items.Count - 1
                lCodBar = Me.lstID.Items(i)
                If lCodBar.Trim <> "" Then
                    If Me.Valida_CodBar(lCodBar) Then
                        Imprimir_Individual()
                        Application.DoEvents()
                        Threading.Thread.Sleep(1500)
                        Application.DoEvents()
                    End If
                End If
            Next

            MessageBox.Show("Impresión terminada.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnPegar_Click(sender As Object, e As EventArgs) Handles btnPegar.Click
        Dim words As String() = Clipboard.GetText.Split(vbCrLf)
        For Each word As String In words
            lstID.Items.Add(word.Trim())
        Next
    End Sub

    Private Sub lstID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstID.SelectedIndexChanged
        If Me.lstID.SelectedIndex < 0 Then Exit Sub
        If Me.lstID.Items(Me.lstID.SelectedIndex).ToString = "" Then Exit Sub

        Dim lCodBar As String
        lCodBar = Me.lstID.Items(Me.lstID.SelectedIndex)
        Me.Valida_CodBar(lCodBar)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Me.Imprimir_Individual()
    End Sub

    Private Sub btnImprimir2_Click(sender As Object, e As EventArgs) Handles btnImprimir2.Click
        Me.Imprimir_Todas()
    End Sub

    Private Sub txtLoteNuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoteNuevo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii, False))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmPROC_ReetiquetarCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lstID.Items.Clear()
    End Sub
End Class