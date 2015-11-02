Imports MaterialSkin
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class mainpage
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim con As New OleDb.OleDbConnection
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim cmd As New OleDbCommand
    Dim sql As String
    Dim totrec As Integer
    Dim currec As Integer

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
                        MessageBox.Show(ex.Message, "Database Error")
                    End Try
                End Try
            End Try
        End Try

        Add.Left = (Me.Width / 2) - (Add.Width / 2)
        combobox_remove_search.Width = combobox_remove_search_membershiptype.Width
        txt_remove_search.Width = combobox_remove_search.Width
        btn_first.Left = 396
        btn_first.Top = MaterialLabel8.Top + 39
        btn_last.Left = 595 + 141 - btn_last.Width
        btn_last.Top = btn_first.Top
        btn_prev.Left = btn_first.Left + btn_first.Width + 13
        btn_prev.Top = MaterialLabel8.Top + 39
        btn_next.Left = btn_prev.Left + btn_prev.Width + 13
        btn_next.Top = btn_first.Top
        btn_remove.Left = 396 + ((btn_last.Left + btn_last.Width - 396) / 2) - (btn_remove.Width / 2)


    End Sub
    Private Sub PermissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermissionToolStripMenuItem.Click
        Permission.Show()
    End Sub

    Private Sub btn_update_search_Click(sender As Object, e As EventArgs) Handles btn_update_search.Click
        btn_update.Visible = True
    End Sub

    Private Sub combobox_add_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_add_membertype.SelectedIndexChanged

        If combobox_add_membertype.Text = "Deluxe" Then
            label_add_shipid.Text = "DE"
        ElseIf combobox_add_membertype.Text = "Non-Deluxe" Then
            label_add_shipid.Text = "ND"
        ElseIf combobox_add_membertype.Text = "Weekday" Then
            label_add_shipid.Text = "WD"
        End If

    End Sub

    Private Sub combobox_remove_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_remove_membertype.SelectedIndexChanged
        If combobox_remove_membertype.Text = "Deluxe" Then
            label_remove_shipid.Text = "DE"
        ElseIf combobox_remove_membertype.Text = "Non-Deluxe" Then
            label_remove_shipid.Text = "ND"
        ElseIf combobox_remove_membertype.Text = "Weekday" Then
            label_remove_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_update_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_update_membertype.SelectedIndexChanged
        If combobox_update_membertype.Text = "Deluxe" Then
            label_update_shipid.Text = "DE"
        ElseIf combobox_update_membertype.Text = "Non-Deluxe" Then
            label_update_shipid.Text = "ND"
        ElseIf combobox_update_membertype.Text = "Weekday" Then
            label_update_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_payment_submit_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_payment_submit_membertype.SelectedIndexChanged
        If combobox_payment_submit_membertype.Text = "Deluxe" Then
            label_payment_submit_shipid.Text = "DE"
        ElseIf combobox_payment_submit_membertype.Text = "Non-Deluxe" Then
            label_payment_submit_shipid.Text = "ND"
        ElseIf combobox_payment_submit_membertype.Text = "Weekday" Then
            label_payment_submit_shipid.Text = "WD"
        End If
    End Sub

    Private Sub combobox_payment_edit_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_payment_edit_membertype.SelectedIndexChanged
        If combobox_payment_edit_membertype.Text = "Deluxe" Then
            label_payment_edit_shipid.Text = "DE"
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

    Private Sub combobox_remove_search_membershiptype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_remove_search_membershiptype.SelectedIndexChanged
        If combobox_remove_search_membershiptype.Text = "Deluxe" Then
            label_remove_search.Left = txt_remove_search.Left - 50
            label_remove_search.Text = "DE"
        ElseIf combobox_remove_search_membershiptype.Text = "Non-Deluxe" Then
            label_remove_search.Left = txt_remove_search.Left - 50
            label_remove_search.Text = "ND"
        ElseIf combobox_remove_search_membershiptype.Text = "Weekday" Then
            label_remove_search.Left = txt_remove_search.Left - 50
            label_remove_search.Text = "WD"
        End If
    End Sub


    Private Sub combobox_update_search_membershiptype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_update_search_membershiptype.SelectedIndexChanged
        If combobox_update_search_membershiptype.Text = "Deluxe" Then
            label_update_search.Left = txt_update_search.Left - 50
            label_update_search.Text = "DE"
        ElseIf combobox_update_search_membershiptype.Text = "Non-Deluxe" Then
            label_update_search.Left = txt_update_search.Left - 50
            label_update_search.Text = "ND"
        ElseIf combobox_update_search_membershiptype.Text = "Weekday" Then
            label_update_search.Left = txt_update_search.Left - 50
            label_update_search.Text = "WD"
        End If
    End Sub

    Private Sub combobox_update_search_LostFocus(sender As Object, e As EventArgs) Handles combobox_update_search.LostFocus
        If combobox_update_search.Text.Equals("Membership ID") <> True Then
            combobox_update_search_membershiptype.Visible = False
            MaterialLabel51.Visible = False
        End If
    End Sub

    Private Sub combobox_update_search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_update_search.SelectedIndexChanged
        If combobox_update_search.Text <> String.Empty Then

            If combobox_update_search.Text.Equals("Membership ID") = True Then
                combobox_update_search_membershiptype.Visible = True
                MaterialLabel51.Visible = True

            Else
                combobox_update_search_membershiptype.Visible = False
                MaterialLabel51.Visible = False
            End If
            label_update_search.Left = txt_update_search.Left - 150
            txt_update_search.Visible = True
            label_update_search.Visible = True
            label_update_search.Text = combobox_update_search.Text & ":"
        Else
            txt_update_search.Visible = False
        End If
    End Sub

    '-------------------------------Add member function starts-------------------------------------
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

        sql = "insert into Members values ('" & txt_add_id.Text & "', '" & txt_add_firstname.Text & "', '" &
            txt_add_lastname.Text & "', " & txt_add_cont.Text & ", '" & txt_add_email.Text & "', 'Active' )"
        cmd = New OleDbCommand(sql, con)
        Try
            MessageBox.Show(sql, "Debug purpose")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Return
        End Try

        sql = "insert into Membership values ('" & txt_add_id.Text & "', '" & label_add_shipid.Text & txt_add_shipid.Text &
            "', '"
        If combobox_add_membertype.SelectedIndex = 0 Then
            sql = sql & combobox_add_membertype.Items(0).ToString & "', 500.00, 120.00)"
        ElseIf combobox_add_membertype.SelectedIndex = 1 Then
            sql = sql & combobox_add_membertype.Items(1).ToString & "', 300.00, 100.00)"
        ElseIf combobox_add_membertype.SelectedIndex = 2 Then
            sql = sql & combobox_add_membertype.Items(2).ToString & "', 180.00, 75.00)"
        Else
            MessageBox.Show("Please select only one of the 3 membership types.", "Membership Type")
            Return
        End If
        cmd = New OleDbCommand(sql, con)
        Try
            MessageBox.Show(sql, "Debug purpose")
            cmd.ExecuteNonQuery()
            MsgBox("Member Added!")
            txt_add_cont.Clear()
            txt_add_email.Clear()
            txt_add_firstname.Clear()
            txt_add_lastname.Clear()
            txt_add_id.Clear()
            txt_add_shipid.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Return
        End Try

    End Sub

    Private Sub txt_add_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_id.KeyPress
        'lock the goddamn anything except controls and numbers
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_add_id_Leave(sender As Object, e As EventArgs) Handles txt_add_id.Leave
        For i = 0 To 9
            If txt_add_id.TextLength < 10 Then
                txt_add_id.Text = "0" + txt_add_id.Text
            End If
        Next i
    End Sub

    Private Sub txt_add_id_TextChanged(sender As Object, e As EventArgs) Handles txt_add_id.TextChanged
        Dim strPaste As String = txt_add_id.Text
        For i = 0 To txt_add_id.TextLength - 1 'loop for checking each position (array position) of your string
            If Char.IsLetter(strPaste.Chars(i)) Then 'check if that thing you pasted contains letters or not
                txt_add_id.Text = Nothing
                MessageBox.Show("Member ID must only consist of numerical values.", "Member ID")
                Return
            End If
        Next

        If txt_add_id.TextLength > 10 Then
            MessageBox.Show("Member ID must be less than 10 numbers.", "Member ID")
            txt_add_id.Text = Nothing
            Return

        End If
        
    End Sub

    Private Sub txt_add_firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_firstname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            If txt_add_firstname.TextLength > 0 And e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_add_firstname_Leave(sender As Object, e As EventArgs) Handles txt_add_firstname.Leave

        Dim str As String = txt_add_firstname.Text
        txt_add_firstname.Text = Regex.Replace(str, " {2,}", " ")
        'regex (regular expression) needs import system.text.regularexpressions
        'space followed by the quantifier {2,}, matches a space, repeated two or more times
        'then replace with single space only
        'check out the quantifiers at https://msdn.microsoft.com/en-us/library/3206d374(v=vs.110).aspx
    End Sub

    Private Sub txt_add_firstname_TextChanged(sender As Object, e As EventArgs) Handles txt_add_firstname.TextChanged

        Dim str As String = txt_add_firstname.Text
        For i = 0 To txt_add_firstname.TextLength - 1 'loop for checking each position (array position) of your string
            If Char.IsLetter(str.Chars(i)) = False Then 'check if that thing you pasted contains letters or not
                txt_add_firstname.Text = Nothing
                MessageBox.Show("Member's First Name must only consist of numerical values.", "Member's First Name")
                Return
            End If
        Next

    End Sub

    Private Sub txt_add_lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_lastname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            If txt_add_lastname.TextLength > 0 And e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_add_lastname_Leave(sender As Object, e As EventArgs) Handles txt_add_lastname.Leave

        Dim str As String = txt_add_lastname.Text
        txt_add_lastname.Text = Regex.Replace(str, " {2,}", " ")

    End Sub

    Private Sub txt_add_lastname_TextChanged(sender As Object, e As EventArgs) Handles txt_add_lastname.TextChanged

        Dim str As String = txt_add_lastname.Text
        For i = 0 To txt_add_lastname.TextLength - 1 'loop for checking each position (array position) of your string
            If Char.IsLetter(str.Chars(i)) = False Then 'check if that thing you pasted contains letters or not
                txt_add_lastname.Text = Nothing
                MessageBox.Show("Member's Last Name must only consist of numerical values.", "Member's Last Name")
                Return
            End If
        Next

    End Sub

    Private Sub txt_add_shipid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_shipid.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_add_shipid_Leave(sender As Object, e As EventArgs) Handles txt_add_shipid.Leave
        For i = 0 To 7
            If txt_add_shipid.TextLength < 8 Then
                txt_add_shipid.Text = "0" + txt_add_shipid.Text
            End If
        Next i
    End Sub

    Private Sub txt_add_shipid_TextChanged(sender As Object, e As EventArgs) Handles txt_add_shipid.TextChanged
        Dim str As String = txt_add_shipid.Text
        For i = 0 To txt_add_shipid.TextLength - 1
            If Char.IsLetter(str.Chars(i)) Then
                txt_add_shipid.Text = Nothing
                MessageBox.Show("Membership ID must only consist of numerical values.", "Membership ID")
                Return
            End If
        Next

        If txt_add_shipid.TextLength > 8 Then
            MessageBox.Show("Membership ID must be less than 8 numbers.", "Membership ID")
            txt_add_shipid.Text = Nothing
            Return
        End If
    End Sub

    Private Sub txt_add_cont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add_cont.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

    Private Sub txt_add_cont_TextChanged(sender As Object, e As EventArgs) Handles txt_add_cont.TextChanged

        Dim str As String = txt_add_cont.Text
        For i = 0 To txt_add_cont.TextLength - 1
            If Char.IsLetter(str.Chars(i)) Then
                txt_add_cont.Text = Nothing
                MessageBox.Show("Contact number must only consist of numerical values.", "Contact Number")
                Return
            End If
        Next

    End Sub

    Private Sub txt_add_email_Leave(sender As Object, e As EventArgs) Handles txt_add_email.Leave

        If Not txt_add_email.Text.Contains("@") Then
            MessageBox.Show("This doesn't look like an E-mail address, please re-enter a valid E-mail address.", "E-mail Address")
            Return
        End If

    End Sub

    Private Sub txt_add_email_TextChanged(sender As Object, e As EventArgs) Handles txt_add_email.TextChanged

        If txt_add_email.TextLength > 30 Then
            MessageBox.Show("The E-mail address length is too long!", "E-mail Address")
            txt_add_email.Text = Nothing
            Return
        End If
    End Sub

    Private Sub combobox_remove_search_LostFocus(sender As Object, e As EventArgs) Handles combobox_remove_search.LostFocus
        If combobox_remove_search.Text.Equals("Membership ID") <> True Then
            combobox_remove_search_membershiptype.Visible = False
            MaterialLabel52.Visible = False
        End If
    End Sub
    '---------------------------------Add member function ends---------------------------------------

    '===============================Delete member function starts====================================
    Private Sub combobox_remove_search_textChanged(sender As Object, e As EventArgs) Handles combobox_remove_search.SelectedIndexChanged
        'DESIGN START
       
        If combobox_remove_search.Text <> String.Empty Then
           
            If combobox_remove_search.Text.Equals("Membership ID") = True Then
                combobox_remove_search_membershiptype.Visible = True
                MaterialLabel52.Visible = True
              
            Else
                combobox_remove_search_membershiptype.Visible = False
                MaterialLabel52.Visible = False
            End If
            
            txt_remove_search.Visible = True
            label_remove_search.Visible = True
            label_remove_search.Text = combobox_remove_search.Text & ":"
        Else
            txt_remove_search.Visible = False
        End If
        'DESIGN END


    End Sub

    Private Sub btn_remove_search_Click(sender As Object, e As EventArgs) Handles btn_remove_search.Click

        If combobox_remove_search.SelectedIndex = 0 Then

            For i = 0 To 9
                If txt_remove_search.TextLength < 10 Then
                    txt_remove_search.Text = "0" + txt_remove_search.Text
                End If
            Next

            'using inner join and identical value,
            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID where M.MID='" & txt_remove_search.Text & "'"

        ElseIf combobox_remove_search.SelectedIndex = 1 Then

            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID where M.First_Name='" & txt_remove_search.Text & "'"

        ElseIf combobox_remove_search.SelectedIndex = 2 Then

            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID where M.Last_Name='" & txt_remove_search.Text & "'"

        ElseIf combobox_remove_search.SelectedIndex = 3 Then
            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members as M " &
                "INNER JOIN Membership as Ms on M.MID=Ms.MID where Ms.MSHIP_ID='" & txt_remove_search.Text & "'"
        End If



        If combobox_remove_search.SelectedIndex >= 0 AndAlso combobox_remove_search.SelectedIndex < 4 Then
            'clear the dataset first, else data will be cached! Works like fflush(stdin) but this one is dataset not stdin
            ds.Clear()
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "TempSet")
            Call addset()
        End If

        'ND00000002

        btn_remove.Visible = True

        If ds.Tables(0).Rows.Count > 1 Then
            btn_first.Visible = True
            btn_prev.Visible = True
            btn_next.Visible = True
            btn_last.Visible = True
        End If

    End Sub
    Public Sub addset()
        txt_remove_id.Text = ds.Tables(0).Rows(0).Item(0)
        Dim mshipid As String = ds.Tables(0).Rows(0).Item(6)
        txt_remove_shipid.Text = mshipid.TrimStart("D", "E", "N", "W")
        txt_remove_firstname.Text = ds.Tables(0).Rows(0).Item(1)
        txt_remove_lastname.Text = ds.Tables(0).Rows(0).Item(2)
        Dim mtype As String = ds.Tables(0).Rows(0).Item(7)
        If mtype = "Deluxe" Then
            combobox_remove_membertype.SelectedIndex = 0
        ElseIf mtype = "Non-Deluxe" Then
            combobox_remove_membertype.SelectedIndex = 1
        ElseIf mtype = "Weekday" Then
            combobox_remove_membertype.SelectedIndex = 2
        End If
        txt_remove_cont.Text = ds.Tables(0).Rows(0).Item(3)
        txt_remove_email.Text = ds.Tables(0).Rows(0).Item(4)
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        'reason why i no need to del from 2 tables because i have foreign key set as on delete cascade
        sql = "delete * from Members where MID ='" & txt_remove_id.Text & "'"
        Try
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            ds.Clear()
            txt_remove_search.Clear()
            txt_remove_id.Clear()
            txt_remove_firstname.Clear()
            txt_remove_lastname.Clear()
            txt_remove_shipid.Clear()
            txt_remove_cont.Clear()
            txt_remove_email.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub


    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        currec = 0
        Call addset()
    End Sub

    Public Sub addset2()
        txt_remove_id.Text = ds.Tables(0).Rows(currec).Item(0)
        Dim mshipid As String = ds.Tables(0).Rows(currec).Item(6)
        txt_remove_shipid.Text = mshipid.TrimStart("D", "E", "N", "W")
        txt_remove_firstname.Text = ds.Tables(0).Rows(currec).Item(1)
        txt_remove_lastname.Text = ds.Tables(0).Rows(currec).Item(2)
        Dim mtype As String = ds.Tables(0).Rows(currec).Item(7)
        If mtype = "Deluxe" Then
            combobox_remove_membertype.SelectedIndex = 0
        ElseIf mtype = "Non-Deluxe" Then
            combobox_remove_membertype.SelectedIndex = 1
        ElseIf mtype = "Weekday" Then
            combobox_remove_membertype.SelectedIndex = 2
        End If
        txt_remove_cont.Text = ds.Tables(0).Rows(currec).Item(3)
        txt_remove_email.Text = ds.Tables(0).Rows(currec).Item(4)
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        If currec <> 0 Then
            currec -= 1
            addset2()
        End If
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If currec <> ds.Tables(0).Rows.Count - 1 Then
            currec += 1
            addset2()
        End If
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        currec = ds.Tables(0).Rows.Count - 1
        addset2()
    End Sub
End Class
'================================Delete member function ends=====================================