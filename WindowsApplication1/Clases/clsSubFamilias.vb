' ***********************************************************************
'  Module:  Subfamilias.vb
'  Author:  omar.valdez
'  Purpose: Definition of the Class Subfamilias
' ***********************************************************************
Option Strict Off

Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System

Public Class clsSubfamilias
    Dim iID_FAM As Integer
    Dim iNOMBRE_FAMILIA As String
    Dim iID_SFAM As Integer
    Dim iNOMBRE_SUBFAMILIA As String
    Dim iESTATUS As String

    Public Sub New(ByVal aID_FAM As Integer, ByVal aID_SFAM As Integer, Optional ByVal aEstatus As String = "%")
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_SUBFAMILIAS " & aID_FAM.ToString & ", " & aID_SFAM.ToString & ", '" & aEstatus & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                iID_FAM = dt.Rows(0)("ID_FAM")
                iNOMBRE_FAMILIA = dt.Rows(0)("NOM_FAM")
                iID_SFAM = dt.Rows(0)("ID_SFAM")
                iNOMBRE_SUBFAMILIA = dt.Rows(0)("NOMBRE")
                iESTATUS = dt.Rows(0)("ESTATUS")
            Else

                Call Me.InicializarValores()

            End If

            lCmd.Dispose()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Public Function Guardar(ByVal aOperacion As String, ByRef aMensajeResultado As String) As Boolean
        Try
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
            pID_FAM.Value = iID_FAM
            pID_SFAM.Value = iID_SFAM
            pDescripcion.Value = iNOMBRE_SUBFAMILIA

            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If pReturn.Value = 1 Then 'Se produjo un error controlado desde el stored procedure
                MsgBox(Trim(pErrorSP.Value), MsgBoxStyle.Exclamation, gProyecto)
                Return False
            End If

            Return True

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Sub InicializarValores()
        iID_FAM = 0
        iNOMBRE_FAMILIA = ""
        iID_SFAM = 0
        iNOMBRE_SUBFAMILIA = ""
        iESTATUS = ""
    End Sub

    Public Property ID_FAM() As String
        Get
            ID_FAM = iID_FAM
        End Get
        Set(ByVal value As String)
            iID_FAM = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_FAMILIA() As String
        Get
            NOMBRE_FAMILIA = iNOMBRE_FAMILIA
        End Get
    End Property

    Public Property ID_SFAM() As String
        Get
            ID_SFAM = iID_SFAM
        End Get
        Set(ByVal value As String)
            iID_SFAM = value
        End Set
    End Property

    Public Property NOMBRE_SUBFAMILIA() As String
        Get
            NOMBRE_SUBFAMILIA = iNOMBRE_SUBFAMILIA
        End Get
        Set(ByVal value As String)
            iNOMBRE_SUBFAMILIA = value
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