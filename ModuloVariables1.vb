Module Module1

    Sub Main()
        'Para imprimir en la consola solo necesitamos de la siguiente línea de código 

        Console.WriteLine("wenas")

        'En este apartado observaremos las distintas variables que usaremos en los principios practicos 
        Dim NUMERO As Integer = 8

        Dim NUMDECIMAL As Double = 8.8

        Dim LETRA As Char = "O"

        Dim CADENA As String = "Ocho"

        Dim CONDICIONAL As Boolean = True

        'cabe resaltar que visual basic no es un lenguaje de progamación que cuente con key sensitive.
        'osea no contempla como diferentes la MAYUSCULA de la minuscula

        '---------------------------------------------------------------------------------------------

        'OPERADORES ARITMETICOS

        Dim suma As Integer = 1 + 8

        Dim menos As Integer = 1 - 8

        Dim multiplicación As Integer = 1 * 8

        Dim division As Integer = 1 / 8

        Dim residuo As Integer = 1 Mod 8

        Console.WriteLine(suma)
        Console.WriteLine(menos)
        Console.WriteLine(multiplicación)
        Console.WriteLine(division)
        Console.WriteLine(residuo)

        'OPERADORES LOGICOS

        Dim mayorque As Boolean = 12 > 5

        Dim menorque As Boolean = 12 < 5

        Dim condicionand As Boolean = 12 > 5 And 5 < 12

        Dim condicionOR As Boolean = 12 < 4 Or 5 < 15

        Dim condicionNOT As Boolean = Not 12 > 5

        Console.WriteLine(mayorque)
        Console.WriteLine(menorque)
        Console.WriteLine(condicionand)
        Console.WriteLine(condicionOR)
        Console.WriteLine(condicionNOT)

        'Con este comando podemos evitar que nuestro programa se cierre hasta precionar cualquier tecla

        Console.ReadKey(True)

    End Sub

End Module
