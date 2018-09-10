Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.IO

#Region "LISTBOX"
Public Class SynListBox
    Inherits ListBox

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        ItemHeight = 80
        BackColor = Color.FromArgb(33, 33, 33)
        BorderStyle = Windows.Forms.BorderStyle.None
    End Sub

    Private MGView As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAsAAAALCAYAAACprHcmAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAA5SURBVHjaYvTJLGQgBLZM7//PwMDAwMRAAmBCNwFmCkHFxID/DAwM/6Fux8sm383DUTEAAAD//wMAA70VL3/mtnsAAAAASUVORK5CYII=")))
    Private MGLike As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAA0AAAANCAYAAABy6+R8AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAGRSURBVHjajFA9axRRFD33403ezM4s624gIEElEUmXkMLeRmxsraz9E1ZpUtpY2Asigp29RZo0onYigqQMaGLYmGzm7btzLXYNfkJOeT649xxZGi3C4ShjiaCKS4MBYowY9husXlnG/tcDsMgLgNaIaIeIoPgPmBkqAgCPWPSedan5qf0WcvjMTITx8cnNszTdYg133B0A3p8bl0aLqMoS/bpB0+thOBiE0XD4EMSnEHVdiB6raldEKiKaXRLmQESZmTxoXPny7fAJi97WogDcAXcw8AbwGwA+ATihqqpet20bmfiBiNzN7tt/9jPLYOIJiD665V09bdtbMIPBrk1zdi2Kv0YRDQBQAtgIUqyyMI9nEk2Y2f455fxNB9C26THjgnB3KBMIeHXhEBHDu+6tKL9jM+vP+RJACSJgPu0vCZhlEPHLum5a7TfNs7PJJKSUPrh3PTf7bHm6whrAIuddVOS4DPqciaBNXd/3rkNKCe6+Z3m6c/3q8uWDo/Ha0fj7OjFvdJ1tFjE+jQtxL5vhxwArhpZqkgK/PwAAAABJRU5ErkJggg==")))
    Private MGDislike As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAA0AAAANCAYAAABy6+R8AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAGLSURBVHjajJG9ahVRFIXXOufMzP3JzP1z4g+KkiaVkIiFD2BjYSeCD2FjKYKVFhZa+Ay+gzaWFhcrSxEfIWCSy83MOWdtiyTEoEIWrGbBYu/9bX9pNkezsYFs9jbl/MH5cB/A7dmk3rx+pS33fu0DwBqA1XWNtm3BxXyOHOOtVdd/E1nTDCChnKEU4UPxUzk9N7OvZVm+HgyHMcgM65iepJxrHwIAAGZwzsFVAwDYorRtplXf94/7lOAODw8qMz3yPgBmOCez02x9Ynjv911O2qVzd8yEi8oZ8DDJQPLipaoqnxIAyGP/Q5I8YEMAyFLjJd0AWUCaSLlwzv1VKkP4THJJcndYVT9wPIRj793OaDR6H8rKQllZqAbmQmEgP7Xzxda0aTAejXit3SxOGGMF8LuAuyCRUgKk9WI2fWXSm6PuKJIOZmZZiuEUgKQXMaZ7ZoZ2OvnYd/3LEMLSkej6Dp5na/95wA5JKMV3N69eftDU42VKCZJAnAcUcBZ8UU4HAJ6lnCH9/2+/BwCcL7OnzeE1BQAAAABJRU5ErkJggg==")))
    Private MGFavorite As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAA0AAAANCAYAAABy6+R8AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAEWSURBVHjajJIxSMNAFIa/aIKhdFckkFkIokshTnFwEFx06KCQmqEFJVAcdHBw7OCWxaVDcHHo5ObYrYEsLSW7uDk6lZREcLkrWi/o2949vuPe9592dHGFqvrmIPZTq7O2vVcsz1ZUQHd/pwa0Yt4t1VwJOcntOUBRY+PfEHAGYDplRzXU59ORcdO9NOTBVnS3ToNN0baAQDwXgPvoodBeD2zXdMonwObvessz/VST9vrmIBY3V9WjtLnYqZ03AyCsAMJ23gyk/h8i8kwfq4jPVH+ptFdla7VRHiqh+XRkAJ7sPxLjZDmCX5BI3waSzO3Vr3ePnzO3VwcSwP2ufQGJ9EM/tbxoOJkBRMPJzE8tDwjlLwH4GgCen0+0kFcLxwAAAABJRU5ErkJggg==")))
    Private MGComment As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAA4AAAALCAYAAABPhbxiAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAGOSURBVHjahE9NK0RhGD3P896GcU234RqSMZHP0WAx1KCwYmE5/AIWVrKwkij+gLIkf2CyommSNAsSs5CFj0QNJSGaxSB37vtamNGl5KxOz3PO6RwamZwGAPTXV89bljWjlDrLZJ+jpy8yjTymBjtLlnePX+EAA0DQy4FcLrdARDozh70ecw4Auhtb2nv8Fdepq7tspMY8Cno58MNYajYZzjQppQEA4u1pjYjqAMAZ+G08vDw/AbAGAET0ZLvNxTxv/RXYUeBagezdPIynk4npKq/nvai9xwIApVSciKIFjW1/JApcNHVFkE4mPMN9kYlgW/NwoKFhwG/o5Vd7O5cHh6mttlCoEYCbiDaS8c0ZrdIvAYCWlhZHmcU6EemOSjElrBXkhE8IbUhKadj2xwW7aPsgnUkCgOY0KSkhlRwDCR9L1xaJrzszg7kYUJiN1JipTPY5quW3ZAFAAXGQ8AmmFfwBZg4bellM2799LHU+emt9q/gHzBzWfh8t6/1eCFeKiModQk9+uxtfFfXPAQBVdottoHg6JQAAAABJRU5ErkJggg==")))
    Private MGBackground As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAABQAAAANCAYAAACpUE5eAAAACXBIWXMAACcQAAAnEAGUaVEZAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAAkSURBVHjaYmRgYJjJQEXAxEBlMGrgqIGjBg6IgQAAAAD//wMArKUAszMjWdUAAAAASUVORK5CYII=")))
    Private MGPublishedAt As Bitmap = Bitmap.FromStream(New MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAwAAAAMCAYAAABWdVznAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAIGNIUk0AAHolAACAgwAA+f8AAIDpAAB1MAAA6mAAADqYAAAXb5JfxUYAAAGhSURBVHjalFIxaFNhGLzv+5JWqC/9HH54Q4ktVGmDqUMRcXfzDYJgRzGTb5E83IWCu9msHSqZpOLUKl1ECZQIdQqKbYUK6vhQXpOmxmD/z8UnRXDwxuPuhrujKE6Q4/lSo0bMN/zR0XkAYJGOed+8cqu+8kcUxQlUNWSRFgADYCfHxt4T0fJvLmORlqqGUZyAAaDb662a91N5yEG/P2tm1wlYV9WZXAMAIKIagExVQwD3CiOjRkTLzrlrUZwgihNUK5WAiD4TUU1YpGFmTy/fjNfOXrj08uvH3XeDwcBPlctP9j/tjerk9FAnp4cf3rweZ5GrYmYN59zDicrcNgBMVOa2z8xfbG9urN/9tt/d2N1qB6dH/KvuwXfuHx7eZvwDRHzi5/AHzPydF+2tPSrIOAAwi3TSNK3+bTg3O7NIRF8AwMxW0jStskiHzfsmgPrm40fhcUN4KhiYWQnAoqouAaib901EcQIWaR3vOt+GiGr5RizSiuIEBQAoBcFCt9dbzbJs59mD+w3n3NtisQgzK2dZtsMinVIQLAAA/e81fg0AI06xxG1cR+MAAAAASUVORK5CYII=")))

    Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
        If ItemList.Count <> 0 Then
            e.DrawBackground()
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(New SolidBrush(SelectedBackColor), e.Bounds)
            Else
                Dim GD As New LinearGradientBrush(New Rectangle(0, e.Bounds.Top, e.Bounds.Width, 10), SelectedBackColor, Color.Transparent, 90.0!)
                e.Graphics.FillRectangle(GD, GD.Rectangle)
                GD = New LinearGradientBrush(New Rectangle(0, e.Bounds.Top + e.Bounds.Height - 10, e.Bounds.Width, 10), Color.Transparent, SelectedBackColor, 90.0!)
                e.Graphics.FillRectangle(GD, GD.Rectangle)
            End If

            e.Graphics.DrawRectangle(New Pen(Color.FromArgb(158, 158, 158), 1), 4, e.Bounds.Top + 4, 96, 73)

            If ItemList(e.Index).Thumbnail IsNot Nothing Then
                e.Graphics.DrawImage(ItemList(e.Index).Thumbnail, 5, e.Bounds.Top + 5, 93, 70)
            End If

            If ItemList(e.Index).Duration IsNot Nothing Then 'DURAÇÃO
                Dim txtSize As Size = GetTextSize(ItemList(e.Index).Duration, CanalFont)
                e.Graphics.DrawImage(MGBackground, 96 - txtSize.Width, e.Bounds.Top + 60, txtSize.Width + 3, 15)
                e.Graphics.DrawString(ItemList(e.Index).Duration, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 99 - txtSize.Width, e.Bounds.Top + 60)
            End If

            If ItemList(e.Index).Titulo IsNot Nothing Then
                e.Graphics.DrawString(ItemList(e.Index).Titulo, e.Font, New SolidBrush(Color.FromArgb(224, 224, 224)), 110, e.Bounds.Top + 13)
            End If

            If ItemList(e.Index).Canal IsNot Nothing Then
                e.Graphics.DrawString(ItemList(e.Index).Canal, CanalFont, New SolidBrush(Color.FromArgb(79, 195, 247)), 110, e.Bounds.Top + 30)
            End If

            e.Graphics.DrawImage(MGView, 112, e.Bounds.Top + 50, 13, 13)

            If ItemList(e.Index).ViewCount IsNot Nothing Then 'VISUALIZAÇÃO
                e.Graphics.DrawString(ItemList(e.Index).ViewCount, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 127, e.Bounds.Top + 50)
            End If

            Dim TextSize As Size = GetTextSize(ItemList(e.Index).ViewCount, CanalFont)

            e.Graphics.DrawImage(MGLike, 125 + TextSize.Width, e.Bounds.Top + 50, 13, 13)

            If ItemList(e.Index).LikeCount IsNot Nothing Then 'LIKE 
                ItemList(e.Index).LikeCount = IIf(ItemList(e.Index).LikeCount.Length.Equals(0), "-", ItemList(e.Index).LikeCount)
                e.Graphics.DrawString(ItemList(e.Index).LikeCount, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 140 + TextSize.Width, e.Bounds.Top + 50)
            End If

            Dim TextSize1 As Size = GetTextSize(ItemList(e.Index).LikeCount, CanalFont)

            e.Graphics.DrawImage(MGDislike, 138 + TextSize.Width + TextSize1.Width, e.Bounds.Top + 50, 13, 13)

            If ItemList(e.Index).DislikeCount IsNot Nothing Then 'DISLIKE
                ItemList(e.Index).DislikeCount = IIf(ItemList(e.Index).DislikeCount.Length.Equals(0), "-", ItemList(e.Index).DislikeCount)
                e.Graphics.DrawString(ItemList(e.Index).DislikeCount, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 154 + TextSize.Width + TextSize1.Width, e.Bounds.Top + 50)
            End If

            Dim TextSize2 As Size = GetTextSize(ItemList(e.Index).DislikeCount, CanalFont)

            e.Graphics.DrawImage(MGFavorite, 151 + TextSize.Width + TextSize1.Width + TextSize2.Width, e.Bounds.Top + 50, 13, 13)

            If ItemList(e.Index).FavoriteCount IsNot Nothing Then 'FOVORITO
                e.Graphics.DrawString(ItemList(e.Index).FavoriteCount, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 165 + TextSize.Width + TextSize1.Width + TextSize2.Width, e.Bounds.Top + 50)
            End If

            Dim TextSize3 As Size = GetTextSize(ItemList(e.Index).FavoriteCount, CanalFont)

            e.Graphics.DrawImage(MGComment, 163 + TextSize.Width + TextSize1.Width + TextSize2.Width + TextSize3.Width, e.Bounds.Top + 50, 13, 13)

            If ItemList(e.Index).CommentCount IsNot Nothing Then 'COMENTÁRIOS
                e.Graphics.DrawString(ItemList(e.Index).CommentCount, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 178 + TextSize.Width + TextSize1.Width + TextSize2.Width + TextSize3.Width, e.Bounds.Top + 50)
            End If

            Dim TextSize4 As Size = GetTextSize(ItemList(e.Index).CommentCount, CanalFont)

            e.Graphics.DrawImage(MGPublishedAt, 176 + TextSize.Width + TextSize1.Width + TextSize2.Width + TextSize3.Width + TextSize4.Width, e.Bounds.Top + 51, 13, 13)

            If ItemList(e.Index).PublishedAt IsNot Nothing Then 'PUBLICADO
                e.Graphics.DrawString(ItemList(e.Index).PublishedAt, CanalFont, New SolidBrush(Color.FromArgb(158, 158, 158)), 192 + TextSize.Width + TextSize1.Width + TextSize2.Width + TextSize3.Width + TextSize4.Width, e.Bounds.Top + 50)
            End If

            e.DrawFocusRectangle()
        End If
        MyBase.OnDrawItem(e)
    End Sub

    Private Function GetTextSize(ByVal Text As String, ByVal Font As Font) As Size
        Return TextRenderer.MeasureText(Text, Font)
    End Function

    Public Sub AddVideo(ByVal MyItem As ListBoxItem)
        ItemList.Add(MyItem)
        Items.Add(MyItem)
    End Sub

    Public Sub VideoClean()
        ItemList.Clear()
        Items.Clear()
    End Sub

    Public Property SelectedBackColor As Color = Color.FromArgb(66, 66, 66)

    Private ItemList As New List(Of ListBoxItem)

    Public Property CanalFont As New Font("Arial", 8, FontStyle.Bold)
    Public Property DescricaoForeColor As Color = Color.FromArgb(118, 118, 118)
    Public Property CanalForeColor As Color = Color.FromArgb(118, 118, 118)

#Region "OCUTAR"
    <Browsable(False)> _
    Public Shadows Property BorderStyle As BorderStyle
        Get
            Return MyBase.BorderStyle
        End Get
        Set(ByVal value As BorderStyle)
            MyBase.BorderStyle = value
        End Set
    End Property
    <Browsable(False)> _
    Public Shadows Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
        End Set
    End Property
    <Browsable(False)> _
    Public Shadows Property ItemHeight As Integer
        Get
            Return MyBase.ItemHeight
        End Get
        Set(ByVal value As Integer)
            MyBase.ItemHeight = value
        End Set
    End Property
#End Region

End Class

Public Class ListBoxItem
    Public Property VideoURL As String
    Public Property VideoEmbed As String
    Public Property ChannelURL As String
    Public Property Thumbnail As Bitmap
    Public Property Titulo As String
    Public Property Canal As String
    Public Property VideoID As String

    Public Property Duration As String
    Public Property ViewCount As String
    Public Property LikeCount As String
    Public Property DislikeCount As String
    Public Property FavoriteCount As String
    Public Property CommentCount As String
    Public Property PublishedAt As String
End Class

#End Region

Public Class SynTrack
    Inherits Control

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetDefaults()
    End Sub

    Private Sub SetDefaults()
        Me.Orientation = Windows.Forms.Orientation.Horizontal
        Me.SmallChange = 1
        Me.Maximum = 10
        Me.Minimum = 0
        Me.ValueLeft = 0
        Me.ValueRight = 7
    End Sub

#Region " Private Fields "

    Private leftThumbState As VisualStyles.TrackBarThumbState
    Private rightThumbState As VisualStyles.TrackBarThumbState

    Private draggingLeft, draggingRight As Boolean
#End Region

#Region " Enums "

    Public Enum Thumbs
        None = 0
        Left = 1
        Right = 2
    End Enum

#End Region

#Region " Properties "

    Private _SelectedThumb As Thumbs
    ''' <summary>
    ''' Gets the thumb that had focus last.
    ''' </summary>
    ''' <returns>The thumb that had focus last.</returns>
    <Description("The thumb that had focus last.")> _
    Public Property SelectedThumb() As Thumbs
        Get
            Return _SelectedThumb
        End Get
        Private Set(ByVal value As Thumbs)
            _SelectedThumb = value
        End Set
    End Property

    Private _ValueLeft As Integer
    ''' <summary>
    ''' Gets or sets the position of the left slider.
    ''' </summary>
    ''' <returns>The position of the left slider.</returns>
    <Description("The position of the left slider.")> _
    Public Property ValueLeft() As Integer
        Get
            Return _ValueLeft
        End Get
        Set(ByVal value As Integer)
            If value < Me.Minimum OrElse value > Me.Maximum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueLeft'. 'ValueLeft' should be between 'Minimum' and 'Maximum'.", value.ToString()), "ValueLeft")
            End If
            If value > Me.ValueRight Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueLeft'. 'ValueLeft' should be less than or equal to 'ValueRight'.", value.ToString()), "ValueLeft")
            End If
            _ValueLeft = value

            Me.OnValueChanged(EventArgs.Empty)
            Me.OnLeftValueChanged(EventArgs.Empty)

            Me.Invalidate()
        End Set
    End Property

    Private _ValueRight As Integer
    ''' <summary>
    ''' Gets or sets the position of the right slider.
    ''' </summary>
    ''' <returns>The position of the right slider.</returns>
    <Description("The position of the right slider.")> _
    Public Property ValueRight() As Integer
        Get
            Return _ValueRight
        End Get
        Set(ByVal value As Integer)
            If value < Me.Minimum OrElse value > Me.Maximum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueRight'. 'ValueRight' should be between 'Minimum' and 'Maximum'.", value.ToString()), "ValueRight")
            End If
            If value < Me.ValueLeft Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'ValueRight'. 'ValueRight' should be greater than or equal to 'ValueLeft'.", value.ToString()), "ValueLeft")
            End If
            _ValueRight = value

            Me.OnValueChanged(EventArgs.Empty)
            Me.OnRightValueChanged(EventArgs.Empty)

            Me.Invalidate()
        End Set
    End Property

    Private _Minimum As Integer
    ''' <summary>
    ''' Gets or sets the minimum value.
    ''' </summary>
    ''' <returns>The minimum value.</returns>
    <Description("The minimum value.")> _
    Public Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            If value >= Me.Maximum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'Minimum'. 'Minimum' should be less than 'Maximum'.", value.ToString()), "Minimum")
            End If
            _Minimum = value
            Me.Invalidate()
        End Set
    End Property

    Private _Maximum As Integer
    ''' <summary>
    ''' Gets or sets the maximum value.
    ''' </summary>
    ''' <returns>The maximum value.</returns>
    <Description("The maximum value.")> _
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value <= Me.Minimum Then
                Throw New ArgumentException(String.Format("Value of '{0}' is not valid for 'Maximum'. 'Maximum' should be greater than 'Minimum'.", value.ToString()), "Maximum")
            End If
            _Maximum = value
            Me.Invalidate()
        End Set
    End Property

    Private _Orientation As Orientation
    ''' <summary>
    ''' Gets or sets the orientation of the control.
    ''' </summary>
    ''' <returns>The orientation of the control.</returns>
    <Description("The orientation of the control.")> _
    Public Property Orientation() As Orientation
        Get
            Return _Orientation
        End Get
        Set(ByVal value As Orientation)
            _Orientation = value
        End Set
    End Property

    Private _SmallChange As Integer
    ''' <summary>
    ''' Gets or sets the amount of positions the closest slider moves when the control is clicked.
    ''' </summary>
    ''' <returns>The amount of positions the closest slider moves when the control is clicked.</returns>
    <Description("The amount of positions the closest slider moves when the control is clicked.")> _
    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            _SmallChange = value
        End Set
    End Property

    Private ReadOnly Property RelativeValueLeft As Double
        Get
            Dim diff = Me.Maximum - Me.Minimum
            Return If(diff = 0, Me.ValueLeft, Me.ValueLeft / diff)
        End Get
    End Property

    Private ReadOnly Property RelativeValueRight As Double
        Get
            Dim diff = Me.Maximum - Me.Minimum
            Return If(diff = 0, Me.ValueLeft, Me.ValueRight / diff)
        End Get
    End Property

#End Region

#Region " Methods "

    Public Sub IncrementLeft()
        Dim newValue = Math.Min(Me.ValueLeft + 1, Me.Maximum)
        If Me.IsValidValueLeft(newValue) Then
            Me.ValueLeft = newValue
        End If
        Me.Invalidate()
    End Sub

    Public Sub IncrementRight()
        Dim newValue = Math.Min(Me.ValueRight + 1, Me.Maximum)
        If Me.IsValidValueRight(newValue) Then
            Me.ValueRight = newValue
        End If
        Me.Invalidate()
    End Sub

    Public Sub DecrementLeft()
        Dim newValue = Math.Max(Me.ValueLeft - 1, Me.Minimum)
        If Me.IsValidValueLeft(newValue) Then
            Me.ValueLeft = newValue
        End If
        Me.Invalidate()
    End Sub

    Public Sub DecrementRight()
        Dim newValue = Math.Max(Me.ValueRight - 1, Me.Minimum)
        If Me.IsValidValueRight(newValue) Then
            Me.ValueRight = newValue
        End If
        Me.Invalidate()
    End Sub

    Private Function IsValidValueLeft(ByVal value As Integer) As Boolean
        Return (value >= Me.Minimum AndAlso value <= Me.Maximum AndAlso value < Me.ValueRight)
    End Function

    Private Function IsValidValueRight(ByVal value As Integer) As Boolean
        Return (value >= Me.Minimum AndAlso value <= Me.Maximum AndAlso value > Me.ValueLeft)
    End Function

    Private Function GetLeftThumbRectangle(Optional ByVal g As Graphics = Nothing) As Rectangle
        Dim shouldDispose = (g Is Nothing)
        If shouldDispose Then g = Me.CreateGraphics()

        Dim rect = Me.GetThumbRectangle(Me.RelativeValueLeft, g)
        If shouldDispose Then g.Dispose()

        Return rect
    End Function

    Private Function GetRightThumbRectangle(Optional ByVal g As Graphics = Nothing) As Rectangle
        Dim shouldDispose = (g Is Nothing)
        If shouldDispose Then g = Me.CreateGraphics()

        Dim rect = Me.GetThumbRectangle(Me.RelativeValueRight, g)
        If shouldDispose Then g.Dispose()

        Return rect
    End Function

    Private Function GetThumbRectangle(ByVal relativeValue As Double, ByVal g As Graphics) As Rectangle
        Dim size = TrackBarRenderer.GetBottomPointingThumbSize(g, VisualStyles.TrackBarThumbState.Normal)
        Dim border = CInt(size.Width / 2)
        Dim w = Me.GetTrackRectangle(border).Width
        Dim x = CInt(Math.Abs(Me.Minimum) / (Me.Maximum - Me.Minimum) * w + relativeValue * w)

        Dim y = CInt((Me.Height - size.Height) / 2)
        Return New Rectangle(New Point(x, y), size)
    End Function

    Private Function GetTrackRectangle(ByVal border As Integer) As Rectangle
        'TODO: Select Case for hor/ver
        Return New Rectangle(border, CInt(Me.Height / 2) - 3, Me.Width - 2 * border - 1, 4)
    End Function

    Private Function GetClosestSlider(ByVal point As Point) As Thumbs
        Dim leftThumbRect = Me.GetLeftThumbRectangle()
        Dim rightThumbRect = Me.GetRightThumbRectangle()
        If Me.Orientation = Windows.Forms.Orientation.Horizontal Then
            If Math.Abs(leftThumbRect.X - point.X) > Math.Abs(rightThumbRect.X - point.X) _
            AndAlso Math.Abs(leftThumbRect.Right - point.X) > Math.Abs(rightThumbRect.Right - point.X) Then
                Return Thumbs.Right
            Else
                Return Thumbs.Left
            End If
        Else
            If Math.Abs(leftThumbRect.Y - point.Y) > Math.Abs(rightThumbRect.Y - point.Y) _
            AndAlso Math.Abs(leftThumbRect.Bottom - point.Y) > Math.Abs(rightThumbRect.Bottom - point.Y) Then
                Return Thumbs.Right
            Else
                Return Thumbs.Left
            End If
        End If
    End Function

    Private Sub SetThumbState(ByVal location As Point, ByVal newState As VisualStyles.TrackBarThumbState)
        Dim leftThumbRect = Me.GetLeftThumbRectangle()
        Dim rightThumbRect = Me.GetRightThumbRectangle()

        If leftThumbRect.Contains(location) Then
            leftThumbState = newState
        Else
            If Me.SelectedThumb = Thumbs.Left Then
                leftThumbState = VisualStyles.TrackBarThumbState.Hot
            Else
                leftThumbState = VisualStyles.TrackBarThumbState.Normal
            End If
        End If

        If rightThumbRect.Contains(location) Then
            rightThumbState = newState
        Else
            If Me.SelectedThumb = Thumbs.Right Then
                rightThumbState = VisualStyles.TrackBarThumbState.Hot
            Else
                rightThumbState = VisualStyles.TrackBarThumbState.Normal
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        On Error Resume Next
        Me.SetThumbState(e.Location, VisualStyles.TrackBarThumbState.Hot)

        Dim offset = CInt(e.Location.X / (Me.Width) * (Me.Maximum - Me.Minimum))
        Dim newValue = Me.Minimum + offset
        If draggingLeft Then
            If Me.IsValidValueLeft(newValue) Then Me.ValueLeft = newValue
        ElseIf draggingRight Then
            If Me.IsValidValueRight(newValue) Then Me.ValueRight = newValue
        End If

        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Me.Focus()
        Me.SetThumbState(e.Location, VisualStyles.TrackBarThumbState.Pressed)

        draggingLeft = (leftThumbState = VisualStyles.TrackBarThumbState.Pressed)
        If Not draggingLeft Then draggingRight = (rightThumbState = VisualStyles.TrackBarThumbState.Pressed)

        If draggingLeft Then
            Me.SelectedThumb = Thumbs.Left
        ElseIf draggingRight Then
            Me.SelectedThumb = Thumbs.Right
        End If

        If Not draggingLeft AndAlso Not draggingRight Then
            If Me.GetClosestSlider(e.Location) = 1 Then
                If e.X < Me.GetLeftThumbRectangle().X Then
                    Me.DecrementLeft()
                Else
                    Me.IncrementLeft()
                End If
                Me.SelectedThumb = Thumbs.Left
            Else
                If e.X < Me.GetRightThumbRectangle().X Then
                    Me.DecrementRight()
                Else
                    Me.IncrementRight()
                End If
                Me.SelectedThumb = Thumbs.Right
            End If
        End If

        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        draggingLeft = False
        draggingRight = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseWheel(e)

        If e.Delta = 0 Then Return

        If Me.SelectedThumb = 1 Then
            If e.Delta > 0 Then
                Me.IncrementLeft()
            Else
                Me.DecrementLeft()
            End If
        ElseIf Me.SelectedThumb = 2 Then
            If e.Delta > 0 Then
                Me.IncrementRight()
            Else
                Me.DecrementRight()
            End If
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        ' Dim thumbSize = Me.GetThumbRectangle(0, e.Graphics).Size
        ' Dim trackRect = Me.GetTrackRectangle(CInt(thumbSize.Width / 2))
        '     Dim ticksRect = trackRect : ticksRect.Offset(0, 15)



        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(204, 204, 204)), 0, CInt(Height / 2 - 15 / 2), Width - 2, 15)
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(176, 129, 118)), GetLeftThumbRectangle(e.Graphics).X, CInt(Height / 2 - 15 / 2), GetRightThumbRectangle(e.Graphics).X - GetLeftThumbRectangle(e.Graphics).X, 15)
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(176, 68, 43)), GetLeftThumbRectangle(e.Graphics))
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(176, 68, 43)), GetRightThumbRectangle(e.Graphics))

        ' TrackBarRenderer.DrawVerticalTrack(e.Graphics, trackRect) 'LINHA
        ' TrackBarRenderer.DrawHorizontalTicks(e.Graphics, ticksRect, Me.Maximum - Me.Minimum + 1, VisualStyles.EdgeStyle.Etched) 'PONTINHOS
        'TrackBarRenderer.DrawBottomPointingThumb(e.Graphics, Me.GetLeftThumbRectangle(e.Graphics), leftThumbState)
        '  TrackBarRenderer.DrawBottomPointingThumb(e.Graphics, Me.GetRightThumbRectangle(e.Graphics), rightThumbState)
    End Sub

