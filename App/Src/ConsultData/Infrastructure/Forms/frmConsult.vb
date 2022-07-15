Public Class frmConsult

    Private _conn As DBConnection
    Private _empresa As Business
    Sub New(parempresa As Business)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _conn = New DBConnection
        _empresa = parempresa
    End Sub

    Private Sub frmConsult_Load(sender As Object, e As EventArgs) Handles Me.Load
        grdDatos.DataSource = New SelectQueryDB(_conn.Connection) _
            .executeSelectQuery($"SELECT quantity AS Quantity, price AS Price, datatrans AS Data FROM SubsTransaction WHERE empresa = {_empresa.Id.Value}")
    End Sub
End Class