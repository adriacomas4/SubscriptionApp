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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grdDatos.DataSource = New FilterDataWithDate(_empresa.Id.Value, dtpFrom.Value, dtpTo.Value).filterDate
    End Sub
End Class