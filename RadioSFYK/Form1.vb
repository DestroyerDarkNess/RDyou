Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Threading.Tasks

Public Class Form1

    Public Shared Sub AllowProprietaryMediaFormats()

    End Sub
    Dim tmpPath As String = Path.GetTempPath()
    Dim dirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

    Private Sub Inicio()
        ' My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicio()
    End Sub

#Region " CenterForm function "

    Function CenterForm(ByVal Form_to_Center As Form, ByVal Form_Location As Point) As Point
        Dim FormLocation As New Point
        FormLocation.X = (Me.Left + (Me.Width - Form_to_Center.Width) / 2) ' set the X coordinates.
        FormLocation.Y = (Me.Top + (Me.Height - Form_to_Center.Height) / 2) ' set the Y coordinates.
        Return FormLocation ' return the Location to the Form it was called from.
    End Function

#End Region

#Region "BOTONES"

    Private Sub FlatStickyButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatStickyButton1.Click
        FlatTabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub FlatStickyButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatStickyButton2.Click
        FlatTabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub FlatStickyButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatStickyButton3.Click
        Acercade.ShowDialog()
    End Sub

    Private Sub FlatStickyButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatStickyButton4.Click
        FlatTabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub FlatStickyButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatStickyButton5.Click
        Donate.ShowDialog()
    End Sub

#End Region

#Region "Tiempo de espera"

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pbar.Maximum = "100"
        pbar.Value = pbar.Value + "100"

        If pbar.Value = "100" Then
            Timer1.Enabled = False
            Form2.ShowDialog()
            r1()
            r2()
            r3()
            r4()
            r5()
            r6()
            r7()
            r8()
            r9()
            r10()
            r11()
            r12()
            r13()
        End If
    End Sub

#End Region

