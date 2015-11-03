Imports MaterialSkin

Public Class popup
    Partial Class popup
        Inherits MaterialSkin.Controls.MaterialForm
    End Class



    Private Sub popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinmanager As MaterialSkin.MaterialSkinManager = MaterialSkinManager.Instance
        skinmanager.AddFormToManage(Me)
        skinmanager.Theme = MaterialSkinManager.Themes.LIGHT
        skinmanager.ColorScheme = New ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.DeepPurple700, Accent.DeepPurple100, TextShade.WHITE)
        label_urpwd.Left = Me.Width / 2 - label_urpwd.Width / 2
        txt_con_urpwd.Top = label_urpwd.Top + 25
        txt_con_urpwd.Left = Me.Width / 2 - txt_con_urpwd.Width / 2
        label_conpwd.Top = txt_con_urpwd.Top + 35
        txt_con_conpwd.Top = label_conpwd.Top + 25
        label_conpwd.Left = Me.Width / 2 - label_conpwd.Width / 2
        txt_con_conpwd.Left = Me.Width / 2 - txt_con_conpwd.Width / 2
        btn_del.Left = Me.Width / 2 - btn_del.Width / 2
        btn_edit.Left = btn_del.Left
        btn_del.Top = txt_con_conpwd.Top + 30
        btn_edit.Top = btn_del.Top
        Me.TopMost = True
    End Sub
End Class