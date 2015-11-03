Imports MaterialSkin
Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class popup
    Dim dt As New DataTable
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

        btn_del.Left = Me.Width / 2 - btn_del.Width / 2
        btn_edit.Left = btn_del.Left
        btn_del.Top = txt_con_urpwd.Top + 30
        btn_edit.Top = btn_del.Top
        Me.TopMost = True
        txt_con_urpwd.PasswordChar = "•"
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_con_urpwd.Text <> dt.Rows(0).Item(1) Then
            MsgBox("lol")
        End If
    End Sub
End Class