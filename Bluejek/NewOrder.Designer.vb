<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewOrder
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
        Me.lbfrom = New System.Windows.Forms.Label()
        Me.lbdetail = New System.Windows.Forms.Label()
        Me.lbto = New System.Windows.Forms.Label()
        Me.cbfrom = New System.Windows.Forms.ComboBox()
        Me.cbto = New System.Windows.Forms.ComboBox()
        Me.tbdetail = New System.Windows.Forms.TextBox()
        Me.btorder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbfrom
        '
        Me.lbfrom.AutoSize = True
        Me.lbfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfrom.Location = New System.Drawing.Point(13, 13)
        Me.lbfrom.Name = "lbfrom"
        Me.lbfrom.Size = New System.Drawing.Size(46, 20)
        Me.lbfrom.TabIndex = 0
        Me.lbfrom.Text = "From"
        '
        'lbdetail
        '
        Me.lbdetail.AutoSize = True
        Me.lbdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdetail.Location = New System.Drawing.Point(13, 57)
        Me.lbdetail.Name = "lbdetail"
        Me.lbdetail.Size = New System.Drawing.Size(50, 20)
        Me.lbdetail.TabIndex = 1
        Me.lbdetail.Text = "Detail"
        '
        'lbto
        '
        Me.lbto.AutoSize = True
        Me.lbto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbto.Location = New System.Drawing.Point(13, 116)
        Me.lbto.Name = "lbto"
        Me.lbto.Size = New System.Drawing.Size(27, 20)
        Me.lbto.TabIndex = 2
        Me.lbto.Text = "To"
        '
        'cbfrom
        '
        Me.cbfrom.FormattingEnabled = True
        Me.cbfrom.Location = New System.Drawing.Point(121, 11)
        Me.cbfrom.Name = "cbfrom"
        Me.cbfrom.Size = New System.Drawing.Size(121, 21)
        Me.cbfrom.TabIndex = 3
        '
        'cbto
        '
        Me.cbto.FormattingEnabled = True
        Me.cbto.Location = New System.Drawing.Point(121, 115)
        Me.cbto.Name = "cbto"
        Me.cbto.Size = New System.Drawing.Size(121, 21)
        Me.cbto.TabIndex = 4
        '
        'tbdetail
        '
        Me.tbdetail.Location = New System.Drawing.Point(121, 57)
        Me.tbdetail.Name = "tbdetail"
        Me.tbdetail.Size = New System.Drawing.Size(121, 20)
        Me.tbdetail.TabIndex = 5
        '
        'btorder
        '
        Me.btorder.Location = New System.Drawing.Point(95, 200)
        Me.btorder.Name = "btorder"
        Me.btorder.Size = New System.Drawing.Size(92, 50)
        Me.btorder.TabIndex = 6
        Me.btorder.Text = "Order Now"
        Me.btorder.UseVisualStyleBackColor = True
        '
        'NewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btorder)
        Me.Controls.Add(Me.tbdetail)
        Me.Controls.Add(Me.cbto)
        Me.Controls.Add(Me.cbfrom)
        Me.Controls.Add(Me.lbto)
        Me.Controls.Add(Me.lbdetail)
        Me.Controls.Add(Me.lbfrom)
        Me.Name = "NewOrder"
        Me.Text = "NewOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbfrom As System.Windows.Forms.Label
    Friend WithEvents lbdetail As System.Windows.Forms.Label
    Friend WithEvents lbto As System.Windows.Forms.Label
    Friend WithEvents cbfrom As System.Windows.Forms.ComboBox
    Friend WithEvents cbto As System.Windows.Forms.ComboBox
    Friend WithEvents tbdetail As System.Windows.Forms.TextBox
    Friend WithEvents btorder As System.Windows.Forms.Button
End Class
