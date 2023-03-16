Module Module1
    Sub Main()
        '---------------------------------------------
        'Numero par o impar
        '---------------------------------------------
        'En la siguiente linea observamos la definición de la variable num
        Dim num As Integer

        Console.WriteLine("NÚMERO PAR O IMPAR")

        'posteriormente pedido la digitación del numero que se asignara a num
        Console.WriteLine("Introduzca un número: ")
        num = Console.ReadLine()
        'Continuamos explorando la condicional en la que determinaremos
        'si el valor digitado es par o impar por medio del operador matematico mod
        If num Mod 2 = 0 Then
            System.Console.WriteLine("Número par")

        Else
            System.Console.WriteLine("Número impar")

        End If
        System.Console.WriteLine("valor: " & num)

        Console.WriteLine("------------------------------------------------------------------ ")

        '---------------------------------------------
        'Sucesión de fibonacci
        '---------------------------------------------

        'Ahora pasaremos a realizar la sucesion de fibonacci con ciclo repetitivo
        'Recordar que la formula para esta sucesión es la siguiente: An = An-2+An-1
        'Primero definimos todas las variables a usar

        Dim contador As Integer = 0
        Dim posicion As Integer
        Dim fibonacci As Integer = 1
        Dim a1 As Integer = 1
        Dim a2 As Integer = 0

        Console.WriteLine("SUCESIÓN DE FIBONACCI")

        'En el siguiente apartado le pediremos al usuario el valor de la posición de la sucesión
        Console.WriteLine("Digite hasta que posición desea observar la sucesión de Fibonacci: ")
        posicion = Console.ReadLine()

        'Podemos ver en en el siguiente bucle condicional, como aplicaremos la sucesión de una forma sencilla
        While (contador <= posicion) 'Definimos la condicion por medio de un contador y el valor digitado por el usuario
            Console.WriteLine("valor de la posicion: " & fibonacci) 'Imprimimos en pantalla el valor actual de la sucesión

            'Realizamos la siguiente formula
            fibonacci = a1 + a2
            a2 = a1
            a1 = fibonacci

            'Aumentamos el valor de la variable contador para que esta cumpla su funcion de terminar el ciclo cuando se cumpla la condición
            contador = contador + 1
        End While

        'Imprimimos el numero de la posición digitada
        Console.WriteLine("posicion: " & posicion)
        'Brindamos el valor de la posicion siguiente a la provista por el usuario 
        Console.WriteLine("valor de la siguiente posicion:" & fibonacci)

        Console.WriteLine("------------------------------------------------------------------ ")

        '---------------------------------------------
        'Números primos
        '---------------------------------------------
        'En esta sección implementaremos la condicional if para determinar si un número es primo
        Console.WriteLine("NÚMEROS PRIMOS :) ")
        Dim númeroprimo As Integer

        Console.WriteLine("Digite el número que desea identificar: ")
        númeroprimo = Console.ReadLine()

        'en este apartado realizamos la condional, en la que si el residuo de cualquier número
        'dividido en 2, es mayor a 0 es un número primo sin incluir al 2
        If númeroprimo Mod 2 > 0 Or númeroprimo = 2 Then

            Console.WriteLine("El número: " & númeroprimo & " es primo :D")

        Else
            Console.WriteLine("El número" & númeroprimo & " no es primo :U")

        End If

        'Utilizamos la siguiente linea para evitar que el ejecutable se suependa una vez acabado el proceso
        Console.ReadKey(True)

        'Fin :3

    End Sub

End Module
