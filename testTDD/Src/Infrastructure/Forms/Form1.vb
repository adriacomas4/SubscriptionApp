Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1

    Private _conn
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _conn = New DBConnection("data source=localhost;initial catalog=testCodely;persist security info=True; Integrated Security=SSPI;")
        OnLoad()
    End Sub

    Private Sub OnLoad()
        emplenarComboEmpreses()

    End Sub

    Private Sub emplenarComboEmpreses()
        Dim query = "SELECT Name FROM Empreses"
        Dim ds As DataTable = _conn.doQuery(query)
        cmbEmpreses.DataSource = ds
        cmbEmpreses.DisplayMember = "Name"
        cmbEmpreses.ValueMember = "Name"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empresa = cmbEmpreses.SelectedValue.ToString
        Dim quantitat = txtSubs.Text
        addSubscription(empresa, quantitat)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpreses.SelectedIndexChanged

    End Sub
End Class
