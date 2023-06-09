Module modConexion
    Public Function Conectar(Optional ByVal aOpcion As Integer = 1) As Boolean
        Dim Servidor As String
        Dim BD As String
        Dim Usuario As String
        Dim PWD As String
        Dim ArchivoINI As String

        Try

            Cnn = New SqlClient.SqlConnection
            ArchivoINI = "c:\windows\tif.ini"
            Servidor = modGeneral.LeerIni(ArchivoINI, "CONEXION", "SERVIDOR")
            BD = modGeneral.LeerIni(ArchivoINI, "CONEXION", "BD")
            Usuario = modGeneral.LeerIni(ArchivoINI, "CONEXION", "USUARIO")
            PWD = modGeneral.LeerIni(ArchivoINI, "CONEXION", "PWD")
            'gCaracterBascula = modGeneral.LeerIni(ArchivoINI, "BASCULA", "CARACTER_DE_ENVIO")
            'gCaracterBasculaEntrada = modGeneral.LeerIni(ArchivoINI, "BASCULA", "CARACTER_DE_ENVIO2")
            gNombreBascula = modGeneral.LeerIni(ArchivoINI, "BASCULA", "NOMBRE_BASCULA")
            gPuertoBascula = modGeneral.LeerIni(ArchivoINI, "BASCULA", "PUERTO")
            gPuertoBascula_Velocidad = modGeneral.LeerIni(ArchivoINI, "BASCULA", "VELOCIDAD")
            gCommSettings = modGeneral.LeerIni(ArchivoINI, "BASCULA", "COMM_SETTINGS")

            goUsuario = 0   'usuario delC:\Users\usermoto\Desktop\sistemas\Sistema\SistemaTIF\WindowsApplication1\Modulos\modConexion.vb sistema

            If aOpcion = 2 Then
                ' ''para conexion sql SERVIDOR
                'Servidor = "SRVAPPTIF"
                'BD = "BDTIF_Resp"
                'Usuario = "SA"
                'PWD = "TifGve01"
                'gProyecto = "RESPALDO - RESPALDO - SISTEMA DE CONTROL DE PRODUCCION - RESPALDO - RESPALDO"
            Else

                ' '''' para conexion sql SERVIDOR
                'Servidor = "SERVERTIF651VM\COMPAC18"
                'BD = "TIF651"
                'Usuario = "SA"
                'PWD = "abc123."
                'gProyecto = gProyecto & "SISTEMA DE CONTROL DE PRODUCCION"
                'gProyecto = "SISTEMA DE CONTROL DE PRODUCCION"

                ''''para conexion sql local
                Servidor = "SISTEMAS\VENTAS"
                BD = "TIF651"
                Usuario = "SA"
                PWD = "abc123."
                gProyecto = gProyecto & " ----> PRUEBAS " & " --BD-- " & BD

            End If

            'mdiPrincipal.Text = gProyecto

            ConnectionString = "Data Source=" & Servidor & ";DATABASE=" & BD & ";User ID=" & Usuario & ";password=" & PWD & "; "
            'Integrated Security = False

            Cnn.ConnectionString = ConnectionString

            If Cnn.State = ConnectionState.Closed Or Cnn.State = ConnectionState.Broken Then
                Cnn.Open()
            Else
                Cnn.Close()
            End If

            Call Cargar_Informacion_Impresoras()

            goEmpresa = New clsEmpresa(1)

            If Not goEmpresa.Existe Then
                MessageBox.Show("No se encontro la información de la empresa.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            gTIF = goEmpresa.TIF

            Dim oDirectorioTrabajo As New clsDirectorioTrabajo
            oDirectorioTrabajo.Crear_Directorio()

            goPermisosValidaciones = New clsPermisosValidaciones

            Return True

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function


End Module
