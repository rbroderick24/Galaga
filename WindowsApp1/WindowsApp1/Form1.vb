Public Class Form1
    Dim draw As System.Drawing.Graphics = Me.CreateGraphics
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "A" Then
            P1Left = True
        End If
        If e.KeyChar = "D" Then
            P1Right = True
        End If
        If e.KeyChar = "W" Then
            P1Up = True
        End If
        If e.KeyChar = "S" Then
            P1Down = True
        End If
        If e.KeyChar = "1" Then
            P2Left = True
        End If
        If e.KeyChar = "3" Then
            P2Right = True
        End If
        If e.KeyChar = "5" Then
            P2Up = True
        End If
        If e.KeyChar = "2" Then
            P2Down = True
        End If

        If e.KeyChar = "0" Then
            shooting = True
            If shooting = True Then
                draw.DrawLine(bullet, 100, 100, 60, 60)








                If e.KeyChar = "Spacebar" Then
                    shooting = True
                    If shooting = True Then
                        draw.DrawLine(bullet2, 10, 10, 10, 10)


                    End If

                End If
            End If
        End If
    End Sub
<<<<<<< HEAD

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
=======
<<<<<<< HEAD

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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

    End Sub
=======
>>>>>>> b6cb81cdbdcb2af264feb10118e50dfd97e5c5b2
>>>>>>> 4ce4b12a2e3eecafb7db85c01a475c85b3ded477
End Class
