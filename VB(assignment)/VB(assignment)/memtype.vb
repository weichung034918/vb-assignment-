﻿Imports MaterialSkin

Public Class memtype
    Partial Class memtype
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub memtype_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mainpage.Enabled = True
    End Sub
    Private Sub memtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.DeepPurple700, Accent.Cyan400, TextShade.WHITE)
        Label12.Text = "No voting and equity Rights" & Environment.NewLine & "No reciprocal  / affiliated Club privileges" & Environment.NewLine & "No Weekend bookings available"
        mainpage.Enabled = False
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click

    End Sub
End Class