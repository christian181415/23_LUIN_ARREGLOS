Imports System.ComponentModel
Imports System.Reflection.Emit

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Progreso.Minimum = 0
        Progreso.Maximum = Limite + 1
    End Sub


#Region "3 ARREGLOS EN 1 CONJUNTO"
    Dim Arreglo = {{"Chettos", 15, 10}, {"Sabritas", 13, 50}, {"Jugo", 18, 100}}
    Dim Conta As Integer = 0
    Dim Maximo As Integer = Arreglo.GetUpperBound(0) + 1
    Dim Minimo As Integer = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '//LIKE PERMITE BUSCAR ENTRE PARAMETROS SIN COMPLETAR
        For x As Integer = 0 To Arreglo.GetUpperBound(0)
            If Arreglo(x, 0) Like TextBox1.Text & "*" Then
                Arreglo(x, 2) = Arreglo(x, 2) - 1
                MsgBox(Arreglo(x, 0) & "  " & Arreglo(x, 1) & "  " & Arreglo(x, 2))
                Label2.Text = Arreglo(x, 0)
                Label3.Text = Arreglo(x, 1)
                Label4.Text = Arreglo(x, 2)
            End If
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Conta <> Maximo Then
                Label2.Text = Arreglo(Conta, 0)
                Label3.Text = Arreglo(Conta, 1)
                Label4.Text = Arreglo(Conta, 2)
                Label1.Text = Conta
                Conta = Conta + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Conta > Minimo Then
                Conta = Conta - 1
                If Arreglo(Conta, 0) <> "" Then
                    Label2.Text = Arreglo(Conta, 0)
                    Label3.Text = Arreglo(Conta, 1)
                    Label4.Text = Arreglo(Conta, 2)
                    Label1.Text = Conta
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region





    'ESTATICOS ----0--------1--------2--------3
    Dim Nombre = {"Juan", "Pedro", "Jose", "Maria"}
    Dim Puesto = {"Sistemas", "Contabilidad", "Compras", "Ventas"}
    Dim Telefono = {"11111111111", "2222222222", "33333333333", "4444444444"}

    'VARIABLE
    Dim Limite As Integer = Nombre.GetUpperBound(0)
    Dim Cont As Integer = 0


    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        Try
            If Nombre(Cont) <> "" And Cont < Limite Then
                Cont = Cont + 1
                txtNombre.Text = Nombre(Cont)
                txtPuesto.Text = Puesto(Cont)
                txtTelefono.Text = Telefono(Cont)
                Progreso.Value = Cont
            End If
        Catch ex As Exception
            MsgBox("No se encontraron valores", MsgBoxStyle.Exclamation, "SIN VALORES")
        End Try
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
        Try
            If Nombre(Cont - 1) <> String.Empty And Cont <> -1 Then
                Cont = Cont - 1
                txtNombre.Text = Nombre(Cont)
                txtPuesto.Text = Puesto(Cont)
                txtTelefono.Text = Telefono(Cont)
                Progreso.Value = Cont
            End If
        Catch ex As Exception
            MsgBox("No se encontraron valores", MsgBoxStyle.Exclamation, "SIN VALORES")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Ultimo.Click
        Try
            If Nombre(Limite) <> String.Empty Then
                txtNombre.Text = Nombre(Limite)
                txtPuesto.Text = Puesto(Limite)
                txtTelefono.Text = Telefono(Limite)
                Progreso.Value = Limite + 1
                Limite = Limite - 1
            End If
        Catch ex As Exception
            MsgBox("No se encontraron valores", MsgBoxStyle.Exclamation, "SIN VALORES")
        End Try
    End Sub

End Class



'--------------------------
'-2 -1 [] 0 1 2 3 4
'
'
'