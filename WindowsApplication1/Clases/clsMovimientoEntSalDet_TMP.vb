﻿Imports System.Data.SqlClient

Public Class clsMovimientoEntSalDet_TMP
    Dim iOPERACION As String
    Dim iID_EST As Long
    Dim iID_ESD As Long
    Dim iFECHA As String
    Dim iID_MOV As Integer
    Dim iNOM_MOV As String
    Dim iID_ALM As Integer
    Dim iNOM_ALM As String
    Dim iID_CTE_INTR As Integer
    Dim iMARCA_CTE_INTR As String
    Dim iNOM_CTE_INTR As String
    Dim iID_ALM_DEST As Integer
    Dim iNOM_ALM_DEST As String
    Dim iID_CTE_DEST As Integer
    Dim iMARCA_CTE_DEST As String
    Dim iNOM_CTE_DEST As String
    Dim iSAC_LOTE As Integer
    Dim iID_PROD As String
    Dim iNOM_PROD As String
    Dim iPIEZAS As Integer
    Dim iPESO As Decimal
    Dim iTARA As Decimal
    Dim iPIEZAS_FRIO As Integer
    Dim iPESO_FRIO As Decimal
    Dim iTARA_FRIO As Decimal
    Dim iFECHA_FRIO As String
    Dim iHORA_FRIO As DateTime
    Dim iSAC_SERIE_ID As String
    Dim iOBSERVACIONES_FRIO As String
    Dim iUsuario As Integer
    Dim iID_PED As Integer
    Dim bSALA As Boolean
    Dim dTEMPERATURA As String
    Dim iSAC_INGESTA As Integer
    Dim iID_CLASIFICACION As Integer

    Public Sub New()
        Me.InicializaValores()
    End Sub

    Public Sub New(aID_EST As Integer)
        Dim lSql As String

        lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO_TMP 0, 0, 0" & aID_EST.ToString

        Me.CargaDatos(lSql)

    End Sub

    Private Sub CargaDatos(aSql As String)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = aSql

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                iID_EST = dt.Rows(0)("ID_EST")
                iID_ESD = dt.Rows(0)("ID_ESD")
                iID_MOV = dt.Rows(0)("ID_MOV")
                iNOM_MOV = dt.Rows(0)("NOM_MOV")
                iFECHA = dt.Rows(0)("FECHA_ESD")
                iID_ALM = dt.Rows(0)("ID_ALM")
                iNOM_ALM = dt.Rows(0)("NOM_ALM")
                iID_ALM_DEST = dt.Rows(0)("ID_ALM_DEST")
                iNOM_ALM_DEST = dt.Rows(0)("NOM_ALM_DEST")
                iID_CTE_DEST = dt.Rows(0)("ID_CTE_DEST")
                iMARCA_CTE_DEST = dt.Rows(0)("MARCA_CTE_DEST")
                iNOM_CTE_DEST = dt.Rows(0)("NOM_CTE_DEST")

                iPIEZAS = dt.Rows(0)("PIEZAS")
                iPESO = dt.Rows(0)("PESO")
                iTARA = dt.Rows(0)("TARA")
                iPIEZAS_FRIO = dt.Rows(0)("PIEZAS_FRIO")
                iPESO_FRIO = dt.Rows(0)("PESO_FRIO")
                iTARA_FRIO = dt.Rows(0)("TARA_FRIO")
                iSAC_SERIE_ID = dt.Rows(0)("SERIE_ID")
                iFECHA_FRIO = dt.Rows(0)("FECHA_FRIO")
                iHORA_FRIO = dt.Rows(0)("HORA_FRIO")
                iOBSERVACIONES_FRIO = (dt.Rows(0)("iOBSERVACIONES_FRIO"))
                bSALA = (dt.Rows(0)("SALA_CORTE"))
                dTEMPERATURA = (dt.Rows(0)("TEMPERATURA"))
                iSAC_INGESTA = (dt).Rows(0)("SAC_INGESTA")
                iUsuario = 0
            Else
                Me.InicializaValores()
            End If

            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Private Sub InicializaValores()
        iOPERACION = ""
        iID_EST = 0
        iID_ESD = 0
        iID_MOV = 0
        iNOM_MOV = ""
        iID_ALM = 0
        iNOM_ALM = ""
        iFECHA = ""
        iID_CTE_INTR = 0
        iMARCA_CTE_INTR = ""
        iNOM_CTE_INTR = ""
        iID_ALM_DEST = 0
        iNOM_ALM_DEST = ""
        iID_CTE_DEST = 0
        iMARCA_CTE_DEST = ""
        iNOM_CTE_DEST = ""
        iSAC_LOTE = 0
        iID_PROD = 0
        iNOM_PROD = ""
        iPIEZAS = 0
        iPESO = 0
        iTARA = 0
        iPIEZAS_FRIO = 0
        iPESO_FRIO = 0
        iTARA_FRIO = 0
        iSAC_SERIE_ID = ""
        iFECHA_FRIO = ""
        iHORA_FRIO = "01/01/1900 00:00:00"
        iOBSERVACIONES_FRIO = ""
        iUsuario = 0
        iID_PED = 0
        dTEMPERATURA = ""
        iSAC_INGESTA = 0
        bSALA = False
    End Sub

    Public Function GuardarCanal(ByRef aMensajeResultado As String, Optional ByRef aFolio As Long = 0) As Boolean

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

            GuardarCanal = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_ENTSAL_TMP"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_ENTSAL_TMP
            '@OPERACION  	CHAR(1),
            '@ID_EST		BIGINT = 0,
            '@ID_ESD		BIGINT = 0,
            '@ID_MOV		INTEGER = 0,
            '@ID_ALM		INTEGER = 0,
            '@ID_ALM_DEST	INTEGER = 0,
            '@ID_CTE_DEST	INTEGER = 0,
            '@PIEZAS		INTEGER = 0,
            '@PESO			DECIMAL(8,2)= 0,
            '@TARA			DECIMAL(8,2)= 0,
            '@FECHA			VARCHAR(10) = '',
            '@OBSERVACIONES	VARCHAR(200) = '',
            '@ERRORSP    	VARCHAR(300) OUTPUT  --INDICADOR DE ERROR (VACIO = OK)

            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_EST", SqlDbType.BigInt)
            lp3 = lCmd.Parameters.Add("ID_ESD", SqlDbType.BigInt)
            lp4 = lCmd.Parameters.Add("ID_MOV", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ID_ALM", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("ID_ALM_DEST", SqlDbType.Int)
            lp7 = lCmd.Parameters.Add("ID_CTE_DEST", SqlDbType.Int)
            lp8 = lCmd.Parameters.Add("PIEZAS", SqlDbType.Int)
            lp9 = lCmd.Parameters.Add("PESO", SqlDbType.Decimal)
            lp10 = lCmd.Parameters.Add("TARA", SqlDbType.Decimal)
            lp11 = lCmd.Parameters.Add("FECHA", SqlDbType.VarChar, 10)
            lp12 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.Char, 200)
            lp13 = lCmd.Parameters.Add("ID_PED", SqlDbType.BigInt)
            lp14 = lCmd.Parameters.Add("TEMPERATURA", SqlDbType.VarChar)
            lp15 = lCmd.Parameters.Add("ID_CLASIFICACION", SqlDbType.Int)
            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output

            lp1.Value = iOPERACION
            lp2.Value = iID_EST
            lp3.Value = iID_ESD
            lp4.Value = iID_MOV
            lp5.Value = iID_ALM
            lp6.Value = iID_ALM_DEST
            lp7.Value = iID_CTE_DEST
            lp8.Value = 1
            lp9.Value = iPESO_FRIO
            lp10.Value = 0
            lp11.Value = iFECHA_FRIO
            lp12.Value = iOBSERVACIONES_FRIO
            lp13.Value = iID_PED
            lp14.Value = dTEMPERATURA
            lp15.Value = iID_CLASIFICACION
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then
                aMensajeResultado = Trim(lpErrorSP.Value)
                GuardarCanal = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
            End If
            GuardarCanal = True

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Function GuardarProducto(ByRef aMensajeResultado As String, Optional ByRef aFolio As Long = 0) As Boolean

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

            GuardarProducto = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_ENTSAL_TMP"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_ENTSAL_TMP
            '@OPERACION  	CHAR(1),
            '@ID_EST		BIGINT = 0,
            '@ID_ESD		BIGINT = 0,
            '@ID_MOV		INTEGER = 0,
            '@ID_ALM		INTEGER = 0,
            '@ID_ALM_DEST	INTEGER = 0,
            '@ID_CTE_DEST	INTEGER = 0,
            '@PIEZAS		INTEGER = 0,
            '@PESO			DECIMAL(8,2)= 0,
            '@TARA			DECIMAL(8,2)= 0,
            '@FECHA			VARCHAR(10) = '',
            '@OBSERVACIONES	VARCHAR(200) = '',
            '@ERRORSP    	VARCHAR(300) OUTPUT  --INDICADOR DE ERROR (VACIO = OK)

            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_EST", SqlDbType.BigInt)
            lp3 = lCmd.Parameters.Add("ID_ESD", SqlDbType.BigInt)
            lp4 = lCmd.Parameters.Add("ID_MOV", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ID_ALM", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("ID_ALM_DEST", SqlDbType.Int)
            lp7 = lCmd.Parameters.Add("ID_CTE_DEST", SqlDbType.Int)
            lp8 = lCmd.Parameters.Add("PIEZAS", SqlDbType.Int)
            lp9 = lCmd.Parameters.Add("PESO", SqlDbType.Decimal)
            lp10 = lCmd.Parameters.Add("TARA", SqlDbType.Decimal)
            lp11 = lCmd.Parameters.Add("FECHA", SqlDbType.VarChar, 10)
            lp12 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.Char, 200)
            lp13 = lCmd.Parameters.Add("ID_PROD", SqlDbType.VarChar, 6)

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output

            lp1.Value = iOPERACION
            lp2.Value = iID_EST
            lp3.Value = iID_ESD
            lp4.Value = iID_MOV
            lp5.Value = iID_ALM
            lp6.Value = iID_ALM_DEST
            lp7.Value = iID_CTE_DEST
            lp13.Value = iID_PROD
            lp8.Value = iPIEZAS
            lp9.Value = iPESO
            lp10.Value = iTARA
            lp11.Value = iFECHA
            lp12.Value = iOBSERVACIONES_FRIO

            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then
                aMensajeResultado = Trim(lpErrorSP.Value)
                GuardarProducto = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
            End If
            GuardarProducto = True

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Function Guardar_MovtoAgrupadoTMP(ByRef aMensajeResultado As String, Optional ByRef aFolio As Long = 0) As Boolean

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

            Guardar_MovtoAgrupadoTMP = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_ENTSAL_DESDE_TMP"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_ENTSAL_DESDE_TMP
            '@OPERACION  	CHAR(1),
            '@ID_MOV		INTEGER = 0,
            '@ID_ALM		INTEGER = 0,
            '@ID_CTE_INTR	INTEGER = 0,
            '@ID_CTE_DEST	INTEGER = 0,
            '@FECHA			VARCHAR(10)	= '',
            '@OBSERVACIONES	VARCHAR(200)= '',
            '@USUARIO		INTEGER	= 0,
            '@FOLIO_GENERADO INTEGER	OUTPUT,	
            '@ERRORSP    	VARCHAR(300)OUTPUT

            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_MOV", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("ID_ALM", SqlDbType.Int)
            lp4 = lCmd.Parameters.Add("ID_CTE_INTR", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ID_CTE_DEST", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("FECHA", SqlDbType.VarChar, 10)
            lp7 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.Char, 200)
            lp8 = lCmd.Parameters.Add("USUARIO", SqlDbType.Int)

            lp9 = lCmd.Parameters.Add("FOLIO_GENERADO", SqlDbType.Int)
            lp9.Direction = ParameterDirection.Output
            lp13 = lCmd.Parameters.Add("ID_PED", SqlDbType.BigInt)
            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output
            lp14 = lCmd.Parameters.Add("SALA", SqlDbType.Bit)
            lp15 = lCmd.Parameters.Add("TEMPERATURA", SqlDbType.VarChar)
            lp1.Value = iOPERACION
            lp2.Value = iID_MOV
            lp3.Value = iID_ALM
            lp4.Value = iID_CTE_INTR
            lp5.Value = iID_CTE_DEST
            lp6.Value = iFECHA_FRIO
            lp7.Value = iOBSERVACIONES_FRIO
            lp8.Value = 0
            lp13.Value = iID_PED
            lp14.Value = bSALA
            lp15.Value = ""
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then
                aMensajeResultado = Trim(lpErrorSP.Value)
                Guardar_MovtoAgrupadoTMP = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
            End If
            Guardar_MovtoAgrupadoTMP = True

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Property OPERACION As String
        Get
            OPERACION = iOPERACION
        End Get
        Set(value As String)
            iOPERACION = value
        End Set
    End Property

    Public Property USUARIO As Integer
        Get
            USUARIO = iUsuario
        End Get
        Set(value As Integer)
            iUsuario = value
        End Set
    End Property

    Public Property ID_EST As Long
        Get
            ID_EST = iID_EST
        End Get
        Set(value As Long)
            iID_EST = value
        End Set
    End Property

    Public Property ID_ESD As Integer
        Get
            ID_ESD = iID_ESD
        End Get
        Set(value As Integer)
            iID_ESD = value
        End Set
    End Property

    Public Property ID_MOV As Integer
        Get
            ID_MOV = iID_MOV
        End Get
        Set(value As Integer)
            iID_MOV = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_MOVIMIENTO As String
        Get
            NOMBRE_MOVIMIENTO = iNOM_MOV
        End Get
    End Property

    Public Property FECHA As String
        Get
            FECHA = iFECHA
        End Get
        Set(value As String)
            iFECHA = value
        End Set
    End Property

    Public Property ID_ALM As Integer
        Get
            ID_ALM = iID_ALM
        End Get
        Set(value As Integer)
            iID_ALM = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_ALMACEN As String
        Get
            NOMBRE_ALMACEN = iNOM_ALM
        End Get
    End Property

    Public Property ID_CTE_INTR As Integer
        Get
            ID_CTE_INTR = iID_CTE_INTR
        End Get
        Set(value As Integer)
            iID_CTE_INTR = value
        End Set
    End Property

    Public ReadOnly Property MARCA_CTE_INTR As String
        Get
            MARCA_CTE_INTR = iMARCA_CTE_INTR
        End Get
    End Property

    Public ReadOnly Property NOMBRE_CTE_INTR As String
        Get
            NOMBRE_CTE_INTR = iNOM_CTE_INTR
        End Get
    End Property

    Public Property ID_ALM_DEST As Integer
        Get
            ID_ALM_DEST = iID_ALM_DEST
        End Get
        Set(value As Integer)
            iID_ALM_DEST = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_ALMACEN_DEST As String
        Get
            NOMBRE_ALMACEN_DEST = iNOM_ALM_DEST
        End Get
    End Property

    Public Property ID_CTE_DEST As Integer
        Get
            ID_CTE_DEST = iID_CTE_DEST
        End Get
        Set(value As Integer)
            iID_CTE_DEST = value
        End Set
    End Property

    Public ReadOnly Property MARCA_CTE_DEST As String
        Get
            MARCA_CTE_DEST = iMARCA_CTE_DEST
        End Get
    End Property

    Public ReadOnly Property NOMBRE_CTE_DEST As String
        Get
            NOMBRE_CTE_DEST = iNOM_CTE_DEST
        End Get
    End Property

    Public Property ID_PROD As String
        Get
            ID_PROD = iID_PROD
        End Get
        Set(value As String)
            iID_PROD = value
        End Set
    End Property

    Public ReadOnly Property NOMBRE_PRODUCTO As String
        Get
            NOMBRE_PRODUCTO = iNOM_PROD
        End Get
    End Property

    Public Property PIEZAS As Integer
        Get
            PIEZAS = iPIEZAS
        End Get
        Set(value As Integer)
            iPIEZAS = value
        End Set
    End Property

    Public Property PESO As Decimal
        Get
            PESO = iPESO
        End Get
        Set(value As Decimal)
            iPESO = value
        End Set
    End Property

    Public Property TARA As Decimal
        Get
            TARA = iTARA
        End Get
        Set(value As Decimal)
            iTARA = value
        End Set
    End Property

    Public Property PIEZAS_FRIO As Integer
        Get
            PIEZAS_FRIO = iPIEZAS_FRIO
        End Get
        Set(value As Integer)
            iPIEZAS_FRIO = value
        End Set
    End Property

    Public Property PESO_FRIO As Decimal
        Get
            PESO_FRIO = iPESO_FRIO
        End Get
        Set(value As Decimal)
            iPESO_FRIO = value
        End Set
    End Property

    Public Property TARA_FRIO As Decimal
        Get
            TARA_FRIO = iTARA_FRIO
        End Get
        Set(value As Decimal)
            iTARA_FRIO = value
        End Set
    End Property

    Public Property FECHA_FRIO As String
        Get
            FECHA_FRIO = iFECHA_FRIO
        End Get
        Set(value As String)
            iFECHA_FRIO = value
        End Set
    End Property

    Public ReadOnly Property HORA_FRIO As String
        Get
            HORA_FRIO = iHORA_FRIO
        End Get
    End Property


    Public ReadOnly Property SAC_SERIE_ID As String
        Get
            SAC_SERIE_ID = iSAC_SERIE_ID
        End Get
    End Property

   
    Public Property OBSERVACIONES_FRIO As String
        Get
            OBSERVACIONES_FRIO = iOBSERVACIONES_FRIO
        End Get
        Set(value As String)
            iOBSERVACIONES_FRIO = value
        End Set
    End Property

    Public Property ID_PED As Integer
        Get
            ID_PED = iID_PED
        End Get
        Set(value As Integer)
            iID_PED = value
        End Set
    End Property
    Public Property SALA_CORTE As Boolean
        Get
            SALA_CORTE = bSALA
        End Get
        Set(value As Boolean)
            bSALA = value
        End Set
    End Property
    Public Property TEMPERATURA As String
        Get
            TEMPERATURA = dTEMPERATURA
        End Get
        Set(value As String)
            dTEMPERATURA = value
        End Set
    End Property
    Public Property ID_CLASIFICACION As Integer
        Get
            ID_CLASIFICACION = iID_CLASIFICACION
        End Get
        Set(value As Integer)
            iID_CLASIFICACION = value
        End Set
    End Property
End Class
