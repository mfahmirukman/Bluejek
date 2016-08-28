Imports System.Data.SqlClient
Public Class Login
    Dim db As Database2Entities = New Database2Entities

    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        If tbusername.Text.Length = 0 Then
            MessageBox.Show("Username must be filled!")

        ElseIf tbusername.Text.Length < 5 Or tbusername.Text.Length > 20 Then
            MessageBox.Show("Username cannot be more than 20 or less than 5 characters")

        ElseIf tbpassword.Text.Length = 0 Then
            MessageBox.Show("Password must be filled!")
        ElseIf tbpassword.Text.Length < 5 Or tbusername.Text.Length > 20 Then
            MessageBox.Show("Password cannot be more than 20 or less than 5 characters")

        ElseIf tbusername.Text.Length <> 0 And tbpassword.Text.Length <> 0 Then
            Dim usr As String = tbusername.Text
            Dim pw As String = tbpassword.Text
            Try
                Dim test1 As Boolean = (From x In db.Users Where x.Username = usr And x.Password = pw).Any()
                Dim test2 As Boolean = (From x In db.Ojeks Where x.Username = usr And x.Password = pw).Any()

                If test1 = True Then
                    Dim a As User = (From x In db.Users Where x.Username = usr And x.Password = pw).FirstOrDefault()
                    If a.Username = usr And a.Password = pw Then
                        If a.Role = "ADM" Then
                            MainMenu.setRole(a.Role)
                            Me.Hide()
                            MsgBox("Welcome " + a.Username)
                            Admin.Show()
                            Admin.setUserID(a.Id)
                        ElseIf a.Role = "USR" Then
                            MainMenu.setRole(a.Role)
                            Me.Hide()
                            MsgBox("Welcome " + a.Username)
                            Customer.Show()
                            Customer.setUserID(a.Id)
                        End If
                    End If
                ElseIf test2 = True Then
                    Dim b As Ojek = (From x In db.Ojeks Where x.Username = usr And x.Password = pw).FirstOrDefault()
                    If b.Username = usr And b.Password = pw Then
                        MainMenu.setRole("Ojek")
                        Me.Hide()
                        MsgBox("Welcome " + b.Username)
                        Ojek_2.Show()
                        Ojek_2.setUserID(b.Id)
                    End If
                ElseIf test1 = False And test2 = False Then
                    MsgBox("Username or password is wrong!")
                End If
                
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        tbusername.Text = ""
        tbpassword.Text = ""
    End Sub

    Private Sub btregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btregister.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcancel.Click
        Me.Hide()
        MainMenu.Show()
        tbusername.Text = ""
        tbpassword.Text = ""

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbusername.TextChanged

    End Sub

    Private Sub tbpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpassword.TextChanged

    End Sub

    Private Sub btregister_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btregister.MouseEnter
        btregister.Text = "REGISTER!"
    End Sub

    Private Sub btregister_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btregister.MouseLeave

        btregister.Text = "Register"
    End Sub

    Private Sub Login_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainMenu.Show()
    End Sub

    Private Sub tbpassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btlogin.PerformClick()
        End If
    End Sub

    Private Sub bttest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttest.Click
        Try
            Dim a As User = (From x In db.Users Where x.Username = "mfahmirukman").FirstOrDefault()
            lbtest.Text = a.Id
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
End Class