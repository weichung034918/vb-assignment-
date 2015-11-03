Imports MaterialSkin

Public Class Permission
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
        label_edel_uname.Top = MaterialLabel1.Top + 40
        label_edel_per.Top = label_edel_uname.Top + 50
        txt_edel_uname.Top = label_edel_uname.Top
        txt_edel_uname.Width = txt_uname.Width
        ComboBox_edel_per.Top = label_edel_per.Top
        ComboBox_edel_per.Width = txt_edel_uname.Width
        btn_edit.Size = New Size(85, 50)
        btn_del.Size = btn_edit.Size
        btn_edit.Top = label_edel_per.Top + 50
        btn_edit.Left = Me.Width / 2 - (btn_edit.Width + 20)
        btn_del.Top = btn_edit.Top
        btn_del.Left = Me.Width / 2 + 20
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        popup.Show()
        popup.btn_del.Visible = True
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        popup.Show()
        popup.btn_edit.Visible = True
    End Sub
End Class