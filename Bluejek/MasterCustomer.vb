Imports System.Data.SqlClient
Public Class MasterCustomer
    Dim db As Database2Entities = New Database2Entities
    Dim db2 As Database2Entities = New Database2Entities
    Dim id As String
    Dim state As Integer = 0 '1 insert, 2 update

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub MasterOjek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvbackup.DataSource = From user In db2.Users Where user.Role = "USR" Select user

        dgvbackup.Visible = False
        btsave.Enabled = False
        btcancel.Enabled = False
        dgv1.DataSource = From user In db.Users Where user.Role = "USR" Select user

        dgv1.ClearSelection()
    End Sub

    Private Sub MasterCustomer_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Admin.Show()
    End Sub

    Private Sub dgv1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        Try
            id = dgv1.CurrentRow.Cells(0).Value.ToString()
            If id = Nothing Then
                MsgBox("Select a data!")
            Else
                Dim a As User = (From x In db.Users Where x.Id = id).FirstOrDefault()
                tbfname.Text = a.Firstname.ToString()
                tblname.Text = a.Lastname.ToString()
                tbemail.Text = a.Email.ToString()
                tbusername.Text = a.Username.ToString()
                tbpassword.Text = a.Password.ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        id = Nothing
    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        Try
            id = dgv1.CurrentRow.Cells(0).Value.ToString()
            If id = Nothing Then
                MsgBox("Select a data!")
            Else
                Dim a As User = (From x In db.Users Where x.Id = id).FirstOrDefault()
                db.Users.DeleteObject(a)
                db.SaveChanges()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        id = Nothing
    End Sub

    Private Sub btcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancel.Click
        btinsert.Enabled = True
        btupdate.Enabled = True
        btdelete.Enabled = True
        btsave.Enabled = False
        btcancel.Enabled = False
        tbfname.Text = Nothing
        tblname.Text = Nothing
        tbemail.Text = Nothing
        tbusername.Text = Nothing
        tbpassword.Text = Nothing
    End Sub

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
        Try
            If state = 1 Then 'insert state

                Dim counter As Integer = MainMenu.getUserCount()
                counter = counter + 1
                Dim genID As String = ""

                

                If tbfname.Text.Length = 0 Then
                    MessageBox.Show("First Name must be filled!")
                ElseIf tblname.Text.Length = 0 Then
                    MessageBox.Show("First Name must be filled!")
                ElseIf tbemail.Text.Length = 0 Then
                    MessageBox.Show("Email must be filled!")
                ElseIf tbemail.Text.Contains("@") = False Then
                    MessageBox.Show("Email must contain @")
                ElseIf Not tbemail.Text.Substring(tbemail.Text.Length - 4, 4) = ".com" Then
                    MessageBox.Show("Email must contain .com at the end")
                ElseIf tbusername.Text.Length = 0 Then
                    MessageBox.Show("Username must be filled")
                ElseIf tbusername.Text.Length < 5 Or tbusername.Text.Length > 20 Then
                    MessageBox.Show("Username must be more than 5 or less than 20 characters!")
                ElseIf tbpassword.Text.Length = 0 Then
                    MessageBox.Show("Password must be filled!")
                ElseIf tbpassword.Text.Length < 5 Or tbpassword.Text.Length > 20 Then
                    MessageBox.Show("Password must be more than 5 or less than 20 characters!")
                ElseIf tbpassword.Text.Length < 5 Or tbpassword.Text.Length > 20 Then
                    MessageBox.Show("Password cannot be more than 20 or less than 5 characters")
                Else
                    Dim newcust = New User
                    If counter < 10 Then
                        Dim num As Integer = 9

                        genID = "US00" + Convert.ToString(counter)
                    ElseIf counter >= 10 And counter < 100 Then
                        genID = "US0" + Convert.ToString(counter)
                    ElseIf counter >= 100 Then
                        genID = "US" + Convert.ToString(counter)
                    End If

                    newcust.Id = genID
                    newcust.Firstname = tbfname.Text
                    newcust.Lastname = tblname.Text
                    newcust.Email = tbemail.Text
                    newcust.Username = tbusername.Text
                    newcust.Password = tbpassword.Text
                    newcust.Role = "USR"


                    db.Users.AddObject(newcust)
                    db.SaveChanges()
                    state = 0
                    dgv1.DataSource = From user In db.Users Where user.Role = "USR" Select user
                End If

            ElseIf state = 2 Then 'update state
                id = dgv1.CurrentRow.Cells(0).Value.ToString()
                Dim upcust As User = (From x In db.Users Where x.Id = id Select x).FirstOrDefault()
                upcust.Firstname = tbfname.Text
                upcust.Lastname = tblname.Text
                upcust.Email = tbemail.Text
                upcust.Username = tbusername.Text
                upcust.Password = tbpassword.Text
                db.SaveChanges()
                dgv1.DataSource = From user In db.Users Where user.Role = "USR" Select user
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

    Private Sub btinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btinsert.Click

        state = 1
        btsave.Enabled = True
        btcancel.Enabled = True
        btinsert.Enabled = False
        btupdate.Enabled = False
        btdelete.Enabled = False
        id = Nothing
    End Sub
    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click

                state = 2
                btsave.Enabled = True
                btcancel.Enabled = True
                btinsert.Enabled = False
                btupdate.Enabled = False
                btdelete.Enabled = False

        id = Nothing

    End Sub

    Private Sub lbtest_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbtest.MouseHover
        lbtest.Text = lbtest.Text = id
    End Sub

    Private Sub tbfname_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbfname.TextChanged

    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class