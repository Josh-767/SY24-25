Imports System.Net.Security
Imports System.Threading

Public Class Form1
    Dim Score As Integer
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PaceX(Enemy, Platty, 7)
        PaceX(Bakaga, Bakaga2, 5)
        PaceX(Enemy2, Bind2, 9)
        If Coin1.Visible = False And Coin2.Visible = False And Coin3.Visible = False And Coin4.Visible = False And Coin5.Visible = False And Coin6.Visible = False And Coin7.Visible = False Then
            Barry.visible = False
        End If
        If IntersectsWith(Avatar, "Flag") Then
            Me.BackColor = Color.Green
            WinMessage.Visible = True
            Flag.Visible = False
            Enemy.Visible = False
            Enemy2.Visible = False
            Bakaga.Visible = False
            Restart.Visible = True
        End If
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag
        Gogo(e, dir * speed, 0)
        If e.Location.X > p.Location.X + p.Width Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub
    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag
        Gogo(e, 0, dir * speed)
        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height Then
            e.Tag = dir * -1
        End If
        If IntersectsWith(p, "wall") Then
            e.Tag = dir * -1
        End If
    End Sub
    Sub Follow(E As PictureBox, A As PictureBox, Speedx As Integer, Speedy As Integer)
        If E.Location.Y > A.Location.Y Then
            Gogo(E, 0, -Speedy)
        Else
            Gogo(E, 0, Speedy)
        End If
        If E.Location.X > A.Location.X Then
            Gogo(E, -Speedx, 0)
        Else
            Gogo(E, Speedx, 0)
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            Gogo(Avatar, -10, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            Gogo(Avatar, 10, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            Gogo(Avatar, 0, 10)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            Gogo(Avatar, 0, -10)
        End If
        Avatar.Refresh()
    End Sub
    Sub Gogo(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
        Dim q As PictureBox
        If IntersectsWith(p, "Coin", q) Then
            p.Location -= New Point(xdir, ydir)
            q.Visible = False
        End If
        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)
    End Sub
    Function endingWith(s As String) As Collection
        Dim coll As New Collection
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If UCase(obj.Name).EndsWith(UCase(s)) Then
                    coll.Add(obj)
                End If
            End If
        Next
        Return coll
    End Function
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Score += 1
        Scoretag.Text = Score
    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub
End Class
