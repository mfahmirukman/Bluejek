Public Class Customer
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

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tslogin_cust.Click

        If (tslogin_cust.Text = "Logout") Then
            Me.Close()
            MainMenu.setRole("")
            MainMenu.Show()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles tsexit_cust.Click
        Application.Exit()
    End Sub

    Private Sub TextToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles tscust_menu2.Click
        Me.Hide()
        Order_History_Cust.Show()
    End Sub

    Private Sub tscust_menu1_Click(sender As System.Object, e As System.EventArgs) Handles tscust_menu1.Click
        Me.Hide()
        NewOrder.Show()
    End Sub

    Private Sub Customer_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Login.Show()
    End Sub

End Class
