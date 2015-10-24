Imports MaterialSkin
Imports System.IO 'for file.exists
Imports ADOX 'for creating database
Imports System.Data.OleDb

Public Class Initialise
    Dim cat As Catalog = New Catalog()
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"

    Private Sub new_element()
        mdb_btn.Dispose()
        accdb_btn.Dispose()

        MyBase.Height = 350
        MaterialLabel1.Text = "Please create a new " & vbNewLine & "administrator account."

        Dim label_uname, label_pwd, label_conpwd As New MaterialSkin.Controls.MaterialLabel
        label_uname.Location = New Point(13, 130)
        label_uname.Visible = True
        MaterialLabel1.AutoSize = True
        label_uname.Text = "test"
        Me.Controls.Add(label_uname)


        Dim field_uname, field_pwd, field_conpwd As New MaterialSkin.Controls.MaterialSingleLineTextField


    End Sub

    Partial Class Initialise
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub Initialise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)

        'btn_appearance() ' :)

        'If File.Exists(dirdb) Or File.Exists(dirdb2) Then
        '    login.Show()
        '    Me.Close()
        'Else
        '    MessageBox.Show("Please select a suitable access database file extension type.", "Database is not detected")
        '    MaterialLabel1.Text = "Select from the following:"
        'End If

        new_element() 'debug purpose for the initial create account new_element. I will remove it by myself.

    End Sub

    Private Sub btn_appearance() 'override buttons' appearances in the form of size and position
        mdb_btn.Width = 200
        accdb_btn.Width = 200
        mdb_btn.Height = 30
        accdb_btn.Height = 30
        mdb_btn.Left = (Me.Width / 2) - (mdb_btn.Width / 2)
        accdb_btn.Left = (Me.Width / 2) - (accdb_btn.Width / 2)
    End Sub

    Private Sub mdb_btn_Click(sender As Object, e As EventArgs) Handles mdb_btn.Click
        cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" &
                    "Data Source=" & dirdb &
                    ";Jet OLEDB:Engine Type=5")
        cat = Nothing

        MessageBox.Show("Database has been successfully created. " +
                        "This type of database is compatible with Microsoft Access 2002 and above.", "Successful!")
        new_element()

    End Sub

    Private Sub accdb_btn_Click(sender As Object, e As EventArgs) Handles accdb_btn.Click
        Try
            cat.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirdb2)
        Catch
            Try
                cat.Create("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + dirdb2)
            Catch
                cat.Create("Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + dirdb2)
            End Try
        End Try

        cat = Nothing

        MessageBox.Show("Database has been successfully created. " +
                        "This type of database is compatible with Microsoft Access 2007 and above.", "Successful!")
        new_element()
    End Sub


End Class