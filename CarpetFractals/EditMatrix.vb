Public Class EditMatrix
    Public editedMatrix As Integer
    Private Sub editMatrixButton_Click(sender As Object, e As EventArgs) Handles editMatrixButton.Click
        Form1.matrices(editedMatrix).matrix(0, 0) = CInt(mat00.Text)
        Form1.matrices(editedMatrix).matrix(1, 0) = CInt(mat10.Text)
        Form1.matrices(editedMatrix).matrix(2, 0) = CInt(mat20.Text)
        Form1.matrices(editedMatrix).matrix(0, 1) = CInt(mat01.Text)
        Form1.matrices(editedMatrix).matrix(1, 1) = CInt(mat11.Text)
        Form1.matrices(editedMatrix).matrix(2, 1) = CInt(mat21.Text)
        Form1.matrices(editedMatrix).matrix(0, 2) = CInt(mat02.Text)
        Form1.matrices(editedMatrix).matrix(1, 2) = CInt(mat12.Text)
        Form1.matrices(editedMatrix).matrix(2, 2) = CInt(mat22.Text)
        Form1.matrices(editedMatrix).color = Color.FromArgb(CInt(red.Text), CInt(green.Text), CInt(blue.Text))
        Me.Close()
    End Sub
End Class