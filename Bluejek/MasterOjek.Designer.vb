<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterOjek
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbfname = New System.Windows.Forms.TextBox()
        Me.tblname = New System.Windows.Forms.TextBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.btinsert = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btcancel = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.dgvbackup = New System.Windows.Forms.DataGridView()
        Me.lbtest = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvbackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 12)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(998, 395)
        Me.dgv1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LastName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 506)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 542)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 576)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password"
        '
        'tbfname
        '
        Me.tbfname.Location = New System.Drawing.Point(96, 430)
        Me.tbfname.Name = "tbfname"
        Me.tbfname.Size = New System.Drawing.Size(153, 20)
        Me.tbfname.TabIndex = 6
        '
        'tblname
        '
        Me.tblname.Location = New System.Drawing.Point(96, 466)
        Me.tblname.Name = "tblname"
        Me.tblname.Size = New System.Drawing.Size(153, 20)
        Me.tblname.TabIndex = 7
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(96, 503)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(153, 20)
        Me.tbemail.TabIndex = 8
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(96, 539)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(153, 20)
        Me.tbusername.TabIndex = 9
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(96, 573)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(153, 20)
        Me.tbpassword.TabIndex = 10
        '
        'btinsert
        '
        Me.btinsert.Location = New System.Drawing.Point(373, 458)
        Me.btinsert.Name = "btinsert"
        Me.btinsert.Size = New System.Drawing.Size(75, 23)
        Me.btinsert.TabIndex = 11
        Me.btinsert.Text = "Insert"
        Me.btinsert.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(373, 500)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(75, 23)
        Me.btupdate.TabIndex = 12
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(373, 542)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 23)
        Me.btdelete.TabIndex = 13
        Me.btdelete.Text = "Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btcancel
        '
        Me.btcancel.Location = New System.Drawing.Point(465, 522)
        Me.btcancel.Name = "btcancel"
        Me.btcancel.Size = New System.Drawing.Size(75, 23)
        Me.btcancel.TabIndex = 14
        Me.btcancel.Text = "Cancel"
        Me.btcancel.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(465, 481)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 23)
        Me.btsave.TabIndex = 15
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'dgvbackup
        '
        Me.dgvbackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbackup.Location = New System.Drawing.Point(671, 469)
        Me.dgvbackup.Name = "dgvbackup"
        Me.dgvbackup.Size = New System.Drawing.Size(81, 19)
        Me.dgvbackup.TabIndex = 16
        '
        'lbtest
        '
        Me.lbtest.AutoSize = True
        Me.lbtest.Location = New System.Drawing.Point(837, 500)
        Me.lbtest.Name = "lbtest"
        Me.lbtest.Size = New System.Drawing.Size(39, 13)
        Me.lbtest.TabIndex = 17
        Me.lbtest.Text = "Label6"
        '
        'MasterCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 608)
        Me.Controls.Add(Me.lbtest)
        Me.Controls.Add(Me.dgvbackup)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.btcancel)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.btinsert)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.tbemail)
        Me.Controls.Add(Me.tblname)
        Me.Controls.Add(Me.tbfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "MasterCustomer"
        Me.Text = "MasterCustomer"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvbackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbfname As System.Windows.Forms.TextBox
    Friend WithEvents tblname As System.Windows.Forms.TextBox
    Friend WithEvents tbemail As System.Windows.Forms.TextBox
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents btinsert As System.Windows.Forms.Button
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents btdelete As System.Windows.Forms.Button
    Friend WithEvents btcancel As System.Windows.Forms.Button
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents dgvbackup As System.Windows.Forms.DataGridView
    Friend WithEvents lbtest As System.Windows.Forms.Label
End Class
