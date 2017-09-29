Public Class AddMatrix
    Private Sub addMatrixButton_Click(sender As Object, e As EventArgs) Handles addMatrixButton.Click
        Form1.matrices(CInt(matInp.Text)) = New TransMatrix(CInt(matInp.Text), CInt(mat00.Text), CInt(mat10.Text), CInt(mat20.Text), CInt(mat01.Text), CInt(mat11.Text), CInt(mat21.Text), CInt(mat02.Text), CInt(mat12.Text), CInt(mat22.Text), Color.FromArgb(CInt(red.Text), CInt(green.Text), CInt(blue.Text)))
        Form1.matrixWasAdded = True
        Me.Close()
    End Sub
End Class