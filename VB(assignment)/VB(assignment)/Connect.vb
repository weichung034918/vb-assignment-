Imports MaterialSkin
Imports ADOX
Imports System.Data.OleDb
Public Class Connect

    Partial Class Connect
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub Connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If My.Computer.FileSystem.FileExists("database.mdb") = True Then
            login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles testbutton.Click
        
    End Sub
End Class