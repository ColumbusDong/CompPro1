'Project:       Final
'Programer:    John Phelan
'Date:         April 2013
'Description:  The project to end all projects.





Public Class MainPage
    'exit
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Print these awesome pictures?",
          "Close The Program", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then
            PrintToolStripMenuItem_Click(sender, e)
        End If
        Me.Close()
    End Sub
    'print
    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
    'font
    Private Sub FontToolStripMenuItem_Click(sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'font
        With FontDialog1
            .Font = NameLable.Font
            .ShowDialog()
            NameLable.Font = .Font
            DescriptionLable.Font = .Font
        End With
    End Sub

    Private Sub ProgrammerInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProgrammerInfoToolStripMenuItem.Click
        ' Display the About message box.
        Dim MessageString As String

        MessageString = Environment.NewLine & "Programmed by John Michael Phelan"


        MessageBox.Show(MessageString, "Programmed by Mike Phelan", MessageBoxButtons.OK,
         MessageBoxIcon.Information)
    End Sub
    Private Sub ProgramInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProgramInfoToolStripMenuItem.Click
        'info
        Dim MessageString As String

        MessageString = Environment.NewLine & "All content belongs to Riot Entertainment"

        MessageBox.Show(MessageString, "League of Legends Champions", MessageBoxButtons.OK,
         MessageBoxIcon.Information)
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Returns lables to original state
        DescriptionLable.Text = " "
        NameLable.Text = "Champion Name"
        'clear the pic
        OutfitPictureBox.Image = Nothing
    End Sub
    Private Sub FontColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DescriptionLable.ForeColor = ColorDialog1.Color
        End If
    End Sub


    'When they click the button it plays the sound and puts the picture up. If the alternate pic checkbox is checked it puts the second image.
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.AlistarSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 100
        MagicBar.Height = 200
        NameLable.Text = "Alistair"
        DescriptionLable.Text = "Alistair is a giant bull. You could call him a minotar, but that isn't politically correct. He bashes his opponents around the battle field with punches and headbutts. You could call him a bully, but that would make you cheesy."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.ali3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.ali2
        End If

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.BrandSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 300
        MagicBar.Height = 300
        NameLable.Text = "Brand"
        DescriptionLable.Text = "Brand has a fiery disposition to say the least. The guy looks like a burned marshmellow. He casts a bunch of fire spells and can ruin your day in a second. Don't play with him if you don't want to get burned."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.brand3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.brand2
        End If
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.ChoSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 200
        MagicBar.Height = 200
        NameLable.Text = "Cho'Gath"
        DescriptionLable.Text = "From the deepest abyss comes a creature of unthinkable horror. He devours all in his path, with an insatiable appetite for flesh. Nom Nom Nom"
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.cho3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.cho2
        End If

    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.JarvinSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 100
        MagicBar.Height = 100
        NameLable.Text = "Jarvin"
        DescriptionLable.Text = "As the royal family of Demacia for centuries, members of the Lightshield line have spent their lives waging war against any who opposed Demacian ethics."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.jarvan3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.jarvan2
        End If
    End Sub
    
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources.KogSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 300
        MagicBar.Height = 100
        NameLable.Text = "Kog'Maw"
        DescriptionLable.Text = "Kog is a ranged champion that destroys everything with his putrid blasts of spit. He devours all life, and has no concept of remorse."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.kog3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.kog2
        End If
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.KayleSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 100
        MagicBar.Height = 200
        NameLable.Text = "Kayle"
        DescriptionLable.Text = "In a world far away where an ancient war still rages, Kayle was a great hero - the strongest of an immortal race committed to destroying evil wherever it could be found."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.kayle3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.kayle2
        End If
    End Sub
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        My.Computer.Audio.Play(My.Resources.LeBlancSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 300
        MagicBar.Height = 300
        NameLable.Text = "LeBlanc"
        DescriptionLable.Text = "There are few things more confusing than fighting LeBlanc. You have no idea what her spells do, and how they killed you. Plus you are silenced. Oh she is almost dead, wait no thats the wrong one."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.leblanc3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.leblanc2
        End If
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.LeonaSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 100
        MagicBar.Height = 100
        NameLable.Text = "Leona"
        DescriptionLable.Text = "The most modestly dressed of all women in Runetera. Leona uses a sheild to block a lot of stuff. Including unwelcome advances from abusive summoners."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.leona3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.leona2
        End If
    End Sub
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(My.Resources.LuxSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 300
        MagicBar.Height = 300
        NameLable.Text = "Lux"
        DescriptionLable.Text = "Lux is not only everyone's favorite rainbow lazer shooting princess, but she is also pretty. Most princesses wouldn't venture into the fray, not Lux. She loves pwning noobs."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.lux3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.lux2
        End If
    End Sub
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.MordeSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 300
        MagicBar.Height = 300
        NameLable.Text = "Mordekaiser"
        DescriptionLable.Text = "You would think he was German with a name like that, but no. He is Hell. For seasons he was overpowered, but now he can't do anything. Alas he was nerfed."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.morde3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.morde2
        End If
    End Sub
    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        My.Computer.Audio.Play(My.Resources.MorgSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 200
        MagicBar.Height = 300
        NameLable.Text = "Morgana"
        DescriptionLable.Text = "She is really evil. You probably can't tell from her appearence, but she has a heart of black. She can kill from far and escape easily. She has zero living ex boyfriends."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.morgana3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.morgana2
        End If
    End Sub
    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        My.Computer.Audio.Play(My.Resources.MumuSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 100
        MagicBar.Height = 200
        NameLable.Text = "Amumu"
        DescriptionLable.Text = "He has no friends. That is why he is sad all the time. He should be popular, and cool, but it just isn't working for him. He is that guy everyone knows but no one hangs out with. Forever alone."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.mumu3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.mumu2
        End If
    End Sub
    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        My.Computer.Audio.Play(My.Resources.PoppySelect, AudioPlayMode.Background)
        HealthBar.Height = 200
        DamageBar.Height = 300
        MagicBar.Height = 200
        NameLable.Text = "Poppy"
        DescriptionLable.Text = "Don't let her pigtails fool you. Poppy packs a punch. She isn't afraid to run right accross the field of battle to smack someone into a tree. That hammer of hers looks heavy too."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.poppy3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.poppy2
        End If
    End Sub
    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        My.Computer.Audio.Play(My.Resources.SeguaniSelect, AudioPlayMode.Background)
        HealthBar.Height = 300
        DamageBar.Height = 100
        MagicBar.Height = 100
        NameLable.Text = "Seguani"
        DescriptionLable.Text = "She is a valkyrie riding a worthog. What else needs to be said."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.seguani3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.seguani2
        End If
    End Sub
    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        My.Computer.Audio.Play(My.Resources.SonaSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 200
        MagicBar.Height = 300
        NameLable.Text = "Sona"
        DescriptionLable.Text = "Sona jams out hard on her harp. It inspires everyone so much that her team rarely loses. Infact it inspires the other team into losing on purpose."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.sona3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.sona2
        End If
    End Sub
    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        My.Computer.Audio.Play(My.Resources.ViegarSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 300
        MagicBar.Height = 300
        NameLable.Text = "Viegar"
        DescriptionLable.Text = "This little guy will ruin your day. He can kill most champions in one combo. On the other hand, most champions can kill him in a matter of seconds."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.viegar3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.viegar2
        End If
    End Sub
    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        My.Computer.Audio.Play(My.Resources.WuSelect, AudioPlayMode.Background)
        HealthBar.Height = 200
        DamageBar.Height = 200
        MagicBar.Height = 100
        NameLable.Text = "Wukong"
        DescriptionLable.Text = "He is not speaking figuratively when he says he is the monkey king. He litterally is the king of monkies. Unfortunately for him monkies have even less respect for authority and nobility than humans do."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.wukong3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.wukong2
        End If
    End Sub
    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        My.Computer.Audio.Play(My.Resources.XinSelect, AudioPlayMode.Background)
        HealthBar.Height = 100
        DamageBar.Height = 300
        MagicBar.Height = 100
        NameLable.Text = "Xin"
        DescriptionLable.Text = "He's not a ninja or a samuri. He is just a bad bad man with a spear. He can rip through armour or health quickly and builds up speed like a train. A smart team focuses on him first."
        If AlternateOutfitCheckBox.Checked = True Then

            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.xin3
        Else
            OutfitPictureBox.Visible = True
            OutfitPictureBox.Image = My.Resources.xin2
        End If
    End Sub
End Class
