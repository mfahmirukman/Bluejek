Imports System.Data.SqlClient


Public Class MasterLocation
    Dim state As Integer = 0
    Dim db As Database2Entities = New Database2Entities
    Dim id As Integer

    Private Sub MasterLocation_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Admin.Show()

    End Sub

    Private Sub MasterLocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgv1.DataSource = From x In db.Locations Select x
        btsave.Enabled = False
        btcancel.Enabled = False
    End Sub

    Private Sub btinsert_Click(sender As System.Object, e As System.EventArgs) Handles btinsert.Click
        state = 1
        btsave.Enabled = True
        btcancel.Enabled = True
        btinsert.Enabled = False
        btupdate.Enabled = False
        btdelete.Enabled = False
    End Sub

    Private Sub btcancel_Click(sender As System.Object, e As System.EventArgs) Handles btcancel.Click
        btinsert.Enabled = True
        btupdate.Enabled = True
        btdelete.Enabled = True
        btsave.Enabled = False
        btcancel.Enabled = False
    End Sub

    Private Sub btupdate_Click(sender As System.Object, e As System.EventArgs) Handles btupdate.Click
        state = 2
        btsave.Enabled = True
        btcancel.Enabled = True
        btinsert.Enabled = False
        btupdate.Enabled = False
        btdelete.Enabled = False
    End Sub

    Private Sub btdelete_Click(sender As System.Object, e As System.EventArgs) Handles btdelete.Click
        Try
            id = dgv1.CurrentRow.Cells(0).Value.ToString()
            If id = Nothing Then
                MsgBox("Select a data!")
            Else
                Dim a As Location = (From x In db.Locations Where x.Id = id).FirstOrDefault()
                db.Locations.DeleteObject(a)
                db.SaveChanges()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btsave_Click(sender As System.Object, e As System.EventArgs) Handles btsave.Click
        Try
            If state = 1 Then 'insert state

                Dim counter As Integer = MainMenu.getLocationCount()
                counter = counter + 1
                If tblocation.Text.Length = 0 Then
                    MsgBox("Location cannot be empty!")
                Else
                    Dim loc = New Location
                    loc.Id = counter
                    loc.Location_Name = tblocation.Text
                    db.Locations.AddObject(loc)
                    db.SaveChanges()
                    state = 0
                    dgv1.DataSource = From x In db.Locations Select x
                End If

            ElseIf state = 2 Then 'update state
                id = dgv1.CurrentRow.Cells(0).Value.ToString()
                Dim loc As Location = (From x In db.Locations Where x.Id = id Select x).FirstOrDefault()
                loc.Location_Name = tblocation.Text
                db.SaveChanges()
                dgv1.DataSource = From x In db.Locations Select x
                state = 0

                btinsert.Enabled = True
                btupdate.Enabled = True
                btdelete.Enabled = True
                btsave.Enabled = False
                btcancel.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        Try
            id = dgv1.CurrentRow.Cells(0).Value.ToString()
            If id = Nothing Then
                MsgBox("Select a data!")
            Else
                Dim a As Location = (From x In db.Locations Where x.Id = id).FirstOrDefault()
                tblocation.Text = a.Location_Name.ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        id = Nothing
    End Sub
End Class