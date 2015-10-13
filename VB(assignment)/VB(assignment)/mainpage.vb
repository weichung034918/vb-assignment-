Imports MaterialSkin
Public Class mainpage
    Partial Class mainpage
        Inherits MaterialSkin.Controls.MaterialForm


        Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
            SkinManager.AddFormToManage(Me)
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700,
                                                      Accent.DeepOrange700, TextShade.WHITE)
            Me.Visible = False
        End Sub
    End Class
End Class