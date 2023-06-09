Imports System.Data.SqlClient

Public Class clsEmpresa
    Dim iOperacion As String
    Dim iID_EMPR As Integer
    Dim iNOMBRE As String
    Dim iDIRECCION As String
    Dim iCOLONIA As String
    Dim iMUNICIPIO As String
    Dim iESTADO As String
    Dim iCP As String
    Dim iEMAIL As String
    Dim iTELEFONO As String
    Dim iRFC As String
    Dim iTIF As String
    Dim iID_CTE As Integer
    Dim iMarca_Cte As String
    Dim iNombre_Cte As String
    Dim iESTATUS As String
    Dim iExiste As Boolean

    Public Sub New()
        Me.InicializaValores()
    End Sub

    Public Sub New(ByVal aID As Integer)
        Try
            If aID = 0 Then
                Me.InicializaValores()
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "SP_CONS_EMPRESA " & aID.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                iOperacion = ""
                iID_EMPR = dt.Rows(0)("ID_EMPR")
                iNOMBRE = dt.Rows(0)("NOMBRE")
                iDIRECCION = dt.Rows(0)("DIRECCION")
                iCOLONIA = dt.Rows(0)("COLONIA")
                iMUNICIPIO = dt.Rows(0)("MUNICIPIO")
                iESTADO = dt.Rows(0)("ESTADO")
                iCP = dt.Rows(0)("CP")
                iEMAIL = dt.Rows(0)("EMAIL")
                iTELEFONO = dt.Rows(0)("TELEFONO")
                iRFC = dt.Rows(0)("RFC")
                iTIF = dt.Rows(0)("TIF")
                iID_CTE = dt.Rows(0)("ID_CTE")
                iMarca_Cte = dt.Rows(0)("MARCA_CTE")
                iNombre_Cte = dt.Rows(0)("NOMBRE_CTE")
                iESTATUS = dt.Rows(0)("ESTATUS")
                iExiste = True
            Else
                Me.InicializaValores()
            End If

            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub InicializaValores()
        iOperacion = ""
        IID_EMPR = 0
        iNOMBRE = ""
        iDIRECCION = ""
        iCOLONIA = ""
        iMUNICIPIO = ""
        iESTADO = ""
        iCP = ""
        iEMAIL = ""
        iTELEFONO = ""
        iRFC = ""
        iTIF = ""
        iID_CTE = 0
        iMarca_Cte = ""
        iNombre_Cte = ""
        iESTATUS = ""
        iExiste = False
    End Sub

    Public Function Guardar(ByRef aMensajeResultado As String, Optional ByRef aFolio As Integer = 0) As Boolean

        Dim lCmd As New SqlClient.SqlCommand
        Dim lp0 As New SqlClient.SqlParameter
        Dim lp1 As New SqlClient.SqlParameter
        Dim lp2 As New SqlClient.SqlParameter
        Dim lp3 As New SqlClient.SqlParameter
        Dim lp4 As New SqlClient.SqlParameter
        Dim lp5 As New SqlClient.SqlParameter
        Dim lp6 As New SqlClient.SqlParameter
        Dim lp7 As New SqlClient.SqlParameter
        Dim lp8 As New SqlClient.SqlParameter
        Dim lp9 As New SqlClient.SqlParameter
        Dim lp10 As New SqlClient.SqlParameter
        Dim lp11 As New SqlClient.SqlParameter
        Dim lp12 As New SqlClient.SqlParameter
        Dim lp13 As New SqlClient.SqlParameter
        Dim lpErrorSP As New SqlClient.SqlParameter

        Try

            Guardar = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_EMPRESAS"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_CLIENTES
            '@OPERACION  CHAR(1),
            '@ID_CTE	INTEGER = 0,
            '@MARCA	    VARCHAR(6) = '',
            '@NOMBRE 	VARCHAR(60) = '',
            '@DIRECCION VARCHAR(40) = '',
            '@COLONIA 	VARCHAR(30) = '',
            '@MUNICIPIO VARCHAR(30) = '',
            '@ESTADO 	VARCHAR(20) = '',
            '@EMAIL	 	VARCHAR(30) = '',
            '@TELEFONO 	VARCHAR(12) = '',
            '@CELULAR 	VARCHAR(12) = '',
            '@CP		VARCHAR(5)	= '',
            '@RFC	 	VARCHAR(13) = '',
            '@ID_TCTE 	INTEGER		= 0,	
            '@ERRORSP   VARCHAR(300) OUTPUT 

            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_EMPR", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("NOMBRE", SqlDbType.VarChar, 60)
            lp4 = lCmd.Parameters.Add("DIRECCION", SqlDbType.VarChar, 40)
            lp5 = lCmd.Parameters.Add("COLONIA", SqlDbType.VarChar, 30)
            lp6 = lCmd.Parameters.Add("MUNICIPIO", SqlDbType.VarChar, 30)
            lp7 = lCmd.Parameters.Add("ESTADO", SqlDbType.VarChar, 20)
            lp8 = lCmd.Parameters.Add("CP", SqlDbType.VarChar, 5)
            lp9 = lCmd.Parameters.Add("EMAIL", SqlDbType.VarChar, 40)
            lp10 = lCmd.Parameters.Add("TELEFONO", SqlDbType.VarChar, 12)
            lp11 = lCmd.Parameters.Add("RFC", SqlDbType.VarChar, 13)
            lp12 = lCmd.Parameters.Add("TIF", SqlDbType.VarChar, 5)
            lp13 = lCmd.Parameters.Add("ESTATUS", SqlDbType.Char, 1)

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output

            lp1.Value = iOperacion
            lp2.Value = iID_EMPR
            lp3.Value = iNOMBRE
            lp4.Value = iDIRECCION
            lp5.Value = iCOLONIA
            lp6.Value = iMUNICIPIO
            lp7.Value = iESTADO
            lp8.Value = iCP
            lp9.Value = iEMAIL
            lp10.Value = iTELEFONO
            lp11.Value = iRFC
            lp12.Value = iTIF
            lp13.Value = iESTATUS

            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                aMensajeResultado = Trim(lpErrorSP.Value)
                Guardar = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
                aFolio = lp0.Value
                Guardar = True
            End If

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public WriteOnly Property Operacion As String
        Set(value As String)
            iOperacion = value
        End Set
    End Property

    Public ReadOnly Property Existe As Boolean
        Get
            Existe = iExiste
        End Get
    End Property
    Public Property ID_EMPR As Integer
        Get
            ID_EMPR = iID_EMPR
        End Get
        Set(value As Integer)
            iID_EMPR = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Nombre = iNOMBRE
        End Get
        Set(value As String)
            iNOMBRE = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Direccion = iDIRECCION
        End Get
        Set(value As String)
            iDIRECCION = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Colonia = iCOLONIA
        End Get
        Set(value As String)
            iCOLONIA = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Municipio = iMUNICIPIO
        End Get
        Set(value As String)
            iMUNICIPIO = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Estado = iESTADO
        End Get
        Set(value As String)
            iESTADO = value
        End Set
    End Property

    Public Property CP As String
        Get
            CP = iCP
        End Get
        Set(value As String)
            iCP = value
        End Set
    End Property

    Public Property Email As String
        Get
            Email = iEMAIL
        End Get
        Set(value As String)
            iEMAIL = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Telefono = iTELEFONO
        End Get
        Set(value As String)
            iTELEFONO = value
        End Set
    End Property

    Public Property RFC As String
        Get
            RFC = iRFC
        End Get
        Set(value As String)
            iRFC = value
        End Set
    End Property

    Public Property TIF As String
        Get
            TIF = iTIF
        End Get
        Set(value As String)
            iTIF = value
        End Set
    End Property

    Public Property ID_CTE As String
        Get
            ID_CTE = iID_CTE
        End Get
        Set(value As String)
            iID_CTE = value
        End Set
    End Property

    Public Property MARCA_CTE As String
        Get
            MARCA_CTE = iMarca_Cte
        End Get
        Set(value As String)
            iMarca_Cte = value
        End Set
    End Property

    Public Property NOMBRE_CTE As String
        Get
            NOMBRE_CTE = iNombre_Cte
        End Get
        Set(value As String)
            iNombre_Cte = value
        End Set
    End Property

End Class
