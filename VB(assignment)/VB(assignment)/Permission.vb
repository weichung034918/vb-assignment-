Imports MaterialSkin

Public Class Permission
    Partial Class Permission
        Inherits MaterialSkin.Controls.MaterialForm
    End Class
    Private Sub Permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance
        skinmanager.AddFormToManage(Me)
        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepPurple100, TextShade.WHITE)
        permission_format()
    End Sub

   
   
    Private Sub permission_format()
        Me.Width = 520
        Me.Height = 330
        permission_search.Width = 110
        permission_search.Location = New Point(permission_search.Left, 90)
        permission_search.Left = (Me.Width / 5 * 2.5) - (permission_search.Width / 2)
        MaterialLabel1.Left = permission_search.Left - 70
        MaterialLabel1.Top = permission_search.Top
        permission_username.Left = (Me.Width / 5 * 2) - (permission_username.Width / 2)
        permission_username.Top = permission_search.Top + 50
        permission_username.Width = 100
        permission_username.Height = 20
        permission_password.Left = permission_username.Left
        permission_password.Top = permission_username.Top + 50
        permission_password.Width = 100
        permission_password.Height = 20
        permission_role.Left = permission_password.Left
        permission_role.Top = permission_password.Top + 50
        permission_role.Width = 100
        permission_role.Height = 20
        MaterialLabel2.Left = permission_username.Left - 100
        MaterialLabel2.Top = permission_username.Top
        MaterialLabel3.Left = MaterialLabel2.Left
        MaterialLabel3.Top = permission_password.Top
        MaterialLabel4.Left = MaterialLabel3.Left
        MaterialLabel4.Top = MaterialLabel4.Top
        'button configuration
        permission_btn_search.Left = permission_search.Left + permission_search.Width + 50
        permission_btn_search.Top = permission_search.Top
        permission_add.Left = (Me.Width / 5 * 4) - (permission_add.Width / 2)
        permission_add.Top = permission_username.Top
        permission_add.Width = 80
        permission_add.Height = 20
        permission_edit.Top = permission_password.Top
        permission_edit.Left = permission_add.Left
        permission_edit.Width = permission_add.Width
        permission_edit.Height = permission_add.Height
        permission_delete.Top = permission_role.Top
        permission_delete.Left = permission_edit.Left
        permission_delete.Height = permission_add.Height
        permission_delete.Width = permission_add.Width
        admin_username.Left = Me.Width - admin_username.Width
        admin_username.Top = Me.Height - admin_username.Height
    End Sub

    Private Sub permission_add_Click(sender As Object, e As EventArgs) Handles permission_add.Click
        ' for adding members
        permission_search.Enabled = False
        permission_username.Enabled = True
        permission_password.Enabled = True
        permission_role.Enabled = True

    End Sub

   
  

    Private Sub permission_search_GotFocus(sender As Object, e As EventArgs) Handles permission_search.GotFocus
        If permission_search.ForeColor = Color.Gray Then
            permission_search.ForeColor = Color.White
            permission_search.Text = ""
        End If
    End Sub

    Private Sub permission_search_LostFocus(sender As Object, e As EventArgs) Handles permission_search.LostFocus
        If permission_search.Text = "" Then
            permission_search.Text = "Enter Username"
            permission_search.ForeColor = Color.Gray
        End If
        If permission_search.Text = "" Then
            permission_btn_search.Visible = False
            permission_username.Enabled = False
            permission_password.Enabled = False
            permission_role.Enabled = False
        ElseIf permission_search.ForeColor = Color.Gray Then
            permission_btn_search.Visible = False
            permission_username.Enabled = False
            permission_password.Enabled = False
            permission_role.Enabled = False
        ElseIf permission_search.ForeColor = Color.White Then
            permission_btn_search.Visible = True
        End If
    End Sub

 

    Private Sub admin_username_Click(sender As Object, e As EventArgs) Handles admin_username.Click

        MaterialLabel1.Dispose()
        MaterialLabel2.Dispose()
        MaterialLabel3.Dispose()
        MaterialLabel4.Dispose()
        permission_search.Dispose()
        permission_username.Dispose()
        permission_password.Dispose()
        permission_role.Dispose()
        permission_add.Dispose()
        permission_edit.Dispose()
        permission_delete.Dispose()
        admin_username.Dispose()
        Me.Width = 240
        Me.Height = 240
        edit_username.Visible = True
        edit_username.Width = 190
        edit_username.Height = 30
        edit_username.Left = (Me.Width / 2) - (edit_username.Width / 2)
        edit_username.Top = (Me.Height / 6 * 3) - (edit_username.Height / 2)

        edit_password.Visible = True
        edit_password.Width = edit_username.Width
        edit_password.Height = edit_username.Height
        edit_password.Left = (Me.Width / 2) - (edit_password.Width / 2)
        edit_password.Top = (Me.Height / 6 * 4) - (edit_password.Height / 2)

        choice_back.Visible = True
        choice_back.Width = 100
        choice_back.Height = 40
        choice_back.Left = (Me.Width / 2) - (choice_back.Width / 2)
        choice_back.Top = (Me.Height / 6 * 5) - (choice_back.Height / 2)
    End Sub

    
    Private Sub permission_search_TextChanged(sender As Object, e As EventArgs) Handles permission_search.TextChanged
        permission_username.Enabled = False
        permission_password.Enabled = False
        permission_role.Enabled = False
        If permission_search.ForeColor = Color.Gray Then
            permission_btn_search.Visible = False

        End If
        If permission_search.ForeColor = Color.White Then
            permission_btn_search.Visible = True
        End If
    End Sub

    Private Sub edit_username_Click(sender As Object, e As EventArgs) Handles edit_username.Click
        Dim edit_username As New Control
        Dim edit_password As New Control
        Dim edit_selection As New List(Of Control)
        Me.Width = 300
        Me.Height = 270
        usernamelabel.Visible = True
        usernamelabel.Left = (Me.Width / 2) - (usernamelabel.Width / 2)
       
        choice_back.Left = (Me.Width / 2) - (choice_back.Width / 2)
        choice_back.Top = (Me.Height / 6 * 5) - (choice_back.Height / 2)
    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles chg_uname_field.Click

    End Sub


    Private Sub permission_btn_search_Click(sender As Object, e As EventArgs) Handles permission_btn_search.Click
        permission_username.Enabled = True
        permission_password.Enabled = True
        permission_role.Enabled = True
    End Sub
End Class