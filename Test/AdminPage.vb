Imports MySql.Data.MySqlClient

Public Class AdminPage
    Public MySqlConn As New MySqlConnection With {.ConnectionString = "server=localhost;user id=root;database=mblibdb"}

    Private Sub BttnSrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnSrch.Click
        If ComboBox1.Text = "Admin" Then
            Dim Command As New MySqlCommand("SELECT * FROM `admin` WHERE `IDnumber` = @IDnumber", MySqlConn)
            Command.Parameters.Add("@IDnumber", MySqlDbType.Text).Value = TextBox1.Text
            Dim adapter As New MySqlDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If TextBox1.Text = "" Then
                MsgBox("Input ID number")
            ElseIf table.Rows.Count > 0 Then
                textbox_name.Text = table(0)(1)
                textbox_gender.Text = table(0)(3)
                textbox_dept.Text = table(0)(4)
            Else
                MsgBox("ID number don`t exist")
            End If
        Else If ComboBox1.Text = "Member" Then
            Dim Command As New MySqlCommand("SELECT * FROM `useraccs` WHERE `idnumber` = @idnumber", MySqlConn)
            Command.Parameters.Add("@idnumber", MySqlDbType.Text).Value = TextBox1.Text
            Dim adapter As New MySqlDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If TextBox1.Text = "" Then
                MsgBox("Input ID number")

            ElseIf table.Rows.Count > 0 Then
                textbox_name.Text = table(0)(1)
                textbox_gender.Text = table(0)(3)
                textbox_dept.Text = table(0)(4)
            Else
                MsgBox("ID number don`t exist")
            End If
        Else
            MsgBox("Please, choose user type.")
        End If
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Membership_Form.Show()
        Me.Close()
    End Sub

    Private Sub bttndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttndel.Click
        If ComboBox1.Text = "Admin" Then

            Dim Command As New MySqlCommand("DELETE FROM `admin` WHERE `IDNumber` = @IDNumber", MySqlConn)
            Command.Parameters.Add("@IDNumber", MySqlDbType.Text).Value = TextBox1.Text
            MySqlConn.Open()

            If Command.ExecuteNonQuery() = 1 Then
                MsgBox("Delete account?", MsgBoxStyle.OkCancel)
                If MsgBoxResult.Ok Then
                    MsgBox("Account deleted")
                End If
                textbox_name.Text = ""
                textbox_gender.Text = ""
                textbox_dept.Text = ""
            Else
                MessageBox.Show("ID number don`t exist")
            End If

            MySqlConn.Close()
        ElseIf ComboBox1.Text = "Member" Then
            Dim Command As New MySqlCommand("DELETE FROM `useraccs` WHERE `IDNumber` = @IDNumber", MySqlConn)
            Command.Parameters.Add("@IDNumber", MySqlDbType.Text).Value = TextBox1.Text
            MySqlConn.Open()

            If Command.ExecuteNonQuery() = 1 Then
                MsgBox("Delete account?", MsgBoxStyle.OkCancel)
                If MsgBoxResult.Ok Then
                    MsgBox("Account deleted")
                End If
                textbox_name.Text = ""
                textbox_gender.Text = ""
                textbox_dept.Text = ""
            Else
                MessageBox.Show("ID number don`t exist")
            End If
            MySqlConn.Close()
        Else
            MsgBox("Please, choose user type.")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub
End Class