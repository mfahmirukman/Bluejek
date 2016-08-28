Imports System.Data.SqlClient
Public Class Take_Order
    Dim id As String
    Dim db As Database2Entities = New Database2Entities

    Private Sub Take_Order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv1.DataSource = From x In db.Headers Join loc In db.Locations On x.From_ID Equals loc.Id Join loc2 In db.Locations On x.To_ID Equals loc2.Id Where x.OjekId = Nothing Select x.Id, From_Location = loc.Location_Name, To_Location = loc2.Location_Name, x.Detail, x.TransactionDate

    End Sub

    Private Sub Take_Order_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Ojek_2.Show()
    End Sub

    Private Sub bttakeorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttakeorder.Click
        Try
            id = Int32.Parse(dgv1.CurrentRow.Cells(0).Value.ToString())
            If id = Nothing Then
                MsgBox("Select a data!")
            Else
                Dim a As Header = (From x In db.Headers Where x.Id = id).FirstOrDefault()
                a.OjekId = Ojek_2.getUserID()
                db.SaveChanges()
                lbtest.Text = a.OjekId
                MsgBox("Success!")
                dgv1.DataSource = From x In db.Headers Join loc In db.Locations On x.From_ID Equals loc.Id Join loc2 In db.Locations On x.To_ID Equals loc2.Id Where x.OjekId = Nothing Select x.Id, From_Location = loc.Location_Name, To_Location = loc2.Location_Name, x.Detail, x.TransactionDate
                Me.Hide()
                Ojek_2.Show()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        'db.MsMahasiswas.DeleteObject(a)
        'db.SaveChanges()
        'state = 0
        'tbName.Text = ""
        'tbMajor.Text = ""
        'tbName.Enabled = False
        'tbMajor.Enabled = False
        'dgv1.DataSource = From x In db.MsMahasiswas Select x
    End Sub
End Class