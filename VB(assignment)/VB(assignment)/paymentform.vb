Imports MaterialSkin
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class paymentform
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable("memdetails")
    Dim dt2 As New DataTable("paydetails")
    Dim dt3 As New DataTable("tempfullpaydetails")
    Dim dt4 As New DataTable("fullpaydetails")
    Dim con As New OleDb.OleDbConnection
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim cmd As New OleDbCommand
    Dim sql As String
    Dim typestr As String

    Partial Class paymentform
        Inherits MaterialSkin.Controls.MaterialForm
    End Class

    Private Sub paymentform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mainpage.Enabled = True
    End Sub

    Private Sub paymentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainpage.Enabled = False
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.DeepPurple700, Accent.Cyan400, TextShade.WHITE)
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

        btn_edit.Location = btn_add.Location
        ds.Tables.Add(dt)
        ds.Tables.Add(dt2)
        ds.Tables.Add(dt3)
        If btn_add.Visible = True Then
            initialload()
            Return
        End If

        If btn_edit.Visible = True Then
            dt3.Clear()
            sql = "select PID, Amount_Paid, Amount_Due from Payment where PID='" & label_pid1.Text & label_pid2.Text & "'"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(dt3)
            Return
        End If

    End Sub

    Public Sub initialload()

        dt.Clear()
        sql = "select M.MID, M.Date_Of_Entry, Ms.MSHIP_ID, Ms.Reg_Fee, Ms.Monthly_Fee from Members M INNER JOIN " &
            "Membership Ms on M.MID=Ms.MID"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("There is no new member yet. Please add a new member", "No New Member")
            Return
        End If
        dt2.Clear()
        sql = "select PID from Payment"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt2)
        If dt2.Rows.Count = 0 Then
            label_pid2.Text = "1"
        ElseIf dt2.Rows.Count > 0 Then
            label_pid2.Text = dt2.Rows.Count + 1
        End If


        For i = 0 To 7
            If label_pid2.Text.Length < 8 Then
                label_pid2.Text = "0" & label_pid2.Text
            End If
        Next
        label_paydate.Text = mainpage.label_date.Text
        label_log.Text = mainpage.label_uname.Text
    End Sub
    Private Sub txt_mid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mid.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_mid_TextChanged(sender As Object, e As EventArgs) Handles txt_mid.TextChanged


        For i = 0 To dt.Rows.Count - 1
            If txt_mid.Text = dt.Rows(i).Item(0) Then
                label_mshipid.Text = dt.Rows(i).Item(2).ToString
                label_doe.Text = dt.Rows(i).Item(1).ToString
                Exit For
            Else
                label_mshipid.Text = Nothing
                label_doe.Text = Nothing
            End If
        Next

    End Sub

    Private Sub radio_mfee_CheckedChanged(sender As Object, e As EventArgs) Handles radio_mfee.CheckedChanged

        If radio_mfee.Checked Then
            typestr = "MF"
            label_due.Text = Nothing
            If dt2.Rows.Count <> 0 Then
                sql = "select * from Payment where MID='" & txt_mid.Text & "' and Payment_Type='" & typestr &
                "' order by Amount_Due"
                dt3.Clear()
                da = New OleDbDataAdapter(sql, con)
                da.Fill(dt3)
                If dt3.Rows.Count <> 0 Then
                    label_due.Text = Format((dt3.Rows(0).Item(8) - label_totalwgst.Text), "0.00")
                    Return
                End If
            End If

            For i = 0 To dt.Rows.Count - 1
                If txt_mid.Text = dt.Rows(i).Item(0) Then
                    'below condition is when user types in amount value adi then only select the radio button
                    If label_totalwgst.Text = "0.00" Then
                        label_due.Text = dt.Rows(i).Item(4).ToString
                    Else
                        label_due.Text = Format((dt.Rows(i).Item(4) - label_totalwgst.Text), "0.00") 'make the format to 2d.p.
                    End If
                    Exit For
                Else
                    label_due.Text = Nothing
                End If
            Next
        End If

    End Sub

    Private Sub radio_rfee_CheckedChanged(sender As Object, e As EventArgs) Handles radio_rfee.CheckedChanged

        If radio_rfee.Checked Then
            typestr = "RF"
            label_due.Text = Nothing

            If dt2.Rows.Count <> 0 Then
                sql = "select * from Payment where MID='" & txt_mid.Text & "' and Payment_Type='" & typestr &
                "' order by Amount_Due"
                dt3.Clear()
                da = New OleDbDataAdapter(sql, con)
                da.Fill(dt3)
                If dt3.Rows.Count <> 0 Then
                    label_due.Text = Format((dt3.Rows(0).Item(8) - label_totalwgst.Text), "0.00")
                    Return
                End If
            End If

            For i = 0 To dt.Rows.Count - 1
                If txt_mid.Text = dt.Rows(i).Item(0) Then
                    'below condition is when user types in amount value alrd then only select the radio button
                    If label_totalwgst.Text = "0.00" Then
                        label_due.Text = dt.Rows(i).Item(3).ToString
                    Else
                        label_due.Text = Format((dt.Rows(i).Item(3) - label_totalwgst.Text), "0.00")
                    End If
                    Exit For
                Else
                    label_due.Text = Nothing
                End If
            Next
        End If

    End Sub

    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress
        
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            If txt_amount.TextLength > 0 And e.KeyChar = ChrW(46) Then 'allow decimal dot
                e.Handled = False
            End If
            If txt_amount.Text.Contains(".") And e.KeyChar = ChrW(46) Then 'no more extra decimal dot
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amount.TextChanged
        If txt_amount.TextLength > 0 Then
            label_totalwgst.Text = Format((txt_amount.Text * (106 / 100)), "0.00")
        Else
            label_totalwgst.Text = "0.00"
            Return
        End If

        If btn_add.Visible = True Then

            'below is for real-time changing of due amount
            If radio_mfee.Checked Then
                label_due.Text = Nothing
                If dt2.Rows.Count <> 0 Then
                    sql = "select * from Payment where MID='" & txt_mid.Text & "' and Payment_Type='" & typestr &
                    "' order by Amount_Due"
                    dt3.Clear()
                    da = New OleDbDataAdapter(sql, con)
                    da.Fill(dt3)
                    If dt3.Rows.Count <> 0 Then
                        label_due.Text = Format((dt3.Rows(0).Item(8) - label_totalwgst.Text), "0.00")
                        Return
                    End If
                End If
                For i = 0 To dt.Rows.Count - 1
                    If txt_mid.Text = dt.Rows(i).Item(0) Then
                        label_due.Text = dt.Rows(i).Item(4) - label_totalwgst.Text
                        Exit For
                    Else
                        label_due.Text = Nothing
                    End If
                Next
            End If

            If radio_rfee.Checked Then

                label_due.Text = Nothing

                If dt2.Rows.Count <> 0 Then
                    sql = "select * from Payment where MID='" & txt_mid.Text & "' and Payment_Type='" & typestr &
                    "' order by Amount_Due"
                    dt3.Clear()
                    da = New OleDbDataAdapter(sql, con)
                    da.Fill(dt3)
                    If dt3.Rows.Count <> 0 Then
                        label_due.Text = Format((dt3.Rows(0).Item(8) - label_totalwgst.Text), "0.00")
                        Return
                    End If
                End If

                For i = 0 To dt.Rows.Count - 1
                    If txt_mid.Text = dt.Rows(i).Item(0) Then
                        label_due.Text = dt.Rows(i).Item(3) - label_totalwgst.Text
                        Exit For
                    Else
                        label_due.Text = Nothing
                    End If
                Next
            End If
        End If 'end of btn_add.visible true

        If btn_edit.Visible = True Then
            label_due.Text = Format(((dt3.Rows(0).Item(2) + dt3.Rows(0).Item(1)) - label_totalwgst.Text), "0.00")
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_mid.Text = Nothing Or txt_amount.Text = Nothing Or label_mshipid.Text = Nothing Then
            MessageBox.Show("You cannot add an incomplete payment!", "Error")
            Return
        End If
        If label_due.Text < 0 Then
            MessageBox.Show("You cannot have a negative due!", "Error")
            Return
        End If

        sql = "insert into Payment values ('" & label_pid1.Text & label_pid2.Text & "', '" & txt_mid.Text & "', '" & label_mshipid.Text &
            "', '" & label_doe.Text & "', '" & label_log.Text & "', '" & txt_desc.Text & "', '" & typestr & "', " & label_totalwgst.Text &
            ", " & label_due.Text & ", '" & label_paydate.Text & "')"
        cmd = New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Added!", MsgBoxStyle.OkOnly, "Successful")

        label_doe.Text = Nothing
        label_log.Text = Nothing
        label_mshipid.Text = Nothing
        label_paydate.Text = Nothing
        label_pid2.Text = Nothing
        label_totalwgst.Text = "0.00"
        label_due.Text = Nothing
        txt_amount.Text = Nothing
        txt_mid.Text = Nothing
        txt_desc.Text = Nothing
        Call initialload()
            
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'fucking desc made me spent 1 hour trying to figure why keep on syntax error, most probably because it's a reserve keyword
        'or shit
        If txt_amount.Text = Nothing Then
            MessageBox.Show("You cannot update with an incomplete payment!", "Error")
            Return
        End If
        If label_due.Text < 0 Then
            MessageBox.Show("You cannot have a negative due!", "Error")
            Return
        End If
        sql = "UPDATE [Payment] SET [desc]='" & txt_desc.Text & "', Amount_Paid=" & label_totalwgst.Text &
            ", Amount_Due=" & label_due.Text & " where PID='" & label_pid1.Text & label_pid2.Text & "'"
        cmd = New OleDbCommand(sql, con)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated Successfully!", "Successful")
        Catch ex As Exception
            MessageBox.Show("Cannot Update. See error message for details. " & Environment.NewLine & ex.Message, "Error")
        End Try

    End Sub

    Private Sub btn_payedit_Click(sender As Object, e As EventArgs) Handles btn_payedit.Click
        If btn_edit.Visible = True Then
            label_due.Text = Format((dt3.Rows(0).Item(2) + dt3.Rows(0).Item(1)), "0.00")
            label_totalwgst.Text = "0.00"
            txt_amount.Enabled = True
            btn_payedit.Visible = False
            btn_edit.Visible = True
        End If

    End Sub
End Class