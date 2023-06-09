Imports System.Data.SqlClient

Public Class clsCortes
    Dim iOPERACION As String
    Dim iID_CORTE As Integer
    Dim iID_ESPECIE As Integer
    Dim iNOM_ESPECIE As String
    Dim iID_CTE_INTR As Integer
    Dim iMARCA_CTE_INTR As String
    Dim iNOM_CTE_INTR As String
    Dim iID_CTE_DEST As Integer
    Dim iMARCA_CTE_DEST As String
    Dim iNOM_CTE_DEST As String
    Dim iCOR_LOTE As Integer
    Dim iFECHA As String
    Dim iSHIPPINGMARK As String
    Dim iINDICACIONES As String
    Dim iOBSERVACIONES As String
    Dim iID_ESC As Integer
    Dim iUSUARIO As String
    Dim iESTATUS As String
    Dim bEstatus_Corte As Boolean


    Public Sub New()
        Me.InicializarValores()
    End Sub
    Public Sub New(ByVal aID_CORTE As Integer, Optional ByVal aLoteCorte As Integer = 0, Optional ByVal aFechaCorte As String = "", Optional ByVal aID_ESPECIE As Integer = 0, Optional ByVal aID_CTE_INTR As Integer = 0, _
                   Optional ByVal aID_CTE_DEST As Integer = 0, Optional ByVal aFECHA_INI As String = "", Optional ByVal aFECHA_FIN As String = "", _
                   Optional ByVal aEstatus As String = "%", Optional ByVal aID_MOV As Integer = 0)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            'PROCEDURE SP_CONS_CORTES
            '@ID_CORTE		INT			= 0,
            '@COR_LOTE		INT			= 0,
            '@FECHA			VARCHAR(10)	= '',
            '@ID_ESPECIE	INT			= 0,
            '@ID_CTE_INTR	VARCHAR(6)	= '%',
            '@ID_CTE_DEST	VARCHAR(6)	= '%',
            '@FECHA_INI		VARCHAR(10) = '',
            '@FECHA_FIN		VARCHAR(10) = '',
            '@ESTATUS		CHAR(1)		= 'A'

            lSql = "EXECUTE SP_CONS_CORTES " & aID_CORTE.ToString & ", " & aLoteCorte.ToString & ", '" & aFechaCorte & "', " & aID_ESPECIE.ToString & ", " & aID_CTE_INTR.ToString & _
                            ", " & aID_CTE_DEST.ToString & ", '" & aFECHA_INI & "', '" & aFECHA_FIN & "', '" & aEstatus & "'" & "," & aID_MOV.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                iID_CORTE = dt.Rows(0)("ID_CORTE")
                iID_ESPECIE = dt.Rows(0)("ID_ESPECIE")
                iNOM_ESPECIE = dt.Rows(0)("NOM_ESPECIE")
                iID_CTE_INTR = dt.Rows(0)("ID_CTE_INTR")
                iMARCA_CTE_INTR = dt.Rows(0)("MARCA_CTE_INTR")
                iNOM_CTE_INTR = dt.Rows(0)("NOM_CTE_INTR")
                iID_CTE_DEST = dt.Rows(0)("ID_CTE_DEST")
                iMARCA_CTE_DEST = dt.Rows(0)("MARCA_CTE_DEST")
                iNOM_CTE_DEST = dt.Rows(0)("NOM_CTE_DEST")
                iCOR_LOTE = dt.Rows(0)("COR_LOTE")
                iFECHA = dt.Rows(0)("FECHA")
                iSHIPPINGMARK = dt.Rows(0)("SHIPPINGMARK")
                iINDICACIONES = dt.Rows(0)("INDICACIONES")
                iOBSERVACIONES = dt.Rows(0)("OBSERVACIONES")
                iESTATUS = dt.Rows(0)("ESTATUS")
                iID_ESC = dt.Rows(0)("ID_ESC")
                bEstatus_Corte = dt.Rows(0)("ESTADO_CORTE")
            Else

                Me.InicializarValores()

            End If

            lCmd.Dispose()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try

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
        Dim lpErrorSP As New SqlClient.SqlParameter

        Try

            Guardar = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_CORTES"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_CORTES
            '@OPERACION		CHAR(1),  
            '@ID_CORTE		INTEGER,  
            '@ID_ESPECIE	INTEGER,
            '@ID_CTE_INTR	INTEGER,
            '@ID_CTE_DEST	INTEGER,
            '@COR_LOTE		INTEGER,
            '@FECHA			VARCHAR(10),
            '@SHIPPINGMARK VARCHAR(10),
            '@INDICACIONES VARCHAR(30),
            '@OBSERVACIONES	VARCHAR(200),
            '@ERRORSP	VARCHAR(300) OUTPUT  


            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_CORTE", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("ID_ESPECIE", SqlDbType.Int)
            lp4 = lCmd.Parameters.Add("ID_CTE_INTR", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ID_CTE_DEST", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("COR_LOTE", SqlDbType.Int)
            lp7 = lCmd.Parameters.Add("FECHA", SqlDbType.VarChar, 10)
            lp8 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.VarChar, 200)
            lp9 = lCmd.Parameters.Add("SHIPPINGMARK", SqlDbType.VarChar, 10)
            lp10 = lCmd.Parameters.Add("INDICACIONES", SqlDbType.VarChar, 30)

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output

            lp1.Value = iOperacion
            lp2.Value = ID_CORTE
            lp3.Value = ID_ESPECIE
            lp4.Value = ID_CTE_INTR
            lp5.Value = ID_CTE_DEST
            lp6.Value = COR_LOTE
            lp7.Value = FECHA
            lp8.Value = OBSERVACIONES
            lp9.Value = iSHIPPINGMARK
            lp10.Value = iINDICACIONES

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

    Public Sub InicializarValores()
        iID_CORTE = 0
        iID_ESPECIE = 0
        iNOM_ESPECIE = ""
        iID_CTE_INTR = 0
        iMARCA_CTE_INTR = ""
        iNOM_CTE_INTR = ""
        iID_CTE_DEST = 0
        iMARCA_CTE_DEST = ""
        iNOM_CTE_DEST = ""
        iCOR_LOTE = 0
        iFECHA = ""
        iSHIPPINGMARK = ""
        iINDICACIONES = ""
        iOBSERVACIONES = ""
        iID_ESC = 0
        bEstatus_Corte = False
    End Sub

    Public Property OPERACION As String
        Get
            OPERACION = iOPERACION
        End Get
        Set(value As String)
            iOPERACION = value
        End Set
    End Property

    Public Property ID_CORTE() As Integer
        Get
            ID_CORTE = iID_CORTE
        End Get
        Set(ByVal value As Integer)
            iID_CORTE = value
        End Set
    End Property

    Public Property ID_ESPECIE() As Integer
        Get
            ID_ESPECIE = iID_ESPECIE
        End Get
        Set(ByVal value As Integer)
            iID_ESPECIE = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_ESPECIE() As String
        Get
            NOMBRE_ESPECIE = iNOM_ESPECIE
        End Get
    End Property

    Public Property ID_CTE_INTR() As Integer
        Get
            ID_CTE_INTR = iID_CTE_INTR
        End Get
        Set(ByVal value As Integer)
            iID_CTE_INTR = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_CTE_INTR() As String
        Get
            NOMBRE_CTE_INTR = iNOM_CTE_INTR
        End Get
    End Property

    Public ReadOnly Property MARCA_CTE_INTR() As String
        Get
            MARCA_CTE_INTR = iMARCA_CTE_INTR
        End Get
    End Property

    Public Property ID_CTE_DEST() As Integer
        Get
            ID_CTE_DEST = iID_CTE_DEST
        End Get
        Set(ByVal value As Integer)
            iID_CTE_DEST = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_CTE_DEST() As String
        Get
            NOMBRE_CTE_DEST = iNOM_CTE_DEST
        End Get
    End Property

    Public ReadOnly Property MARCA_DEST() As String
        Get
            MARCA_DEST = iMARCA_CTE_DEST
        End Get
    End Property

    Public Property COR_LOTE() As Integer
        Get
            COR_LOTE = iCOR_LOTE
        End Get
        Set(ByVal value As Integer)
            iCOR_LOTE = value
        End Set
    End Property

    Public Property FECHA() As String
        Get
            FECHA = iFECHA
        End Get
        Set(ByVal value As String)
            iFECHA = value
        End Set
    End Property

    Public Property SHIPPINGMARK() As String
        Get
            SHIPPINGMARK = iSHIPPINGMARK
        End Get
        Set(ByVal value As String)
            iSHIPPINGMARK = value
        End Set
    End Property

    Public Property INDICACIONES() As String
        Get
            INDICACIONES = iINDICACIONES
        End Get
        Set(ByVal value As String)
            iINDICACIONES = value
        End Set
    End Property

    Public Property OBSERVACIONES() As String
        Get
            OBSERVACIONES = iOBSERVACIONES
        End Get
        Set(ByVal value As String)
            iOBSERVACIONES = value
        End Set
    End Property

    Public ReadOnly Property ID_ESC() As Integer
        Get
            ID_ESC = iID_ESC
        End Get
    End Property

    Public Property USUARIO() As Integer
        Get
            USUARIO = iUSUARIO
        End Get
        Set(ByVal value As Integer)
            iUSUARIO = value
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
    Public Property ESTADO_CORTE() As Boolean
        Get
            ESTADO_CORTE = bEstatus_Corte
        End Get
        Set(ByVal value As Boolean)
            bEstatus_Corte = value
        End Set
    End Property

End Class
