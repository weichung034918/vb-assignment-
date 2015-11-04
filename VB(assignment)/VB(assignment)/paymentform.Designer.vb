<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentform
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
        Me.txt_mid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_mshipid = New MaterialSkin.Controls.MaterialLabel()
        Me.label_doe = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.label_log = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label_pid1 = New MaterialSkin.Controls.MaterialLabel()
        Me.label_pid2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label_paydate = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_amount = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label_totalwgst = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_due = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_add = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.radio_mfee = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radio_rfee = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btn_edit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_payedit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(6, 16)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(130, 21)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Payment ID:"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(6, 47)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(130, 21)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Member ID:"
        Me.MaterialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(6, 79)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(130, 21)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "Membership ID:"
        Me.MaterialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(6, 110)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(130, 21)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Date of Entry:"
        Me.MaterialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_mid
        '
        Me.txt_mid.Depth = 0
        Me.txt_mid.Hint = ""
        Me.txt_mid.Location = New System.Drawing.Point(153, 47)
        Me.txt_mid.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_mid.Name = "txt_mid"
        Me.txt_mid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mid.SelectedText = ""
        Me.txt_mid.SelectionLength = 0
        Me.txt_mid.SelectionStart = 0
        Me.txt_mid.Size = New System.Drawing.Size(135, 23)
        Me.txt_mid.TabIndex = 0
        Me.txt_mid.UseSystemPasswordChar = False
        '
        'label_mshipid
        '
        Me.label_mshipid.Depth = 0
        Me.label_mshipid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_mshipid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_mshipid.Location = New System.Drawing.Point(149, 79)
        Me.label_mshipid.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_mshipid.Name = "label_mshipid"
        Me.label_mshipid.Size = New System.Drawing.Size(139, 21)
        Me.label_mshipid.TabIndex = 9
        Me.label_mshipid.Text = "MshipID"
        Me.label_mshipid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_doe
        '
        Me.label_doe.Depth = 0
        Me.label_doe.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_doe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_doe.Location = New System.Drawing.Point(149, 110)
        Me.label_doe.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_doe.Name = "label_doe"
        Me.label_doe.Size = New System.Drawing.Size(139, 21)
        Me.label_doe.TabIndex = 10
        Me.label_doe.Text = "DOE"
        Me.label_doe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(21, 16)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(112, 21)
        Me.MaterialLabel8.TabIndex = 11
        Me.MaterialLabel8.Text = "Logged by:"
        Me.MaterialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label_log
        '
        Me.label_log.Depth = 0
        Me.label_log.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_log.Location = New System.Drawing.Point(139, 16)
        Me.label_log.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_log.Name = "label_log"
        Me.label_log.Size = New System.Drawing.Size(139, 21)
        Me.label_log.TabIndex = 12
        Me.label_log.Text = "Increment ID"
        Me.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label_pid1)
        Me.GroupBox1.Controls.Add(Me.label_pid2)
        Me.GroupBox1.Controls.Add(Me.label_doe)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.label_mshipid)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox1.Controls.Add(Me.txt_mid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 144)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'label_pid1
        '
        Me.label_pid1.Depth = 0
        Me.label_pid1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_pid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_pid1.Location = New System.Drawing.Point(142, 16)
        Me.label_pid1.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_pid1.Name = "label_pid1"
        Me.label_pid1.Size = New System.Drawing.Size(36, 21)
        Me.label_pid1.TabIndex = 12
        Me.label_pid1.Text = "PM"
        Me.label_pid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_pid2
        '
        Me.label_pid2.Depth = 0
        Me.label_pid2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_pid2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_pid2.Location = New System.Drawing.Point(176, 16)
        Me.label_pid2.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_pid2.Name = "label_pid2"
        Me.label_pid2.Size = New System.Drawing.Size(112, 21)
        Me.label_pid2.TabIndex = 11
        Me.label_pid2.Text = "PID"
        Me.label_pid2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(25, 47)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(108, 21)
        Me.MaterialLabel10.TabIndex = 14
        Me.MaterialLabel10.Text = "Description:"
        Me.MaterialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(139, 49)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(138, 51)
        Me.txt_desc.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.label_paydate)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel5)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel10)
        Me.GroupBox2.Controls.Add(Me.txt_desc)
        Me.GroupBox2.Controls.Add(Me.MaterialLabel8)
        Me.GroupBox2.Controls.Add(Me.label_log)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 144)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'label_paydate
        '
        Me.label_paydate.Depth = 0
        Me.label_paydate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_paydate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_paydate.Location = New System.Drawing.Point(139, 110)
        Me.label_paydate.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_paydate.Name = "label_paydate"
        Me.label_paydate.Size = New System.Drawing.Size(108, 21)
        Me.label_paydate.TabIndex = 17
        Me.label_paydate.Text = "PDATE"
        Me.label_paydate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(25, 110)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(108, 21)
        Me.MaterialLabel5.TabIndex = 16
        Me.MaterialLabel5.Text = "Payment Date:"
        Me.MaterialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(18, 231)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(130, 21)
        Me.MaterialLabel11.TabIndex = 11
        Me.MaterialLabel11.Text = "Pay Amount:"
        Me.MaterialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_amount
        '
        Me.txt_amount.Depth = 0
        Me.txt_amount.Hint = ""
        Me.txt_amount.Location = New System.Drawing.Point(85, 255)
        Me.txt_amount.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amount.SelectedText = ""
        Me.txt_amount.SelectionLength = 0
        Me.txt_amount.SelectionStart = 0
        Me.txt_amount.Size = New System.Drawing.Size(144, 23)
        Me.txt_amount.TabIndex = 0
        Me.txt_amount.UseSystemPasswordChar = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.label_totalwgst)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.label_due)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel13)
        Me.GroupBox3.Controls.Add(Me.MaterialLabel12)
        Me.GroupBox3.Location = New System.Drawing.Point(315, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 96)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "* inclusive of 6% GST"
        '
        'label_totalwgst
        '
        Me.label_totalwgst.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_totalwgst.Location = New System.Drawing.Point(131, 9)
        Me.label_totalwgst.Name = "label_totalwgst"
        Me.label_totalwgst.Size = New System.Drawing.Size(128, 42)
        Me.label_totalwgst.TabIndex = 23
        Me.label_totalwgst.Text = "withGST"
        Me.label_totalwgst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 42)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "RM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_due
        '
        Me.label_due.Depth = 0
        Me.label_due.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_due.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_due.Location = New System.Drawing.Point(76, 63)
        Me.label_due.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_due.Name = "label_due"
        Me.label_due.Size = New System.Drawing.Size(81, 21)
        Me.label_due.TabIndex = 21
        Me.label_due.Text = "dueamount"
        Me.label_due.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel13.Location = New System.Drawing.Point(1, 22)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(52, 21)
        Me.MaterialLabel13.TabIndex = 18
        Me.MaterialLabel13.Text = "Total:"
        Me.MaterialLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(6, 63)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(47, 21)
        Me.MaterialLabel12.TabIndex = 18
        Me.MaterialLabel12.Text = "Due:"
        Me.MaterialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_add
        '
        Me.btn_add.Depth = 0
        Me.btn_add.Location = New System.Drawing.Point(395, 328)
        Me.btn_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Primary = True
        Me.btn_add.Size = New System.Drawing.Size(135, 34)
        Me.btn_add.TabIndex = 18
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        Me.btn_add.Visible = False
        '
        'radio_mfee
        '
        Me.radio_mfee.AutoSize = True
        Me.radio_mfee.Depth = 0
        Me.radio_mfee.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radio_mfee.Location = New System.Drawing.Point(85, 282)
        Me.radio_mfee.Margin = New System.Windows.Forms.Padding(0)
        Me.radio_mfee.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radio_mfee.MouseState = MaterialSkin.MouseState.HOVER
        Me.radio_mfee.Name = "radio_mfee"
        Me.radio_mfee.Ripple = True
        Me.radio_mfee.Size = New System.Drawing.Size(105, 30)
        Me.radio_mfee.TabIndex = 1
        Me.radio_mfee.TabStop = True
        Me.radio_mfee.Text = "Monthly Fee"
        Me.radio_mfee.UseVisualStyleBackColor = True
        '
        'radio_rfee
        '
        Me.radio_rfee.AutoSize = True
        Me.radio_rfee.Depth = 0
        Me.radio_rfee.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radio_rfee.Location = New System.Drawing.Point(85, 312)
        Me.radio_rfee.Margin = New System.Windows.Forms.Padding(0)
        Me.radio_rfee.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radio_rfee.MouseState = MaterialSkin.MouseState.HOVER
        Me.radio_rfee.Name = "radio_rfee"
        Me.radio_rfee.Ripple = True
        Me.radio_rfee.Size = New System.Drawing.Size(129, 30)
        Me.radio_rfee.TabIndex = 2
        Me.radio_rfee.TabStop = True
        Me.radio_rfee.Text = "Registration Fee"
        Me.radio_rfee.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Depth = 0
        Me.btn_edit.Location = New System.Drawing.Point(254, 328)
        Me.btn_edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Primary = True
        Me.btn_edit.Size = New System.Drawing.Size(135, 34)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "update"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'btn_payedit
        '
        Me.btn_payedit.Depth = 0
        Me.btn_payedit.Location = New System.Drawing.Point(236, 255)
        Me.btn_payedit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_payedit.Name = "btn_payedit"
        Me.btn_payedit.Primary = True
        Me.btn_payedit.Size = New System.Drawing.Size(52, 23)
        Me.btn_payedit.TabIndex = 23
        Me.btn_payedit.Text = "edit"
        Me.btn_payedit.UseVisualStyleBackColor = True
        Me.btn_payedit.Visible = False
        '
        'paymentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 374)
        Me.Controls.Add(Me.btn_payedit)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.radio_rfee)
        Me.Controls.Add(Me.radio_mfee)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.MaterialLabel11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "paymentform"
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_mid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label_mshipid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_doe As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_log As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_amount As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents label_due As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_add As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents label_totalwgst As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label_paydate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_pid2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents radio_mfee As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radio_rfee As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents label_pid1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_edit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_payedit As MaterialSkin.Controls.MaterialRaisedButton
End Class
