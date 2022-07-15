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
        Dim ds As DataTable = New getAllBusiness(New BusinessDatabase).getBusiness
        cmbEmpreses.DataSource = ds
        cmbEmpreses.DisplayMember = "name"
        cmbEmpreses.ValueMember = "name"
        cmbEmpreses.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEmpreses.SelectedIndex = -1
        actualizarcontador()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbEmpreses.SelectedIndex <> -1 Then
            Dim emp As Business = getEmpresa()
            Dim addsub = New addSubscriptionToBusiness(New BusinessDatabase, New PurchaseDatabase, emp, numQuantity.Value)
            numQuantity.Value = 0
            emplenarComboEmpreses()
        Else
            MsgBox("Selecciona una empresa de la lista.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cmbEmpreses.SelectedIndex <> -1 Then
            Dim frm As frmConsult = New frmConsult(getEmpresa)
            frm.Show()
        Else
            MsgBox("Selecciona una empresa de la lista.")
        End If
    End Sub

    Private Sub cmbEmpreses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpreses.SelectedIndexChanged
        numQuantity.Value = 0
        actualizarcontador()
    End Sub

    Private Sub actualizarcontador()
        If cmbEmpreses.SelectedIndex <> -1 Then
            lblDisp.Visible = True
            lblDisp.Text = $"Tiene {getEmpresa.Quantity.Value} suscripciones"
        Else
            lblDisp.Visible = False
        End If
    End Sub


    Private Function getEmpresa() As Business
        Dim emp As DataRowView = cmbEmpreses.SelectedItem
        Dim newempresa As Business
        With emp.Row
            newempresa = New Business(New VOBusinessId(.Item("id")), New VOBusinessName(.Item("Name")), New VOBusinessQuantity(.Item("quantity")))
        End With
        Return newempresa
    End Function

End Class
