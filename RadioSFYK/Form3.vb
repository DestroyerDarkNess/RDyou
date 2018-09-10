Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.FormBorderStyle = FormBorderStyle.None
        NotifyIcon1.Text = Label3.Text
    End Sub

#Region "Youtube"

#Region "mover ventana con picturebox"
    Dim st As Integer
    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.DoubleClick
        If st = 0 Then
            Me.WindowState = FormWindowState.Maximized
            st = 1


        ElseIf st = 1 Then
            Me.WindowState = FormWindowState.Normal
            st = 0
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        ex = e.X

        ey = e.Y

        Arrastre = True
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseUp
        Arrastre = False
    End Sub

#End Region


    Private Sub WebView1_NewWindow(ByVal sender As Object, ByVal e As EO.WebBrowser.NewWindowEventArgs) Handles WebView1.NewWindow
        e.Accepted = False

    End Sub

#End Region

   
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        NotifyIcon1.Visible = True
        Me.NotifyIcon1.ShowBalloonTip(10000, "Youtube Player", Label1.Text + vbCrLf + Label3.Text, ToolTipIcon.None)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class