<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslog = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tslogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslog})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(827, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslog
        '
        Me.tslog.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslogin, Me.tsexit})
        Me.tslog.Image = CType(resources.GetObject("tslog.Image"), System.Drawing.Image)
        Me.tslog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tslog.Name = "tslog"
        Me.tslog.Size = New System.Drawing.Size(54, 22)
        Me.tslog.Text = "File"
        '
        'tslogin
        '
        Me.tslogin.Name = "tslogin"
        Me.tslogin.Size = New System.Drawing.Size(104, 22)
        Me.tslogin.Text = "Login"
        '
        'tsexit
        '
        Me.tsexit.Name = "tsexit"
        Me.tsexit.Size = New System.Drawing.Size(104, 22)
        Me.tsexit.Text = "Exit"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 544)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslog As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tslogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsexit As System.Windows.Forms.ToolStripMenuItem

End Class
