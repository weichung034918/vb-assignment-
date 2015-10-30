<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permission
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.permission_username = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.permission_password = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.permission_search = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.permission_edit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.permission_delete = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.permission_add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.permission_role = New System.Windows.Forms.ComboBox()
        Me.admin_username = New MaterialSkin.Controls.MaterialFlatButton()
        Me.permission_btn_search = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.edit_username = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.edit_password = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.choice_back = New MaterialSkin.Controls.MaterialFlatButton()
        Me.usernamelabel = New MaterialSkin.Controls.MaterialLabel()
        Me.reusername = New MaterialSkin.Controls.MaterialLabel()
        Me.chg_uname_field = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.retype_uname_field = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(217, 91)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Search:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(80, 174)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Username:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(80, 213)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(79, 19)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Password:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(80, 246)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Permission:"
        '
        'permission_username
        '
        Me.permission_username.Depth = 0
        Me.permission_username.Enabled = False
        Me.permission_username.Hint = ""
        Me.permission_username.Location = New System.Drawing.Point(219, 169)
        Me.permission_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_username.Name = "permission_username"
        Me.permission_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.permission_username.SelectedText = ""
        Me.permission_username.SelectionLength = 0
        Me.permission_username.SelectionStart = 0
        Me.permission_username.Size = New System.Drawing.Size(111, 23)
        Me.permission_username.TabIndex = 4
        Me.permission_username.UseSystemPasswordChar = False
        '
        'permission_password
        '
        Me.permission_password.Depth = 0
        Me.permission_password.Enabled = False
        Me.permission_password.Hint = ""
        Me.permission_password.Location = New System.Drawing.Point(219, 208)
        Me.permission_password.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_password.Name = "permission_password"
        Me.permission_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.permission_password.SelectedText = ""
        Me.permission_password.SelectionLength = 0
        Me.permission_password.SelectionStart = 0
        Me.permission_password.Size = New System.Drawing.Size(103, 23)
        Me.permission_password.TabIndex = 5
        Me.permission_password.UseSystemPasswordChar = False
        '
        'permission_search
        '
        Me.permission_search.Depth = 0
        Me.permission_search.ForeColor = System.Drawing.Color.Gray
        Me.permission_search.Hint = ""
        Me.permission_search.Location = New System.Drawing.Point(350, 91)
        Me.permission_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_search.Name = "permission_search"
        Me.permission_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.permission_search.SelectedText = ""
        Me.permission_search.SelectionLength = 0
        Me.permission_search.SelectionStart = 0
        Me.permission_search.Size = New System.Drawing.Size(103, 23)
        Me.permission_search.TabIndex = 7
        Me.permission_search.Text = "Enter Username"
        Me.permission_search.UseSystemPasswordChar = False
        '
        'permission_edit
        '
        Me.permission_edit.Depth = 0
        Me.permission_edit.Location = New System.Drawing.Point(409, 198)
        Me.permission_edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_edit.Name = "permission_edit"
        Me.permission_edit.Primary = True
        Me.permission_edit.Size = New System.Drawing.Size(75, 23)
        Me.permission_edit.TabIndex = 8
        Me.permission_edit.Text = "Edit"
        Me.permission_edit.UseVisualStyleBackColor = True
        '
        'permission_delete
        '
        Me.permission_delete.Depth = 0
        Me.permission_delete.Location = New System.Drawing.Point(409, 242)
        Me.permission_delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_delete.Name = "permission_delete"
        Me.permission_delete.Primary = True
        Me.permission_delete.Size = New System.Drawing.Size(75, 23)
        Me.permission_delete.TabIndex = 9
        Me.permission_delete.Text = "Delete"
        Me.permission_delete.UseVisualStyleBackColor = True
        '
        'permission_add
        '
        Me.permission_add.Depth = 0
        Me.permission_add.Location = New System.Drawing.Point(409, 169)
        Me.permission_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_add.Name = "permission_add"
        Me.permission_add.Primary = True
        Me.permission_add.Size = New System.Drawing.Size(95, 23)
        Me.permission_add.TabIndex = 10
        Me.permission_add.Text = "Add"
        Me.permission_add.UseVisualStyleBackColor = True
        '
        'permission_role
        '
        Me.permission_role.Enabled = False
        Me.permission_role.FormattingEnabled = True
        Me.permission_role.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.permission_role.Location = New System.Drawing.Point(219, 246)
        Me.permission_role.Name = "permission_role"
        Me.permission_role.Size = New System.Drawing.Size(103, 21)
        Me.permission_role.TabIndex = 11
        '
        'admin_username
        '
        Me.admin_username.AutoSize = True
        Me.admin_username.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.admin_username.Depth = 0
        Me.admin_username.Location = New System.Drawing.Point(267, 276)
        Me.admin_username.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.admin_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.admin_username.Name = "admin_username"
        Me.admin_username.Primary = False
        Me.admin_username.Size = New System.Drawing.Size(118, 36)
        Me.admin_username.TabIndex = 12
        Me.admin_username.Text = "usernamehere"
        Me.admin_username.UseVisualStyleBackColor = True
        '
        'permission_btn_search
        '
        Me.permission_btn_search.Depth = 0
        Me.permission_btn_search.Location = New System.Drawing.Point(429, 129)
        Me.permission_btn_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.permission_btn_search.Name = "permission_btn_search"
        Me.permission_btn_search.Primary = True
        Me.permission_btn_search.Size = New System.Drawing.Size(75, 23)
        Me.permission_btn_search.TabIndex = 13
        Me.permission_btn_search.Text = "Search"
        Me.permission_btn_search.UseVisualStyleBackColor = True
        Me.permission_btn_search.Visible = False
        '
        'edit_username
        '
        Me.edit_username.Depth = 0
        Me.edit_username.Location = New System.Drawing.Point(672, 129)
        Me.edit_username.MouseState = MaterialSkin.MouseState.HOVER
        Me.edit_username.Name = "edit_username"
        Me.edit_username.Primary = True
        Me.edit_username.Size = New System.Drawing.Size(75, 23)
        Me.edit_username.TabIndex = 14
        Me.edit_username.Text = "Edit Username"
        Me.edit_username.UseVisualStyleBackColor = True
        Me.edit_username.Visible = False
        '
        'edit_password
        '
        Me.edit_password.Depth = 0
        Me.edit_password.Location = New System.Drawing.Point(754, 198)
        Me.edit_password.MouseState = MaterialSkin.MouseState.HOVER
        Me.edit_password.Name = "edit_password"
        Me.edit_password.Primary = True
        Me.edit_password.Size = New System.Drawing.Size(75, 23)
        Me.edit_password.TabIndex = 15
        Me.edit_password.Text = "Edit Password"
        Me.edit_password.UseVisualStyleBackColor = True
        Me.edit_password.Visible = False
        '
        'choice_back
        '
        Me.choice_back.AutoSize = True
        Me.choice_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.choice_back.Depth = 0
        Me.choice_back.Location = New System.Drawing.Point(754, 276)
        Me.choice_back.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.choice_back.MouseState = MaterialSkin.MouseState.HOVER
        Me.choice_back.Name = "choice_back"
        Me.choice_back.Primary = False
        Me.choice_back.Size = New System.Drawing.Size(47, 36)
        Me.choice_back.TabIndex = 16
        Me.choice_back.Text = "back"
        Me.choice_back.UseVisualStyleBackColor = True
        Me.choice_back.Visible = False
        '
        'usernamelabel
        '
        Me.usernamelabel.AutoSize = True
        Me.usernamelabel.Depth = 0
        Me.usernamelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.usernamelabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.usernamelabel.Location = New System.Drawing.Point(752, 144)
        Me.usernamelabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.usernamelabel.Name = "usernamelabel"
        Me.usernamelabel.Size = New System.Drawing.Size(85, 18)
        Me.usernamelabel.TabIndex = 17
        Me.usernamelabel.Text = "Username :"
        Me.usernamelabel.Visible = False
        '
        'reusername
        '
        Me.reusername.AutoSize = True
        Me.reusername.Depth = 0
        Me.reusername.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.reusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.reusername.Location = New System.Drawing.Point(751, 162)
        Me.reusername.MouseState = MaterialSkin.MouseState.HOVER
        Me.reusername.Name = "reusername"
        Me.reusername.Size = New System.Drawing.Size(130, 19)
        Me.reusername.TabIndex = 18
        Me.reusername.Text = "Retype Username:"
        Me.reusername.Visible = False
        '
        'chg_uname_field
        '
        Me.chg_uname_field.Depth = 0
        Me.chg_uname_field.Hint = ""
        Me.chg_uname_field.Location = New System.Drawing.Point(830, 243)
        Me.chg_uname_field.MouseState = MaterialSkin.MouseState.HOVER
        Me.chg_uname_field.Name = "chg_uname_field"
        Me.chg_uname_field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.chg_uname_field.SelectedText = ""
        Me.chg_uname_field.SelectionLength = 0
        Me.chg_uname_field.SelectionStart = 0
        Me.chg_uname_field.Size = New System.Drawing.Size(75, 23)
        Me.chg_uname_field.TabIndex = 19
        Me.chg_uname_field.UseSystemPasswordChar = False
        Me.chg_uname_field.Visible = False
        '
        'retype_uname_field
        '
        Me.retype_uname_field.Depth = 0
        Me.retype_uname_field.Hint = ""
        Me.retype_uname_field.Location = New System.Drawing.Point(829, 273)
        Me.retype_uname_field.MouseState = MaterialSkin.MouseState.HOVER
        Me.retype_uname_field.Name = "retype_uname_field"
        Me.retype_uname_field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.retype_uname_field.SelectedText = ""
        Me.retype_uname_field.SelectionLength = 0
        Me.retype_uname_field.SelectionStart = 0
        Me.retype_uname_field.Size = New System.Drawing.Size(75, 23)
        Me.retype_uname_field.TabIndex = 20
        Me.retype_uname_field.UseSystemPasswordChar = False
        Me.retype_uname_field.Visible = False
        '
        'Permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 273)
        Me.Controls.Add(Me.retype_uname_field)
        Me.Controls.Add(Me.chg_uname_field)
        Me.Controls.Add(Me.reusername)
        Me.Controls.Add(Me.usernamelabel)
        Me.Controls.Add(Me.choice_back)
        Me.Controls.Add(Me.edit_password)
        Me.Controls.Add(Me.edit_username)
        Me.Controls.Add(Me.permission_btn_search)
        Me.Controls.Add(Me.admin_username)
        Me.Controls.Add(Me.permission_role)
        Me.Controls.Add(Me.permission_add)
        Me.Controls.Add(Me.permission_delete)
        Me.Controls.Add(Me.permission_edit)
        Me.Controls.Add(Me.permission_search)
        Me.Controls.Add(Me.permission_password)
        Me.Controls.Add(Me.permission_username)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Permission"
        Me.Text = "Admin Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents permission_username As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents permission_password As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents permission_search As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents permission_edit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents permission_delete As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents permission_add As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents permission_role As System.Windows.Forms.ComboBox
    Friend WithEvents admin_username As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents permission_btn_search As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents edit_username As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents edit_password As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents choice_back As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents usernamelabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents reusername As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chg_uname_field As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents retype_uname_field As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
