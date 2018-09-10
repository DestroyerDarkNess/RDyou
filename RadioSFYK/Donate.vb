Public Class Donate

    Private Sub Donate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Form1.CenterForm(Me, Me.Location)
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://www.paypal.me/SalvadorKrilewski")
    End Sub
End Class