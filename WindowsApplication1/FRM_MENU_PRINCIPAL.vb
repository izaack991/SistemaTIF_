Imports System.Data.SqlClient

Public Class FRM_MENU_PRINCIPAL
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
    Private Sub FRM_MENU_PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd = Cnn.CreateCommand()
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
        ' RecorrerEstructuraMenu(MenuStrip1, table)
        'modConexion.Conectar()
    End Sub
    'Private Sub RecorrerEstructuraMenu(ByRef oMenu As MenuStrip, ByVal Table As DataTable)
    '    ' en este método recorremos las opciones de la barra
    '    ' principal (el primer nivel) de la colección de elementos
    '    ' del menú del formulario

    '    For Each oOpcionMenu As ToolStripMenuItem In oMenu.Items

    '        'If oOpcionMenu.DropDownItems.Count > 0 Then
    '        '    Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, "----")
    '        'End If

    '        habilitarMenu(oOpcionMenu, Table)
    '        Me.RecorrerSubmenu(oOpcionMenu.DropDownItems, Table)
    '        ' si una opción de menú de la barra de primer nivel

    '        ' tiene a su vez opciones, llamar a otro método que
    '        ' será el que recorra estas subopciones

    '    Next
    'End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim PS As New FRM_PROGRAMA_SACRIFICIO(False)
        PS.MdiParent = Me
        PS.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim iz As New frmPROC_GanadoEnPie
        iz.MdiParent = Me
        iz.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
      
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim can As New frmPROC_Sacrificio
        can.MdiParent = Me
        can.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim gpie As New frmCONS_EntradaGanadoEnPie
        gpie.MdiParent = Me
        gpie.Show()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Dim cpiel As New frmCONS_EntradaPieles
        cpiel.MdiParent = Me
        cpiel.Show()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim sacri As New frmCONS_EntradaSacrificio
        sacri.MdiParent = Me
        sacri.Show()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Dim pie As New frmPROC_Pieles
        pie.MdiParent = Me
        pie.Show()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick

    End Sub
End Class