Public Class BookStats

    Private Sub BookStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MblibdbDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.MblibdbDataSet.books)

    End Sub

    Private Sub bttnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnback.Click
        Main.Show()
        Me.Close()

    End Sub

    Private Sub bttnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class