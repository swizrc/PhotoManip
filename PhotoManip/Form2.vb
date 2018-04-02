Public Class Form2

    Private ExifName As String

    Public Sub New(ByVal ExifN)
        ExifName = ExifN

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Label1 As New Label
        Label1.Location = New Point(111, 91)
        Label1.Text = ExifName
        Controls.Add(Label1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Label1.Text = ExifName
    End Sub
End Class