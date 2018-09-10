Public Class Acercade

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCaqF0HH2UQktDQ62VpWNk1Q")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/salvador.osvaldo.1")
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        Me.Close()
    End Sub
    Private Sub Acercade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Form1.CenterForm(Me, Me.Location)
    End Sub

End Class