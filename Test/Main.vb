
Public Class Main
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub BttnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnMember.Click
        Membership_Form.Show()
        Me.Hide()
    End Sub

    Private Sub BttnExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnExt.Click
        Me.Close()
    End Sub

    Private Sub BttnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnIssue.Click
        Login01.Show()
        Me.Hide()
    End Sub

    Private Sub BttnStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnStatus.Click
        BookStats.Show()
        Me.Hide()
    End Sub

End Class
