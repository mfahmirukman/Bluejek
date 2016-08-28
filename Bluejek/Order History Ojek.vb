Imports System.Data.SqlClient
Public Class Order_History_Ojek
    Dim id As String
    Dim db As Database2Entities = New Database2Entities

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub Order_History_Ojek_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Ojek_2.Show()
    End Sub

    Private Sub Order_History_Ojek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ojek_id As String = Ojek_2.getUserID()
        dgv1.DataSource = From head In db.Headers Join user In db.Users On head.UserId Equals user.Id Join ojek In db.Ojeks On head.OjekId Equals ojek.Id Where head.OjekId.Contains(ojek_id) Select head.Id, head.TransactionDate, head.Status, Customer_Name = user.Firstname + " " + user.Lastname, Ojek_Name = ojek.Firstname + " " + ojek.Lastname
    End Sub

    Private Sub dgv1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        id = dgv1.CurrentRow.Cells(0).Value.ToString()
        Dim status As Header = (From x In db.Headers Where x.Id = id Select x).FirstOrDefault()
        If status.Status = "Not Arrived" Then
            btArrive.Enabled = True
        Else
            btArrive.Enabled = False
        End If
    End Sub

    Private Sub btArrive_Click(sender As System.Object, e As System.EventArgs) Handles btArrive.Click
        Try
            id = dgv1.CurrentRow.Cells(0).Value.ToString()
            Dim state As Header = (From x In db.Headers Where x.Id = id Select x).FirstOrDefault()
            state.Status = "Arrived"
            db.SaveChanges()
            Dim ojek_id As String = Ojek_2.getUserID()
            dgv1.DataSource = From head In db.Headers Join user In db.Users On head.UserId Equals user.Id Join ojek In db.Ojeks On head.OjekId Equals ojek.Id Where head.OjekId.Contains(ojek_id) Select head.Id, head.TransactionDate, head.Status, Customer_Name = user.Firstname + " " + user.Lastname, Ojek_Name = ojek.Firstname + " " + ojek.Lastname

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class