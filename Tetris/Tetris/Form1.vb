Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Follow(Enemy, Avatar, 15) 'GTA5 source code moment'
        Follow(Enemy2, Avatar, 10)
    End Sub
    Sub Follow(E As PictureBox, A As PictureBox, S As Integer)
        If E.Location.Y > A.Location.Y Then
            Move(E, 0, -S)
        Else
            Move(E, 0, S)
        End If
        If E.Location.X > A.Location.X Then
            Move(E, -S, 0)
        Else 'the imposter from among us'
            Move(E, S, 0) 'when the imposter is sus'
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            Move(Avatar, -15, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            Move(Avatar, 15, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            Move(Avatar, 0, 15)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            Move(Avatar, 0, -15)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        Avatar.Refresh()

    End Sub

    Sub Move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If p.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            PictureBox3.Visible = False
        End If
    End Sub

End Class
