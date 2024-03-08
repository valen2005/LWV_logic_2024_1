using System;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese el sueldo base y el monto de cada venta
            Console.Write("Ingrese el sueldo base del vendedor: ");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el monto de cada una de las tres ventas realizadas:");
            Console.Write("Venta 1: ");
            double venta1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Venta 2: ");
            double venta2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Venta 3: ");
            double venta3 = Convert.ToDouble(Console.ReadLine());

            // Calcular la comisión por cada venta (10% del monto de la venta)
            double comision1 = venta1 * 0.10;
            double comision2 = venta2 * 0.10;
            double comision3 = venta3 * 0.10;

            // Calcular el total de las comisiones
            double totalComisiones = comision1 + comision2 + comision3;

            // Calcular el total del dinero que el vendedor recibirá en el mes
            double totalMes = sueldoBase + totalComisiones;

            // Mostrar los resultados en pantalla
            Console.WriteLine($"La comisión por la venta 1 es: {comision1}");
            Console.WriteLine($"La comisión por la venta 2 es: {comision2}");
            Console.WriteLine($"La comisión por la venta 3 es: {comision3}");
            Console.WriteLine($"El total de las comisiones es: {totalComisiones}");
            Console.WriteLine($"El total del dinero que recibirá en el mes es: {totalMes}");


        }
    }
}
