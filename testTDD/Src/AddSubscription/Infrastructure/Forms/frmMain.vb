Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMain

    Private _conn
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _conn = New DBConnection()
        OnLoad()
    End Sub

    Private Sub OnLoad()
        emplenarComboEmpreses()

    End Sub

    Private Sub emplenarComboEmpreses()
        Dim query = "SELECT Name FROM Empreses"
        Dim ds As DataTable = _conn.doSelectQuery(query)
        cmbEmpreses.DataSource = ds
        cmbEmpreses.DisplayMember = "Name"
        cmbEmpreses.ValueMember = "Name"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empresa As String = cmbEmpreses.SelectedValue.ToString
        Dim quantitat As Integer = numQuantity.Value
        Dim addsub = New addSubscriptionToBusiness(New VOEmpreses(empresa), New VOSubscripcions(quantitat))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmConsult.Show()
    End Sub
End Class
