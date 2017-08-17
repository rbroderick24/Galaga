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
    Dim P1Bullets() As Point = {New Point(0, 0), New Point(0, 0), New Point(0, 0)}


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


            End If
        End If




    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Label1.Text = MousePosition.X
    '    Label2.Text = MousePosition.Y

    'End Sub



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





        If e.KeyCode = 32 Then
            shooting = True
            If shooting = True Then
                draw.DrawLine(bullet2, 10, 10, 10, 10)

            End If
        End If

    End Sub

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
        If e.KeyCode = 32 Then
            shooting = False
        End If
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim point1 As New Point(P1Position.X - 50, P1Position.Y)
        Dim point2 As New Point(P1Position.X + 50, P1Position.Y)


        Dim point1 As New Point(P1Position.X - 50, 800)
        Dim point2 As New Point(P1Position.X + 50, 800)

        Dim point3 As New Point(P1Position.X, P1Position.Y - 25)
        Dim point4 As New Point(P2Position.X - 50, P2Position.Y)
        Dim point5 As New Point(P2Position.X + 50, P2Position.Y)
        Dim point6 As New Point(P2Position.X, P2Position.Y + 25)



        Dim draw As System.Drawing.Graphics = Me.CreateGraphics
        Dim allP As Point() = {point1, point2, point3}
        Dim allP2 As Point() = {point4, point5, point6}
        Dim redBrush As New SolidBrush(Color.Red)
        Dim blueBrush As New SolidBrush(Color.Blue)

        draw.FillRectangle(Brushes.Black, 0, 0, 780, 850)
        draw.FillPolygon(redBrush, allP)
        draw.FillPolygon(blueBrush, allP2)


        For i As Integer = 0 To P1Bullets.Length - 1
            P1Bullets(i).Y -= 10
            If P1Bullets(i) <> New Point(0, 0) Then
                If P1Bullets(i).Y <= 0 Then
                    P1Bullets(i) = New Point(0, 0)

                End If
                Debug.WriteLine("{" & P1Bullets(0).ToString & "," & P1Bullets(1).ToString & ", " & P1Bullets(2).ToString & "}")

                draw.FillRectangle(redBrush, P1Bullets(i).X, P1Bullets(i).Y, 5, 20)
            End If
        Next

        If P1Left And
            P1Position.X >= 5 Then
            P1Position.X -= 5
        End If
        If P1Right And
            P1Position.X <= 775 Then
            P1Position.X += 5
        End If

        If P1Up And
            P1Position.Y >= 650 Then
            P1Position.Y -= 5
        End If
        If P1Down And
            P1Position.Y <= 845 Then
            P1Position.Y += 5
        End If

        If P2Left And
            P2Position.X >= 5 Then
            P2Position.X -= 5
        End If
        If P2Right And
            P2Position.X <= 775 Then
            P2Position.X += 5
        End If
        If P2Down And
            P2Position.Y <= 200 Then
            P2Position.Y += 5
        End If
        If P2Up And
            P2Position.Y >= 5 Then
            P2Position.Y -= 5
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = " " Then
            For i As Integer = 0 To P1Bullets.Length - 1
                If P1Bullets(i) = New Point(0, 0) Then
                    P1Bullets(i) = New Point(P1Position.X, P1Position.Y - 25)
                    Exit For
                End If
            Next
        End If
    End Sub




End Class
