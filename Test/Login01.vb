Imports MySql.Data.MySqlClient

Public Class Login01
    Public MySqlConn As New MySqlConnection With {.ConnectionString = "server=localhost;user id=root;database=mblibdb"}

    Private Sub bttnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnlogin.Click
        MySqlConn.Open()
        Dim Command1 As MySqlCommand = New MySqlCommand( _
     "SELECT * FROM useraccs WHERE username = '" & _
                   TextBox_user.Text & "' AND password = '" & TextBox_pass.Text & "' ", MySqlConn)
            Dim sdr1 As MySqlDataReader = Command1.ExecuteReader()
            If (sdr1.Read() = True) Then
                MySqlConn.Close()
                Issue_Book.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password")
                MySqlConn.Close()
            End If


    End Sub

    Private Sub Bttnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttnback.Click
        Main.Show()
        Me.Close()

    End Sub

   
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class