Imports System.Windows.Forms

Public Class frmBusProdListaPrec
    Dim iiD_cte As Integer
    Public Sub New(iiD_cte As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.iiD_cte = iiD_cte
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmBusProdListaPrec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_BUS_PROD_CTE.PRODUCTOS_CTE' Puede moverla o quitarla según sea necesario.
      

    End Sub

    Private Sub TXTFILTRO_TextChanged(sender As Object, e As EventArgs) Handles TXTFILTRO.TextChanged
        Me.PRODUCTOS_CTETableAdapter.Connection.ConnectionString = ConnectionString
        Me.PRODUCTOS_CTETableAdapter.Fill(Me.DS_BUS_PROD_CTE.PRODUCTOS_CTE, Me.TXTFILTRO.Text, Me.iiD_cte)
    End Sub
End Class
