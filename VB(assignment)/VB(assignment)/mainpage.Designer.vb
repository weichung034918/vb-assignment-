<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainpage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainpage))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel29 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_add_shipid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.combobox_add_membertype = New System.Windows.Forms.ComboBox()
        Me.label_add_shipid = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_add_id = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_add_email = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_add_cont = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_add_firstname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_add_lastname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.combobox_reup_status = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel53 = New MaterialSkin.Controls.MaterialLabel()
        Me.combobox_modeselect = New System.Windows.Forms.ComboBox()
        Me.btn_update = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_last = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_next = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_prev = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_first = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.combobox_reup_search_membershiptype = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel52 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_reup_email = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_reup_cont = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_reup_shipid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_reup_lastname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_reup_firstname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_reup_id = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_reup_search = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_reup_shipid = New MaterialSkin.Controls.MaterialLabel()
        Me.label_reup_search = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel47 = New MaterialSkin.Controls.MaterialLabel()
        Me.combobox_reup_membertype = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel21 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_remove = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_reup_search = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.combobox_reup_search = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.tabpgae = New System.Windows.Forms.TabPage()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_payadd = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_payedit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txt_pay_search = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_pay_search = New MaterialSkin.Controls.MaterialLabel()
        Me.payment_groupbox = New System.Windows.Forms.GroupBox()
        Me.radio_pid = New System.Windows.Forms.RadioButton()
        Me.radio_mid = New System.Windows.Forms.RadioButton()
        Me.radio_mshipid = New System.Windows.Forms.RadioButton()
        Me.payment_listview = New System.Windows.Forms.ListView()
        Me.list_pid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_mid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_mship_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_doe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_log = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_paytype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_paid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_due = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_pdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.group_reportpay = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.list3_pid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list3_mid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list3_mshipid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list3_paytype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list3_paid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list3_due = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_reppay = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_paysearch = New MaterialSkin.Controls.MaterialLabel()
        Me.group_payrepsearch = New System.Windows.Forms.GroupBox()
        Me.radio_reppaypid = New System.Windows.Forms.RadioButton()
        Me.radio_reppaymid = New System.Windows.Forms.RadioButton()
        Me.radio_reppaymshipid = New System.Windows.Forms.RadioButton()
        Me.btn_reportpayall = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.group_reportmem = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.list2_mid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list2_mshipid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list2_fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list2_lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_repmem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btn_reportmemall = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.group_memrepsearch = New System.Windows.Forms.GroupBox()
        Me.radio_repmemlname = New System.Windows.Forms.RadioButton()
        Me.radio_repmemfname = New System.Windows.Forms.RadioButton()
        Me.radio_repmemmid = New System.Windows.Forms.RadioButton()
        Me.radio_repmemmshipid = New System.Windows.Forms.RadioButton()
        Me.label_memsearch = New MaterialSkin.Controls.MaterialLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_reportpayspec = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_reportmemspec = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.PermissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mshipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.label_uname = New MaterialSkin.Controls.MaterialLabel()
        Me.label_unamelbl = New MaterialSkin.Controls.MaterialLabel()
        Me.label_time = New MaterialSkin.Controls.MaterialLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label_date = New MaterialSkin.Controls.MaterialLabel()
        Me.label_day = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_logout = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tabpgae.SuspendLayout()
        Me.payment_groupbox.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.group_reportpay.SuspendLayout()
        Me.group_payrepsearch.SuspendLayout()
        Me.group_reportmem.SuspendLayout()
        Me.group_memrepsearch.SuspendLayout()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.tabpgae)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.HotTrack = True
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 104)
        Me.MaterialTabControl1.MaximumSize = New System.Drawing.Size(837, 500)
        Me.MaterialTabControl1.MinimumSize = New System.Drawing.Size(837, 500)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(837, 500)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.Controls.Add(Me.Add)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(829, 474)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Members"
        '
        'Add
        '
        Me.Add.Depth = 0
        Me.Add.Location = New System.Drawing.Point(363, 301)
        Me.Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add.Name = "Add"
        Me.Add.Primary = True
        Me.Add.Size = New System.Drawing.Size(97, 36)
        Me.Add.TabIndex = 7
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel29)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.txt_add_shipid)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox1.Controls.Add(Me.combobox_add_membertype)
        Me.GroupBox1.Controls.Add(Me.label_add_shipid)
        Me.GroupBox1.Controls.Add(Me.txt_add_id)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 195)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account information"
        '
        'MaterialLabel29
        '
        Me.MaterialLabel29.AutoSize = True
        Me.MaterialLabel29.Depth = 0
        Me.MaterialLabel29.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel29.Location = New System.Drawing.Point(15, 121)
        Me.MaterialLabel29.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel29.Name = "MaterialLabel29"
        Me.MaterialLabel29.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel29.TabIndex = 14
        Me.MaterialLabel29.Text = "Membership ID:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(15, 34)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Member ID:"
        '
        'txt_add_shipid
        '
        Me.txt_add_shipid.Depth = 0
        Me.txt_add_shipid.Hint = ""
        Me.txt_add_shipid.Location = New System.Drawing.Point(229, 121)
        Me.txt_add_shipid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_add_shipid.Name = "txt_add_shipid"
        Me.txt_add_shipid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add_shipid.SelectedText = ""
        Me.txt_add_shipid.SelectionLength = 0
        Me.txt_add_shipid.SelectionStart = 0
        Me.txt_add_shipid.Size = New System.Drawing.Size(86, 23)
        Me.txt_add_shipid.TabIndex = 4
        Me.txt_add_shipid.TabStop = False
        Me.txt_add_shipid.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(15, 78)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(132, 19)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Membership Type:"
        '
        'combobox_add_membertype
        '
        Me.combobox_add_membertype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combobox_add_membertype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combobox_add_membertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_add_membertype.FormattingEnabled = True
        Me.combobox_add_membertype.Items.AddRange(New Object() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_add_membertype.Location = New System.Drawing.Point(174, 79)
        Me.combobox_add_membertype.Name = "combobox_add_membertype"
        Me.combobox_add_membertype.Size = New System.Drawing.Size(141, 21)
        Me.combobox_add_membertype.TabIndex = 3
        Me.combobox_add_membertype.TabStop = False
        '
        'label_add_shipid
        '
        Me.label_add_shipid.AutoSize = True
        Me.label_add_shipid.Depth = 0
        Me.label_add_shipid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_add_shipid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_add_shipid.Location = New System.Drawing.Point(170, 126)
        Me.label_add_shipid.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_add_shipid.Name = "label_add_shipid"
        Me.label_add_shipid.Size = New System.Drawing.Size(23, 19)
        Me.label_add_shipid.TabIndex = 16
        Me.label_add_shipid.Text = "ID"
        '
        'txt_add_id
        '
        Me.txt_add_id.Depth = 0
        Me.txt_add_id.Hint = ""
        Me.txt_add_id.Location = New System.Drawing.Point(174, 37)
        Me.txt_add_id.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add_id.SelectedText = ""
        Me.txt_add_id.SelectionLength = 0
        Me.txt_add_id.SelectionStart = 0
        Me.txt_add_id.Size = New System.Drawing.Size(141, 23)
        Me.txt_add_id.TabIndex = 0
        Me.txt_add_id.TabStop = False
        Me.txt_add_id.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_add_email)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox2.Controls.Add(Me.txt_add_cont)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox2.Controls.Add(Me.txt_add_firstname)
        Me.GroupBox2.Controls.Add(Me.txt_add_lastname)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel5)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox2.Location = New System.Drawing.Point(410, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 195)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Member information"
        '
        'txt_add_email
        '
        Me.txt_add_email.Depth = 0
        Me.txt_add_email.Hint = ""
        Me.txt_add_email.Location = New System.Drawing.Point(222, 157)
        Me.txt_add_email.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_add_email.Name = "txt_add_email"
        Me.txt_add_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add_email.SelectedText = ""
        Me.txt_add_email.SelectionLength = 0
        Me.txt_add_email.SelectionStart = 0
        Me.txt_add_email.Size = New System.Drawing.Size(141, 23)
        Me.txt_add_email.TabIndex = 6
        Me.txt_add_email.TabStop = False
        Me.txt_add_email.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(6, 77)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(145, 19)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Member Last Name:"
        '
        'txt_add_cont
        '
        Me.txt_add_cont.Depth = 0
        Me.txt_add_cont.Hint = ""
        Me.txt_add_cont.Location = New System.Drawing.Point(222, 117)
        Me.txt_add_cont.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_add_cont.Name = "txt_add_cont"
        Me.txt_add_cont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add_cont.SelectedText = ""
        Me.txt_add_cont.SelectionLength = 0
        Me.txt_add_cont.SelectionStart = 0
        Me.txt_add_cont.Size = New System.Drawing.Size(141, 23)
        Me.txt_add_cont.TabIndex = 5
        Me.txt_add_cont.TabStop = False
        Me.txt_add_cont.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(6, 37)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(146, 19)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Member First Name:"
        '
        'txt_add_firstname
        '
        Me.txt_add_firstname.Depth = 0
        Me.txt_add_firstname.Hint = ""
        Me.txt_add_firstname.Location = New System.Drawing.Point(222, 33)
        Me.txt_add_firstname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_add_firstname.Name = "txt_add_firstname"
        Me.txt_add_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add_firstname.SelectedText = ""
        Me.txt_add_firstname.SelectionLength = 0
        Me.txt_add_firstname.SelectionStart = 0
        Me.txt_add_firstname.Size = New System.Drawing.Size(141, 23)
        Me.txt_add_firstname.TabIndex = 1
        Me.txt_add_firstname.TabStop = False
        Me.txt_add_firstname.UseSystemPasswordChar = False
        '
        'txt_add_lastname
        '
        Me.txt_add_lastname.Depth = 0
        Me.txt_add_lastname.Hint = ""
        Me.txt_add_lastname.Location = New System.Drawing.Point(222, 77)
        Me.txt_add_lastname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_add_lastname.Name = "txt_add_lastname"
        Me.txt_add_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_add_lastname.SelectedText = ""
        Me.txt_add_lastname.SelectionLength = 0
        Me.txt_add_lastname.SelectionStart = 0
        Me.txt_add_lastname.Size = New System.Drawing.Size(141, 23)
        Me.txt_add_lastname.TabIndex = 2
        Me.txt_add_lastname.TabStop = False
        Me.txt_add_lastname.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(6, 117)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(123, 19)
        Me.MaterialLabel5.TabIndex = 4
        Me.MaterialLabel5.Text = "Contact Number:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(6, 157)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel6.TabIndex = 5
        Me.MaterialLabel6.Text = "E-mail Address:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage2.Controls.Add(Me.combobox_reup_status)
        Me.TabPage2.Controls.Add(Me.MaterialLabel53)
        Me.TabPage2.Controls.Add(Me.combobox_modeselect)
        Me.TabPage2.Controls.Add(Me.btn_update)
        Me.TabPage2.Controls.Add(Me.btn_last)
        Me.TabPage2.Controls.Add(Me.btn_next)
        Me.TabPage2.Controls.Add(Me.btn_prev)
        Me.TabPage2.Controls.Add(Me.btn_first)
        Me.TabPage2.Controls.Add(Me.combobox_reup_search_membershiptype)
        Me.TabPage2.Controls.Add(Me.MaterialLabel52)
        Me.TabPage2.Controls.Add(Me.txt_reup_email)
        Me.TabPage2.Controls.Add(Me.txt_reup_cont)
        Me.TabPage2.Controls.Add(Me.txt_reup_shipid)
        Me.TabPage2.Controls.Add(Me.txt_reup_lastname)
        Me.TabPage2.Controls.Add(Me.txt_reup_firstname)
        Me.TabPage2.Controls.Add(Me.txt_reup_id)
        Me.TabPage2.Controls.Add(Me.txt_reup_search)
        Me.TabPage2.Controls.Add(Me.label_reup_shipid)
        Me.TabPage2.Controls.Add(Me.label_reup_search)
        Me.TabPage2.Controls.Add(Me.MaterialLabel47)
        Me.TabPage2.Controls.Add(Me.combobox_reup_membertype)
        Me.TabPage2.Controls.Add(Me.MaterialLabel21)
        Me.TabPage2.Controls.Add(Me.btn_remove)
        Me.TabPage2.Controls.Add(Me.btn_reup_search)
        Me.TabPage2.Controls.Add(Me.MaterialLabel8)
        Me.TabPage2.Controls.Add(Me.MaterialLabel9)
        Me.TabPage2.Controls.Add(Me.MaterialLabel11)
        Me.TabPage2.Controls.Add(Me.MaterialLabel12)
        Me.TabPage2.Controls.Add(Me.MaterialLabel13)
        Me.TabPage2.Controls.Add(Me.combobox_reup_search)
        Me.TabPage2.Controls.Add(Me.MaterialLabel7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(829, 474)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Members"
        '
        'combobox_reup_status
        '
        Me.combobox_reup_status.AutoCompleteCustomSource.AddRange(New String() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_reup_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_reup_status.Enabled = False
        Me.combobox_reup_status.FormattingEnabled = True
        Me.combobox_reup_status.Items.AddRange(New Object() {"Active", "Closed"})
        Me.combobox_reup_status.Location = New System.Drawing.Point(595, 333)
        Me.combobox_reup_status.Name = "combobox_reup_status"
        Me.combobox_reup_status.Size = New System.Drawing.Size(141, 21)
        Me.combobox_reup_status.TabIndex = 73
        '
        'MaterialLabel53
        '
        Me.MaterialLabel53.AutoSize = True
        Me.MaterialLabel53.Depth = 0
        Me.MaterialLabel53.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel53.Location = New System.Drawing.Point(397, 333)
        Me.MaterialLabel53.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel53.Name = "MaterialLabel53"
        Me.MaterialLabel53.Size = New System.Drawing.Size(56, 19)
        Me.MaterialLabel53.TabIndex = 72
        Me.MaterialLabel53.Text = "Status:"
        '
        'combobox_modeselect
        '
        Me.combobox_modeselect.AutoCompleteCustomSource.AddRange(New String() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_modeselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_modeselect.FormattingEnabled = True
        Me.combobox_modeselect.Items.AddRange(New Object() {"Delete Members", "Update Members", "Search Members"})
        Me.combobox_modeselect.Location = New System.Drawing.Point(0, 2)
        Me.combobox_modeselect.Name = "combobox_modeselect"
        Me.combobox_modeselect.Size = New System.Drawing.Size(141, 21)
        Me.combobox_modeselect.TabIndex = 71
        '
        'btn_update
        '
        Me.btn_update.Depth = 0
        Me.btn_update.Location = New System.Drawing.Point(395, 374)
        Me.btn_update.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Primary = True
        Me.btn_update.Size = New System.Drawing.Size(115, 39)
        Me.btn_update.TabIndex = 70
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        Me.btn_update.Visible = False
        '
        'btn_last
        '
        Me.btn_last.Depth = 0
        Me.btn_last.Location = New System.Drawing.Point(720, 419)
        Me.btn_last.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Primary = True
        Me.btn_last.Size = New System.Drawing.Size(75, 23)
        Me.btn_last.TabIndex = 64
        Me.btn_last.Text = "Last"
        Me.btn_last.UseVisualStyleBackColor = True
        Me.btn_last.Visible = False
        '
        'btn_next
        '
        Me.btn_next.Depth = 0
        Me.btn_next.Location = New System.Drawing.Point(720, 390)
        Me.btn_next.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Primary = True
        Me.btn_next.Size = New System.Drawing.Size(75, 23)
        Me.btn_next.TabIndex = 63
        Me.btn_next.Text = ">>"
        Me.btn_next.UseVisualStyleBackColor = True
        Me.btn_next.Visible = False
        '
        'btn_prev
        '
        Me.btn_prev.Depth = 0
        Me.btn_prev.Location = New System.Drawing.Point(720, 362)
        Me.btn_prev.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Primary = True
        Me.btn_prev.Size = New System.Drawing.Size(75, 23)
        Me.btn_prev.TabIndex = 62
        Me.btn_prev.Text = "<<"
        Me.btn_prev.UseVisualStyleBackColor = True
        Me.btn_prev.Visible = False
        '
        'btn_first
        '
        Me.btn_first.Depth = 0
        Me.btn_first.Location = New System.Drawing.Point(720, 333)
        Me.btn_first.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Primary = True
        Me.btn_first.Size = New System.Drawing.Size(75, 23)
        Me.btn_first.TabIndex = 61
        Me.btn_first.Text = "First"
        Me.btn_first.UseVisualStyleBackColor = True
        Me.btn_first.Visible = False
        '
        'combobox_reup_search_membershiptype
        '
        Me.combobox_reup_search_membershiptype.AutoCompleteCustomSource.AddRange(New String() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_reup_search_membershiptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_reup_search_membershiptype.FormattingEnabled = True
        Me.combobox_reup_search_membershiptype.Items.AddRange(New Object() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_reup_search_membershiptype.Location = New System.Drawing.Point(188, 96)
        Me.combobox_reup_search_membershiptype.Name = "combobox_reup_search_membershiptype"
        Me.combobox_reup_search_membershiptype.Size = New System.Drawing.Size(141, 21)
        Me.combobox_reup_search_membershiptype.TabIndex = 60
        Me.combobox_reup_search_membershiptype.Visible = False
        '
        'MaterialLabel52
        '
        Me.MaterialLabel52.AutoSize = True
        Me.MaterialLabel52.Depth = 0
        Me.MaterialLabel52.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel52.Location = New System.Drawing.Point(50, 98)
        Me.MaterialLabel52.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel52.Name = "MaterialLabel52"
        Me.MaterialLabel52.Size = New System.Drawing.Size(132, 19)
        Me.MaterialLabel52.TabIndex = 59
        Me.MaterialLabel52.Text = "Membership Type:"
        Me.MaterialLabel52.Visible = False
        '
        'txt_reup_email
        '
        Me.txt_reup_email.Depth = 0
        Me.txt_reup_email.Enabled = False
        Me.txt_reup_email.Hint = ""
        Me.txt_reup_email.Location = New System.Drawing.Point(595, 294)
        Me.txt_reup_email.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_email.Name = "txt_reup_email"
        Me.txt_reup_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_email.SelectedText = ""
        Me.txt_reup_email.SelectionLength = 0
        Me.txt_reup_email.SelectionStart = 0
        Me.txt_reup_email.Size = New System.Drawing.Size(141, 23)
        Me.txt_reup_email.TabIndex = 40
        Me.txt_reup_email.UseSystemPasswordChar = False
        '
        'txt_reup_cont
        '
        Me.txt_reup_cont.Depth = 0
        Me.txt_reup_cont.Enabled = False
        Me.txt_reup_cont.Hint = ""
        Me.txt_reup_cont.Location = New System.Drawing.Point(595, 255)
        Me.txt_reup_cont.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_cont.Name = "txt_reup_cont"
        Me.txt_reup_cont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_cont.SelectedText = ""
        Me.txt_reup_cont.SelectionLength = 0
        Me.txt_reup_cont.SelectionStart = 0
        Me.txt_reup_cont.Size = New System.Drawing.Size(141, 23)
        Me.txt_reup_cont.TabIndex = 39
        Me.txt_reup_cont.UseSystemPasswordChar = False
        '
        'txt_reup_shipid
        '
        Me.txt_reup_shipid.Depth = 0
        Me.txt_reup_shipid.Enabled = False
        Me.txt_reup_shipid.Hint = ""
        Me.txt_reup_shipid.Location = New System.Drawing.Point(650, 216)
        Me.txt_reup_shipid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_shipid.Name = "txt_reup_shipid"
        Me.txt_reup_shipid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_shipid.SelectedText = ""
        Me.txt_reup_shipid.SelectionLength = 0
        Me.txt_reup_shipid.SelectionStart = 0
        Me.txt_reup_shipid.Size = New System.Drawing.Size(86, 23)
        Me.txt_reup_shipid.TabIndex = 38
        Me.txt_reup_shipid.UseSystemPasswordChar = False
        '
        'txt_reup_lastname
        '
        Me.txt_reup_lastname.Depth = 0
        Me.txt_reup_lastname.Enabled = False
        Me.txt_reup_lastname.Hint = ""
        Me.txt_reup_lastname.Location = New System.Drawing.Point(595, 137)
        Me.txt_reup_lastname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_lastname.Name = "txt_reup_lastname"
        Me.txt_reup_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_lastname.SelectedText = ""
        Me.txt_reup_lastname.SelectionLength = 0
        Me.txt_reup_lastname.SelectionStart = 0
        Me.txt_reup_lastname.Size = New System.Drawing.Size(141, 23)
        Me.txt_reup_lastname.TabIndex = 37
        Me.txt_reup_lastname.UseSystemPasswordChar = False
        '
        'txt_reup_firstname
        '
        Me.txt_reup_firstname.Depth = 0
        Me.txt_reup_firstname.Enabled = False
        Me.txt_reup_firstname.Hint = ""
        Me.txt_reup_firstname.Location = New System.Drawing.Point(595, 98)
        Me.txt_reup_firstname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_firstname.Name = "txt_reup_firstname"
        Me.txt_reup_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_firstname.SelectedText = ""
        Me.txt_reup_firstname.SelectionLength = 0
        Me.txt_reup_firstname.SelectionStart = 0
        Me.txt_reup_firstname.Size = New System.Drawing.Size(141, 23)
        Me.txt_reup_firstname.TabIndex = 36
        Me.txt_reup_firstname.UseSystemPasswordChar = False
        '
        'txt_reup_id
        '
        Me.txt_reup_id.Depth = 0
        Me.txt_reup_id.Enabled = False
        Me.txt_reup_id.Hint = ""
        Me.txt_reup_id.Location = New System.Drawing.Point(595, 59)
        Me.txt_reup_id.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_id.Name = "txt_reup_id"
        Me.txt_reup_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_id.SelectedText = ""
        Me.txt_reup_id.SelectionLength = 0
        Me.txt_reup_id.SelectionStart = 0
        Me.txt_reup_id.Size = New System.Drawing.Size(141, 23)
        Me.txt_reup_id.TabIndex = 35
        Me.txt_reup_id.UseSystemPasswordChar = False
        '
        'txt_reup_search
        '
        Me.txt_reup_search.Depth = 0
        Me.txt_reup_search.Hint = ""
        Me.txt_reup_search.Location = New System.Drawing.Point(188, 133)
        Me.txt_reup_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reup_search.Name = "txt_reup_search"
        Me.txt_reup_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reup_search.SelectedText = ""
        Me.txt_reup_search.SelectionLength = 0
        Me.txt_reup_search.SelectionStart = 0
        Me.txt_reup_search.Size = New System.Drawing.Size(121, 23)
        Me.txt_reup_search.TabIndex = 34
        Me.txt_reup_search.UseSystemPasswordChar = False
        '
        'label_reup_shipid
        '
        Me.label_reup_shipid.AutoSize = True
        Me.label_reup_shipid.Depth = 0
        Me.label_reup_shipid.Enabled = False
        Me.label_reup_shipid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_reup_shipid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_reup_shipid.Location = New System.Drawing.Point(595, 216)
        Me.label_reup_shipid.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_reup_shipid.Name = "label_reup_shipid"
        Me.label_reup_shipid.Size = New System.Drawing.Size(23, 19)
        Me.label_reup_shipid.TabIndex = 32
        Me.label_reup_shipid.Text = "ID"
        '
        'label_reup_search
        '
        Me.label_reup_search.Depth = 0
        Me.label_reup_search.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_reup_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_reup_search.Location = New System.Drawing.Point(29, 137)
        Me.label_reup_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_reup_search.Name = "label_reup_search"
        Me.label_reup_search.Size = New System.Drawing.Size(153, 19)
        Me.label_reup_search.TabIndex = 30
        Me.label_reup_search.Text = "Search:"
        Me.label_reup_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaterialLabel47
        '
        Me.MaterialLabel47.AutoSize = True
        Me.MaterialLabel47.Depth = 0
        Me.MaterialLabel47.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel47.Location = New System.Drawing.Point(397, 216)
        Me.MaterialLabel47.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel47.Name = "MaterialLabel47"
        Me.MaterialLabel47.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel47.TabIndex = 28
        Me.MaterialLabel47.Text = "Membership ID:"
        '
        'combobox_reup_membertype
        '
        Me.combobox_reup_membertype.AutoCompleteCustomSource.AddRange(New String() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_reup_membertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_reup_membertype.Enabled = False
        Me.combobox_reup_membertype.FormattingEnabled = True
        Me.combobox_reup_membertype.Items.AddRange(New Object() {"Deluxe", "Non-Deluxe", "Weekday"})
        Me.combobox_reup_membertype.Location = New System.Drawing.Point(595, 176)
        Me.combobox_reup_membertype.Name = "combobox_reup_membertype"
        Me.combobox_reup_membertype.Size = New System.Drawing.Size(141, 21)
        Me.combobox_reup_membertype.TabIndex = 27
        '
        'MaterialLabel21
        '
        Me.MaterialLabel21.AutoSize = True
        Me.MaterialLabel21.Depth = 0
        Me.MaterialLabel21.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel21.Location = New System.Drawing.Point(397, 176)
        Me.MaterialLabel21.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel21.Name = "MaterialLabel21"
        Me.MaterialLabel21.Size = New System.Drawing.Size(132, 19)
        Me.MaterialLabel21.TabIndex = 26
        Me.MaterialLabel21.Text = "Membership Type:"
        '
        'btn_remove
        '
        Me.btn_remove.Depth = 0
        Me.btn_remove.Location = New System.Drawing.Point(522, 374)
        Me.btn_remove.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Primary = True
        Me.btn_remove.Size = New System.Drawing.Size(115, 39)
        Me.btn_remove.TabIndex = 25
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = True
        Me.btn_remove.Visible = False
        '
        'btn_reup_search
        '
        Me.btn_reup_search.Depth = 0
        Me.btn_reup_search.Location = New System.Drawing.Point(234, 228)
        Me.btn_reup_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reup_search.Name = "btn_reup_search"
        Me.btn_reup_search.Primary = True
        Me.btn_reup_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_reup_search.TabIndex = 24
        Me.btn_reup_search.Text = "Search"
        Me.btn_reup_search.UseVisualStyleBackColor = True
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(396, 294)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel8.TabIndex = 17
        Me.MaterialLabel8.Text = "E-mail Address:"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(396, 255)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(123, 19)
        Me.MaterialLabel9.TabIndex = 16
        Me.MaterialLabel9.Text = "Contact Number:"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(396, 137)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(145, 19)
        Me.MaterialLabel11.TabIndex = 14
        Me.MaterialLabel11.Text = "Member Last Name:"
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(397, 98)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(146, 19)
        Me.MaterialLabel12.TabIndex = 13
        Me.MaterialLabel12.Text = "Member First Name:"
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.AutoSize = True
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel13.Location = New System.Drawing.Point(396, 59)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel13.TabIndex = 12
        Me.MaterialLabel13.Text = "Member ID:"
        '
        'combobox_reup_search
        '
        Me.combobox_reup_search.AutoCompleteCustomSource.AddRange(New String() {"Member ID", "Member First Name", "Member Last Name", "Membership ID"})
        Me.combobox_reup_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combobox_reup_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combobox_reup_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_reup_search.FormattingEnabled = True
        Me.combobox_reup_search.Items.AddRange(New Object() {"Member ID", "Member First Name", "Member Last Name", "Membership ID"})
        Me.combobox_reup_search.Location = New System.Drawing.Point(188, 59)
        Me.combobox_reup_search.Name = "combobox_reup_search"
        Me.combobox_reup_search.Size = New System.Drawing.Size(121, 21)
        Me.combobox_reup_search.TabIndex = 3
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(103, 59)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(79, 19)
        Me.MaterialLabel7.TabIndex = 1
        Me.MaterialLabel7.Text = "Search By:"
        '
        'tabpgae
        '
        Me.tabpgae.BackColor = System.Drawing.Color.White
        Me.tabpgae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tabpgae.Controls.Add(Me.btn_refresh)
        Me.tabpgae.Controls.Add(Me.btn_payadd)
        Me.tabpgae.Controls.Add(Me.btn_payedit)
        Me.tabpgae.Controls.Add(Me.txt_pay_search)
        Me.tabpgae.Controls.Add(Me.label_pay_search)
        Me.tabpgae.Controls.Add(Me.payment_groupbox)
        Me.tabpgae.Controls.Add(Me.payment_listview)
        Me.tabpgae.Enabled = Global.VB_assignment_.My.MySettings.Default.Enabled
        Me.tabpgae.ForeColor = System.Drawing.Color.Transparent
        Me.tabpgae.Location = New System.Drawing.Point(4, 22)
        Me.tabpgae.Name = "tabpgae"
        Me.tabpgae.Size = New System.Drawing.Size(829, 474)
        Me.tabpgae.TabIndex = 2
        Me.tabpgae.Text = "Payment"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackgroundImage = CType(resources.GetObject("btn_refresh.BackgroundImage"), System.Drawing.Image)
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.Location = New System.Drawing.Point(790, 144)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(30, 30)
        Me.btn_refresh.TabIndex = 12
        Me.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_payadd
        '
        Me.btn_payadd.Depth = 0
        Me.btn_payadd.Location = New System.Drawing.Point(504, 76)
        Me.btn_payadd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_payadd.Name = "btn_payadd"
        Me.btn_payadd.Primary = True
        Me.btn_payadd.Size = New System.Drawing.Size(96, 37)
        Me.btn_payadd.TabIndex = 11
        Me.btn_payadd.Text = "Add"
        Me.btn_payadd.UseVisualStyleBackColor = True
        '
        'btn_payedit
        '
        Me.btn_payedit.Depth = 0
        Me.btn_payedit.Location = New System.Drawing.Point(619, 76)
        Me.btn_payedit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_payedit.Name = "btn_payedit"
        Me.btn_payedit.Primary = True
        Me.btn_payedit.Size = New System.Drawing.Size(96, 37)
        Me.btn_payedit.TabIndex = 10
        Me.btn_payedit.Text = "Edit"
        Me.btn_payedit.UseVisualStyleBackColor = True
        Me.btn_payedit.Visible = False
        '
        'txt_pay_search
        '
        Me.txt_pay_search.Depth = 0
        Me.txt_pay_search.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_pay_search.Hint = ""
        Me.txt_pay_search.Location = New System.Drawing.Point(189, 90)
        Me.txt_pay_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_pay_search.Name = "txt_pay_search"
        Me.txt_pay_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pay_search.SelectedText = ""
        Me.txt_pay_search.SelectionLength = 0
        Me.txt_pay_search.SelectionStart = 0
        Me.txt_pay_search.Size = New System.Drawing.Size(113, 23)
        Me.txt_pay_search.TabIndex = 6
        Me.txt_pay_search.UseSystemPasswordChar = False
        Me.txt_pay_search.Visible = False
        '
        'label_pay_search
        '
        Me.label_pay_search.AutoSize = True
        Me.label_pay_search.Depth = 0
        Me.label_pay_search.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_pay_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_pay_search.Location = New System.Drawing.Point(124, 90)
        Me.label_pay_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_pay_search.Name = "label_pay_search"
        Me.label_pay_search.Size = New System.Drawing.Size(59, 19)
        Me.label_pay_search.TabIndex = 5
        Me.label_pay_search.Text = "Search:"
        Me.label_pay_search.Visible = False
        '
        'payment_groupbox
        '
        Me.payment_groupbox.Controls.Add(Me.radio_pid)
        Me.payment_groupbox.Controls.Add(Me.radio_mid)
        Me.payment_groupbox.Controls.Add(Me.radio_mshipid)
        Me.payment_groupbox.Location = New System.Drawing.Point(8, 3)
        Me.payment_groupbox.Name = "payment_groupbox"
        Me.payment_groupbox.Size = New System.Drawing.Size(294, 41)
        Me.payment_groupbox.TabIndex = 1
        Me.payment_groupbox.TabStop = False
        Me.payment_groupbox.Text = "Search By:"
        '
        'radio_pid
        '
        Me.radio_pid.AutoSize = True
        Me.radio_pid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_pid.Location = New System.Drawing.Point(204, 18)
        Me.radio_pid.Name = "radio_pid"
        Me.radio_pid.Size = New System.Drawing.Size(80, 17)
        Me.radio_pid.TabIndex = 3
        Me.radio_pid.TabStop = True
        Me.radio_pid.Text = "Payment ID"
        Me.radio_pid.UseVisualStyleBackColor = True
        '
        'radio_mid
        '
        Me.radio_mid.AutoSize = True
        Me.radio_mid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_mid.Location = New System.Drawing.Point(6, 18)
        Me.radio_mid.Name = "radio_mid"
        Me.radio_mid.Size = New System.Drawing.Size(77, 17)
        Me.radio_mid.TabIndex = 2
        Me.radio_mid.TabStop = True
        Me.radio_mid.Text = "Member ID"
        Me.radio_mid.UseVisualStyleBackColor = True
        '
        'radio_mshipid
        '
        Me.radio_mshipid.AutoSize = True
        Me.radio_mshipid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_mshipid.Location = New System.Drawing.Point(89, 18)
        Me.radio_mshipid.Name = "radio_mshipid"
        Me.radio_mshipid.Size = New System.Drawing.Size(96, 17)
        Me.radio_mshipid.TabIndex = 2
        Me.radio_mshipid.TabStop = True
        Me.radio_mshipid.Text = "Membership ID"
        Me.radio_mshipid.UseVisualStyleBackColor = True
        '
        'payment_listview
        '
        Me.payment_listview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.list_pid, Me.list_mid, Me.list_mship_id, Me.list_doe, Me.list_log, Me.list_desc, Me.list_paytype, Me.list_paid, Me.list_due, Me.list_pdate})
        Me.payment_listview.Location = New System.Drawing.Point(8, 172)
        Me.payment_listview.MultiSelect = False
        Me.payment_listview.Name = "payment_listview"
        Me.payment_listview.Size = New System.Drawing.Size(811, 294)
        Me.payment_listview.TabIndex = 0
        Me.payment_listview.UseCompatibleStateImageBehavior = False
        Me.payment_listview.View = System.Windows.Forms.View.Details
        '
        'list_pid
        '
        Me.list_pid.Text = "Payment ID"
        Me.list_pid.Width = 100
        '
        'list_mid
        '
        Me.list_mid.Text = "Member ID"
        Me.list_mid.Width = 100
        '
        'list_mship_id
        '
        Me.list_mship_id.Text = "Membership ID"
        Me.list_mship_id.Width = 100
        '
        'list_doe
        '
        Me.list_doe.Text = "Date of Entry"
        Me.list_doe.Width = 100
        '
        'list_log
        '
        Me.list_log.Text = "Logged by"
        Me.list_log.Width = 100
        '
        'list_desc
        '
        Me.list_desc.Text = "Description"
        Me.list_desc.Width = 100
        '
        'list_paytype
        '
        Me.list_paytype.Text = "Payment Type"
        Me.list_paytype.Width = 100
        '
        'list_paid
        '
        Me.list_paid.Text = "Paid"
        Me.list_paid.Width = 100
        '
        'list_due
        '
        Me.list_due.Text = "Amount Due"
        Me.list_due.Width = 100
        '
        'list_pdate
        '
        Me.list_pdate.Text = "Payment Date"
        Me.list_pdate.Width = 100
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.group_reportpay)
        Me.TabPage4.Controls.Add(Me.group_reportmem)
        Me.TabPage4.Controls.Add(Me.btn_reportpayspec)
        Me.TabPage4.Controls.Add(Me.btn_reportmemspec)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(829, 474)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Report"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'group_reportpay
        '
        Me.group_reportpay.BackColor = System.Drawing.Color.White
        Me.group_reportpay.Controls.Add(Me.ListView2)
        Me.group_reportpay.Controls.Add(Me.Label4)
        Me.group_reportpay.Controls.Add(Me.txt_reppay)
        Me.group_reportpay.Controls.Add(Me.label_paysearch)
        Me.group_reportpay.Controls.Add(Me.group_payrepsearch)
        Me.group_reportpay.Controls.Add(Me.btn_reportpayall)
        Me.group_reportpay.Controls.Add(Me.Label2)
        Me.group_reportpay.Location = New System.Drawing.Point(435, 27)
        Me.group_reportpay.Name = "group_reportpay"
        Me.group_reportpay.Size = New System.Drawing.Size(362, 403)
        Me.group_reportpay.TabIndex = 1
        Me.group_reportpay.TabStop = False
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.list3_pid, Me.list3_mid, Me.list3_mshipid, Me.list3_paytype, Me.list3_paid, Me.list3_due})
        Me.ListView2.Location = New System.Drawing.Point(6, 255)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(350, 142)
        Me.ListView2.TabIndex = 9
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'list3_pid
        '
        Me.list3_pid.Text = "Payment ID"
        Me.list3_pid.Width = 100
        '
        'list3_mid
        '
        Me.list3_mid.Text = "Member ID"
        Me.list3_mid.Width = 100
        '
        'list3_mshipid
        '
        Me.list3_mshipid.Text = "Membership ID"
        Me.list3_mshipid.Width = 100
        '
        'list3_paytype
        '
        Me.list3_paytype.Text = "Payment Type"
        Me.list3_paytype.Width = 100
        '
        'list3_paid
        '
        Me.list3_paid.Text = "Total Paid"
        Me.list3_paid.Width = 100
        '
        'list3_due
        '
        Me.list3_due.Text = "Amount Due"
        Me.list3_due.Width = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Example view:"
        '
        'txt_reppay
        '
        Me.txt_reppay.Depth = 0
        Me.txt_reppay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_reppay.Hint = ""
        Me.txt_reppay.Location = New System.Drawing.Point(69, 213)
        Me.txt_reppay.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_reppay.Name = "txt_reppay"
        Me.txt_reppay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_reppay.SelectedText = ""
        Me.txt_reppay.SelectionLength = 0
        Me.txt_reppay.SelectionStart = 0
        Me.txt_reppay.Size = New System.Drawing.Size(233, 23)
        Me.txt_reppay.TabIndex = 7
        Me.txt_reppay.UseSystemPasswordChar = False
        Me.txt_reppay.Visible = False
        '
        'label_paysearch
        '
        Me.label_paysearch.AutoSize = True
        Me.label_paysearch.Depth = 0
        Me.label_paysearch.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_paysearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_paysearch.Location = New System.Drawing.Point(55, 191)
        Me.label_paysearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_paysearch.Name = "label_paysearch"
        Me.label_paysearch.Size = New System.Drawing.Size(59, 19)
        Me.label_paysearch.TabIndex = 6
        Me.label_paysearch.Text = "Search:"
        Me.label_paysearch.Visible = False
        '
        'group_payrepsearch
        '
        Me.group_payrepsearch.Controls.Add(Me.radio_reppaypid)
        Me.group_payrepsearch.Controls.Add(Me.radio_reppaymid)
        Me.group_payrepsearch.Controls.Add(Me.radio_reppaymshipid)
        Me.group_payrepsearch.Location = New System.Drawing.Point(47, 118)
        Me.group_payrepsearch.Name = "group_payrepsearch"
        Me.group_payrepsearch.Size = New System.Drawing.Size(273, 41)
        Me.group_payrepsearch.TabIndex = 4
        Me.group_payrepsearch.TabStop = False
        Me.group_payrepsearch.Text = "Search By:"
        '
        'radio_reppaypid
        '
        Me.radio_reppaypid.AutoSize = True
        Me.radio_reppaypid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_reppaypid.Location = New System.Drawing.Point(191, 18)
        Me.radio_reppaypid.Name = "radio_reppaypid"
        Me.radio_reppaypid.Size = New System.Drawing.Size(80, 17)
        Me.radio_reppaypid.TabIndex = 3
        Me.radio_reppaypid.TabStop = True
        Me.radio_reppaypid.Text = "Payment ID"
        Me.radio_reppaypid.UseVisualStyleBackColor = True
        '
        'radio_reppaymid
        '
        Me.radio_reppaymid.AutoSize = True
        Me.radio_reppaymid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_reppaymid.Location = New System.Drawing.Point(6, 18)
        Me.radio_reppaymid.Name = "radio_reppaymid"
        Me.radio_reppaymid.Size = New System.Drawing.Size(77, 17)
        Me.radio_reppaymid.TabIndex = 2
        Me.radio_reppaymid.TabStop = True
        Me.radio_reppaymid.Text = "Member ID"
        Me.radio_reppaymid.UseVisualStyleBackColor = True
        '
        'radio_reppaymshipid
        '
        Me.radio_reppaymshipid.AutoSize = True
        Me.radio_reppaymshipid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_reppaymshipid.Location = New System.Drawing.Point(89, 18)
        Me.radio_reppaymshipid.Name = "radio_reppaymshipid"
        Me.radio_reppaymshipid.Size = New System.Drawing.Size(96, 17)
        Me.radio_reppaymshipid.TabIndex = 2
        Me.radio_reppaymshipid.TabStop = True
        Me.radio_reppaymshipid.Text = "Membership ID"
        Me.radio_reppaymshipid.UseVisualStyleBackColor = True
        '
        'btn_reportpayall
        '
        Me.btn_reportpayall.Depth = 0
        Me.btn_reportpayall.Location = New System.Drawing.Point(136, 47)
        Me.btn_reportpayall.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reportpayall.Name = "btn_reportpayall"
        Me.btn_reportpayall.Primary = True
        Me.btn_reportpayall.Size = New System.Drawing.Size(106, 40)
        Me.btn_reportpayall.TabIndex = 6
        Me.btn_reportpayall.Text = "Generate All"
        Me.btn_reportpayall.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Payment Report"
        '
        'group_reportmem
        '
        Me.group_reportmem.BackColor = System.Drawing.Color.White
        Me.group_reportmem.Controls.Add(Me.ListView1)
        Me.group_reportmem.Controls.Add(Me.Label3)
        Me.group_reportmem.Controls.Add(Me.txt_repmem)
        Me.group_reportmem.Controls.Add(Me.btn_reportmemall)
        Me.group_reportmem.Controls.Add(Me.group_memrepsearch)
        Me.group_reportmem.Controls.Add(Me.label_memsearch)
        Me.group_reportmem.Controls.Add(Me.Label1)
        Me.group_reportmem.Location = New System.Drawing.Point(33, 27)
        Me.group_reportmem.Name = "group_reportmem"
        Me.group_reportmem.Size = New System.Drawing.Size(362, 403)
        Me.group_reportmem.TabIndex = 0
        Me.group_reportmem.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.list2_mid, Me.list2_mshipid, Me.list2_fname, Me.list2_lname})
        Me.ListView1.Location = New System.Drawing.Point(6, 255)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(350, 142)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'list2_mid
        '
        Me.list2_mid.Text = "Member ID"
        Me.list2_mid.Width = 85
        '
        'list2_mshipid
        '
        Me.list2_mshipid.Text = "Membership ID"
        Me.list2_mshipid.Width = 85
        '
        'list2_fname
        '
        Me.list2_fname.Text = "First Name"
        Me.list2_fname.Width = 85
        '
        'list2_lname
        '
        Me.list2_lname.Text = "Last Name"
        Me.list2_lname.Width = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Example view:"
        '
        'txt_repmem
        '
        Me.txt_repmem.Depth = 0
        Me.txt_repmem.Hint = ""
        Me.txt_repmem.Location = New System.Drawing.Point(67, 213)
        Me.txt_repmem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_repmem.Name = "txt_repmem"
        Me.txt_repmem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_repmem.SelectedText = ""
        Me.txt_repmem.SelectionLength = 0
        Me.txt_repmem.SelectionStart = 0
        Me.txt_repmem.Size = New System.Drawing.Size(233, 23)
        Me.txt_repmem.TabIndex = 6
        Me.txt_repmem.UseSystemPasswordChar = False
        Me.txt_repmem.Visible = False
        '
        'btn_reportmemall
        '
        Me.btn_reportmemall.Depth = 0
        Me.btn_reportmemall.Location = New System.Drawing.Point(128, 47)
        Me.btn_reportmemall.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reportmemall.Name = "btn_reportmemall"
        Me.btn_reportmemall.Primary = True
        Me.btn_reportmemall.Size = New System.Drawing.Size(106, 40)
        Me.btn_reportmemall.TabIndex = 3
        Me.btn_reportmemall.Text = "Generate All"
        Me.btn_reportmemall.UseVisualStyleBackColor = True
        '
        'group_memrepsearch
        '
        Me.group_memrepsearch.Controls.Add(Me.radio_repmemlname)
        Me.group_memrepsearch.Controls.Add(Me.radio_repmemfname)
        Me.group_memrepsearch.Controls.Add(Me.radio_repmemmid)
        Me.group_memrepsearch.Controls.Add(Me.radio_repmemmshipid)
        Me.group_memrepsearch.Location = New System.Drawing.Point(49, 118)
        Me.group_memrepsearch.Name = "group_memrepsearch"
        Me.group_memrepsearch.Size = New System.Drawing.Size(269, 70)
        Me.group_memrepsearch.TabIndex = 2
        Me.group_memrepsearch.TabStop = False
        Me.group_memrepsearch.Text = "Search By:"
        '
        'radio_repmemlname
        '
        Me.radio_repmemlname.AutoSize = True
        Me.radio_repmemlname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_repmemlname.Location = New System.Drawing.Point(6, 41)
        Me.radio_repmemlname.Name = "radio_repmemlname"
        Me.radio_repmemlname.Size = New System.Drawing.Size(76, 17)
        Me.radio_repmemlname.TabIndex = 4
        Me.radio_repmemlname.TabStop = True
        Me.radio_repmemlname.Text = "Last Name"
        Me.radio_repmemlname.UseVisualStyleBackColor = True
        '
        'radio_repmemfname
        '
        Me.radio_repmemfname.AutoSize = True
        Me.radio_repmemfname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_repmemfname.Location = New System.Drawing.Point(191, 18)
        Me.radio_repmemfname.Name = "radio_repmemfname"
        Me.radio_repmemfname.Size = New System.Drawing.Size(75, 17)
        Me.radio_repmemfname.TabIndex = 3
        Me.radio_repmemfname.TabStop = True
        Me.radio_repmemfname.Text = "First Name"
        Me.radio_repmemfname.UseVisualStyleBackColor = True
        '
        'radio_repmemmid
        '
        Me.radio_repmemmid.AutoSize = True
        Me.radio_repmemmid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_repmemmid.Location = New System.Drawing.Point(6, 18)
        Me.radio_repmemmid.Name = "radio_repmemmid"
        Me.radio_repmemmid.Size = New System.Drawing.Size(77, 17)
        Me.radio_repmemmid.TabIndex = 2
        Me.radio_repmemmid.TabStop = True
        Me.radio_repmemmid.Text = "Member ID"
        Me.radio_repmemmid.UseVisualStyleBackColor = True
        '
        'radio_repmemmshipid
        '
        Me.radio_repmemmshipid.AutoSize = True
        Me.radio_repmemmshipid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radio_repmemmshipid.Location = New System.Drawing.Point(89, 18)
        Me.radio_repmemmshipid.Name = "radio_repmemmshipid"
        Me.radio_repmemmshipid.Size = New System.Drawing.Size(96, 17)
        Me.radio_repmemmshipid.TabIndex = 2
        Me.radio_repmemmshipid.TabStop = True
        Me.radio_repmemmshipid.Text = "Membership ID"
        Me.radio_repmemmshipid.UseVisualStyleBackColor = True
        '
        'label_memsearch
        '
        Me.label_memsearch.AutoSize = True
        Me.label_memsearch.Depth = 0
        Me.label_memsearch.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_memsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_memsearch.Location = New System.Drawing.Point(54, 191)
        Me.label_memsearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_memsearch.Name = "label_memsearch"
        Me.label_memsearch.Size = New System.Drawing.Size(59, 19)
        Me.label_memsearch.TabIndex = 1
        Me.label_memsearch.Text = "Search:"
        Me.label_memsearch.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Members Report"
        '
        'btn_reportpayspec
        '
        Me.btn_reportpayspec.Depth = 0
        Me.btn_reportpayspec.Location = New System.Drawing.Point(571, 427)
        Me.btn_reportpayspec.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reportpayspec.Name = "btn_reportpayspec"
        Me.btn_reportpayspec.Primary = True
        Me.btn_reportpayspec.Size = New System.Drawing.Size(106, 26)
        Me.btn_reportpayspec.TabIndex = 7
        Me.btn_reportpayspec.Text = "Find Specific"
        Me.btn_reportpayspec.UseVisualStyleBackColor = True
        Me.btn_reportpayspec.Visible = False
        '
        'btn_reportmemspec
        '
        Me.btn_reportmemspec.Depth = 0
        Me.btn_reportmemspec.Location = New System.Drawing.Point(161, 427)
        Me.btn_reportmemspec.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_reportmemspec.Name = "btn_reportmemspec"
        Me.btn_reportmemspec.Primary = True
        Me.btn_reportmemspec.Size = New System.Drawing.Size(106, 26)
        Me.btn_reportmemspec.TabIndex = 4
        Me.btn_reportmemspec.Text = "Find Specific"
        Me.btn_reportmemspec.UseVisualStyleBackColor = True
        Me.btn_reportmemspec.Visible = False
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermissionToolStripMenuItem, Me.mshipToolStripMenuItem})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(244, 70)
        '
        'PermissionToolStripMenuItem
        '
        Me.PermissionToolStripMenuItem.Name = "PermissionToolStripMenuItem"
        Me.PermissionToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.PermissionToolStripMenuItem.Text = "Admin Settings"
        '
        'mshipToolStripMenuItem
        '
        Me.mshipToolStripMenuItem.Name = "mshipToolStripMenuItem"
        Me.mshipToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.mshipToolStripMenuItem.Text = "Membership Fees and Privileges"
        '
        'label_uname
        '
        Me.label_uname.Depth = 0
        Me.label_uname.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_uname.Location = New System.Drawing.Point(589, 12)
        Me.label_uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_uname.Name = "label_uname"
        Me.label_uname.Size = New System.Drawing.Size(126, 17)
        Me.label_uname.TabIndex = 20
        Me.label_uname.Text = "uname"
        Me.label_uname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_unamelbl
        '
        Me.label_unamelbl.AutoSize = True
        Me.label_unamelbl.Depth = 0
        Me.label_unamelbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_unamelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_unamelbl.Location = New System.Drawing.Point(500, 12)
        Me.label_unamelbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_unamelbl.Name = "label_unamelbl"
        Me.label_unamelbl.Size = New System.Drawing.Size(86, 19)
        Me.label_unamelbl.TabIndex = 19
        Me.label_unamelbl.Text = "Logged as: "
        Me.label_unamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_time
        '
        Me.label_time.AutoSize = True
        Me.label_time.Depth = 0
        Me.label_time.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_time.Location = New System.Drawing.Point(6, 12)
        Me.label_time.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_time.Name = "label_time"
        Me.label_time.Size = New System.Drawing.Size(78, 19)
        Me.label_time.TabIndex = 21
        Me.label_time.Text = "label_time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'label_date
        '
        Me.label_date.AutoSize = True
        Me.label_date.Depth = 0
        Me.label_date.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_date.Location = New System.Drawing.Point(96, 12)
        Me.label_date.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(77, 19)
        Me.label_date.TabIndex = 22
        Me.label_date.Text = "label_date"
        '
        'label_day
        '
        Me.label_day.AutoSize = True
        Me.label_day.Depth = 0
        Me.label_day.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_day.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_day.Location = New System.Drawing.Point(185, 12)
        Me.label_day.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_day.Name = "label_day"
        Me.label_day.Size = New System.Drawing.Size(71, 19)
        Me.label_day.TabIndex = 23
        Me.label_day.Text = "label_day"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_logout)
        Me.GroupBox3.Controls.Add(Me.label_uname)
        Me.GroupBox3.Controls.Add(Me.label_day)
        Me.GroupBox3.Controls.Add(Me.label_time)
        Me.GroupBox3.Controls.Add(Me.label_date)
        Me.GroupBox3.Controls.Add(Me.label_unamelbl)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 585)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(827, 36)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.Depth = 0
        Me.btn_logout.Location = New System.Drawing.Point(746, 9)
        Me.btn_logout.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Primary = True
        Me.btn_logout.Size = New System.Drawing.Size(75, 23)
        Me.btn_logout.TabIndex = 24
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(857, 43)
        Me.MaterialTabSelector1.TabIndex = 25
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'mainpage
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 624)
        Me.ContextMenuStrip = Me.MaterialContextMenuStrip1
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(835, 624)
        Me.MinimumSize = New System.Drawing.Size(835, 624)
        Me.Name = "mainpage"
        Me.Text = "Main Page"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.tabpgae.ResumeLayout(False)
        Me.tabpgae.PerformLayout()
        Me.payment_groupbox.ResumeLayout(False)
        Me.payment_groupbox.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.group_reportpay.ResumeLayout(False)
        Me.group_reportpay.PerformLayout()
        Me.group_payrepsearch.ResumeLayout(False)
        Me.group_payrepsearch.PerformLayout()
        Me.group_reportmem.ResumeLayout(False)
        Me.group_reportmem.PerformLayout()
        Me.group_memrepsearch.ResumeLayout(False)
        Me.group_memrepsearch.PerformLayout()
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Add As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents combobox_reup_search As System.Windows.Forms.ComboBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_reup_search As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_remove As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents combobox_add_membertype As System.Windows.Forms.ComboBox
    Friend WithEvents combobox_reup_membertype As System.Windows.Forms.ComboBox
    Friend WithEvents MaterialLabel21 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel29 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_reup_search As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel47 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_add_shipid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_reup_shipid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_add_firstname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_add_id As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_add_lastname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_add_email As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_add_cont As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_add_shipid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_id As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_search As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_cont As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_shipid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_lastname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_firstname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_reup_email As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents PermissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents combobox_reup_search_membershiptype As System.Windows.Forms.ComboBox
    Friend WithEvents MaterialLabel52 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_last As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_next As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_prev As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_first As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_update As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents combobox_modeselect As System.Windows.Forms.ComboBox
    Friend WithEvents combobox_reup_status As System.Windows.Forms.ComboBox
    Friend WithEvents MaterialLabel53 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_uname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_unamelbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents label_day As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_time As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_date As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_logout As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents tabpgae As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents payment_listview As System.Windows.Forms.ListView
    Friend WithEvents list_pid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_mid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_mship_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_doe As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_log As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_paid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_due As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_pdate As System.Windows.Forms.ColumnHeader
    Friend WithEvents payment_groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents radio_pid As System.Windows.Forms.RadioButton
    Friend WithEvents radio_mid As System.Windows.Forms.RadioButton
    Friend WithEvents radio_mshipid As System.Windows.Forms.RadioButton
    Friend WithEvents label_pay_search As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_pay_search As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_payedit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_payadd As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents list_paytype As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents group_reportmem As System.Windows.Forms.GroupBox
    Friend WithEvents group_reportpay As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label_memsearch As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents group_payrepsearch As System.Windows.Forms.GroupBox
    Friend WithEvents radio_reppaypid As System.Windows.Forms.RadioButton
    Friend WithEvents radio_reppaymid As System.Windows.Forms.RadioButton
    Friend WithEvents radio_reppaymshipid As System.Windows.Forms.RadioButton
    Friend WithEvents group_memrepsearch As System.Windows.Forms.GroupBox
    Friend WithEvents radio_repmemmid As System.Windows.Forms.RadioButton
    Friend WithEvents radio_repmemmshipid As System.Windows.Forms.RadioButton
    Friend WithEvents txt_reppay As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label_paysearch As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_reportpayspec As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_reportpayall As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txt_repmem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btn_reportmemspec As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_reportmemall As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents radio_repmemlname As System.Windows.Forms.RadioButton
    Friend WithEvents radio_repmemfname As System.Windows.Forms.RadioButton
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents list3_pid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list3_mid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list3_mshipid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list3_paytype As System.Windows.Forms.ColumnHeader
    Friend WithEvents list3_paid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list3_due As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents list2_mid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list2_mshipid As System.Windows.Forms.ColumnHeader
    Friend WithEvents list2_fname As System.Windows.Forms.ColumnHeader
    Friend WithEvents list2_lname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mshipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
