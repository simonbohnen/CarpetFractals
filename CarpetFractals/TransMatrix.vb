Public Class TransMatrix
    Public color As Color
    Public matrix(2, 2) As Integer
    Public matInp As Integer

    Public Sub New(newMatInp As Integer, mat00 As Integer, mat10 As Integer, mat20 As Integer, mat01 As Integer, mat11 As Integer, mat21 As Integer, mat02 As Integer, mat12 As Integer, mat22 As Integer, newColor As Color)
        matInp = newMatInp
        matrix(0, 0) = mat00
        matrix(1, 0) = mat10
        matrix(2, 0) = mat20
        matrix(0, 1) = mat01
        matrix(1, 1) = mat11
        matrix(2, 1) = mat21
        matrix(0, 2) = mat02
        matrix(1, 2) = mat12
        matrix(2, 2) = mat22
        color = newColor
    End Sub
End Class
