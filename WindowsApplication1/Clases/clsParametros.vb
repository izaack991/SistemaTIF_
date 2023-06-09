Imports System.Data.SqlClient

Public Class clsParametros
    Dim iID_PAR As String
    Dim iNOMBRE As String
    Dim iENT1 As Integer
    Dim iENT2 As Integer
    Dim iCAD1 As String
    Dim iCAD2 As String
    Dim iDEC1 As Decimal
    Dim iDEC2 As Decimal
    Dim sPASSCANALES As String
    Dim sPASSCAJAS As String
    Dim sPASSSALA As String
    Dim sPASSVISCERAS As String
    Public Sub New(ByVal aID As Integer)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_PARAMETROS " & aID.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                iID_PAR = dt.Rows(0)("ID_PAR")
                iNOMBRE = dt.Rows(0)("NOMBRE")
                iENT1 = dt.Rows(0)("ENT1")
                iENT2 = dt.Rows(0)("ENT2")
                iCAD1 = dt.Rows(0)("CAD1")
                iCAD2 = dt.Rows(0)("CAD2")
                iDEC1 = dt.Rows(0)("DEC1")
                iDEC2 = dt.Rows(0)("DEC2")
                sPASSCANALES = dt.Rows(0)("PASSCANALES")
                sPASSCAJAS = dt.Rows(0)("PASSCAJAS")
                sPASSSALA = dt.Rows(0)("PASSSALA")
                sPASSVISCERAS = dt.Rows(0)("PASSVISCERAS")
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
            Dim lOperacion As String = aOperacion

            Dim lCmd As New SqlClient.SqlCommand
            Dim lpReturn As New SqlClient.SqlParameter
            Dim lpErrorSP As New SqlClient.SqlParameter
            Dim lp1 As New SqlClient.SqlParameter
            Dim lp2 As New SqlClient.SqlParameter
            Dim lp3 As New SqlClient.SqlParameter
            Dim lp4 As New SqlClient.SqlParameter
            Dim lp5 As New SqlClient.SqlParameter
            Dim lp6 As New SqlClient.SqlParameter
            Dim lp7 As New SqlClient.SqlParameter
            Dim lp8 As New SqlClient.SqlParameter
            Dim lp9 As New SqlClient.SqlParameter

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_PARAMETROS"
            lCmd.CommandType = CommandType.StoredProcedure

            lpReturn = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lpReturn.Direction = ParameterDirection.ReturnValue

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 800)
            lpErrorSP.Direction = ParameterDirection.Output

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_PAR", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("NOMBRE", SqlDbType.VarChar, 60)
            lp4 = lCmd.Parameters.Add("ENT1", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ENT2", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("CAD1", SqlDbType.VarChar, 60)
            lp7 = lCmd.Parameters.Add("CAD2", SqlDbType.VarChar, 60)
            lp8 = lCmd.Parameters.Add("DEC1", SqlDbType.Decimal)
            lp9 = lCmd.Parameters.Add("DEC2", SqlDbType.Decimal)

            lp1.Value = lOperacion
            lp2.Value = iID_PAR
            lp3.Value = iNOMBRE
            lp4.Value = iENT1
            lp5.Value = iENT2
            lp6.Value = iCAD1
            lp7.Value = iCAD2
            lp8.Value = iDEC1
            lp9.Value = iDEC2

            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lpReturn.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                aMensajeResultado = Trim(lpErrorSP.Value)
                Guardar = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
                iID_PAR = lpErrorSP.Value
                Guardar = True
            End If

            lCmd = Nothing

            Return True

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Sub InicializarValores()
        iID_PAR = 0
        iNombre = ""
        iENT1 = 0
        iENT2 = 0
        iCAD1 = ""
        iCAD2 = ""
        iDEC1 = 0
        iDEC2 = 0
        sPASSCANALES = ""
        sPASSCAJAS = ""
        sPASSSALA = ""

    End Sub

    Public Property ID_PAR() As String
        Get
            ID_PAR = iID_PAR
        End Get
        Set(ByVal value As String)
            iID_PAR = value
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            NOMBRE = iNombre
        End Get
        Set(ByVal value As String)
            iNombre = value
        End Set
    End Property

    Public Property ENT1() As Integer
        Get
            ENT1 = iENT1
        End Get
        Set(ByVal value As Integer)
            iENT1 = value
        End Set
    End Property

    Public Property ENT2() As Integer
        Get
            ENT2 = iENT2
        End Get
        Set(ByVal value As Integer)
            iENT2 = value
        End Set
    End Property

    Public Property CAD1() As String
        Get
            CAD1 = iCAD1
        End Get
        Set(ByVal value As String)
            iCAD1 = value
        End Set
    End Property

    Public Property CAD2() As String
        Get
            CAD2 = iCAD2
        End Get
        Set(ByVal value As String)
            iCAD2 = value
        End Set
    End Property

    Public Property DEC1() As Decimal
        Get
            DEC1 = iDEC1
        End Get
        Set(ByVal value As Decimal)
            iDEC1 = value
        End Set
    End Property

    Public Property DEC2() As Decimal
        Get
            DEC2 = iDEC2
        End Get
        Set(ByVal value As Decimal)
            iDEC2 = value
        End Set
    End Property
    Public Property PASSCANALES() As String
        Get
            PASSCANALES = sPASSCANALES
        End Get
        Set(ByVal value As String)
            sPASSCANALES = value
        End Set
    End Property
    Public Property PASSCAJAS() As String
        Get
            PASSCAJAS = sPASSCAJAS
        End Get
        Set(ByVal value As String)
            sPASSCAJAS = value
        End Set
    End Property
    Public Property PASSSALA() As String
        Get
            PASSSALA = sPASSSALA
        End Get
        Set(ByVal value As String)
            sPASSSALA = value
        End Set
    End Property
    Public Property PASSVISCERAS() As String
        Get
            PASSVISCERAS = sPASSVISCERAS
        End Get
        Set(ByVal value As String)
            sPASSVISCERAS = value
        End Set
    End Property
End Class
