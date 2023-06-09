Public Class frmCONFIG_Permisos_Validaciones
    Dim ioPermisosValidaciones As clsPermisosValidaciones

    Private Sub frmCONFIG_Permisos_Validaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ioPermisosValidaciones = New clsPermisosValidaciones
        Me.CargarInformacion()
    End Sub

    Private Sub CargarInformacion()
        Me.chkPM_EntradaVehiculos.Checked = ioPermisosValidaciones.PesadaManual_EntradaVehiculos
        Me.chkPM_GanadoEnPie.Checked = ioPermisosValidaciones.PesadaManual_GanadoEnPie
        Me.chkPM_Pieles.Checked = ioPermisosValidaciones.PesadaManual_Pieles
        Me.chkPM_Canales.Checked = ioPermisosValidaciones.PesadaManual_Canales
        Me.chkPM_ViscerasRojas.Checked = ioPermisosValidaciones.PesadaManual_ViscerasRojas
        Me.chkPM_VIscerasVerdes.Checked = ioPermisosValidaciones.PesadaManual_ViscerasVerdes
        Me.chkPM_SalidaVisceras.Checked = ioPermisosValidaciones.PesadaManual_SalidaVisceras
        Me.chkPM_SalidaViscerasDecomiso.Checked = ioPermisosValidaciones.PesadaManual_SalidaViscerasDecomiso
        Me.chkPM_SalidaPïeles.Checked = ioPermisosValidaciones.PesadaManual_SalidaPieles
        Me.chkPM_SalidaCanales.Checked = ioPermisosValidaciones.PesadaManual_SalidaCanales
        Me.chkPM_SalaDeCortes.Checked = ioPermisosValidaciones.PesadaManual_SalaCortes
        Me.chkVAL_RegistroEntVeh.Checked = ioPermisosValidaciones.Validacion_LotesSinEntradaVehiculos
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            ioPermisosValidaciones.PesadaManual_EntradaVehiculos = Me.chkPM_EntradaVehiculos.Checked
            ioPermisosValidaciones.PesadaManual_GanadoEnPie = Me.chkPM_GanadoEnPie.Checked
            ioPermisosValidaciones.PesadaManual_Pieles = Me.chkPM_Pieles.Checked
            ioPermisosValidaciones.PesadaManual_Canales = Me.chkPM_Canales.Checked
            ioPermisosValidaciones.PesadaManual_ViscerasRojas = Me.chkPM_ViscerasRojas.Checked
            ioPermisosValidaciones.PesadaManual_ViscerasVerdes = Me.chkPM_VIscerasVerdes.Checked
            ioPermisosValidaciones.PesadaManual_SalidaVisceras = Me.chkPM_SalidaVisceras.Checked
            ioPermisosValidaciones.PesadaManual_SalidaViscerasDecomiso = Me.chkPM_SalidaViscerasDecomiso.Checked
            ioPermisosValidaciones.PesadaManual_SalidaPieles = Me.chkPM_SalidaPïeles.Checked
            ioPermisosValidaciones.PesadaManual_SalidaCanales = Me.chkPM_SalidaCanales.Checked
            ioPermisosValidaciones.PesadaManual_SalaCortes = Me.chkPM_SalaDeCortes.Checked
            ioPermisosValidaciones.Validacion_LotesSinEntradaVehiculos = Me.chkVAL_RegistroEntVeh.Checked
            If ioPermisosValidaciones.Guardar() Then
                MessageBox.Show("Configuración guardada correctamente.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        
    End Sub
End Class