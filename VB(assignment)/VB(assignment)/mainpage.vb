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

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_remove_search.Click
        btn_remove.Visible = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        MsgBox("are you sure?", vbYesNo)
    End Sub

    Private Sub btn_update_search_Click(sender As Object, e As EventArgs) Handles btn_update_search.Click
        btn_update.Visible = True
    End Sub

    Private Sub txt_payment_delete_submit_Click(sender As Object, e As EventArgs) Handles txt_payment_delete_submit.Click
        MsgBox("are you sure?", vbYesNo)
    End Sub

    Private Sub txt_payment_submit_Click(sender As Object, e As EventArgs) Handles txt_payment_submit.Click
        MsgBox("Form Submitted")
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        MsgBox("Member Added!")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub combobox_remove_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_remove_membertype.SelectedIndexChanged

    End Sub
End Class









