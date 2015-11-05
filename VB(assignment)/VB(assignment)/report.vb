Imports MaterialSkin
Imports System.Data.OleDb

Public Class report
    Partial Class report
        Inherits MaterialSkin.Controls.MaterialForm
    End Class
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'databaseDataSet.Members' table. You can move, or remove it, as needed.
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.DeepPurple700, Accent.Cyan400, TextShade.WHITE)
        Dim con As New OleDbConnection
        Dim dirdb As String = Application.StartupPath + "\database.mdb"
        Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
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
                    End Try
                End Try
            End Try
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Shared Function membershipTableAdapter() As Object
        Throw New NotImplementedException
    End Function

    Public Shared Sub filter(ind As Integer, value As String)
        
    End Sub
End Class