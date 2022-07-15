Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMain

    Private _conn
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _conn = New DBConnection()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        emplenarComboEmpreses()
    End Sub


    Private Sub emplenarComboEmpreses()
        Dim query = "SELECT id, Name, quantity FROM Empreses"
        Dim ds As DataTable = _conn.doSelectQuery(query)
        cmbEmpreses.DataSource = ds
        cmbEmpreses.DisplayMember = "Name"
        cmbEmpreses.ValueMember = "Name"
        cmbEmpreses.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEmpreses.SelectedIndex = -1
        actualizarcontador()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As Empresa = getEmpresa()
        Dim addsub = New addSubscriptionToBusiness(New SubsToBusinessDatabase, New AddTransactionBusinessDatabase,
                                                   emp, numQuantity.Value)
        emplenarComboEmpreses()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As frmConsult = New frmConsult(getEmpresa)
        frm.Show()
    End Sub

    Private Sub cmbEmpreses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpreses.SelectedIndexChanged
        actualizarcontador()
    End Sub

    Private Sub actualizarcontador()
        If cmbEmpreses.SelectedIndex <> -1 Then
            lblDisp.Visible = True
            lblDisp.Text = $"Tiene {getEmpresa.Quantity.value} suscripciones"
        Else
            lblDisp.Visible = False
        End If
    End Sub


    Private Function getEmpresa() As Empresa

        Dim emp As DataRowView = cmbEmpreses.SelectedItem
        Dim newempresa As Empresa
        With emp.Row
            newempresa = New Empresa(New EmpresaId(.Item("id")), New EmpresaName(.Item("Name")), New EmpresaQuantity(.Item("quantity")))
        End With
        Return newempresa
    End Function

End Class
