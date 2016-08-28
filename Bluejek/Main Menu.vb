Imports System.Data.SqlClient
Public Class MainMenu
    Dim db As Database2Entities = New Database2Entities

    Dim role As String
    Dim usercount As Integer = db.Users.Count()
    Dim ojekcount As Integer = db.Ojeks.Count()
    Dim locationcount As Integer = db.Locations.Count()

    Public Function getUserCount()
        Return usercount
    End Function

    Public Sub setUserCount(ByRef count As Integer)
        usercount = count
    End Sub
    Public Function getOjekCount()
        Return ojekcount
    End Function

    Public Sub setOjekCount(ByRef count As Integer)
        ojekcount = count
    End Sub
    Public Function getLocationCount()
        Return locationcount
    End Function

    Public Sub setLocationCount(ByRef count As Integer)
        locationcount = count
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tssbtfile_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub setRole(ByRef role2 As String)
        role = role2
    End Sub

    Public Function getRole()
        Return role
    End Function

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connection.connect()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lbrole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tslogin.Click

        If (tslogin.Text = "Login" And role = "") Then
            Me.Hide()
            Login.Show()
        ElseIf (tslogin.Text = "Logout" And role <> "") Then
            Me.Hide()
            Me.Show()
            role = ""
            tslogin.Text = "Login"
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsexit.Click
        Application.Exit()
    End Sub
End Class