#End Region

#Region " Events "

    Public Event ValueChanged As EventHandler
    Public Event LeftValueChanged As EventHandler
    Public Event RightValueChanged As EventHandler

    Protected Overridable Sub OnValueChanged(ByVal e As EventArgs)
        RaiseEvent ValueChanged(Me, e)
    End Sub

    Protected Overridable Sub OnLeftValueChanged(ByVal e As EventArgs)
        RaiseEvent LeftValueChanged(Me, e)
    End Sub

    Protected Overridable Sub OnRightValueChanged(ByVal e As EventArgs)
        RaiseEvent RightValueChanged(Me, e)
    End Sub

#End Region

End Class

Public Class SynListView
    Inherits ListView
#Region "Interop-Defines"
    <DllImport("user32.dll")> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wPar As IntPtr, ByVal lPar As IntPtr) As IntPtr
    End Function

    ' ListView messages
    Private Const LVM_FIRST As Integer = &H1000
    Private Const LVM_GETCOLUMNORDERARRAY As Integer = (LVM_FIRST + 59)

    ' Windows Messages
    Private Const WM_PAINT As Integer = &HF
#End Region

    ''' <summary>
    ''' Structure to hold an embedded control's info
    ''' </summary>
    Private Structure EmbeddedControl
        Public Control As Control
        Public Column As Integer
        Public Row As Integer
        Public Dock As DockStyle
        Public Item As ListViewItem
    End Structure

    Private _embeddedControls As New ArrayList()

    Public Sub New()
    End Sub

    ''' <summary>
    ''' Retrieve the order in which columns appear
    ''' </summary>
    ''' <returns>Current display order of column indices</returns>
    Protected Function GetColumnOrder() As Integer()
        Dim lPar As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(GetType(Integer)) * Columns.Count)

        Dim res As IntPtr = SendMessage(Handle, LVM_GETCOLUMNORDERARRAY, New IntPtr(Columns.Count), lPar)
        If res.ToInt32() = 0 Then
            ' Something went wrong
            Marshal.FreeHGlobal(lPar)
            Return Nothing
        End If

        Dim order As Integer() = New Integer(Columns.Count - 1) {}
        Marshal.Copy(lPar, order, 0, Columns.Count)

        Marshal.FreeHGlobal(lPar)

        Return order
    End Function

    ''' <summary>
    ''' Retrieve the bounds of a ListViewSubItem
    ''' </summary>
    ''' <param name="Item">The Item containing the SubItem</param>
    ''' <param name="SubItem">Index of the SubItem</param>
    ''' <returns>Subitem's bounds</returns>
    Protected Function GetSubItemBounds(ByVal Item As ListViewItem, ByVal SubItem As Integer) As Rectangle
        Dim subItemRect As Rectangle = Rectangle.Empty

        If Item Is Nothing Then
            Throw New ArgumentNullException("Item")
        End If

        Dim order As Integer() = GetColumnOrder()
        If order Is Nothing Then
            ' No Columns
            Return subItemRect
        End If

        If SubItem >= order.Length Then
            Throw New IndexOutOfRangeException("SubItem " + SubItem + " out of range")
        End If

        ' Retrieve the bounds of the entire ListViewItem (all subitems)
        Dim lviBounds As Rectangle = Item.GetBounds(ItemBoundsPortion.Entire)
        Dim subItemX As Integer = lviBounds.Left

        ' Calculate the X position of the SubItem.
        ' Because the columns can be reordered we have to use Columns[order[i]] instead of Columns[i] !
        Dim col As ColumnHeader
        Dim i As Integer
        For i = 0 To order.Length - 1
            col = Me.Columns(order(i))
            If col.Index = SubItem Then
                Exit For
            End If
            subItemX += col.Width
        Next

        subItemRect = New Rectangle(subItemX, lviBounds.Top, Me.Columns(order(i)).Width, lviBounds.Height)

        Return subItemRect
    End Function

    ''' <summary>
    ''' Add a control to the ListView
    ''' </summary>
    ''' <param name="c">Control to be added</param>
    ''' <param name="col">Index of column</param>
    ''' <param name="row">Index of row</param>
    Public Sub AddEmbeddedControl(ByVal c As Control, ByVal col As Integer, ByVal row As Integer)
        AddEmbeddedControl(c, col, row, DockStyle.Fill)
    End Sub
    ''' <summary>
    ''' Add a control to the ListView
    ''' </summary>
    ''' <param name="c">Control to be added</param>
    ''' <param name="col">Index of column</param>
    ''' <param name="row">Index of row</param>
    ''' <param name="dock">Location and resize behavior of embedded control</param>
    Public Sub AddEmbeddedControl(ByVal c As Control, ByVal col As Integer, ByVal row As Integer, ByVal dock As DockStyle)
        If c Is Nothing Then
            Throw New ArgumentNullException()
        End If
        If col >= Columns.Count OrElse row >= Items.Count Then
            Throw New ArgumentOutOfRangeException()
        End If

        Dim ec As EmbeddedControl
        ec.Control = c
        ec.Column = col
        ec.Row = row
        ec.Dock = dock
        ec.Item = Items(row)

        _embeddedControls.Add(ec)

        ' Add a Click event handler to select the ListView row when an embedded control is clicked
        AddHandler c.Click, New EventHandler(AddressOf _embeddedControl_Click)

        Me.Controls.Add(c)
    End Sub

    ''' <summary>
    ''' Remove a control from the ListView
    ''' </summary>
    ''' <param name="c">Control to be removed</param>
    Public Sub RemoveEmbeddedControl(ByVal c As Control)
        If c Is Nothing Then
            Throw New ArgumentNullException()
        End If

        For i As Integer = 0 To _embeddedControls.Count - 1
            Dim ec As EmbeddedControl = CType(_embeddedControls(i), EmbeddedControl)
            If ec.Control Is c Then
                RemoveHandler c.Click, New EventHandler(AddressOf _embeddedControl_Click)
                Me.Controls.Remove(c)
                _embeddedControls.RemoveAt(i)
                Return
            End If
        Next
        Throw New Exception("Control not found!")
    End Sub

    ''' <summary>
    ''' Retrieve the control embedded at a given location
    ''' </summary>
    ''' <param name="col">Index of Column</param>
    ''' <param name="row">Index of Row</param>
    ''' <returns>Control found at given location or null if none assigned.</returns>
    Public Function GetEmbeddedControl(ByVal col As Integer, ByVal row As Integer) As Control
        For Each ec As EmbeddedControl In _embeddedControls
            If ec.Row = row AndAlso ec.Column = col Then
                Return ec.Control
            End If
        Next

        Return Nothing
    End Function

    <DefaultValue(View.LargeIcon)> _
    Public Shadows Property View() As View
        Get
            Return MyBase.View
        End Get
        Set(ByVal value As View)
            ' Embedded controls are rendered only when we're in Details mode
            For Each ec As EmbeddedControl In _embeddedControls
                ec.Control.Visible = (value = View.Details)
            Next

            MyBase.View = value
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case WM_PAINT
                If View <> View.Details Then
                    Exit Select
                End If

                ' Calculate the position of all embedded controls
                For Each ec As EmbeddedControl In _embeddedControls
                    Dim rc As Rectangle = Me.GetSubItemBounds(ec.Item, ec.Column)

                    If (Me.HeaderStyle <> ColumnHeaderStyle.None) AndAlso (rc.Top < Me.Font.Height) Then
                        ' Control overlaps ColumnHeader
                        ec.Control.Visible = False
                        Continue For
                    Else
                        ec.Control.Visible = True
                    End If

                    Select Case ec.Dock
                        Case DockStyle.Fill
                            Exit Select
                        Case DockStyle.Top
                            rc.Height = ec.Control.Height
                            Exit Select
                        Case DockStyle.Left
                            rc.Width = ec.Control.Width
                            Exit Select
                        Case DockStyle.Bottom
                            rc.Offset(0, rc.Height - ec.Control.Height)
                            rc.Height = ec.Control.Height
                            Exit Select
                        Case DockStyle.Right
                            rc.Offset(rc.Width - ec.Control.Width, 0)
                            rc.Width = ec.Control.Width
                            Exit Select
                        Case DockStyle.None
                            rc.Size = ec.Control.Size
                            Exit Select
                    End Select

                    ' Set embedded control's bounds
                    ec.Control.Bounds = rc
                Next
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub

    Private Sub _embeddedControl_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' When a control is clicked the ListViewItem holding it is selected
        For Each ec As EmbeddedControl In _embeddedControls
            If ec.Control Is DirectCast(sender, Control) Then
                Me.SelectedItems.Clear()
                ec.Item.Selected = True
            End If
        Next
    End Sub
