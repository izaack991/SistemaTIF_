Imports CrystalDecisions.CrystalReports.Engine
Imports System.Runtime.InteropServices
Imports System.IO

Module modFuncProc
    Public bDeshabilita As Boolean = False
    Public Sub ConsultaMovimientoAlmacen(aID_ESC As Integer)

        'Dim lID_ESC As String
        Dim lResp As Integer

        lResp = MessageBox.Show("¿Deseas abrir el detalle de este movimiento?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If lResp = MsgBoxResult.No Then
            Exit Sub
        End If

        'lID_ESC = Me.dgvDatos.SelectedRows(0).Cells("ID_ESC").Value

        Dim frmCONSULTA_MOVIMIENTO As New frmCONS_Movimiento_EntSal(False)

        frmCONSULTA_MOVIMIENTO.MdiParent = mdiPrincipal

        frmCONSULTA_MOVIMIENTO.DespliegaDatos(aID_ESC)

        frmCONSULTA_MOVIMIENTO.Show()
    End Sub

    Public Function DespliegaDescripcionCliente(ByRef aTxtCodMarcaCliente As TextBox, ByRef aTxtNomCliente As TextBox, Optional ByRef aoCliente As clsCliente = Nothing) As Boolean
        Dim lCodCliente As String = "0"
        Dim lMarcaCliente As String = ""
        'Dim lNomCliente As String = ""

        Dim oCliente As clsCliente
        aoCliente = New clsCliente(0)

        'lCodCliente = aTxtCodMarcaCliente.Text.Trim
        lMarcaCliente = aTxtCodMarcaCliente.Text.Trim

        Try
            DespliegaDescripcionCliente = False

            If lCodCliente = "" And lMarcaCliente = "" Then
                MessageBox.Show("Debe capturar una marca.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                aTxtCodMarcaCliente.Text = ""
                aTxtNomCliente.Text = ""

                Exit Function
            End If

            oCliente = New clsCliente(lCodCliente, lMarcaCliente)

            If oCliente.ID_CLIENTE <> 0 Then

                DespliegaDescripcionCliente = True

                aTxtCodMarcaCliente.Text = oCliente.Marca.Trim
                aTxtNomCliente.Text = oCliente.Nombre

                aoCliente = oCliente
            Else
                aTxtNomCliente.Text = ""
            End If

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function

    Public Function DespliegaDescripcionProducto(ByRef aTxtCodProducto As TextBox, ByRef aTxtNomProducto As TextBox, Optional ByRef aoProducto As clsProductos = Nothing) As Boolean
        Dim lCodProducto As String
        Dim lNomProducto As String = ""

        Dim oProducto As clsProductos
        aoProducto = New clsProductos(0)

        lCodProducto = aTxtCodProducto.Text.Trim

        Try
            DespliegaDescripcionProducto = False

            If lCodProducto = "" Then
                MessageBox.Show("Debe capturar una código de producto.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                aTxtCodProducto.Text = ""
                aTxtNomProducto.Text = ""

                Exit Function
            End If

            oProducto = New clsProductos(lCodProducto)

            If oProducto.ID_PROD <> "" Then

                DespliegaDescripcionProducto = True

                aTxtCodProducto.Text = oProducto.ID_PROD
                aTxtNomProducto.Text = oProducto.NOMBRE

                aoProducto = oProducto
            Else
                aTxtNomProducto.Text = ""
            End If

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function

    Function ReceiveSerialData() As String
        Dim returnStr As String = ""
        Dim com1 As IO.Ports.SerialPort = Nothing
        Dim Incoming As String
        Dim i As Integer

        Try
            com1 = My.Computer.Ports.OpenSerialPort(gPuertoBascula)
            com1.ReadTimeout = 5000
            Do
                Incoming = com1.ReadLine()

                'hace unas lecturas previas para eliminar la basura que manda la bascula
                For i = 1 To 2
                    Incoming = com1.ReadLine()
                    returnStr &= Incoming & vbNewLine
                Next
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                returnStr = ""
                Incoming = com1.ReadLine()
                returnStr &= Incoming & vbCrLf

                If InStr(returnStr, vbCrLf) > 0 Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop

        Catch ex As TimeoutException
            returnStr = "Error: Serial Port, se terminó el tiempo de espera."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

        Return gfDeterminaElPeso(returnStr)

        'Return returnStr
    End Function

    Public Function gfDeterminaElPeso(asLecturaSerial As String) As Decimal
        Try
            Dim i As Integer
            Dim y As Integer
            Dim lsPeso As String = ""
            Dim lsPesoAux As String = ""
            Dim lsPesoFinal As String = ""
            Dim lYaEncontroElPunto As Boolean = False
            Dim SalirCiclo As Boolean = False

            gfDeterminaElPeso = 0

            'asLecturaSerial = "Weight:  30.56Kg"

            If InStr(asLecturaSerial, "-") Then
                lsPeso = 0
            Else
                'busca el primer numero y a partir de ahi toma 7 caracteres o lo que quede de la cadena hacia el final
                For i = 0 To asLecturaSerial.Length - 1
                    If IsNumeric(asLecturaSerial.Substring(i, 1)) Then
                        lsPeso = asLecturaSerial.Substring(i, IIf(asLecturaSerial.Length - i > 7, 7, asLecturaSerial.Length - (i)))
                        For y = 0 To lsPeso.Length - 1
                            If IsNumeric(lsPeso.Substring(y, 1)) Or lsPeso.Substring(y, 1) = "." Then
                                lsPesoAux = lsPesoAux + lsPeso.Substring(y, 1)
                                SalirCiclo = True
                            End If
                        Next
                        If SalirCiclo Then
                            lsPeso = lsPesoAux
                            Exit For
                        End If
                    End If
                Next

                If IsNumeric(lsPeso) Then
                    gfDeterminaElPeso = CDec(lsPeso)
                End If
            End If

            Return gfDeterminaElPeso

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return gfDeterminaElPeso
        End Try
    End Function

    Public Sub Imprimir_CrystalReport(aDataTable As DataTable, aReporte As ReportDocument)
        'Public Sub Imprimir_CrystalReport(aID_ESC As Integer, aDataTable As DataTable, aReporte As ReportDocument)
        'EJEMPLO QUE DEBE PEGARSE CUANDO SE MANDA LLAMAR
        'Dim miReporte As ReportDocument = Nothing
        'miReporte = CType(New crptINV_EntSal, ReportDocument)
        '
        'modFuncProc.Imprimir_CrystalReport(oMovimientoEntSal.ID_ESC, dsSacrificio.SP_CONS_ENTSAL_X_MOVTO, miReporte)
        '
        Try
            Dim miReporte As ReportDocument = Nothing
            Dim dtReporte As DataTable

            miReporte = aReporte 'CType(New aReporte, ReportDocument)


            Dim oProductoCatalogo As New clsProductos
            dtReporte = aDataTable

            If dtReporte.Rows.Count > 0 Then
                miReporte.SetDataSource(dtReporte)
                Dim frmReporte As New frmCRViewer
                'frmReporte.MdiParent = mdiPrincipal
                frmReporte.crViewer.ReportSource = miReporte
                frmReporte.WindowState = FormWindowState.Maximized
                frmReporte.Show()
            Else

                MessageBox.Show("No se encontró información para generar el reporte.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Public Sub Genera_Numero_de_Renglon_Grid(ByRef aDataGrid As DataGridView, Optional ByVal aNombreRen As String = "")
        Dim I As Integer

        If aNombreRen = "" Then aNombreRen = "REN"

        For I = 0 To aDataGrid.RowCount - 1
            aDataGrid.Rows(I).Cells(aNombreRen).Value = I + 1
        Next
    End Sub

    Public Function SoloNumeros(ByVal Keyascii As Short, Optional ByVal PermitirPunto As Boolean = False) As Short
        Dim CaracteresPermitidos As String

        If PermitirPunto = False Then
            CaracteresPermitidos = "1234567890"
        Else
            CaracteresPermitidos = "1234567890."
        End If

        If InStr(CaracteresPermitidos, Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select


        '''''''''''''''''''''''''''''''''''''''''''
        'PEGAR ESTE CODIGO EN EL EVENTO KEYPRESS
        '''''''''''''''''''''''''''''''''''''''''''

        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoloNumeros(KeyAscii, True))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        'End If

    End Function

    Public Function RandomNumber(ByVal Upper As Integer, ByVal Lower As Integer) As Integer
        'Generates a Random Number BETWEEN the LOWER and UPPER values   
        Randomize()
        RandomNumber = Int((Upper - Lower + 1) * Rnd() + Lower)
    End Function

    Public Function GridAExcel(ByVal aGrid As DataGridView, ByVal aProgressBar As ProgressBar) As Boolean

        'Creamos las variables

        'TODO: agregar referencia a excel

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Dim lTotalCeldas As Integer = 0
        Dim lPorcAvance As Decimal = 0
        Dim lAvanceActual As Integer = 0

        Try
            aProgressBar.Value = 0
            aProgressBar.Visible = True
            aProgressBar.UseWaitCursor = True

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = aGrid.ColumnCount
            Dim NRow As Integer = aGrid.RowCount

            lTotalCeldas = NRow * NCol

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                'exHoja.Cells.Item(1, i) = aGrid.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(1, i) = aGrid.Columns(i - 1).HeaderText
                exHoja.Cells.Item(1, i).font.color = RGB(255, 255, 255)
                exHoja.Cells.Item(1, i).interior.color = RGB(0, 0, 80)
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = aGrid.Rows(Fila).Cells(Col).Value
                    lAvanceActual += 1
                    lPorcAvance = lAvanceActual / lTotalCeldas
                    aProgressBar.Value = lPorcAvance * 100
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = True
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            Return True

        Catch ex As Exception
            MessageBox.Show("Error al exportar a excel" & _
                        vbNewLine & vbNewLine & ex.Message, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Finally
            aProgressBar.UseWaitCursor = False
            aProgressBar.Visible = False
        End Try
    End Function

    Public Function DataTableAExcel(ByVal aDataTable As DataTable, ByVal aProgressBar As ProgressBar) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Dim lTotalCeldas As Integer = 0
        Dim lPorcAvance As Decimal = 0
        Dim lAvanceActual As Integer = 0

        Try
            aProgressBar.Value = 0
            aProgressBar.Visible = True
            aProgressBar.UseWaitCursor = True

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = aDataTable.Columns.Count
            Dim NRow As Integer = aDataTable.Rows.Count

            lTotalCeldas = NRow * NCol

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                'exHoja.Cells.Item(1, i) = aGrid.Columns(i - 1).HeaderText
                exHoja.Cells.Item(1, i) = aDataTable.Columns(i - 1).ColumnName
                exHoja.Cells.Item(1, i).font.color = RGB(255, 255, 255)
                exHoja.Cells.Item(1, i).interior.color = RGB(0, 0, 80)
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = aDataTable.Rows(Fila).Item(Col).ToString
                    lAvanceActual += 1
                    lPorcAvance = lAvanceActual / lTotalCeldas
                    aProgressBar.Value = lPorcAvance * 100
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = True
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            Return True

        Catch ex As Exception
            MessageBox.Show("Error al exportar a excel" & _
                        vbNewLine & vbNewLine & ex.Message, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Finally
            aProgressBar.UseWaitCursor = False
            aProgressBar.Visible = False
        End Try
    End Function

    Public Sub msgInformacionGuardada(ByRef Forma As System.Windows.Forms.Form, Optional ByVal asTextoAdicional As String = "")
        Dim lsMensaje As String

        lsMensaje = "La información fue guardada correctamente."

        If asTextoAdicional <> "" Then
            lsMensaje = lsMensaje & vbNewLine & vbNewLine & asTextoAdicional
        End If

        If Forma Is Nothing Then
            MessageBox.Show(lsMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(lsMensaje, gProyecto & " - " & Forma.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub FormatoGrid_MarcarCancelados(ByRef aGrid As DataGridView, _
            Optional ByVal aNomColEstatus As String = "ESTATUS", Optional ByVal aEstatus As String = "C")
        Try
            Dim i As Integer
            For i = 0 To aGrid.RowCount - 1
                If aGrid.Rows(i).Cells(aNomColEstatus).Value = aEstatus.ToUpper Then
                    aGrid.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    aGrid.Rows(i).DefaultCellStyle.ForeColor = Color.White

                End If
            Next

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Public Sub FormatoGrid_Marca300(ByRef aGrid As DataGridView, _
           Optional ByVal aNomColREV_CALIDAD As String = "REV_CALIDAD", Optional ByVal bREV_CALIDAD As Boolean = True)
        Try
            Dim i As Integer
            For i = 0 To aGrid.RowCount - 1
                If aGrid.Rows(i).Cells(aNomColREV_CALIDAD).Value = bREV_CALIDAD Then
                    aGrid.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                    aGrid.Rows(i).DefaultCellStyle.ForeColor = Color.White

                End If
            Next

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Public Sub FormatoGrid_MarcarDecomiso(ByRef aGrid As DataGridView, _
        Optional ByVal aNomColEstatus As String = "DECOMISO", Optional ByVal aDecomiso As String = "1")
        Try
            Dim i As Integer
            For i = 0 To aGrid.RowCount - 1
                If aGrid.Rows(i).Cells(aNomColEstatus).Value = aDecomiso.ToUpper Then
                    aGrid.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                    aGrid.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Public Sub Label_Cancelado(ByRef aLabel As Label, ByVal aEstatus As String)
        aLabel.Visible = False
        Select Case aEstatus
            Case "C"
                aLabel.BackColor = Color.Red
                aLabel.ForeColor = Color.Yellow
                aLabel.Text = "CANCELADO(A)"
                aLabel.Visible = True
            Case "A"
                aLabel.BackColor = Color.LawnGreen
                aLabel.ForeColor = Color.Black
                aLabel.Text = "ACTIVO(A)"
            Case Else
                aLabel.BackColor = Color.Red
                aLabel.ForeColor = Color.Yellow
                aLabel.Text = "NO ESPECIFICADO"
        End Select
    End Sub

    Public Class clsDirectorioTrabajo
        Public Sub Crear_Directorio()
            'Specify the directories you want to manipulate. 

            Dim path As String = gRutaTrabajo

            'Dim target As String = "c:\TestDir"

            Try
                ' Determine whethers the directory exists. 
                If Directory.Exists(path) = False Then
                    ' Create the directory.
                    Directory.CreateDirectory(path)
                End If

                'If Directory.Exists(target) Then
                '    ' Delete the target to ensure it is not there.
                '    Directory.Delete(target, True)
                'End If

                '' Move the directory.
                'Directory.Move(path, target)

                ''Create a file in the directory.
                'File.CreateText(target + "\myfile.txt")

                ''Count the files in the target.
                'Console.WriteLine("The number of files in {0} is {1}", _
                '  target, Directory.GetFiles(target).Length)

            Catch e As Exception
                Call modGeneral.ManejaExcepcion(e)
            End Try
        End Sub
    End Class

    Public Sub ImprimeEtiquetaRaw(ByVal aRutaArchivo As String, ByVal aNombreImpresora As String)
        Try
            If aNombreImpresora = "" Then
                MessageBox.Show("Debe seleccionar una impresora.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                mdiPrincipal.PrintDialog.ShowDialog()
                gNombreEtiquetadora = mdiPrincipal.PrintDialog.PrinterSettings.PrinterName
                aNombreImpresora = gNombreEtiquetadora
            End If

            Dim pText As New System.Text.StringBuilder

            ' Create an instance of StreamReader to read from a file.
            Dim srArchivo As IO.StreamReader = New IO.StreamReader(aRutaArchivo)
            Dim Linea As String
            Do
                Linea = srArchivo.ReadLine()
                pText.AppendLine(Linea)
            Loop Until Linea Is Nothing
            srArchivo.Close()

            RawPrinter.SendToPrinter("Sistema de Produccion", pText.ToString, aNombreImpresora)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Public Class RawPrinter
        Public Structure DOCINFO
            <MarshalAs(UnmanagedType.LPWStr)> Public DocumentName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public OutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public DataType As String
        End Structure

        <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function OpenPrinter(ByVal pPrinterName As String, ByRef phPrinter As IntPtr, ByVal pDefault As Integer) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal Level As Integer, ByRef pDocInfo As DOCINFO) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal data As String, ByVal buf As Integer, ByRef pcWritten As Integer) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        <DllImport("winspool.drv", CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Long
        End Function

        Public Shared Sub SendToPrinter(ByVal printerJobName As String, ByVal rawStringToSendToThePrinter As String, ByVal printerNameAsDescribedByPrintManager As String)
            Dim handleForTheOpenPrinter As New IntPtr()
            Dim documentInformation As New DOCINFO()
            Dim printerBytesWritten As Integer = 0
            documentInformation.DocumentName = printerJobName
            documentInformation.DataType = vbNullString
            documentInformation.OutputFile = vbNullString
            OpenPrinter(printerNameAsDescribedByPrintManager, handleForTheOpenPrinter, 0)
            StartDocPrinter(handleForTheOpenPrinter, 1, documentInformation)
            StartPagePrinter(handleForTheOpenPrinter)
            WritePrinter(handleForTheOpenPrinter, rawStringToSendToThePrinter, rawStringToSendToThePrinter.Length, printerBytesWritten)
            EndPagePrinter(handleForTheOpenPrinter)
            EndDocPrinter(handleForTheOpenPrinter)
            ClosePrinter(handleForTheOpenPrinter)
        End Sub
    End Class

    Public Sub Muestra_Pertenencia_Lote(aLote As Integer)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim dt As New DataTable()

            Dim lSql As String
            Dim lMensaje As String = ""
            Dim i As Integer

            lSql = "SP_CONS_PERTENENCIA_LOTES " & aLote.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New System.Data.SqlClient.SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Este lote no ha sido utilizado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                For i = 0 To dt.Rows.Count - 1
                    lMensaje = lMensaje & dt.Rows(i)("TIPO") & vbNewLine & " - LOTE: " & dt.Rows(i)("LOTE").ToString & vbNewLine & " - PRODUCTOR    : " & dt.Rows(i)("MARCA_PRODUCTOR").ToString & vbNewLine & " - INTRODUCTOR: " & dt.Rows(i)("MARCA_INTRODUCTOR").ToString & vbNewLine & " - DESTINO           : " & dt.Rows(i)("MARCA_DESTINO").ToString & vbNewLine & vbNewLine
                Next

                MessageBox.Show("Este lote ha sido utilizado en: " & vbNewLine & vbNewLine & lMensaje, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            da.Dispose()
            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
End Module
