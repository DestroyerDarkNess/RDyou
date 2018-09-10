<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LinhaDireita As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CTX = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTXClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTXVideoURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTXChannelURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTXDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTXMyPlaylist = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSkin1 = New RadioSFYK.FormSkin()
        Me.FlatStickyButton5 = New RadioSFYK.FlatStickyButton()
        Me.FlatStickyButton4 = New RadioSFYK.FlatStickyButton()
        Me.FlatStickyButton3 = New RadioSFYK.FlatStickyButton()
        Me.FlatStickyButton2 = New RadioSFYK.FlatStickyButton()
        Me.FlatStickyButton1 = New RadioSFYK.FlatStickyButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatMini1 = New RadioSFYK.FlatMini()
        Me.FlatClose1 = New RadioSFYK.FlatClose()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FlatTabControl1 = New RadioSFYK.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listv = New System.Windows.Forms.ListView()
        Me.Definicion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CAL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PLoading = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SynVideos = New RadioSFYK.SynListBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FlatToggle3 = New RadioSFYK.FlatToggle()
        Me.FlatLabel3 = New RadioSFYK.FlatLabel()
        Me.FlatToggle2 = New RadioSFYK.FlatToggle()
        Me.FlatLabel2 = New RadioSFYK.FlatLabel()
        Me.FlatLabel1 = New RadioSFYK.FlatLabel()
        Me.FlatToggle1 = New RadioSFYK.FlatToggle()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        LinhaDireita = New System.Windows.Forms.Panel()
        Me.CTX.SuspendLayout()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.PLoading.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinhaDireita
        '
        LinhaDireita.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        LinhaDireita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        LinhaDireita.Location = New System.Drawing.Point(8, 50)
        LinhaDireita.Name = "LinhaDireita"
        LinhaDireita.Size = New System.Drawing.Size(869, 320)
        LinhaDireita.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CTX
        '
        Me.CTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTXClipboard, Me.CTXDownload, Me.CTXMyPlaylist})
        Me.CTX.Name = "CTX"
        Me.CTX.Size = New System.Drawing.Size(133, 70)
        '
        'CTXClipboard
        '
        Me.CTXClipboard.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTXVideoURL, Me.CTXChannelURL})
        Me.CTXClipboard.Image = CType(resources.GetObject("CTXClipboard.Image"), System.Drawing.Image)
        Me.CTXClipboard.Name = "CTXClipboard"
        Me.CTXClipboard.Size = New System.Drawing.Size(132, 22)
        Me.CTXClipboard.Text = "Clipboard"
        '
        'CTXVideoURL
        '
        Me.CTXVideoURL.Image = CType(resources.GetObject("CTXVideoURL.Image"), System.Drawing.Image)
        Me.CTXVideoURL.Name = "CTXVideoURL"
        Me.CTXVideoURL.Size = New System.Drawing.Size(142, 22)
        Me.CTXVideoURL.Text = "Video URL"
        '
        'CTXChannelURL
        '
        Me.CTXChannelURL.Image = CType(resources.GetObject("CTXChannelURL.Image"), System.Drawing.Image)
        Me.CTXChannelURL.Name = "CTXChannelURL"
        Me.CTXChannelURL.Size = New System.Drawing.Size(142, 22)
        Me.CTXChannelURL.Text = "Channel URL"
        '
        'CTXDownload
        '
        Me.CTXDownload.Image = CType(resources.GetObject("CTXDownload.Image"), System.Drawing.Image)
        Me.CTXDownload.Name = "CTXDownload"
        Me.CTXDownload.Size = New System.Drawing.Size(132, 22)
        Me.CTXDownload.Text = "View Video"
        '
        'CTXMyPlaylist
        '
        Me.CTXMyPlaylist.Enabled = False
        Me.CTXMyPlaylist.Image = CType(resources.GetObject("CTXMyPlaylist.Image"), System.Drawing.Image)
        Me.CTXMyPlaylist.Name = "CTXMyPlaylist"
        Me.CTXMyPlaylist.Size = New System.Drawing.Size(132, 22)
        Me.CTXMyPlaylist.Text = "My Playlist"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.DodgerBlue
        Me.FormSkin1.Controls.Add(Me.FlatStickyButton5)
        Me.FormSkin1.Controls.Add(Me.FlatStickyButton4)
        Me.FormSkin1.Controls.Add(Me.FlatStickyButton3)
        Me.FormSkin1.Controls.Add(Me.FlatStickyButton2)
        Me.FormSkin1.Controls.Add(Me.FlatStickyButton1)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.pbar)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.DodgerBlue
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(893, 535)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "       RDYou Music v1.0"
        '
        'FlatStickyButton5
        '
        Me.FlatStickyButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton5.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatStickyButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton5.Location = New System.Drawing.Point(727, 65)
        Me.FlatStickyButton5.Name = "FlatStickyButton5"
        Me.FlatStickyButton5.Rounded = False
        Me.FlatStickyButton5.Size = New System.Drawing.Size(157, 46)
        Me.FlatStickyButton5.TabIndex = 11
        Me.FlatStickyButton5.Text = "Donate"
        Me.FlatStickyButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton4
        '
        Me.FlatStickyButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton4.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatStickyButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton4.Location = New System.Drawing.Point(371, 65)
        Me.FlatStickyButton4.Name = "FlatStickyButton4"
        Me.FlatStickyButton4.Rounded = False
        Me.FlatStickyButton4.Size = New System.Drawing.Size(157, 46)
        Me.FlatStickyButton4.TabIndex = 10
        Me.FlatStickyButton4.Text = "Options"
        Me.FlatStickyButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton3
        '
        Me.FlatStickyButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton3.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatStickyButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton3.Location = New System.Drawing.Point(548, 65)
        Me.FlatStickyButton3.Name = "FlatStickyButton3"
        Me.FlatStickyButton3.Rounded = False
        Me.FlatStickyButton3.Size = New System.Drawing.Size(157, 46)
        Me.FlatStickyButton3.TabIndex = 8
        Me.FlatStickyButton3.Text = "About"
        Me.FlatStickyButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton2
        '
        Me.FlatStickyButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton2.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton2.Location = New System.Drawing.Point(192, 65)
        Me.FlatStickyButton2.Name = "FlatStickyButton2"
        Me.FlatStickyButton2.Rounded = False
        Me.FlatStickyButton2.Size = New System.Drawing.Size(157, 46)
        Me.FlatStickyButton2.TabIndex = 7
        Me.FlatStickyButton2.Text = "Youtube"
        Me.FlatStickyButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton1
        '
        Me.FlatStickyButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatStickyButton1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatStickyButton1.Location = New System.Drawing.Point(12, 65)
        Me.FlatStickyButton1.Name = "FlatStickyButton1"
        Me.FlatStickyButton1.Rounded = False
        Me.FlatStickyButton1.Size = New System.Drawing.Size(157, 46)
        Me.FlatStickyButton1.TabIndex = 6
        Me.FlatStickyButton1.Text = "Radio"
        Me.FlatStickyButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(851, 0)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(875, 0)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SpringGreen
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(0, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(893, 65)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Controls.Add(Me.TabPage4)
        Me.FlatTabControl1.Controls.Add(Me.TabPage5)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 65)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(890, 461)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.listv)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PictureBox6)
        Me.TabPage1.Controls.Add(Me.PictureBox7)
        Me.TabPage1.Controls.Add(Me.PictureBox5)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(882, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(3, 376)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(876, 34)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(551, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "The Synchronization Process can take several minutes!"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(847, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'listv
        '
        Me.listv.AllowColumnReorder = True
        Me.listv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Definicion, Me.CAL})
        Me.listv.FullRowSelect = True
        Me.listv.GridLines = True
        Me.listv.Location = New System.Drawing.Point(3, 54)
        Me.listv.MultiSelect = False
        Me.listv.Name = "listv"
        Me.listv.ShowItemToolTips = True
        Me.listv.Size = New System.Drawing.Size(876, 316)
        Me.listv.TabIndex = 12
        Me.listv.UseCompatibleStateImageBehavior = False
        Me.listv.View = System.Windows.Forms.View.Details
        '
        'Definicion
        '
        Me.Definicion.Text = "Radio Online SFYK"
        Me.Definicion.Width = 406
        '
        'CAL
        '
        Me.CAL.Text = "Qualification"
        Me.CAL.Width = 440
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Broadcast Stations"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Location = New System.Drawing.Point(723, 54)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(55, 46)
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Enabled = False
        Me.PictureBox7.Location = New System.Drawing.Point(723, 54)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Location = New System.Drawing.Point(723, 54)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Location = New System.Drawing.Point(693, 54)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PLoading)
        Me.TabPage2.Controls.Add(Me.lblResult)
        Me.TabPage2.Controls.Add(Me.btnPrevious)
        Me.TabPage2.Controls.Add(Me.btnNext)
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.SynVideos)
        Me.TabPage2.Controls.Add(LinhaDireita)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(882, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'PLoading
        '
        Me.PLoading.BackColor = System.Drawing.Color.White
        Me.PLoading.Controls.Add(Me.lblStatus)
        Me.PLoading.Location = New System.Drawing.Point(8, 50)
        Me.PLoading.Name = "PLoading"
        Me.PLoading.Size = New System.Drawing.Size(868, 320)
        Me.PLoading.TabIndex = 10
        Me.PLoading.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(98, 158)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(692, 23)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Searching videos..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResult.AutoEllipsis = True
        Me.lblResult.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(503, 387)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(198, 23)
        Me.lblResult.TabIndex = 14
        Me.lblResult.Text = "Copyright © 2018 All Rights Reserved"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnPrevious.Location = New System.Drawing.Point(720, 380)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 30)
        Me.btnPrevious.TabIndex = 13
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Enabled = False
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnNext.Location = New System.Drawing.Point(801, 380)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 30)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(67, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(717, 26)
        Me.txtSearch.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Location = New System.Drawing.Point(790, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SynVideos
        '
        Me.SynVideos.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SynVideos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SynVideos.CanalFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SynVideos.CanalForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.SynVideos.ContextMenuStrip = Me.CTX
        Me.SynVideos.DescricaoForeColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.SynVideos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SynVideos.FormattingEnabled = True
        Me.SynVideos.ItemHeight = 80
        Me.SynVideos.Location = New System.Drawing.Point(8, 50)
        Me.SynVideos.Name = "SynVideos"
        Me.SynVideos.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SynVideos.Size = New System.Drawing.Size(869, 320)
        Me.SynVideos.TabIndex = 15
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Location = New System.Drawing.Point(11, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.FlatToggle3)
        Me.TabPage3.Controls.Add(Me.FlatLabel3)
        Me.TabPage3.Controls.Add(Me.FlatToggle2)
        Me.TabPage3.Controls.Add(Me.FlatLabel2)
        Me.TabPage3.Controls.Add(Me.FlatLabel1)
        Me.TabPage3.Controls.Add(Me.FlatToggle1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(882, 413)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'FlatToggle3
        '
        Me.FlatToggle3.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle3.Checked = True
        Me.FlatToggle3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle3.Enabled = False
        Me.FlatToggle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle3.Location = New System.Drawing.Point(204, 174)
        Me.FlatToggle3.Name = "FlatToggle3"
        Me.FlatToggle3.Options = RadioSFYK.FlatToggle._Options.Style1
        Me.FlatToggle3.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle3.TabIndex = 5
        Me.FlatToggle3.Text = "FlatToggle3"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel3.Location = New System.Drawing.Point(17, 182)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(159, 17)
        Me.FlatLabel3.TabIndex = 4
        Me.FlatLabel3.Text = "EO Youtube Player Engine"
        '
        'FlatToggle2
        '
        Me.FlatToggle2.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle2.Checked = True
        Me.FlatToggle2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle2.Enabled = False
        Me.FlatToggle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle2.Location = New System.Drawing.Point(204, 101)
        Me.FlatToggle2.Name = "FlatToggle2"
        Me.FlatToggle2.Options = RadioSFYK.FlatToggle._Options.Style1
        Me.FlatToggle2.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle2.TabIndex = 3
        Me.FlatToggle2.Text = "FlatToggle2"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel2.Location = New System.Drawing.Point(17, 109)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(159, 17)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "RD MP3 Converter Engine"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FlatLabel1.Location = New System.Drawing.Point(17, 39)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(181, 17)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "Start RDYou at Windows Start"
        '
        'FlatToggle1
        '
        Me.FlatToggle1.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle1.Checked = True
        Me.FlatToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle1.Location = New System.Drawing.Point(204, 31)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Options = RadioSFYK.FlatToggle._Options.Style1
        Me.FlatToggle1.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle1.TabIndex = 0
        Me.FlatToggle1.Text = "FlatToggle1"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(882, 413)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(4, 44)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(882, 413)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(845, 56)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(39, 8)
        Me.pbar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 535)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RDYou Music"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CTX.ResumeLayout(False)
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.PLoading.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As RadioSFYK.FormSkin
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatMini1 As RadioSFYK.FlatMini
    Friend WithEvents FlatClose1 As RadioSFYK.FlatClose
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatStickyButton3 As RadioSFYK.FlatStickyButton
    Friend WithEvents FlatStickyButton2 As RadioSFYK.FlatStickyButton
    Friend WithEvents FlatStickyButton1 As RadioSFYK.FlatStickyButton
    Friend WithEvents FlatTabControl1 As RadioSFYK.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents listv As System.Windows.Forms.ListView
    Friend WithEvents Definicion As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CAL As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatStickyButton5 As RadioSFYK.FlatStickyButton
    Friend WithEvents FlatStickyButton4 As RadioSFYK.FlatStickyButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents PLoading As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents CTX As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CTXClipboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTXVideoURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTXChannelURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTXDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTXMyPlaylist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents SynVideos As RadioSFYK.SynListBox
    Friend WithEvents FlatToggle1 As RadioSFYK.FlatToggle
    Friend WithEvents FlatToggle3 As RadioSFYK.FlatToggle
    Friend WithEvents FlatLabel3 As RadioSFYK.FlatLabel
    Friend WithEvents FlatToggle2 As RadioSFYK.FlatToggle
    Friend WithEvents FlatLabel2 As RadioSFYK.FlatLabel
    Friend WithEvents FlatLabel1 As RadioSFYK.FlatLabel

End Class