End Class

Public Class SynButton
    Inherits Panel

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 8.25, FontStyle.Bold)
        Cursor = Cursors.Hand
        BackColor = Color.FromArgb(58, 151, 222)
        ForeColor = Color.Black
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.SmoothingMode = SmoothingMode.HighQuality
        G.Clear(BackColor)
        Select Case Status
            Case MyStatus.Hover
                G.DrawRectangle(New Pen(LineColor, LineWidth), 0, 0, Width - 1, Height - 1)
            Case MyStatus.Click
                G.FillRectangle(New SolidBrush(BackColorMouseClick), 0, 0, Width, Height)
        End Select
        G.DrawString(_Caption, Font, New SolidBrush(ForeColor), Width / 2, Height / 2, New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})

        MyBase.OnPaint(e)
    End Sub

    Private _Caption As String = "SynButton"
    Public Property Caption As String
        Get
            Return _Caption
        End Get
        Set(ByVal value As String)
            _Caption = value : Invalidate()
        End Set
    End Property

    Private Status As MyStatus = MyStatus.Leave
    Private Enum MyStatus
        Hover = 0
        Leave = 1
        Click = 2
    End Enum

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e) : Status = MyStatus.Hover : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e) : Status = MyStatus.Leave : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e) : Status = MyStatus.Click : Invalidate()
    End Sub

    Public Property LineColor As Color = Color.FromArgb(58, 79, 222)
    Public Property LineWidth As Integer = 1
    Public Property BackColorMouseClick As Color = Color.FromArgb(123, 185, 233)
End Class
