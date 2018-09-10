Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization

Public Class SynYoutube

    'DATA/HORA: 09/01/2017 09:12:45 AM
    'CODE: HACKING SOOFT T
    'BLOGGER: SOOFTT.BLOGSPOT.COM

    Public Event TotalResult(ByVal Result As String)
    Public Event Status(ByVal Result As String)
    Public Event StatusButtons(ByVal ButtonNextPageToken As Boolean, ByVal ButtonPrevPageToken As Boolean)

    Public Property API_Key As String = "AIzaSyA1n4M-fo2Y5NHUj0RsvXEAis3H6_lIjRg"

    'I recommend creating a new key because I can delete my key soon
    'DOUBTS?
    'VIDEO CREATE KEY (YOUTUBE API) - https://www.youtube.com/watch?v=QFGFHiAY5J4

    Public Function Search(ByVal Query As String) As List(Of ListBoxItem)
        Dim MyList As New List(Of ListBoxItem)
        Try
            Dim Result As String = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=50&q=" & URLEncode(Query) & "&fields=items(id/videoId,snippet(publishedAt,channelId,channelTitle,thumbnails/default/url,title)),nextPageToken,pageInfo,prevPageToken&key=" & API_Key)
            Dim MyMt As JsVideo = New JavaScriptSerializer().Deserialize(Of JsVideo)(Result)
            RaiseEvent TotalResult("Approximately " & ToNumber(MyMt.pageInfo.totalResults) & " results")
            Dim MyCount As Integer = 1
            For Each MyItem In MyMt.items
                Try
                    RaiseEvent Status("Loading Videos (" & MyCount.ToString & "/" & MyMt.items.Count.ToString & ")")

                    Result = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("https://www.googleapis.com/youtube/v3/videos?part=contentDetails,statistics&id=" & MyItem.id.videoId & "&fields=items(contentDetails/duration,statistics)&key=" & API_Key)

                    Dim TX As JsInfo = New JavaScriptSerializer().Deserialize(Of JsInfo)(Result)

                    Dim NewItem As New ListBoxItem
                    NewItem.ChannelURL = "https://www.youtube.com/channel/" & MyItem.snippet.channelId
                    NewItem.VideoURL = "https://www.youtube.com/watch?v=" & MyItem.id.videoId
                    NewItem.VideoEmbed = "https://www.youtube.com/embed/" & MyItem.id.videoId & "?rel=0&controls=0&showinfo=0"
                    NewItem.VideoID = MyItem.id.videoId
                    NewItem.Thumbnail = ToBitmap(MyItem.snippet.thumbnails.default.url)
                    NewItem.Titulo = MyItem.snippet.title
                    NewItem.Canal = MyItem.snippet.channelTitle

                    NewItem.Duration = FormatDuration(TX.items(0).contentDetails.duration, True)
                    NewItem.ViewCount = ToNumber(TX.items(0).statistics.viewCount)
                    NewItem.LikeCount = ToNumber(TX.items(0).statistics.likeCount)
                    NewItem.DislikeCount = ToNumber(TX.items(0).statistics.dislikeCount)
                    NewItem.FavoriteCount = ToNumber(TX.items(0).statistics.favoriteCount)
                    NewItem.CommentCount = ToNumber(TX.items(0).statistics.commentCount)
                    NewItem.PublishedAt = MyItem.snippet.publishedAt.ToString("dd/MM/yyyy hh:mm:ss")

                    MyList.Add(NewItem)
                    MyCount += 1
                Catch ex As Exception : End Try
            Next
            RaiseEvent StatusButtons(IIf(MyMt.nextPageToken Is Nothing, False, True), IIf(MyMt.prevPageToken Is Nothing, False, True))
            LastNextPageToken = IIf(MyMt.nextPageToken Is Nothing, Nothing, MyMt.nextPageToken)
            LastPrevPageToken = IIf(MyMt.prevPageToken Is Nothing, Nothing, MyMt.prevPageToken)
            LastQuery = Query
        Catch ex As Exception : End Try
        Return MyList
    End Function

    Public Function NextPage() As List(Of ListBoxItem)
        Dim MyList As New List(Of ListBoxItem)
        Try
            Dim Result As String = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=50&pageToken=" & LastNextPageToken & "&q=" & URLEncode(LastQuery) & "&fields=items(id/videoId,snippet(publishedAt,channelId,channelTitle,thumbnails/default/url,title)),nextPageToken,pageInfo,prevPageToken&key=" & API_Key)
            Dim MyMt As JsVideo = New JavaScriptSerializer().Deserialize(Of JsVideo)(Result)
            RaiseEvent TotalResult("Approximately " & ToNumber(MyMt.pageInfo.totalResults) & " results")
            Dim MyCount As Integer = 1
            For Each MyItem In MyMt.items
                Try
                    RaiseEvent Status("Loading Videos (" & MyCount.ToString & "/" & MyMt.items.Count.ToString & ")")

                    Result = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("https://www.googleapis.com/youtube/v3/videos?part=contentDetails,statistics&id=" & MyItem.id.videoId & "&fields=items(contentDetails/duration,statistics)&key=" & API_Key)

                    Dim TX As JsInfo = New JavaScriptSerializer().Deserialize(Of JsInfo)(Result)

                    Dim NewItem As New ListBoxItem
                    NewItem.ChannelURL = "https://www.youtube.com/channel/" & MyItem.snippet.channelId
                    NewItem.VideoURL = "https://www.youtube.com/watch?v=" & MyItem.id.videoId
                    NewItem.VideoEmbed = "https://www.youtube.com/embed/" & MyItem.id.videoId & "?rel=0&controls=0&showinfo=0"
                    NewItem.VideoID = MyItem.id.videoId
                    NewItem.Thumbnail = ToBitmap(MyItem.snippet.thumbnails.default.url)
                    NewItem.Titulo = MyItem.snippet.title
                    NewItem.Canal = MyItem.snippet.channelTitle

                    NewItem.Duration = FormatDuration(TX.items(0).contentDetails.duration, True)
                    NewItem.ViewCount = ToNumber(TX.items(0).statistics.viewCount)
                    NewItem.LikeCount = ToNumber(TX.items(0).statistics.likeCount)
                    NewItem.DislikeCount = ToNumber(TX.items(0).statistics.dislikeCount)
                    NewItem.FavoriteCount = ToNumber(TX.items(0).statistics.favoriteCount)
                    NewItem.CommentCount = ToNumber(TX.items(0).statistics.commentCount)
                    NewItem.PublishedAt = MyItem.snippet.publishedAt.ToString("dd/MM/yyyy hh:mm:ss")

                    MyList.Add(NewItem)
                    MyCount += 1
                Catch ex As Exception : End Try
            Next
            RaiseEvent StatusButtons(IIf(MyMt.nextPageToken Is Nothing, False, True), IIf(MyMt.prevPageToken Is Nothing, False, True))
            LastNextPageToken = IIf(MyMt.nextPageToken Is Nothing, Nothing, MyMt.nextPageToken)
            LastPrevPageToken = IIf(MyMt.prevPageToken Is Nothing, Nothing, MyMt.prevPageToken)
        Catch ex As Exception : End Try
        Return MyList
    End Function

    Private LastNextPageToken As String
    Private LastPrevPageToken As String
    Private LastQuery As String

    Public Function PreviousPage() As List(Of ListBoxItem)
        Dim MyList As New List(Of ListBoxItem)
        Try
            Dim Result As String = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=50&pageToken=" & LastPrevPageToken & "&q=" & URLEncode(LastQuery) & "&fields=items(id/videoId,snippet(publishedAt,channelId,channelTitle,thumbnails/default/url,title)),nextPageToken,pageInfo,prevPageToken&key=" & API_Key)
            Dim MyMt As JsVideo = New JavaScriptSerializer().Deserialize(Of JsVideo)(Result)
            RaiseEvent TotalResult("Approximately " & ToNumber(MyMt.pageInfo.totalResults) & " results")
            Dim MyCount As Integer = 1
            For Each MyItem In MyMt.items
                Try
                    RaiseEvent Status("Loading Videos (" & MyCount.ToString & "/" & MyMt.items.Count.ToString & ")")

                    Result = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("https://www.googleapis.com/youtube/v3/videos?part=contentDetails,statistics&id=" & MyItem.id.videoId & "&fields=items(contentDetails/duration,statistics)&key=" & API_Key)

                    Dim TX As JsInfo = New JavaScriptSerializer().Deserialize(Of JsInfo)(Result)

                    Dim NewItem As New ListBoxItem
                    NewItem.ChannelURL = "https://www.youtube.com/channel/" & MyItem.snippet.channelId
                    NewItem.VideoURL = "https://www.youtube.com/watch?v=" & MyItem.id.videoId
                    NewItem.VideoEmbed = "https://www.youtube.com/embed/" & MyItem.id.videoId & "?rel=0&controls=0&showinfo=0"
                    NewItem.VideoID = MyItem.id.videoId
                    NewItem.Thumbnail = ToBitmap(MyItem.snippet.thumbnails.default.url)
                    NewItem.Titulo = MyItem.snippet.title
                    NewItem.Canal = MyItem.snippet.channelTitle

                    NewItem.Duration = FormatDuration(TX.items(0).contentDetails.duration, True)
                    NewItem.ViewCount = ToNumber(TX.items(0).statistics.viewCount)
                    NewItem.LikeCount = ToNumber(TX.items(0).statistics.likeCount)
                    NewItem.DislikeCount = ToNumber(TX.items(0).statistics.dislikeCount)
                    NewItem.FavoriteCount = ToNumber(TX.items(0).statistics.favoriteCount)
                    NewItem.CommentCount = ToNumber(TX.items(0).statistics.commentCount)
                    NewItem.PublishedAt = MyItem.snippet.publishedAt.ToString("dd/MM/yyyy hh:mm:ss")

                    MyList.Add(NewItem)
                    MyCount += 1
                Catch ex As Exception : End Try
            Next
            RaiseEvent StatusButtons(IIf(MyMt.nextPageToken Is Nothing, False, True), IIf(MyMt.prevPageToken Is Nothing, False, True))
            LastNextPageToken = IIf(MyMt.nextPageToken Is Nothing, Nothing, MyMt.nextPageToken)
            LastPrevPageToken = IIf(MyMt.prevPageToken Is Nothing, Nothing, MyMt.prevPageToken)
        Catch ex As Exception : End Try
        Return MyList
    End Function

    Public Function Suggestions(ByVal Query As String) As List(Of String)
        Dim NewList As New List(Of String)
        Try
            Dim Result As String = New WebClient() With {.Proxy = Nothing, .Encoding = Encoding.UTF8}.DownloadString("http://suggestqueries.google.com/complete/search?client=firefox&ds=yt&q=" & URLEncode(Query)).Replace("[""" & Query & """,[""", "").Replace("""]]", "")
            For Each MyItem In Split(Result, """,""")
                NewList.Add(MyItem)
            Next
        Catch ex As Exception : End Try
        Return NewList
    End Function
    Public Function URLEncode(ByVal StringToEncode As String, Optional ByVal UsePlusRatherThanHexForSpace As Boolean = False) As String

        Dim TempAns As String
        Dim CurChr As Integer
        CurChr = 1
        Do Until CurChr - 1 = Len(StringToEncode)
            Select Case Asc(Mid(StringToEncode, CurChr, 1))
                Case 48 To 57, 65 To 90, 97 To 122
                    TempAns = TempAns & Mid(StringToEncode, CurChr, 1)
                Case 32
                    If UsePlusRatherThanHexForSpace = True Then
                        TempAns = TempAns & "+"
                    Else
                        TempAns = TempAns & "%" & Hex(32)
                    End If
                Case Else
                    TempAns = TempAns & "%" & _
                         Format(Hex(Asc(Mid(StringToEncode, _
                         CurChr, 1))), "00")
            End Select

            CurChr = CurChr + 1
        Loop

        URLEncode = TempAns
    End Function

    Public Function URLDecode(ByVal StringToDecode As String) As String

        Dim TempAns As String
        Dim CurChr As Integer

        CurChr = 1

        Do Until CurChr - 1 = Len(StringToDecode)
            Select Case Mid(StringToDecode, CurChr, 1)
                Case "+"
                    TempAns = TempAns & " "
                Case "%"
                    TempAns = TempAns & Chr(Val("&h" & _
                       Mid(StringToDecode, CurChr + 1, 2)))
                    CurChr = CurChr + 2
                Case Else
                    TempAns = TempAns & Mid(StringToDecode, CurChr, 1)
            End Select

            CurChr = CurChr + 1
        Loop

        URLDecode = TempAns
    End Function

    ' URLDecode function in Perl for reference
    ' both VB and Perl versions must return same
    '
    ' sub urldecode{
    '  local($val)=@_;
    '  $val=~s/\+/ /g;
    '  $val=~s/%([0-9A-H]{2})/pack('C',hex($1))/ge;
    '  return $val;
    ' }
End Class


#Region "JSON"
Public Class JsVideo
    Public Property nextPageToken As String
    Public Property prevPageToken As String
    Public Property pageInfo As JsPageInfo
    Public Property items As New List(Of JsItems)
End Class

Public Class JsPageInfo
    Public Property totalResults As String
    Public Property resultsPerPage As String
End Class

Public Class JsItems
    Public Property id As JsID
    Public Property snippet As JsSnippet
End Class

Public Class JsID
    Public Property videoId As String
End Class

Public Class JsSnippet
    Public Property publishedAt As DateTime
    Public Property channelId As String
    Public Property title As String
    Public Property thumbnails As JsThumbnails
    Public Property channelTitle As String
End Class

Public Class JsThumbnails
    Public Property [default] As JsDefault
End Class

Public Class JsDefault
    Public Property url As String
End Class

#Region "JSON INFO"
Public Class JsInfo
    Public Property items As List(Of JsContentDetails)
End Class

Public Class JsContentDetails
    Public Property contentDetails As JsDuration
    Public Property statistics As JsStatistics
End Class

Public Class JsDuration
    Public Property duration As String
End Class

Public Class JsStatistics
    Public Property viewCount As String
    Public Property likeCount As String
    Public Property dislikeCount As String
    Public Property favoriteCount As String
    Public Property commentCount As String
End Class
#End Region

#End Region