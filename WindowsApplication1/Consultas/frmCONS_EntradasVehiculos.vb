Option Explicit On

Imports VB = Microsoft.VisualBasic

Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmCONS_EntradasVehiculos


    Dim iPrimeraVez As Boolean = True
    Dim iBuscaProductor As Boolean = False
    Dim iBuscaIntroductor As Boolean = False
    Dim iEstatus As String = ""
    Dim oProductor As New clsCliente(0)
    Dim oIntroductor As New clsCliente(0)
    Dim oProveedor As New clsCliente(0)

    Private Sub frmCON011_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If iPrimeraVez Then
            Call Me.CargarCombos()
            iPrimeraVez = False
        End If
    End Sub

    Private Sub frmCONS_EntradasVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Me.Limpiar()
    End Sub

    Private Sub frmCON011_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Call Me.Limpiar()
            Case Keys.F3
                Call Me.Buscar()
            Case Keys.F4
                Call Me.DespliegaDatos()
            Case Keys.F5
            Case Keys.F8
                Call Me.Imprimir()
        End Select
    End Sub

    Private Sub CargarCombos()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim daCatalogo2 As SqlClient.SqlDataAdapter
            Dim lSql As String

            lSql = "EXECUTE SP_CONS_TIPOS_ENTRADA_VEHICULOS"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_TIPOS_ENTRADA_VEHICULOS").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_TIPOS_ENTRADA_VEHICULOS")

            daCatalogo2.Dispose()

            lSql = "EXECUTE SP_CONS_ESPECIES"
            daCatalogo2 = New SqlClient.SqlDataAdapter(lSql, Cnn)
            DsCatalogos.Tables("SP_CONS_ESPECIES").Clear()
            daCatalogo2.Fill(DsCatalogos, "SP_CONS_ESPECIES")

            daCatalogo2.Dispose()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub despliegaCliente(ByVal aOpcion As Integer)
        Try
            Me.Cursor = Cursors.WaitCursor

            If aOpcion = 1 Then
                If modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProductor, Me.txtNomProductor, oProductor) Then
                    Me.txtMarcaIntroductor.Focus()
                End If
            ElseIf aOpcion = 2 Then
                Call modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaIntroductor, Me.txtNomIntroductor, oIntroductor)
            ElseIf aOpcion = 3 Then
                modFuncProc.DespliegaDescripcionCliente(Me.txtMarcaProveedor, Me.txtNomProveedor, oProveedor)
            End If

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Limpiar(Optional ByVal aOpcion As Integer = 0)
        If aOpcion = 0 Then

            If Not iPrimeraVez Then
                Me.cmbTipoEntrada.SelectedIndex = 0
                Me.cmbEspecie.SelectedIndex = 0
            End If

            Me.dtpFechaIni.Value = Today
            Me.dtpFechaFin.Value = Today

            Me.txtLote.Text = ""
            Me.txtLote.Tag = ""
            Me.txtLote.Text = ""

            Me.txtMarcaProductor.Text = ""
            'Me.txtMarcaProductor.Tag = ""
            Me.txtNomProductor.Text = ""

            Me.txtMarcaIntroductor.Text = ""
            'Me.txtMarcaIntroductor.Tag = ""
            Me.txtNomIntroductor.Text = ""

            Me.txtNomProveedor.Text = ""
            'Me.txtNomProveedor.Tag = ""
            Me.txtNomProveedor.Text = ""

            Me.chkEspecieTodos.Checked = False
            Me.rdbSacrificio.Checked = True


            Me.DsCatalogos.Tables("SP_CONS_ENTRADAS").Clear()

            Me.dtpFechaIni.Focus()

        End If
    End Sub

    Public Sub Buscar()
        'Dim frmBUS001 As New frmBUS001
        'Dim lsTitulo As String = ""
        'Dim lsCampoBusqueda As String = ""
        'Dim liColumnaCodigo As Short

        ''Dim iBuscaProductor As Boolean = False
        ''Dim iBuscaIntroductor As Boolean = False
        ''Dim iBuscaFolio As Boolean = False

        'If Me.ActiveControl.Name.ToString.ToUpper = "TXTMARCAPRODUCTOR" Then
        '    iBuscaProductor = True
        '    iBuscaIntroductor = False
        'ElseIf Me.ActiveControl.Name.ToString.ToUpper = "TXTMARCAINTRODUCTOR" Then
        '    iBuscaIntroductor = True
        '    iBuscaProductor = False
        '    'ElseIf Me.ActiveControl.Name.ToString.ToUpper = "TXTFOLIO" Then
        '    '    iBuscaFolio = True
        'Else
        '    Exit Sub
        'End If

        'If iBuscaProductor Or iBuscaIntroductor Then
        '    lsTitulo = "CLIENTES_ENTRADAS2"
        '    lsCampoBusqueda = "ALIAS"
        '    liColumnaCodigo = 2
        'Else
        '    'lsTitulo = "ENTRADAS"
        '    'lsCampoBusqueda = "PRODUCTOR"
        '    'liColumnaCodigo = 1
        'End If

        'Call frmBUS001.CachaParametros(lsTitulo, lsCampoBusqueda, liColumnaCodigo)
        'frmBUS001.ShowDialog()
        'Me.BringToFront()

        'If iBuscaProductor Then
        '    Me.txtMarcaProductor.Focus()
        'ElseIf iBuscaIntroductor Then
        '    Me.txtMarcaIntroductor.Focus()
        '    'ElseIf iBuscaFolio Then
        '    '    Me.txtLote.Focus()
        'End If

    End Sub

    Public Sub RegresaBuscarCte(ByVal aCodigo As String)
        If iBuscaProductor Then
            Me.txtMarcaProductor.Text = aCodigo
            Call Me.despliegaCliente(1)
        Else
            Me.txtMarcaIntroductor.Text = aCodigo
            Call Me.despliegaCliente(2)
        End If
    End Sub

    Private Sub txtMarcaProductor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMarcaProductor.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Call Me.despliegaCliente(1)
        End Select
    End Sub

    Private Sub txtMarcaIntroductor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMarcaIntroductor.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Call Me.despliegaCliente(2)
        End Select
    End Sub

    Private Sub txtMarcaProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMarcaProveedor.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Call Me.despliegaCliente(3)
        End Select
    End Sub

    Private Sub DespliegaDatos()
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim lSql As String
            Dim lFechaIni As String = ""
            Dim lFechaFin As String = ""
            Dim lFechaSac As String = ""
            Dim lTipoEntrada As String = "%"
            Dim lEspecie As String = "%"
            Dim lCodigoProductor As String = "%"
            Dim lCodigoIntroductor As String = "%"
            Dim lCodigoProveedor As String = "%"
            Dim lLote As String = ""
            Dim lEstatus As String = "%"

            If Me.rdbSacrificio.Checked Then
                lFechaSac = Format(Me.dtpFechaSac.Value, "dd/MM/yyyy")
            Else
                lFechaIni = Format(Me.dtpFechaIni.Value, "dd/MM/yyyy")
                lFechaFin = Format(Me.dtpFechaFin.Value, "dd/MM/yyyy")
            End If

            lTipoEntrada = Me.cmbTipoEntrada.SelectedValue

            Select Case lTipoEntrada
                Case 1, 2
                    lCodigoProductor = IIf(oProductor.ID_CLIENTE = 0, "%", oProductor.ID_CLIENTE.ToString)
                    lCodigoIntroductor = IIf(oIntroductor.ID_CLIENTE = 0, "%", oIntroductor.ID_CLIENTE.ToString)

                    If lTipoEntrada = 1 Then
                        lLote = IIf(Me.txtLote.Text.Trim = "", "", Me.txtLote.Text.Trim)
                        If Me.chkEspecieTodos.Checked Then
                            lEspecie = "%"
                        Else
                            lEspecie = Me.cmbEspecie.SelectedValue
                        End If
                    End If
                Case 3
                    lCodigoProveedor = IIf(oProveedor.ID_CLIENTE = 0, "%", oProveedor.ID_CLIENTE)
            End Select

            'PROCEDURE SP_CONS_ENTRADAS
            '@ID		    INT		= 0,
            '@FECHA_INI	    VARCHAR(10) = '',
            '@FECHA_FIN	    VARCHAR(10) = '',
            '@FECHA_SAC	    VARCHAR(10) = '',
            '@ID_TEV	    CHAR(1)		= '%',
            '@ID_ESPECIE	CHAR(1)		= '%',
            '@ID_CTE_PROD	VARCHAR(6)	= '%',
            '@ID_CTE_INTR	VARCHAR(6)	= '%',
            '@ID_CTE_PROV	VARCHAR(6)	= '%',
            '@LOTE		    VARCHAR(8)	= '%',
            '@ESTATUS	    CHAR(1)		= '%'

            Me.DsCatalogos.Tables("SP_CONS_ENTRADAS").Clear()

            lSql = "EXECUTE SP_CONS_ENTRADAS  0, '" & lFechaIni & "', '" & lFechaFin & "', '" & lFechaSac & "', " & _
                                                "'" & lTipoEntrada & "', '" & lEspecie & "', " & _
                                                "'" & lCodigoProductor & "','" & lCodigoIntroductor & "', '" & lCodigoProveedor & "', " & _
                                                "'" & lLote & "', '" & lEstatus & "'"


            Dim dataAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(lSql, Cnn)
            dataAdapter.Fill(DsCatalogos, "SP_CONS_ENTRADAS")

            Call Me.FormatoGrid()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub FormatoGrid()
        Try
            'Dim i As Integer
            'Dim oParametros As New clsParametros(21)

            'Me.Cursor = Cursors.WaitCursor

            'If Me.dgvDatos.Rows.Count > 0 Then
            '    For i = 0 To Me.dgvDatos.Rows.Count - 1

            '        'If me.dgvDatos.Rows(i).Cells("ID_ESP").Value = "1" Then  'BOVINOS
            '        '    me.dgvDatos.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            '        'ElseIf me.dgvDatos.Rows(i).Cells("ID_ESP").Value = "2" Then  'PORCINO
            '        '    me.dgvDatos.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            '        'End If

            '        If oParametros.Valor03.ToUpper = "SI" Then
            '            If Me.dgvDatos.Rows(i).Cells("PESADA_MANUAL").Value = "M" Then
            '                Me.dgvDatos.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            '            End If
            '        End If

            '        If Me.dgvDatos.Rows(i).Cells("ESTATUS").Value = "C" Then
            '            Me.dgvDatos.Rows(i).DefaultCellStyle.BackColor = Color.Red
            '        End If

            '    Next

            'End If

            modFuncProc.Genera_Numero_de_Renglon_Grid(Me.dgvDatos)


        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
        Call Me.DespliegaDatos()
    End Sub

    Private Sub cmbTipoEntrada_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoEntrada.SelectedValueChanged
        If Not iPrimeraVez Then
            If Me.cmbTipoEntrada.SelectedValue = "3" Then
                Me.cmbEspecie.Enabled = False
            Else
                Me.cmbEspecie.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPrevia.Click
        Call Me.Imprimir()
    End Sub

    Private Sub Imprimir()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim miReporte As ReportDocument = Nothing

            miReporte = CType(New crptCAT_Entradas, ReportDocument)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte
            miReporte.SetDataSource(DsCatalogos.Tables("SP_CONS_ENTRADAS"))
            If Me.rdbSacrificio.Checked Then
                miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'FECHA DE SACRIFICIO " & Format(Me.dtpFechaSac.Value, "dd/MM/yyyy") & "'"
            Else
                miReporte.DataDefinition.FormulaFields("PERIODO").Text = "'DEL " & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & " AL " & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "'"
            End If


            frmReporte.Show()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnReimpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReimpresion.Click
        Call Me.Reimpresion()
    End Sub
    Private Sub Reimpresion()
        Try
            'Dim lSql As String
            Dim lFolio As String
            Dim lEstatus As String
            'Dim lFechaEntrada As String

            If Me.dgvDatos.Rows.Count <= 0 Then
                MessageBox.Show("Debe seleccionar una entrada para reimprimir.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim miReporte As ReportDocument = Nothing
            miReporte = CType(New crptCAT_EntradaIndividualTodo, ReportDocument)

            lFolio = Me.dgvDatos.CurrentRow.Cells("ID_ENT").Value
            lEstatus = Me.dgvDatos.CurrentRow.Cells("ESTATUS").Value
            'lFechaEntrada = Me.dgvDatos.CurrentRow.Cells("FECHA_ENTRADA").Value

            Dim oEntradaIndividual As New clsEntrada(lFolio)

            If oEntradaIndividual.ID_ENTRADA = 0 Then
                MessageBox.Show("La Entrada proporcionada no existe.", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If oEntradaIndividual.ESTATUS = "C" Then
                MessageBox.Show("Esta Entrada esta cancelada. NO SE PUEDE REIMPRIMIR", gProyecto, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Me.Cursor = Cursors.Default

            ''OBTIENE LOS DATOS DEL ESTUDIO DE CORTES
            'Me.DsEntradas.Tables("SP_CONSULTA_ENTRADAS").Clear()

            'lSql = "EXECUTE SP_CONSULTA_ENTRADAS '" & lFechaEntrada & "', '" & lFechaEntrada & "' ,'" & lFolio & "'"

            'Dim daConsulta As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(lSql, Cnn)
            'daConsulta.Fill(Me.DsEntradas, "SP_CONSULTA_ENTRADAS")

            'miReporte.SetDataSource(Me.DsEntradas.Tables("SP_CONSULTA_ENTRADAS"))
            miReporte.SetDataSource(oEntradaIndividual.dt_ENTRADA)

            Dim frmReporte As New frmCRViewer
            frmReporte.MdiParent = Me.ParentForm
            frmReporte.crViewer.ReportSource = miReporte
            'miReporte.SetParameterValue("IMPRIMETODO", True)
            'miReporte.SetParameterValue("REIMPRESION", True)

            'miReporte.SetParameterValue("EMPRESA", goEmpresa.DescEmpresa)
            'miReporte.SetParameterValue("DIRECCION1", goEmpresa.Domicilio)
            'miReporte.SetParameterValue("DIRECCION2", goEmpresa.DescCiudad.ToUpper & ", C.P. " & goEmpresa.CP & ", TEL." & _
            '                            Format(CLng(goEmpresa.FAX), "(###)###-####") & ", " & Format(CLng(goEmpresa.Telefono), "(###)###-####"))


            frmReporte.Show()

            Application.DoEvents()

            Call Me.DespliegaDatos()

            Application.DoEvents()

        Catch ex As Exception
            Call modGeneral.ManejaExcepcion(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub rdbSacrificio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSacrificio.CheckedChanged
        If Me.rdbSacrificio.Checked Then
            Me.dtpFechaSac.Enabled = True
            Me.dtpFechaIni.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub rdbEntrada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbEntrada.CheckedChanged
        If Me.rdbEntrada.Checked Then
            Me.dtpFechaSac.Enabled = False
            Me.dtpFechaIni.Enabled = True
            Me.dtpFechaFin.Enabled = True
        End If
    End Sub

    Private Sub cmbTipoEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoEntrada.SelectedIndexChanged
        Select Case Me.cmbTipoEntrada.SelectedIndex
            Case 0
                lblProv.Visible = False
                Me.txtMarcaProveedor.Visible = False
                Me.txtNomProveedor.Visible = False

                lblProd.Visible = True
                Me.txtMarcaProductor.Visible = True
                Me.txtNomProductor.Visible = True

                lblIntr.Visible = True
                Me.txtMarcaIntroductor.Visible = True
                Me.txtNomIntroductor.Visible = True

                Me.dgvDatos.Columns("MARCA_CTE_PROD").Visible = True
                Me.dgvDatos.Columns("MARCA_CTE_INTR").Visible = True
                Me.dgvDatos.Columns("MARCA_CTE_PROV").Visible = False

                Me.dgvDatos.Columns("NOM_CTE_PROD").Visible = True
                Me.dgvDatos.Columns("NOM_CTE_INTR").Visible = True
                Me.dgvDatos.Columns("NOM_CTE_PROV").Visible = False
            Case 1
                lblProv.Visible = False
                Me.txtMarcaProveedor.Visible = False
                Me.txtNomProveedor.Visible = False

                lblProd.Visible = True
                Me.txtMarcaProductor.Visible = True
                Me.txtNomProductor.Visible = True

                lblIntr.Visible = True
                Me.txtMarcaIntroductor.Visible = True
                Me.txtNomIntroductor.Visible = True
                Me.dgvDatos.Columns("MARCA_CTE_PROD").Visible = True
                Me.dgvDatos.Columns("MARCA_CTE_INTR").Visible = True
                Me.dgvDatos.Columns("MARCA_CTE_PROV").Visible = False

                Me.dgvDatos.Columns("NOM_CTE_PROD").Visible = True
                Me.dgvDatos.Columns("NOM_CTE_INTR").Visible = True
                Me.dgvDatos.Columns("NOM_CTE_PROV").Visible = False

            Case 2
                lblProv.Visible = True
                Me.txtMarcaProveedor.Visible = True
                Me.txtNomProveedor.Visible = True

                lblProd.Visible = False
                Me.txtMarcaProductor.Visible = False
                Me.txtNomProductor.Visible = False

                lblIntr.Visible = False
                Me.txtMarcaIntroductor.Visible = False
                Me.txtNomIntroductor.Visible = False

                Me.dgvDatos.Columns("MARCA_CTE_PROD").Visible = False
                Me.dgvDatos.Columns("MARCA_CTE_INTR").Visible = False
                Me.dgvDatos.Columns("MARCA_CTE_PROV").Visible = True

                Me.dgvDatos.Columns("NOM_CTE_PROD").Visible = False
                Me.dgvDatos.Columns("NOM_CTE_INTR").Visible = False
                Me.dgvDatos.Columns("NOM_CTE_PROV").Visible = True
        End Select

    End Sub




    Private Sub txtMarcaProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtMarcaProveedor.TextChanged

    End Sub
    Private Sub txtMarcaProductor_TextChanged(sender As Object, e As EventArgs) Handles txtMarcaProductor.TextChanged

    End Sub

    Private Sub txtMarcaIntroductor_TextChanged(sender As Object, e As EventArgs) Handles txtMarcaIntroductor.TextChanged

    End Sub
End Class