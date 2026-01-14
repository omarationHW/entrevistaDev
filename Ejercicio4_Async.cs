// ============================================
// EJERCICIO 4 - FUNCIONES ASINCRONAS
// ============================================

/*
    El siguiente codigo tiene un problema.
    Identificalo y corrigelo.
*/

using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    // CODIGO CON PROBLEMA:
    public async Task<string> ObtenerDatosAsync()
    {
        HttpClient client = new HttpClient();
        string resultado = client.GetStringAsync("https://api.ejemplo.com/datos").Result;
        return resultado;
    }
}

// ============================================
// TUS RESPUESTAS:
// ============================================

// 1. Cual es el problema?
//
//
//

// 2. Escribe el codigo corregido aqui abajo:


    public async Task<string> ObtenerDatosAsync()
    {
        // Tu codigo corregido:



    }
