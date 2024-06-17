Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvNuevoVector.ColumnCount = 8
        dtvNuevoVector.Rows.Add()
        dtvVector.ColumnCount = 8
        dtvVector.Rows.Add()
        For i = 0 To 7
            dtvVector.Columns(i).Width = 40
            dtvNuevoVector.Columns(i).Width = 40
        Next
    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim vector(8) As Integer
        Dim nuevoVector(8) As Integer

        For i = 0 To 7
            vector(i) = dtvVector.Item(i, 0).Value
        Next
        lblVector.Text = "Vector original:"
        For i = 4 To 7
            nuevoVector(i - 4) = vector(i)
        Next
        For i = 0 To 3
            nuevoVector(i + 4) = vector(i)
        Next
        lblNuevoVector.Text = "Vector nuevo:"
        For i = 0 To 7
            dtvNuevoVector.Item(i, 0).Value = nuevoVector(i)
        Next
    End Sub
End Class
