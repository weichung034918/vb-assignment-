Imports MaterialSkin
Imports ADOX
Imports System.Data.OleDb
Public Class login
    Partial Class login
        Inherits MaterialSkin.Controls.MaterialForm
      
    End Class


    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'just hide this form when login complete, if forcefully quit it will also quit the main program

        Connect.Dispose()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)
        If My.Computer.FileSystem.FileExists("database.mdb") = False Then
            Dim cat As Catalog = New Catalog()
            Dim dirdb As String = "database.mdb"

            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" &
                        "Data Source=" & dirdb &
                        ";Jet OLEDB:Engine Type=5")
            MsgBox("A database has been created!")
            cat = Nothing
        End If
    End Sub


    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

        Me.Hide()
        mainpage.Show()
    End Sub
End Class
