Public Class Form1

    Dim shooting As Boolean = False
    Dim bullet As New Pen(Color.Red, 3)
    Dim bullet2 As New Pen(Color.Blue, 3)
    Dim P1Left As Boolean = False
    Dim P1Right As Boolean = False
    Dim P1Up As Boolean = False
    Dim P1Down As Boolean = False
    Dim P2Left As Boolean = False
    Dim P2Right As Boolean = False
    Dim P2Up As Boolean = False
    Dim P2Down As Boolean = False
    Dim P1Position As New Point(390, 800)
    Dim P2Position As New Point(390, 50)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim draw As System.Drawing.Graphics = Me.CreateGraphics
        If e.KeyCode = 65 Then
            P1Left = True
        End If
        If e.KeyCode = 68 Then
            P1Right = True
        End If
        If e.KeyCode = 87 Then
            P1Up = True
        End If
        If e.KeyCode = 83 Then
            P1Down = True
        End If
        If e.KeyCode = 37 Then
            P2Left = True
        End If
        If e.KeyCode = 39 Then
            P2Right = True
        End If
        If e.KeyCode = 38 Then
            P2Up = True
        End If
        If e.KeyCode = 40 Then
            P2Down = True
        End If

        If e.KeyCode = 17 Then
            shooting = True
            If shooting = True Then

                draw.DrawLine(bullet, 300, 100, 50, 50)

                draw.DrawLine(bullet, 50, 100, 50, 50)

                draw.DrawLine(bullet, 20000, 20000, 100, 100)

                If e.KeyCode = 32 Then
                    shooting = True
                    If shooting = True Then
                        draw.DrawLine(bullet2, 10, 10, 10, 10)

                    End If
                End If
            End If
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y

    End Sub



    'Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
    'If e.KeyChar = "A" Then
    '    P1Left = False
    'End If
    'If e.KeyChar = "D" Then
    '    P1Right = False
    'End If
    'If e.KeyChar = "W" Then
    '    P1Up = False
    'End If
    'If e.KeyChar = "S" Then
    '    P1Down = False
    'End If
    'If e.KeyChar = "1" Then
    '    P2Left = False
    'End If
    'If e.KeyChar = "3" Then
    '    P2Right = False
    'End If
    'If e.KeyChar = "5" Then
    '    P2Up = False
    'End If
    'If e.KeyChar = "2" Then
    '    P2Down = False
    'End If

    'End Sub


    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = 65 Then
            P1Left = False
        End If
        If e.KeyCode = 68 Then
            P1Right = False
        End If
        If e.KeyCode = 87 Then
            P1Up = False
        End If
        If e.KeyCode = 83 Then
            P1Down = False
        End If
        If e.KeyCode = 37 Then
            P2Left = False
        End If
        If e.KeyCode = 39 Then
            P2Right = False
        End If
        If e.KeyCode = 38 Then
            P2Up = False
        End If
        If e.KeyCode = 40 Then
            P2Down = False
        End If
    End Sub

<<<<<<< HEAD
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
=======

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
>>>>>>> 7a2d408fced887dc7de439d9c1a6e7355f578270
        Dim point1 As New Point(P1Position.X - 50, 800)
        Dim point2 As New Point(P1Position.X + 50, 800)
        Dim point3 As New Point(P1Position.X, P1Position.Y - 25)
        Dim point4 As New Point(P2Position.X - 50, 50)
        Dim point5 As New Point(P2Position.X + 50, 50)
        Dim point6 As New Point(P2Position.X, P2Position.Y + 25)

        Dim draw As System.Drawing.Graphics = Me.CreateGraphics
        Dim allP As Point() = {point1, point2, point3}
        Dim allP2 As Point() = {point4, point5, point6}
        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)

        draw.FillRectangle(Brushes.Black, 0, 0, 780, 850)
        draw.FillPolygon(redBrush, allP)
        draw.FillPolygon(blueBrush, allP2)

        If P1Left Then
            P1Position.X -= 10
        End If
        If P1Right Then
            P1Position.X += 10
        End If

        If P2Left Then
            P2Position.X -= 10
        End If
        If P2Right Then
            P2Position.X += 10
        End If
    End Sub
End Class
