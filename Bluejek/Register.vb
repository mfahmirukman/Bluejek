Imports System.Data.SqlClient
Public Class Register
    Dim genID As String
    Dim db As Database2Entities = New Database2Entities

    Private Sub btsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsave.Click
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
            'generate genID via reading the database (primary key) perhaps
            'genID = "USXXX"
            'store these data and genID to database

            Dim counter As Integer
            Dim genID As String = ""
            Try
                counter = MainMenu.getUserCount() + 1
                If counter < 10 Then
                    genID = "US00" + Convert.ToString(counter)
                ElseIf counter >= 10 And counter < 100 Then
                    genID = "US0" + Convert.ToString(counter)
                ElseIf counter >= 100 Then
                    genID = "US" + Convert.ToString(counter)
                End If

                Dim b = New User
                b.Id = genID
                b.Firstname = tbfname.Text
                b.Lastname = tblname.Text
                b.Email = tbemail.Text
                b.Username = tbusername.Text
                b.Password = tbpassword.Text
                b.Role = "USR"
                db.Users.AddObject(b)
                db.SaveChanges()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            

            

            tbfname.Text = ""
            tblname.Text = ""
            tbemail.Text = ""
            tbusername.Text = ""
            listrecommendation.Text = ""
            tbpassword.Text = ""
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbfname.TextChanged
        For i As Integer = 0 To tbfname.Text.Length - 1
            If IsNumeric(tbfname.Text(i)) Then
                MessageBox.Show("Name must be character")
                tbfname.Text = ""
            ElseIf tbfname.Text(i) = " " Then
                MessageBox.Show("First name cannot have space")
                tbfname.Text = ""
            End If
        Next
    End Sub

    Private Sub tblname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblname.TextChanged
        For i As Integer = 0 To tblname.Text.Length - 1
            If IsNumeric(tblname.Text(i)) Then
                MessageBox.Show("Name must be character")
                tblname.Text = ""
            ElseIf tblname.Text(i) = " " Then
                MessageBox.Show("Last name cannot have space")
                tblname.Text = ""
            End If
        Next

        listrecommendation.Items.Clear()
        generateList()
    End Sub

    Private Function randomNum(ByRef upperbound As Integer, ByRef lowerbound As Integer)
        Dim num As String
        num = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Return num
    End Function

    Private Sub generateList()
        If tbfname.Text <> "" And tblname.Text <> "" Then
            listrecommendation.Items.Add(tbfname.Text(0) + tblname.Text)
            listrecommendation.Items.Add(tbfname.Text + tblname.Text(0))
            listrecommendation.Items.Add(tbfname.Text + tblname.Text)
            listrecommendation.Items.Add(tbfname.Text + tblname.Text(0) + randomNum(10, 98))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        listrecommendation.Items.Clear()
        generateList()
    End Sub

    Private Sub tbemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbemail.TextChanged

    End Sub

    Private Sub Register_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub

    Private Sub listrecommendation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listrecommendation.SelectedIndexChanged
        tbusername.Text = listrecommendation.SelectedItem.ToString()
    End Sub

    Private Sub tbpassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btsave.PerformClick()
        End If
    End Sub


    Private Sub bttest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttest.Click

    End Sub
End Class