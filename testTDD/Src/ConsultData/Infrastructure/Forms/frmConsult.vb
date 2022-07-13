Public Class frmConsult

    Private _connection As DBConnection
    Private _empresa As Empresa
    Sub New(parempresa As Empresa)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _connection = New DBConnection
        _empresa = parempresa
    End Sub

    Private Sub frmConsult_Load(sender As Object, e As EventArgs) Handles Me.Load
        grdDatos.DataSource = _connection.DoSelectQuery($"SELECT quantity AS Quantity, price AS Price FROM SubsTransaction WHERE empresa = {_empresa.Id}")
    End Sub
End Class