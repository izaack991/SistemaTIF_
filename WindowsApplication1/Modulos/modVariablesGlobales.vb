Module modVariablesGlobales
    Public gProyecto As String = "Sistema TIF"
    'Declaracion de Funciones Externas

    '***Archivos Ini
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public Cnn As SqlClient.SqlConnection
    ' Public ConnectionString As String = "Data Source=SERVERTIF651VM\COMPAC18;Initial Catalog=TIF651;user id=sa;password=abc123."
    Public ConnectionString As String = "Data Source=SISTEMAS\VENTAS;Initial Catalog=TIF651;user id=sa;password=abc123."
    Public Const FactorLibras As Double = 2.20466
    Public gTIF As String = ""
    Public gVersionWindows As String = ""
    Public gNombreEtiquetadora As String = ""

    Public gPuertoBascula As String = ""
    Public gPuertoBascula_Velocidad As String

    Public gCommSettings As String = ""
    Public gNombreBascula As String = ""

    Public goEmpresa As clsEmpresa
    Public goUsuario As Integer
    Public goPermisosValidaciones As clsPermisosValidaciones

    Public gRutaTrabajo As String = "c:\Sistema Rastro"
    Public gArchivoEtiquetaSac As String = gRutaTrabajo & "\etiqsac.txt"
    Public gArchivoEtiquetaCorte As String = gRutaTrabajo & "\etiqcor.txt"

End Module
