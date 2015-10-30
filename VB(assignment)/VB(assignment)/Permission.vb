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
    End Sub
End Class