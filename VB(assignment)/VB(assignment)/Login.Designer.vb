<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.login_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.field_username = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.field_pwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.AutoSize = True
        Me.login_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.login_btn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.login_btn.Depth = 0
        Me.login_btn.Location = New System.Drawing.Point(106, 179)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.login_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Primary = False
        Me.login_btn.Size = New System.Drawing.Size(52, 36)
        Me.login_btn.TabIndex = 0
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(53, 81)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel1.TabIndex = 5
        Me.MaterialLabel1.Text = "Username"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(54, 130)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(75, 19)
        Me.MaterialLabel2.TabIndex = 6
        Me.MaterialLabel2.Text = "Password"
        '
        'field_username
        '
        Me.field_username.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.field_username.Depth = 0
        Me.field_username.ForeColor = System.Drawing.SystemColors.ControlText
        Me.field_username.Hint = ""
        Me.field_username.Location = New System.Drawing.Point(54, 103)
        Me.field_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.field_username.Name = "field_username"
        Me.field_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.field_username.SelectedText = ""
        Me.field_username.SelectionLength = 0
        Me.field_username.SelectionStart = 0
        Me.field_username.Size = New System.Drawing.Size(160, 23)
        Me.field_username.TabIndex = 7
        Me.field_username.UseSystemPasswordChar = False
        '
        'field_pwd
        '
        Me.field_pwd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.field_pwd.Depth = 0
        Me.field_pwd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.field_pwd.Hint = ""
        Me.field_pwd.Location = New System.Drawing.Point(54, 152)
        Me.field_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.field_pwd.Name = "field_pwd"
        Me.field_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.field_pwd.SelectedText = ""
        Me.field_pwd.SelectionLength = 0
        Me.field_pwd.SelectionStart = 0
        Me.field_pwd.Size = New System.Drawing.Size(160, 23)
        Me.field_pwd.TabIndex = 8
        Me.field_pwd.UseSystemPasswordChar = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(271, 263)
        Me.Controls.Add(Me.field_pwd)
        Me.Controls.Add(Me.field_username)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.login_btn)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.ShowInTaskbar = False
        Me.Text = "Login"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents field_username As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents field_pwd As MaterialSkin.Controls.MaterialSingleLineTextField

End Class
