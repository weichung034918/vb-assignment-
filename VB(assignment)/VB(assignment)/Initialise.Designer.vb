<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Initialise
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
        Me.mdb_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.accdb_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.label_uname = New MaterialSkin.Controls.MaterialLabel()
        Me.label_pwd = New MaterialSkin.Controls.MaterialLabel()
        Me.label_conpwd = New MaterialSkin.Controls.MaterialLabel()
        Me.field_uname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.field_pwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.field_conpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.next_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 71)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(108, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "MaterialLabel1"
        '
        'mdb_btn
        '
        Me.mdb_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mdb_btn.Depth = 0
        Me.mdb_btn.Location = New System.Drawing.Point(12, 148)
        Me.mdb_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.mdb_btn.Name = "mdb_btn"
        Me.mdb_btn.Primary = True
        Me.mdb_btn.Size = New System.Drawing.Size(193, 35)
        Me.mdb_btn.TabIndex = 0
        Me.mdb_btn.Text = "Create MDB Database"
        Me.mdb_btn.UseVisualStyleBackColor = True
        '
        'accdb_btn
        '
        Me.accdb_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accdb_btn.Depth = 0
        Me.accdb_btn.Location = New System.Drawing.Point(12, 201)
        Me.accdb_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.accdb_btn.Name = "accdb_btn"
        Me.accdb_btn.Primary = True
        Me.accdb_btn.Size = New System.Drawing.Size(193, 33)
        Me.accdb_btn.TabIndex = 0
        Me.accdb_btn.Text = "Create ACCDB Database"
        Me.accdb_btn.UseVisualStyleBackColor = True
        '
        'label_uname
        '
        Me.label_uname.AutoSize = True
        Me.label_uname.Depth = 0
        Me.label_uname.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_uname.Location = New System.Drawing.Point(404, 71)
        Me.label_uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_uname.Name = "label_uname"
        Me.label_uname.Size = New System.Drawing.Size(81, 19)
        Me.label_uname.TabIndex = 0
        Me.label_uname.Text = "Username:"
        '
        'label_pwd
        '
        Me.label_pwd.AutoSize = True
        Me.label_pwd.Depth = 0
        Me.label_pwd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_pwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_pwd.Location = New System.Drawing.Point(404, 90)
        Me.label_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_pwd.Name = "label_pwd"
        Me.label_pwd.Size = New System.Drawing.Size(79, 19)
        Me.label_pwd.TabIndex = 0
        Me.label_pwd.Text = "Password:"
        '
        'label_conpwd
        '
        Me.label_conpwd.AutoSize = True
        Me.label_conpwd.Depth = 0
        Me.label_conpwd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_conpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_conpwd.Location = New System.Drawing.Point(404, 109)
        Me.label_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_conpwd.Name = "label_conpwd"
        Me.label_conpwd.Size = New System.Drawing.Size(137, 19)
        Me.label_conpwd.TabIndex = 0
        Me.label_conpwd.Text = "Confirm Password:"
        '
        'field_uname
        '
        Me.field_uname.Depth = 0
        Me.field_uname.Hint = ""
        Me.field_uname.Location = New System.Drawing.Point(408, 148)
        Me.field_uname.MouseState = MaterialSkin.MouseState.HOVER
        Me.field_uname.Name = "field_uname"
        Me.field_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.field_uname.SelectedText = ""
        Me.field_uname.SelectionLength = 0
        Me.field_uname.SelectionStart = 0
        Me.field_uname.Size = New System.Drawing.Size(75, 23)
        Me.field_uname.TabIndex = 1
        Me.field_uname.TabStop = False
        Me.field_uname.UseSystemPasswordChar = False
        '
        'field_pwd
        '
        Me.field_pwd.Depth = 0
        Me.field_pwd.Hint = ""
        Me.field_pwd.Location = New System.Drawing.Point(408, 178)
        Me.field_pwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.field_pwd.Name = "field_pwd"
        Me.field_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.field_pwd.SelectedText = ""
        Me.field_pwd.SelectionLength = 0
        Me.field_pwd.SelectionStart = 0
        Me.field_pwd.Size = New System.Drawing.Size(75, 23)
        Me.field_pwd.TabIndex = 2
        Me.field_pwd.TabStop = False
        Me.field_pwd.UseSystemPasswordChar = False
        '
        'field_conpwd
        '
        Me.field_conpwd.Depth = 0
        Me.field_conpwd.Hint = ""
        Me.field_conpwd.Location = New System.Drawing.Point(408, 208)
        Me.field_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.field_conpwd.Name = "field_conpwd"
        Me.field_conpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.field_conpwd.SelectedText = ""
        Me.field_conpwd.SelectionLength = 0
        Me.field_conpwd.SelectionStart = 0
        Me.field_conpwd.Size = New System.Drawing.Size(75, 23)
        Me.field_conpwd.TabIndex = 3
        Me.field_conpwd.TabStop = False
        Me.field_conpwd.UseSystemPasswordChar = False
        '
        'next_btn
        '
        Me.next_btn.Depth = 0
        Me.next_btn.Location = New System.Drawing.Point(489, 148)
        Me.next_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Primary = True
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 0
        Me.next_btn.Text = "Next"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'Initialise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 322)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.field_conpwd)
        Me.Controls.Add(Me.field_pwd)
        Me.Controls.Add(Me.field_uname)
        Me.Controls.Add(Me.label_conpwd)
        Me.Controls.Add(Me.label_pwd)
        Me.Controls.Add(Me.label_uname)
        Me.Controls.Add(Me.accdb_btn)
        Me.Controls.Add(Me.mdb_btn)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "Initialise"
        Me.Text = "Initial Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mdb_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents accdb_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents label_uname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_pwd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents label_conpwd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents field_uname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents field_pwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents field_conpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents next_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
