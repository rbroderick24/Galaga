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
        If e.KeyCode = 49 Then
            P2Left = True
        End If
        If e.KeyCode = 51 Then
            P2Right = True
        End If
        If e.KeyCode = 53 Then
            P2Up = True
        End If
        If e.KeyCode = 50 Then
            P2Down = True
        End If

        If e.KeyCode = 17 Then
            shooting = True
            If shooting = True Then


                draw.DrawLine(bullet, 300, 100, 50, 50)




                draw.DrawLine(bullet, 50, 100, 50, 50)

                draw.DrawLine(bullet, 20000, 20000, 100, 100)
<<<<<<< HEAD


=======

<<<<<<< HEAD
=======







>>>>>>> bbfdb51e05316c0ad89c2f6be807303556ccca79

>>>>>>> 21def598d18d957920d5ea2dda9ef0a1ee85b718
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

<<<<<<< HEAD



=======
>>>>>>> bbfdb51e05316c0ad89c2f6be807303556ccca79

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
        If e.KeyCode = 49 Then
            P2Left = False
        End If
        If e.KeyCode = 51 Then
            P2Right = False
        End If
        If e.KeyCode = 53 Then
            P2Up = False
        End If
        If e.KeyCode = 50 Then
            P2Down = False
        End If
    End Sub
<<<<<<< HEAD

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim point1 As New Point(P1Position.X - 50, 800)
        Dim point2 As New Point(P1Position.X + 50, 800)
        Dim point3 As New Point(P1Position.X, P1Position.Y - 25)
        Dim draw As System.Drawing.Graphics = Me.CreateGraphics
        Dim allP As Point() = {point1, point2, point3}
        Dim redBrush As New SolidBrush(Color.Red)
        draw.FillPolygon(redBrush, allP)
    End Sub
=======
<<<<<<< HEAD
=======

>>>>>>> bbfdb51e05316c0ad89c2f6be807303556ccca79
>>>>>>> 21def598d18d957920d5ea2dda9ef0a1ee85b718
End Class
