Public Class Form1
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

        Dim bullet As New Pen(Color.Red, 3)
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
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

    End Sub
End Class
