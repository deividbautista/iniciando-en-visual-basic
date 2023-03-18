'Esta linea nos sirve para importar la libreria math, que nos trae varias funciones necesarias para el desarrollo del último ejercicio
Imports System.Math
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

        'Definir funciones que vamos a necesitar para el correcto desarrollo del programa
        'En estas primeras tres guardaremos el valor de los angulos recuktantes de la ecuaciones
        Dim A As Double
        Dim B As Double
        Dim C As Double

        'En las siguientes varibales utilizaremos un concepto nuevo, denominado: "MATRICES", para poder guardar
        'Dos resultados relacionados en una misma lista
        Dim AB(2) As Double
        Dim BC(2) As Double
        Dim AC(2) As Double

        'Estos son variables para calcular los conocidos vectores, para el continuo desarrollo de la ecuación
        Dim VectoresAB As Double
        Dim vectoresBC As Double
        Dim vectoresAC As Double

        'En estos apartados definiremos los productos escalar de las funciones "AB, AC, BC"
        Dim escalarA As Integer
        Dim escalarB As Integer

        'Las siguientes variables las definimos para guardar los resultados de los paso necesarios paar ahcer la ecuación final
        Dim paso1 As Double
        Dim paso2 As Double
        Dim paso3 As Double

        'En esta funcion se guarda la raiz de los vectores "AB, AC"
        Dim raiz As Double
        'La función división nos permite guardar el valor del producto esclar por los vectores
        Dim división As Double

        'Definimos las cordenadas como integer para despues solicitar su valor al usuario
        Dim Ax As Integer
        Dim Ay As Integer
        Dim Bx As Integer
        Dim By As Integer
        Dim Cx As Integer
        Dim Cy As Integer

        'En este apartado solicitamos las distintas coordenadas deseadas
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

        'En este apartado empezamos a utilizar las coordenadas para multiplicarlas y obtener las nuevas cordenadas de "AB, AC, BC"
        AB(0) = Bx - Ax
        AB(1) = By - Ay
        AC(0) = Cx - Ax
        AC(1) = Cy - Ay
        BC(0) = Cx - Bx
        BC(1) = Cy - By
        'Procedemos a realizar los vectores de la formula indicada de "AB, AC, BC"
        VectoresAB = AB(0) ^ 2 + AB(1) ^ 2
        vectoresAC = AC(0) ^ 2 + AC(1) ^ 2
        vectoresBC = BC(0) ^ 2 + BC(1) ^ 2

        'Obtenemos el producto escalar utilizando los distintos vectores de "AB, AC, BC"
        escalarA = AB(0) * AC(0) + AB(1) * AC(1)
        escalarB = AB(0) * BC(0) + AB(1) * BC(1)

        'A continuación insertamos la formula para conseguir la función matematica de coseno inverso o arcoseno, el cual sera necesario para la continuidad del proceso
        'Atan(-x / Sqrt(-x * x + 1)) + (2 * Atan(1))
        'Tambien es importante tener en cuenta la configuración de ATAN en el visual basic, para cambiarlo de radianes a grados que eslo que necitamos
        'Se realiza lo siguiente: atan()*180/math.pi
        'O en caso de requerir lo contrario re realiza de la siguiente manera: atan()*math.pi/180
        'La función Sqrt nos brinda la raiz cudrada de un número, importada de la libreria math
        'La función Pi nos brinda el número pi sin tener que determinarlo importada de la libreria math

        'En este apartado veremos los pasos a realizar para resolver la ecuación
        'Primero realizamos el calculo de la raiz de los vectores "AB, AC"
        raiz = Sqrt(VectoresAB) * Sqrt(vectoresAC)
        'Segundo se realiza la división del producto escalar y el resultado de la raiz de los vectores "AB, AC"
        división = escalarA / raiz
        'lo siquiente que se debe de realizar es la ecuación para hallar el arcoseno de la división echa anterioremente para asi dar solución al problema
        'Atan(-x / Sqrt(-x * x + 1)) + (2 * Atan(1))
        paso1 = -división * división + 1
        paso2 = Atan(-división / Sqrt(paso1))
        'Ya con el arcoseno encontrado, finalmente para obtener el resultado deseado, debemos de realizar lo descrito en lineas anteriores
        'Converti el resultado obtenido en radianes a grados
        paso3 = paso2 * 180 / Math.PI
        'Concluyendo obtenemos el angulo del vertice A 
        A = paso3 + (2 * Atan(1) * 180 / Math.PI)

        'Aplicamos los mismos parametros de la ecuación anterior, adaptano las variables para obtener el resultado del angulo del vertice B
        raiz = Sqrt(VectoresAB) * Sqrt(vectoresBC)
        división = escalarB / raiz
        división = Math.Abs(división)
        paso1 = -división * división + 1
        paso2 = Atan(-división / Sqrt(paso1))
        paso3 = paso2 * 180 / Math.PI
        B = paso3 + (2 * Atan(1) * 180 / Math.PI)

        'En esta linea hallamos el angulo de c, porque como recordamos de nustras clases de trigonometria
        'un triangulo posee 180 grados en total de sus tres vertices, por lo que solo quedaria restar los resultados anteriores de 180
        C = 180 - A - B

        'Una vez obtenido todos los angulos, imprimimos por pantalla los resultados
        Console.WriteLine("El angulo del vertice A es: " & A)
        Console.WriteLine("El angulo del vertice B es: " & B)
        Console.WriteLine("El angulo del vertice C es: " & C)

        Console.WriteLine("------------------------------------------------------------------ ")

        '---------------------------------------------
        'FizzBuzz
        '--------------------------------------------
        Console.WriteLine("imprimir multiplos de 3 y 5 FIZZBUZZ ")
        
        'Primero definimor una variable que va funcionar de contador

        Dim númerofizzbuzz As Integer = 1
        
        'Utilizamos un bucle repetitivo para poder realizar las intrucciones indicadas, utilizando el contador para compararlo
        'Con las condicionales anidadas que implementaremos más adelante
        While (númerofizzbuzz < 100)
            
            'La primera condicionales que utilizaremos es nos indica que si el contador resulta ser multiplo de 3 y 5, escriba Fizzbuzz
            If númerofizzbuzz Mod 3 = 0 And númerofizzbuzz Mod 5 = 0 Then
                Console.WriteLine(númerofizzbuzz & " fizzbuzz")
                'Si no esmultiplo de 3 y 5, pero si es multiplo de 5, escriba buzz
            ElseIf númerofizzbuzz Mod 5 = 0 Then
                Console.WriteLine(númerofizzbuzz & " buzz")
                'Si no esmultiplo de 3 y 5, y tampoco es multiplo de 5 pero si es multiplo de 3, escriba fizz 
            ElseIf númerofizzbuzz Mod 3 = 0 Then
                Console.WriteLine(númerofizzbuzz & " fizz")

            End If
            
            'Por utimo sumamos un número al contador para que el proceso se repita hasta llegar a 100 que es cuando el bucle finaliza
            númerofizzbuzz += 1

        End While

        'Utilizamos la siguiente linea para evitar que el ejecutable se suependa una vez acabado el proceso
        Console.ReadKey(True)

        'Fin :3

    End Sub

End Module
