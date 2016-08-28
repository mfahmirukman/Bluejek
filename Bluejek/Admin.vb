Public Class Admin
    Dim usrid As String = ""
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tssbtfile_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connection.connect()
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Public Sub setUserID(ByRef id As String)
        usrid = id
    End Sub
    Public Function getUserID()
        Return usrid
    End Function

    Private Sub lbrole_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tslogin_ojek.Click

        If (tslogin_ojek.Text = "Logout") Then
            Me.Close()
            MainMenu.setRole("")
            MainMenu.Show()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles tsexit_admin.Click
        Application.Exit()
    End Sub

    Private Sub TextToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles tsadmin_menu2.Click
        Me.Hide()
        MasterCustomer.Show()
    End Sub

    Private Sub Admin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub tsadmin_menu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsadmin_menu1.Click
        Me.Hide()
        MasterOjek.Show()
    End Sub

    Private Sub tsadmin_menu3_Click(sender As System.Object, e As System.EventArgs) Handles tsadmin_menu3.Click
        Me.Hide()
        MasterLocation.Show()

    End Sub
End Class
