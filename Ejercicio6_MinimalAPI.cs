// ============================================
// EJERCICIO 6 - MINIMAL API EN .NET
// ============================================

/*
    Completa el codigo para crear una Minimal API con dos endpoints:

    - GET  /productos  -> retorna la lista de productos
    - POST /productos  -> agrega un producto nuevo a la lista
*/

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<string> productos = new List<string> { "Laptop", "Mouse" };

// ============================================
// ESCRIBE TUS ENDPOINTS AQUI:
// ============================================

// GET /productos



// POST /productos



// ============================================

app.Run();
