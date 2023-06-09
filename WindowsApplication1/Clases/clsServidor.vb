Imports System.Data.SqlClient

Public Class clsServidor
    Dim iNOMBRE As String
    Dim iFECHA As String
    Dim iHORA As String
    Dim iEquipoLocal As String

    Public Sub New()
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXEC SP_CONS_INFORMACION_SERVIDOR"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                iNOMBRE = dt.Rows(0)("NOMBRE_SERVIDOR")
                iFECHA = dt.Rows(0)("FECHA")
                iHORA = dt.Rows(0)("HORA")
                iEquipoLocal = System.Environment.MachineName.Trim.ToUpper
            Else
                Me.InicializaValores()
            End If

            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub InicializaValores()
        iNOMBRE = ""
        iFECHA = ""
        iHORA = ""
        iEquipoLocal = ""
    End Sub

    Public Property Nombre As String
        Get
            Nombre = iNOMBRE
        End Get
        Set(value As String)
            iNOMBRE = value
        End Set
    End Property

    Public Property FECHA As String
        Get
            FECHA = iFECHA
        End Get
        Set(value As String)
            iFECHA = value
        End Set
    End Property

    Public Property HORA As String
        Get
            HORA = iHORA
        End Get
        Set(value As String)
            iHORA = value
        End Set
    End Property

    Public Property Equipo_Local As String
        Get
            Equipo_Local = iEquipoLocal
        End Get
        Set(value As String)
            iEquipoLocal = value
        End Set
    End Property

End Class
