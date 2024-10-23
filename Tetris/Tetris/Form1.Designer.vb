<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        Enemy = New PictureBox()
        Coin1 = New PictureBox()
        Enemy2 = New PictureBox()
        Platform = New PictureBox()
        ScoreLabel = New Label()
        Timer2 = New Timer(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox16 = New PictureBox()
        Bakaga = New PictureBox()
        Platform55 = New PictureBox()
        PictureBox17 = New PictureBox()
        PictureBox18 = New PictureBox()
        PictureBox19 = New PictureBox()
        PictureBox20 = New PictureBox()
        PictureBox21 = New PictureBox()
        PictureBox22 = New PictureBox()
        PictureBox23 = New PictureBox()
        PictureBox24 = New PictureBox()
        PictureBox25 = New PictureBox()
        Coin2 = New PictureBox()
        Coin4 = New PictureBox()
        Coin3 = New PictureBox()
        Coin7 = New PictureBox()
        Coin5 = New PictureBox()
        Coin6 = New PictureBox()
        Platty = New PictureBox()
        Bakaga2 = New PictureBox()
        Bind2 = New PictureBox()
        WinMessage = New Label()
        Barry = New PictureBox()
        Flag = New PictureBox()
        Scoretag = New Label()
        Restart = New Label()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        CType(Bakaga, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform55, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox17, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox21, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox22, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox24, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox25, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin7, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin5, ComponentModel.ISupportInitialize).BeginInit()
        CType(Coin6, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platty, ComponentModel.ISupportInitialize).BeginInit()
        CType(Bakaga2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Bind2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Barry, ComponentModel.ISupportInitialize).BeginInit()
        CType(Flag, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(77, 821)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(73, 80)
        Avatar.SizeMode = PictureBoxSizeMode.Zoom
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 150
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(541, 574)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(70, 70)
        Enemy.SizeMode = PictureBoxSizeMode.Zoom
        Enemy.TabIndex = 1
        Enemy.TabStop = False
        Enemy.Tag = "1"
        ' 
        ' Coin1
        ' 
        Coin1.Image = CType(resources.GetObject("Coin1.Image"), Image)
        Coin1.Location = New Point(326, 696)
        Coin1.Name = "Coin1"
        Coin1.Size = New Size(70, 70)
        Coin1.SizeMode = PictureBoxSizeMode.Zoom
        Coin1.TabIndex = 2
        Coin1.TabStop = False
        Coin1.Tag = "Coin"
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(476, 448)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(70, 70)
        Enemy2.SizeMode = PictureBoxSizeMode.Zoom
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        Enemy2.Tag = "1"
        ' 
        ' Platform
        ' 
        Platform.BackColor = SystemColors.WindowFrame
        Platform.BorderStyle = BorderStyle.FixedSingle
        Platform.Location = New Point(83, 923)
        Platform.Name = "Platform"
        Platform.Size = New Size(900, 30)
        Platform.SizeMode = PictureBoxSizeMode.StretchImage
        Platform.TabIndex = 4
        Platform.TabStop = False
        Platform.Tag = "wall"
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.Location = New Point(718, 9)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(13, 20)
        ScoreLabel.TabIndex = 5
        ScoreLabel.Text = " "
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.WindowFrame
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(-1, 785)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        PictureBox1.Tag = "wall"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.WindowFrame
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(177, 778)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 145)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        PictureBox2.Tag = "wall"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.WindowFrame
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Location = New Point(299, 785)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(133, 30)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        PictureBox4.Tag = "wall"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.WindowFrame
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
        PictureBox5.Location = New Point(402, 796)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 145)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        PictureBox5.Tag = "wall"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.WindowFrame
        PictureBox7.BorderStyle = BorderStyle.FixedSingle
        PictureBox7.Location = New Point(518, 670)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(30, 145)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        PictureBox7.Tag = "wall"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.WindowFrame
        PictureBox8.BorderStyle = BorderStyle.FixedSingle
        PictureBox8.Location = New Point(261, 650)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(171, 30)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 12
        PictureBox8.TabStop = False
        PictureBox8.Tag = "wall"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = SystemColors.WindowFrame
        PictureBox9.BorderStyle = BorderStyle.FixedSingle
        PictureBox9.Location = New Point(402, 670)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(30, 145)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 13
        PictureBox9.TabStop = False
        PictureBox9.Tag = "wall"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.WindowFrame
        PictureBox10.BorderStyle = BorderStyle.FixedSingle
        PictureBox10.Location = New Point(-1, -4)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(30, 799)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 14
        PictureBox10.TabStop = False
        PictureBox10.Tag = "wall"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = SystemColors.WindowFrame
        PictureBox11.BorderStyle = BorderStyle.FixedSingle
        PictureBox11.Location = New Point(-1, 0)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(869, 30)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 15
        PictureBox11.TabStop = False
        PictureBox11.Tag = "wall"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = SystemColors.WindowFrame
        PictureBox12.BorderStyle = BorderStyle.FixedSingle
        PictureBox12.Location = New Point(120, 405)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(30, 275)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 16
        PictureBox12.TabStop = False
        PictureBox12.Tag = "wall"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = SystemColors.WindowFrame
        PictureBox13.BorderStyle = BorderStyle.FixedSingle
        PictureBox13.Location = New Point(236, 535)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(30, 145)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 17
        PictureBox13.TabStop = False
        PictureBox13.Tag = "wall"
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = SystemColors.WindowFrame
        PictureBox14.BorderStyle = BorderStyle.FixedSingle
        PictureBox14.Location = New Point(120, 399)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(312, 30)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 18
        PictureBox14.TabStop = False
        PictureBox14.Tag = "wall"
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BackColor = SystemColors.WindowFrame
        PictureBox15.BorderStyle = BorderStyle.FixedSingle
        PictureBox15.Location = New Point(372, 524)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(297, 30)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 19
        PictureBox15.TabStop = False
        PictureBox15.Tag = "wall"
        ' 
        ' PictureBox16
        ' 
        PictureBox16.BackColor = SystemColors.WindowFrame
        PictureBox16.BorderStyle = BorderStyle.FixedSingle
        PictureBox16.Location = New Point(653, 524)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(30, 291)
        PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox16.TabIndex = 20
        PictureBox16.TabStop = False
        PictureBox16.Tag = "wall"
        ' 
        ' Bakaga
        ' 
        Bakaga.Image = CType(resources.GetObject("Bakaga.Image"), Image)
        Bakaga.Location = New Point(653, 181)
        Bakaga.Name = "Bakaga"
        Bakaga.Size = New Size(70, 70)
        Bakaga.SizeMode = PictureBoxSizeMode.Zoom
        Bakaga.TabIndex = 21
        Bakaga.TabStop = False
        Bakaga.Tag = "1"
        ' 
        ' Platform55
        ' 
        Platform55.BackColor = SystemColors.WindowFrame
        Platform55.BorderStyle = BorderStyle.FixedSingle
        Platform55.Location = New Point(12, 277)
        Platform55.Name = "Platform55"
        Platform55.Size = New Size(856, 30)
        Platform55.SizeMode = PictureBoxSizeMode.StretchImage
        Platform55.TabIndex = 22
        Platform55.TabStop = False
        Platform55.Tag = "wall"
        ' 
        ' PictureBox17
        ' 
        PictureBox17.BackColor = SystemColors.WindowFrame
        PictureBox17.BorderStyle = BorderStyle.FixedSingle
        PictureBox17.Location = New Point(372, 399)
        PictureBox17.Name = "PictureBox17"
        PictureBox17.Size = New Size(30, 145)
        PictureBox17.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox17.TabIndex = 23
        PictureBox17.TabStop = False
        PictureBox17.Tag = "wall"
        ' 
        ' PictureBox18
        ' 
        PictureBox18.BackColor = SystemColors.WindowFrame
        PictureBox18.BorderStyle = BorderStyle.FixedSingle
        PictureBox18.Location = New Point(408, 399)
        PictureBox18.Name = "PictureBox18"
        PictureBox18.Size = New Size(30, 145)
        PictureBox18.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox18.TabIndex = 24
        PictureBox18.TabStop = False
        PictureBox18.Tag = "wall"
        ' 
        ' PictureBox19
        ' 
        PictureBox19.BackColor = SystemColors.WindowFrame
        PictureBox19.BorderStyle = BorderStyle.FixedSingle
        PictureBox19.Location = New Point(529, 284)
        PictureBox19.Name = "PictureBox19"
        PictureBox19.Size = New Size(30, 131)
        PictureBox19.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox19.TabIndex = 25
        PictureBox19.TabStop = False
        PictureBox19.Tag = "wall"
        ' 
        ' PictureBox20
        ' 
        PictureBox20.BackColor = SystemColors.WindowFrame
        PictureBox20.BorderStyle = BorderStyle.FixedSingle
        PictureBox20.Location = New Point(658, 405)
        PictureBox20.Name = "PictureBox20"
        PictureBox20.Size = New Size(210, 30)
        PictureBox20.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox20.TabIndex = 26
        PictureBox20.TabStop = False
        PictureBox20.Tag = "wall"
        ' 
        ' PictureBox21
        ' 
        PictureBox21.BackColor = SystemColors.WindowFrame
        PictureBox21.BorderStyle = BorderStyle.FixedSingle
        PictureBox21.Location = New Point(953, 133)
        PictureBox21.Name = "PictureBox21"
        PictureBox21.Size = New Size(30, 799)
        PictureBox21.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox21.TabIndex = 27
        PictureBox21.TabStop = False
        PictureBox21.Tag = "wall"
        ' 
        ' PictureBox22
        ' 
        PictureBox22.BackColor = SystemColors.WindowFrame
        PictureBox22.BorderStyle = BorderStyle.FixedSingle
        PictureBox22.Location = New Point(787, 430)
        PictureBox22.Name = "PictureBox22"
        PictureBox22.Size = New Size(30, 372)
        PictureBox22.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox22.TabIndex = 28
        PictureBox22.TabStop = False
        PictureBox22.Tag = "wall"
        ' 
        ' PictureBox23
        ' 
        PictureBox23.BackColor = SystemColors.WindowFrame
        PictureBox23.BorderStyle = BorderStyle.FixedSingle
        PictureBox23.Location = New Point(838, 277)
        PictureBox23.Name = "PictureBox23"
        PictureBox23.Size = New Size(30, 554)
        PictureBox23.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox23.TabIndex = 29
        PictureBox23.TabStop = False
        PictureBox23.Tag = "wall"
        ' 
        ' PictureBox24
        ' 
        PictureBox24.BackColor = SystemColors.WindowFrame
        PictureBox24.BorderStyle = BorderStyle.FixedSingle
        PictureBox24.Location = New Point(518, 801)
        PictureBox24.Name = "PictureBox24"
        PictureBox24.Size = New Size(331, 30)
        PictureBox24.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox24.TabIndex = 30
        PictureBox24.TabStop = False
        PictureBox24.Tag = ""
        ' 
        ' PictureBox25
        ' 
        PictureBox25.BackColor = SystemColors.WindowFrame
        PictureBox25.BorderStyle = BorderStyle.FixedSingle
        PictureBox25.Location = New Point(429, 118)
        PictureBox25.Name = "PictureBox25"
        PictureBox25.Size = New Size(554, 30)
        PictureBox25.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox25.TabIndex = 31
        PictureBox25.TabStop = False
        PictureBox25.Tag = "wall"
        ' 
        ' Coin2
        ' 
        Coin2.Image = CType(resources.GetObject("Coin2.Image"), Image)
        Coin2.Location = New Point(565, 725)
        Coin2.Name = "Coin2"
        Coin2.Size = New Size(70, 70)
        Coin2.SizeMode = PictureBoxSizeMode.Zoom
        Coin2.TabIndex = 32
        Coin2.TabStop = False
        Coin2.Tag = "Coin"
        ' 
        ' Coin4
        ' 
        Coin4.Image = CType(resources.GetObject("Coin4.Image"), Image)
        Coin4.Location = New Point(757, 321)
        Coin4.Name = "Coin4"
        Coin4.Size = New Size(70, 70)
        Coin4.SizeMode = PictureBoxSizeMode.Zoom
        Coin4.TabIndex = 33
        Coin4.TabStop = False
        Coin4.Tag = "Coin"
        ' 
        ' Coin3
        ' 
        Coin3.Image = CType(resources.GetObject("Coin3.Image"), Image)
        Coin3.Location = New Point(700, 725)
        Coin3.Name = "Coin3"
        Coin3.Size = New Size(70, 70)
        Coin3.SizeMode = PictureBoxSizeMode.Zoom
        Coin3.TabIndex = 34
        Coin3.TabStop = False
        Coin3.Tag = "Coin"
        ' 
        ' Coin7
        ' 
        Coin7.Image = CType(resources.GetObject("Coin7.Image"), Image)
        Coin7.Location = New Point(35, 201)
        Coin7.Name = "Coin7"
        Coin7.Size = New Size(70, 70)
        Coin7.SizeMode = PictureBoxSizeMode.Zoom
        Coin7.TabIndex = 35
        Coin7.TabStop = False
        Coin7.Tag = "Coin"
        ' 
        ' Coin5
        ' 
        Coin5.Image = CType(resources.GetObject("Coin5.Image"), Image)
        Coin5.Location = New Point(35, 36)
        Coin5.Name = "Coin5"
        Coin5.Size = New Size(70, 70)
        Coin5.SizeMode = PictureBoxSizeMode.Zoom
        Coin5.TabIndex = 36
        Coin5.TabStop = False
        Coin5.Tag = "Coin"
        ' 
        ' Coin6
        ' 
        Coin6.Image = CType(resources.GetObject("Coin6.Image"), Image)
        Coin6.Location = New Point(35, 118)
        Coin6.Name = "Coin6"
        Coin6.Size = New Size(70, 70)
        Coin6.SizeMode = PictureBoxSizeMode.Zoom
        Coin6.TabIndex = 37
        Coin6.TabStop = False
        Coin6.Tag = "Coin"
        ' 
        ' Platty
        ' 
        Platty.Location = New Point(299, 650)
        Platty.Name = "Platty"
        Platty.Size = New Size(312, 30)
        Platty.TabIndex = 38
        Platty.TabStop = False
        Platty.Visible = False
        ' 
        ' Bakaga2
        ' 
        Bakaga2.Location = New Point(143, 273)
        Bakaga2.Name = "Bakaga2"
        Bakaga2.Size = New Size(706, 30)
        Bakaga2.TabIndex = 39
        Bakaga2.TabStop = False
        Bakaga2.Visible = False
        ' 
        ' Bind2
        ' 
        Bind2.Location = New Point(476, 524)
        Bind2.Name = "Bind2"
        Bind2.Size = New Size(278, 30)
        Bind2.TabIndex = 40
        Bind2.TabStop = False
        Bind2.Visible = False
        ' 
        ' WinMessage
        ' 
        WinMessage.AutoSize = True
        WinMessage.Font = New Font("Segoe UI", 90F)
        WinMessage.Location = New Point(140, 52)
        WinMessage.Name = "WinMessage"
        WinMessage.Size = New Size(672, 199)
        WinMessage.TabIndex = 41
        WinMessage.Text = "You Win!"
        WinMessage.Visible = False
        ' 
        ' Barry
        ' 
        Barry.BackColor = SystemColors.WindowFrame
        Barry.BorderStyle = BorderStyle.FixedSingle
        Barry.Location = New Point(838, 12)
        Barry.Name = "Barry"
        Barry.Size = New Size(30, 131)
        Barry.SizeMode = PictureBoxSizeMode.StretchImage
        Barry.TabIndex = 42
        Barry.TabStop = False
        Barry.Tag = "wall"
        ' 
        ' Flag
        ' 
        Flag.Image = CType(resources.GetObject("Flag.Image"), Image)
        Flag.Location = New Point(874, -4)
        Flag.Name = "Flag"
        Flag.Size = New Size(109, 116)
        Flag.SizeMode = PictureBoxSizeMode.Zoom
        Flag.TabIndex = 43
        Flag.TabStop = False
        Flag.Tag = "Flag"
        ' 
        ' Scoretag
        ' 
        Scoretag.AutoSize = True
        Scoretag.Location = New Point(5, 5)
        Scoretag.Name = "Scoretag"
        Scoretag.Size = New Size(13, 20)
        Scoretag.TabIndex = 44
        Scoretag.Text = " "
        ' 
        ' Restart
        ' 
        Restart.AutoSize = True
        Restart.Font = New Font("Segoe UI", 35F)
        Restart.Location = New Point(383, 834)
        Restart.Name = "Restart"
        Restart.Size = New Size(213, 78)
        Restart.TabIndex = 45
        Restart.Text = "Restart"
        Restart.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 953)
        Controls.Add(Restart)
        Controls.Add(Scoretag)
        Controls.Add(Flag)
        Controls.Add(Barry)
        Controls.Add(WinMessage)
        Controls.Add(Bind2)
        Controls.Add(Bakaga2)
        Controls.Add(Platty)
        Controls.Add(Coin6)
        Controls.Add(Coin5)
        Controls.Add(Coin7)
        Controls.Add(Coin3)
        Controls.Add(Coin4)
        Controls.Add(Coin2)
        Controls.Add(PictureBox25)
        Controls.Add(PictureBox24)
        Controls.Add(PictureBox23)
        Controls.Add(PictureBox22)
        Controls.Add(PictureBox21)
        Controls.Add(PictureBox20)
        Controls.Add(PictureBox19)
        Controls.Add(PictureBox18)
        Controls.Add(PictureBox17)
        Controls.Add(Platform55)
        Controls.Add(Bakaga)
        Controls.Add(PictureBox16)
        Controls.Add(PictureBox15)
        Controls.Add(PictureBox14)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox12)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(ScoreLabel)
        Controls.Add(Platform)
        Controls.Add(Enemy2)
        Controls.Add(Coin1)
        Controls.Add(Enemy)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin1, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        CType(Bakaga, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform55, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox17, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox21, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox22, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox24, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox25, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin2, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin4, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin3, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin7, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin5, ComponentModel.ISupportInitialize).EndInit()
        CType(Coin6, ComponentModel.ISupportInitialize).EndInit()
        CType(Platty, ComponentModel.ISupportInitialize).EndInit()
        CType(Bakaga2, ComponentModel.ISupportInitialize).EndInit()
        CType(Bind2, ComponentModel.ISupportInitialize).EndInit()
        CType(Barry, ComponentModel.ISupportInitialize).EndInit()
        CType(Flag, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Coin1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Bakaga As PictureBox
    Friend WithEvents Platform55 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents Coin2 As PictureBox
    Friend WithEvents Coin4 As PictureBox
    Friend WithEvents Coin3 As PictureBox
    Friend WithEvents Coin7 As PictureBox
    Friend WithEvents Coin5 As PictureBox
    Friend WithEvents Coin6 As PictureBox
    Friend WithEvents Platty As PictureBox
    Friend WithEvents Bakaga2 As PictureBox
    Friend WithEvents Bind2 As PictureBox
    Friend WithEvents WinMessage As Label
    Friend WithEvents Barry As PictureBox
    Friend WithEvents Flag As PictureBox
    Friend WithEvents Scoretag As Label
    Friend WithEvents Restart As Label

End Class
