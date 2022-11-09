Imports MySql.Data.MySqlClient

Public Class Issue_Book
    Public sql As New Class2
    Public qry As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public id As String
    Public stats As String
    Public st As String
    Public dit As String
    Public rd As String
    Public t As String

    Private Sub Issue_Book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BooksTableAdapter.Fill(Me.MblibdbDataSet.books)
        Label1.Text = TimeOfDay + Today

    End Sub
  
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            id = row.Cells(0).Value.ToString
            Label2.Text = row.Cells(3).Value.ToString
            st = row.Cells(4).Value.ToString
        Catch ex As Exception
        End Try
        Issue_Book_Load(sender, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnback.Click
        Main.Show()
        Me.Close()

    End Sub

    Private Sub BttnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnIssue.Click
        dit = Label1.Text

        If Label2.Text = "" Then
            MsgBox("Please choose book")
        Else
            stats = "Unavailable"
            If st = "Unavailable" Then
                MsgBox("The book is currently unavailable")

            Else

                Try
                    sql.con.Close()
                    sql.con.Open()
                    qry = "UPDATE books SET BookStatus=@booksts,IssueDate=@issue WHERE BookID=@id"
                    cmd = New MySqlCommand(qry, sql.con)

                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@booksts", stats)
                    cmd.Parameters.AddWithValue("@issue", dit)
                    cmd.ExecuteNonQuery()
                    sql.con.Close()

                    MsgBox("Successfuly issued")
                    If MsgBoxResult.Ok Then
                        Issue_Book_Load(sender, e)
                    End If
                Catch ex As Exception
                    MsgBox("Opps")

                End Try
            End If
        End If

        Issue_Book_Load(sender, e)

    End Sub

    Private Sub BttnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnReturn.Click
        rd = Label1.Text
        t = ""
        If Label2.Text = "" Then
            MsgBox("Please choose book")
        Else
            Try
                sql.con.Open()
                stats = "Available"
                qry = "UPDATE books SET BookStatus=@booksts,IssueDate=@issue,ReturnDate=@rd WHERE BookID=@id"
                cmd = New MySqlCommand(qry, sql.con)

                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@booksts", stats)
                cmd.Parameters.AddWithValue("@issue", t)
                cmd.Parameters.AddWithValue("@rd", rd)
                cmd.ExecuteNonQuery()
                sql.con.Close()

                MsgBox("Successfully Returned")
            Catch ex As Exception
                MsgBox("Opps")
            End Try
        End If


        Issue_Book_Load(sender, e)
    End Sub

   
End Class