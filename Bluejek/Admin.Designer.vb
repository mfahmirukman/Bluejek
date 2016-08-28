<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslog_admin = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tslogin_ojek = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsexit_admin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsuser_admin = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsadmin_menu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsadmin_menu2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsadmin_menu3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslog_admin, Me.tsuser_admin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslog_admin
        '
        Me.tslog_admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslogin_ojek, Me.tsexit_admin})
        Me.tslog_admin.Image = CType(resources.GetObject("tslog_admin.Image"), System.Drawing.Image)
        Me.tslog_admin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tslog_admin.Name = "tslog_admin"
        Me.tslog_admin.Size = New System.Drawing.Size(52, 22)
        Me.tslog_admin.Text = "File"
        '
        'tslogin_ojek
        '
        Me.tslogin_ojek.Name = "tslogin_ojek"
        Me.tslogin_ojek.Size = New System.Drawing.Size(107, 22)
        Me.tslogin_ojek.Text = "Logout"
        '
        'tsexit_admin
        '
        Me.tsexit_admin.Name = "tsexit_admin"
        Me.tsexit_admin.Size = New System.Drawing.Size(107, 22)
        Me.tsexit_admin.Text = "Exit"
        '
        'tsuser_admin
        '
        Me.tsuser_admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsadmin_menu1, Me.tsadmin_menu2, Me.tsadmin_menu3})
        Me.tsuser_admin.Image = CType(resources.GetObject("tsuser_admin.Image"), System.Drawing.Image)
        Me.tsuser_admin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsuser_admin.Name = "tsuser_admin"
        Me.tsuser_admin.Size = New System.Drawing.Size(65, 22)
        Me.tsuser_admin.Text = "Admin"
        '
        'tsadmin_menu1
        '
        Me.tsadmin_menu1.Name = "tsadmin_menu1"
        Me.tsadmin_menu1.Size = New System.Drawing.Size(152, 22)
        Me.tsadmin_menu1.Text = "Ojek"
        '
        'tsadmin_menu2
        '
        Me.tsadmin_menu2.Name = "tsadmin_menu2"
        Me.tsadmin_menu2.Size = New System.Drawing.Size(152, 22)
        Me.tsadmin_menu2.Text = "Customer"
        '
        'tsadmin_menu3
        '
        Me.tsadmin_menu3.Name = "tsadmin_menu3"
        Me.tsadmin_menu3.Size = New System.Drawing.Size(152, 22)
        Me.tsadmin_menu3.Text = "Location"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 544)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.Text = "Bluejek"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslog_admin As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tslogin_ojek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsexit_admin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsuser_admin As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsadmin_menu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsadmin_menu2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsadmin_menu3 As System.Windows.Forms.ToolStripMenuItem

End Class