#Region "RADIO"

    Private Sub r1()
        Dim r1 As String = "Rock Ultra"
        Dim lvi As New ListViewItem(r1)
        lvi.SubItems.Add("★★★★★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r2()
        Dim r2 As String = "Relax Radio FM"
        Dim lvi As New ListViewItem(r2)
        lvi.SubItems.Add("★★")
        listv.Items.Add(lvi)
    End Sub

    Private Sub r3()
        Dim r3 As String = "Brasil Radio"
        Dim lvi As New ListViewItem(r3)
        lvi.SubItems.Add("-")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r4()
        Dim r4 As String = "Reggaeton Radio"
        Dim lvi As New ListViewItem(r4)
        lvi.SubItems.Add("★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r5()
        Dim r5 As String = "Reggaeton FM"
        Dim lvi As New ListViewItem(r5)
        lvi.SubItems.Add("★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r6()
        Dim r6 As String = "Universal"
        Dim lvi As New ListViewItem(r6)
        lvi.SubItems.Add("★★★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r7()
        Dim r7 As String = "Amvrakia Fm"
        Dim lvi As New ListViewItem(r7)
        lvi.SubItems.Add("★★★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r8()
        Dim r8 As String = "89 FM A RADIO"
        Dim lvi As New ListViewItem(r8)
        lvi.SubItems.Add("★★★★★★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r9()
        Dim r9 As String = "Extreme Anime Radio"
        Dim lvi As New ListViewItem(r9)
        lvi.SubItems.Add("★★★★★★★★★ OMAEWA MOU SHINDEIRU")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r10()
        Dim r10 As String = "Anime Blast Radio"
        Dim lvi As New ListViewItem(r10)
        lvi.SubItems.Add("★★★★★ Rasengan!")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r11()
        Dim r11 As String = "JPop PowerPlay"
        Dim lvi As New ListViewItem(r11)
        lvi.SubItems.Add("★★★★")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r12()
        Dim r12 As String = "Indian Radio"
        Dim lvi As New ListViewItem(r12)
        lvi.SubItems.Add("★★★★★★★ Hare Krishna!")
        listv.Items.Add(lvi)
    End Sub
    Private Sub r13()
        Dim r13 As String = "Arabic Center"
        Dim lvi As New ListViewItem(r13)
        lvi.SubItems.Add("★★★★★★★ Allahu Akbar! Boom...")
        listv.Items.Add(lvi)
    End Sub


    Private Sub listv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listv.SelectedIndexChanged
        Try


            For Each item As ListViewItem In listv.Items
                If item.Selected = True Then
                    Dim name As String = item.Text
                    If name = "Rock Ultra" Then
                        AxWindowsMediaPlayer1.URL = "http://uplink.duplexfx.com:8008"
                    ElseIf name = "Relax Radio FM" Then
                        AxWindowsMediaPlayer1.URL = "http://streaming.radionomy.com/JamendoLounge?lang=es-ES%2ces%3bq%3d0.9"
                    ElseIf name = "Brasil Radio" Then
                        AxWindowsMediaPlayer1.URL = "https://live.hunter.fm/country"
                    ElseIf name = "Reggaeton Radio" Then
                        AxWindowsMediaPlayer1.URL = "http://192.184.9.158:8836/"
                    ElseIf name = "Reggaeton FM" Then
                        AxWindowsMediaPlayer1.URL = "http://192.111.140.6:8224/stream/2/;"
                    ElseIf name = "Universal" Then
                        AxWindowsMediaPlayer1.URL = "http://69.4.234.186:9180/"
                    ElseIf name = "Amvrakia Fm" Then
                        AxWindowsMediaPlayer1.URL = "http://216.120.247.11:8000/"
                    ElseIf name = "89 FM A RADIO" Then
                        AxWindowsMediaPlayer1.URL = "http://54.38.184.167:8054/fmradiomanele"
                    ElseIf name = "Extreme Anime Radio" Then
                        AxWindowsMediaPlayer1.URL = "http://174.37.159.206:8052/"
                    ElseIf name = "Anime Blast Radio" Then
                        AxWindowsMediaPlayer1.URL = "http://tedc.biz:8000/stream/2/"
                    ElseIf name = "JPop PowerPlay" Then
                        AxWindowsMediaPlayer1.URL = "http://198.27.80.154:8080/"
                    ElseIf name = "Indian Radio" Then
                        AxWindowsMediaPlayer1.URL = "http://63.143.36.2:8888/Bhakti/"
                    ElseIf name = "Arabic Center" Then
                        AxWindowsMediaPlayer1.URL = "http://144.76.218.173:8100/"
                    End If
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "YOUSHEAR"

#Region "INICIAL"
    Sub New()
        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False
        SetSubText("Search for videos...", txtSearch)
    End Sub

    Private WithEvents Syn As New SynYoutube
#End Region

#Region "EVENTS"
    Private Sub Syn_Status(ByVal Result As String) Handles Syn.Status
        lblStatus.Text = Result
    End Sub

    Private Sub Syn_StatusButtons(ByVal ButtonNextPageToken As Boolean, ByVal ButtonPrevPageToken As Boolean) Handles Syn.StatusButtons
        btnNext.Enabled = ButtonNextPageToken
        btnPrevious.Enabled = ButtonPrevPageToken
    End Sub

    Private Sub Syn_TotalResult(ByVal Result As String) Handles Syn.TotalResult
        lblResult.Text = Result
    End Sub
#End Region

#Region "SEARCH, PREVIOUS, NEXT"
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If txtSearch.TextLength < 1 Then : Exit Sub : End If
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        PLoading.Visible = True
        SynVideos.VideoClean()
        Dim MyTask As Task = Task.Factory.StartNew(Function(t) Syn.Search(txtSearch.Text), Nothing).ContinueWith(Sub(t) EndSearch(t.Result), TaskScheduler.FromCurrentSynchronizationContext)
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        PLoading.Visible = True
        SynVideos.VideoClean()
        Dim MyTask As Task = Task.Factory.StartNew(Function(t) Syn.NextPage, Nothing).ContinueWith(Sub(t) EndSearch(t.Result), TaskScheduler.FromCurrentSynchronizationContext)
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        PLoading.Visible = True
        SynVideos.VideoClean()
        Dim MyTask As Task = Task.Factory.StartNew(Function(t) Syn.PreviousPage, Nothing).ContinueWith(Sub(t) EndSearch(t.Result), TaskScheduler.FromCurrentSynchronizationContext)
    End Sub

    Private Sub EndSearch(ByVal Result As List(Of ListBoxItem))
        For Each MyItem In Result
            SynVideos.AddVideo(MyItem)
        Next
        txtSearch.Enabled = True
        btnSearch.Enabled = True
        PLoading.Visible = False
        lblStatus.Text = "Searching videos..."
    End Sub
#End Region

    Private Sub SynVideos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynVideos.SelectedIndexChanged
        Dim MyItem As ListBoxItem = CType(SynVideos.SelectedItems(0), ListBoxItem)
        Try
            For Each item As ListViewItem In SynVideos.Items

                If item.Selected = True Then
                    If SynVideos.SelectedItems.Count = 0 Then : Exit Sub : End If

                    'Form3.TextBox1.Text = MyItem.VideoID
                    'Form3.Label1.Text = MyItem.Canal
                    'Form3.Label3.Text = MyItem.Titulo
                    MsgBox(MyItem.VideoID)
                End If
                MsgBox("1" & MyItem.VideoID)
            Next
            MsgBox("2" & MyItem.VideoID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CTXVideoURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTXVideoURL.Click
        If SynVideos.SelectedItems.Count = 0 Then : Exit Sub : End If
        Clipboard.SetText(CType(SynVideos.SelectedItems(0), ListBoxItem).VideoURL)
    End Sub

    Private Sub CTXChannelURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTXChannelURL.Click
        If SynVideos.SelectedItems.Count = 0 Then : Exit Sub : End If
        Clipboard.SetText(CType(SynVideos.SelectedItems(0), ListBoxItem).ChannelURL)
    End Sub

    Private Sub CTXDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTXDownload.Click
        If SynVideos.SelectedItems.Count = 0 Then : Exit Sub : End If
        Dim MyItem As ListBoxItem = CType(SynVideos.SelectedItems(0), ListBoxItem)
        Form3.WebView1.Url = "https://www.youtube.com/embed/" & MyItem.VideoID & "?autoplay=1"
        Form3.Label1.Text = MyItem.Canal
        Form3.Label3.Text = MyItem.Titulo
        Form3.Show()
    End Sub


#End Region

#Region "AUTOSTART"

    Private Sub FlatToggle1_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle1.CheckedChanged
        Try
            If FlatToggle1.Checked = False Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

#End Region


  
End Class
