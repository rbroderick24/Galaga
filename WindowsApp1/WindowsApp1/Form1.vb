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
    End Sub

<<<<<<< HEAD

        Dim P1Left As Boolean = False
        Dim P1Right As Boolean = False
        Dim P1Up As Boolean = False
        Dim P1Down As Boolean = False
        Dim P2Left As Boolean = False
        Dim P2Right As Boolean = False
        Dim P2Up As Boolean = False
        Dim P2Down As Boolean = False
        Dim P1Position As New Point(390, 800)
=======
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
>>>>>>> 40f99f2bf76f02571ce21ab9c08409f224df9c71

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.keyChar = "0" Then

        End If
    End Sub
End Class
