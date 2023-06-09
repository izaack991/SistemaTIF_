Imports System.Data.SqlClient

Public Class clsMovimientoAlmacen
    Dim iOperacion As Integer
    Dim iNombre_Operacion As String
    Dim iMovimiento As Integer
    Dim iNombre As String
    Dim iEstatus As String
    Dim iExiste As Boolean

    Public Sub New()
        Me.InicializaValores()
    End Sub

    Public Sub New(ByVal aID_MOV As Integer)
        Try
            Dim lCmd As New SqlClient.SqlCommand
            Dim lSql As String
            Dim dt As New DataTable()

            lSql = "EXECUTE SP_CONS_CAT_MOVIMIENTOS " & aID_MOV.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                iOperacion = dt.Rows(0)("ID_OPER")
                iNombre_Operacion = dt.Rows(0)("NOM_OPER")
                iNombre = dt.Rows(0)("NOMBRE")
                iMovimiento = dt.Rows(0)("ID_MOV")
                iEstatus = dt.Rows(0)("ESTATUS")
                iExiste = True
            Else
                Me.InicializaValores()
            End If

            lCmd.Dispose()

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
        End Try
    End Sub

    Public Function Catalogo(Optional ByVal aID_OPER As Integer = 0) As DataTable
        Dim dt As New DataTable()
        Dim lCmd As New SqlClient.SqlCommand
        Dim lSql As String

        Try

            lSql = "EXECUTE SP_CONS_CAT_MOVIMIENTOS 0, " & aID_OPER.ToString

            lCmd.Connection = Cnn
            lCmd.CommandType = CommandType.Text
            lCmd.CommandText = lSql

            Dim da As New SqlDataAdapter(lCmd)
            da.Fill(dt)

            lCmd.Dispose()

            Return dt

        Catch ex As Exception
            modGeneral.ManejaExcepcion(ex)
            Return dt
        End Try
    End Function

    Private Sub InicializaValores()
        iOperacion = 0
        iNombre_Operacion = ""
        iMovimiento = 0
        iNombre = ""
        iEstatus = ""
        iExiste = True = False
    End Sub

    Public ReadOnly Property ID_OPER As Integer
        Get
            ID_OPER = iOperacion
        End Get
    End Property

    Public ReadOnly Property Nombre_Operacion As String
        Get
            Nombre_Operacion = iNombre_Operacion
        End Get
    End Property

    Public ReadOnly Property ID_MOV As Integer
        Get
            ID_MOV = iMovimiento
        End Get
    End Property

    Public ReadOnly Property Nombre_Movimiento As String
        Get
            Nombre_Movimiento = iNombre
        End Get
    End Property

    Public ReadOnly Property Estatus As Integer
        Get
            Estatus = iEstatus
        End Get
    End Property

    Public ReadOnly Property Existe As Boolean
        Get
            Existe = iExiste
        End Get
    End Property
End Class
