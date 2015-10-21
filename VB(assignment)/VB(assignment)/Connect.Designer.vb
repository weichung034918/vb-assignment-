<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connect
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.testbutton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'testbutton
        '
        Me.testbutton.AutoSize = True
        Me.testbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.testbutton.Depth = 0
        Me.testbutton.Location = New System.Drawing.Point(93, 170)
        Me.testbutton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.testbutton.MouseState = MaterialSkin.MouseState.HOVER
        Me.testbutton.Name = "testbutton"
        Me.testbutton.Primary = False
        Me.testbutton.Size = New System.Drawing.Size(98, 36)
        Me.testbutton.TabIndex = 0
        Me.testbutton.Text = "Testbutton"
        Me.testbutton.UseVisualStyleBackColor = True
        '
        'Connect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.testbutton)
        Me.Name = "Connect"
        Me.Text = "Connect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents testbutton As MaterialSkin.Controls.MaterialFlatButton
End Class
