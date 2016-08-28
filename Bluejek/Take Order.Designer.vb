<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Take_Order
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
        Me.bttakeorder = New System.Windows.Forms.Button()
        Me.lbtest = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 12)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(629, 234)
        Me.dgv1.TabIndex = 0
        '
        'bttakeorder
        '
        Me.bttakeorder.Location = New System.Drawing.Point(252, 280)
        Me.bttakeorder.Name = "bttakeorder"
        Me.bttakeorder.Size = New System.Drawing.Size(131, 56)
        Me.bttakeorder.TabIndex = 1
        Me.bttakeorder.Text = "Take Order"
        Me.bttakeorder.UseVisualStyleBackColor = True
        '
        'lbtest
        '
        Me.lbtest.AutoSize = True
        Me.lbtest.Location = New System.Drawing.Point(69, 280)
        Me.lbtest.Name = "lbtest"
        Me.lbtest.Size = New System.Drawing.Size(39, 13)
        Me.lbtest.TabIndex = 2
        Me.lbtest.Text = "Label1"
        '
        'Take_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 348)
        Me.Controls.Add(Me.lbtest)
        Me.Controls.Add(Me.bttakeorder)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "Take_Order"
        Me.Text = "Take Order"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents bttakeorder As System.Windows.Forms.Button
    Friend WithEvents lbtest As System.Windows.Forms.Label
End Class
