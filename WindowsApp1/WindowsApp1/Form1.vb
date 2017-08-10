Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bullet As New Pen(Color.Red, 3)


        Dim P1Left As Boolean = False
        Dim P1Right As Boolean = False
        Dim P1Up As Boolean = False
        Dim P1Down As Boolean = False
        Dim P2Left As Boolean = False
        Dim P2Right As Boolean = False
        Dim P2Up As Boolean = False
        Dim P2Down As Boolean = False
        Dim P1Position As New Point(390, 800)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.keyChar = "0" Then

        End If
    End Sub
End Class
