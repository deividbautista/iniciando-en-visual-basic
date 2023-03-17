﻿Imports System.Math
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

        Console.WriteLine("------------------------------------------------------------------ ")
        '---------------------------------------------
        'Hallar los grados de un triangulo 
        '---------------------------------------------

        Console.WriteLine("Hallar grados de un triangulo :} ")
        
        'Definir funciones 
        Dim A As Double
        Dim B As Double
        Dim C As Double
        Dim AB(2) As Double
        Dim BC(2) As Double
        Dim AC(2) As Double
        Dim VectoresAB As Double
        Dim vectoresBC As Double
        Dim vectoresAC As Double
        Dim escalarA As Integer
        Dim escalarB As Integer
        Dim paso1 As Double
        Dim paso2 As Double
        Dim paso3 As Double
        Dim cosenor As Double
        Dim división As Double
        Dim Ax As Integer
        Dim Ay As Integer
        Dim Bx As Integer
        Dim By As Integer
        Dim Cx As Integer
        Dim Cy As Integer


        Console.WriteLine("Digite la cordenada X del vertice A: ")
        Ax = Console.ReadLine()
        Console.WriteLine("Digite la cordenada y del vertice A: ")
        Ay = Console.ReadLine()
        Console.WriteLine("Digite la cordenada x del vertice B: ")
        Bx = Console.ReadLine()
        Console.WriteLine("Digite la cordenada y del vertice B: ")
        By = Console.ReadLine()
        Console.WriteLine("Digite la cordenada x del vertice C: ")
        Cx = Console.ReadLine()
        Console.WriteLine("Digite la cordenada y del vertice C: ")
        Cy = Console.ReadLine()

        AB(0) = Bx - Ax
        AB(1) = By - Ay
        AC(0) = Cx - Ax
        AC(1) = Cy - Ay
        BC(0) = Cx - Bx
        BC(1) = Cy - By
        VectoresAB = AB(0) ^ 2 + AB(1) ^ 2
        vectoresAC = AC(0) ^ 2 + AC(1) ^ 2
        vectoresBC = BC(0) ^ 2 + BC(1) ^ 2

        escalarA = AB(0) * AC(0) + AB(1) * AC(1)
        escalarB = AB(0) * BC(0) + AB(1) * BC(1)

        'Atan(-x / Sqrt(-x * x + 1)) + (2 * Atan(1))

        cosenor = Sqrt(VectoresAB) * Sqrt(vectoresAC)
        división = escalarA / cosenor
        paso1 = -división * división + 1
        paso2 = Atan(-división / Sqrt(paso1))
        paso3 = paso2 * 180 / Math.PI
        A = paso3 + (2 * Atan(1) * 180 / Math.PI)


        cosenor = Sqrt(VectoresAB) * Sqrt(vectoresBC)
        división = escalarB / cosenor
        división = Math.Abs(división)
        paso1 = -división * división + 1
        paso2 = Atan(-división / Sqrt(paso1))
        paso3 = paso2 * 180 / Math.PI
        B = paso3 + (2 * Atan(1) * 180 / Math.PI)

        C = 180 - A - B
        Console.WriteLine("El angulo del vertice A es: " & A)
        Console.WriteLine("El angulo del vertice B es: " & B)
        Console.WriteLine("El angulo del vertice C es: " & C)


        'Utilizamos la siguiente linea para evitar que el ejecutable se suependa una vez acabado el proceso
        Console.ReadKey(True)

        'Fin :3

    End Sub

End Module
