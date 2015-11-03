Imports MaterialSkin
Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class Permission
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim cmd As New OleDbCommand
    Dim sql As String
    Dim currec As Integer
    Dim totrec As Integer

    Partial Class Permission
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub Permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance
        skinmanager.AddFormToManage(Me)
        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepPurple100, TextShade.WHITE)
        txt_uname.Width = 150
        txt_pwd.Width = 150
        txt_conpwd.Width = 150
        ComboBox_per.Width = 150
        btn_add.Left = (Me.Width / 2) - (btn_add.Width / 2)
        btn_add.Top = ComboBox_per.Top + 60
        
        btn_edit.Size = New Size(85, 50)
        btn_del.Size = btn_edit.Size
        btn_edit.Top = label_edel_per.Top + 30
        btn_edit.Left = Me.Width / 2 - (btn_edit.Width / 2)
        btn_del.Top = btn_edit.Top
        btn_del.Left = btn_edit.Left
        btn_myset_update.Left = Me.Width / 2 - btn_myset_update.Width / 2
        txt_pwd.PasswordChar = "•"
        txt_conpwd.PasswordChar = "•"

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
                        MessageBox.Show(ex.Message, "Database Error")
                        Return
                    End Try
                End Try
            End Try
        End Try

        sql = "select Username, Permission from Admin"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "UserSet")
        currec = 0
        usertext()

    End Sub

    Private Sub txt_myset_TextChanged(sender As Object, e As EventArgs) Handles txt_myset_uname.TextChanged, txt_myset_pwd.TextChanged, txt_myset_conpwd.TextChanged
        If txt_myset_uname.TextLength > 0 AndAlso txt_myset_pwd.TextLength > 0 AndAlso txt_myset_conpwd.TextLength > 0 Then
            btn_myset_update.Visible = True
        Else
            btn_myset_update.Visible = False
        End If
    End Sub
    '================================add user starts====================================
    Private Sub txt_uname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_uname.KeyPress
        If Not txt_uname.TextLength > 0 And e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_uname_Leave(sender As Object, e As EventArgs) Handles txt_uname.Leave
        Dim str As String = txt_uname.Text
        txt_uname.Text = Regex.Replace(str, " {2,}", " ")
    End Sub

    Private Sub txt_pwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pwd.KeyPress
        If e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_pwd_Leave(sender As Object, e As EventArgs) Handles txt_pwd.Leave
        If txt_pwd.TextLength = 0 Then
            Return
        End If
        If txt_pwd.TextLength < 6 Then
            MessageBox.Show(" must >6!", "Pwd")
            txt_pwd.Text = Nothing
            Return
        End If
    End Sub

    Private Sub txt_conpwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_conpwd.KeyPress
        If e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_conpwd_Leave(sender As Object, e As EventArgs) Handles txt_conpwd.Leave
        If txt_conpwd.TextLength = 0 Then
            Return
        End If
        If txt_conpwd.TextLength < 6 Then
            MessageBox.Show(" must >6!", "Pwd")
            txt_conpwd.Text = Nothing
            Return
        End If
    End Sub

    Private Sub newevent(sender As Object, e As EventArgs) Handles txt_uname.TextChanged, txt_pwd.TextChanged, txt_conpwd.TextChanged, ComboBox_per.SelectedIndexChanged
        If txt_uname.TextLength > 0 AndAlso txt_pwd.TextLength > 0 AndAlso txt_conpwd.TextLength > 0 AndAlso ComboBox_per.SelectedIndex >= 0 Then
            btn_add.Visible = True
        Else
            btn_add.Visible = False
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_pwd.Text <> txt_conpwd.Text Then
            MessageBox.Show("Password not match, re-enter again.", "Password")
            txt_pwd.Text = Nothing
            txt_conpwd.Text = Nothing
            Return
        End If
        For i = 0 To ds.Tables("UserSet").Rows.Count - 1
            If txt_uname.Text = ds.Tables("UserSet").Rows(i).Item(0) Then
                MessageBox.Show("Username exists. Please enter a new username.", "")
            End If
        Next
        sql = "insert into Admin values ('" & txt_uname.Text & "', '" & txt_pwd.Text & "', '" &
            ComboBox_per.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            MessageBox.Show(sql, "Debug purpose")
            cmd.ExecuteNonQuery()
            MsgBox("User Added!")
            txt_uname.Clear()
            txt_pwd.Clear()
            txt_conpwd.Clear()
            ds.Tables("UserSet").Clear()
            da.Fill(ds, "UserSet")
            txt_edel_uname.Text = ds.Tables("UserSet").Rows(0).Item(0) 'ignoring first row, as it must not be deleted (initial admin)
            Dim pertype As String = ds.Tables("UserSet").Rows(0).Item(1) 'ignoring first row
            If pertype = "Admin" Then
                ComboBox_edel_per.SelectedIndex = 0
            ElseIf pertype = "Staff" Then
                ComboBox_edel_per.SelectedIndex = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Return
        End Try
    End Sub
    '=====================================add user ends============================================

    '===================================edit/del user starts=======================================

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        If currec <> 0 Then
            currec -= 1
            usertext()
        End If
    End Sub
    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If currec <> ds.Tables("UserSet").Rows.Count - 1 Then
            currec += 1
            usertext()
        End If
    End Sub

    Public Sub usertext()

        txt_edel_uname.Text = ds.Tables("UserSet").Rows(currec).Item(0) 'ignoring first row, as it must not be deleted (initial admin)
        Dim pertype As String = ds.Tables("UserSet").Rows(currec).Item(1) 'ignoring first row
        If pertype = "Admin" Then
            ComboBox_edel_per.SelectedIndex = 0
        ElseIf pertype = "Staff" Then
            ComboBox_edel_per.SelectedIndex = 1
        End If
    End Sub

    Private Sub ComboBox_modeselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_modeselect.SelectedIndexChanged
        If ComboBox_modeselect.SelectedIndex = 0 Then
            btn_edit.Visible = True
            btn_del.Visible = False
            label_edel_per.Visible = True
            label_edel_uname.Visible = True
            label_edel_pwd.Visible = True
            label_edel_conpwd.Visible = True
            txt_edel_uname.Visible = True
            txt_edel_pwd.Visible = True
            txt_edel_conpwd.Visible = True
            ComboBox_edel_per.Visible = True
            btn_next.Visible = True
            btn_prev.Visible = True
            label_edel_per.Top = label_edel_conpwd.Top + 40
            ComboBox_edel_per.Top = label_edel_per.Top
        ElseIf ComboBox_modeselect.SelectedIndex = 1 Then
            label_edel_per.Visible = True
            label_edel_uname.Visible = True
            txt_edel_uname.Visible = True
            ComboBox_edel_per.Visible = True
            btn_next.Visible = True
            btn_prev.Visible = True
            btn_edit.Visible = False
            btn_del.Visible = True
            label_edel_pwd.Visible = False
            label_edel_conpwd.Visible = False
            txt_edel_conpwd.Visible = False
            txt_edel_pwd.Visible = False
            label_edel_per.Top = label_edel_uname.Top + 50
            ComboBox_edel_per.Top = label_edel_per.Top

        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_edel_conpwd.TextLength > 5 AndAlso txt_edel_pwd.TextLength > 5 AndAlso txt_edel_uname.TextLength > 5 Then

            sql = "UPDATE Admin SET Password='" & txt_edel_pwd.Text & "', Permission='"
            If ComboBox_edel_per.SelectedIndex = 0 Then
                sql = sql & ComboBox_edel_per.Items(0).ToString & "' where Username='" & txt_edel_uname.Text & "'"
            ElseIf ComboBox_edel_per.SelectedIndex = 1 Then
                sql = sql & ComboBox_edel_per.Items(1).ToString & "' where  Username='" & txt_edel_uname.Text & "'"
            End If
        Else

        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        sql = "delete * from Admin where Username='" & txt_edel_uname.Text & "'"
        If txt_edel_uname.Text = mainpage.label_uname.Text Then
            MessageBox.Show("You cannot delete your own account!", "Error")
            Return
        End If
        cmd = New OleDbCommand(sql, con)
        Try
            MessageBox.Show(sql, "Debug purpose")
            cmd.ExecuteNonQuery()
            MsgBox("Removed!")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Return
        End Try

        txt_edel_uname.Clear()
        txt_edel_conpwd.Clear()
        txt_edel_pwd.Clear()
        ds.Tables("UserSet").Clear()
        da.Fill(ds, "UserSet")
        txt_edel_uname.Text = ds.Tables("UserSet").Rows(0).Item(0) 'ignoring first row, as it must not be deleted (initial admin)
        Dim pertype As String = ds.Tables("UserSet").Rows(0).Item(1) 'ignoring first row
        If pertype = "Admin" Then
            ComboBox_edel_per.SelectedIndex = 0
        ElseIf pertype = "Staff" Then
            ComboBox_edel_per.SelectedIndex = 1
        End If
    End Sub
End Class
