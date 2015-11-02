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
        txt_uname.Width = 150
        txt_pwd.Width = 150
        txt_conpwd.Width = 150
        ComboBox_per.Width = 150
        btn_add.Left = (Me.Width / 2) - (btn_add.Width / 2)
        btn_add.Top = ComboBox_per.Top + 60
    End Sub

End Class