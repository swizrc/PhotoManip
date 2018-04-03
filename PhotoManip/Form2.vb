Public Class Form2

    Private ExifName As String
    Private ExifVal As String

    Public Sub New(ByVal ExifN, ByVal ExifV)
        InitializeComponent()

        ExifName = ExifN
        ExifVal = ExifV
        Label1.Text = "Edit " & ExifName
        PrevTagName.Text = PrevTagName.Text.ToString & ExifVal

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If EditTextBox.Text.ToString.Length <> 0 Then
            Form1.AxImageBox1.ExifSetAttribute(ExifName, EditTextBox.Text.ToString)

            Form1.ListBox1.Items.Clear()
            For I = 0 To Form1.AxImageBox1.ExifCount - 1
                Form1.ListBox1.Items.Add(Form1.AxImageBox1.get_ExifName(I) & ": " & Form1.AxImageBox1.get_ExifValueByIndex(I))
            Next
            Form1.ExifChanged = True
            Me.Close()
        End If
    End Sub
End Class