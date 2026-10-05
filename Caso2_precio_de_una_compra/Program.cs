using System;
using System.Text;

// Configurar la consola para que reconozca caracteres especiales como ₡
Console.OutputEncoding = Encoding.UTF8;

// Ejecución del programa
ProcesarCaso2();

static void ProcesarCaso2()
{
    Console.WriteLine("=== CASO 2: PRECIO DE UNA COMPRA ===");

    Console.Write("Ingrese el precio del producto (₡): ");
    string entradaPrecio = Console.ReadLine() ?? string.Empty;

    Console.Write("Ingrese la cantidad a comprar: ");
    string entradaCantidad = Console.ReadLine() ?? string.Empty;

    bool precioValido = double.TryParse(entradaPrecio, out double precio);
    bool cantidadValida = int.TryParse(entradaCantidad, out int cantidad);

    if (precioValido && cantidadValida && precio > 0 && cantidad > 0)
    {
        double subtotal = precio * cantidad;
        double descuento = 0;

        if (subtotal > 25000)
        {
            descuento = subtotal * 0.10;
        }

        double total = subtotal - descuento;

        Console.WriteLine("\n--- RESUMEN DE LA COMPRA ---");
        Console.WriteLine($"Subtotal: ₡{subtotal:N2}");
        Console.WriteLine($"Descuento (10%): ₡{descuento:N2}");
        Console.WriteLine($"Total a pagar: ₡{total:N2}");
    }
    else
    {
        Console.WriteLine("\nError: El precio y la cantidad deben ser números mayores a cero.");
    }

    Console.WriteLine("\nPresione Enter para finalizar...");
    Console.ReadLine();
}