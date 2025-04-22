Module Ejercicios

    Sub Main()
        Dim arrayElement() As Integer = {}
        'Primera Prueba (punto importate mod para sacar modulo )
        Console.WriteLine(SumaPares({1, 2, 3, 4, 5, 6}))

        Console.WriteLine(EsPalindromo("programar"))

        Console.WriteLine(SegundoMayor({5, 8, 1, 3, 9, 2}))

        For Each item In FizzBuzz(5)
            Console.WriteLine(item)
        Next

        'Console.WriteLine(ContarCaracteres("banana"))
        For Each item In ContarCaracteres("banana")
            Console.WriteLine(item)
        Next

    End Sub

    Function SumaPares(arr As Integer()) As Integer
        Dim sum As Integer = 0

        For index As Integer = 0 To arr.Length - 1
            If arr(index) Mod 2 = 0 Then
                sum += arr(index)
            End If
        Next
        Return sum
    End Function

    Function EsPalindromo(palabra As String) As Boolean
        'Tengo dos opciones una es usar una es usar esta funcion que ya lo hace o 
        Dim isPalindromo As String = StrReverse(palabra)
        If LCase(palabra).Equals(LCase(isPalindromo)) Then
            Return True
        End If
        Return False
    End Function
    Function SegundoMayor(arr As Integer()) As Integer
        If arr.Length < 2 Then
            Throw New ArgumentException("El arreglo debe tener al menos 2 elementos.")
        End If

        Dim mayor As Integer = Integer.MinValue
        Dim segundoMayors As Integer = Integer.MinValue

        For Each num As Integer In arr
            If num > mayor Then
                segundoMayors = mayor
                mayor = num
            ElseIf num > segundoMayors AndAlso num <> mayor Then
                segundoMayors = num
            End If
        Next

        Return segundoMayors
    End Function
    Function FizzBuzz(n As Integer) As List(Of String)
        ' defino la lista 
        Dim listaReturn As New List(Of String)
        'recorro hasta N 
        For index As Integer = 1 To n
            'SI la division del index es divisible entre 3 osea que da 0 o 5 hazme fizzbuzz
            If index Mod 3 = 0 AndAlso index Mod 5 = 0 Then
                listaReturn.Add("FizzBuzz")
            ElseIf index Mod 3 = 0 Then
                listaReturn.Add("Fizz")
            ElseIf index Mod 5 = 0 Then
                listaReturn.Add("Buzz")
            Else
                listaReturn.Add(index.ToString())
            End If
        Next

        Return listaReturn
    End Function

    Function ContarCaracteres(texto As String) As Dictionary(Of Char, Integer)
        Dim dictionary As New Dictionary(Of Char, Integer)
        'Lista de caracteres (Array)
        Dim charArray() As Char = texto.ToCharArray()

        For index As Integer = 0 To charArray.Length - 1
            Dim caracter As Char = charArray(index)

            If dictionary.ContainsKey(caracter) Then
                'Si existe le sumo uno al valor del contenido del dicionario 
                dictionary(caracter) += 1
            Else
                dictionary.Add(caracter, 1)
            End If
        Next
        Return dictionary
    End Function
End Module
