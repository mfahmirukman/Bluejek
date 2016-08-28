Imports System.Data.SqlClient
Public Class Order_History_Cust
    Dim db As Database2Entities = New Database2Entities
    Dim state As Integer = 0
    Dim id As Integer = 0

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub Order_History_Cust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usrid = Customer.getUserID()
        dgv1.DataSource = From head In db.Headers Join loc In db.Locations On head.From_ID Equals loc.Id Join loc2 In db.Locations On head.To_ID Equals loc2.Id Where head.UserId.Contains(usrid) Select head.Id, head.TransactionDate, From_Location = loc.Location_Name, To_Location = loc2.Location_Name, head.Status 'selectall
    End Sub

    Private Sub Order_History_Cust_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Customer.Show()
    End Sub
End Class