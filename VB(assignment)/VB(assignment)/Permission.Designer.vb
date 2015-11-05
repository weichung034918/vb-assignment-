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
        Me.btn_add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ComboBox_per = New System.Windows.Forms.ComboBox()
        Me.txt_conpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_pwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_uname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_edel_per = New System.Windows.Forms.ComboBox()
        Me.txt_edel_conpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_edel_pwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_edel_uname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_edel_per = New MaterialSkin.Controls.MaterialLabel()
        Me.label_edel_conpwd = New MaterialSkin.Controls.MaterialLabel()
        Me.label_edel_pwd = New MaterialSkin.Controls.MaterialLabel()
        Me.label_edel_uname = New MaterialSkin.Controls.MaterialLabel()
        Me.ComboBox_modeselect = New System.Windows.Forms.ComboBox()
        Me.btn_prev = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_next = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btn_del = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_edit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_oldpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_oldpwd = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_myset_update = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txt_myset_conpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_myset_pwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        'btn_add
        '
        Me.btn_add.Depth = 0
        Me.btn_add.Location = New System.Drawing.Point(103, 176)
        Me.btn_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Primary = True
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        Me.btn_add.Visible = False
        '
        'ComboBox_per
        '
        Me.ComboBox_per.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_per.FormattingEnabled = True
        Me.ComboBox_per.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.ComboBox_per.Location = New System.Drawing.Point(282, 154)
        Me.ComboBox_per.Name = "ComboBox_per"
        Me.ComboBox_per.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_per.TabIndex = 3
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
        Me.txt_conpwd.TabIndex = 2
        Me.txt_conpwd.TabStop = False
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
        Me.txt_pwd.TabIndex = 1
        Me.txt_pwd.TabStop = False
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
        Me.txt_uname.TabIndex = 0
        Me.txt_uname.TabStop = False
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
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.ComboBox_edel_per)
        Me.TabPage2.Controls.Add(Me.txt_edel_conpwd)
        Me.TabPage2.Controls.Add(Me.txt_edel_pwd)
        Me.TabPage2.Controls.Add(Me.txt_edel_uname)
        Me.TabPage2.Controls.Add(Me.label_edel_per)
        Me.TabPage2.Controls.Add(Me.label_edel_conpwd)
        Me.TabPage2.Controls.Add(Me.label_edel_pwd)
        Me.TabPage2.Controls.Add(Me.label_edel_uname)
        Me.TabPage2.Controls.Add(Me.ComboBox_modeselect)
        Me.TabPage2.Controls.Add(Me.btn_prev)
        Me.TabPage2.Controls.Add(Me.btn_next)
        Me.TabPage2.Controls.Add(Me.btn_del)
        Me.TabPage2.Controls.Add(Me.btn_edit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(547, 251)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "edit/delete user"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(458, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'ComboBox_edel_per
        '
        Me.ComboBox_edel_per.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_edel_per.FormattingEnabled = True
        Me.ComboBox_edel_per.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.ComboBox_edel_per.Location = New System.Drawing.Point(302, 174)
        Me.ComboBox_edel_per.Name = "ComboBox_edel_per"
        Me.ComboBox_edel_per.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_edel_per.TabIndex = 3
        Me.ComboBox_edel_per.TabStop = False
        Me.ComboBox_edel_per.Visible = False
        '
        'txt_edel_conpwd
        '
        Me.txt_edel_conpwd.Depth = 0
        Me.txt_edel_conpwd.Hint = ""
        Me.txt_edel_conpwd.Location = New System.Drawing.Point(302, 134)
        Me.txt_edel_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_edel_conpwd.Name = "txt_edel_conpwd"
        Me.txt_edel_conpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_edel_conpwd.SelectedText = ""
        Me.txt_edel_conpwd.SelectionLength = 0
        Me.txt_edel_conpwd.SelectionStart = 0
        Me.txt_edel_conpwd.Size = New System.Drawing.Size(121, 23)
        Me.txt_edel_conpwd.TabIndex = 2
        Me.txt_edel_conpwd.TabStop = False
        Me.txt_edel_conpwd.UseSystemPasswordChar = False
        Me.txt_edel_conpwd.Visible = False
        '
        'txt_edel_pwd
        '
        Me.txt_edel_pwd.Depth = 0
        Me.txt_edel_pwd.Hint = ""
        Me.txt_edel_pwd.Location = New System.Drawing.Point(302, 94)
        Me.txt_edel_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_edel_pwd.Name = "txt_edel_pwd"
        Me.txt_edel_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_edel_pwd.SelectedText = ""
        Me.txt_edel_pwd.SelectionLength = 0
        Me.txt_edel_pwd.SelectionStart = 0
        Me.txt_edel_pwd.Size = New System.Drawing.Size(121, 23)
        Me.txt_edel_pwd.TabIndex = 1
        Me.txt_edel_pwd.TabStop = False
        Me.txt_edel_pwd.UseSystemPasswordChar = False
        Me.txt_edel_pwd.Visible = False
        '
        'txt_edel_uname
        '
        Me.txt_edel_uname.Depth = 0
        Me.txt_edel_uname.Enabled = False
        Me.txt_edel_uname.Hint = ""
        Me.txt_edel_uname.Location = New System.Drawing.Point(302, 54)
        Me.txt_edel_uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_edel_uname.Name = "txt_edel_uname"
        Me.txt_edel_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_edel_uname.SelectedText = ""
        Me.txt_edel_uname.SelectionLength = 0
        Me.txt_edel_uname.SelectionStart = 0
        Me.txt_edel_uname.Size = New System.Drawing.Size(121, 23)
        Me.txt_edel_uname.TabIndex = 0
        Me.txt_edel_uname.TabStop = False
        Me.txt_edel_uname.UseSystemPasswordChar = False
        Me.txt_edel_uname.Visible = False
        '
        'label_edel_per
        '
        Me.label_edel_per.AutoSize = True
        Me.label_edel_per.Depth = 0
        Me.label_edel_per.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_edel_per.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_edel_per.Location = New System.Drawing.Point(119, 174)
        Me.label_edel_per.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_edel_per.Name = "label_edel_per"
        Me.label_edel_per.Size = New System.Drawing.Size(89, 19)
        Me.label_edel_per.TabIndex = 25
        Me.label_edel_per.Text = "Permission:"
        Me.label_edel_per.Visible = False
        '
        'label_edel_conpwd
        '
        Me.label_edel_conpwd.AutoSize = True
        Me.label_edel_conpwd.Depth = 0
        Me.label_edel_conpwd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_edel_conpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_edel_conpwd.Location = New System.Drawing.Point(119, 134)
        Me.label_edel_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_edel_conpwd.Name = "label_edel_conpwd"
        Me.label_edel_conpwd.Size = New System.Drawing.Size(137, 19)
        Me.label_edel_conpwd.TabIndex = 24
        Me.label_edel_conpwd.Text = "Confirm Password:"
        Me.label_edel_conpwd.Visible = False
        '
        'label_edel_pwd
        '
        Me.label_edel_pwd.AutoSize = True
        Me.label_edel_pwd.Depth = 0
        Me.label_edel_pwd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_edel_pwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_edel_pwd.Location = New System.Drawing.Point(119, 94)
        Me.label_edel_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_edel_pwd.Name = "label_edel_pwd"
        Me.label_edel_pwd.Size = New System.Drawing.Size(113, 19)
        Me.label_edel_pwd.TabIndex = 23
        Me.label_edel_pwd.Text = "New Password:"
        Me.label_edel_pwd.Visible = False
        '
        'label_edel_uname
        '
        Me.label_edel_uname.AutoSize = True
        Me.label_edel_uname.Depth = 0
        Me.label_edel_uname.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_edel_uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_edel_uname.Location = New System.Drawing.Point(119, 54)
        Me.label_edel_uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_edel_uname.Name = "label_edel_uname"
        Me.label_edel_uname.Size = New System.Drawing.Size(81, 19)
        Me.label_edel_uname.TabIndex = 22
        Me.label_edel_uname.Text = "Username:"
        Me.label_edel_uname.Visible = False
        '
        'ComboBox_modeselect
        '
        Me.ComboBox_modeselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_modeselect.FormattingEnabled = True
        Me.ComboBox_modeselect.Items.AddRange(New Object() {"Edit", "Delete"})
        Me.ComboBox_modeselect.Location = New System.Drawing.Point(4, 4)
        Me.ComboBox_modeselect.Name = "ComboBox_modeselect"
        Me.ComboBox_modeselect.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_modeselect.TabIndex = 21
        '
        'btn_prev
        '
        Me.btn_prev.AutoSize = True
        Me.btn_prev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_prev.Depth = 0
        Me.btn_prev.Location = New System.Drawing.Point(195, 17)
        Me.btn_prev.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_prev.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Primary = False
        Me.btn_prev.Size = New System.Drawing.Size(46, 36)
        Me.btn_prev.TabIndex = 20
        Me.btn_prev.Text = "Prev"
        Me.btn_prev.UseVisualStyleBackColor = True
        Me.btn_prev.Visible = False
        '
        'btn_next
        '
        Me.btn_next.AutoSize = True
        Me.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_next.Depth = 0
        Me.btn_next.Location = New System.Drawing.Point(281, 17)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_next.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Primary = False
        Me.btn_next.Size = New System.Drawing.Size(46, 36)
        Me.btn_next.TabIndex = 19
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        Me.btn_next.Visible = False
        '
        'btn_del
        '
        Me.btn_del.Depth = 0
        Me.btn_del.Location = New System.Drawing.Point(265, 222)
        Me.btn_del.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Primary = True
        Me.btn_del.Size = New System.Drawing.Size(75, 23)
        Me.btn_del.TabIndex = 18
        Me.btn_del.Text = "delete"
        Me.btn_del.UseVisualStyleBackColor = True
        Me.btn_del.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.Depth = 0
        Me.btn_edit.Location = New System.Drawing.Point(166, 222)
        Me.btn_edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Primary = True
        Me.btn_edit.Size = New System.Drawing.Size(75, 22)
        Me.btn_edit.TabIndex = 17
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.txt_oldpwd)
        Me.TabPage3.Controls.Add(Me.label_oldpwd)
        Me.TabPage3.Controls.Add(Me.btn_myset_update)
        Me.TabPage3.Controls.Add(Me.txt_myset_conpwd)
        Me.TabPage3.Controls.Add(Me.txt_myset_pwd)
        Me.TabPage3.Controls.Add(Me.MaterialLabel5)
        Me.TabPage3.Controls.Add(Me.MaterialLabel6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(547, 251)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "EDIT PASSWORD"
        '
        'txt_oldpwd
        '
        Me.txt_oldpwd.Depth = 0
        Me.txt_oldpwd.Hint = ""
        Me.txt_oldpwd.Location = New System.Drawing.Point(285, 53)
        Me.txt_oldpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_oldpwd.Name = "txt_oldpwd"
        Me.txt_oldpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_oldpwd.SelectedText = ""
        Me.txt_oldpwd.SelectionLength = 0
        Me.txt_oldpwd.SelectionStart = 0
        Me.txt_oldpwd.Size = New System.Drawing.Size(150, 23)
        Me.txt_oldpwd.TabIndex = 20
        Me.txt_oldpwd.UseSystemPasswordChar = False
        '
        'label_oldpwd
        '
        Me.label_oldpwd.AutoSize = True
        Me.label_oldpwd.Depth = 0
        Me.label_oldpwd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_oldpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_oldpwd.Location = New System.Drawing.Point(110, 57)
        Me.label_oldpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_oldpwd.Name = "label_oldpwd"
        Me.label_oldpwd.Size = New System.Drawing.Size(105, 19)
        Me.label_oldpwd.TabIndex = 19
        Me.label_oldpwd.Text = "Old Password:"
        '
        'btn_myset_update
        '
        Me.btn_myset_update.Depth = 0
        Me.btn_myset_update.Location = New System.Drawing.Point(231, 213)
        Me.btn_myset_update.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_myset_update.Name = "btn_myset_update"
        Me.btn_myset_update.Primary = True
        Me.btn_myset_update.Size = New System.Drawing.Size(75, 22)
        Me.btn_myset_update.TabIndex = 18
        Me.btn_myset_update.Text = "update"
        Me.btn_myset_update.UseVisualStyleBackColor = True
        Me.btn_myset_update.Visible = False
        '
        'txt_myset_conpwd
        '
        Me.txt_myset_conpwd.Depth = 0
        Me.txt_myset_conpwd.Hint = ""
        Me.txt_myset_conpwd.Location = New System.Drawing.Point(285, 131)
        Me.txt_myset_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_myset_conpwd.Name = "txt_myset_conpwd"
        Me.txt_myset_conpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_myset_conpwd.SelectedText = ""
        Me.txt_myset_conpwd.SelectionLength = 0
        Me.txt_myset_conpwd.SelectionStart = 0
        Me.txt_myset_conpwd.Size = New System.Drawing.Size(150, 23)
        Me.txt_myset_conpwd.TabIndex = 12
        Me.txt_myset_conpwd.UseSystemPasswordChar = False
        '
        'txt_myset_pwd
        '
        Me.txt_myset_pwd.Depth = 0
        Me.txt_myset_pwd.Hint = ""
        Me.txt_myset_pwd.Location = New System.Drawing.Point(285, 91)
        Me.txt_myset_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_myset_pwd.Name = "txt_myset_pwd"
        Me.txt_myset_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_myset_pwd.SelectedText = ""
        Me.txt_myset_pwd.SelectionLength = 0
        Me.txt_myset_pwd.SelectionStart = 0
        Me.txt_myset_pwd.Size = New System.Drawing.Size(150, 23)
        Me.txt_myset_pwd.TabIndex = 11
        Me.txt_myset_pwd.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(108, 135)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(137, 19)
        Me.MaterialLabel5.TabIndex = 9
        Me.MaterialLabel5.Text = "Confirm Password:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(108, 95)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(113, 19)
        Me.MaterialLabel6.TabIndex = 8
        Me.MaterialLabel6.Text = "New Password:"
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
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
    Friend WithEvents btn_edit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_del As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txt_myset_conpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_myset_pwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_myset_update As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_prev As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btn_next As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ComboBox_modeselect As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_edel_per As System.Windows.Forms.ComboBox
    Friend WithEvents txt_edel_conpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_edel_pwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_edel_uname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label_edel_per As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_edel_conpwd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_edel_pwd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_edel_uname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_oldpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label_oldpwd As MaterialSkin.Controls.MaterialLabel
End Class
