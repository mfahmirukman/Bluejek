<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.lbfname = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbemail = New System.Windows.Forms.Label()
        Me.lbrecommendation = New System.Windows.Forms.Label()
        Me.lbpassword = New System.Windows.Forms.Label()
        Me.btsave = New System.Windows.Forms.Button()
        Me.tbfname = New System.Windows.Forms.TextBox()
        Me.tblname = New System.Windows.Forms.TextBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.listrecommendation = New System.Windows.Forms.ListBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.lbusername = New System.Windows.Forms.Label()
        Me.tbtest = New System.Windows.Forms.Label()
        Me.bttest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbfname
        '
        Me.lbfname.AutoSize = True
        Me.lbfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfname.Location = New System.Drawing.Point(12, 23)
        Me.lbfname.Name = "lbfname"
        Me.lbfname.Size = New System.Drawing.Size(86, 20)
        Me.lbfname.TabIndex = 0
        Me.lbfname.Text = "First Name"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(12, 73)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(86, 20)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Last Name"
        '
        'lbemail
        '
        Me.lbemail.AutoSize = True
        Me.lbemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbemail.Location = New System.Drawing.Point(12, 125)
        Me.lbemail.Name = "lbemail"
        Me.lbemail.Size = New System.Drawing.Size(48, 20)
        Me.lbemail.TabIndex = 2
        Me.lbemail.Text = "Email"
        '
        'lbrecommendation
        '
        Me.lbrecommendation.AutoSize = True
        Me.lbrecommendation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrecommendation.Location = New System.Drawing.Point(54, 233)
        Me.lbrecommendation.Name = "lbrecommendation"
        Me.lbrecommendation.Size = New System.Drawing.Size(135, 20)
        Me.lbrecommendation.TabIndex = 3
        Me.lbrecommendation.Text = "Recommendation"
        '
        'lbpassword
        '
        Me.lbpassword.AutoSize = True
        Me.lbpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpassword.Location = New System.Drawing.Point(12, 343)
        Me.lbpassword.Name = "lbpassword"
        Me.lbpassword.Size = New System.Drawing.Size(78, 20)
        Me.lbpassword.TabIndex = 4
        Me.lbpassword.Text = "Password"
        '
        'btsave
        '
        Me.btsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.Location = New System.Drawing.Point(16, 411)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(129, 30)
        Me.btsave.TabIndex = 5
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'tbfname
        '
        Me.tbfname.Location = New System.Drawing.Point(215, 26)
        Me.tbfname.Name = "tbfname"
        Me.tbfname.Size = New System.Drawing.Size(135, 20)
        Me.tbfname.TabIndex = 6
        '
        'tblname
        '
        Me.tblname.Location = New System.Drawing.Point(215, 73)
        Me.tblname.Name = "tblname"
        Me.tblname.Size = New System.Drawing.Size(135, 20)
        Me.tblname.TabIndex = 7
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(215, 125)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(135, 20)
        Me.tbemail.TabIndex = 8
        '
        'listrecommendation
        '
        Me.listrecommendation.FormattingEnabled = True
        Me.listrecommendation.Location = New System.Drawing.Point(58, 261)
        Me.listrecommendation.Name = "listrecommendation"
        Me.listrecommendation.Size = New System.Drawing.Size(292, 56)
        Me.listrecommendation.TabIndex = 9
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(215, 343)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassword.Size = New System.Drawing.Size(135, 20)
        Me.tbpassword.TabIndex = 10
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(215, 181)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(135, 20)
        Me.tbusername.TabIndex = 12
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.Location = New System.Drawing.Point(12, 181)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(83, 20)
        Me.lbusername.TabIndex = 11
        Me.lbusername.Text = "Username"
        '
        'tbtest
        '
        Me.tbtest.AutoSize = True
        Me.tbtest.Location = New System.Drawing.Point(215, 411)
        Me.tbtest.Name = "tbtest"
        Me.tbtest.Size = New System.Drawing.Size(39, 13)
        Me.tbtest.TabIndex = 13
        Me.tbtest.Text = "Label1"
        '
        'bttest
        '
        Me.bttest.Location = New System.Drawing.Point(178, 461)
        Me.bttest.Name = "bttest"
        Me.bttest.Size = New System.Drawing.Size(75, 23)
        Me.bttest.TabIndex = 14
        Me.bttest.Text = "Button1"
        Me.bttest.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 532)
        Me.Controls.Add(Me.bttest)
        Me.Controls.Add(Me.tbtest)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.lbusername)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.listrecommendation)
        Me.Controls.Add(Me.tbemail)
        Me.Controls.Add(Me.tblname)
        Me.Controls.Add(Me.tbfname)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.lbpassword)
        Me.Controls.Add(Me.lbrecommendation)
        Me.Controls.Add(Me.lbemail)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbfname)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbfname As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lbemail As System.Windows.Forms.Label
    Friend WithEvents lbrecommendation As System.Windows.Forms.Label
    Friend WithEvents lbpassword As System.Windows.Forms.Label
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents tbfname As System.Windows.Forms.TextBox
    Friend WithEvents tblname As System.Windows.Forms.TextBox
    Friend WithEvents tbemail As System.Windows.Forms.TextBox
    Friend WithEvents listrecommendation As System.Windows.Forms.ListBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents tbtest As System.Windows.Forms.Label
    Friend WithEvents bttest As System.Windows.Forms.Button
End Class
