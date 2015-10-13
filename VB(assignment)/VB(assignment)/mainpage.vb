Imports MaterialSkin

Public Class mainpage
    Partial Class mainpage
        Inherits MaterialSkin.Controls.MaterialForm
    End Class
    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lg As login = New login
        lg.Show()
        Me.Hide()


        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance
        skinmanager.AddFormToManage(Me)
        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)



    End Sub

End Class