<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbuser = New System.Windows.Forms.Label()
        Me.lbpass = New System.Windows.Forms.Label()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btcancel = New System.Windows.Forms.Button()
        Me.btregister = New System.Windows.Forms.Button()
        Me.bttest = New System.Windows.Forms.Button()
        Me.lbtest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbuser
        '
        Me.lbuser.AutoSize = True
        Me.lbuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbuser.Location = New System.Drawing.Point(13, 22)
        Me.lbuser.Name = "lbuser"
        Me.lbuser.Size = New System.Drawing.Size(97, 24)
        Me.lbuser.TabIndex = 0
        Me.lbuser.Text = "Username"
        '
        'lbpass
        '
        Me.lbpass.AutoSize = True
        Me.lbpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpass.Location = New System.Drawing.Point(13, 60)
        Me.lbpass.Name = "lbpass"
        Me.lbpass.Size = New System.Drawing.Size(92, 24)
        Me.lbpass.TabIndex = 1
        Me.lbpass.Text = "Password"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(145, 27)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(139, 20)
        Me.tbusername.TabIndex = 2
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(145, 65)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassword.Size = New System.Drawing.Size(139, 20)
        Me.tbpassword.TabIndex = 3
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(17, 154)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(88, 37)
        Me.btlogin.TabIndex = 4
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'btcancel
        '
        Me.btcancel.Location = New System.Drawing.Point(111, 154)
        Me.btcancel.Name = "btcancel"
        Me.btcancel.Size = New System.Drawing.Size(85, 37)
        Me.btcancel.TabIndex = 5
        Me.btcancel.Text = "Cancel"
        Me.btcancel.UseVisualStyleBackColor = True
        '
        'btregister
        '
        Me.btregister.Location = New System.Drawing.Point(202, 154)
        Me.btregister.Name = "btregister"
        Me.btregister.Size = New System.Drawing.Size(82, 37)
        Me.btregister.TabIndex = 6
        Me.btregister.Text = "Register"
        Me.btregister.UseVisualStyleBackColor = True
        '
        'bttest
        '
        Me.bttest.Location = New System.Drawing.Point(202, 118)
        Me.bttest.Name = "bttest"
        Me.bttest.Size = New System.Drawing.Size(75, 23)
        Me.bttest.TabIndex = 7
        Me.bttest.Text = "Button1"
        Me.bttest.UseVisualStyleBackColor = True
        '
        'lbtest
        '
        Me.lbtest.AutoSize = True
        Me.lbtest.Location = New System.Drawing.Point(135, 118)
        Me.lbtest.Name = "lbtest"
        Me.lbtest.Size = New System.Drawing.Size(39, 13)
        Me.lbtest.TabIndex = 8
        Me.lbtest.Text = "Label1"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 198)
        Me.Controls.Add(Me.lbtest)
        Me.Controls.Add(Me.bttest)
        Me.Controls.Add(Me.btregister)
        Me.Controls.Add(Me.btcancel)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.lbpass)
        Me.Controls.Add(Me.lbuser)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbuser As System.Windows.Forms.Label
    Friend WithEvents lbpass As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents btlogin As System.Windows.Forms.Button
    Friend WithEvents btcancel As System.Windows.Forms.Button
    Friend WithEvents btregister As System.Windows.Forms.Button
    Friend WithEvents bttest As System.Windows.Forms.Button
    Friend WithEvents lbtest As System.Windows.Forms.Label
End Class
