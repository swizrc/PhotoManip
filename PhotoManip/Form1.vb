Public Class Form1
    Dim SecondForm As Form2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        OpenFileDialog1.Filter = ".jpg |*.jpg| All Files | *.*"


        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            AxImageBox1.LoadFromFile(TextBox1.Text.ToString)
        End If
    End Sub

    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        If AxImageBox1.ExifCount > 0 Then
            'TESTING CODE
            AxImageBox1.ExifSetAttribute("Make", "Sam")
            Dim sam As String = TextBox1.Text.ToString.Substring(0, TextBox1.Text.ToString.Length - 4)
            AxImageBox1.SaveToFile(sam & "_1.jpg")
            'TESTING CODE

            For I = 0 To AxImageBox1.ExifCount - 1
                ListBox1.Items.Add(AxImageBox1.get_ExifName(I) & ": " & AxImageBox1.get_ExifValueByIndex(I))
            Next

        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim ExifArray(0 To 1) As String
            Dim ExifName As String = ListBox1.SelectedItem.ToString
            ExifArray = Split(ExifName, ": ")
            ExifName = ExifArray(0)

            If SecondForm Is Nothing Then
                SecondForm = New Form2(ExifName)
            End If

            If SecondForm IsNot Nothing Then
                If Not SecondForm.Visible Then
                    SecondForm = New Form2(ExifName)
                End If
            End If
            SecondForm.Show()
        End If



    End Sub
End Class
