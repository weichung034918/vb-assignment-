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
        Me.txt_con_urpwd = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.label_urpwd = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_del = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btn_edit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'txt_con_urpwd
        '
        Me.txt_con_urpwd.Depth = 0
        Me.txt_con_urpwd.Hint = ""
        Me.txt_con_urpwd.Location = New System.Drawing.Point(83, 97)
        Me.txt_con_urpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_con_urpwd.Name = "txt_con_urpwd"
        Me.txt_con_urpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_con_urpwd.SelectedText = ""
        Me.txt_con_urpwd.SelectionLength = 0
        Me.txt_con_urpwd.SelectionStart = 0
        Me.txt_con_urpwd.Size = New System.Drawing.Size(100, 23)
        Me.txt_con_urpwd.TabIndex = 18
        Me.txt_con_urpwd.UseSystemPasswordChar = False
        '
        'label_urpwd
        '
        Me.label_urpwd.AutoSize = True
        Me.label_urpwd.Depth = 0
        Me.label_urpwd.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label_urpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label_urpwd.Location = New System.Drawing.Point(66, 75)
        Me.label_urpwd.MouseState = MaterialSkin.MouseState.HOVER
        Me.label_urpwd.Name = "label_urpwd"
        Me.label_urpwd.Size = New System.Drawing.Size(114, 19)
        Me.label_urpwd.TabIndex = 16
        Me.label_urpwd.Text = "Your Password:"
        '
        'btn_del
        '
        Me.btn_del.Depth = 0
        Me.btn_del.Location = New System.Drawing.Point(140, 139)
        Me.btn_del.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Primary = True
        Me.btn_del.Size = New System.Drawing.Size(75, 25)
        Me.btn_del.TabIndex = 21
        Me.btn_del.Text = "delete"
        Me.btn_del.UseVisualStyleBackColor = True
        Me.btn_del.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.Depth = 0
        Me.btn_edit.Location = New System.Drawing.Point(46, 139)
        Me.btn_edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Primary = True
        Me.btn_edit.Size = New System.Drawing.Size(75, 25)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "update"
        Me.btn_edit.UseVisualStyleBackColor = True
        Me.btn_edit.Visible = False
        '
        'popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 208)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.txt_con_urpwd)
        Me.Controls.Add(Me.label_urpwd)
        Me.Name = "popup"
        Me.Text = "Edit/Delete User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_con_urpwd As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents label_urpwd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_del As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btn_edit As MaterialSkin.Controls.MaterialRaisedButton
End Class
