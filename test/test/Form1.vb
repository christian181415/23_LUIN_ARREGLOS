Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .Rows.Add("Caseta 01")
            .Rows.Add("Caseta 02")
            .Rows.Add("Caseta 03")
            .Rows.Add("Caseta 04")
        End With

        Dim BtnTable As DataGridViewButtonColumn = New DataGridViewButtonColumn
        BtnTable.HeaderText = "Acciones"
        BtnTable.Name = "BtnAgregar"
        BtnTable.Text = "Agregar"
        BtnTable.FlatStyle = FlatStyle.Flat
        BtnTable.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(BtnTable)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 2 Then
            MessageBox.Show("Columna N°: " & e.RowIndex & Chr(10) &
                            "Caseta: " & Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value))
        End If
    End Sub
End Class
