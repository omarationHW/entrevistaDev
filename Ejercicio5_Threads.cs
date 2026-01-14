// ============================================
// EJERCICIO 5 - THREADS
// ============================================

/*
    Tienes este codigo que incrementa un contador
    desde multiples hilos.

    Responde las preguntas de abajo.
*/

using System;
using System.Threading;

class Program
{
    static int contador = 0;

    static void Incrementar()
    {
        for (int i = 0; i < 1000; i++)
        {
            contador++;
        }
    }

    static void Main()
    {
        Thread hilo1 = new Thread(Incrementar);
        Thread hilo2 = new Thread(Incrementar);

        hilo1.Start();
        hilo2.Start();

        hilo1.Join();
        hilo2.Join();

        Console.WriteLine(contador);  // Que valor tendra?
    }
}

// ============================================
// TUS RESPUESTAS:
// ============================================

// 1. El resultado final siempre sera 2000? Por que si o por que no?
//
//
//

// 2. Como garantizarias que el resultado sea siempre 2000?
//    (puedes escribir codigo o explicar el concepto)

/*
    // Tu solucion aqui:



*/
