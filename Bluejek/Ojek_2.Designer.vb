<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ojek_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ojek_2))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslog_cust = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tslogin_ojek = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsexit_ojek = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsuser_ojek = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tscust_menu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsojek_menu2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslog_cust, Me.tsuser_ojek})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslog_cust
        '
        Me.tslog_cust.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslogin_ojek, Me.tsexit_ojek})
        Me.tslog_cust.Image = CType(resources.GetObject("tslog_cust.Image"), System.Drawing.Image)
        Me.tslog_cust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tslog_cust.Name = "tslog_cust"
        Me.tslog_cust.Size = New System.Drawing.Size(54, 22)
        Me.tslog_cust.Text = "File"
        '
        'tslogin_ojek
        '
        Me.tslogin_ojek.Name = "tslogin_ojek"
        Me.tslogin_ojek.Size = New System.Drawing.Size(112, 22)
        Me.tslogin_ojek.Text = "Logout"
        '
        'tsexit_ojek
        '
        Me.tsexit_ojek.Name = "tsexit_ojek"
        Me.tsexit_ojek.Size = New System.Drawing.Size(112, 22)
        Me.tsexit_ojek.Text = "Exit"
        '
        'tsuser_ojek
        '
        Me.tsuser_ojek.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscust_menu1, Me.tsojek_menu2})
        Me.tsuser_ojek.Image = CType(resources.GetObject("tsuser_ojek.Image"), System.Drawing.Image)
        Me.tsuser_ojek.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsuser_ojek.Name = "tsuser_ojek"
        Me.tsuser_ojek.Size = New System.Drawing.Size(60, 22)
        Me.tsuser_ojek.Text = "Ojek"
        '
        'tscust_menu1
        '
        Me.tscust_menu1.Name = "tscust_menu1"
        Me.tscust_menu1.Size = New System.Drawing.Size(218, 22)
        Me.tscust_menu1.Text = "Take Order From Customer"
        '
        'tsojek_menu2
        '
        Me.tsojek_menu2.Name = "tsojek_menu2"
        Me.tsojek_menu2.Size = New System.Drawing.Size(218, 22)
        Me.tsojek_menu2.Text = "Order History"
        '
        'Ojek_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 544)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "Ojek_2"
        Me.Text = "Bluejek"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslog_cust As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tslogin_ojek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsexit_ojek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsuser_ojek As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tscust_menu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsojek_menu2 As System.Windows.Forms.ToolStripMenuItem

End Class
