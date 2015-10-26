﻿Imports MaterialSkin
Imports System.Data.OleDb

Public Class mainpage
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim sql As String

    Partial Class mainpage
        Inherits MaterialSkin.Controls.MaterialForm

    End Class

    

    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance
        skinmanager.AddFormToManage(Me)
        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepPurple100, TextShade.WHITE)
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
        End Try

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        MsgBox("are you sure?", vbYesNo)
        If vbYes Then

        ElseIf vbNo Then

        End If

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_remove_search.Click
        btn_remove.Visible = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        MsgBox("are you sure?", vbYesNo)
        If vbYes Then

        ElseIf vbNo Then

        End If
    End Sub

    Private Sub btn_update_search_Click(sender As Object, e As EventArgs) Handles btn_update_search.Click
        btn_update.Visible = True

    End Sub

    Private Sub txt_payment_delete_submit_Click(sender As Object, e As EventArgs) Handles txt_payment_delete_submit.Click
        MsgBox("are you sure?", vbYesNo)
        If vbYes Then

        ElseIf vbNo Then

        End If
    End Sub

    Private Sub txt_payment_submit_Click(sender As Object, e As EventArgs) Handles txt_payment_submit.Click
        MsgBox("Form Submitted")
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If String.IsNullOrEmpty(txt_add_id.Text) Then
            MsgBox("Please enter member ID")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_firstname.Text) Then
            MsgBox("Please enter first name")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_lastname.Text) Then
            MsgBox("Please enter last name")
            Return
        ElseIf String.IsNullOrEmpty(combobox_add_membertype.Text) Then
            MsgBox("Please select member type")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_shipid.Text) Then
            MsgBox("Please insert Membership ID ")
            Return
        End If


            'INSERT FUNCTION TO ADD HERE
            MsgBox("Member Added!")
    End Sub



    Private Sub txt_payment_edit_submit_Click(sender As Object, e As EventArgs) Handles txt_payment_edit_submit.Click
        MsgBox("are you sure?", vbYesNo)
        If vbYes Then

        ElseIf vbNo Then

        End If
    End Sub

    Private Sub combobox_remove_search_textChanged(sender As Object, e As EventArgs) Handles combobox_remove_search.SelectedIndexChanged
        'DESIGN START
        If combobox_remove_search.Text <> String.Empty Then
            txt_remove_search.Enabled = True
            label_remove_search.Enabled = True
            label_remove_search.Text = combobox_remove_search.Text & ":"
        Else
            txt_remove_search.Enabled = False

        End If
        'DESIGN END
    End Sub



    Private Sub label_update_search_Click(sender As Object, e As EventArgs) Handles label_update_search.Click

    End Sub

    Private Sub combobox_update_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_update_search.SelectedIndexChanged
        label_update_search.Text = combobox_update_search.Text & ":"
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub combobox_add_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_add_membertype.SelectedIndexChanged
        If combobox_add_membertype.Text = "Deluxe" Then
            label_add_shipid.Text = "D"
            Else If combobox_add_membertype.Text = "Non-Deluxe" then
            label_add_shipid.Text = "ND"
        ElseIf combobox_add_membertype.Text = "Weekday" Then
            label_add_shipid.Text = "WD"
        End If

    End Sub

    Private Sub combobox_remove_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_remove_membertype.SelectedIndexChanged
        If combobox_remove_membertype.Text = "Deluxe" Then
            label_remove_shipid.Text = "D"
        ElseIf combobox_remove_membertype.Text = "Non-Deluxe" Then
            label_remove_shipid.Text = "ND"
        ElseIf combobox_remove_membertype.Text = "Weekday" Then
            label_remove_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_update_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_update_membertype.SelectedIndexChanged
        If combobox_update_membertype.Text = "Deluxe" Then
            label_update_shipid.Text = "D"
        ElseIf combobox_update_membertype.Text = "Non-Deluxe" Then
            label_update_shipid.Text = "ND"
        ElseIf combobox_update_membertype.Text = "Weekday" Then
            label_update_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_payment_submit_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_payment_submit_membertype.SelectedIndexChanged
        If combobox_payment_submit_membertype.Text = "Deluxe" Then
            label_payment_submit_shipid.Text = "D"
        ElseIf combobox_payment_submit_membertype.Text = "Non-Deluxe" Then
            label_payment_submit_shipid.Text = "ND"
        ElseIf combobox_payment_submit_membertype.Text = "Weekday" Then
            label_payment_submit_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_payment_edit_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_payment_edit_membertype.SelectedIndexChanged
        If combobox_payment_edit_membertype.Text = "Deluxe" Then
            label_payment_edit_shipid.Text = "D"
        ElseIf combobox_payment_edit_membertype.Text = "Non-Deluxe" Then
            label_payment_edit_shipid.Text = "ND"
        ElseIf combobox_payment_edit_membertype.Text = "Weekday" Then
            label_payment_edit_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_payment_delete_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_payment_delete_membertype.SelectedIndexChanged
        If combobox_payment_delete_membertype.Text = "Deluxe" Then
            label_payment_delete_shipid.Text = "D"
        ElseIf combobox_payment_delete_membertype.Text = "Non-Deluxe" Then
            label_payment_delete_shipid.Text = "ND"
        ElseIf combobox_payment_delete_membertype.Text = "Weekday" Then
            label_payment_delete_shipid.Text = "WD"
        End If
    End Sub

    
   

    Private Sub txt_remove_search_TextChanged(sender As Object, e As EventArgs)

        If String.IsNullOrEmpty(txt_remove_search.Text) Then
            btn_remove_search.Visible = False
        ElseIf txt_remove_search.Text <> String.Empty Then
            btn_remove_search.Visible = True

        End If
    End Sub

    Private Sub txt_add_lastname_Click(sender As Object, e As EventArgs) Handles txt_add_lastname.Click

    End Sub

    Private Sub txt_remove_id_Click(sender As Object, e As EventArgs) Handles txt_remove_id.Click

    End Sub

    Private Sub txt_payment_edit_paymentid_Click(sender As Object, e As EventArgs) Handles txt_payment_edit_paymentid.Click

    End Sub

    Private Sub txt_add_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_id.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then 'lock the goddamn anything except controls and numbers
            e.Handled = True
        End If
            


    End Sub

    Private Sub txt_add_id_TextChanged(sender As Object, e As EventArgs) Handles txt_add_id.TextChanged
        If txt_add_id.TextLength > 10 Then
            MessageBox.Show("Member ID must be less than 10 numbers.", "Member ID")
        End If
        Dim strPaste As String = txt_add_id.Text
        For i = 0 To txt_add_id.TextLength - 1 'loop for checking each position (array position) of your string
            If Char.IsLetter(strPaste.Chars(i)) Then 'check if that thing you pasted contains letters or not
                txt_add_id.Text = Nothing
                MessageBox.Show("Member ID must only consist of numerical values.", "Member ID") 'goddamn looped x times if your string pasted length is x long, need fix
            End If
        Next
    End Sub

End Class















