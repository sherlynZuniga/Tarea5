Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'validacion de entrada de datos?
        If TextBox1.Text = "" Then
            MsgBox("Ingresar no. de boletos")
        End If

        'envio de la funcion y cine'
        If indice < 9 Then

            'valores en vectores'

            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem
            subtotal_a_pagar(indice) = calcularsubtotal(vfuncion(indice), vcine(indice))
            vdescuento1(indice) = subtotal_a_pagar(indice) * calculodescuento1(vfuncion(indice), vcine(indice))
            vdescuento2(indice) = subtotal_a_pagar(indice) * calculodescuento2(vfuncion(indice), vcine(indice))
            vtotal(indice) = subtotal_a_pagar(indice) - vdescuento1(indice) - vdescuento2(indice)

            'mostrar valores en listboxs'
            Funcion.Items.Add(vfuncion(indice))
            Cine.Items.Add(vcine(indice))
            Subtotal.Items.Add(subtotal_a_pagar(indice))
            Descuento1.Items.Add(vdescuento1(indice))
            Descuento2.Items.Add(vdescuento2(indice))
            Total.Items.Add(vtotal(indice))


        ElseIf indice >= 9 Then
            MsgBox("VECTORES LLENOS")
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'limpiar'
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()
        Cine.Items.Clear()
        Funcion.Items.Clear()
        Subtotal.Items.Clear()
        Descuento1.Items.Clear()
        Descuento2.Items.Clear()
        Total.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()

    End Sub
End Class
