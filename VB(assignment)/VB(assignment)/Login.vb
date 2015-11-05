Imports MaterialSkin
Imports System.Data.OleDb
Public Class login

    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim sql As String

    Partial Class login
        Inherits MaterialSkin.Controls.MaterialForm

    End Class

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.DeepPurple700, Accent.Cyan400, TextShade.WHITE)
        field_pwd.PasswordChar = "•"
        login_design()
        Try
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" &
                    "Data Source=" & dirdb)
            con.Open()
        Catch
            Try
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dirdb2)
                con.Open()
            Catch
                Try
                    con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + dirdb2)
                    con.Open()
                Catch
                    Try
                        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + dirdb2)
                        con.Open()
                    Catch ex As Exception
                        MessageBox.Show("Cannot connect to database!", "Database Error")
                    End Try
                End Try
            End Try
        End Try 'a simple misusage of try...catch as exception, but very fun to use and easy to use lol
        

    End Sub


    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim uname As String = field_username.Text
        Dim pwd As String = field_pwd.Text

        sql = "select Username, Password, Permission from Admin where Username='" + uname + "' and Password='" + pwd + "'"
        da = New OleDbDataAdapter(sql, con)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then 'this is one of the simple ways to detect the presence of the account, curi ayam style
            Dim per As String = dt.Rows(0).Item(2)
            Dim name As String = dt.Rows(0).Item(0)
            MessageBox.Show("You're logged as: " + name + Environment.NewLine + "Permission      : " + per, "Login Successful")
        Else
            MessageBox.Show("Username or password not match.", "Login Failed")
            field_username.Text = Nothing
            field_pwd.Text = Nothing
            Return
        End If

        con.Close()

        mainpage.label_uname.Text = dt.Rows(0).Item(0)
        mainpage.Show()
        Me.Close()
    End Sub

    Public Sub login_design()
        MyBase.Height = 280
        MyBase.Width = 260
      
        login_btn.Left = (Me.Width / 2) - (login_btn.Width / 2)
        field_username.Left = (Me.Width / 2) - (field_username.Width / 2)
        field_pwd.Left = (Me.Width / 2) - (field_pwd.Width / 2)
        login_btn.Top = (field_pwd.Top + 30)
        login_btn.Left = (Me.Width / 2) - (login_btn.Width / 2)
        MaterialLabel1.Left = field_username.Left
        MaterialLabel2.Left = field_pwd.Left
    End Sub
End Class

