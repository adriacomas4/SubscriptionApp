Public Class frmConsult

    Private _connection As DBConnection
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _connection = New DBConnection
    End Sub

    Private Sub frmConsult_Load(sender As Object, e As EventArgs) Handles Me.Load
        grdDatos.DataSource = _connection.DoSelectQuery("SELECT * FROM Empreses")
    End Sub
End Class