<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslog_cust = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tslogin_cust = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsexit_cust = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsuser_cust = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tscust_menu1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tscust_menu2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslog_cust, Me.tsuser_cust})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslog_cust
        '
        Me.tslog_cust.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslogin_cust, Me.tsexit_cust})
        Me.tslog_cust.Image = CType(resources.GetObject("tslog_cust.Image"), System.Drawing.Image)
        Me.tslog_cust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tslog_cust.Name = "tslog_cust"
        Me.tslog_cust.Size = New System.Drawing.Size(54, 22)
        Me.tslog_cust.Text = "File"
        '
        'tslogin_cust
        '
        Me.tslogin_cust.Name = "tslogin_cust"
        Me.tslogin_cust.Size = New System.Drawing.Size(112, 22)
        Me.tslogin_cust.Text = "Logout"
        '
        'tsexit_cust
        '
        Me.tsexit_cust.Name = "tsexit_cust"
        Me.tsexit_cust.Size = New System.Drawing.Size(112, 22)
        Me.tsexit_cust.Text = "Exit"
        '
        'tsuser_cust
        '
        Me.tsuser_cust.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscust_menu1, Me.tscust_menu2})
        Me.tsuser_cust.Image = CType(resources.GetObject("tsuser_cust.Image"), System.Drawing.Image)
        Me.tsuser_cust.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsuser_cust.Name = "tsuser_cust"
        Me.tsuser_cust.Size = New System.Drawing.Size(88, 22)
        Me.tsuser_cust.Text = "Customer"
        '
        'tscust_menu1
        '
        Me.tscust_menu1.Name = "tscust_menu1"
        Me.tscust_menu1.Size = New System.Drawing.Size(145, 22)
        Me.tscust_menu1.Text = "Make Order"
        '
        'tscust_menu2
        '
        Me.tscust_menu2.Name = "tscust_menu2"
        Me.tscust_menu2.Size = New System.Drawing.Size(145, 22)
        Me.tscust_menu2.Text = "Order History"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 544)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "Customer"
        Me.Text = "Bluejek"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslog_cust As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tslogin_cust As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsexit_cust As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsuser_cust As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tscust_menu1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tscust_menu2 As System.Windows.Forms.ToolStripMenuItem

End Class
