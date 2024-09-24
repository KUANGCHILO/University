
Public Class game
    Private Declare Sub Sleep Lib "kerne132" Alias "Sleep" (ByVal dwMilliseconds As Long)
    Dim instring As String
    Dim count As Integer = 0
    Dim cur As Integer = 1
    Dim rand As New Random()
    Dim forward As Integer = 100
    Dim bornx1 As Integer = 50
    Dim bornx2 As Integer = 180
    Dim bornx3 As Integer = 300
    Dim borny As Integer = 30
    Dim penl As Boolean = False
    Dim score As Integer = 0
    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim imagePaths() As String = {"img\count1.png", "img\count2.png", "img\count3.png"}
        For i As Integer = 1 To 4
            Dim controlName As String = "zombie" & i.ToString()
            Dim zombieControl As Control = Me.Controls.Find(controlName, True).FirstOrDefault()
            Dim randomNumber As Integer = rand.Next(1, 4)
            zombieControl.Tag = Str(randomNumber)
            If zombieControl IsNot Nothing Then
                Select Case Val(randomNumber)
                    Case 1
                        zombieControl.Location = New Point(46, zombieControl.Location.Y)
                    Case 2
                        zombieControl.Location = New Point(170, zombieControl.Location.Y)
                    Case 3
                        zombieControl.Location = New Point(300, zombieControl.Location.Y)
                End Select
            End If
        Next
        Timer1.Interval = 10 '1秒執行一次
        Timer1.Enabled = True '開啟 False 關掉
        Timer2.Interval = 1000 '1秒執行一次
        Timer2.Enabled = True '開啟 False 關掉

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        count = count + 1
        instring = Form1.SerialPort1.ReadExisting() 'nano有送資料給電腦 Read讀
        If instring.Length = 0 Or penl Or score_text.Visible Then
            Exit Sub '沒有字串進來的話跳離此程序(timer1.tick)
        End If
        Select Case cur
            Case 1
                zombie_die(Str(instring) = Str(zombie1.Tag))
            Case 2
                zombie_die(Str(instring) = Str(zombie2.Tag))
            Case 3
                zombie_die(Str(instring) = Str(zombie3.Tag))
            Case 4
                zombie_die(Str(instring) = Str(zombie4.Tag))
        End Select
    End Sub

    Sub zombie_die(ByVal zombie_hit As Boolean)
        If zombie_hit = True Then
            Dim randomNumber As Integer = rand.Next(1, 4)
            score = score + 1
            Select Case cur
                Case 1
                    zombie1.Tag = Nothing
                    zombie1.Tag = Str(randomNumber)
                    Select Case Val(randomNumber)
                        Case 1
                            zombie1.Location = New Point(bornx1, borny)
                        Case 2
                            zombie1.Location = New Point(bornx2, borny)
                        Case 3
                            zombie1.Location = New Point(bornx3, borny)
                    End Select
                    zombie2.Location = New Point(zombie2.Location.X, Val(zombie2.Location.Y) + forward)
                    zombie3.Location = New Point(zombie3.Location.X, Val(zombie3.Location.Y) + forward)
                    zombie4.Location = New Point(zombie4.Location.X, Val(zombie4.Location.Y) + forward)
                    cur = cur + 1
                Case 2
                    zombie2.Tag = Nothing
                    zombie2.Tag = Str(randomNumber)
                    Select Case Val(randomNumber)
                        Case 1
                            zombie2.Location = New Point(bornx1, borny)
                        Case 2
                            zombie2.Location = New Point(bornx2, borny)
                        Case 3
                            zombie2.Location = New Point(bornx3, borny)
                    End Select
                    zombie1.Location = New Point(zombie1.Location.X, Val(zombie1.Location.Y) + forward)
                    zombie3.Location = New Point(zombie3.Location.X, Val(zombie3.Location.Y) + forward)
                    zombie4.Location = New Point(zombie4.Location.X, Val(zombie4.Location.Y) + forward)
                    cur = cur + 1
                Case 3
                    zombie3.Tag = Nothing
                    zombie3.Tag = Str(randomNumber)
                    Select Case Val(randomNumber)
                        Case 1
                            zombie3.Location = New Point(bornx1, borny)
                        Case 2
                            zombie3.Location = New Point(bornx2, borny)
                        Case 3
                            zombie3.Location = New Point(bornx3, borny)
                    End Select
                    zombie1.Location = New Point(zombie1.Location.X, Val(zombie1.Location.Y) + forward)
                    zombie2.Location = New Point(zombie2.Location.X, Val(zombie2.Location.Y) + forward)
                    zombie4.Location = New Point(zombie4.Location.X, Val(zombie4.Location.Y) + forward)
                    cur = cur + 1
                Case 4
                    zombie4.Tag = Nothing
                    zombie4.Tag = Str(randomNumber)
                    Select Case Val(randomNumber)
                        Case 1
                            zombie4.Location = New Point(bornx1, borny)
                        Case 2
                            zombie4.Location = New Point(bornx2, borny)
                        Case 3
                            zombie4.Location = New Point(bornx3, borny)
                    End Select
                    zombie1.Location = New Point(zombie1.Location.X, Val(zombie1.Location.Y) + forward)
                    zombie2.Location = New Point(zombie2.Location.X, Val(zombie2.Location.Y) + forward)
                    zombie3.Location = New Point(zombie3.Location.X, Val(zombie3.Location.Y) + forward)
                    cur = cur - 3
            End Select
        ElseIf zombie_hit = False Then
            penl = True
            Select Case cur
                Case 1
                    zombie1.Image = Image.FromFile("img\zombie_miss.png")
                    wait(1)
                    zombie1.Image = Image.FromFile("img\zombie.png")
                Case 2
                    zombie2.Image = Image.FromFile("img\zombie_miss.png")
                    wait(1)
                    zombie2.Image = Image.FromFile("img\zombie.png")
                Case 3
                    zombie3.Image = Image.FromFile("img\zombie_miss.png")
                    wait(1)
                    zombie3.Image = Image.FromFile("img\zombie.png")
                Case 4
                    zombie4.Image = Image.FromFile("img\zombie_miss.png")
                    wait(1)
                    zombie4.Image = Image.FromFile("img\zombie.png")
            End Select
            penl = False
        End If
    End Sub

    Dim WithEvents w_timer As New Timer
    Dim w_tick As Integer
    Private Sub wait(ByVal second As Integer)
        w_tick = 0
        w_timer.Interval = second * 1000
        w_timer.Enabled = True
        Do Until w_tick >= 1
            Application.DoEvents()
        Loop
        w_timer.Enabled = False
        w_timer.Interval = 1
    End Sub
    Private Sub w_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles w_timer.Tick
        w_tick += 1
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        time.Text = Val(time.Text) - Val(1)
        If Val(time.Text) = 0 Then
            score_text.Visible = True
            score_text.Text = score_text.Text + score.ToString() + "分"
            Timer2.Enabled = False
            wait(5)
            Me.Close()
        End If
    End Sub
End Class
