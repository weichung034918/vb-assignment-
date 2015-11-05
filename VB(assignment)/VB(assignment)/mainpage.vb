Imports MaterialSkin
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class mainpage
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable("TempSet")
    Dim dt2 As New DataTable("TempStore")
    Dim dt3 As New DataTable("forlistview")
    Dim dt4 As New DataTable("editpayment")
    Dim dt5 As New DataTable("listview1")
    Dim dt6 As New DataTable("listview2")
    Dim useracc As New DataTable("useracc")
    Dim cache As New DataTable("cache")
    Dim con As New OleDb.OleDbConnection
    Dim dirdb As String = Application.StartupPath + "\database.mdb"
    Dim dirdb2 As String = Application.StartupPath + "\database.accdb"
    Dim cmd As New OleDbCommand
    Dim sql As String
    Dim totrec As Integer
    Dim currec As Integer
    Dim x As Integer

    Partial Class mainpage
        Inherits MaterialSkin.Controls.MaterialForm
    End Class


    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
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
                    End Try
                End Try
            End Try
        End Try
        ds.Tables.Add(dt)
        ds.Tables.Add(dt2)
        ds.Tables.Add(dt3)
        ds.Tables.Add(dt4)
        ds.Tables.Add(dt5)
        ds.Tables.Add(dt6)
        ds.Tables.Add(useracc)
        ds.Tables.Add(cache)
        listviewrec()

        Add.Left = (Me.Width / 2) - (Add.Width / 2)
        combobox_reup_search.Width = combobox_reup_search_membershiptype.Width
        'combobox_update_search.Width = combobox_reup_search.Width
        txt_reup_search.Width = combobox_reup_search.Width
        btn_first.Left = 396
        btn_first.Top = MaterialLabel53.Top + 39
        btn_last.Left = 595 + 141 - btn_last.Width
        btn_last.Top = btn_first.Top
        btn_prev.Left = btn_first.Left + btn_first.Width + 13
        btn_prev.Top = btn_first.Top
        btn_next.Left = btn_prev.Left + btn_prev.Width + 13
        btn_next.Top = btn_first.Top
        btn_remove.Left = 396 + ((btn_last.Left + btn_last.Width - 396) / 2) - (btn_remove.Width / 2)

        btn_remove.Top = btn_first.Top + 39
        btn_update.Left = btn_remove.Left
        btn_update.Top = btn_remove.Top


        useracc.Clear()
        sql = "select * from Admin where Username='" & label_uname.Text & "'"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(useracc)
        If useracc.Rows.Count = 0 Then
            Return
        End If

        If useracc.Rows(0).Item(2) = "Admin" Then
            MaterialContextMenuStrip1.Enabled = True
        ElseIf useracc.Rows(0).Item(2) = "Staff" Then
            MaterialContextMenuStrip1.Enabled = False
        Else
            Return
        End If

        MessageBox.Show("Welcome " & label_uname.Text & "!", "Welcome")

    End Sub
    Private Sub PermissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermissionToolStripMenuItem.Click
        Permission.Show()
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

    Private Sub combobox_remove_membertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_reup_membertype.SelectedIndexChanged
        If combobox_reup_membertype.Text = "Deluxe" Then
            label_reup_shipid.Text = "DE"
        ElseIf combobox_reup_membertype.Text = "Non-Deluxe" Then
            label_reup_shipid.Text = "ND"
        ElseIf combobox_reup_membertype.Text = "Weekday" Then
            label_reup_shipid.Text = "WD"
        End If
    End Sub

    Private Sub txt_reup_search_LostFocus(sender As Object, e As EventArgs) Handles txt_reup_search.LostFocus
        If Not txt_reup_search.Text = Nothing Then
            btn_reup_search.Visible = True
        End If
    End Sub

    Private Sub txt_remove_search_TextChanged(sender As Object, e As EventArgs) Handles txt_reup_search.TextChanged

        If Not txt_reup_search.Text = Nothing Then
            btn_reup_search.Visible = True
        End If
    End Sub

    Private Sub combobox_remove_search_membershiptype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_reup_search_membershiptype.SelectedIndexChanged

        If combobox_reup_search_membershiptype.Text = "Deluxe" Then
            'label_remove_search.Left = txt_remove_search.Left - 50
            label_reup_search.Text = "DE"
        ElseIf combobox_reup_search_membershiptype.Text = "Non-Deluxe" Then
            'label_remove_search.Left = txt_remove_search.Left - 50
            label_reup_search.Text = "ND"
        ElseIf combobox_reup_search_membershiptype.Text = "Weekday" Then
            'label_remove_search.Left = txt_remove_search.Left - 50
            label_reup_search.Text = "WD"
        End If
    End Sub

    '-------------------------------Add member function starts-------------------------------------
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If String.IsNullOrEmpty(txt_add_id.Text) Then
            MsgBox("Please enter member ID.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_firstname.Text) Then
            MsgBox("Please enter first name.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_lastname.Text) Then
            MsgBox("Please enter last name.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        ElseIf String.IsNullOrEmpty(combobox_add_membertype.Text) Then
            MsgBox("Please select member type.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_shipid.Text) Then
            MsgBox("Please enter Membership ID.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_cont.Text) Then
            MsgBox("Please enter contact number.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        ElseIf String.IsNullOrEmpty(txt_add_email.Text) Then
            MsgBox("Please enter E-mail address.", MsgBoxStyle.OkOnly, "Empty Field")
            Return
        End If
        sql = "select M.MID, M.Contact_number, M.Email, Ms.MSHIP_ID from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID"
        ds.Tables("TempStore").Clear()
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "TempStore")
        For i = 0 To ds.Tables("TempStore").Rows.Count - 1
            If txt_add_id.Text = ds.Tables("TempStore").Rows(i).Item(0) Then
                MessageBox.Show("Member ID exists in the member list! Please enter a new Member ID.", "")
                Return
            ElseIf txt_add_shipid.Text = ds.Tables("TempStore").Rows(i).Item(3) Then
                MessageBox.Show("Membership ID exists in the member list! Please enter a new Membership ID.", "")
                Return
            ElseIf txt_add_cont.Text = ds.Tables("TempStore").Rows(i).Item(1) Then
                MessageBox.Show("Contact number exists in the member list!", "")
                Return
            ElseIf txt_add_email.Text = ds.Tables("TempStore").Rows(i).Item(2) Then
                MessageBox.Show("E-mail exists in the member list!", "")
                Return
            End If
        Next

        sql = "insert into Members(MID, First_Name, Last_Name, Contact_Number, Email, Status, Date_Of_Entry) values ('" & txt_add_id.Text & "', '" & txt_add_firstname.Text & "', '" &
            txt_add_lastname.Text & "', " & txt_add_cont.Text & ", '" & txt_add_email.Text & "', 'Active', '" & label_date.Text & "')"
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
            sql = sql & combobox_add_membertype.Items(0).ToString & "', 500.00 * (106 / 100), 120.00 * (106 / 100))"
        ElseIf combobox_add_membertype.SelectedIndex = 1 Then
            sql = sql & combobox_add_membertype.Items(1).ToString & "', 300.00 * (106 / 100), 100.00 * (106 / 100))"
        ElseIf combobox_add_membertype.SelectedIndex = 2 Then
            sql = sql & combobox_add_membertype.Items(2).ToString & "', 180.00 * (106 / 100), 75.00 * (106 / 100))"
        Else
            MessageBox.Show("Please select only one of the 3 membership types.", "Membership Type")
            Return
        End If
        cmd = New OleDbCommand(sql, con)
        Try
            MessageBox.Show(sql, "Debug purpose")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Return
        End Try

        sql = "UPDATE Members set MSHIP_ID='" & label_add_shipid.Text & txt_add_shipid.Text & "' where MID='" & txt_add_id.Text & "'"
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
                txt_add_id.Text = "0" & txt_add_id.Text
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
        txt_add_firstname.Text = str.TrimStart(" ")
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
                MessageBox.Show("Member's First Name must only consist of alphabetical values.", "Member's First Name")
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
                txt_add_shipid.Text = "0" & txt_add_shipid.Text
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

    Private Sub combobox_remove_search_LostFocus(sender As Object, e As EventArgs) Handles combobox_reup_search.LostFocus
        If combobox_reup_search.Text.Equals("Membership ID") <> True Then
            combobox_reup_search_membershiptype.Visible = False
            MaterialLabel52.Visible = False
        End If
    End Sub
    '---------------------------------Add member function ends---------------------------------------

    '===============================Delete member function starts====================================
    Private Sub combobox_remove_search_textChanged(sender As Object, e As EventArgs) Handles combobox_reup_search.SelectedIndexChanged
        'DESIGN START
        txt_reup_search.Text = Nothing
        If Not combobox_reup_search.Text = Nothing Then

            txt_reup_search.Visible = True

            If combobox_reup_search.Text.Equals("Membership ID") = True Then
                combobox_reup_search_membershiptype.Visible = True
                MaterialLabel52.Visible = True

            Else
                combobox_reup_search_membershiptype.Visible = False
                MaterialLabel52.Visible = False
            End If

            label_reup_search.Visible = True
            label_reup_search.Text = combobox_reup_search.Text & ":"
        Else
            txt_reup_search.Visible = False
        End If
        'DESIGN END


    End Sub

    Private Sub btn_reup_search_Click(sender As Object, e As EventArgs) Handles btn_reup_search.Click

        If combobox_reup_search.SelectedIndex = 0 Then

            For i = 0 To 9
                If txt_reup_search.TextLength < 10 Then
                    txt_reup_search.Text = "0" + txt_reup_search.Text
                End If
            Next

            'using inner join and identical value,
            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID where M.MID='" & txt_reup_search.Text & "'"

            'notice how i use .selectedindex instead of combobox.text = "something" >>> this is not safe at all when
            'a person tampered with the text. if the text = "Deluxe" then he go and add till become "Deluxeaaa", all condition
            'will be not matched! User .selectedindex instead since after selection, up to him to tamper the text as long
            'as the index is selected.
        ElseIf combobox_reup_search.SelectedIndex = 1 Then

            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID where M.First_Name='" & txt_reup_search.Text & "'"

        ElseIf combobox_reup_search.SelectedIndex = 2 Then

            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members M " &
                "INNER JOIN Membership Ms on M.MID=Ms.MID where M.Last_Name='" & txt_reup_search.Text & "'"

        ElseIf combobox_reup_search.SelectedIndex = 3 Then
            For i = 0 To 7
                If txt_reup_search.TextLength < 8 Then
                    txt_reup_search.Text = "0" + txt_reup_search.Text
                End If
            Next
            sql = "select M.*, Ms.MSHIP_ID, Ms.Member_Type from Members as M " &
                "INNER JOIN Membership as Ms on M.MID=Ms.MID where Ms.MSHIP_ID='" & txt_reup_search.Text & "'"
        Else
            Return 'heh, if nothing is selected, next codes aren't proceeded.
        End If



        If combobox_reup_search.SelectedIndex >= 0 AndAlso combobox_reup_search.SelectedIndex < 4 Then
            'clear the dataset first, else data will be cached! Works like fflush(stdin) but this one is dataset not stdin
            ds.Tables("TempSet").Clear()
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "TempSet")
            Call addset()
        End If


        If ds.Tables(0).Rows.Count > 1 Then
            btn_first.Visible = True
            btn_prev.Visible = True
            btn_next.Visible = True
            btn_last.Visible = True
        End If

    End Sub
    Public Sub addset()
        If ds.Tables("TempSet").Rows.Count = 0 Then
            MessageBox.Show("Member list is empty.", "No members found.")
            Return
        End If
        MsgBox(ds.Tables("TempSet").Rows.Count) ' debug purpose
        txt_reup_id.Text = ds.Tables("TempSet").Rows(0).Item(0)
        Dim mshipid As String = ds.Tables("TempSet").Rows(0).Item(8)
        txt_reup_shipid.Text = mshipid.TrimStart("D", "E", "N", "W")
        txt_reup_firstname.Text = ds.Tables("TempSet").Rows(0).Item(1)
        txt_reup_lastname.Text = ds.Tables("TempSet").Rows(0).Item(2)
        Dim mtype As String = ds.Tables("TempSet").Rows(0).Item(9)
        If mtype = "Deluxe" Then
            combobox_reup_membertype.SelectedIndex = 0
        ElseIf mtype = "Non-Deluxe" Then
            combobox_reup_membertype.SelectedIndex = 1
        ElseIf mtype = "Weekday" Then
            combobox_reup_membertype.SelectedIndex = 2
        End If
        txt_reup_cont.Text = ds.Tables("TempSet").Rows(0).Item(3)
        txt_reup_email.Text = ds.Tables("TempSet").Rows(0).Item(4)
        If ds.Tables("TempSet").Rows(0).Item(5).ToString = "Active" Then
            combobox_reup_status.SelectedIndex = 0
        ElseIf ds.Tables("TempSet").Rows(0).Item(5).ToString = "Closed" Then
            combobox_reup_status.SelectedIndex = 1
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        'reason why i no need to del from 2 tables because i have foreign key set as on delete cascade
        sql = "delete * from Members where MID ='" & txt_reup_id.Text & "'"
        Try
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            ds.Tables("TempSet").Clear()
            txt_reup_search.Clear()
            txt_reup_id.Clear()
            txt_reup_firstname.Clear()
            txt_reup_lastname.Clear()
            txt_reup_shipid.Clear()
            txt_reup_cont.Clear()
            txt_reup_email.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub


    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        currec = 0
        Call addset() 'since row in addset is 0 so i just call the addset() instead of addset2()
    End Sub

    Public Sub addset2() 'for prev, next, last
        txt_reup_id.Text = ds.Tables("TempSet").Rows(currec).Item(0)
        Dim mshipid As String = ds.Tables("TempSet").Rows(currec).Item(8)
        txt_reup_shipid.Text = mshipid.TrimStart("D", "E", "N", "W")
        txt_reup_firstname.Text = ds.Tables("TempSet").Rows(currec).Item(1)
        txt_reup_lastname.Text = ds.Tables("TempSet").Rows(currec).Item(2)
        Dim mtype As String = ds.Tables("TempSet").Rows(currec).Item(9)
        If mtype = "Deluxe" Then
            combobox_reup_membertype.SelectedIndex = 0
        ElseIf mtype = "Non-Deluxe" Then
            combobox_reup_membertype.SelectedIndex = 1
        ElseIf mtype = "Weekday" Then
            combobox_reup_membertype.SelectedIndex = 2
        End If
        txt_reup_cont.Text = ds.Tables("TempSet").Rows(currec).Item(3)
        txt_reup_email.Text = ds.Tables("TempSet").Rows(currec).Item(4)
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
    '================================Delete member function ends=====================================

    'I really feel that if we combine the delete and update to one tab i can save tonnes of works...i in fact don't know
    'why u separate delete and update to two tabs T_T
    'wei chung: so that you can delete moar things and to prevent me from forgetting anything, boss.
    '===============================Update member function starts====================================
    'Private Sub combobox_update_search_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If combobox_update_search.Text <> String.Empty Then

    '        If combobox_update_search.Text.Equals("Membership ID") = True Then
    '            combobox_update_search_membershiptype.Visible = True
    '            MaterialLabel51.Visible = True

    '        Else
    '            combobox_update_search_membershiptype.Visible = False
    '            MaterialLabel51.Visible = False
    '        End If
    '        txt_update_search.Visible = True
    '        label_update_search.Visible = True
    '        label_update_search.Text = combobox_update_search.Text & ":"
    '    Else
    '        txt_update_search.Visible = False
    '    End If
    'End Sub
    Private Sub btn_update_search_Click(sender As Object, e As EventArgs)

    End Sub
    ' i think i dowan to do update members liao, i will move update codes into remove tab and add an update btn, below onwards

    Private Sub combobox_modeselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_modeselect.SelectedIndexChanged
        refresh_reup()
        If combobox_modeselect.SelectedIndex = 0 Then
            btn_remove.Visible = True
            btn_update.Visible = False
            combobox_reup_search.Visible = True
            txt_reup_cont.Enabled = False
            txt_reup_email.Enabled = False
            txt_reup_firstname.Enabled = False
            txt_reup_id.Enabled = False
            txt_reup_lastname.Enabled = False
            txt_reup_shipid.Enabled = False
            combobox_reup_membertype.Enabled = False
            label_reup_shipid.Enabled = True

        ElseIf combobox_modeselect.SelectedIndex = 1 Then
            btn_remove.Visible = False
            btn_update.Visible = True
            combobox_reup_search.Visible = True
            txt_reup_cont.Enabled = True
            txt_reup_email.Enabled = True
            txt_reup_firstname.Enabled = True
            txt_reup_id.Enabled = True
            txt_reup_lastname.Enabled = True
            txt_reup_shipid.Enabled = True
            combobox_reup_status.Enabled = True
            combobox_reup_membertype.Enabled = True
            label_reup_shipid.Enabled = True
            'no point disabling the goddamn label wei chung... 
            'wei chung : accident happens ck... accidents
        ElseIf combobox_modeselect.SelectedIndex = 2 Then
            btn_remove.Visible = False
            btn_update.Visible = False
            combobox_reup_search.Visible = True
            txt_reup_cont.Enabled = False
            txt_reup_email.Enabled = False
            txt_reup_firstname.Enabled = False
            txt_reup_id.Enabled = False
            txt_reup_lastname.Enabled = False
            txt_reup_shipid.Enabled = False
            combobox_reup_status.Enabled = False
            combobox_reup_membertype.Enabled = False
            label_reup_shipid.Enabled = False
        Else
            Return
        End If
    End Sub
    Private Sub refresh_reup()
        combobox_reup_search.SelectedIndex = -1
        combobox_reup_search_membershiptype.SelectedIndex = -1
        combobox_reup_membertype.SelectedIndex = -1
        combobox_reup_status.SelectedIndex = -1
        txt_reup_search.Clear()
        txt_reup_id.Clear()
        txt_reup_lastname.Clear()
        txt_reup_cont.Clear()
        txt_reup_shipid.Clear()
        txt_reup_email.Clear()
        txt_reup_firstname.Clear()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        sql = "UPDATE Members SET First_Name='" & txt_reup_firstname.Text & "', Last_Name='" &
            txt_reup_lastname.Text & "', Contact_Number=" & txt_reup_cont.Text & ", Email='" &
            txt_reup_email.Text & "', Status='"

        If combobox_reup_status.SelectedIndex = 0 Then
            sql = sql & combobox_reup_status.Items(0).ToString & "' where MID='" & txt_reup_id.Text & "'"
        ElseIf combobox_reup_status.SelectedIndex = 1 Then
            sql = sql & combobox_reup_status.Items(1).ToString & "' where MID='" & txt_reup_id.Text & "'"
        Else
            Return
        End If

        Try
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Success update")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        sql = "UPDATE Membership SET Member_Type='"

        If combobox_reup_membertype.SelectedIndex = 0 Then
            sql = sql & combobox_reup_membertype.Items(0).ToString & "', MSHIP_ID='" &
            label_reup_shipid.Text & txt_reup_shipid.Text & "', Reg_Fee=500.00*(106 / 100), Monthly_Fee=120.00*(106 / 100) where MID='" & txt_reup_id.Text & "'"

        ElseIf combobox_reup_membertype.SelectedIndex = 1 Then
            sql = sql & combobox_reup_membertype.Items(1).ToString & "', MSHIP_ID='" &
            label_reup_shipid.Text & txt_reup_shipid.Text & "', Reg_Fee=300.00*(106 / 100), Monthly_Fee=100.00*(106 / 100) where MID='" & txt_reup_id.Text & "'"

        ElseIf combobox_reup_membertype.SelectedIndex = 2 Then
            sql = sql & combobox_reup_membertype.Items(2).ToString & "', MSHIP_ID='" &
            label_reup_shipid.Text & txt_reup_shipid.Text & "', Reg_Fee=180.00*(106 / 100), Monthly_Fee=75.00*(106 / 100) where MID='" & txt_reup_id.Text & "'"

        End If
        Try
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Success update")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        label_time.Text = TimeOfDay.ToString("h:mm:ss tt")
        label_date.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
        label_day.Text = System.DateTime.Now.ToString("dddd")
    End Sub
    '========================================payment starts================================================
    Public Sub listviewrec()
        dt3.Clear()
        payment_listview.Items.Clear()
        sql = "select * from Payment"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt3)
        Dim listrow As DataRow
        For Each listrow In dt3.Rows
            payment_listview.Items.Add(listrow.Item(0))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(1))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(2))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(3))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(4))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(5))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(6))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(7))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(8))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(9))
        Next
    End Sub

    Private Sub btn_payadd_Click(sender As Object, e As EventArgs) Handles btn_payadd.Click
        paymentform.btn_add.Visible = True
        paymentform.btn_edit.Visible = False
        paymentform.btn_payedit.Visible = False
        paymentform.label_doe.Text = Nothing
        paymentform.label_log.Text = Nothing
        paymentform.label_mshipid.Text = Nothing
        paymentform.label_paydate.Text = Nothing
        paymentform.label_pid2.Text = Nothing
        paymentform.label_totalwgst.Text = "0.00"
        paymentform.label_due.Text = Nothing
        paymentform.txt_amount.Text = Nothing
        paymentform.txt_mid.Text = Nothing
        paymentform.txt_desc.Text = Nothing
        paymentform.Show()
    End Sub

    Private Sub pay_memshipid_SelectedIndexChanged(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub memshipid_radio_CheckedChanged(sender As Object, e As EventArgs) Handles radio_mshipid.CheckedChanged
        
        If radio_mshipid.Checked Then
            label_pay_search.Visible = True
            txt_pay_search.Visible = True
        End If

    End Sub

    Private Sub payid_radio_CheckedChanged(sender As Object, e As EventArgs) Handles radio_pid.CheckedChanged
        txt_pay_search.Clear()
        If radio_pid.Checked Then
            label_pay_search.Visible = True
            txt_pay_search.Visible = True
        End If
    End Sub

    Private Sub memid_radio_CheckedChanged(sender As Object, e As EventArgs) Handles radio_mid.CheckedChanged
        txt_pay_search.Clear()
        If radio_pid.Checked Then
            label_pay_search.Visible = True
            txt_pay_search.Visible = True
        End If
    End Sub

    Private Sub pay_search_txt_Click(sender As Object, e As EventArgs) Handles txt_pay_search.Click
        btn_payedit.Visible = False
    End Sub

    Private Sub label_reup_shipid_TextChanged(sender As Object, e As EventArgs) Handles label_reup_shipid.TextChanged
        label_reup_shipid.Left = txt_reup_shipid.Left - label_reup_shipid.Width
    End Sub


    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click
        combobox_modeselect.SelectedIndex = -1
    End Sub

    Public Sub listviewmin() 'for each pay_search text depending on 3 radio buttons
        dt3.Clear()
        payment_listview.Items.Clear()
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt3)
        Dim listrow As DataRow
        For Each listrow In dt3.Rows
            payment_listview.Items.Add(listrow.Item(0))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(1))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(2))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(3))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(4))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(5))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(6))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(7))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(8))
            payment_listview.Items(payment_listview.Items.Count - 1).SubItems.Add(listrow.Item(9))
        Next
    End Sub
    Private Sub pay_search_txt_TextChanged(sender As Object, e As EventArgs) Handles txt_pay_search.TextChanged

        If radio_mid.Checked Then
            sql = "select * from Payment where MID LIKE '%" & txt_pay_search.Text & "%'"
            listviewmin()
        End If
        If radio_mshipid.Checked Then
            sql = "select * from Payment where MSHIP_ID LIKE '%" & txt_pay_search.Text & "%'"
            listviewmin()
        End If
        If radio_pid.Checked Then
            sql = "select * from Payment where PID LIKE '%" & txt_pay_search.Text & "%'"
            listviewmin()
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        listviewrec()
    End Sub

    Private Sub payment_listview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles payment_listview.SelectedIndexChanged
        btn_payedit.Visible = True
    End Sub

    Private Sub btn_payedit_Click(sender As Object, e As EventArgs) Handles btn_payedit.Click
        If label_uname.Text <> payment_listview.SelectedItems(0).SubItems(4).Text Then
            MessageBox.Show("You cannot edit the payment details logged by other admin/staffs.", "Unauthorized")
            Return
        End If

        paymentform.btn_add.Visible = False
        paymentform.btn_edit.Visible = True
        paymentform.btn_payedit.Visible = True
        paymentform.txt_mid.Enabled = False
        paymentform.txt_amount.Enabled = False
        paymentform.radio_rfee.Enabled = False
        paymentform.radio_mfee.Enabled = False
        If payment_listview.SelectedItems.Count > 0 Then
            paymentform.label_pid2.Text = payment_listview.SelectedItems(0).SubItems(0).Text.TrimStart("P", "M")
            paymentform.txt_mid.Text = payment_listview.SelectedItems(0).SubItems(1).Text
            paymentform.label_mshipid.Text = payment_listview.SelectedItems(0).SubItems(2).Text
            paymentform.label_doe.Text = payment_listview.SelectedItems(0).SubItems(3).Text
            paymentform.label_log.Text = payment_listview.SelectedItems(0).SubItems(4).Text
            paymentform.txt_desc.Text = payment_listview.SelectedItems(0).SubItems(5).Text
            If payment_listview.SelectedItems(0).SubItems(6).Text = "RF" Then
                paymentform.radio_rfee.Checked = True
                paymentform.radio_mfee.Checked = False
            ElseIf payment_listview.SelectedItems(0).SubItems(6).Text = "MF" Then
                paymentform.radio_rfee.Checked = False
                paymentform.radio_mfee.Checked = True
            End If
            paymentform.txt_amount.Text = Format((payment_listview.SelectedItems(0).SubItems(7).Text * 94 / 100), "0.00")
            paymentform.label_totalwgst.Text = payment_listview.SelectedItems(0).SubItems(7).Text
            paymentform.label_due.Text = payment_listview.SelectedItems(0).SubItems(8).Text
            paymentform.label_paydate.Text = payment_listview.SelectedItems(0).SubItems(9).Text
        End If
        paymentform.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        MsgBox("Are you sure you want to logout?", vbYesNo, "Logout")
        If vbYes Then
            useracc.Clear()
            con.Close()
            login.Show()
            Me.Close()
        ElseIf vbNo Then
            Return
        End If
    End Sub

    Private Sub btn_reportsmempec_Click(sender As Object, e As EventArgs) Handles btn_reportmemspec.Click

        report.Show()
        report.ReportViewer1.Refresh()
        report.ReportViewer1.RefreshReport()
        If radio_repmemmid.Checked Then

            report.MembersTableAdapter.FillBy(report.databaseDataSet.Members, ListView1.Items(0).SubItems(0).Text)

        ElseIf radio_repmemmshipid.Checked Then

            report.MembersTableAdapter.FillBy1(report.databaseDataSet.Members, ListView1.Items(0).SubItems(1).Text)

        ElseIf radio_repmemfname.Checked Then

            report.MembersTableAdapter.FillBy2(report.databaseDataSet.Members, ListView1.Items(0).SubItems(2).Text)

        ElseIf radio_repmemlname.Checked Then

            report.MembersTableAdapter.FillBy3(report.databaseDataSet.Members, ListView1.Items(0).SubItems(3).Text)

        End If

        report.ReportViewer1.Refresh()
        report.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_reportmemall_Click(sender As Object, e As EventArgs) Handles btn_reportmemall.Click
        cache.Clear()
        sql = "select * from Members"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(cache)
        If cache.Rows.Count < 1 Then
            MessageBox.Show("Nothing to report!", "Empty")
            Return
        End If

        report.MembersTableAdapter.Fill(report.databaseDataSet.Members)
        report.Show()

    End Sub

    Private Sub btn_reportpayall_Click(sender As Object, e As EventArgs) Handles btn_reportpayall.Click
        cache.Clear()
        sql = "select * from Members"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(cache)
        If cache.Rows.Count < 1 Then
            MessageBox.Show("Nothing to report!", "Empty")
            Return
        End If

        reportpayment.PaymentTableAdapter.GetData()
        reportpayment.Show()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles radio_repmemmid.CheckedChanged, radio_repmemfname.CheckedChanged, radio_repmemlname.CheckedChanged, radio_repmemmshipid.CheckedChanged
        label_memsearch.Visible = True
        txt_repmem.Visible = True
        txt_repmem.Text = Nothing
    End Sub

    Private Sub radio_reppaymid_CheckedChanged(sender As Object, e As EventArgs) Handles radio_reppaymid.CheckedChanged, radio_reppaymshipid.CheckedChanged, radio_reppaypid.CheckedChanged
        label_paysearch.Visible = True
        txt_reppay.Visible = True
        txt_reppay.Text = Nothing
    End Sub

    Private Sub txt_repmem_TextChanged(sender As Object, e As EventArgs) Handles txt_repmem.TextChanged
        
        If Not txt_repmem.Text = Nothing Then
            btn_reportmemspec.Visible = True
            If radio_repmemmid.Checked Then
                sql = "select MID, MSHIP_ID, First_Name, Last_Name from Members where MID LIKE '%" & txt_repmem.Text & "%'"
                forlistview1()
            ElseIf radio_repmemmshipid.Checked Then
                sql = "select MID, MSHIP_ID, First_Name, Last_Name from Members where MSHIP_ID LIKE '%" & txt_repmem.Text & "%'"
                forlistview1()
            ElseIf radio_repmemfname.Checked Then
                sql = "select MID, MSHIP_ID, First_Name, Last_Name from Members where First_Name LIKE '%" & txt_repmem.Text & "%'"
                forlistview1()
            ElseIf radio_repmemlname.Checked Then
                sql = "select MID, MSHIP_ID, First_Name, Last_Name from Members where Last_Name LIKE '%" & txt_repmem.Text & "%'"
                forlistview1()
            End If
        Else
            btn_reportmemspec.Visible = False
        End If
    End Sub

    Public Sub forlistview1()
        dt5.Clear()
        ListView1.Items.Clear()
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt5)
        Dim listrow As DataRow
        For Each listrow In dt5.Rows
            ListView1.Items.Add(listrow.Item(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(listrow.Item(1))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(listrow.Item(2))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(listrow.Item(3))
        Next
    End Sub

    Private Sub txt_reppay_TextChanged(sender As Object, e As EventArgs) Handles txt_reppay.TextChanged
        
        If Not txt_reppay.Text = Nothing Then
            btn_reportpayspec.Visible = True
            If radio_reppaymid.Checked Then
                sql = "select PID, MID, MSHIP_ID, Payment_Type, Amount_Paid, Amount_Due from Payment where MID LIKE '%" & txt_reppay.Text & "%'"
                forlistview2()
            ElseIf radio_reppaymshipid.Checked Then
                sql = "select PID, MID, MSHIP_ID, Payment_Type, Amount_Paid, Amount_Due from Payment where MSHIP_ID LIKE '%" & txt_reppay.Text & "%'"
                forlistview2()
            ElseIf radio_reppaypid.Checked Then
                sql = "select PID, MID, MSHIP_ID, Payment_Type, Amount_Paid, Amount_Due from Payment where PID LIKE '%" & txt_reppay.Text & "%'"
                forlistview2()
            End If
        Else
            btn_reportpayspec.Visible = False
        End If
    End Sub
    Public Sub forlistview2()
        dt6.Clear()
        ListView2.Items.Clear()
        da = New OleDbDataAdapter(sql, con)
        da.Fill(dt6)
        Dim listrow As DataRow
        For Each listrow In dt6.Rows
            ListView2.Items.Add(listrow.Item(0))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(listrow.Item(1))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(listrow.Item(2))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(listrow.Item(3))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(listrow.Item(4))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(listrow.Item(5))
        Next
    End Sub
    
    Private Sub btn_reportpayspec_Click(sender As Object, e As EventArgs) Handles btn_reportpayspec.Click
        reportpayment.Show()
        reportpayment.ReportViewer1.Refresh()
        reportpayment.ReportViewer1.RefreshReport()
        If radio_reppaymid.Checked Then

            reportpayment.PaymentTableAdapter.FillBy(reportpayment.databaseDataSet1.Payment, ListView2.Items(0).SubItems(1).Text)

        ElseIf radio_reppaymshipid.Checked Then

            reportpayment.PaymentTableAdapter.FillBy(reportpayment.databaseDataSet1.Payment, ListView2.Items(0).SubItems(2).Text)

        ElseIf radio_reppaypid.Checked Then

            reportpayment.PaymentTableAdapter.FillBy(reportpayment.databaseDataSet1.Payment, ListView2.Items(0).SubItems(0).Text)

        End If

        reportpayment.ReportViewer1.Refresh()
        reportpayment.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt_reup_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reup_id.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_reup_shipid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reup_shipid.KeyPress
        e.Handled = True
    End Sub

    Private Sub txt_reup_firstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reup_firstname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            If txt_reup_firstname.TextLength > 0 And e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_reup_firstname_Leave(sender As Object, e As EventArgs) Handles txt_reup_firstname.Leave
        Dim str As String = txt_reup_firstname.Text
        txt_reup_firstname.Text = Regex.Replace(str, " {2,}", " ")
        txt_reup_firstname.Text = str.TrimStart(" ")
    End Sub

    Private Sub txt_reup_firstname_TextChanged(sender As Object, e As EventArgs) Handles txt_reup_firstname.TextChanged
        Dim str As String = txt_reup_firstname.Text
        For i = 0 To txt_reup_firstname.TextLength - 1 'loop for checking each position (array position) of your string
            If Char.IsLetter(str.Chars(i)) = False Then 'check if that thing you pasted contains letters or not
                txt_reup_firstname.Text = Nothing
                MessageBox.Show("Member's First Name must only consist of alphabetic values.", "Member's First Name")
                Return
            End If
        Next
    End Sub

    Private Sub txt_reup_lastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reup_lastname.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            If txt_reup_lastname.TextLength > 0 And e.KeyChar = ChrW(Keys.Space) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub txt_reup_lastname_Leave(sender As Object, e As EventArgs) Handles txt_reup_lastname.Leave
        Dim str As String = txt_reup_lastname.Text
        txt_reup_lastname.Text = Regex.Replace(str, " {2,}", " ")
        txt_reup_lastname.Text = str.TrimStart(" ")
    End Sub

    Private Sub txt_reup_lastname_TextChanged(sender As Object, e As EventArgs) Handles txt_reup_lastname.TextChanged
        Dim str As String = txt_reup_lastname.Text
        For i = 0 To txt_reup_lastname.TextLength - 1 'loop for checking each position (array position) of your string
            If Char.IsLetter(str.Chars(i)) = False Then 'check if that thing you pasted contains letters or not
                txt_reup_lastname.Text = Nothing
                MessageBox.Show("Member's Last Name must only consist of alphabetic values.", "Member's First Name")
                Return
            End If
        Next
    End Sub

    Private Sub txt_reup_cont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reup_cont.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_reup_cont_TextChanged(sender As Object, e As EventArgs) Handles txt_reup_cont.TextChanged
        Dim str As String = txt_reup_cont.Text
        For i = 0 To txt_reup_cont.TextLength - 1
            If Char.IsLetter(str.Chars(i)) Then
                txt_reup_cont.Text = Nothing
                MessageBox.Show("Contact number must only consist of numerical values.", "Contact Number")
                Return
            End If
        Next
    End Sub

    Private Sub txt_reup_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reup_email.KeyPress
        If e.KeyChar = ChrW(Keys.Space) Then 'not allowing space into the text field
            e.Handled = True
        End If
    End Sub

    Private Sub txt_reup_email_Leave(sender As Object, e As EventArgs) Handles txt_reup_email.Leave
        If Not txt_reup_email.Text.Contains("@") Then
            MessageBox.Show("This doesn't look like an E-mail address, please re-enter a valid E-mail address.", "E-mail Address")
            Return
        End If
    End Sub

    Private Sub txt_reup_email_TextChanged(sender As Object, e As EventArgs) Handles txt_reup_email.TextChanged
        If txt_reup_email.TextLength > 30 Then
            MessageBox.Show("The E-mail address length is too long!", "E-mail Address")
            txt_reup_email.Text = Nothing
            Return
        End If
    End Sub
End Class
