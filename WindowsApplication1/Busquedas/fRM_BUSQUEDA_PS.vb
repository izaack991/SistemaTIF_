Public Class fRM_BUSQUEDA_PS
    Dim Posicion As Integer
    Dim fecha As Date
    Dim Entro As Boolean
    Public Sub New(fecha As Date)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.fecha = fecha
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub fRM_BUSQUEDA_PS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SACRIFICIOTableAdapter.Connection.ConnectionString = ConnectionString
        Me.SACRIFICIOTableAdapter.Fill(Me.DS_PROG_SACRI.SACRIFICIO, "A", Me.fecha)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
       
        Entro = False
        Salir()
    End Sub
    Private Sub Salir()
        If Not Entro Then
            Posicion = Me.SACRIFICIOBindingSource.Position
        End If
        '  e.SuppressKeyPress = True
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Salir()
    End Sub

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.End Then
            Posicion = SACRIFICIOBindingSource.Position
            Entro = False
            e.SuppressKeyPress = True
            Salir()
        End If
      
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

    End Sub
End Class