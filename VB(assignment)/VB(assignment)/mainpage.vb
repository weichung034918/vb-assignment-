Imports MaterialSkin

Public Class mainpage


    Partial Class mainpage
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub mainpage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lg As login = New login
        lg.Show()
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance
        skinmanager.AddFormToManage(Me)
        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepPurple100, TextShade.WHITE)


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
        MsgBox("Member Added!")
    End Sub



    Private Sub txt_payment_edit_submit_Click(sender As Object, e As EventArgs) Handles txt_payment_edit_submit.Click
        MsgBox("are you sure?", vbYesNo)
        If vbYes Then

        ElseIf vbNo Then

        End If
    End Sub

    Private Sub combobox_remove_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_remove_search.SelectedIndexChanged
        label_remove_search.Text = combobox_remove_search.Text & ":"
    End Sub



    Private Sub label_update_search_Click(sender As Object, e As EventArgs) Handles label_update_search.Click

    End Sub

    Private Sub combobox_update_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_update_search.SelectedIndexChanged
        label_update_search.Text = combobox_update_search.Text & ":"
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

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

    
   
   
End Class












