Module modGeneral

    Public Sub Cargar_Informacion_Impresoras()
        'Dim ArchivoINI As String

        'Try
        '    ArchivoINI = "c:\windows\rfc.ini"
        '    gVersionWindows = modGeneral.LeerIni(ArchivoINI, "VERSION_WINDOWS", "WINDOWS")
        '    'gsRutaCrearEtiqueta = modGeneral.LeerIni(ArchivoINI, "VERSION_WINDOWS", "CMD_RUTA_CREAR_ETIQ")
        '    'gsInstruccionImprimirEtiqueta = modGeneral.LeerIni(ArchivoINI, "VERSION_WINDOWS", "CMD_INSTR_ETIQCOR")

        'Catch ex As Exception
        '    Call modGeneral.ManejaExcepcion(ex)
        'End Try
    End Sub

    Public Sub ImprimirUltimaEtiquetaSacrificio()
        Try

            Call modFuncProc.ImprimeEtiquetaRaw(gArchivoEtiquetaSac, gNombreEtiquetadora)
            
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Public Sub ImprimirUltimaEtiquetaCorte()
        Try

            Call modFuncProc.ImprimeEtiquetaRaw(gArchivoEtiquetaCorte, gNombreEtiquetadora)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Public Sub ManejaExcepcion(ByRef Ex As Exception, Optional ByRef Forma As System.Windows.Forms.Form = Nothing)

        Application.DoEvents()

        If Forma Is Nothing Then
            MessageBox.Show("Error: " & vbNewLine & Ex.Message.ToString, gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If InStr(Ex.Message.ToString, "requiere una conexión abierta") Then
                If Cnn.State = ConnectionState.Closed Then
                    Cnn.Open()
                End If
            End If
        Else
            MessageBox.Show("Error: " & vbNewLine & Ex.InnerException.ToString & "Origen: " & vbNewLine & Ex.Source.ToString & vbNewLine & vbNewLine & "Descripción: " & vbNewLine & Ex.Message.ToString, _
                            gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If InStr(Ex.Message.ToString, "requiere una conexión abierta") Then
                If Cnn.State = ConnectionState.Closed Then
                    Cnn.Open()
                End If
            End If
        End If
        If Cnn.State = ConnectionState.Closed Then
            Cnn.Open()
        End If

    End Sub

    ' Leer un valor de un archivo Ini
    Public Function LeerIni(ByRef lpFileName As String, ByRef lpAppName As String, ByRef lpKeyName As String, Optional ByRef vDefault As Object = Nothing) As String
        'lpFileName:    Nombre del fichero INI
        'lpAppName:     La sección que suele estar entre corchetes
        'lpKeyName:     Clave
        'vDefault:      Valor opcional que devolverá si no se encuentra la clave
        Dim lpString As String
        Dim Ltmp As Integer
        Dim sRetVal As String
        'Si no se especifica el valor por defecto asignar una cadena vacía
        If IsNothing(vDefault) Then
            lpString = ""
        Else
            lpString = vDefault
        End If
        sRetVal = New String(Chr(0), 255)
        Ltmp = GetPrivateProfileString(lpAppName, lpKeyName, lpString, sRetVal, Len(sRetVal), lpFileName)
        If Ltmp = 0 Then
            LeerIni = lpString
        Else
            LeerIni = Left(sRetVal, Ltmp)
        End If
    End Function

    ' Guarda un valor en un archivo Ini
    Public Sub GuardarIni(ByRef lpFileName As String, ByRef lpAppName As String, ByRef lpKeyName As String, ByRef lpString As String)
        Dim Ltmp As Integer
        Ltmp = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName)
    End Sub

 
End Module
