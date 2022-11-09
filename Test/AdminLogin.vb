Imports MySql.Data.MySqlClient
Public Class AdminLogin
    Public MySqlConn As New MySqlConnection With {.ConnectionString = "server=localhost;user id=root;database=mblibdb"}
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Membership_Form.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnSignIn.Click
        MySqlConn.Open()

        Dim Command As MySqlCommand = New MySqlCommand( _
          "SELECT * FROM admin WHERE username = '" & _
         TextBox_user.Text & "' AND password = '" & TextBox_pass.Text & "' ", MySqlConn)
        Dim sdr As MySqlDataReader = Command.ExecuteReader()
        If (sdr.Read() = True) Then
            MySqlConn.Close()
            AdminPage.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid username or password")
            MySqlConn.Close()
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class