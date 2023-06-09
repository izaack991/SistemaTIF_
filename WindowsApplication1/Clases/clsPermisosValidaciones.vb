Public Class clsPermisosValidaciones
    Dim ioPesadaManual_EntradaVehiculos As clsParametros
    Dim ioPesadaManual_GanadoEnPie As clsParametros
    Dim ioPesadaManual_Pieles As clsParametros
    Dim ioPesadaManual_Canales As clsParametros
    Dim ioPesadaManual_ViscerasRojas As clsParametros
    Dim ioPesadaManual_ViscerasVerdes As clsParametros
    Dim ioPesadaManual_SalidaVisceras As clsParametros
    Dim ioPesadaManual_SalidaViscerasDecomiso As clsParametros
    Dim ioPesadaManual_SalidaPieles As clsParametros
    Dim ioPesadaManual_SalidaCanales As clsParametros
    Dim ioPesadaManual_SalaCortes As clsParametros
    Dim ioValidacion_LotesSinEntradaVehiculos As clsParametros

    Dim iPesadaManual_EntradaVehiculos As Boolean
    Dim iPesadaManual_GanadoEnPie As Boolean
    Dim iPesadaManual_Pieles As Boolean
    Dim iPesadaManual_Canales As Boolean
    Dim iPesadaManual_ViscerasRojas As Boolean
    Dim iPesadaManual_ViscerasVerdes As Boolean
    Dim iPesadaManual_SalidaVisceras As Boolean
    Dim iPesadaManual_SalidaViscerasDecomiso As Boolean
    Dim iPesadaManual_SalidaPieles As Boolean
    Dim iPesadaManual_SalidaCanales As Boolean
    Dim iPesadaManual_SalaCortes As Boolean
    Dim iValidacion_LotesSinEntradaVehiculos As Boolean

    Public Sub New()
        Try
            ioPesadaManual_EntradaVehiculos = New clsParametros(5)
            ioPesadaManual_GanadoEnPie = New clsParametros(6)
            ioPesadaManual_Pieles = New clsParametros(7)
            ioPesadaManual_Canales = New clsParametros(8)
            ioPesadaManual_ViscerasRojas = New clsParametros(9)
            ioPesadaManual_ViscerasVerdes = New clsParametros(10)
            ioPesadaManual_SalidaVisceras = New clsParametros(11)
            ioPesadaManual_SalidaViscerasDecomiso = New clsParametros(12)
            ioPesadaManual_SalidaPieles = New clsParametros(13)
            ioPesadaManual_SalidaCanales = New clsParametros(14)
            ioPesadaManual_SalaCortes = New clsParametros(15)
            ioValidacion_LotesSinEntradaVehiculos = New clsParametros(16)

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub
    Public Function Guardar() As Boolean
        Try
            Dim lMensajeResultado As String = ""

            ioPesadaManual_EntradaVehiculos.ENT1 = IIf(iPesadaManual_EntradaVehiculos, 1, 0)
            If Not ioPesadaManual_EntradaVehiculos.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual en Entrada de Vehiculos." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_GanadoEnPie.ENT1 = IIf(iPesadaManual_GanadoEnPie, 1, 0)
            If Not ioPesadaManual_GanadoEnPie.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual de Ganado en Pie." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_Pieles.ENT1 = IIf(iPesadaManual_Pieles, 1, 0)
            If Not ioPesadaManual_Pieles.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual de Pieles." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_Canales.ENT1 = IIf(iPesadaManual_Canales, 1, 0)
            If Not ioPesadaManual_Canales.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual de Canales." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_ViscerasRojas.ENT1 = IIf(iPesadaManual_ViscerasRojas, 1, 0)
            If Not ioPesadaManual_ViscerasRojas.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual de Visceras Rojas." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_ViscerasVerdes.ENT1 = IIf(iPesadaManual_ViscerasVerdes, 1, 0)
            If Not ioPesadaManual_ViscerasVerdes.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual de Visceras Verdes." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_SalidaVisceras.ENT1 = IIf(iPesadaManual_SalidaVisceras, 1, 0)
            If Not ioPesadaManual_SalidaVisceras.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual en Salida de Visceras." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_SalidaViscerasDecomiso.ENT1 = IIf(iPesadaManual_SalidaViscerasDecomiso, 1, 0)
            If Not ioPesadaManual_SalidaViscerasDecomiso.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual en Salidapor Decomiso de Visceras." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_SalidaPieles.ENT1 = IIf(iPesadaManual_SalidaPieles, 1, 0)
            If Not ioPesadaManual_SalidaPieles.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual en Salida de Visceras." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_SalidaCanales.ENT1 = IIf(iPesadaManual_SalidaCanales, 1, 0)
            If Not ioPesadaManual_SalidaCanales.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual en Salida de Canales." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioPesadaManual_SalaCortes.ENT1 = IIf(iPesadaManual_SalaCortes, 1, 0)
            If Not ioPesadaManual_SalaCortes.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar el permiso de Pesada Manual en Sala de Cortes." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ioValidacion_LotesSinEntradaVehiculos.ENT1 = IIf(iValidacion_LotesSinEntradaVehiculos, 1, 0)
            If Not ioValidacion_LotesSinEntradaVehiculos.Guardar("M", lMensajeResultado) Then
                MessageBox.Show("No se pudo actualizar la validación de capturar lotes sin registro en entrada de vehiculos." & vbNewLine & vbNewLine & _
                                "Intente de nuevo", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Return True
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function

    Public Property PesadaManual_EntradaVehiculos As Boolean
        Get
            ioPesadaManual_EntradaVehiculos = New clsParametros(5)
            iPesadaManual_EntradaVehiculos = IIf(ioPesadaManual_EntradaVehiculos.ENT1 = 0, False, True)
            PesadaManual_EntradaVehiculos = iPesadaManual_EntradaVehiculos
        End Get
        Set(value As Boolean)
            iPesadaManual_EntradaVehiculos = value
        End Set
    End Property

    Public Property PesadaManual_GanadoEnPie As Boolean
        Get
            ioPesadaManual_GanadoEnPie = New clsParametros(6)
            iPesadaManual_GanadoEnPie = IIf(ioPesadaManual_GanadoEnPie.ENT1 = 0, False, True)
            PesadaManual_GanadoEnPie = iPesadaManual_GanadoEnPie
        End Get
        Set(value As Boolean)
            iPesadaManual_GanadoEnPie = value
        End Set
    End Property

    Public Property PesadaManual_Pieles As Boolean
        Get
            ioPesadaManual_Pieles = New clsParametros(7)
            iPesadaManual_Pieles = IIf(ioPesadaManual_Pieles.ENT1 = 0, False, True)
            PesadaManual_Pieles = iPesadaManual_Pieles
        End Get
        Set(value As Boolean)
            iPesadaManual_Pieles = value
        End Set
    End Property

    Public Property PesadaManual_Canales As Boolean
        Get
            ioPesadaManual_Canales = New clsParametros(8)
            iPesadaManual_Canales = IIf(ioPesadaManual_Canales.ENT1 = 0, False, True)
            PesadaManual_Canales = iPesadaManual_Canales
        End Get
        Set(value As Boolean)
            iPesadaManual_Canales = value
        End Set
    End Property

    Public Property PesadaManual_ViscerasRojas As Boolean
        Get
            ioPesadaManual_ViscerasRojas = New clsParametros(9)
            iPesadaManual_ViscerasRojas = IIf(ioPesadaManual_ViscerasRojas.ENT1 = 0, False, True)
            PesadaManual_ViscerasRojas = iPesadaManual_ViscerasRojas
        End Get
        Set(value As Boolean)
            iPesadaManual_ViscerasRojas = value
        End Set
    End Property

    Public Property PesadaManual_ViscerasVerdes As Boolean
        Get
            ioPesadaManual_ViscerasVerdes = New clsParametros(10)
            iPesadaManual_ViscerasVerdes = IIf(ioPesadaManual_ViscerasVerdes.ENT1 = 0, False, True)
            PesadaManual_ViscerasVerdes = iPesadaManual_ViscerasVerdes
        End Get
        Set(value As Boolean)
            iPesadaManual_ViscerasVerdes = value
        End Set
    End Property

    Public Property PesadaManual_SalidaVisceras As Boolean
        Get
            ioPesadaManual_SalidaVisceras = New clsParametros(11)
            iPesadaManual_SalidaVisceras = IIf(ioPesadaManual_SalidaVisceras.ENT1 = 0, False, True)
            PesadaManual_SalidaVisceras = iPesadaManual_SalidaVisceras
        End Get
        Set(value As Boolean)
            iPesadaManual_SalidaVisceras = value
        End Set
    End Property

    Public Property PesadaManual_SalidaViscerasDecomiso As Boolean
        Get
            ioPesadaManual_SalidaViscerasDecomiso = New clsParametros(12)
            iPesadaManual_SalidaViscerasDecomiso = IIf(ioPesadaManual_SalidaViscerasDecomiso.ENT1 = 0, False, True)
            PesadaManual_SalidaViscerasDecomiso = iPesadaManual_SalidaViscerasDecomiso
        End Get
        Set(value As Boolean)
            iPesadaManual_SalidaViscerasDecomiso = value
        End Set
    End Property

    Public Property PesadaManual_SalidaPieles As Boolean
        Get
            ioPesadaManual_SalidaPieles = New clsParametros(13)
            iPesadaManual_SalidaPieles = IIf(ioPesadaManual_SalidaPieles.ENT1 = 0, False, True)
            PesadaManual_SalidaPieles = iPesadaManual_SalidaPieles
        End Get
        Set(value As Boolean)
            iPesadaManual_SalidaPieles = value
        End Set
    End Property

    Public Property PesadaManual_SalidaCanales As Boolean
        Get
            ioPesadaManual_SalidaCanales = New clsParametros(14)
            iPesadaManual_SalidaCanales = IIf(ioPesadaManual_SalidaCanales.ENT1 = 0, False, True)
            PesadaManual_SalidaCanales = iPesadaManual_SalidaCanales
        End Get
        Set(value As Boolean)
            iPesadaManual_SalidaCanales = value
        End Set
    End Property

    Public Property PesadaManual_SalaCortes As Boolean
        Get
            ioPesadaManual_SalaCortes = New clsParametros(15)
            iPesadaManual_SalaCortes = IIf(ioPesadaManual_SalaCortes.ENT1 = 0, False, True)
            PesadaManual_SalaCortes = iPesadaManual_SalaCortes
        End Get
        Set(value As Boolean)
            iPesadaManual_SalaCortes = value
        End Set
    End Property

    Public Property Validacion_LotesSinEntradaVehiculos As Boolean
        Get
            ioValidacion_LotesSinEntradaVehiculos = New clsParametros(16)
            iValidacion_LotesSinEntradaVehiculos = IIf(ioValidacion_LotesSinEntradaVehiculos.ENT1 = 0, False, True)
            Validacion_LotesSinEntradaVehiculos = iValidacion_LotesSinEntradaVehiculos
        End Get
        Set(value As Boolean)
            iValidacion_LotesSinEntradaVehiculos = value
        End Set
    End Property

    Public Function ExisteLoteEntrada(ByVal aLote As Integer, Optional ByRef aID_CTE_PROD As Integer = 0, Optional ByRef aID_CTE_INTR As Integer = 0) As Boolean
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_ENTRADAS  0, '', '', '', '1', '%', '%','%', '%', '" & aLote & "'"

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlClient.SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                aID_CTE_PROD = dt.Rows(0)("ID_CTE_PROD")
                aID_CTE_INTR = dt.Rows(0)("ID_CTE_INTR")
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return False
        End Try
    End Function
End Class
