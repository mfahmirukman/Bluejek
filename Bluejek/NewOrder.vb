Imports System.Data.SqlClient
Public Class NewOrder
    Dim db As Database2Entities = New Database2Entities
    Private Sub btorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btorder.Click
        'finding last index to be added fo the last
        Dim a = From x In db.Headers

        Dim temp As Integer
        Try
            For Each result In a
                temp = result.Id
            Next
            temp = temp + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        Try
            Dim h = New Header
            h.Id = Convert.ToString(temp)
            h.UserId = Customer.getUserID()
            'h.ojekid = null
            Dim from_s As String = cbfrom.SelectedItem.ToString()
            Dim to_s As String = cbto.SelectedItem.ToString()
            Dim loc_from As Location = (From x In db.Locations Where x.Location_Name = from_s).FirstOrDefault()
            Dim loc_to As Location = (From x In db.Locations Where x.Location_Name = to_s).FirstOrDefault()

            Dim d As Date = Today
            h.From_ID = loc_from.Id
            h.To_ID = loc_to.Id
            h.TransactionDate = d
            h.Detail = tbdetail.Text
            h.Status = "Not Arrived"
            db.Headers.AddObject(h)
            db.SaveChanges()
            MsgBox("Your order has been completed")
            Me.Close()
            Customer.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        

    End Sub

    Private Sub btorder_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btorder.MouseHover

    End Sub

    Private Sub NewOrder_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Customer.Show()
    End Sub

    Private Sub NewOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim count = db.Locations.Count()
        For i As Integer = 1 To count
            Dim a As Location = (From x In db.Locations Where x.Id = i).FirstOrDefault()
            cbfrom.Items.Add(a.Location_Name)
        Next

        For i As Integer = 1 To count
            Dim a As Location = (From x In db.Locations Where x.Id = i).FirstOrDefault()
            cbto.Items.Add(a.Location_Name)
        Next

    End Sub

    Private Sub cbfrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbfrom.SelectedIndexChanged

    End Sub
End Class