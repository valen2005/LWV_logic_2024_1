using System;

public class Program
{
    public static void Main()
    {
        // Definir una matriz de números enteros
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Encontrar el número máximo en la matriz
        int maximo = EncontrarMaximo(matriz);

        // Mostrar el número máximo en pantalla
        Console.WriteLine($"El número máximo en la matriz es: {maximo}");
    }

    // Función para encontrar el número máximo en una matriz
    public static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = int.MinValue;
        foreach (int numero in matriz)
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
        }
        return maximo;
    }
}
