Imports MaterialSkin
Public Class Connect

    Partial Class Connect
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub Connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)


    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles testbutton.Click
        Dim mn As mainpage = New mainpage
        mn.Show()
        Me.Hide()
    End Sub
End Class