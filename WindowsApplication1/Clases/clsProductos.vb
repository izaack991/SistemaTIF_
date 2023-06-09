Option Strict Off

Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System

Public Class clsProductos
    Dim iOperacion As String
    Dim iID_PROD As String
    Dim iNOMBRE As String
    Dim iDIAS_CADUCIDAD As Integer
    Dim iID_ESPECIE As Integer
    Dim iNOM_ESPECIE As String
    Dim iID_FAM As Integer
    Dim iNOM_FAM As String
    Dim iID_SFAM As Integer
    Dim iNOM_SFAM As String
    Dim iID_CUARTO As Integer
    Dim iNOM_CUARTO As String
    Dim iID_REF As Integer
    Dim iNOM_REF As String
    Dim iID_CEXP As Integer
    Dim iNOM_CEXP As String
    Dim iESTATUS As String

    Dim iID_CTE As Integer
    Dim iMARCA_CTE As String
    Dim iNOMBRE_CTE As String
    Dim iID_PROD_CTE As String
    Dim iNOMBRE_PROD_CTE As String
    Dim iESTATUS_PROD_CTE As String

    Dim iporCliente As Boolean = False
    Dim iExiste As Boolean
    Dim iID_PROD_CTE_PADRE As String
    Dim iPROD_MP As Boolean
    Public Sub New()
        Me.InicializaValores()
    End Sub

    Public Sub New(ByVal aID_CTE As Integer, ByVal aID_PRODCTE As String)
        iporCliente = True
        Me.CargaDatos("EXECUTE SP_CONS_PRODUCTOS_X_CTE '" & aID_CTE & "', '" & aID_PRODCTE & "'")
    End Sub

    Public Sub New(ByVal aID_PROD As String)
        Me.CargaDatos("EXECUTE SP_CONS_PRODUCTOS '" & aID_PROD & "'")
    End Sub

    Private Sub CargaDatos(aSql As String)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            Me.InicializaValores()

            'lSql = "EXECUTE SP_CONS_PRODUCTOS " & aID

            lSql = aSql

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                iID_PROD = dt.Rows(0)("ID_PROD")
                iNOMBRE = dt.Rows(0)("NOMBRE")
                iDIAS_CADUCIDAD = dt.Rows(0)("DIAS_CAD")
                iID_ESPECIE = dt.Rows(0)("ID_ESPECIE")
                iNOM_ESPECIE = dt.Rows(0)("NOM_ESPECIE")
                iID_FAM = dt.Rows(0)("ID_FAM")
                iNOM_FAM = dt.Rows(0)("NOM_FAM")
                iID_SFAM = dt.Rows(0)("ID_SFAM")
                iNOM_SFAM = dt.Rows(0)("NOM_SFAM")
                iID_CUARTO = dt.Rows(0)("ID_CUARTO")
                iNOM_CUARTO = dt.Rows(0)("NOM_CUARTO")
                iID_REF = dt.Rows(0)("ID_REF")
                iNOM_REF = dt.Rows(0)("NOM_REF")
                iID_CEXP = dt.Rows(0)("ID_CEXP")
                iNOM_CEXP = dt.Rows(0)("NOM_CEXP")
                iESTATUS = dt.Rows(0)("ESTATUS")

                If iporCliente Then
                    iID_CTE = dt.Rows(0)("ID_CTE")
                    iMARCA_CTE = dt.Rows(0)("MARCA_CTE")
                    iNOMBRE_CTE = dt.Rows(0)("NOMBRE_CTE")
                    iID_PROD_CTE = dt.Rows(0)("ID_PROD_CTE")
                    iNOMBRE_PROD_CTE = dt.Rows(0)("NOMBRE_PROD_CTE")
                    iESTATUS_PROD_CTE = dt.Rows(0)("ESTATUS_PROD_CTE")
                    iPROD_MP = dt.Rows(0)("PROD_MP")
                    iID_PROD_CTE_PADRE = dt.Rows(0)("PROD_PADRE")
                End If

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
        iID_PROD = ""
        iNOMBRE = ""
        iDIAS_CADUCIDAD = 0
        iID_ESPECIE = 0
        iNOM_ESPECIE = ""
        iID_FAM = 0
        iNOM_FAM = ""
        iID_SFAM = 0
        iNOM_SFAM = ""
        iID_CUARTO = 0
        iNOM_CUARTO = ""
        iID_REF = 0
        iNOM_REF = ""
        iID_CEXP = 0
        iNOM_CEXP = ""
        iESTATUS = ""
        iExiste = False

        iID_CTE = 0
        iMARCA_CTE = ""
        iNOMBRE_CTE = ""
        iID_PROD_CTE = ""
        iNOMBRE_PROD_CTE = ""
        iESTATUS_PROD_CTE = ""
        iID_PROD_CTE_PADRE = ""
        iPROD_MP = False
    End Sub

    Public Function Guardar(ByRef aMensajeResultado As String, Optional ByRef aFolio As String = "") As Boolean

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
        Dim lpID_PROD_GENERADO As New SqlClient.SqlParameter
        Dim lpErrorSP As New SqlClient.SqlParameter

        Try

            Guardar = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_PRODUCTOS"
            lCmd.CommandType = CommandType.StoredProcedure

            'PROCEDURE SP_ABC_PRODUCTOS
            '@OPERACION     CHAR(1),
            '@ID_PROD	    INTEGER = 0,
            '@NOMBRE 	    VARCHAR(60) = '',
            '@DIAS_CAD	    INT	= 0,
            '@ID_ESPECIE    INT	= 0,
            '@ID_FAM		INT	= 0,
            '@ID_SFAM	    INT	= 0,
            '@ID_REF	    INT	= 0,
            '@ID_CEXP	    INT	= 0,
            '-----------------------
            '@ID_CTE		    INTEGER		= 0,
            '@ID_PROD_CTE	    VARCHAR(4)	= '',
            '@NOMBRE_PROD_CTE	VARCHAR(40)	= '',
            '-----------------------
            '@ERRORSP       VARCHAR(300) OUTPUT 

            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_PROD", SqlDbType.VarChar, 6)
            lp3 = lCmd.Parameters.Add("NOMBRE", SqlDbType.VarChar, 40)
            lp4 = lCmd.Parameters.Add("DIAS_CAD", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("ID_ESPECIE", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("ID_FAM", SqlDbType.Int)
            lp7 = lCmd.Parameters.Add("ID_SFAM", SqlDbType.Int)
            lp8 = lCmd.Parameters.Add("ID_REF", SqlDbType.Int)
            lp9 = lCmd.Parameters.Add("ID_CEXP", SqlDbType.Int)
            lp10 = lCmd.Parameters.Add("ID_CTE", SqlDbType.Int)
            lp11 = lCmd.Parameters.Add("ID_PROD_CTE", SqlDbType.VarChar, 4)
            lp12 = lCmd.Parameters.Add("NOMBRE_PROD_CTE", SqlDbType.VarChar, 40)
            lp13 = lCmd.Parameters.Add("ID_CUARTO", SqlDbType.Int)
            lp14 = lCmd.Parameters.Add("PROD_MP", SqlDbType.Bit)
            lp15 = lCmd.Parameters.Add("PROD_PADRE", SqlDbType.VarChar, 6)
            lpID_PROD_GENERADO = lCmd.Parameters.Add("ID_PROD_GENERADO", SqlDbType.VarChar, 6)
            lpID_PROD_GENERADO.Direction = ParameterDirection.Output
            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output

            lp1.Value = iOperacion
            lp2.Value = iID_PROD
            lp3.Value = iNOMBRE
            lp4.Value = iDIAS_CADUCIDAD
            lp5.Value = iID_ESPECIE
            lp6.Value = iID_FAM
            lp7.Value = iID_SFAM
            lp8.Value = iID_REF
            lp9.Value = iID_CEXP
            lp13.Value = iID_CUARTO

            lp10.Value = iID_CTE
            lp11.Value = ID_PROD_CTE
            lp12.Value = iNOMBRE_PROD_CTE
            lp14.Value = iPROD_MP
            lp15.Value = iID_PROD_CTE_PADRE
            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                aMensajeResultado = Trim(lpErrorSP.Value)
                Guardar = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
                aFolio = lpID_PROD_GENERADO.Value
                Guardar = True
            End If

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Function Catalogo(Optional ByVal aID_PROD As String = "", Optional ByVal aID_ESPECIE As String = "%", _
                            Optional ByVal aID_FAM As String = "%", Optional ByVal aID_SFAM As String = "%", _
                            Optional ByVal aID_REF As String = "%", Optional ByVal aID_CEXP As String = "%", _
                            Optional ByVal aESTATUS As String = "A") As DataTable
        Dim lSql As String
        Dim daConsultaCat As SqlClient.SqlDataAdapter
        Dim lDatatable As New DataTable
        Try

            lSql = "EXECUTE SP_CONS_PRODUCTOS '" & aID_PROD & "', '" & aID_ESPECIE & "', '" & aID_FAM & "', '" & aID_SFAM & "', '" & aID_REF & "', '" & aID_CEXP & "', '" & aESTATUS & "'"

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

    Public Function Catalogo_Clientes_Corte(ByVal aID_CTE As Integer, Optional ByVal ID_PRODCTE As String = "", Optional ByVal aID_ESPECIE As String = "%", _
                        Optional ByVal aID_FAM As String = "%", Optional ByVal aID_SFAM As String = "%", Optional ByVal aESTATUS As String = "A") As DataTable
        Dim lSql As String
        Dim daConsultaCat As SqlClient.SqlDataAdapter
        Dim lDatatable As New DataTable
        Try

            lSql = "EXECUTE SP_CONS_PRODUCTOS_X_CTE '" & aID_CTE & "', '" & ID_PRODCTE & "', '" & aID_ESPECIE & "', '" & aID_FAM & "', '" & aID_SFAM & "', '" & aESTATUS & "'"

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

    Public Property ID_PROD As String
        Get
            ID_PROD = iID_PROD
        End Get
        Set(value As String)
            iID_PROD = value
        End Set
    End Property

    Public Property NOMBRE As String
        Get
            NOMBRE = iNOMBRE
        End Get
        Set(value As String)
            iNOMBRE = value
        End Set
    End Property

    Public Property DIAS_CADUCIDAD As Integer
        Get
            DIAS_CADUCIDAD = iDIAS_CADUCIDAD
        End Get
        Set(value As Integer)
            iDIAS_CADUCIDAD = value
        End Set
    End Property

    Public Property ID_ESPECIE As Integer
        Get
            ID_ESPECIE = iID_ESPECIE
        End Get
        Set(value As Integer)
            iID_ESPECIE = value
        End Set
    End Property

    Public ReadOnly Property NOM_ESPECIE As String
        Get
            NOM_ESPECIE = iNOM_ESPECIE
        End Get
    End Property

    Public Property ID_FAM As Integer
        Get
            ID_FAM = iID_FAM
        End Get
        Set(value As Integer)
            iID_FAM = value
        End Set
    End Property

    Public ReadOnly Property NOM_FAMILIA As String
        Get
            NOM_FAMILIA = iNOM_FAM
        End Get
    End Property

    Public Property ID_SFAM As Integer
        Get
            ID_SFAM = iID_SFAM
        End Get
        Set(value As Integer)
            iID_SFAM = value
        End Set
    End Property

    Public ReadOnly Property NOM_SUBFAMILIA As String
        Get
            NOM_SUBFAMILIA = iNOM_SFAM
        End Get
    End Property

    Public Property ID_CUARTO As Integer
        Get
            ID_CUARTO = iID_CUARTO
        End Get
        Set(value As Integer)
            iID_CUARTO = value
        End Set
    End Property

    Public ReadOnly Property NOM_CUARTO As String
        Get
            NOM_CUARTO = iNOM_CUARTO
        End Get
    End Property

    Public Property ID_REF As Integer
        Get
            ID_REF = iID_REF
        End Get
        Set(value As Integer)
            iID_REF = value
        End Set
    End Property

    Public ReadOnly Property NOM_REFRIGERACION As String
        Get
            NOM_REFRIGERACION = iNOM_REF
        End Get
    End Property

    Public Property ID_CEXP As Integer
        Get
            ID_CEXP = iID_CEXP
        End Get
        Set(value As Integer)
            iID_CEXP = value
        End Set
    End Property

    Public ReadOnly Property NOM_CLASIF_EXP As String
        Get
            NOM_CLASIF_EXP = iNOM_CEXP
        End Get
    End Property

    Public ReadOnly Property ESTATUS As String
        Get
            ESTATUS = iESTATUS
        End Get
    End Property

    Public Property ID_CTE As Integer
        Get
            ID_CTE = iID_CTE
        End Get
        Set(value As Integer)
            iID_CTE = value
        End Set
    End Property

    Public ReadOnly Property MARCA_CTE As String
        Get
            MARCA_CTE = iMARCA_CTE
        End Get
    End Property

    Public ReadOnly Property NOMBRE_CTE As String
        Get
            NOMBRE_CTE = iNOMBRE_CTE
        End Get
    End Property

    Public Property ID_PROD_CTE As String
        Get
            ID_PROD_CTE = iID_PROD_CTE
        End Get
        Set(value As String)
            iID_PROD_CTE = value
        End Set
    End Property
    Public Property PROD_PADRE As String
        Get
            PROD_PADRE = iID_PROD_CTE_PADRE
        End Get
        Set(value As String)
            iID_PROD_CTE_PADRE = value
        End Set
    End Property

    Public Property NOMBRE_PROD_CTE As String
        Get
            NOMBRE_PROD_CTE = iNOMBRE_PROD_CTE
        End Get
        Set(value As String)
            iNOMBRE_PROD_CTE = value
        End Set
    End Property

    Public ReadOnly Property ESTATUS_PROD_CTE As String
        Get
            ESTATUS_PROD_CTE = iESTATUS_PROD_CTE
        End Get
    End Property
    Public Property PROD_MP As Boolean
        Get
            PROD_MP = iPROD_MP
        End Get
        Set(value As Boolean)
            iPROD_MP = value
        End Set
    End Property
End Class
