Imports MaterialSkin
Imports System.Data.OleDb
Public Class login

    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim ds As New DataSet
    Dim con As New OleDbConnection
    Dim totrec As Integer
    Dim currec As Integer
    Dim cmd As New OleDbCommand
    Dim sql As String

    Partial Class login
        Inherits MaterialSkin.Controls.MaterialForm

    End Class

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepOrange700, TextShade.WHITE)

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

        sql = "select Username, Password from Admin where Username='" + uname + "' and Password='" + pwd + "'"
        da = New OleDbDataAdapter(sql, con)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Login successful")
        Else
            MessageBox.Show("Invalid user")
            Return
        End If

        mainpage.Show()
        Me.Close()
    End Sub


End Class
