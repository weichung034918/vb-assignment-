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
        permission_search.Left = (Me.Width / 2) - (permission_search.Width / 2)
        MaterialLabel1.Left = permission_search.Left - 70
        MaterialLabel1.Top = permission_search.Top
        permission_username.Left = (Me.Width / 3) - (permission_username.Width / 2)
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
    End Sub
End Class