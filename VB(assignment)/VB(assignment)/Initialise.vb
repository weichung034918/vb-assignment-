Imports MaterialSkin
Imports System.IO 'for file.exists
Imports ADOX 'for creating database
Imports System.Data.OleDb

Public Class Initialise
    Dim cat As Catalog = New Catalog()
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDbCommand
    Dim sql As String


    

    Partial Class Initialise
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub Initialise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)

        MaterialLabel1.ForeColor = Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(251, 264)
        label_uname.Visible = False
        label_pwd.Visible = False
        label_conpwd.Visible = False
        field_uname.Visible = False
        field_pwd.Visible = False
        field_conpwd.Visible = False
        btn_appearance() ' :)

        If File.Exists(dirdb) Or File.Exists(dirdb2) Then
            login.Show()
            Me.Close()
        Else
            MessageBox.Show("Please select a suitable access database file extension type.", "Database is not detected")
            MaterialLabel1.Text = "Select from the following:"
        End If

        'add_element() 'debug purpose for the initial create account new_element. I will remove it by myself.

    End Sub

    Private Sub mdb_btn_Click(sender As Object, e As EventArgs) Handles mdb_btn.Click
        cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" &
                    "Data Source=" & dirdb &
                    ";Jet OLEDB:Engine Type=5")
        cat = Nothing

        MessageBox.Show("Database has been successfully created. " +
                        "This type of database is compatible with Microsoft Access 2002 and above.", "Successful!")

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" &
                    "Data Source=" & dirdb)
        Try
            con.Open()
            MessageBox.Show("Database is connected.", "Database")
        Catch ex As Exception
            MessageBox.Show("Cannot connect to database!", "Database Error")
        End Try

        Call create_table()

        con.Close()

        add_element()

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

        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirdb2)
            con.Open()
            MessageBox.Show("Database is connected.", "Database")
        Catch
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + dirdb2)
                con.Open()
                MessageBox.Show("Database is connected.", "Database")
            Catch
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + dirdb2)
                    con.Open()
                    MessageBox.Show("Database is connected.", "Database")
                Catch ex As Exception
                    MessageBox.Show("Cannot connect to database!", "Database Error")
                End Try
            End Try
        End Try

        Call create_table()

        con.Close()

        add_element()
    End Sub
    Public Sub create_table()
        cmd = New OleDbCommand("CREATE TABLE [Admin] ([Username] TEXT PRIMARY KEY, [Password] MEMO, [Permission] TEXT)", con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cmd = New OleDbCommand("CREATE TABLE [Members] ([MID] TEXT(10) PRIMARY KEY, [First_Name] MEMO, [Last_Name] MEMO, " +
                                "[Contact_Number] INT, [Email] TEXT(30), [Status] TEXT(30))", con)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cmd = New OleDbCommand("CREATE TABLE [Membership] ([MID] TEXT(10), [MSHIP_ID] TEXT(10) PRIMARY KEY, [Member_Type] MEMO, " +
                              "[Reg_Fee] DECIMAL(10,2), [Monthly_Fee] DECIMAL(10,2), " +
                              "CONSTRAINT FKMembershipMID FOREIGN KEY (MID) REFERENCES Members(MID) ON UPDATE CASCADE ON DELETE CASCADE)", con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        cmd = New OleDbCommand("CREATE TABLE [Payment] ([PID] INT PRIMARY KEY, " +
                               "[MID] TEXT(10), CONSTRAINT FKPaymentMID FOREIGN KEY (MID) REFERENCES Members(MID) ON UPDATE CASCADE ON DELETE CASCADE, " +
                               "[MSHIP_ID] TEXT(10), CONSTRAINT FKPaymentMSHIP_ID FOREIGN KEY (MSHIP_ID) REFERENCES Membership(MSHIP_ID) ON UPDATE CASCADE ON DELETE CASCADE, " +
                               "[Date_of_Entry] TEXT, [Logged_by] TEXT, [DESC] MEMO, [Amount_Due] DECIMAL(10,2), [Payment_Date] TEXT)", con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click

        If field_uname.Text = Nothing Or field_uname.TextLength < 6 Then
            MessageBox.Show("Please enter a username not less than 6 characters.", "Username")
            field_uname.Text = Nothing
            field_pwd.Text = Nothing
            field_conpwd.Text = Nothing
            Return
        End If

        If field_pwd.TextLength < 6 And field_conpwd.TextLength < 6 Then
            MessageBox.Show("Password must be at least 6 characters", "Password")
            field_pwd.Text = Nothing
            field_conpwd.Text = Nothing
            Return
        End If

        If field_pwd.Text <> field_conpwd.Text Then
            MessageBox.Show("Password not match! Please try again.", "Password")
            field_pwd.Text = Nothing
            field_conpwd.Text = Nothing
            Return
        End If

        con.Open()
        sql = "insert into Admin values ('" & field_uname.Text & "', '" & field_pwd.Text & "', 'Admin')"
        MessageBox.Show("You are inserting [" & sql & "] into the database", "Debug purpose") 'for debug purpose, will delete
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Administrator account has been created.", "Successful")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        con.Close()

        login.Show()
        Me.Close()

    End Sub

    Private Sub field_KeyPress(sender As Object, e As KeyPressEventArgs) Handles field_uname.KeyPress,
        field_pwd.KeyPress, field_conpwd.KeyPress 'lock the goddamn spacebar
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_appearance() 'override buttons' appearances in the form of size and position
        mdb_btn.Width = 200
        accdb_btn.Width = 200
        mdb_btn.Height = 30
        accdb_btn.Height = 30
        mdb_btn.Left = (Me.Width / 2) - (mdb_btn.Width / 2)
        accdb_btn.Left = (Me.Width / 2) - (accdb_btn.Width / 2)
    End Sub

    Public Sub add_element() 'positioning and sizing elements on the right in design view
        mdb_btn.Dispose()
        accdb_btn.Dispose()

        MyBase.Height = 370
        MyBase.Width = 251

        MaterialLabel1.Text = "Please create a new " & vbNewLine & "administrator account."

        label_uname.Location = New Point(13, 130)
        label_uname.Visible = True
        label_uname.AutoSize = True

        label_pwd.Location = New Point(13, 190)
        label_pwd.Visible = True
        label_pwd.AutoSize = True

        label_conpwd.Location = New Point(13, 250)
        label_conpwd.Visible = True
        label_conpwd.AutoSize = True

        field_uname.Width = 190
        field_uname.Height = 23
        Dim w As Integer = (Me.Width / 2) - (field_uname.Width / 2)
        field_uname.Location = New Point(w, 160)
        field_uname.Visible = True

        field_pwd.Width = field_uname.Width
        field_pwd.Height = field_uname.Height
        field_pwd.Location = New Point(w, 220)
        field_pwd.Visible = True
        field_pwd.PasswordChar = "•"

        field_conpwd.Width = field_uname.Width
        field_conpwd.Height = field_uname.Height
        field_conpwd.Location = New Point(w, 280)
        field_conpwd.Visible = True
        field_conpwd.PasswordChar = "•"

        next_btn.Width = accdb_btn.Width / 2
        next_btn.Height = accdb_btn.Height
        next_btn.Location = New Point((Me.Width / 2) - (next_btn.Width / 2), 320)
        next_btn.Visible = True

    End Sub
End Class