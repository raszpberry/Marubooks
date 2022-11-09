Imports MySql.Data.MySqlClient

Public Class Membership_Form
    Public MySqlConn As New MySqlConnection With {.ConnectionString = "server=localhost;user id=root;database=mblibdb"}
    Public Command As New MySqlCommand
    Public query As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnCrt.Click
        If TextBox_FN.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf TextBox_LN.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf TextBox_Gender.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf ComboBox_Dept.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf TextBox_Email.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf TextBox_Pass.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf TextBox_ID.Text = "" Then
            MsgBox("Fill in the required info")
        ElseIf TextBox_user.Text = "" Then
            MsgBox("Fill in the required info")
        Else : Try
                MySqlConn.Open()
                query = "INSERT INTO useraccs (firstname,lastname,gender,dept,email,password,idnumber,username) VALUES (@firstname,@lastname,@gender,@dept,@email,@password,@idnumber,@username)"
                Command = New MySqlCommand(query, MySqlConn)
                Command.Parameters.AddWithValue("@firstname", TextBox_FN.Text)
                Command.Parameters.AddWithValue("@lastname", TextBox_LN.Text)
                Command.Parameters.AddWithValue("@gender", TextBox_Gender.Text)
                Command.Parameters.AddWithValue("@dept", ComboBox_Dept.Text)
                Command.Parameters.AddWithValue("@email", TextBox_Email.Text)
                Command.Parameters.AddWithValue("@password", TextBox_Pass.Text)
                Command.Parameters.AddWithValue("@idnumber", TextBox_ID.Text)
                Command.Parameters.AddWithValue("@username", TextBox_user.Text)
                Command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            MsgBox("User registered")
            Main.Show()
            MySqlConn.Close()
            Me.Close()
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            TextBox_Gender.Text = RadioButton2.Text
        End If

    End Sub

    
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox_Gender.Text = RadioButton1.Text


        End If
    End Sub

    Private Sub BttnBck2Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        AdminPage.Show()


    End Sub


    Private Sub TextBox_Pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Pass.TextChanged


        If TextBox_Pass.Text = TextBox_chckpass.Text Then
            lblchcker.Visible = True
            lblchcker.Text = "Matched"
            lblchcker.ForeColor = Color.Lime

        Else
            lblchcker.Visible = True
            lblchcker.Text = "Not matched"
            lblchcker.ForeColor = Color.Red

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
        AdminPage.Close()
    End Sub
End Class