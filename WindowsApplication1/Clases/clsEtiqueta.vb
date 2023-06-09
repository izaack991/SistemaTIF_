Public Class clsEtiqueta
    Dim ioInfEtiq As clsInfEtiqueta
    Dim ioMovto As clsMovimientoEntSal
    '-------------------------------------
    Dim RetVal As Integer
    Dim FS As Object
    Dim A As Object
    '-------------------------------------C:\Users\JAVIER\Documents\Sistemas\Sistema\SistemaTIF\WindowsApplication1\Clases\clsEtiqueta.vb
    Dim iProdRefrigerado As String
    Dim iCodProducto As String
    Dim iHora As String
    Dim iLeyendaProduccion As String
    Dim iFecha As String
    Dim iEmpresa As String
    Dim iDireccion As String
    Dim iDireccion2 As String
    Dim iTelefono As String
    Dim iLeyendaProducto As String
    Dim iProducto As String
    Dim iLeyendaPeso As String
    Dim iPesoKg As String
    Dim iPesoAux As String
    Dim iPesoLb As String
    Dim iLeyendaCteOrig As String
    Dim iClienteOrigen As String
    Dim iLeyendaCteDest As String
    Dim iClienteDestino As String
    Dim iLeyendaSecuencia As String
    Dim iSecuencia As String
    Dim iSubsecuencia As String
    Dim iLote As String
    Dim iTIF As String
    Dim iLeyendaInspeccion As String
    Dim iCodBar As String
    Dim iIdent As String
    Dim iLimiteEdad As String
    Dim iVaciada As String
    Dim iTextoEtiqueta As String
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    Dim iCAJA_SERIE As String
    Dim iCAJA_ID As Integer
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    Public Sub New(aID_ETIQ As Integer, aID_ESD As Long, Optional aTipo_Etiqueta As Integer = 1)
        'aTipo_Etiqueta = 1 : aTipo_Etiqueta de canales

        If aID_ETIQ = 0 Or aID_ESD = 0 Then
            MessageBox.Show("Datos incorrectos, no se pudo generar la etiqueta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ioInfEtiq = New clsInfEtiqueta(aID_ETIQ, aTipo_Etiqueta)
        ioMovto = New clsMovimientoEntSal(0, aID_ESD)

        If ioInfEtiq.ID_ETQUETA = 0 Then
            MessageBox.Show("No existe el formato de etiqueta proporcionado, no se pudo generar la etiqueta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If ioMovto.ID_ESD = 0 Then
            MessageBox.Show("No existe el movmiento proporcionado, no se pudo generar la etiqueta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Select Case aTipo_Etiqueta
            Case 1
                Me.Genera_Etiqueta_Canales()
            Case Else
                'MessageBox.Show("No existe el tipo de etiqueta proporcionado, no se pudo generar la etiqueta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Exit Sub
        End Select
    End Sub

    Public Sub Cargar_Datos_Para_Etiqueta()
        'iProdRefrigerado = ""
        'iCodProducto = ""
        'iHora = ""
        'iLeyendaProduccion = ""
        'iFecha = ""
        'iEmpresa = ""
        'iDireccion = ""
        'iDireccion2 = ""
        'iTelefono = ""
        'iLeyendaProducto = ""
        'iProducto = ""
        'iLeyendaPeso = ""
        'iPesoKg = ""
        'iPesoAux = ""
        'iPesoLb = ""
        'iLeyendaCteOrig = ""
        'iClienteOrigen = ""
        'iLeyendaCteDest = ""
        'iClienteDestino = ""
        'iLeyendaSecuencia = ""
        'iSecuencia = ""
        'iSubsecuencia = ""
        'iLote = ""
        'iTIF = ""
        'iLeyendaInspeccion = ""
        'iCodBar = ""
        'iIdent = ""
        'iLimiteEdad = ""
        'iVaciada = ""
        'iTextoEtiqueta = ""
    End Sub

    Public Function Genera_Etiqueta_Canales() As Boolean
        Try
            Dim lCodBar As String = ""

            FS = CreateObject("Scripting.FileSystemObject")
            A = FS.CreateTextFile(gArchivoEtiquetaSac, True)

            A.WriteLine("FK " & Chr(34) & "*" & Chr(34))
            A.WriteLine("q800")
            A.WriteLine("Q800,24")
            A.WriteLine("S4")
            A.WriteLine("D8")
            A.WriteLine("ZB")
            A.WriteLine("TTh:m")
            A.WriteLine("TDy2.mn.dd")
            A.WriteLine("N")
            A.WriteLine("A580,760,2,1,1,1,N," & Chr(34) & ioInfEtiq.INSPECCIONADO_TIF & Chr(34))
            A.WriteLine("A750,60,2,1,1,1,N," & Chr(34) & goEmpresa.Nombre & Chr(34))
            A.WriteLine("A750,45,2,1,1,1,N," & Chr(34) & goEmpresa.Direccion & Chr(34))
            ' A.WriteLine("A750,30,2,1,1,1,N," & Chr(34) & lsDireccion2 & Chr(34))
            A.WriteLine("A750,15,2,1,1,1,N," & Chr(34) & goEmpresa.Telefono & Chr(34))
            A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            A.WriteLine("A720,85,1,4,1,1,N," & Chr(34) & ioMovto.FECHA_ESD & Chr(34))
            'A.WriteLine("A690,85,1,4,1,1,N," & Chr(34) & ioMovto.HORA_ESD & Chr(34))
            A.WriteLine("A750,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.LOTE & " " & ioMovto.SAC_LOTE.ToString & Chr(34))
            A.WriteLine("A690,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.TIF & " " & goEmpresa.TIF & Chr(34))
            A.WriteLine("A620,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PRODUCTO & Chr(34))
            A.WriteLine("A620,520,1,1,1,1,N," & Chr(34) & ioInfEtiq.CONTENIDO_PRODUCTO & Chr(34))

            'A.WriteLine("A600,85,1,5,1,1,R," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO & Space(18), 18) & Chr(34))
            A.WriteLine("A600,85,1,5,1,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO & Space(18), 18) & Chr(34))

            'PESO ALINEADO A LA IZQUIERDA
            'A.WriteLine("A520,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PESO_NETO & Chr(34))
            'A.WriteLine("A500,85,1,5,1,1,N," & Chr(34) & Format(ioMovto.PESO, "#,##0.00") & "KG" & Chr(34))

            A.WriteLine("A520,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PESO_NETO & Chr(34))
            A.WriteLine("A500,250,1,5,1,1,N," & Chr(34) & Format(ioMovto.PESO, "#,##0.00") & "KG" & Chr(34))

            'A.WriteLine("A500,450,1,5,1,1,N," & Chr(34) & Format(.Peso_Caliente * modGeneral.FactorLibras, "#,##0.00") & "LB" & Chr(34))
            A.WriteLine("A420,85,1,2,1,1,N," & Chr(34) & "DE:" & Chr(34))
            A.WriteLine("A400,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_INTRODUCTOR & Chr(34))
            A.WriteLine("A420,300,1,2,1,1,N," & Chr(34) & "PARA:" & Chr(34))
            A.WriteLine("A400,300,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_DESTINO_DET & Chr(34))

            'CONSECUTIVO
            A.WriteLine("A420,550,1,2,1,1,N," & Chr(34) & "CANAL:" & Chr(34))
            A.WriteLine("A400,550,1,3,2,2,N," & Chr(34) & ioMovto.SAC_CONSECUTIVO & "-" & ioMovto.SAC_LADO & Chr(34))

            A.WriteLine("A320,100,1,3,2,2,N," & Chr(34) & IIf(ioMovto.SAC_MAYOR = 0, "", ">30m") & Chr(34))
            A.WriteLine("A280,100,1,3,2,2,N," & Chr(34) & IIf(ioMovto.SAC_VACIADA = 0, "", "v") & Chr(34))

            'A.WriteLine("A320,85,1,2,1,1,N," & Chr(34) & lsLeyendaSecuencia & Chr(34))
            'A.WriteLine("A290,85,1,4,1,1,N," & Chr(34) & lsSecuencia & " - " & lsSubsecuencia & Chr(34))

            'A.WriteLine("A290,520,1,3,2,2,N," & Chr(34) & lsIdent & Chr(34))

            'A.WriteLine("A230,85,1,2,1,2,N," & Chr(34) & lsTextoEtiqueta & Chr(34))
            lCodBar = Right("0000" & ioMovto.ID_PROD.ToString, 4) & Right("000000" & CStr(CInt(ioMovto.PESO * 100)), 6) & ioMovto.SAC_SERIE_ID

            A.WriteLine("B180,85,1,1B,2,8,100,B," & Chr(34) & lCodBar & Chr(34))

            A.writeline("X530,80,1,530,750")
            A.writeline("X440,80,1,440,750")

            A.WriteLine("P1")
            A.WriteLine("FE")
            A.Close()

            'modFuncProc.ImprimeEtiquetaRaw(gArchivoEtiquetaSac, gNombreEtiquetadora)
            'modGeneral.ImprimirUltimaEtiquetaSacrificio()

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function
    Public Function Genera_Etiqueta_Cortes(Optional ByVal aIndicaciones As String = "", Optional ByVal bVacio As Boolean = False) As Boolean
        Try
            Dim lCodBar As String = ""

            FS = CreateObject("Scripting.FileSystemObject")
            A = FS.CreateTextFile(gArchivoEtiquetaCorte, True)

            A.WriteLine("FK " & Chr(34) & "*" & Chr(34))
            A.WriteLine("q800")
            A.WriteLine("Q800,24")
            A.WriteLine("S4")
            A.WriteLine("D8")
            A.WriteLine("ZB")
            A.WriteLine("TTh:m")
            A.WriteLine("TDy2.mn.dd")
            A.WriteLine("N")
            A.WriteLine("A680,760,2,1,1,1,N," & Chr(34) & ioInfEtiq.INSPECCIONADO_TIF & Chr(34))
            A.WriteLine("A750,60,2,1,1,1,N," & Chr(34) & goEmpresa.Nombre & Chr(34))
            A.WriteLine("A750,45,2,1,1,1,N," & Chr(34) & goEmpresa.Direccion & Chr(34))
            A.WriteLine("A750,30,2,1,1,1,N," & Chr(34) & goEmpresa.Colonia & ", " & goEmpresa.Municipio & ", " & goEmpresa.Estado & Chr(34))
            A.WriteLine("A750,15,2,1,1,1,N," & Chr(34) & goEmpresa.Telefono & Chr(34))

            'A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            'A.WriteLine("A720,85,1,4,1,1,N," & Chr(34) & ioMovto.FECHA_ESD & Chr(34))
            ''A.WriteLine("A690,85,1,4,1,1,N," & Chr(34) & ioMovto.HORA_ESD & Chr(34))

            A.WriteLine("A750,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.LOTE & " " & ioMovto.COR_LOTE.ToString & Chr(34))
            A.WriteLine("A690,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.TIF & " " & goEmpresa.TIF & Chr(34))
            A.WriteLine("A620,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PRODUCTO & Chr(34))
            A.WriteLine("A620,520,1,1,1,1,N," & Chr(34) & ioInfEtiq.CONTENIDO_PRODUCTO & Chr(34))

            'A.WriteLine("A420,85,1,2,1,1,N," & Chr(34) & "DE:" & Chr(34))
            'A.WriteLine("A400,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_INTRODUCTOR & Chr(34))
            A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & "PARA:" & Chr(34))
            A.WriteLine("A730,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_DESTINO_DET & Chr(34))

            If Len(ioMovto.NOMBRE_PRODCTE.Trim) <= 18 Then
                A.WriteLine("A600,85,1,5,1,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO & Space(18), 18) & Chr(34))
            Else
                A.WriteLine("A600,85,1,4,3,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO, 40) & Chr(34))
            End If

            If aIndicaciones <> "MEJORADO" Then
                A.WriteLine("A510,280,1,3,1,1,N," & Chr(34) & aIndicaciones & Chr(34))
            End If

            A.WriteLine("A460,650,1,4,1,1,N," & Chr(34) & IIf(ioMovto.SAC_MAYOR = 1, ">30", "") & Chr(34))

            A.WriteLine("A520,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PIEZAS & "/PC(S)" & Chr(34))
            A.WriteLine("A500,120,1,5,1,1,N," & Chr(34) & ioMovto.PIEZAS & Chr(34))

            A.WriteLine("A520,420,1,1,1,1,N," & Chr(34) & "HORA PRODUCCION:" & Chr(34))
            A.WriteLine("A500,420,1,3,2,2,N," & Chr(34) & ioMovto.HORA_ESD & Chr(34))

            A.WriteLine("A430,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PESO_NETO & Chr(34))
            A.WriteLine("A410,100,1,5,1,1,N," & Chr(34) & Format(ioMovto.PESO, "#,##0.00") & ioInfEtiq.KGS & Chr(34))

            A.WriteLine("A430,400,1,1,1,1,N," & Chr(34) & "NET WEIGHT" & Chr(34))
            A.WriteLine("A410,415,1,5,1,1,N," & Chr(34) & Format(ioMovto.LBS, "#,##0.00") & ioInfEtiq.LBS & Chr(34))

            'A.WriteLine("A500,450,1,5,1,1,N," & Chr(34) & Format(.Peso_Caliente * modGeneral.FactorLibras, "#,##0.00") & "LB" & Chr(34))

            A.WriteLine("A320,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            A.WriteLine("A300,85,1,3,2,2,N," & Chr(34) & ioMovto.FECHA_ESD & Chr(34))

            A.WriteLine("A320,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_CADUCIDAD & Chr(34))
            A.WriteLine("A300,420,1,3,2,2,N," & Chr(34) & ioMovto.FECHA_CADUCIDAD & Chr(34))
            If bVacio = False Then
                A.WriteLine("A130,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.VACIO & Chr(34))
            End If
            Dim iDias As Integer
            iDias = DateDiff(DateInterval.Day, Date.Now, Convert.ToDateTime(ioMovto.FECHA_CADUCIDAD))
            If iDias >= 300 Then
                A.WriteLine("A130,420,1,2,1,1,N," & Chr(34) & "Mantenerse a -18 C" & Chr(34))
            Else
                A.WriteLine("A130,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            End If
            
            'A.WriteLine("A230,85,1,2,1,2,N," & Chr(34) & lsTextoEtiqueta & Chr(34))
            'lCodBar = Right("0000" & ioMovto.ID_PROD.ToString, 4) & Right("000000" & CStr(CInt(ioMovto.PESO * 100)), 6) & ioMovto.SAC_SERIE_ID
            'A.WriteLine("B160,5,1,1B,2,12,120,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))
            A.WriteLine("B260,85,1,1,2,7,100,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))


            A.writeline("X530,80,1,530,750")
            A.writeline("X340,80,1,340,750")

            A.WriteLine("P1")
            A.WriteLine("FE")
            A.Close()

            'modFuncProc.ImprimeEtiquetaRaw(gArchivoEtiquetaSac, gNombreEtiquetadora)
            'modGeneral.ImprimirUltimaEtiquetaSacrificio()

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function

    Public Function Genera_Etiqueta_Cortes_Exportacion(Optional ByVal aIndicaciones As String = "", Optional ByVal aShippingMark As String = "") As Boolean
        Try
            Dim lCodBar As String = ""
            Dim loProducto As New clsProductos(ioMovto.ID_PROD)

            FS = CreateObject("Scripting.FileSystemObject")
            A = FS.CreateTextFile(gArchivoEtiquetaCorte, True)

            A.WriteLine("FK " & Chr(34) & "*" & Chr(34))
            A.WriteLine("q800")
            A.WriteLine("Q800,24")
            A.WriteLine("S4")
            A.WriteLine("D8")
            A.WriteLine("ZB")
            A.WriteLine("TTh:m")
            A.WriteLine("TDy2.mn.dd")
            A.WriteLine("N")
            A.WriteLine("A680,760,2,1,1,1,N," & Chr(34) & ioInfEtiq.INSPECCIONADO_TIF & Chr(34))
            A.WriteLine("A750,60,2,1,1,1,N," & Chr(34) & goEmpresa.Nombre & Chr(34))
            A.WriteLine("A750,45,2,1,1,1,N," & Chr(34) & goEmpresa.Direccion & Chr(34))
            A.WriteLine("A750,30,2,1,1,1,N," & Chr(34) & goEmpresa.Colonia & ", " & goEmpresa.Municipio & ", " & goEmpresa.Estado & Chr(34))
            A.WriteLine("A750,15,2,1,1,1,N," & Chr(34) & goEmpresa.Telefono & Chr(34))

            'A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            'A.WriteLine("A720,85,1,4,1,1,N," & Chr(34) & ioMovto.FECHA_ESD & Chr(34))
            ''A.WriteLine("A690,85,1,4,1,1,N," & Chr(34) & ioMovto.HORA_ESD & Chr(34))

            A.WriteLine("A750,520,1,4,1,1,N," & Chr(34) & ioInfEtiq.LOTE & " " & ioMovto.COR_LOTE.ToString & Chr(34))
            A.WriteLine("A690,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.TIF & " " & goEmpresa.TIF & Chr(34))
            A.WriteLine("A620,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PRODUCTO & Chr(34))
            A.WriteLine("A620,520,1,1,1,1,N," & Chr(34) & ioInfEtiq.CONTENIDO_PRODUCTO & Chr(34))

            'A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & "PARA:" & Chr(34))
            'A.WriteLine("A730,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_DESTINO_DET & Chr(34))

            A.WriteLine("A750,85,1,4,1,1,N," & Chr(34) & ioInfEtiq.SHIPPINGMARK & Chr(34))
            A.WriteLine("A720,85,1,3,2,2,N," & Chr(34) & aShippingMark & Chr(34))

            If Len(ioMovto.NOMBRE_PRODCTE.Trim) <= 18 Then
                A.WriteLine("A600,85,1,5,1,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO & Space(18), 18) & Chr(34))
            Else
                A.WriteLine("A600,85,1,4,2,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO, 40) & Chr(34))
            End If

            If Len(loProducto.NOM_CLASIF_EXP.Trim) <= 18 Then
                A.WriteLine("A510,85,1,5,1,1,N," & Chr(34) & loProducto.NOM_CLASIF_EXP & Chr(34))
            Else
                A.WriteLine("A510,85,1,2,1,1,N," & Chr(34) & loProducto.NOM_CLASIF_EXP & Chr(34))
            End If


            A.WriteLine("A660,85,1,3,1,1,N," & Chr(34) & aIndicaciones & Chr(34))

            A.WriteLine("A460,650,1,4,1,1,N," & Chr(34) & IIf(ioMovto.SAC_MAYOR = 1, ">30", "") & Chr(34))

            A.WriteLine("A430,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PIEZAS & "/PC(S)" & Chr(34))
            A.WriteLine("A410,120,1,5,1,1,N," & Chr(34) & ioMovto.PIEZAS & Chr(34))

            A.WriteLine("A430,260,1,1,1,1,N," & Chr(34) & "NET WEIGHT" & Chr(34))
            A.WriteLine("A410,275,1,5,1,1,N," & Chr(34) & Format(ioMovto.LBS, "#,##0.00") & Chr(34))
            A.WriteLine("A400,460,1,4,2,1,N," & Chr(34) & ioInfEtiq.LBS & Chr(34))

            A.WriteLine("A430,570,1,1,1,1,N," & Chr(34) & ioInfEtiq.PESO_NETO & Chr(34))
            A.WriteLine("A400,585,1,4,2,1,N," & Chr(34) & Format(ioMovto.PESO, "#,##0.00") & " " & ioInfEtiq.KGS & Chr(34))

            'A.WriteLine("A500,450,1,5,1,1,N," & Chr(34) & Format(.Peso_Caliente * modGeneral.FactorLibras, "#,##0.00") & "LB" & Chr(34))

            A.WriteLine("A320,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            A.WriteLine("A300,85,1,3,2,2,N," & Chr(34) & Format(CDate(ioMovto.FECHA_ESD), "MM/dd/yyyy") & " " & ioMovto.HORA_ESD & Chr(34))

            'A.WriteLine("A320,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_CADUCIDAD & Chr(34))
            'A.WriteLine("A300,420,1,3,2,2,N," & Chr(34) & Format(CDate(ioMovto.FECHA_CADUCIDAD), "MM/dd/yyyy") & Chr(34))

            'A.WriteLine("A220,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.VACIO & Chr(34))
            'A.WriteLine("A220,350,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            A.WriteLine("A222,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            A.WriteLine("A222,550,1,2,1,1,N," & Chr(34) & ioInfEtiq.ORIGEN_PRODUCTO & Chr(34))
            'A.WriteLine("A230,85,1,2,1,2,N," & Chr(34) & lsTextoEtiqueta & Chr(34))
            'lCodBar = Right("0000" & ioMovto.ID_PROD.ToString, 4) & Right("000000" & CStr(CInt(ioMovto.PESO * 100)), 6) & ioMovto.SAC_SERIE_ID
            'A.WriteLine("B160,5,1,1B,2,12,120,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))
            A.WriteLine("B160,85,1,1,2,7,100,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))


            A.writeline("X530,80,1,530,750")
            A.writeline("X340,80,1,340,750")

            A.WriteLine("P1")
            A.WriteLine("FE")
            A.Close()

            'modFuncProc.ImprimeEtiquetaRaw(gArchivoEtiquetaSac, gNombreEtiquetadora)
            'modGeneral.ImprimirUltimaEtiquetaSacrificio()

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function

    Public Function Reetiquetar_Etiqueta_Cortes_Exportacion(Optional ByVal aIndicaciones As String = "", Optional ByVal aShippingMark As String = "", _
                                                             Optional ByVal aFechaProduccion As String = "", Optional ByVal aLote As String = "") As Boolean
        Try
            Dim lCodBar As String = ""
            Dim loProducto As New clsProductos(ioMovto.ID_PROD)
            Dim lLote As String
            Dim lFechaProduccion As String

            If aLote.Trim = "" Then
                lLote = ioMovto.COR_LOTE.ToString
            Else
                lLote = aLote.Trim
            End If

            If aFechaProduccion.Trim = "" Then
                lFechaProduccion = Format(CDate(ioMovto.FECHA_ESD), "MM/dd/yyyy")
            Else
                lFechaProduccion = Format(CDate(aFechaProduccion), "MM/dd/yyyy")
            End If

            FS = CreateObject("Scripting.FileSystemObject")
            A = FS.CreateTextFile(gArchivoEtiquetaCorte, True)

            A.WriteLine("FK " & Chr(34) & "*" & Chr(34))
            A.WriteLine("q800")
            A.WriteLine("Q800,24")
            A.WriteLine("S4")
            A.WriteLine("D8")
            A.WriteLine("ZB")
            A.WriteLine("TTh:m")
            A.WriteLine("TDy2.mn.dd")
            A.WriteLine("N")
            A.WriteLine("A680,760,2,1,1,1,N," & Chr(34) & ioInfEtiq.INSPECCIONADO_TIF & Chr(34))
            A.WriteLine("A750,60,2,1,1,1,N," & Chr(34) & goEmpresa.Nombre & Chr(34))
            A.WriteLine("A750,45,2,1,1,1,N," & Chr(34) & goEmpresa.Direccion & Chr(34))
            A.WriteLine("A750,30,2,1,1,1,N," & Chr(34) & goEmpresa.Colonia & ", " & goEmpresa.Municipio & ", " & goEmpresa.Estado & Chr(34))
            A.WriteLine("A750,15,2,1,1,1,N," & Chr(34) & goEmpresa.Telefono & Chr(34))

            'A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            'A.WriteLine("A720,85,1,4,1,1,N," & Chr(34) & ioMovto.FECHA_ESD & Chr(34))
            ''A.WriteLine("A690,85,1,4,1,1,N," & Chr(34) & ioMovto.HORA_ESD & Chr(34))

            A.WriteLine("A750,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.LOTE & " " & lLote & Chr(34))
            A.WriteLine("A690,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.TIF & " " & goEmpresa.TIF & Chr(34))
            A.WriteLine("A620,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PRODUCTO & Chr(34))
            A.WriteLine("A620,520,1,1,1,1,N," & Chr(34) & ioInfEtiq.CONTENIDO_PRODUCTO & Chr(34))

            'A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & "PARA:" & Chr(34))
            'A.WriteLine("A730,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_DESTINO_DET & Chr(34))

            A.WriteLine("A750,85,1,4,1,1,N," & Chr(34) & ioInfEtiq.SHIPPINGMARK & Chr(34))
            A.WriteLine("A720,85,1,3,2,2,N," & Chr(34) & aShippingMark & Chr(34))

            If Len(ioMovto.NOMBRE_PRODCTE.Trim) <= 18 Then
                A.WriteLine("A600,85,1,5,1,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO & Space(18), 18) & Chr(34))
            Else
                A.WriteLine("A600,85,1,4,3,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO, 40) & Chr(34))
            End If

            If Len(loProducto.NOM_CLASIF_EXP.Trim) <= 18 Then
                A.WriteLine("A510,85,1,5,1,1,N," & Chr(34) & loProducto.NOM_CLASIF_EXP & Chr(34))
            Else
                A.WriteLine("A510,85,1,4,3,1,N," & Chr(34) & loProducto.NOM_CLASIF_EXP & Chr(34))
            End If

            A.WriteLine("A660,85,1,3,1,1,N," & Chr(34) & aIndicaciones & Chr(34))

            A.WriteLine("A460,650,1,4,1,1,N," & Chr(34) & IIf(ioMovto.SAC_MAYOR = 1, ">30", "") & Chr(34))

            A.WriteLine("A430,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PIEZAS & "/PC(S)" & Chr(34))
            A.WriteLine("A410,120,1,5,1,1,N," & Chr(34) & ioMovto.PIEZAS & Chr(34))

            A.WriteLine("A430,260,1,1,1,1,N," & Chr(34) & "NET WEIGHT" & Chr(34))
            A.WriteLine("A410,275,1,5,1,1,N," & Chr(34) & Format(ioMovto.LBS, "#,##0.00") & Chr(34))
            A.WriteLine("A400,460,1,4,2,1,N," & Chr(34) & ioInfEtiq.LBS & Chr(34))

            A.WriteLine("A430,570,1,1,1,1,N," & Chr(34) & ioInfEtiq.PESO_NETO & Chr(34))
            A.WriteLine("A400,585,1,4,2,1,N," & Chr(34) & Format(ioMovto.PESO, "#,##0.00") & " " & ioInfEtiq.KGS & Chr(34))

            'A.WriteLine("A500,450,1,5,1,1,N," & Chr(34) & Format(.Peso_Caliente * modGeneral.FactorLibras, "#,##0.00") & "LB" & Chr(34))

            A.WriteLine("A320,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            A.WriteLine("A300,85,1,3,2,2,N," & Chr(34) & lFechaProduccion & Chr(34))

            'A.WriteLine("A320,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_CADUCIDAD & Chr(34))
            'A.WriteLine("A300,420,1,3,2,2,N," & Chr(34) & Format(CDate(ioMovto.FECHA_CADUCIDAD), "MM/dd/yyyy") & Chr(34))

            'A.WriteLine("A220,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.VACIO & Chr(34))
            'A.WriteLine("A220,350,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            ' Dim iDias As Integer
            'iDias = DateDiff(DateInterval.Day, Date.Now, Convert.ToDateTime(ioMovto.FECHA_CADUCIDAD))
            'If iDias >= 365 Then
            '    A.WriteLine("A130,420,1,2,1,1,N," & Chr(34) & "Mantenerse a -18 C" & Chr(34))
            'Else
            'A.WriteLine("A130,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            'End If
            A.WriteLine("A222,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            'A.WriteLine("A130,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            'A.WriteLine("A220,350,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            A.WriteLine("A222,350,1,2,1,1,N," & Chr(34) & ioInfEtiq.ORIGEN_PRODUCTO & Chr(34))
            'A.WriteLine("A230,85,1,2,1,2,N," & Chr(34) & lsTextoEtiqueta & Chr(34))
            'lCodBar = Right("0000" & ioMovto.ID_PROD.ToString, 4) & Right("000000" & CStr(CInt(ioMovto.PESO * 100)), 6) & ioMovto.SAC_SERIE_ID
            'A.WriteLine("B160,5,1,1B,2,12,120,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))
            A.WriteLine("B160,85,1,1,2,7,100,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))


            A.writeline("X530,80,1,530,750")
            A.writeline("X340,80,1,340,750")

            A.WriteLine("P1")
            A.WriteLine("FE")
            A.Close()

            'modFuncProc.ImprimeEtiquetaRaw(gArchivoEtiquetaSac, gNombreEtiquetadora)
            'modGeneral.ImprimirUltimaEtiquetaSacrificio()

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function


    Public Sub GeneraEtiquetaExportacion_PRUEBAS(Optional ByVal aImprimeFechaCaducidad As Boolean = False)
        'Try
        '    Dim FS As Object
        '    Dim A As Object

        '    FS = CreateObject("Scripting.FileSystemObject")
        '    'A = FS.CreateTextFile("c:\windows\etiqcor.txt", True)
        '    A = FS.CreateTextFile(gArchivoEtiquetaCorte, True)


        '    Me.Peso_Neto_en_Lbs = Format(Math.Round((CDec(Me.Peso_Neto_en_Kgs) * modGeneral.FactorLibras), 2), "#,##0.00")

        '    A.WriteLine("FK " & Chr(34) & "*" & Chr(34))
        '    A.WriteLine("q800")
        '    A.WriteLine("Q800,24")
        '    A.WriteLine("S4")
        '    A.WriteLine("D8")
        '    A.WriteLine("ZB")
        '    A.WriteLine("TTh:m")
        '    A.WriteLine("TDy2.mn.dd")
        '    A.WriteLine("N")


        '    A.WriteLine("A490,770,2,1,1,1,N," & Chr(34) & ioInfEtiq.INSPECCIONADO_TIF & Chr(34))
        '    A.WriteLine("A490,60,2,1,1,1,N," & Chr(34) & goEmpresa.Nombre & Chr(34))
        '    A.WriteLine("A490,45,2,1,1,1,N," & Chr(34) & goEmpresa.Direccion & Chr(34))
        '    A.WriteLine("A490,30,2,1,1,1,N," & Chr(34) & goEmpresa.Municipio & Chr(34))
        '    A.WriteLine("A490,15,2,1,1,1,N," & Chr(34) & goEmpresa.Telefono & Chr(34))

        '    A.WriteLine("A700,320,1,2,2,1,N," & Chr(34) & ioInfEtiq.TIF & " " & goEmpresa.TIF & Chr(34))

        '    A.WriteLine("A650,250,1,1,1,1,N," & Chr(34) & "INSPECT. AND APROV. BY TIF" & Chr(34))

        '    'Me.Codigo_ShippingMark = "2010060015"
        '    'iLote = "PSXLRW"
        '    'Me.iCodigo_del_Producto = "0000"
        '    'Me.iDescripcion_del_Producto_Ingles = ""
        '    'Me.iDescripcion_Familia_Exportacion = ""
        '    'Me.iDescripcion_del_Producto = ""
        '    'iPiezas = ""
        '    'iPeso_Neto_en_Lbs = ""
        '    'iPeso_Neto_en_Kgs = ""
        '    'iFecha_de_Produccion = ""
        '    'iCodigo_de_Barras_Externo = ""


        '    'A.WriteLine("B750,15,1,1B,1,8,100,B," & Chr(34) & iCodigo_de_Barras_Interno & Chr(34))
        '    A.WriteLine("A760,15,1,2,2,2,N," & Chr(34) & Me.iLEYENDA_SHIPPING_MARK & Chr(34))
        '    A.WriteLine("A720,15,1,3,2,2,N," & Chr(34) & Me.Codigo_ShippingMark & Chr(34))

        '    A.WriteLine("A660,15,1,1,1,1,N," & Chr(34) & Me.LEYENDA_ORIGEN_PRODUCTO_INGLES & Chr(34))

        '    A.WriteLine("A750,610,1,2,1,1,N," & Chr(34) & Me.iLEYENDA_LOTE_INGLES & "/" & Me.iLEYENDA_LOTE & Chr(34))
        '    'A.WriteLine("A750,650,1,3,1,1,N," & Chr(34) & Me.iLEYENDA_LOTE & Chr(34))
        '    A.WriteLine("A730,620,1,2,1,1,N," & Chr(34) & iLote & Chr(34))

        '    A.WriteLine("A690,580,1,2,1,1,N," & Chr(34) & Me.iLEYENDA_PRODUCTO_INGLES & Chr(34))
        '    A.WriteLine("A670,560,1,2,1,1,N," & Chr(34) & Me.iLEYENDA_PRODUCTO & Chr(34))
        '    A.WriteLine("A650,620,1,2,1,1,N," & Chr(34) & Me.iCodigo_del_Producto & Chr(34))

        '    'A.writeline("X607,15,60,564,750")

        '    If Len(iDescripcion_del_Producto_Ingles.Trim) <= 20 Then
        '        A.WriteLine("A630,15,1,5,1,1,R," & Chr(34) & iDescripcion_del_Producto_Ingles & Chr(34))
        '    Else
        '        A.WriteLine("A635,20,1,4,3,1,R," & Chr(34) & Left(iDescripcion_del_Producto_Ingles, 40) & Chr(34))
        '    End If
        '    'A.WriteLine("A630,15,1,5,1,1,R," & Chr(34) & Me.iDescripcion_del_Producto_Ingles & Chr(34))

        '    Select Case iCodigo_Familia_Exportacion
        '        Case 1, 2, 3
        '            A.WriteLine("A560,15,1,5,1,1,R," & Chr(34) & Me.iDescripcion_Familia_Exportacion & Chr(34))
        '        Case 4, 5
        '            'A.WriteLine("A560,15,1,4,1,1,R," & Chr(34) & Me.iDescripcion_Familia_Exportacion & Chr(34))
        '            A.WriteLine("A560,15,1,2,2,2,R," & Chr(34) & Me.iDescripcion_Familia_Exportacion & Chr(34))

        '            'APROBACION
        '            A.WRITELINE("A515,100,1,2,1,1,N," & Chr(34) & iLEYENDA_APROBACION & Chr(34))
        '            'PROPORCION
        '            A.WRITELINE("A515,350,1,2,1,1,N," & Chr(34) & iLEYENDA_PROPORCION & Chr(34))
        '            'INGREDIENTES
        '            A.WriteLine("A490,100,1,1,1,1,N," & Chr(34) & "INGREDIENTS:" & Chr(34))

        '            'A.WriteLine("A475,100,1,1,1,1,N," & Chr(34) & Mid(iLEYENDA_INGREDIENTES, 1, Len(iLEYENDA_INGREDIENTES) / 2) & " -" & Chr(34))
        '            'A.WriteLine("A460,100,1,1,1,1,N," & Chr(34) & Mid(iLEYENDA_INGREDIENTES, (Len(iLEYENDA_INGREDIENTES) / 2) + 1) & Chr(34))

        '            A.WriteLine("A475,100,1,1,1,1,N," & Chr(34) & Mid(iLEYENDA_INGREDIENTES, 1, 64) & Chr(34))
        '            A.WriteLine("A460,100,1,1,1,1,N," & Chr(34) & Mid(iLEYENDA_INGREDIENTES, 65) & Chr(34))
        '    End Select


        '    'A.writeline("X440,15,1,440,750")
        '    A.writeline("X440,80,1,440,750")

        '    A.WriteLine("A430,80,1,2,1,1,N," & Chr(34) & iLEYENDA_PIEZAS_INGLES & "/" & iLEYENDA_PIEZAS & Chr(34))
        '    'A.WriteLine("A450,150,1,2,1,1,N," & Chr(34) & iLEYENDA_PIEZAS & Chr(34))
        '    A.WriteLine("A390,130,1,5,1,1,N," & Chr(34) & iPiezas & Chr(34))

        '    A.WriteLine("A430,320,1,2,1,1,N," & Chr(34) & iLEYENDA_PESO_NETO_INGLES & Chr(34))
        '    A.WriteLine("A390,250,1,5,1,1,N," & Chr(34) & iPeso_Neto_en_Lbs & Chr(34))
        '    A.WriteLine("A355,450,1,3,1,1,N," & Chr(34) & iLEYENDA_LBS & Chr(34))

        '    A.WriteLine("A430,600,1,2,1,1,N," & Chr(34) & iLEYENDA_PESO_NETO & Chr(34))
        '    A.WriteLine("A380,570,1,4,2,1,N," & Chr(34) & iPeso_Neto_en_Kgs & Chr(34))
        '    A.WriteLine("A355,680,1,3,1,1,N," & Chr(34) & iLEYENDA_KGS & Chr(34))

        '    If iTipo_de_refrigeracion_del_producto = 1 Then
        '        'A.WriteLine("A330,85,1,4,1,1,N," & Chr(34) & iLEYENDA_CARNE_FRESCA_INGLES & Chr(34))
        '        A.WriteLine("A300,220,1,2,1,1,N," & Chr(34) & iLEYENDA_INDICACION_TEMPERATURA_INGLES & Chr(34))
        '        A.WriteLine("A280,220,1,1,1,1,N," & Chr(34) & iLEYENDA_INDICACION_TEMPERATURA & Chr(34))
        '    Else
        '        'A.WriteLine("A330,85,1,4,1,1,N," & Chr(34) & iLEYENDA_CARNE_FRESCA_INGLES & Chr(34))
        '        A.WriteLine("A300,220,1,2,1,1,N," & Chr(34) & "FROZEN KEEP AT -0.4 F" & Chr(34))
        '        A.WriteLine("A280,220,1,1,1,1,N," & Chr(34) & "CONGELADO MANTENGASE A -18 C" & Chr(34))
        '    End If

        '    A.writeline("X260,80,1,260,750")

        '    A.WriteLine("A250,110,1,2,1,1,N," & Chr(34) & iLEYENDA_FECHA_PRODUCCION_INGLES & Chr(34))
        '    A.WriteLine("A230,85,1,2,1,1,N," & Chr(34) & iLEYENDA_FECHA_PRODUCCION & Chr(34))
        '    A.WriteLine("A210,115,1,4,2,1,N," & Chr(34) & iFecha_de_Produccion & Chr(34))


        '    If aImprimeFechaCaducidad Then
        '        A.WriteLine("A250,530,1,2,1,1,N," & Chr(34) & iLEYENDA_FECHA_CADUCIDAD_INGLES & Chr(34))
        '        A.WriteLine("A230,500,1,2,1,1,N," & Chr(34) & iLEYENDA_FECHA_CADUCIDAD & Chr(34))
        '        A.WriteLine("A210,530,1,4,2,1,N," & Chr(34) & iFecha_de_Caducidad & Chr(34))
        '    End If
        '    'A.writeline("X352,190,3,220,350")
        '    'A.writeline("X352,590,3,220,80")

        '    A.WriteLine("A240,20,1,2,1,1,N," & Chr(34) & iNombreBascula & Chr(34))
        '    A.WriteLine("A180,20,1,2,1,1,N," & Chr(34) & i30meses & Chr(34))
        '    A.WriteLine("A120,20,1,2,1,1,N," & Chr(34) & iVaciada & Chr(34))

        '    'MARCA PARA LA ETIQUETA HECHA EN EL RASTRO
        '    A.WriteLine("A440,85,1,1,1,1,N," & Chr(34) & "---" & Chr(34))

        '    A.WriteLine("B160,85,1,1B,2,12,120,B," & Chr(34) & iCodigo_de_Barras_Externo & Chr(34))
        '    'A.WriteLine("B160,85,1,1,2,8,100,B," & Chr(34) & iCodBarConLote & Chr(34))
        '    'A.WriteLine("B160,85,1,1,2,8,100,B," & Chr(34) & iCodBarConLoteLbs & Chr(34))

        '    A.WriteLine("P1")
        '    A.WriteLine("FE")
        '    A.Close()

        'Catch ex As Exception
        '    Call modGeneral.ManejaExcepcion(ex)

        'End Try
    End Sub


    Public Function Reetiquetar_Etiqueta_Cortes(Optional ByVal aFecha As String = "", Optional ByVal aLote As String = "") As Boolean
        Try
            Dim lCodBar As String = ""
            Dim nLote As String
            Dim nFecha As String
            Dim nFechaCaducidad As String

            If aFecha <> "" Then
                nFecha = Format(CDate(aFecha), "dd/MM/yyyy")
                nFechaCaducidad = Format(DateAdd(DateInterval.Day, ioMovto.DIAS_CADUCIDAD, CDate(aFecha)), "dd/MM/yyyy")
            Else
                nFecha = ioMovto.FECHA_ESD
                nFechaCaducidad = ioMovto.FECHA_CADUCIDAD
            End If

            nLote = IIf(aLote <> "", aLote, ioMovto.COR_LOTE.ToString)


            FS = CreateObject("Scripting.FileSystemObject")
            A = FS.CreateTextFile(gArchivoEtiquetaCorte, True)

            A.WriteLine("FK " & Chr(34) & "*" & Chr(34))
            A.WriteLine("q800")
            A.WriteLine("Q800,24")
            A.WriteLine("S4")
            A.WriteLine("D8")
            A.WriteLine("ZB")
            A.WriteLine("TTh:m")
            A.WriteLine("TDy2.mn.dd")
            A.WriteLine("N")
            A.WriteLine("A680,760,2,1,1,1,N," & Chr(34) & ioInfEtiq.INSPECCIONADO_TIF & Chr(34))
            A.WriteLine("A750,60,2,1,1,1,N," & Chr(34) & goEmpresa.Nombre & Chr(34))
            A.WriteLine("A750,45,2,1,1,1,N," & Chr(34) & goEmpresa.Direccion & Chr(34))
            A.WriteLine("A750,30,2,1,1,1,N," & Chr(34) & goEmpresa.Colonia & ", " & goEmpresa.Municipio & ", " & goEmpresa.Estado & Chr(34))
            A.WriteLine("A750,15,2,1,1,1,N," & Chr(34) & goEmpresa.Telefono & Chr(34))

            'A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            'A.WriteLine("A720,85,1,4,1,1,N," & Chr(34) & ioMovto.FECHA_ESD & Chr(34))
            ''A.WriteLine("A690,85,1,4,1,1,N," & Chr(34) & ioMovto.HORA_ESD & Chr(34))

            A.WriteLine("A750,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.LOTE & " " & nLote & Chr(34))
            A.WriteLine("A690,550,1,4,1,1,N," & Chr(34) & ioInfEtiq.TIF & " " & goEmpresa.TIF & Chr(34))
            A.WriteLine("A620,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PRODUCTO & Chr(34))
            A.WriteLine("A620,520,1,1,1,1,N," & Chr(34) & ioInfEtiq.CONTENIDO_PRODUCTO & Chr(34))

            'A.WriteLine("A420,85,1,2,1,1,N," & Chr(34) & "DE:" & Chr(34))
            'A.WriteLine("A400,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_INTRODUCTOR & Chr(34))
            A.WriteLine("A750,85,1,2,1,1,N," & Chr(34) & "PARA:" & Chr(34))
            A.WriteLine("A730,85,1,3,2,2,N," & Chr(34) & ioMovto.MARCA_DESTINO_DET & Chr(34))

            If Len(ioMovto.NOMBRE_PRODCTE.Trim) <= 18 Then
                A.WriteLine("A600,85,1,5,1,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO & Space(18), 18) & Chr(34))
            Else
                A.WriteLine("A600,85,1,4,3,1,N," & Chr(34) & Left(ioMovto.NOMBRE_PRODUCTO, 40) & Chr(34))
            End If

            A.WriteLine("A520,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PIEZAS & "/PC(S)" & Chr(34))
            A.WriteLine("A500,120,1,5,1,1,N," & Chr(34) & ioMovto.PIEZAS & Chr(34))

            A.WriteLine("A430,85,1,1,1,1,N," & Chr(34) & ioInfEtiq.PESO_NETO & Chr(34))
            A.WriteLine("A410,100,1,5,1,1,N," & Chr(34) & Format(ioMovto.PESO, "#,##0.00") & "KG" & Chr(34))

            A.WriteLine("A430,400,1,1,1,1,N," & Chr(34) & "NET WEIGHT" & Chr(34))
            A.WriteLine("A410,415,1,5,1,1,N," & Chr(34) & Format(ioMovto.LBS, "#,##0.00") & ioInfEtiq.LBS & Chr(34))

            ''''''''''''''FECHA DE PRODUCCION'''''''''''''''''''''''''''''''''''''''''''''''
            A.WriteLine("A320,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_PRODUCCION & Chr(34))
            A.WriteLine("A300,85,1,3,2,2,N," & Chr(34) & nFecha & Chr(34))
            ''''''''''''''FECHA CADUCIDAD'''''''''''''''''''''''''''''''''''''''''''''''''''
            A.WriteLine("A320,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.FECHA_CADUCIDAD & Chr(34))
            A.WriteLine("A300,420,1,3,2,2,N," & Chr(34) & nFechaCaducidad & Chr(34))
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            A.WriteLine("A220,85,1,2,1,1,N," & Chr(34) & ioInfEtiq.VACIO & Chr(34))
            'A.WriteLine("A220,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            Dim iDias As Integer
            iDias = DateDiff(DateInterval.Day, Date.Now, Convert.ToDateTime(nFechaCaducidad))
            If iDias >= 300 Then
                A.WriteLine("A190,420,1,2,1,1,N," & Chr(34) & "Mantenerse a -18 C" & Chr(34))
            Else
                A.WriteLine("A190,420,1,2,1,1,N," & Chr(34) & ioInfEtiq.INDICACION_TEMPERATURA & Chr(34))
            End If

            If aFecha <> "" Or aLote <> 0 Then
                lCodBar = Right("0000" + ioMovto.ID_PRODCTE, 4) + _
                            Right("000" + ioMovto.PIEZAS.ToString, 3) + _
                            Right("000000" + CStr(CInt(ioMovto.PESO * 100)), 6) + _
                            Format(CDate(nFecha), "yyMMdd") + _
                            Right("000000" + nLote, 6) + _
                            ioMovto.CAJA_SERIE_ID
                A.WriteLine("B160,85,1,1,2,7,100,B," & Chr(34) & lCodBar & Chr(34))
            Else
                A.WriteLine("B160,85,1,1,2,7,100,B," & Chr(34) & ioMovto.CAJA_CODBAR.Trim & Chr(34))
            End If

            A.writeline("X530,80,1,530,750")
            A.writeline("X340,80,1,340,750")

            A.WriteLine("P1")
            A.WriteLine("FE")
            A.Close()

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try

    End Function

End Class
