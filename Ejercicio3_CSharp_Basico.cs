// ============================================
// EJERCICIO 3 - C#
// ============================================

/*
    Que imprime el siguiente codigo? Explica por que.

    Escribe tus respuestas en los comentarios de abajo.
*/

using System;

class Program
{
    static void Main()
    {
        string a = "hola";
        string b = "hola";
        string c = new string("hola".ToCharArray());

        Console.WriteLine(a == b);           // Linea 1
        Console.WriteLine(a == c);           // Linea 2
        Console.WriteLine(ReferenceEquals(a, b));  // Linea 3
        Console.WriteLine(ReferenceEquals(a, c));  // Linea 4
    }
}

// ============================================
// TUS RESPUESTAS:
// ============================================

// Linea 1 imprime: ___________
// Linea 2 imprime: ___________
// Linea 3 imprime: ___________
// Linea 4 imprime: ___________

// Explicacion:
//
//
//
