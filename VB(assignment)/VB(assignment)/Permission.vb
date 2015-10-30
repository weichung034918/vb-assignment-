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

   
    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub
    Private Sub permission_format()
        Me.Width = 520
        Me.Height = 330
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
    End Sub
End Class