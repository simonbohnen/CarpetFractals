Public Class Form1
    Public matrices(50) As TransMatrix
    Public carpets As New List(Of Integer(,))
    Public matrixWasAdded As Boolean = False

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer = InputBox("Which matrix would you like to edit?", "Edit Matrix")

        If i < 0 Or i > 49 Or matrices(i) Is Nothing Then
            MessageBox.Show("Index is out of range!")
            Return
        End If

        EditMatrix.matInp.Enabled = True
        EditMatrix.matInp.Text = matrices(i).matInp
        EditMatrix.matInp.Enabled = False
        EditMatrix.mat00.Text = matrices(i).matrix(0, 0)
        EditMatrix.mat10.Text = matrices(i).matrix(1, 0)
        EditMatrix.mat20.Text = matrices(i).matrix(2, 0)
        EditMatrix.mat01.Text = matrices(i).matrix(0, 1)
        EditMatrix.mat11.Text = matrices(i).matrix(1, 1)
        EditMatrix.mat21.Text = matrices(i).matrix(2, 1)
        EditMatrix.mat02.Text = matrices(i).matrix(0, 2)
        EditMatrix.mat12.Text = matrices(i).matrix(1, 2)
        EditMatrix.mat22.Text = matrices(i).matrix(2, 2)
        EditMatrix.red.Text = matrices(i).color.R
        EditMatrix.green.Text = matrices(i).color.G
        EditMatrix.blue.Text = matrices(i).color.B
        EditMatrix.Text = "Edit Matrix " & i
        EditMatrix.editedMatrix = i
        EditMatrix.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iter As Integer = CInt(iterations.Text)
        Dim bitmap As Bitmap = New Bitmap(729, 729)
        Dim imgbitmap As Bitmap = New Bitmap(CInt(Math.Pow(3, iter)), CInt(Math.Pow(3, iter)))
        'Debug
        'matrices(0) = New TransMatrix(0, 1, 1, 1, 1, 1, 1, 1, 1, 1, Color.FromArgb(255, 255, 255))
        'matrices(1) = New TransMatrix(1, 0, 1, 0, 1, 0, 1, 0, 1, 0, Color.FromArgb(0, 0, 0))

        If Not matrixWasAdded Then
            MessageBox.Show("You have to add a transformation matrix!")
            Return
        End If

        carpets = New List(Of Integer(,))
        carpets.Add(New Integer(1, 1) {})

        For i As Integer = 1 To iter
            Dim size = Math.Pow(3, i)
            Dim oldSize = size / 3
            carpets.Add(New Integer(size, size) {})
            For x As Integer = 0 To oldSize - 1
                For y As Integer = 0 To oldSize - 1
                    setCarpetPatch(x * 3, y * 3, matrices(carpets(i - 1)(x, y)), carpets(i))
                Next
            Next
        Next

        If iter >= 6 Then
            For x As Integer = 0 To 728
                For y As Integer = 0 To 728
                    bitmap.SetPixel(x, y, matrices(carpets(6)(x, y)).color)
                Next
            Next
        Else
            Dim g = Graphics.FromImage(bitmap)
            Dim size = Math.Pow(3, iter)
            Dim rectSize As Single = 729 / size
            Dim finalCarpet = carpets(iter)
            For x As Integer = 0 To size - 1
                For y As Integer = 0 To size - 1
                    g.FillRectangle(New SolidBrush(matrices(finalCarpet(x, y)).color), x * rectSize, y * rectSize, rectSize, rectSize)
                Next
            Next
        End If

        CreateGraphics.DrawImage(bitmap, 0, 0)
        'bitmap.Save("c://users/simon/teppich.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

    Private Sub setCarpetPatch(startX As Integer, startY As Integer, matrix As TransMatrix, ByRef carpet As Integer(,))
        For x As Integer = 0 To 2
            For y As Integer = 0 To 2
                carpet(startX + x, startY + y) = matrix.matrix(x, y)
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddMatrix.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReDim matrices(50)
    End Sub
End Class
