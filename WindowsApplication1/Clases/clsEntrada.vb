Public Class clsEntrada
    Dim iID_ENT As Integer
    Dim iID_TEV As Integer
    Dim iNOM_TEV As String
    Dim iID_CTE_PROD As Integer
    Dim iMARCA_CTE_PROD As String
    Dim iNOM_CTE_PROD As String
    Dim iID_CTE_INTR As Integer
    Dim iMARCA_CTE_INTR As String
    Dim iNOM_CTE_INTR As String
    Dim iID_CTE_PROV As Integer
    Dim iMARCA_CTE_PROV As String
    Dim iNOM_CTE_PROV As String
    Dim iID_ESPECIE As Integer
    Dim iNOM_ESPECIE As String
    Dim iID_TGAN As Integer
    Dim iNOM_TGAN As String
    Dim iID_VEH As Integer
    Dim iNOM_VEH As String
    Dim iID_MVEH As Integer
    Dim iNOM_MVEH As String
    Dim iLOTE As Integer
    Dim iFECHA_ENTRADA As String
    Dim iHORA_ENTRADA As String
    Dim iFECHA_SALIDA As String
    Dim iHORA_SALIDA As String
    Dim iFECHA_SACRIFICIO As String
    Dim iPESO_ENTRADA As Decimal
    Dim iPESO_SALIDA As Decimal
    Dim iPESO_NETO As Decimal
    Dim iNUM_GUIA As String
    Dim iPESO_GUIA As Decimal
    Dim iNUM_MACHOS_GUIA As Integer
    Dim iNUM_HEMBRAS_GUIA As Integer
    Dim iTOT_ANIMALES_GUIA As Integer
    Dim iNUM_MACHOS As Integer
    Dim iNUM_TORETES As Integer
    Dim iNUM_HEMBRAS As Integer
    Dim iNUM_VAQUILLAS As Integer
    Dim iTOT_MACHOS As Integer
    Dim iTOT_HEMBRAS As Integer
    Dim iTOT_ANIMALES As Integer
    Dim iORIGEN As String
    Dim iCONDUCTOR As String
    Dim iPLACAS As String
    Dim iOBSERVACIONES As String
    Dim iCORRALES As String
    Dim iFOLIO_CZM As String
    Dim iFLEJE As String
    Dim iPESADA_MANUAL As String
    Dim iESTATUS As String
    Dim idt_Entrada As DataTable

    Public Sub New()
        Me.InicializaValores()
    End Sub
    Public Sub New(aID As Integer)
        Try

            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_ENTRADAS " & aID.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlClient.SqlDataAdapter(lCmd)
            da.Fill(dt)
            idt_Entrada = dt

            If dt.Rows.Count > 0 Then
                iID_ENT = dt.Rows(0)("ID_ENT")
                iID_TEV = dt.Rows(0)("ID_TEV")
                iNOM_TEV = dt.Rows(0)("NOM_TEV")
                iID_CTE_PROD = dt.Rows(0)("ID_CTE_PROD")
                iMARCA_CTE_PROD = dt.Rows(0)("MARCA_CTE_PROD")
                iNOM_CTE_PROD = dt.Rows(0)("NOM_CTE_PROD")
                iID_CTE_INTR = dt.Rows(0)("ID_CTE_INTR")
                iMARCA_CTE_INTR = dt.Rows(0)("MARCA_CTE_INTR")
                iNOM_CTE_INTR = dt.Rows(0)("NOM_CTE_INTR")
                iID_CTE_PROV = dt.Rows(0)("ID_CTE_PROV")
                iMARCA_CTE_PROV = dt.Rows(0)("MARCA_CTE_PROV")
                iNOM_CTE_PROV = dt.Rows(0)("NOM_CTE_PROV")
                iID_ESPECIE = dt.Rows(0)("ID_ESPECIE")
                iNOM_ESPECIE = dt.Rows(0)("NOM_ESPECIE")
                iID_TGAN = dt.Rows(0)("ID_TGAN")
                iNOM_TGAN = dt.Rows(0)("NOM_TGAN")
                iID_VEH = dt.Rows(0)("ID_VEH")
                iNOM_VEH = dt.Rows(0)("NOM_VEH")
                iID_MVEH = dt.Rows(0)("ID_MVEH")
                iNOM_MVEH = dt.Rows(0)("NOM_MVEH")
                iLOTE = dt.Rows(0)("LOTE")
                iFECHA_ENTRADA = dt.Rows(0)("FECHA_ENTRADA")
                iHORA_ENTRADA = dt.Rows(0)("HORA_ENTRADA")
                iFECHA_SALIDA = dt.Rows(0)("FECHA_SALIDA")
                iHORA_SALIDA = dt.Rows(0)("HORA_SALIDA")
                iFECHA_SACRIFICIO = dt.Rows(0)("FECHA_SACRIFICIO")
                iPESO_ENTRADA = dt.Rows(0)("PESO_ENTRADA")
                iPESO_SALIDA = dt.Rows(0)("PESO_SALIDA")
                iPESO_NETO = dt.Rows(0)("PESO_NETO")
                iNUM_GUIA = dt.Rows(0)("NUM_GUIA")
                iPESO_GUIA = dt.Rows(0)("PESO_GUIA")
                iNUM_MACHOS_GUIA = dt.Rows(0)("NUM_MACHOS_GUIA")
                iNUM_HEMBRAS_GUIA = dt.Rows(0)("NUM_HEMBRAS_GUIA")
                iTOT_ANIMALES_GUIA = dt.Rows(0)("TOT_ANIMALES_GUIA")
                iNUM_MACHOS = dt.Rows(0)("NUM_MACHOS")
                iNUM_TORETES = dt.Rows(0)("NUM_TORETES")
                iNUM_HEMBRAS = dt.Rows(0)("NUM_HEMBRAS")
                iNUM_VAQUILLAS = dt.Rows(0)("NUM_VAQUILLAS")
                iTOT_HEMBRAS = dt.Rows(0)("TOT_HEMBRAS")
                iTOT_MACHOS = dt.Rows(0)("TOT_MACHOS")
                iTOT_ANIMALES = dt.Rows(0)("TOT_ANIMALES")
                iORIGEN = dt.Rows(0)("ORIGEN")
                iCONDUCTOR = dt.Rows(0)("CONDUCTOR")
                iPLACAS = dt.Rows(0)("PLACAS")
                iOBSERVACIONES = dt.Rows(0)("OBSERVACIONES")
                iCORRALES = dt.Rows(0)("CORRALES")
                iFOLIO_CZM = dt.Rows(0)("FOLIO_CZM")
                iFLEJE = dt.Rows(0)("FLEJE")
                iPESADA_MANUAL = dt.Rows(0)("PESADA_MANUAL")
                iESTATUS = dt.Rows(0)("ESTATUS")
            Else
                Me.InicializaValores()
            End If

            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub InicializaValores()
        iID_ENT = 0
        iID_TEV = 0
        iNOM_TEV = ""
        iID_CTE_PROD = 0
        iMARCA_CTE_PROD = ""
        iNOM_CTE_PROD = ""
        iID_CTE_INTR = 0
        iMARCA_CTE_INTR = ""
        iNOM_CTE_INTR = ""
        iID_CTE_PROV = 0
        iMARCA_CTE_PROV = ""
        iNOM_CTE_PROV = ""
        iID_ESPECIE = 0
        iNOM_ESPECIE = ""
        iID_TGAN = 0
        iNOM_TGAN = ""
        iID_VEH = 0
        iNOM_VEH = ""
        iID_MVEH = 0
        iNOM_MVEH = ""
        iLOTE = 0
        iFECHA_ENTRADA = ""
        iHORA_ENTRADA = ""
        iFECHA_SALIDA = ""
        iHORA_SALIDA = ""
        iFECHA_SACRIFICIO = ""
        iPESO_ENTRADA = 0
        iPESO_SALIDA = 0
        iPESO_NETO = 0
        iNUM_GUIA = ""
        iPESO_GUIA = 0
        iNUM_MACHOS_GUIA = 0
        iNUM_HEMBRAS_GUIA = 0
        iTOT_ANIMALES_GUIA = 0
        iNUM_MACHOS = 0
        iNUM_TORETES = 0
        iNUM_HEMBRAS = 0
        iNUM_VAQUILLAS = 0
        iTOT_MACHOS = 0
        iTOT_HEMBRAS = 0
        iTOT_ANIMALES = 0
        iORIGEN = ""
        iCONDUCTOR = ""
        iPLACAS = ""
        iOBSERVACIONES = ""
        iCORRALES = ""
        iFOLIO_CZM = ""
        iFLEJE = ""
        iPESADA_MANUAL = ""
        iESTATUS = ""
        idt_Entrada = Nothing
    End Sub

    Public Function Guardar(ByRef aMensajeResultado As String, Optional ByRef aFolio As Integer = 0, Optional ByVal aOperacion As String = "A") As Boolean
        Dim lOperacion As String = aOperacion

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
        Dim lp16 As New SqlClient.SqlParameter
        Dim lp17 As New SqlClient.SqlParameter
        Dim lp18 As New SqlClient.SqlParameter
        Dim lp19 As New SqlClient.SqlParameter
        Dim lp20 As New SqlClient.SqlParameter
        Dim lp21 As New SqlClient.SqlParameter
        Dim lp22 As New SqlClient.SqlParameter
        Dim lp23 As New SqlClient.SqlParameter
        Dim lp24 As New SqlClient.SqlParameter
        Dim lp25 As New SqlClient.SqlParameter
        Dim lp26 As New SqlClient.SqlParameter
        Dim lp27 As New SqlClient.SqlParameter
        Dim lp28 As New SqlClient.SqlParameter
        Dim lp29 As New SqlClient.SqlParameter
        Dim lp30 As New SqlClient.SqlParameter
        Dim lp31 As New SqlClient.SqlParameter
        Dim lp32 As New SqlClient.SqlParameter
        Dim lp33 As New SqlClient.SqlParameter
        Dim lp34 As New SqlClient.SqlParameter
        Dim lp35 As New SqlClient.SqlParameter
        Dim lp36 As New SqlClient.SqlParameter
        Dim lp37 As New SqlClient.SqlParameter
        Dim lp38 As New SqlClient.SqlParameter

        Dim lpErrorSP As New SqlClient.SqlParameter

        Try

            Guardar = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_ENTRADAS"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_ENTRADAS
            '@OPERACION  		CHAR(1),
            '@ID_ENT			INTEGER = 0,
            '@ID_TEV			INTEGER = 0,
            '@ID_CTE_PROD		INTEGER = 0,
            '@ID_CTE_INTR		INTEGER = 0,
            '@ID_CTE_PROV		INTEGER = 0,
            '@ID_ESPECIE		INTEGER = 0,
            '@ID_TGAN			INTEGER = 0,
            '@ID_VEH			INTEGER = 0,
            '@ID_MVEH			INTEGER = 0,
            '@LOTE				INTEGER = 0,
            '@FECHA_ENTRADA		VARCHAR(10) = '',
            '--@HORA_ENTRADA	DATETIME,
            '@FECHA_SALIDA		VARCHAR(10) = '',
            '--@HORA_SALIDA		DATETIME,
            '@FECHA_SACRIFICIO	VARCHAR(10) = '',
            '@PESO_ENTRADA		DECIMAL(8,2)= 0,
            '@PESO_SALIDA		DECIMAL(8,2)= 0,
            '@PESO_NETO			DECIMAL(8,2)= 0,
            '@NUM_GUIA			VARCHAR(10) = '',
            '@PESO_GUIA			DECIMAL(8,2)= 0,
            '@NUM_MACHOS_GUIA	INTEGER = 0,
            '@NUM_HEMBRAS_GUIA	INTEGER = 0,
            '@NUM_MACHOS		INTEGER = 0,
            '@NUM_TORETES		INTEGER = 0,
            '@NUM_HEMBRAS		INTEGER = 0,
            '@NUM_VAQUILLAS		INTEGER = 0,
            '@ORIGEN			VARCHAR(40) = '',
            '@CONDUCTOR			VARCHAR(30) = '',
            '@PLACAS			VARCHAR(10) = '',
            '@OBSERVACIONES		VARCHAR(200) = '',
            '@CORRALES			VARCHAR(20) = '',
            '@FOLIO_CZM			VARCHAR(15) = '',
            '@FLEJE				VARCHAR(15) = '',
            '@PESADA_MANUAL		VARCHAR(1) = '',
            '--@ESTATUS			VARCHAR(1) = ''
            '@ERRORSP    		VARCHAR(300) OUTPUT  --INDICADOR DE ERROR (VACIO = OK)

            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_ENT", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("ID_TEV", SqlDbType.Int)
            lp4 = lCmd.Parameters.Add("ID_CTE_PROD", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ID_CTE_INTR", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("ID_CTE_PROV", SqlDbType.Int)
            lp7 = lCmd.Parameters.Add("ID_ESPECIE", SqlDbType.Int)
            lp8 = lCmd.Parameters.Add("ID_TGAN", SqlDbType.Int)
            lp9 = lCmd.Parameters.Add("ID_VEH", SqlDbType.Int)
            lp10 = lCmd.Parameters.Add("ID_MVEH", SqlDbType.Int)
            lp12 = lCmd.Parameters.Add("LOTE", SqlDbType.Int)
            lp13 = lCmd.Parameters.Add("FECHA_ENTRADA", SqlDbType.VarChar, 10)
            lp14 = lCmd.Parameters.Add("FECHA_SALIDA", SqlDbType.VarChar, 10)
            lp15 = lCmd.Parameters.Add("FECHA_SACRIFICIO", SqlDbType.VarChar, 10)
            lp16 = lCmd.Parameters.Add("PESO_ENTRADA", SqlDbType.Decimal)
            lp17 = lCmd.Parameters.Add("PESO_SALIDA", SqlDbType.Decimal)
            lp18 = lCmd.Parameters.Add("PESO_NETO", SqlDbType.Decimal)
            lp19 = lCmd.Parameters.Add("NUM_GUIA", SqlDbType.VarChar, 10)
            lp20 = lCmd.Parameters.Add("PESO_GUIA", SqlDbType.Decimal)
            lp21 = lCmd.Parameters.Add("NUM_MACHOS_GUIA", SqlDbType.Int)
            lp22 = lCmd.Parameters.Add("NUM_HEMBRAS_GUIA", SqlDbType.Int)
            lp23 = lCmd.Parameters.Add("NUM_MACHOS", SqlDbType.Int)
            lp24 = lCmd.Parameters.Add("NUM_TORETES", SqlDbType.Int)
            lp25 = lCmd.Parameters.Add("NUM_HEMBRAS", SqlDbType.Int)
            lp26 = lCmd.Parameters.Add("NUM_VAQUILLAS", SqlDbType.Int)
            lp27 = lCmd.Parameters.Add("ORIGEN", SqlDbType.VarChar, 40)
            lp28 = lCmd.Parameters.Add("CONDUCTOR", SqlDbType.VarChar, 30)
            lp29 = lCmd.Parameters.Add("PLACAS", SqlDbType.VarChar, 10)
            lp31 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.VarChar, 200)
            lp32 = lCmd.Parameters.Add("CORRALES", SqlDbType.VarChar, 20)
            lp33 = lCmd.Parameters.Add("FOLIO_CZM", SqlDbType.VarChar, 15)
            lp34 = lCmd.Parameters.Add("FLEJE", SqlDbType.VarChar, 15)
            lp35 = lCmd.Parameters.Add("PESADA_MANUAL", SqlDbType.Char, 1)
            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output


            lp1.Value = aOperacion
            lp2.Value = iID_ENT
            lp3.Value = iID_TEV
            lp4.Value = iID_CTE_PROD
            lp5.Value = iID_CTE_INTR
            lp6.Value = iID_CTE_PROV
            lp7.Value = iID_ESPECIE
            lp8.Value = iID_TGAN
            lp9.Value = iID_VEH
            lp10.Value = iID_MVEH
            lp12.Value = iLOTE
            lp13.Value = iFECHA_ENTRADA
            lp14.Value = iFECHA_SALIDA
            lp15.Value = iFECHA_SACRIFICIO
            lp16.Value = iPESO_ENTRADA
            lp17.Value = iPESO_SALIDA
            lp18.Value = iPESO_NETO
            lp19.Value = iNUM_GUIA
            lp20.Value = iPESO_GUIA
            lp21.Value = iNUM_MACHOS_GUIA
            lp22.Value = iNUM_HEMBRAS_GUIA
            lp23.Value = iNUM_MACHOS
            lp24.Value = iNUM_TORETES
            lp25.Value = iNUM_HEMBRAS
            lp26.Value = iNUM_VAQUILLAS
            lp27.Value = iORIGEN
            lp28.Value = iCONDUCTOR
            lp29.Value = iPLACAS
            lp31.Value = iOBSERVACIONES
            lp32.Value = iCORRALES
            lp33.Value = iFOLIO_CZM
            lp34.Value = iFLEJE
            lp35.Value = iPESADA_MANUAL


            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                aMensajeResultado = Trim(lpErrorSP.Value)
                Guardar = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
                aFolio = lpErrorSP.Value
                Guardar = True
            End If

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Function Catalogo() As DataTable
        Dim lSql As String
        Dim daConsultaCat As SqlClient.SqlDataAdapter
        Dim lDatatable As New DataTable
        Try

            lSql = "EXECUTE SP_CONS_ENTRADAS"

            daConsultaCat = New SqlClient.SqlDataAdapter(lSql, Cnn)
            daConsultaCat.Fill(lDatatable)
            daConsultaCat.Dispose()

            Return lDatatable

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return lDatatable
        Finally

        End Try
    End Function

    Public ReadOnly Property dt_ENTRADA As DataTable
        Get
            dt_ENTRADA = idt_Entrada
        End Get
    End Property

    Public Property ID_ENTRADA As Integer
        Get
            ID_ENTRADA = iID_ENT
        End Get
        Set(value As Integer)
            iID_ENT = value
        End Set
    End Property

    Public Property ID_Tipo_Entrada As Integer
        Get
            ID_Tipo_Entrada = iID_TEV
        End Get
        Set(value As Integer)
            iID_TEV = value
        End Set
    End Property

    Public ReadOnly Property Nom_Tipo_Entrada As String
        Get
            Nom_Tipo_Entrada = iNOM_TEV
        End Get
    End Property

    Public Property ID_Cte_Productor As Integer
        Get
            ID_Cte_Productor = iID_CTE_PROD
        End Get
        Set(value As Integer)
            iID_CTE_PROD = value
        End Set
    End Property

    Public ReadOnly Property Marca_Cte_Productor As String
        Get
            Marca_Cte_Productor = iMARCA_CTE_PROD
        End Get
    End Property

    Public ReadOnly Property Nom_Cte_Productor As String
        Get
            Nom_Cte_Productor = iNOM_CTE_PROD
        End Get
    End Property

    Public Property ID_Cte_Introductor As Integer
        Get
            ID_Cte_Introductor = iID_CTE_INTR
        End Get
        Set(value As Integer)
            iID_CTE_INTR = value
        End Set
    End Property

    Public ReadOnly Property Marca_Cte_Introductor As String
        Get
            Marca_Cte_Introductor = iMARCA_CTE_INTR
        End Get
    End Property

    Public ReadOnly Property Nom_Cte_Introductor As String
        Get
            Nom_Cte_Introductor = iNOM_CTE_INTR
        End Get
    End Property

    Public Property ID_Cte_Proveedor As Integer
        Get
            ID_Cte_Proveedor = iID_CTE_PROV
        End Get
        Set(value As Integer)
            iID_CTE_PROV = value
        End Set
    End Property

    Public ReadOnly Property Marca_Cte_Proveedor As String
        Get
            Marca_Cte_Proveedor = iMARCA_CTE_PROV
        End Get
    End Property

    Public ReadOnly Property Nom_Cte_Proveedor As String
        Get
            Nom_Cte_Proveedor = iNOM_CTE_PROV
        End Get
    End Property

    Public Property ID_Especie As Integer
        Get
            ID_Especie = iID_ESPECIE
        End Get
        Set(value As Integer)
            iID_ESPECIE = value
        End Set
    End Property

    Public ReadOnly Property Nombre_Especie As String
        Get
            Nombre_Especie = iNOM_ESPECIE
        End Get
    End Property

    Public Property ID_Tipo_Ganado As Integer
        Get
            ID_Tipo_Ganado = iID_TGAN
        End Get
        Set(value As Integer)
            iID_TGAN = value
        End Set
    End Property

    Public ReadOnly Property Nom_Tipo_Ganado As String
        Get
            Nom_Tipo_Ganado = iNOM_TGAN
        End Get
    End Property

    Public Property ID_Tipo_Vehiculo As Integer
        Get
            ID_Tipo_Vehiculo = iID_VEH
        End Get
        Set(value As Integer)
            iID_VEH = value
        End Set
    End Property

    Public ReadOnly Property Nom_Tipo_Vehiculo As String
        Get
            Nom_Tipo_Vehiculo = iNOM_VEH
        End Get
    End Property

    Public Property ID_Marca_Vehiculo As Integer
        Get
            ID_Marca_Vehiculo = iID_MVEH
        End Get
        Set(value As Integer)
            iID_MVEH = value
        End Set
    End Property

    Public ReadOnly Property Nom_Marca_Vehiculo As String
        Get
            Nom_Marca_Vehiculo = iNOM_MVEH
        End Get
    End Property

    Public Property LOTE As Integer
        Get
            LOTE = iLOTE
        End Get
        Set(value As Integer)
            iLOTE = value
        End Set
    End Property

    Public Property FECHA_ENTRADA As String
        Get
            FECHA_ENTRADA = iFECHA_ENTRADA
        End Get
        Set(value As String)
            iFECHA_ENTRADA = value
        End Set
    End Property

    Public Property HORA_ENTRADA As String
        Get
            HORA_ENTRADA = iHORA_ENTRADA
        End Get
        Set(value As String)
            iHORA_ENTRADA = value
        End Set
    End Property

    Public Property FECHA_SALIDA As String
        Get
            FECHA_SALIDA = iFECHA_SALIDA
        End Get
        Set(value As String)
            iFECHA_SALIDA = value
        End Set
    End Property

    Public Property HORA_SALIDA As String
        Get
            HORA_SALIDA = iHORA_SALIDA
        End Get
        Set(value As String)
            iHORA_SALIDA = value
        End Set
    End Property

    Public Property FECHA_SACRIFICIO As String
        Get
            FECHA_SACRIFICIO = iFECHA_SACRIFICIO
        End Get
        Set(value As String)
            iFECHA_SACRIFICIO = value
        End Set
    End Property

    Public Property PESO_ENTRADA As Decimal
        Get
            PESO_ENTRADA = iPESO_ENTRADA
        End Get
        Set(value As Decimal)
            iPESO_ENTRADA = value
        End Set
    End Property

    Public Property PESO_SALIDA As Decimal
        Get
            PESO_SALIDA = iPESO_SALIDA
        End Get
        Set(value As Decimal)
            iPESO_SALIDA = value
        End Set
    End Property

    Public Property PESO_NETO As Decimal
        Get
            PESO_NETO = iPESO_NETO
        End Get
        Set(value As Decimal)
            iPESO_NETO = value
        End Set
    End Property

    Public Property NUM_GUIA As String
        Get
            NUM_GUIA = iNUM_GUIA
        End Get
        Set(value As String)
            iNUM_GUIA = value
        End Set
    End Property

    Public Property PESO_GUIA As Decimal
        Get
            PESO_GUIA = iPESO_GUIA
        End Get
        Set(value As Decimal)
            iPESO_GUIA = value
        End Set
    End Property

    Public Property NUM_MACHOS_GUIA As Integer
        Get
            NUM_MACHOS_GUIA = iNUM_MACHOS_GUIA
        End Get
        Set(value As Integer)
            iNUM_MACHOS_GUIA = value
        End Set
    End Property

    Public Property NUM_HEMBRAS_GUIA As Integer
        Get
            NUM_HEMBRAS_GUIA = iNUM_HEMBRAS_GUIA
        End Get
        Set(value As Integer)
            iNUM_HEMBRAS_GUIA = value
        End Set
    End Property

    Public ReadOnly Property TOTAL_ANIMALES_GUIA As Integer
        Get
            TOTAL_ANIMALES_GUIA = iTOT_ANIMALES_GUIA
        End Get
    End Property

    Public Property NUM_MACHOS As Integer
        Get
            NUM_MACHOS = iNUM_MACHOS
        End Get
        Set(value As Integer)
            iNUM_MACHOS = value
        End Set
    End Property

    Public Property NUM_TORETES As Integer
        Get
            NUM_TORETES = iNUM_TORETES
        End Get
        Set(value As Integer)
            iNUM_TORETES = value
        End Set
    End Property

    Public Property NUM_HEMBRAS As Integer
        Get
            NUM_HEMBRAS = iNUM_HEMBRAS
        End Get
        Set(value As Integer)
            iNUM_HEMBRAS = value
        End Set
    End Property

    Public Property NUM_VAQUILLAS As Integer
        Get
            NUM_VAQUILLAS = iNUM_VAQUILLAS
        End Get
        Set(value As Integer)
            iNUM_VAQUILLAS = value
        End Set
    End Property

    Public ReadOnly Property TOTAL_HEMBRAS As Integer
        Get
            TOTAL_HEMBRAS = iTOT_HEMBRAS
        End Get
    End Property

    Public ReadOnly Property TOTAL_MACHOS As Integer
        Get
            TOTAL_MACHOS = iTOT_MACHOS
        End Get
    End Property

    Public ReadOnly Property TOTAL_ANIMALES As Integer
        Get
            TOTAL_ANIMALES = iTOT_ANIMALES
        End Get
    End Property

    Public Property ORIGEN As String
        Get
            ORIGEN = iORIGEN
        End Get
        Set(value As String)
            iORIGEN = value
        End Set
    End Property

    Public Property CONDUCTOR As String
        Get
            CONDUCTOR = iCONDUCTOR
        End Get
        Set(value As String)
            iCONDUCTOR = value
        End Set
    End Property

    Public Property PLACAS As String
        Get
            PLACAS = iPLACAS
        End Get
        Set(value As String)
            iPLACAS = value
        End Set
    End Property

    Public Property OBSERVACIONES As String
        Get
            OBSERVACIONES = iOBSERVACIONES
        End Get
        Set(value As String)
            iOBSERVACIONES = value
        End Set
    End Property

    Public Property CORRALES As String
        Get
            CORRALES = iCORRALES
        End Get
        Set(value As String)
            iCORRALES = value
        End Set
    End Property

    Public Property FOLIO_CZM As String
        Get
            FOLIO_CZM = iFOLIO_CZM
        End Get
        Set(value As String)
            iFOLIO_CZM = value
        End Set
    End Property

    Public Property FLEJE As String
        Get
            FLEJE = iFLEJE
        End Get
        Set(value As String)
            iFLEJE = value
        End Set
    End Property

    Public Property PESADA_MANUAL As String
        Get
            PESADA_MANUAL = iPESADA_MANUAL
        End Get
        Set(value As String)
            iPESADA_MANUAL = value
        End Set
    End Property

    Public Property ESTATUS As String
        Get
            ESTATUS = iESTATUS
        End Get
        Set(value As String)
            iESTATUS = value
        End Set
    End Property


End Class
