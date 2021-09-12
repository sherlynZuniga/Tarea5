Module Module1

    'lista'
    Public vfuncion(8)
    Public vcine(8)
    Public subtotal_a_pagar(8)
    Public vdescuento1(8)
    Public vdescuento2(8)
    Public vtotal(8)


    Public indice = 0

    'variable de calculo'
    Public calculo_subtotal As Double = 0
    Public calculo_descuento2 As Double = 0

    'calcular subtotal'
    Function calcularsubtotal(funcion As String, cine As String) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30 * Val(Form1.TextBox1.Text)
                    Case "2"
                        calculo_subtotal = 35 * Val(Form1.TextBox1.Text)
                    Case "3"
                        calculo_subtotal = 40 * Val(Form1.TextBox1.Text)
                    Case "4"
                        calculo_subtotal = 40 * Val(Form1.TextBox1.Text)
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24 * Val(Form1.TextBox1.Text)
                    Case "2"
                        calculo_subtotal = 34 * Val(Form1.TextBox1.Text)
                    Case "3"
                        calculo_subtotal = 44 * Val(Form1.TextBox1.Text)
                    Case "4"
                        calculo_subtotal = 44 * Val(Form1.TextBox1.Text)
                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35 * Val(Form1.TextBox1.Text)
                    Case "2"
                        calculo_subtotal = 40 * Val(Form1.TextBox1.Text)
                    Case "3"
                        calculo_subtotal = 50 * Val(Form1.TextBox1.Text)
                    Case "4"
                        calculo_subtotal = 50 * Val(Form1.TextBox1.Text)
                End Select
        End Select

        Return calculo_subtotal
    End Function

    'calculo descuento 1'
    Function calculodescuento1(funcion As String, cine As String) As Double
        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculodescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculodescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculodescuento1 = 0.015
        End If
        Return calculodescuento1
    End Function

    'calculo descuento 2'
    Function calculodescuento2(funcion As String, cine As String) As Double
        Select Case calculo_subtotal
            Case 100 To 300
                calculodescuento2 = 2 / 100
            Case 301 To 500
                calculodescuento2 = 4 / 100
            Case 501 To 1000
                calculodescuento2 = 6 / 100
        End Select
        Return calculodescuento2
    End Function



End Module
