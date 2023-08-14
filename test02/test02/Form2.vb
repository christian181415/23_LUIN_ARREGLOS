Public Class Form2
    Dim Nombre = {"Juan", "Pedro", "Jose", "Maria"}
    Dim Puesto = {"Sistemas", "Contabilidad", "Compras", "Ventas"}
    Dim Telefono = {"1", "2", "3", "4"}

    Dim ContN As Integer = Nombre.GetUpperBound(0)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If ContN <> Nothing Then
        '    MsgBox(Nombre(ContN))
        'End If


        For N As Integer = 0 To Nombre.GetUpperBound(0)
            If Nombre(N) <> String.Empty Then
                Nombre(N) = Nombre(N) - 1
                MsgBox(Nombre(N))
            End If
        Next
        'For P As Integer = 0 To Puesto.GetUpperBound(0)
        'Next
        'For T As Integer = 0 To Telefono.GetUpperBound(0)
        'Next
    End Sub
End Class