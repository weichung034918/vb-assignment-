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
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBox_per = New System.Windows.Forms.ComboBox()
        Me.txt_conpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_pwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_uname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-2, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(555, 35)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(-2, 91)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(555, 277)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btn_add)
        Me.TabPage1.Controls.Add(Me.ComboBox_per)
        Me.TabPage1.Controls.Add(Me.txt_conpwd)
        Me.TabPage1.Controls.Add(Me.txt_pwd)
        Me.TabPage1.Controls.Add(Me.txt_uname)
        Me.TabPage1.Controls.Add(Me.MaterialLabel4)
        Me.TabPage1.Controls.Add(Me.MaterialLabel3)
        Me.TabPage1.Controls.Add(Me.MaterialLabel2)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(547, 251)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New User"
        '
        'ComboBox_per
        '
        Me.ComboBox_per.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_per.FormattingEnabled = True
        Me.ComboBox_per.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.ComboBox_per.Location = New System.Drawing.Point(282, 154)
        Me.ComboBox_per.Name = "ComboBox_per"
        Me.ComboBox_per.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_per.TabIndex = 7
        '
        'txt_conpwd
        '
        Me.txt_conpwd.Depth = 0
        Me.txt_conpwd.Hint = ""
        Me.txt_conpwd.Location = New System.Drawing.Point(282, 114)
        Me.txt_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_conpwd.Name = "txt_conpwd"
        Me.txt_conpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_conpwd.SelectedText = ""
        Me.txt_conpwd.SelectionLength = 0
        Me.txt_conpwd.SelectionStart = 0
        Me.txt_conpwd.Size = New System.Drawing.Size(75, 23)
        Me.txt_conpwd.TabIndex = 6
        Me.txt_conpwd.UseSystemPasswordChar = False
        '
        'txt_pwd
        '
        Me.txt_pwd.Depth = 0
        Me.txt_pwd.Hint = ""
        Me.txt_pwd.Location = New System.Drawing.Point(282, 74)
        Me.txt_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pwd.SelectedText = ""
        Me.txt_pwd.SelectionLength = 0
        Me.txt_pwd.SelectionStart = 0
        Me.txt_pwd.Size = New System.Drawing.Size(75, 23)
        Me.txt_pwd.TabIndex = 5
        Me.txt_pwd.UseSystemPasswordChar = False
        '
        'txt_uname
        '
        Me.txt_uname.Depth = 0
        Me.txt_uname.Hint = ""
        Me.txt_uname.Location = New System.Drawing.Point(282, 34)
        Me.txt_uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_uname.SelectedText = ""
        Me.txt_uname.SelectionLength = 0
        Me.txt_uname.SelectionStart = 0
        Me.txt_uname.Size = New System.Drawing.Size(75, 23)
        Me.txt_uname.TabIndex = 4
        Me.txt_uname.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(99, 154)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Permission:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(99, 114)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(137, 19)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Confirm Password:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(99, 74)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Password:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(99, 34)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Username:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(547, 251)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "edit/delete user"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(547, 251)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "My settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Depth = 0
        Me.btn_add.Location = New System.Drawing.Point(103, 176)
        Me.btn_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Primary = True
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 371)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Permission"
        Me.Text = "Admin Settings"
        Me.TopMost = True
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox_per As System.Windows.Forms.ComboBox
    Friend WithEvents txt_conpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_pwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_uname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_add As MaterialSkin.Controls.MaterialRaisedButton
End Class
