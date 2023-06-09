Imports System.Data.SqlClient

Public Class clsCliente
    Dim iOperacion As String
    Dim iID_CTE As Integer
    Dim iNOMBRE As String
    Dim iID_TCTE As Integer
    Dim iNOM_TCTE As String
    Dim iMARCA As String
    Dim iDIRECCION As String
    Dim iCOLONIA As String
    Dim iMUNICIPIO As String
    Dim iESTADO As String
    Dim iEMAIL As String
    Dim iTELEFONO As String
    Dim iCELULAR As String
    Dim iCP As String
    Dim iRFC As String
    Dim iID_ALM_GAN As Integer
    Dim iID_ALM_CAN As Integer
    Dim iID_ALM_PIEL As Integer
    Dim iID_ALM_VIS As Integer
    Dim iID_ALM_CAJ As Integer
    Dim iPREFIJO As String
    Dim iESTATUS As String
    Dim iExiste As Boolean

    Public Sub New()
        Me.InicializaValores()
    End Sub

    Public Sub New(ByVal aID As Integer, Optional ByVal aMarca As String = "")
        Try
            If aID = 0 And aMarca = "" Then
                Me.InicializaValores()
                Exit Sub
            End If

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            'Dim lDR As SqlDataReader = Nothing
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_CLIENTES " & aID.ToString & ", '" & aMarca.Trim & "', '%', '%'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                iID_CTE = dt.Rows(0)("ID_CTE")
                iNOMBRE = dt.Rows(0)("NOMBRE")
                iID_TCTE = dt.Rows(0)("ID_TCTE")
                iNOM_TCTE = dt.Rows(0)("NOM_TCTE")
                iMARCA = dt.Rows(0)("MARCA")
                iDIRECCION = dt.Rows(0)("DIRECCION")
                iCOLONIA = dt.Rows(0)("COLONIA")
                iMUNICIPIO = dt.Rows(0)("MUNICIPIO")
                iESTADO = dt.Rows(0)("ESTADO")
                iEMAIL = dt.Rows(0)("EMAIL")
                iTELEFONO = dt.Rows(0)("TELEFONO")
                iCELULAR = dt.Rows(0)("CELULAR")
                iCP = dt.Rows(0)("CP")
                iRFC = dt.Rows(0)("RFC")
                iID_ALM_GAN = dt.Rows(0)("ID_ALM_GAN")
                iID_ALM_CAN = dt.Rows(0)("ID_ALM_CAN")
                iID_ALM_PIEL = dt.Rows(0)("ID_ALM_PIEL")
                iID_ALM_VIS = dt.Rows(0)("ID_ALM_VIS")
                iID_ALM_CAJ = dt.Rows(0)("ID_ALM_CAJ")
                iESTATUS = dt.Rows(0)("ESTATUS")
                iPREFIJO = dt.Rows(0)("PREFIJO")
                iExiste = True
            Else
                Me.InicializaValores()
            End If

            lCmd.Dispose()
            'lDR.Close()


        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub InicializaValores()
        iOperacion = ""
        iID_CTE = 0
        iNOMBRE = ""
        iID_TCTE = 0
        iNOM_TCTE = ""
        iMARCA = ""
        iDIRECCION = ""
        iCOLONIA = ""
        iMUNICIPIO = ""
        iESTADO = ""
        iEMAIL = ""
        iTELEFONO = ""
        iCELULAR = ""
        iCP = ""
        iRFC = ""
        iID_ALM_GAN = 0
        iID_ALM_CAN = 0
        iID_ALM_PIEL = 0
        iID_ALM_VIS = 0
        iID_ALM_CAJ = 0
        iESTATUS = ""
        iPREFIJO = ""
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
        Dim lp14 As New SqlClient.SqlParameter
        Dim lp15 As New SqlClient.SqlParameter
        Dim lpErrorSP As New SqlClient.SqlParameter

        Try

            Guardar = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_CLIENTES"
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
            lp2 = lCmd.Parameters.Add("ID_CTE", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("MARCA", SqlDbType.VarChar, 6)
            lp4 = lCmd.Parameters.Add("NOMBRE", SqlDbType.VarChar, 60)
            lp5 = lCmd.Parameters.Add("DIRECCION", SqlDbType.VarChar, 40)
            lp6 = lCmd.Parameters.Add("COLONIA", SqlDbType.VarChar, 30)
            lp7 = lCmd.Parameters.Add("MUNICIPIO", SqlDbType.VarChar, 30)
            lp8 = lCmd.Parameters.Add("ESTADO", SqlDbType.VarChar, 20)
            lp9 = lCmd.Parameters.Add("EMAIL", SqlDbType.VarChar, 30)
            lp10 = lCmd.Parameters.Add("TELEFONO", SqlDbType.VarChar, 12)
            lp12 = lCmd.Parameters.Add("CELULAR", SqlDbType.VarChar, 12)
            lp13 = lCmd.Parameters.Add("CP", SqlDbType.VarChar, 5)
            lp14 = lCmd.Parameters.Add("RFC", SqlDbType.VarChar, 13)
            lp15 = lCmd.Parameters.Add("ID_TCTE", SqlDbType.Int)

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output


            lp1.Value = iOperacion
            lp2.Value = iID_CTE
            lp3.Value = iMARCA
            lp4.Value = iNOMBRE
            lp5.Value = iDIRECCION
            lp6.Value = iCOLONIA
            lp7.Value = iMUNICIPIO
            lp8.Value = iESTADO
            lp9.Value = iEMAIL
            lp10.Value = iTELEFONO
            lp12.Value = iCELULAR
            lp13.Value = iCP
            lp14.Value = iRFC
            lp15.Value = iID_TCTE

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

    Public Function CatalogoClientes() As DataTable
        Dim lSql As String
        Dim daConsultaCatCte As SqlClient.SqlDataAdapter
        Dim lDatatable As New DataTable
        Try

            lSql = "EXECUTE SP_CONS_CLIENTES 0, '', '%', '%'"

            daConsultaCatCte = New SqlClient.SqlDataAdapter(lSql, Cnn)
            daConsultaCatCte.Fill(lDatatable)
            daConsultaCatCte.Dispose()

            Return lDatatable

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return lDatatable
        End Try
    End Function

    Public Function Almacenes() As DataTable
        Dim lSql As String
        Dim daConsultaCatCte As SqlClient.SqlDataAdapter
        Dim lDatatable As New DataTable
        Try

            lSql = "EXECUTE SP_CONS_ALMACENES 0, " & iID_CTE.ToString

            daConsultaCatCte = New SqlClient.SqlDataAdapter(lSql, Cnn)
            daConsultaCatCte.Fill(lDatatable)
            daConsultaCatCte.Dispose()

            Return lDatatable

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return lDatatable
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

    Public Property ID_CLIENTE As Integer
        Get
            ID_CLIENTE = iID_CTE
        End Get
        Set(value As Integer)
            iID_CTE = value
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

    Public Property ID_Tipo_Cliente As Integer
        Get
            ID_Tipo_Cliente = iID_TCTE
        End Get
        Set(value As Integer)
            iID_TCTE = value
        End Set
    End Property

    Public ReadOnly Property Nom_Tipo_Cliente As String
        Get
            Nom_Tipo_Cliente = iNOM_TCTE
        End Get
    End Property

    Public Property Marca As String
        Get
            Marca = iMARCA
        End Get
        Set(value As String)
            iMARCA = value
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

    Public Property Celular As String
        Get
            Celular = iCELULAR
        End Get
        Set(value As String)
            iCELULAR = value
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

    Public Property RFC As String
        Get
            RFC = iRFC
        End Get
        Set(value As String)
            iRFC = value
        End Set
    End Property

    Public ReadOnly Property ID_ALM_GAN As Integer
        Get
            ID_ALM_GAN = iID_ALM_GAN
        End Get
    End Property

    Public ReadOnly Property ID_ALM_CAN As Integer
        Get
            ID_ALM_CAN = iID_ALM_CAN
        End Get
    End Property

    Public ReadOnly Property ID_ALM_PIEL As Integer
        Get
            ID_ALM_PIEL = iID_ALM_PIEL
        End Get
    End Property

    Public ReadOnly Property ID_ALM_VIS As Integer
        Get
            ID_ALM_VIS = iID_ALM_VIS
        End Get
    End Property

    Public ReadOnly Property ID_ALM_CAJ As Integer
        Get
            ID_ALM_CAJ = iID_ALM_CAJ
        End Get
    End Property

    Public Property Estatus As String
        Get
            Estatus = iESTATUS
        End Get
        Set(value As String)
            iESTATUS = value
        End Set
    End Property

    Public ReadOnly Property PREFIJO As String
        Get
            PREFIJO = iPREFIJO
        End Get
    End Property
End Class
