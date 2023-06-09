Imports System.Data.SqlClient

Public Class clsMovimientoEntSal
    Dim iOPERACION As String
    Dim iID_ESC As Integer
    Dim iID_MOV As Integer
    Dim iNOM_MOV As String
    Dim iID_ALM As Integer
    Dim iNOM_ALM As String
    Dim iFOLIO As Integer
    Dim iID_CTE_PROD As Integer
    Dim iMARCA_CTE_PROD As String
    Dim iNOM_CTE_PROD As String
    Dim iID_CTE_INTR As String
    Dim iMARCA_CTE_INTR  As String
    Dim iNOM_CTE_INTR As String
    Dim iID_CTE_DEST As String
    Dim iMARCA_CTE_DEST As String
    Dim iNOM_CTE_DEST As String
    Dim iFECHA As String
    Dim iREF_FOLIO_ENT As Integer
    Dim iREF_FOLIO_SAL As Integer
    Dim iSAC_LOTE As Integer
    Dim iID_CORTE As Integer
    Dim iCOR_LOTE As Integer
    Dim iOBSERVACIONES As String
    Dim iFECHA_MOD As String
    Dim iFECHA_CANC As String
    Dim iUSUARIO As Integer
    Dim iUSUARIO_CANC As Integer
    Dim iID_ESC_REF As Integer
    Dim iESTATUS As String
    Dim iID_ESD As Long
    Dim iID_CTE_DET As String
    Dim iMARCA_CTE_DET As String
    Dim iNOM_CTE_DET As String
    Dim iID_PROD As String
    Dim iNOM_PRODUCTO As String
    Dim iPIEZAS As Integer
    Dim iPESO As Decimal
    Dim iTARA As Decimal
    Dim iFECHA_ESD As String
    Dim iHORA_ESD As String
    Dim iDIAS_CADUCIDAD As Integer
    Dim iFECHA_CADUCIDAD As String
    Dim iSAC_SERIE As String
    Dim iSAC_ID As Integer
    Dim iSAC_LADO As Integer
    Dim iSAC_SEXO As String
    Dim iSAC_CONSECUTIVO As Integer
    Dim iSAC_MAYOR As Integer
    Dim iSAC_VACIADA As Integer
    Dim iSAC_INGESTA As Integer
    Dim iSAC_ENMANTADO As Integer
    Dim iPIEL_ARETE_CAMPAÑA As String
    Dim iPIEL_ARETE_SAGARPA As String
    Dim iPIEL_ARETE_INTRODUCTOR As String
    Dim iDECOMISO As Integer
    Dim iOBSERVACIONES_ESD As String
    Dim iID_ESD_REF As Long
    Dim iESTATUS_ESD As String
    Dim iPROCESADO As String
    Dim iSAC_SERIE_ID As String
    Dim iSAC_CODBAR As String
    Dim dTEMPERATURA As String
    '-----------------------------------
    Dim iCAJA_SERIE As String
    Dim iCAJA_ID As Integer
    Dim iCAJA_SERIE_ID As String
    Dim iCAJA_FECHA_ETIQ As String
    Dim iID_PRODCTE As String
    Dim iNOMBRE_PRODCTE As String
    Dim iCAJA_CODBAR As String
    Dim iLBS As Decimal
    '-----------------------------------
    Dim bREV_CALIDAD As Boolean
    Dim bSOSPECHOSO As Boolean
    Public Sub New()
        Me.InicializaValores()
    End Sub

    Public Sub New(aID_ESC As Integer, Optional ByVal aID_ESD As Long = 0)
        Dim lSql As String = ""

        If aID_ESC <> 0 Then
            lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO " & aID_ESC.ToString
        ElseIf aID_ESD <> 0 Then
            lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO 0, 0, 0, 0, " & aID_ESD.ToString
        End If

        Me.CargaDatos(lSql)

    End Sub

    Public Sub New(aID_ALM As Integer, aTIPO_OPERACION As Integer, aFOLIO As Integer)
        Dim lSql As String

        lSql = "EXECUTE SP_CONS_ENTSAL_X_MOVTO 0, " & aID_ALM.ToString & ", " & aTIPO_OPERACION.ToString & ", " & aFOLIO.ToString

        Me.CargaDatos(lSql)
    End Sub

    Public Sub New(aTipo As Integer, aSerieID As String)
        Dim lSql As String

        Select Case aTipo
            Case 91, 92
                lSql = "EXECUTE SP_CONS_SERIE_ID_ORIGEN " & aTipo & ", '" & aSerieID & "'"
            Case Else
                lSql = "EXECUTE SP_CONS_ENTSAL_X_SERIE_ID " & aTipo & ", '" & aSerieID & "'"
        End Select

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
                iID_ESC = dt.Rows(0)("ID_ESC")

                iID_MOV = dt.Rows(0)("ID_MOV")
                iNOM_MOV = dt.Rows(0)("NOM_MOV")

                iID_ALM = dt.Rows(0)("ID_ALM")
                iNOM_ALM = dt.Rows(0)("NOM_ALM")

                iFOLIO = dt.Rows(0)("FOLIO")

                iID_CTE_PROD = dt.Rows(0)("ID_CTE_PROD")
                iMARCA_CTE_PROD = dt.Rows(0)("MARCA_CTE_PROD")
                iNOM_CTE_PROD = dt.Rows(0)("NOM_CTE_PROD")

                iID_CTE_INTR = dt.Rows(0)("ID_CTE_INTR")
                iMARCA_CTE_INTR = dt.Rows(0)("MARCA_CTE_INTR")
                iNOM_CTE_INTR = dt.Rows(0)("NOM_CTE_INTR")

                iID_CTE_DEST = dt.Rows(0)("ID_CTE_DEST")
                iMARCA_CTE_DEST = dt.Rows(0)("MARCA_CTE_DEST")
                iNOM_CTE_DEST = dt.Rows(0)("NOM_CTE_DEST")

                iFECHA = dt.Rows(0)("FECHA")
                iREF_FOLIO_ENT = dt.Rows(0)("REF_FOLIO_ENT")
                iREF_FOLIO_SAL = dt.Rows(0)("REF_FOLIO_SAL")
                iSAC_LOTE = dt.Rows(0)("SAC_LOTE")
                iID_CORTE = dt.Rows(0)("ID_CORTE")
                iCOR_LOTE = dt.Rows(0)("COR_LOTE")
                iOBSERVACIONES = dt.Rows(0)("OBSERVACIONES")
                iFECHA_MOD = dt.Rows(0)("FECHA_MOD")
                iFECHA_CANC = dt.Rows(0)("FECHA_CANC")
                iUSUARIO = dt.Rows(0)("USUARIO")
                iUSUARIO_CANC = dt.Rows(0)("USUARIO_CANC")
                iID_ESC_REF = dt.Rows(0)("ID_ESC_REF")
                iESTATUS = dt.Rows(0)("ESTATUS")
                iID_ESD = dt.Rows(0)("ID_ESD")

                iID_CTE_DET = dt.Rows(0)("ID_CTE_DET")
                iMARCA_CTE_DET = dt.Rows(0)("MARCA_CTE_DET")
                iNOM_CTE_DET = dt.Rows(0)("NOM_CTE_DET")

                iID_PROD = dt.Rows(0)("ID_PROD")
                iNOM_PRODUCTO = dt.Rows(0)("NOM_PROD")
                iPIEZAS = dt.Rows(0)("PIEZAS")
                iPESO = dt.Rows(0)("PESO")
                iTARA = dt.Rows(0)("TARA")
                iLBS = dt.Rows(0)("LBS")
                iFECHA_ESD = dt.Rows(0)("FECHA_ESD")
                iHORA_ESD = dt.Rows(0)("HORA_ESD")
                iSAC_SERIE = dt.Rows(0)("SAC_SERIE")
                iSAC_ID = dt.Rows(0)("SAC_ID")
                iSAC_LADO = dt.Rows(0)("SAC_LADO")
                iSAC_SEXO = dt.Rows(0)("SAC_SEXO")
                iSAC_CONSECUTIVO = dt.Rows(0)("SAC_CONSEC")
                iSAC_MAYOR = dt.Rows(0)("SAC_MAYOR")
                iSAC_VACIADA = dt.Rows(0)("SAC_VACIADA")
                iSAC_ENMANTADO = dt.Rows(0)("SAC_ENMANTADO")
                iPIEL_ARETE_CAMPAÑA = dt.Rows(0)("PIEL_ARETE_CAMPANA")
                iPIEL_ARETE_SAGARPA = dt.Rows(0)("PIEL_ARETE_SAGARPA")
                iPIEL_ARETE_INTRODUCTOR = dt.Rows(0)("PIEL_ARETE_INTRODUCTOR")
                iDECOMISO = dt.Rows(0)("DECOMISO")
                iOBSERVACIONES_ESD = (dt.Rows(0)("OBSERVACIONES_ESD"))
                iID_ESD_REF = dt.Rows(0)("ID_ESD_REF")
                iESTATUS_ESD = dt.Rows(0)("ESTATUS_ESD")
                iPROCESADO = dt.Rows(0)("PROCESADO")
                iSAC_SERIE_ID = dt.Rows(0)("SAC_SERIE_ID")
                iSAC_CODBAR = dt.Rows(0)("SAC_CODBAR")
                dTEMPERATURA = dt.Rows(0)("TEMPERATURA")
                '''''''''''''''''''''''''''''''''''''''''
                iDIAS_CADUCIDAD = dt.Rows(0)("DIAS_CADUCIDAD")
                iFECHA_CADUCIDAD = dt.Rows(0)("FECHA_CADUCIDAD")
                iCAJA_SERIE = dt.Rows(0)("CAJA_SERIE")
                iCAJA_ID = dt.Rows(0)("CAJA_ID")
                iCAJA_SERIE_ID = dt.Rows(0)("CAJA_SERIE_ID")
                iCAJA_FECHA_ETIQ = dt.Rows(0)("CAJA_FECHA_ETIQ")
                iID_PRODCTE = dt.Rows(0)("ID_PRODCTE")
                iNOMBRE_PRODCTE = dt.Rows(0)("NOMBRE_PRODCTE")
                iCAJA_CODBAR = dt.Rows(0)("CAJA_CODBAR")
                iSAC_INGESTA = dt.Rows(0)("SAC_INGESTA")
                bREV_CALIDAD = dt.Rows(0)("REV_CALIDAD")
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
        iID_ESC = 0
        iID_MOV = 0
        iNOM_MOV = ""
        iID_ALM = 0
        iNOM_ALM = ""
        iFOLIO = 0
        iID_CTE_PROD = 0
        iMARCA_CTE_PROD = ""
        iNOM_CTE_PROD = ""
        iID_CTE_INTR = 0
        iMARCA_CTE_INTR = ""
        iNOM_CTE_INTR = ""
        iFECHA = ""
        iREF_FOLIO_ENT = 0
        iREF_FOLIO_SAL = 0
        ' iSAC_LOTE = 0
        iID_CORTE = 0
        iCOR_LOTE = 0
        iOBSERVACIONES = ""
        iFECHA_MOD = ""
        iFECHA_CANC = ""
        iUSUARIO = 0
        iUSUARIO_CANC = 0
        iID_ESC_REF = 0
        iESTATUS = ""
        iID_ESD = 0
        iID_CTE_DET = 0
        iMARCA_CTE_DEST = ""
        iNOM_CTE_DEST = ""
        iID_PROD = ""
        iNOM_PRODUCTO = ""
        iPIEZAS = 0
        iPESO = 0
        iTARA = 0
        iLBS = 0
        iFECHA_ESD = ""
        iHORA_ESD = ""
        iSAC_SERIE = ""
        iSAC_ID = 0
        iSAC_LADO = 0
        iSAC_SEXO = ""
        iSAC_CONSECUTIVO = 0
        iSAC_MAYOR = 0
        iSAC_VACIADA = 0
        iSAC_INGESTA = 0
        iSAC_ENMANTADO = 0
        iPIEL_ARETE_CAMPAÑA = ""
        iPIEL_ARETE_SAGARPA = ""
        iPIEL_ARETE_INTRODUCTOR = ""
        iDECOMISO = 0
        iOBSERVACIONES_ESD = ""
        iID_ESD_REF = 0
        iESTATUS_ESD = ""
        iPROCESADO = ""
        iSAC_SERIE_ID = ""
        iSAC_CODBAR = ""
        dTEMPERATURA = 0.0
        iDIAS_CADUCIDAD = 0
        iFECHA_CADUCIDAD = ""

        iCAJA_SERIE = ""
        iCAJA_ID = 0
        iCAJA_SERIE_ID = ""
        iCAJA_FECHA_ETIQ = ""
        iID_PRODCTE = ""
        iNOMBRE_PRODCTE = ""
        iCAJA_CODBAR = ""
        bREV_CALIDAD = False
    End Sub

    Public Function Guardar(ByRef aMensajeResultado As String, Optional ByRef aFolio As Integer = 0, Optional ByRef aMovto As clsMovimientoEntSal = Nothing) As Boolean
        Dim lCmd As New SqlClient.SqlCommand
        Dim lp0 As New SqlClient.SqlParameter
        Dim lp1 As New SqlClient.SqlParameter
        Dim lp2 As New SqlClient.SqlParameter
        Dim lp3 As New SqlClient.SqlParameter
        Dim lp4 As New SqlClient.SqlParameter
        Dim lp5 As New SqlClient.SqlParameter
        Dim lp6 As New SqlClient.SqlParameter
        Dim lp7 As New SqlClient.SqlParameter
        Dim lp7_2 As New SqlClient.SqlParameter
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
        Dim lp39 As New SqlClient.SqlParameter
        Dim lp40 As New SqlClient.SqlParameter
        Dim lp40_2 As New SqlClient.SqlParameter
        Dim lpFoliogenerado As New SqlClient.SqlParameter
        Dim lpFolioDetgenerado As New SqlClient.SqlParameter
        Dim lpSAC_SERIE As New SqlClient.SqlParameter
        Dim lpSAC_ID As New SqlClient.SqlParameter
        Dim lpErrorSP As New SqlClient.SqlParameter
        Dim lp41 As New SqlClient.SqlParameter
        Dim lp42 As New SqlClient.SqlParameter
        Dim lp43 As New SqlClient.SqlParameter
        Dim lp44 As New SqlClient.SqlParameter
        Try

            Guardar = False

            lCmd.Connection = Cnn
            lCmd.CommandText = "SP_ABC_ENTSAL"
            lCmd.CommandType = CommandType.StoredProcedure

            'CREATE PROCEDURE SP_ABC_ENTSAL


            lp0 = lCmd.Parameters.Add("Return", SqlDbType.Int)
            lp0.Direction = ParameterDirection.ReturnValue

            lp1 = lCmd.Parameters.Add("OPERACION", SqlDbType.Char, 1)
            lp2 = lCmd.Parameters.Add("ID_ESC", SqlDbType.Int)
            lp3 = lCmd.Parameters.Add("ID_MOV", SqlDbType.Int)
            lp4 = lCmd.Parameters.Add("ID_ALM", SqlDbType.Int)
            lp5 = lCmd.Parameters.Add("FOLIO", SqlDbType.Int)
            lp6 = lCmd.Parameters.Add("ID_CTE_PROD", SqlDbType.Int)
            lp7 = lCmd.Parameters.Add("ID_CTE_INTR", SqlDbType.Int)
            lp7_2 = lCmd.Parameters.Add("ID_CTE_DEST", SqlDbType.Int)
            lp8 = lCmd.Parameters.Add("FECHA", SqlDbType.VarChar, 10)
            lp9 = lCmd.Parameters.Add("REF_FOLIO_ENT", SqlDbType.Int)
            lp10 = lCmd.Parameters.Add("REF_FOLIO_SAL", SqlDbType.Int)
            lp11 = lCmd.Parameters.Add("SAC_LOTE", SqlDbType.Int)
            lp40 = lCmd.Parameters.Add("COR_LOTE", SqlDbType.Int)
            lp40_2 = lCmd.Parameters.Add("ID_CORTE", SqlDbType.Int)
            lp12 = lCmd.Parameters.Add("OBSERVACIONES", SqlDbType.VarChar, 200)
            lp13 = lCmd.Parameters.Add("FECHA_MOD", SqlDbType.VarChar, 10)
            lp14 = lCmd.Parameters.Add("FECHA_CANC", SqlDbType.VarChar, 10)
            lp15 = lCmd.Parameters.Add("USUARIO", SqlDbType.Int)
            lp16 = lCmd.Parameters.Add("USUARIO_CANC", SqlDbType.Int)
            lp17 = lCmd.Parameters.Add("ID_ESC_REF", SqlDbType.Int)
            lp18 = lCmd.Parameters.Add("ESTATUS", SqlDbType.Char, 1)
            lp19 = lCmd.Parameters.Add("ID_ESD", SqlDbType.BigInt)
            lp20 = lCmd.Parameters.Add("ID_CTE_DET", SqlDbType.Int)
            lp21 = lCmd.Parameters.Add("ID_PROD", SqlDbType.VarChar, 6)
            lp22 = lCmd.Parameters.Add("PIEZAS", SqlDbType.Int)
            lp23 = lCmd.Parameters.Add("PESO", SqlDbType.Decimal, 8, 2)
            lp24 = lCmd.Parameters.Add("TARA", SqlDbType.Decimal, 8, 2)
            lp25 = lCmd.Parameters.Add("FECHA_ESD", SqlDbType.VarChar, 10)
            lp26 = lCmd.Parameters.Add("SAC_SERIE", SqlDbType.Char, 1)
            lp27 = lCmd.Parameters.Add("SAC_ID", SqlDbType.VarChar, 5)
            lp28 = lCmd.Parameters.Add("SAC_LADO", SqlDbType.Int)
            lp29 = lCmd.Parameters.Add("SAC_SEXO", SqlDbType.Char, 1)
            lp30 = lCmd.Parameters.Add("SAC_MAYOR", SqlDbType.Int)
            lp31 = lCmd.Parameters.Add("SAC_VACIADA", SqlDbType.Int)
            lp32 = lCmd.Parameters.Add("SAC_ENMANTADO", SqlDbType.Int)
            lp33 = lCmd.Parameters.Add("OBSERVACIONES_ESD", SqlDbType.VarChar, 200)
            lp34 = lCmd.Parameters.Add("ID_ESD_REF", SqlDbType.BigInt)
            lp35 = lCmd.Parameters.Add("ESTATUS_ESD", SqlDbType.Char, 1)
            lp36 = lCmd.Parameters.Add("PIEL_ARETE_CAMPANA", SqlDbType.VarChar, 15)
            lp37 = lCmd.Parameters.Add("PIEL_ARETE_SAGARPA", SqlDbType.VarChar, 15)
            lp38 = lCmd.Parameters.Add("PIEL_ARETE_INTRODUCTOR", SqlDbType.VarChar, 15)
            lp39 = lCmd.Parameters.Add("DECOMISO", SqlDbType.Int)
            lp41 = lCmd.Parameters.Add("TEMPERATURA", SqlDbType.VarChar)
            lp32 = lCmd.Parameters.Add("SAC_INGESTA", SqlDbType.Int)
            lp43 = lCmd.Parameters.Add("CAJA_ID", SqlDbType.Int)
            lp44 = lCmd.Parameters.Add("SOSPECHOSO", SqlDbType.Bit)
            lpSAC_SERIE = lCmd.Parameters.Add("@SAC_SERIE_AUX", SqlDbType.Char, 1)
            lpSAC_SERIE.Direction = ParameterDirection.Output

            lpSAC_ID = lCmd.Parameters.Add("@SAC_ID_AUX", SqlDbType.Int)
            lpSAC_ID.Direction = ParameterDirection.Output

            lpFoliogenerado = lCmd.Parameters.Add("@ID_GENERADO", SqlDbType.VarChar, 13)
            lpFoliogenerado.Direction = ParameterDirection.Output

            lpFolioDetgenerado = lCmd.Parameters.Add("@ID_ESD_GENERADO", SqlDbType.BigInt)
            lpFolioDetgenerado.Direction = ParameterDirection.Output

            lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 300)
            lpErrorSP.Direction = ParameterDirection.Output


            lp1.Value = iOPERACION
            lp2.Value = iID_ESC
            lp3.Value = iID_MOV
            lp4.Value = iID_ALM
            lp5.Value = iFOLIO
            lp6.Value = iID_CTE_PROD
            lp7.Value = iID_CTE_INTR
            lp7_2.Value = iID_CTE_DEST
            lp8.Value = iFECHA
            lp9.Value = iREF_FOLIO_ENT
            lp10.Value = iREF_FOLIO_SAL
            lp11.Value = iSAC_LOTE
            lp40.Value = iCOR_LOTE
            lp40_2.Value = iID_CORTE
            lp12.Value = iOBSERVACIONES
            lp13.Value = iFECHA_MOD
            lp14.Value = iFECHA_CANC
            lp15.Value = iUSUARIO
            lp16.Value = iUSUARIO_CANC
            lp17.Value = iID_ESC_REF
            lp18.Value = iESTATUS
            lp19.Value = iID_ESD
            lp20.Value = iID_CTE_DET
            lp21.Value = iID_PROD
            lp22.Value = iPIEZAS
            lp23.Value = iPESO
            lp24.Value = iTARA
            lp25.Value = iFECHA_ESD
            lp26.Value = iSAC_SERIE
            lp27.Value = iSAC_ID
            lp28.Value = iSAC_LADO
            lp29.Value = iSAC_SEXO
            lp30.Value = iSAC_MAYOR
            lp31.Value = iSAC_VACIADA
            lp32.Value = iSAC_ENMANTADO
            lp33.Value = iOBSERVACIONES_ESD
            lp34.Value = iID_ESD_REF
            lp35.Value = iESTATUS_ESD
            lp36.Value = iPIEL_ARETE_CAMPAÑA
            lp37.Value = iPIEL_ARETE_SAGARPA
            lp38.Value = iPIEL_ARETE_INTRODUCTOR
            lp39.Value = iDECOMISO
            lp41.Value = dTEMPERATURA
            lp42.Value = iSAC_INGESTA
            lp43.Value = iCAJA_ID
            lp44.Value = bSOSPECHOSO
            'el control de la transaccion se realiza en el stored procdedure
            lCmd.ExecuteNonQuery()

            If lp0.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
                'MsgBox(Trim(lp25.Value), MsgBoxStyle.Exclamation, gsProyecto)
                aMensajeResultado = Trim(lpErrorSP.Value)
                Guardar = False
            Else
                aMensajeResultado = "La información se guardó correctamente."
                aFolio = lpFoliogenerado.Value
                If Not IsDBNull(lpSAC_SERIE.Value) Then
                    If lpSAC_SERIE.Value <> "0" Then
                        iSAC_SERIE = lpSAC_SERIE.Value
                        iSAC_ID = lpSAC_ID.Value
                        If iOPERACION = "A" Then
                            iID_ESD = lpFolioDetgenerado.Value
                        End If
                    End If
                End If
            End If
            Guardar = True

            lCmd = Nothing

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Function ID_x_ENTRADA_LOTE_MOVIMIENTO() As Integer
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            'Dim lDR As SqlDataReader = Nothing
            Dim dt As New DataTable()
            Dim lID_ESC As Integer

            lSql = "SELECT ID_ESC = DBO.FN_ID_ENTRADA_LOTE_MOVIMIENTO('" & iFECHA & "', " & iSAC_LOTE & ", " & iID_MOV & ", " & iID_ALM & ")"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                lID_ESC = dt.Rows(0)("ID_ESC")
            Else
                lID_ESC = 0
            End If

            Return lID_ESC
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

    Public Property ID_ESC As Integer
        Get
            ID_ESC = iID_ESC
        End Get
        Set(value As Integer)
            iID_ESC = value
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

    Public Property FOLIO As Integer
        Get
            FOLIO = iFOLIO
        End Get
        Set(value As Integer)
            iFOLIO = value
        End Set
    End Property

    Public Property ID_CTE_PROD As Integer
        Get
            ID_CTE_PROD = iID_CTE_PROD
        End Get
        Set(value As Integer)
            iID_CTE_PROD = value
        End Set
    End Property

    Public ReadOnly Property MARCA_PRODUCTOR As String
        Get
            MARCA_PRODUCTOR = iMARCA_CTE_PROD
        End Get
    End Property

    Public ReadOnly Property NOMBRE_PRODUCTOR As String
        Get
            NOMBRE_PRODUCTOR = iNOM_CTE_PROD
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

    Public ReadOnly Property MARCA_INTRODUCTOR As String
        Get
            MARCA_INTRODUCTOR = iMARCA_CTE_INTR
        End Get
    End Property

    Public ReadOnly Property NOMBRE_INTRODUCTOR As String
        Get
            NOMBRE_INTRODUCTOR = iNOM_CTE_INTR
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

    Public ReadOnly Property MARCA_DESTINO As String
        Get
            MARCA_DESTINO = iMARCA_CTE_DEST
        End Get
    End Property

    Public ReadOnly Property NOMBRE_DESTINO As String
        Get
            NOMBRE_DESTINO = iNOM_CTE_DEST
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

    Public Property REF_FOLIO_ENT As Integer
        Get
            REF_FOLIO_ENT = iREF_FOLIO_ENT
        End Get
        Set(value As Integer)
            iREF_FOLIO_ENT = value
        End Set
    End Property

    Public Property REF_FOLIO_SAL As Integer
        Get
            REF_FOLIO_SAL = iREF_FOLIO_SAL
        End Get
        Set(value As Integer)
            iREF_FOLIO_SAL = value
        End Set
    End Property

    Public Property SAC_LOTE As Integer
        Get
            SAC_LOTE = iSAC_LOTE
        End Get
        Set(value As Integer)
            iSAC_LOTE = value
        End Set
    End Property

    Public Property ID_CORTE As Integer
        Get
            ID_CORTE = iID_CORTE
        End Get
        Set(value As Integer)
            iID_CORTE = value
        End Set
    End Property

    Public Property COR_LOTE As Integer
        Get
            COR_LOTE = iCOR_LOTE
        End Get
        Set(value As Integer)
            iCOR_LOTE = value
        End Set
    End Property

    Public Property SAC_CORTE As Integer
        Get
            SAC_CORTE = iCOR_LOTE
        End Get
        Set(value As Integer)
            iCOR_LOTE = value
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
      
    Public Property FECHA_MOD As String
        Get
            FECHA_MOD = iFECHA_MOD
        End Get
        Set(value As String)
            iFECHA_MOD = value
        End Set
    End Property

    Public Property FECHA_CANC As String
        Get
            FECHA_CANC = iFECHA_CANC
        End Get
        Set(value As String)
            iFECHA_CANC = value
        End Set
    End Property

    Public Property USUARIO As Integer
        Get
            USUARIO = iUSUARIO
        End Get
        Set(value As Integer)
            iUSUARIO = value
        End Set
    End Property

    Public Property USUARIO_CANC As Integer
        Get
            USUARIO_CANC = iUSUARIO_CANC
        End Get
        Set(value As Integer)
            iUSUARIO_CANC = value
        End Set
    End Property

    Public Property ID_ESC_REF As Integer
        Get
            ID_ESC_REF = iID_ESC_REF
        End Get
        Set(value As Integer)
            iID_ESC_REF = value
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

    Public Property ID_ESD As Integer
        Get
            ID_ESD = iID_ESD
        End Get
        Set(value As Integer)
            iID_ESD = value
        End Set
    End Property

    Public Property ID_CTE_DET As Integer
        Get
            ID_CTE_DET = iID_CTE_DET
        End Get
        Set(value As Integer)
            iID_CTE_DET = value
        End Set
    End Property

    Public ReadOnly Property MARCA_DESTINO_DET As String
        Get
            MARCA_DESTINO_DET = iMARCA_CTE_DET
        End Get
    End Property

    Public ReadOnly Property NOMBRE_DESTINO_DET As String
        Get
            NOMBRE_DESTINO_DET = iNOM_CTE_DET
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
            NOMBRE_PRODUCTO = iNOM_PRODUCTO
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

    Public ReadOnly Property LBS As Decimal
        Get
            LBS = iLBS
        End Get
    End Property

    Public Property TARA As Decimal
        Get
            TARA = iTARA
        End Get
        Set(value As Decimal)
            iTARA = value
        End Set
    End Property

    Public Property FECHA_ESD As String
        Get
            FECHA_ESD = iFECHA_ESD
        End Get
        Set(value As String)
            iFECHA_ESD = value
        End Set
    End Property

    Public Property HORA_ESD As String
        Get
            HORA_ESD = iHORA_ESD
        End Get
        Set(value As String)
            iHORA_ESD = value
        End Set
    End Property

    Public Property SAC_SERIE As String
        Get
            SAC_SERIE = iSAC_SERIE
        End Get
        Set(value As String)
            iSAC_SERIE = value
        End Set
    End Property

    Public Property SAC_ID As Integer
        Get
            SAC_ID = iSAC_ID
        End Get
        Set(value As Integer)
            iSAC_ID = value
        End Set
    End Property

    Public Property SAC_LADO As Integer
        Get
            SAC_LADO = iSAC_LADO
        End Get
        Set(value As Integer)
            iSAC_LADO = value
        End Set
    End Property

    Public Property SAC_SEXO As String
        Get
            SAC_SEXO = iSAC_SEXO
        End Get
        Set(value As String)
            iSAC_SEXO = value
        End Set
    End Property

    Public Property SAC_CONSECUTIVO As Integer
        Get
            SAC_CONSECUTIVO = iSAC_CONSECUTIVO
        End Get
        Set(value As Integer)
            iSAC_CONSECUTIVO = value
        End Set
    End Property

    Public Property SAC_MAYOR As Integer
        Get
            SAC_MAYOR = iSAC_MAYOR
        End Get
        Set(value As Integer)
            iSAC_MAYOR = value
        End Set
    End Property

    Public Property SAC_VACIADA As Integer
        Get
            SAC_VACIADA = iSAC_VACIADA
        End Get
        Set(value As Integer)
            iSAC_VACIADA = value
        End Set
    End Property
    Public Property SAC_INGESTA As Integer
        Get
            SAC_INGESTA = iSAC_INGESTA
        End Get
        Set(value As Integer)
            iSAC_INGESTA = value
        End Set
    End Property

    Public Property SAC_ENMANTADO As Integer
        Get
            SAC_ENMANTADO = iSAC_ENMANTADO
        End Get
        Set(value As Integer)
            iSAC_ENMANTADO = value
        End Set
    End Property
  
    Public Property PIEL_ARETE_CAMPAÑA As String
        Get
            PIEL_ARETE_CAMPAÑA = iPIEL_ARETE_CAMPAÑA
        End Get
        Set(value As String)
            iPIEL_ARETE_CAMPAÑA = value
        End Set
    End Property

    Public Property PIEL_ARETE_SAGARPA As String
        Get
            PIEL_ARETE_SAGARPA = iPIEL_ARETE_SAGARPA
        End Get
        Set(value As String)
            iPIEL_ARETE_SAGARPA = value
        End Set
    End Property

    Public Property PIEL_ARETE_INTRODUCTOR As String
        Get
            PIEL_ARETE_INTRODUCTOR = iPIEL_ARETE_INTRODUCTOR
        End Get
        Set(value As String)
            iPIEL_ARETE_INTRODUCTOR = value
        End Set
    End Property

    Public Property DECOMISO As Integer
        Get
            DECOMISO = iDECOMISO
        End Get
        Set(value As Integer)
            iDECOMISO = value
        End Set
    End Property

    Public Property OBSERVACIONES_ESD As String
        Get
            OBSERVACIONES_ESD = iOBSERVACIONES_ESD
        End Get
        Set(value As String)
            iOBSERVACIONES_ESD = value
        End Set
    End Property

    Public Property ID_ESD_REF As Integer
        Get
            ID_ESD_REF = iID_ESD_REF
        End Get
        Set(value As Integer)
            iID_ESD_REF = value
        End Set
    End Property

    Public Property ESTATUS_ESD As String
        Get
            ESTATUS_ESD = iESTATUS_ESD
        End Get
        Set(value As String)
            iESTATUS_ESD = value
        End Set
    End Property

    Public Property PROCESADO As String
        Get
            PROCESADO = iPROCESADO
        End Get
        Set(value As String)
            iPROCESADO = value
        End Set
    End Property

    Public ReadOnly Property SAC_SERIE_ID As String
        Get
            SAC_SERIE_ID = iSAC_SERIE_ID
        End Get
    End Property

    Public ReadOnly Property SAC_CODBAR As String
        Get
            SAC_CODBAR = iSAC_CODBAR
        End Get
    End Property


    Public ReadOnly Property DIAS_CADUCIDAD As Integer
        Get
            DIAS_CADUCIDAD = iDIAS_CADUCIDAD
        End Get
    End Property

    Public ReadOnly Property FECHA_CADUCIDAD As String
        Get
            FECHA_CADUCIDAD = iFECHA_CADUCIDAD
        End Get
    End Property

    Public Property CAJA_SERIE As String
        Get
            CAJA_SERIE = iCAJA_SERIE
        End Get
        Set(value As String)
            iCAJA_SERIE = value
        End Set
    End Property

    Public Property CAJA_ID As Integer
        Get
            CAJA_ID = iCAJA_ID
        End Get
        Set(value As Integer)
            iCAJA_ID = value
        End Set
    End Property

    Public ReadOnly Property CAJA_SERIE_ID As String
        Get
            CAJA_SERIE_ID = iCAJA_SERIE_ID
        End Get
    End Property

    Public Property CAJA_FECHA_ETIQ As String
        Get
            CAJA_FECHA_ETIQ = iCAJA_FECHA_ETIQ
        End Get
        Set(value As String)
            iCAJA_FECHA_ETIQ = value
        End Set
    End Property

    Public ReadOnly Property ID_PRODCTE As String
        Get
            ID_PRODCTE = iID_PRODCTE
        End Get
    End Property

    Public ReadOnly Property NOMBRE_PRODCTE As String
        Get
            NOMBRE_PRODCTE = iNOMBRE_PRODCTE
        End Get
    End Property

    Public ReadOnly Property CAJA_CODBAR As String
        Get
            CAJA_CODBAR = iCAJA_CODBAR
        End Get
    End Property
    Public Property TEMPERATURA As String
        Get
            TEMPERATURA = dTEMPERATURA
        End Get
        Set(value As String)
            dTEMPERATURA = value
        End Set
    End Property
    Public Property REV_CALIDAD As Boolean
        Get
            REV_CALIDAD = bREV_CALIDAD
        End Get
        Set(value As Boolean)
            bREV_CALIDAD = value
        End Set
    End Property
    Public Property SOSPECHOSO As Boolean
        Get
            SOSPECHOSO = bSOSPECHOSO
        End Get
        Set(value As Boolean)
            bSOSPECHOSO = value
        End Set
    End Property
End Class
