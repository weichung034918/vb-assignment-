Imports MaterialSkin
Imports ADOX
Imports System.Data.OleDb
Public Class login
    Partial Class login
        Inherits MaterialSkin.Controls.MaterialForm
      
    End Class

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)
        
    End Sub


    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        mainpage.Show()
        Me.Close()
    End Sub
End Class
