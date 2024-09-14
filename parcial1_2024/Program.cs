using System.Xml.Schema;

public class Program
{
    private static int objetivo;
    private static bool superoObjetivo;

    private static void Main(string[] args)
    {

        // Sueldo base del vendedor
        double sueldoBase = 2600000; 

        //ventas del vendedor
        Console.WriteLine("primera venta: ");
        double venta1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("segunda venta: ");
        double venta2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("tercera venta: ");
        double venta3 = Convert.ToDouble(Console.ReadLine());

        // comisiones
        double comision1 = venta1 * 0.10;
        double comision2 = venta2 * 0.10;
        double comision3 = venta3 * 0.10;

        // Total de todas las comisiones
        double totalComisiones = comision1 + comision2 + comision3;

        // total del mes con comisiones y sueldo
        double totalRecibir = sueldoBase + totalComisiones;

        // mayor comision

        double mayorComision = comision1; 
        if (comision2 > mayorComision)
        {
            mayorComision = comision2;
        }
        if (comision3 > mayorComision)
        {
            mayorComision = comision3;
        }

        // Promedio de las comisiones
        double promedioComisiones = totalComisiones / 3;

        // Objetivo de mes
        double beneficioExtra = 0;
        if (objetivo>= 1000000)
        {
            beneficioExtra = 100000;
        }

        // Mostrar resultados
        Console.WriteLine($"Total de comisiones por las tres ventas: {totalComisiones:C}");
        Console.WriteLine($"Total del mes (sueldo base + comisiones): {totalRecibir + beneficioExtra:C}");
        Console.WriteLine($"La mayor comisión: {mayorComision:C}");
        Console.WriteLine($"Promedio de las comisiones: {promedioComisiones:C}");
        Console.WriteLine(superoObjetivo ? "¡felicitaciones hasganadoel beneficio extra de $100.000!" : "lo sentimos no alcanzaste el objetivo para el beneficio extra.");
    }
}



