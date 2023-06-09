Option Explicit On

Imports System.Reflection
Imports System.Deployment
Imports System.Data.SqlClient

Public Class mdiPrincipal

    Inherits System.Windows.Forms.Form
    Dim iIdUsuario As Integer
    Dim iRol As Integer
    Dim sNombre As String
    Private Property ApplicationDeployment As Object
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal sNombre As String, ByVal iRol As Integer, ByVal iIdUsuario As Integer)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.iRol = iRol
        Me.iIdUsuario = iIdUsuario
        Me.sNombre = sNombre
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub mdiPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = e.CloseReason
        frmLogin.Close()
        If My.Application.OpenForms.Count > 1 Then
            MessageBox.Show("Todavía existen ventanas abiertas, es necesario cerrarlas para salir del sistema.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cancel = 1
        End If
        e.Cancel = Cancel
    End Sub
    Private Sub mdiPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select e.KeyCode
            Case e.Shift = True And Keys.F8
                Dim frmPassword As New frmUTIL_Contrasena
                Dim oParametros As New clsParametros(17)

                frmPassword.ShowDialog(frmUTIL_Contrasena)
                If frmPassword.txtPassword.Text.Trim = oParametros.CAD1 Then
                    frmPassword.Dispose()
                    frmCONFIG_Permisos_Validaciones.MdiParent = Me
                    frmCONFIG_Permisos_Validaciones.Show()
                Else
                    frmPassword.Dispose()
                    MessageBox.Show("Contraseña incorrecta.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
        End Select
    End Sub

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        modConexion.Conectar()

        Dim lFechaVencimiento As String = "15/12/2015"
        Dim lFechaProrroga As String = "18/12/2015"
        Dim lDiasRestantes As Integer = 0

        Dim myVersion As System.Version = Nothing

        Dim lServidor As New clsServidor()

        'If CDate(lServidor.FECHA) > CDate(lFechaProrroga) Then
        '    MessageBox.Show("La licencia de prueba ha expirado.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End
        'End If

        'If CDate(lServidor.FECHA) > CDate(lFechaVencimiento) Then
        '    lDiasRestantes = DateDiff(DateInterval.Day, CDate(lServidor.FECHA), CDate(lFechaProrroga)) + 1
        '    MessageBox.Show("La licencia de prueba ha expirado." & vbNewLine & vbNewLine & "Restan " & lDiasRestantes.ToString & " dias de uso.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If


        'If lServidor.Equipo_Local = "SYSMASTER" Then
        '    EmbarqueToolStripMenuItem.Visible = True
        'Else
        '    EmbarqueToolStripMenuItem.Visible = False
        'End If



        'If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
        '    With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
        '        Me.Text = "V" & .Major & "." & .Minor & "." & .Build
        '    End With
        'End If

        'If Not IsNothing(ApplicationDeployment.IsNetworkDeployed) Then
        '    If ApplicationDeployment.IsNetworkDeployed Then
        'myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
        '    End If
        'End If


        'Me.lblVersion.Text = "v" & myVersion.ToString

        Dim cmd As SqlCommand
        cmd = cnn.CreateCommand()
        cmd.CommandText = "SELECT  m.Opcion, o.Enable, o.Visible,o.idRol from Sistema.OcionesRol AS o INNER JOIN Sistema.OpcionesMenu AS m ON o.Nivel = m.Nivel where o.idRol =" & Str(iRol)
        cmd.CommandType = CommandType.Text
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        'modConexion.Conectar()

        Dim table As DataTable = New DataTable
        adapter.Fill(table)
        adapter.Dispose()
        cmd.Dispose()
        'habilitar(table, Me)
        RecorrerEstructuraMenu(MenuStrip1, table)
        'modConexion.Conectar()
    End Sub
    Private Sub habilitar(ByVal table As DataTable, ByVal ctr As Control)

        Dim sOpcion As String
        Dim bEnabled As Boolean
        Dim bVisible As Boolean

        For Each ct As Control In ctr.Controls

            For Each row As DataRow In table.Rows

                sOpcion = Convert.ToString(row("Opcion"))
                bEnabled = Convert.ToBoolean(row("Enable"))
                bVisible = Convert.ToBoolean(row("Visible"))
                If ct.Name = sOpcion Then
                    ct.Enabled = bEnabled
                    ct.Visible = bVisible
                End If
            Next

            habilitar(table, ct)
        Next

    End Sub
    Private Sub habilitarMenu(ByRef oOpcionMenu As ToolStripMenuItem, ByVal Table As DataTable)

        Dim sOpcion As String
        Dim bEnabled As Boolean
        Dim bVisible As Boolean
        For Each row As DataRow In Table.Rows

            sOpcion = Convert.ToString(row("Opcion"))
            bEnabled = Convert.ToBoolean(row("Enable"))
            bVisible = Convert.ToBoolean(row("Visible"))
            If oOpcionMenu.Name = sOpcion Then
                oOpcionMenu.Enabled = bEnabled
                oOpcionMenu.Visible = bVisible
            End If
        Next

    End Sub
    Private Sub RecorrerEstructuraMenu(ByRef oMenu As MenuStrip, ByVal Table As DataTable)
        ' en este método recorremos las opciones de la barra
        ' principal (el primer nivel) de la colección de elementos
        ' del menú del formulario

        For Each oOpcionMenu As ToolStripMenuItem In oMenu.Items

            'If oOpcionMenu.DropDownItems.Count > 0 Then
            '    Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, "----")
            'End If

            habilitarMenu(oOpcionMenu, Table)
            Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, Table)
            ' si una opción de menú de la barra de primer nivel

            ' tiene a su vez opciones, llamar a otro método que
            ' será el que recorra estas subopciones

        Next
    End Sub
    Private Sub RecorrerSubmenu(ByVal oSubmenuItems As ToolStripItemCollection, ByVal Table As DataTable)
        ' en este método recorremos las opciones de nivel inferior
        ' de una opción de menú principal, y si alguna de estas opciones
        ' tiene a su vez submenús, volvemos a llamar recursivamente a
        ' este método para ir profundizando en el siguiente nivel,
        ' y así sucesivamente

        For Each oSubitem As ToolStripMenuItem In oSubmenuItems

            habilitarMenu(oSubitem, Table)
            Me.RecorrerSubmenu(oSubitem.DropDownItems, Table)

        Next
    End Sub
    Private Sub FamiliasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FamiliasToolStripMenuItem1.Click
        frmCAT_Familias.MdiParent = Me
        frmCAT_Familias.Show()
    End Sub

    Private Sub SubfamiliasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SubfamiliasToolStripMenuItem1.Click
        frmCAT_Subfamilias.MdiParent = Me
        frmCAT_Subfamilias.Show()
    End Sub
    Private Sub EspeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspeciesToolStripMenuItem.Click
        frmCAT_Especies.MdiParent = Me
        frmCAT_Especies.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        frmCAT_MarcasVehiculos.MdiParent = Me
        frmCAT_MarcasVehiculos.Show()
    End Sub

    Private Sub TiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposToolStripMenuItem.Click
        frmCAT_TiposVehiculo.MdiParent = Me
        frmCAT_TiposVehiculo.Show()
    End Sub

    Private Sub TipoDeGanadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeGanadoToolStripMenuItem.Click
        frmCAT_TipoGanado.MdiParent = Me
        frmCAT_TipoGanado.Show()
    End Sub

    Private Sub ClasificacionesDeExportaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificacionesDeExportaciónToolStripMenuItem.Click
        frmCAT_ClasificacionExp.MdiParent = Me
        frmCAT_ClasificacionExp.Show()
    End Sub

    Private Sub EntradaDeVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeVehículosToolStripMenuItem.Click
        frmEntradaVehiculos.MdiParent = Me
        frmEntradaVehiculos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCAT_Clientes.MdiParent = Me
        frmCAT_Clientes.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        frmCAT_Productos.MdiParent = Me
        frmCAT_Productos.Show()
    End Sub

    Private Sub EntradaVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaVehiculosToolStripMenuItem.Click
        frmCONS_EntradasVehiculos.MdiParent = Me
        frmCONS_EntradasVehiculos.Show()
    End Sub

    Private Sub GanadoEnPieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GanadoEnPieToolStripMenuItem.Click
        frmPROC_GanadoEnPie.MdiParent = Me
        frmPROC_GanadoEnPie.cargarusuario(iIdUsuario)
        frmPROC_GanadoEnPie.Show()
    End Sub

    Private Sub CanalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanalesToolStripMenuItem.Click
        Dim frmPROC_Sacrificio As New frmPROC_Sacrificio
        frmPROC_Sacrificio.cargarusuario(iIdUsuario)
        frmPROC_Sacrificio.MdiParent = Me
        frmPROC_Sacrificio.Show()
    End Sub

    Private Sub PielesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PielesToolStripMenuItem.Click
        frmPROC_Pieles.MdiParent = Me
        frmPROC_Pieles.cargarusuario(iIdUsuario)
        frmPROC_Pieles.Show()
    End Sub
    ''' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ViscerasRojasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViscerasRojasToolStripMenuItem.Click
        frmPROC_ViscerasRojas.MdiParent = Me
        frmPROC_ViscerasRojas.cargarusuario(iIdUsuario)
        frmPROC_ViscerasRojas.Show()
    End Sub
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    Private Sub ViscerasVerdesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViscerasVerdesToolStripMenuItem.Click
        frmPROC_ViscerasVerdes.MdiParent = Me
        frmPROC_ViscerasVerdes.cargarusuario(iIdUsuario)
        frmPROC_ViscerasVerdes.Show()
    End Sub

    Private Sub RelacionDeEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionDeEntradasToolStripMenuItem.Click
        frmCONS_EntradaVisceras.MdiParent = Me
        frmCONS_EntradaVisceras.Show()
    End Sub

    Private Sub RelaciónDeSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeSalidasToolStripMenuItem.Click
        frmCONS_SalidaVisceras.MdiParent = Me
        frmCONS_SalidaVisceras.Show()
    End Sub

    Private Sub MovimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoToolStripMenuItem.Click
        Dim cc As New frmCONS_RelacionCortes(False)
        cc.MdiParent = Me
        cc.Show()
    End Sub

    Private Sub GanadoEnPieToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GanadoEnPieToolStripMenuItem2.Click
        frmCONS_GanadoEnPie.MdiParent = Me
        frmCONS_GanadoEnPie.Show()
    End Sub

    Private Sub PielesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PielesToolStripMenuItem1.Click
        frmCONS_Pieles.MdiParent = Me
        frmCONS_Pieles.Show()
    End Sub

    Private Sub CanalesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CanalesToolStripMenuItem3.Click
        frmCONS_Sacrificio.MdiParent = Me
        frmCONS_Sacrificio.Show()
    End Sub

    Private Sub GanadoEnPieToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GanadoEnPieToolStripMenuItem3.Click
        frmCONS_EntradaGanadoEnPie.MdiParent = Me
        frmCONS_EntradaGanadoEnPie.Show()
    End Sub

    Private Sub CanalesToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CanalesToolStripMenuItem4.Click
        frmCONS_EntradaSacrificio.MdiParent = Me
        frmCONS_EntradaSacrificio.Show()
    End Sub

    Private Sub SacrificioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SacrificioToolStripMenuItem1.Click
        frmCONS_RelacionGanadoEnPie.MdiParent = Me
        frmCONS_RelacionGanadoEnPie.Show()
    End Sub

    Private Sub RelaciónDeSalidasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RelaciónDeSalidasToolStripMenuItem1.Click
        frmCONS_RelacionSalidaCanales.MdiParent = Me
        frmCONS_RelacionSalidaCanales.Show()
    End Sub


    Private Sub EstablecerEtiquetadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecerEtiquetadoraToolStripMenuItem.Click
        Try
            Dim lResp As Integer
            lResp = MessageBox.Show("¿Deseas cambiar la etiquetadora predeterminada?", gProyecto, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If lResp = MsgBoxResult.Yes Then
                Me.PrintDialog.ShowDialog()
                gNombreEtiquetadora = Me.PrintDialog.PrinterSettings.PrinterName
            End If
        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Private Sub InventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventariosToolStripMenuItem.Click
        frmCONS_InventarioCanales.MdiParent = Me
        frmCONS_InventarioCanales.Show()
    End Sub

    Private Sub ProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProducciónToolStripMenuItem.Click
        modConexion.Conectar()
        modConexion.Conectar()
    End Sub

    Private Sub RespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldoToolStripMenuItem.Click
        modConexion.Conectar(2)
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        frmCONS_InventarioVisceras.MdiParent = Me
        frmCONS_InventarioVisceras.Show()
    End Sub

    'Private Sub ViscerasRojasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViscerasRojasToolStripMenuItem1.Click
    '    frmPROC_EntradaProductosPorFamilia.MdiParent = Me
    '    frmPROC_EntradaProductosPorFamilia.RecibeParametros(9, 2, 1)
    '    frmPROC_EntradaProductosPorFamilia.Show()
    'End Sub

    Private Sub EmbarqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarqueToolStripMenuItem.Click
        frmPROC_Salida_Visceras.MdiParent = Me
        frmPROC_Salida_Visceras.cargarusuario(iIdUsuario)
        frmPROC_Salida_Visceras.Show()
    End Sub

    Private Sub DecomisoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DecomisoToolStripMenuItem1.Click
        frmPROC_Salida_ViscerasDecomisos.MdiParent = Me
        frmPROC_Salida_ViscerasDecomisos.cargarusuario(iIdUsuario)
        frmPROC_Salida_ViscerasDecomisos.Show()
    End Sub

    Private Sub PielesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PielesToolStripMenuItem2.Click
        frmPROC_Salida_Pieles.MdiParent = Me
        frmPROC_Salida_Pieles.cargarusuario(iIdUsuario)
        frmPROC_Salida_Pieles.Show()
    End Sub

    Private Sub RelacionDeSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionDeSalidasToolStripMenuItem.Click
        frmCONS_RelacionSalidaPieles.MdiParent = Me
        frmCONS_RelacionSalidaPieles.Show()
    End Sub

    Private Sub RelacionDeEntradasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RelacionDeEntradasToolStripMenuItem1.Click
        frmCONS_EntradaPieles.MdiParent = Me
        frmCONS_EntradaPieles.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem1.Click
        frmCONS_InventarioPieles.MdiParent = Me
        frmCONS_InventarioPieles.Show()
    End Sub

    Private Sub ProductosClientesCortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosClientesCortesToolStripMenuItem.Click
        frmCAT_ProductosCte.MdiParent = Me
        frmCAT_ProductosCte.Show()
    End Sub

    Private Sub ProgramacionCorteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgramaciónDeCortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramaciónDeCortesToolStripMenuItem.Click
        frmPROC_ProgramacionCorte.MdiParent = Me
        frmPROC_ProgramacionCorte.cargarusuario(iIdUsuario)
        frmPROC_ProgramacionCorte.Show()
    End Sub

    Private Sub CortesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CortesToolStripMenuItem1.Click
        frmPROC_ProduccionCortes.MdiParent = Me
        frmPROC_ProduccionCortes.cargarusuario(iIdUsuario)
        frmPROC_ProduccionCortes.Show()
    End Sub

    Private Sub EmbarqueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmbarqueToolStripMenuItem1.Click
        frmPROC_SalidaCajas.MdiParent = Me
        frmPROC_SalidaCajas.cargarusuario(iIdUsuario)
        frmPROC_SalidaCajas.Show()
    End Sub

    Private Sub EmbarqueToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmbarqueToolStripMenuItem2.Click
        frmPROC_SalidaCanales.MdiParent = Me
        frmPROC_SalidaCanales.cargarusuario(iIdUsuario, False)
        frmPROC_SalidaCanales.Show()
    End Sub

    Private Sub InventariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InventariosToolStripMenuItem1.Click
        frmCONS_InventarioCajas.MdiParent = Me
        frmCONS_InventarioCajas.Show()
    End Sub

    Private Sub RelaciónDeCOrtesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeCOrtesToolStripMenuItem.Click
        Dim cc As New frmCONS_RelacionCortes(False)
        cc.MdiParent = Me
        cc.Show()
    End Sub

    Private Sub RelaciónDeSalidasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RelaciónDeSalidasToolStripMenuItem2.Click
        frmCONS_RelacionSalidaCajas.MdiParent = Me
        frmCONS_RelacionSalidaCajas.Show()
    End Sub

    Private Sub RelaciónDeEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeEntradasToolStripMenuItem.Click
        frmCONS_RelacionEntradaCajas.MdiParent = Me
        frmCONS_RelacionEntradaCajas.Show()
    End Sub

    Private Sub CambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiosToolStripMenuItem.Click
        frmPROC_ReetiquetarCajas.MdiParent = Me
        frmPROC_ReetiquetarCajas.Show()
    End Sub

    Private Sub EmbarqueXIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarqueXIDToolStripMenuItem.Click
        frmPROC_SalidaCajas_xID.MdiParent = Me
        frmPROC_SalidaCajas_xID.cargarusuario(iIdUsuario)
        frmPROC_SalidaCajas_xID.Show()
    End Sub

    Private Sub EmbarquePorIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarquePorIDToolStripMenuItem.Click
        frmPROC_SalidaCanales_xID.MdiParent = Me
        frmPROC_SalidaCanales_xID.cargarusuario(iIdUsuario)
        frmPROC_SalidaCanales_xID.Show()
    End Sub

    Private Sub PorDevoluciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorDevoluciónToolStripMenuItem.Click
        frmPROC_EntradaCajas_xDev.MdiParent = Me
        frmPROC_EntradaCajas_xDev.cargarusuario(iIdUsuario)
        frmPROC_EntradaCajas_xDev.Show()
    End Sub

    Private Sub RegistrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem1.Click
        frmINV_Registro.MdiParent = Me
        frmINV_Registro.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem1.Click
        frmCONS_RelacionInventarios.MdiParent = Me
        frmCONS_RelacionInventarios.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmCONS_RegistroInventario.MdiParent = Me
        frmCONS_RegistroInventario.Show()
    End Sub

    Private Sub AjusteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjusteToolStripMenuItem.Click
        frmINV_AjusteDeInventario.MdiParent = Me
        frmINV_AjusteDeInventario.cargarusuario(iIdUsuario)
        frmINV_AjusteDeInventario.Show()
    End Sub

    Private Sub CajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaToolStripMenuItem.Click
        frmCONS_KardexCaja.MdiParent = Me
        frmCONS_KardexCaja.Show()
    End Sub

    Private Sub PorProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorProductoToolStripMenuItem.Click
        frmCONS_KardexCaja_Producto.MdiParent = Me
        frmCONS_KardexCaja_Producto.Show()
    End Sub

    Private Sub TransformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformaciónToolStripMenuItem.Click
        frmPROC_SalidaCanales_x_Transformacion.MdiParent = Me
        frmPROC_SalidaCanales_x_Transformacion.Show()
    End Sub

    Private Sub RelaciónDeSalidasDetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaciónDeSalidasDetalleToolStripMenuItem.Click
        frmCONS_RelacionSalidaCajas_Det.MdiParent = Me
        frmCONS_RelacionSalidaCajas_Det.Show()
    End Sub

    Private Sub RelacionDeCortesMejoradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionDeCortesMejoradoToolStripMenuItem.Click
        Dim cc As New frmCONS_RelacionCortes(True)
        cc.MdiParent = Me
        cc.Show()
    End Sub

    Private Sub SalaDeCortesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalaDeCortesToolStripMenuItem1.Click

    End Sub

    Private Sub TransformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransformacionToolStripMenuItem.Click
        frmPROC_EntradaProdTransf.MdiParent = Me
        frmPROC_EntradaProdTransf.Show()
    End Sub

    Private Sub GenerarArchivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarArchivosToolStripMenuItem.Click
        frmGenerarArchivos.MdiParent = Me
        frmGenerarArchivos.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        frmPedidos.MdiParent = Me
        frmPedidos.Show()
    End Sub

    Private Sub AbrirCerrarCortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCerrarCortesToolStripMenuItem.Click
        FrmAbrirCerrarCorte.MdiParent = Me
        FrmAbrirCerrarCorte.Show()
    End Sub

    Private Sub VerificarCajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarCajasToolStripMenuItem.Click
        frmRevisionCajas.MdiParent = Me
        frmRevisionCajas.Show()
    End Sub

    Private Sub InventarioTotalXIntroductorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioTotalXIntroductorToolStripMenuItem.Click
        frmCONS_INVENTARIOXINTR.MdiParent = Me
        frmCONS_INVENTARIOXINTR.Show()
    End Sub

    Private Sub RelacionDeMermasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionDeMermasToolStripMenuItem.Click
        frmCONS_RELACION_MERMAS_CANALES.MdiParent = Me
        frmCONS_RELACION_MERMAS_CANALES.Show()
    End Sub

    Private Sub TransferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciaToolStripMenuItem.Click
        Dim T As New frmPROC_TRANSF_CAJAS(False)
        T.MdiParent = Me
        T.Show()
    End Sub

    Private Sub TransferenciaPorIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciaPorIDToolStripMenuItem.Click
        frmPROC_TrasnfCajas_ID.MdiParent = Me
        frmPROC_TrasnfCajas_ID.Show()
    End Sub

    Private Sub TransferenciaASalaDeCorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciaASalaDeCorteToolStripMenuItem.Click
        Dim T As New frmPROC_TRANSF_CAJAS(True)
        T.MdiParent = Me
        T.Show()
    End Sub

    Private Sub TransferenciaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransferenciaToolStripMenuItem1.Click
        frmPROC_SalidaCanales.MdiParent = Me
        frmPROC_SalidaCanales.cargarusuario(iIdUsuario, True)
        frmPROC_SalidaCanales.Show()
    End Sub

    Private Sub ProgramaSacrificioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramaSacrificioToolStripMenuItem.Click
        Dim PS As New frmOrdenSacrificio
        PS.Show()
    End Sub

    Private Sub RevionCalidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevionCalidadToolStripMenuItem.Click
        FRM_REV_CALIDAD.MdiParent = Me
        FRM_REV_CALIDAD.Show()
    End Sub

    Private Sub MermaGrasahuesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MermaGrasahuesoToolStripMenuItem.Click
        frmPROC_MERMA_GH.MdiParent = Me
        frmPROC_MERMA_GH.Show()
    End Sub

    Private Sub RelacionDeCarneEnGrasaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionDeCarneEnGrasaToolStripMenuItem.Click
        frmCONS_Mermagrasahueso.MdiParent = Me
        frmCONS_Mermagrasahueso.Show()
    End Sub

    Private Sub PCC1BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCC1BToolStripMenuItem.Click
        frmKPI_INGESTA.MdiParent = Me
        frmKPI_INGESTA.Show()
    End Sub

    Private Sub PCC1BToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PCC1BToolStripMenuItem1.Click
        frmCONS_PCC1B.MdiParent = Me
        frmCONS_PCC1B.Show()
    End Sub

    Private Sub SospechososToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SospechososToolStripMenuItem.Click
        frmPROC_SacrificioSospechos.MdiParent = Me
        frmPROC_SacrificioSospechos.Show()
    End Sub

    Private Sub CosteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosteoToolStripMenuItem.Click
        frmPROC_COSTEO.MdiParent = Me
        frmPROC_COSTEO.Show()
    End Sub

    Private Sub InsumosCosteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsumosCosteoToolStripMenuItem.Click
        frmCAT_INSUMOS.MdiParent = Me
        frmCAT_INSUMOS.Show()
    End Sub

    Private Sub ComprasInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasInsumosToolStripMenuItem.Click
        fmrPROC_COMPRAS_INSUMOS.MdiParent = Me
        fmrPROC_COMPRAS_INSUMOS.Show()

    End Sub

    Private Sub ListasPreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasPreciosToolStripMenuItem.Click
        frmListaPrecios.MdiParent = Me
        frmListaPrecios.Show()
    End Sub

    Private Sub ArchivosMeatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivosMeatToolStripMenuItem.Click
        frmCONS_MEAT.MdiParent = Me
        frmCONS_MEAT.Show()
    End Sub
End Class
