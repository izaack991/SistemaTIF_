Public Class clsInfEtiqueta
    Dim iID_ETIQ As Integer
    Dim iDESCRIPCION As String
    Dim iLOTE As String
    Dim iFECHA_PRODUCCION As String
    Dim iFECHA_CADUCIDAD As String
    Dim iPRODUCTO As String
    Dim iTIF As String
    Dim iPESO_NETO As String
    Dim iPIEZAS As String
    Dim iPESO_BRUTO As String
    Dim iKGS As String
    Dim iLBS As String
    Dim iTARA As String
    Dim iELABORADO_POR As String
    Dim iELABORADO_PARA As String
    Dim iINSPECCIONADO_TIF As String
    Dim iCARNE_FRESCA As String
    Dim iCARNE_CONGELADA As String
    Dim iINDICACION_TEMPERATURA As String
    Dim iINDICACION_TEMPERATURA_CONGELADA As String
    Dim iORIGEN_PRODUCTO As String
    Dim iCONTENIDO_PRODUCTO As String
    Dim iSHIPPINGMARK As String
    Dim iGENERAL_01 As String
    Dim iGENERAL_02 As String
    Dim iGENERAL_03 As String
    Dim iGENERAL_04 As String
    Dim iVACIO As String
    Dim iCONSECUTIVO_MANUAL As Integer


    Public Sub New(ByVal aID_Etiqueta As Integer, aTipo_Etiqueta As Integer)
        Try
            Dim lCommand As New SqlClient.SqlCommand
            Dim lSql As String
            Dim lDR As SqlClient.SqlDataReader

            lSql = "EXECUTE SP_CONS_INF_ETIQUETAS '" & aID_Etiqueta & "', " & aTipo_Etiqueta

            lCommand.Connection = Cnn
            lCommand.CommandType = CommandType.Text
            lCommand.CommandText = lSql

            lDR = lCommand.ExecuteReader

            If lDR.HasRows() Then

                lDR.Read()

                iID_ETIQ = lDR("ID_ETIQ")
                iDESCRIPCION = lDR("DESCRIPCION")
                iLOTE = lDR("LOTE")
                iFECHA_PRODUCCION = lDR("FECHA_PRODUCCION")
                iFECHA_CADUCIDAD = lDR("FECHA_CADUCIDAD")
                iPRODUCTO = lDR("PRODUCTO")
                iTIF = lDR("TIF")
                iPESO_NETO = lDR("PESO_NETO")
                iPIEZAS = lDR("PIEZAS")
                iPESO_BRUTO = lDR("PESO_BRUTO")
                iKGS = lDR("KGS")
                iLBS = lDR("LBS")
                iTARA = lDR("TARA")
                iELABORADO_POR = lDR("ELABORADO_POR")
                iELABORADO_PARA = lDR("ELABORADO_PARA")
                iINSPECCIONADO_TIF = lDR("INSPECCIONADO_TIF")
                iCARNE_FRESCA = lDR("CARNE_FRESCA")
                iCARNE_CONGELADA = lDR("CARNE_CONGELADA")
                iINDICACION_TEMPERATURA = lDR("INDICACION_TEMPERATURA")
                iINDICACION_TEMPERATURA_CONGELADA = lDR("INDICACION_TEMPERATURA_CONGELADA")
                iORIGEN_PRODUCTO = lDR("ORIGEN_PRODUCTO")
                iCONTENIDO_PRODUCTO = lDR("CONTENIDO_PRODUCTO")
                iSHIPPINGMARK = lDR("SHIPPINGMARK")
                iGENERAL_01 = lDR("GENERAL_01")
                iGENERAL_02 = lDR("GENERAL_02")
                iGENERAL_03 = lDR("GENERAL_03")
                iGENERAL_04 = lDR("GENERAL_04")
                iVACIO = lDR("VACIO")
                iCONSECUTIVO_MANUAL = lDR("CONSECUTIVO_MANUAL")
            Else

                Call Me.Limpiar()

            End If

            lDR.Close()
            lCommand.Dispose()
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try

    End Sub

    Private Sub Limpiar()
        iID_ETIQ = 0
        iDESCRIPCION = ""
        iLOTE = ""
        iFECHA_PRODUCCION = ""
        iFECHA_CADUCIDAD = ""
        iPRODUCTO = ""
        iTIF = ""
        iPESO_NETO = ""
        iPIEZAS = ""
        iPESO_BRUTO = ""
        iKGS = ""
        iLBS = ""
        iTARA = ""
        iELABORADO_POR = ""
        iELABORADO_PARA = ""
        iINSPECCIONADO_TIF = ""
        iCARNE_FRESCA = ""
        iCARNE_CONGELADA = ""
        iINDICACION_TEMPERATURA = ""
        iINDICACION_TEMPERATURA_CONGELADA = ""
        iORIGEN_PRODUCTO = ""
        iCONTENIDO_PRODUCTO = ""
        iSHIPPINGMARK = ""
        iGENERAL_01 = ""
        iGENERAL_02 = ""
        iGENERAL_03 = ""
        iGENERAL_04 = ""
        iVACIO = ""
        iCONSECUTIVO_MANUAL = 0
    End Sub

    Public Function Actualiza_Consecutivo_Manual(ByVal aConsecutivo As Integer, ByRef aMensajeResultado As String) As Boolean
        'Dim lCmd As New SqlClient.SqlCommand

        'Dim lpReturn As New SqlClient.SqlParameter
        'Dim lpErrorSP As New SqlClient.SqlParameter
        'Dim lp1 As New SqlClient.SqlParameter
        'Dim lp2 As New SqlClient.SqlParameter


        'Try
        '    Actualiza_Consecutivo_Manual = False

        '    lCmd.Connection = Cnn
        '    lCmd.CommandText = "SP_ABC_CONSECUTIVO_ETIQUETA_MANUAL"
        '    lCmd.CommandType = CommandType.StoredProcedure


        '    'PROCEDURE SP_ABC_CONSECUTIVO_ETIQUETA_MANUAL
        '    '@ERRORSP    	VARCHAR(8000) OUTPUT,  --INDICADOR DE ERROR (VACIO = OK)
        '    '@ID_ETIQUETA	INT,
        '    '@CONSECUTIVO	INT

        '    lpReturn = lCmd.Parameters.Add("Return", SqlDbType.Int)
        '    lpReturn.Direction = ParameterDirection.ReturnValue
        '    lp1 = lCmd.Parameters.Add("ID_ETIQUETA", SqlDbType.Int)
        '    lp2 = lCmd.Parameters.Add("CONSECUTIVO", SqlDbType.Int)

        '    lpErrorSP = lCmd.Parameters.Add("ERRORSP", SqlDbType.VarChar, 8000)
        '    lpErrorSP.Direction = ParameterDirection.Output

        '    lp1.Value = iID_ETIQ
        '    lp2.Value = aConsecutivo

        '    'el control de la transaccion se realiza en el stored procdedure
        '    lCmd.ExecuteNonQuery()

        '    If lpReturn.Value = -1 Then 'Se produjo un error controlado desde el stored procedure
        '        aMensajeResultado = Trim(lpErrorSP.Value)
        '    Else
        '        aMensajeResultado = "La información se guardó correctamente."
        Actualiza_Consecutivo_Manual = True
        '    End If

        '    lCmd = Nothing

        'Catch ex As Exception
        '    Call modGeneral.ManejaExcepcion(ex)
        'End Try
    End Function

    Public Sub Consulta_Consecutivo_Etiqueta()
        'Try
        '    Dim lCommand As New SqlClient.SqlCommand
        '    Dim lSql As String
        '    Dim lDR As SqlClient.SqlDataReader
        '    lSql = "EXECUTE SP_CONSULTA_ETIQUETAS " & iID_ETIQ

        '    lCommand.Connection = Cnn
        '    lCommand.CommandType = CommandType.Text
        '    lCommand.CommandText = lSql

        '    lDR = lCommand.ExecuteReader

        '    If lDR.HasRows() Then

        '        lDR.Read()

        '        iConsecutivoEtiquetaManual = lDR("CONSECUTIVO_ETIQUETA")

        '    Else

        '        iConsecutivoEtiquetaManual = 0

        '    End If

        '    lDR.Close()
        '    lCommand.Dispose()

        'Catch ex As Exception
        '    Call modGeneral.ManejaExcepcion(ex)
        'Finally

        'End Try
    End Sub

    Public Property CONSECUTIVO_MANUAL() As Integer
        Get
            CONSECUTIVO_MANUAL = iCONSECUTIVO_MANUAL
        End Get
        Set(ByVal value As Integer)
            iCONSECUTIVO_MANUAL = value
        End Set
    End Property

    Public Property ID_ETQUETA() As Integer
        Get
            ID_ETQUETA = iID_ETIQ
        End Get
        Set(ByVal value As Integer)
            iID_ETIQ = value
        End Set
    End Property

    Public Property DESCRIPCION() As String
        Get
            DESCRIPCION = iDESCRIPCION
        End Get
        Set(ByVal value As String)
            iDESCRIPCION = value
        End Set
    End Property

    Public Property LOTE() As String
        Get
            LOTE = iLOTE
        End Get
        Set(ByVal value As String)
            iLOTE = value
        End Set
    End Property

    Public Property FECHA_PRODUCCION() As String
        Get
            FECHA_PRODUCCION = iFECHA_PRODUCCION
        End Get
        Set(ByVal value As String)
            iFECHA_PRODUCCION = value
        End Set
    End Property

    Public Property FECHA_CADUCIDAD() As String
        Get
            FECHA_CADUCIDAD = iFECHA_CADUCIDAD
        End Get
        Set(ByVal value As String)
            iFECHA_CADUCIDAD = value
        End Set
    End Property

    Public Property PRODUCTO() As String
        Get
            PRODUCTO = iPRODUCTO
        End Get
        Set(ByVal value As String)
            iPRODUCTO = value
        End Set
    End Property

    Public Property TIF() As String
        Get
            TIF = iTIF
        End Get
        Set(ByVal value As String)
            iTIF = value
        End Set
    End Property

    Public Property PESO_NETO() As String
        Get
            PESO_NETO = iPESO_NETO
        End Get
        Set(ByVal value As String)
            iPESO_NETO = value
        End Set
    End Property

    Public Property PIEZAS() As String
        Get
            PIEZAS = iPIEZAS
        End Get
        Set(ByVal value As String)
            iPIEZAS = value
        End Set
    End Property

    Public Property PESO_BRUTO() As String
        Get
            PESO_BRUTO = iPESO_BRUTO
        End Get
        Set(ByVal value As String)
            iPESO_BRUTO = value
        End Set
    End Property

    Public Property KGS() As String
        Get
            KGS = iKGS
        End Get
        Set(ByVal value As String)
            iKGS = value
        End Set
    End Property

    Public Property LBS() As String
        Get
            LBS = iLBS
        End Get
        Set(ByVal value As String)
            iLBS = value
        End Set
    End Property

    Public Property TARA() As String
        Get
            TARA = iTARA
        End Get
        Set(ByVal value As String)
            iTARA = value
        End Set
    End Property

    Public Property ELABORADO_POR() As String
        Get
            ELABORADO_POR = iELABORADO_POR
        End Get
        Set(ByVal value As String)
            iELABORADO_POR = value
        End Set
    End Property

    Public Property ELABORADO_PARA() As String
        Get
            ELABORADO_PARA = iELABORADO_PARA
        End Get
        Set(ByVal value As String)
            iELABORADO_PARA = value
        End Set
    End Property

    Public Property INSPECCIONADO_TIF() As String
        Get
            INSPECCIONADO_TIF = iINSPECCIONADO_TIF
        End Get
        Set(ByVal value As String)
            iINSPECCIONADO_TIF = value
        End Set
    End Property

    Public Property CARNE_FRESCA() As String
        Get
            CARNE_FRESCA = iCARNE_FRESCA
        End Get
        Set(ByVal value As String)
            iCARNE_FRESCA = value
        End Set
    End Property

    Public Property CARNE_CONGELADA() As String
        Get
            CARNE_CONGELADA = iCARNE_CONGELADA
        End Get
        Set(ByVal value As String)
            iCARNE_CONGELADA = value
        End Set
    End Property

    Public Property INDICACION_TEMPERATURA() As String
        Get
            INDICACION_TEMPERATURA = iINDICACION_TEMPERATURA
        End Get
        Set(ByVal value As String)
            iINDICACION_TEMPERATURA = value
        End Set
    End Property

    Public Property ORIGEN_PRODUCTO() As String
        Get
            ORIGEN_PRODUCTO = iORIGEN_PRODUCTO
        End Get
        Set(ByVal value As String)
            iORIGEN_PRODUCTO = value
        End Set
    End Property

    Public Property CONTENIDO_PRODUCTO() As String
        Get
            CONTENIDO_PRODUCTO = iCONTENIDO_PRODUCTO
        End Get
        Set(ByVal value As String)
            iCONTENIDO_PRODUCTO = value
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

    Public ReadOnly Property VACIO() As String
        Get
            VACIO = iVACIO
        End Get
    End Property

End Class
