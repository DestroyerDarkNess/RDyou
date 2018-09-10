Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Xml

Module SynPublic

    Public Function ToNumber(ByVal Count As String) As String
        Return FormatNumber(Count, 0, TriState.True, TriState.True, TriState.True)
    End Function

    Public Function ToBitmap(ByVal URL As String) As Bitmap
        Dim MyBitmap As Bitmap
        Try
            MyBitmap = ToThumbnail(Bitmap.FromStream(New WebClient() With {.Proxy = Nothing}.OpenRead(URL)))
        Catch ex As Exception
            MyBitmap = ToThumbnail(Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("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"))))
        End Try
        Return MyBitmap
    End Function

    Public Function ToThumbnail(ByVal MyBitmap As Bitmap) As Bitmap
        Try
            Dim original As Bitmap = MyBitmap
            Dim modificada As Bitmap = New Bitmap(93, 70)
            modificada = DirectCast(original.GetThumbnailImage(modificada.Width, modificada.Height, Nothing, IntPtr.Zero), Bitmap)
            Return modificada
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#Region "WINDOWS API"
    Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Public Sub SetSubText(ByVal SubText As String, ByVal TextBox As TextBox)
        SendMessage(TextBox.Handle, EM_SETCUEBANNER, 1, SubText)
    End Sub
#End Region

    Public Function FormatDuration(ByVal Segundos As String, Optional ByVal YoutubeFormat As Boolean = False) As String
        If YoutubeFormat = False Then
            Dim iSpan As TimeSpan = TimeSpan.FromSeconds(Segundos)
            Return IIf(iSpan.Hours.ToString.PadLeft(2, "0"c).Equals("00"), iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c), iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c))
        Else
            Dim iSpan As TimeSpan = XmlConvert.ToTimeSpan(Segundos) 'YOUTUBE
            Return IIf(iSpan.Hours.ToString.PadLeft(2, "0"c).Equals("00"), iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c), iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c))
        End If
    End Function

    Public Function FileSize(ByVal Tamanho As Double, Optional ByVal ShowName As Boolean = True) As String
        Dim Tipos As String() = {"Bytes", "KB", "MB", "GB"}
        Dim TamanhoDouble As Double = Tamanho
        Dim CSA As Integer = 0
        While TamanhoDouble >= 1024 AndAlso CSA + 1 < Tipos.Length
            CSA += 1
            TamanhoDouble = TamanhoDouble / 1024
        End While
        Return IIf(ShowName.Equals(True), [String].Format("{0:0.##} {1}", TamanhoDouble, Tipos(CSA)), [String].Format("{0:0.##}", TamanhoDouble))
    End Function

    Public Function ToName(ByVal Name As String) As String
        Return Name.Replace("\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("""", "").Replace("<", "").Replace(">", "").Replace("|", "")
    End Function


End Module
