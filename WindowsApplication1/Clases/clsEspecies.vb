Imports System.Data.SqlClient

Public Class clsEspecies
    Dim iID_ESPECIE As Integer
    Dim iNOMBRE As String
    Dim iESTATUS As String

    Public Sub New()
        Me.InicializarValores()
    End Sub
    Public Sub New(ByVal aID_ESPECIE As Integer, Optional ByVal aEstatus As String = "%")
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_ESPECIES " & aID_ESPECIE.ToString & ", '" & aEstatus & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                iID_ESPECIE = dt.Rows(0)("ID")
                iNOMBRE = dt.Rows(0)("NOMBRE")
                iESTATUS = dt.Rows(0)("ESTATUS")
            Else

                Me.InicializarValores()

            End If

            lCmd.Dispose()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    'Public Function Guardar(ByVal aOperacion As String, ByRef aMensajeResultado As String) As Boolean
    '    Try
    '    Catch ex As Exception
    '        modGeneral.ManejaExcepcion(ex)
    '        Return False
    '    End Try
    'End Function

    Public Sub InicializarValores()
        iID_ESPECIE = 0
        iNOMBRE = ""
        iESTATUS = ""
    End Sub

    Public Property ID_ESPECIE() As String
        Get
            ID_ESPECIE = iID_ESPECIE
        End Get
        Set(ByVal value As String)
            iID_ESPECIE = value
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            NOMBRE = iNOMBRE
        End Get
        Set(value As String)
            iNOMBRE = value
        End Set
    End Property

    Public Property ESTATUS() As String
        Get
            ESTATUS = iESTATUS
        End Get
        Set(ByVal value As String)
            iESTATUS = value
        End Set
    End Property

End Class
