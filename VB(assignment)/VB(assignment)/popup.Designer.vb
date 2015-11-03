<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popup
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
        Me.txt_edel_conpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_edel_urpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_del = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_edit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'txt_edel_conpwd
        '
        Me.txt_edel_conpwd.Depth = 0
        Me.txt_edel_conpwd.Hint = ""
        Me.txt_edel_conpwd.Location = New System.Drawing.Point(149, 111)
        Me.txt_edel_conpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_edel_conpwd.Name = "txt_edel_conpwd"
        Me.txt_edel_conpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_edel_conpwd.SelectedText = ""
        Me.txt_edel_conpwd.SelectionLength = 0
        Me.txt_edel_conpwd.SelectionStart = 0
        Me.txt_edel_conpwd.Size = New System.Drawing.Size(75, 23)
        Me.txt_edel_conpwd.TabIndex = 19
        Me.txt_edel_conpwd.UseSystemPasswordChar = False
        '
        'txt_edel_urpwd
        '
        Me.txt_edel_urpwd.Depth = 0
        Me.txt_edel_urpwd.Hint = ""
        Me.txt_edel_urpwd.Location = New System.Drawing.Point(149, 75)
        Me.txt_edel_urpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_edel_urpwd.Name = "txt_edel_urpwd"
        Me.txt_edel_urpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_edel_urpwd.SelectedText = ""
        Me.txt_edel_urpwd.SelectionLength = 0
        Me.txt_edel_urpwd.SelectionStart = 0
        Me.txt_edel_urpwd.Size = New System.Drawing.Size(75, 23)
        Me.txt_edel_urpwd.TabIndex = 18
        Me.txt_edel_urpwd.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(3, 115)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(137, 19)
        Me.MaterialLabel6.TabIndex = 17
        Me.MaterialLabel6.Text = "Confirm Password:"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(3, 75)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(114, 19)
        Me.MaterialLabel7.TabIndex = 16
        Me.MaterialLabel7.Text = "Your Password:"
        '
        'btn_del
        '
        Me.btn_del.Depth = 0
        Me.btn_del.Location = New System.Drawing.Point(82, 187)
        Me.btn_del.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Primary = True
        Me.btn_del.Size = New System.Drawing.Size(75, 23)
        Me.btn_del.TabIndex = 21
        Me.btn_del.Text = "delete"
        Me.btn_del.UseVisualStyleBackColor = True
        Me.btn_del.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.Depth = 0
        Me.btn_edit.Location = New System.Drawing.Point(82, 150)
        Me.btn_edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Primary = True
        Me.btn_edit.Size = New System.Drawing.Size(75, 22)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 234)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.txt_edel_conpwd)
        Me.Controls.Add(Me.txt_edel_urpwd)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Name = "popup"
        Me.Text = "Admin Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_edel_conpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_edel_urpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_del As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_edit As MaterialSkin.Controls.MaterialRaisedButton
End Class
