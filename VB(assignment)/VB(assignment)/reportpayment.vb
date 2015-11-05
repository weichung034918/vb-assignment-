Imports MaterialSkin
Imports System.Data.OleDb

Public Class reportpayment
    Partial Class reportpayment
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub reportpayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mainpage.Enabled = True
    End Sub
    Private Sub reportpayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'databaseDataSet1.Payment' table. You can move, or remove it, as needed.
        mainpage.Enabled = False
        Me.PaymentTableAdapter.Fill(Me.databaseDataSet1.Payment)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.DeepPurple700, Accent.Cyan400, TextShade.WHITE)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class