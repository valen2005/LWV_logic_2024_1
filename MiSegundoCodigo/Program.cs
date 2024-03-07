using System;

namespace MiSegundoCodigo
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //realiza un algortimo que me pida 3 números por pantalla con el primer número hayar el cuadrado con el segundo número hayar la raiz cuadrada y con el tercer numero hayar la raiz cubica.
            //mostrar en pantalla los 3 resultados aritméticos recuerde concatenar los string para mostrar un mensaje bonito


            // definir variables 

            double  num1, num2, num3;

            // LLamar a pantalla 
           
            Console.WriteLine("Por favor ingresa 3 números");

            Console.Write("Por favor ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por favor ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por favor ingrese el tercer número: ");
            num3 = Convert.ToDouble(Console.ReadLine());


            //// LEER
            ///// Mostrar los resultados en pantalla directamente
            Console.WriteLine("El cuadrado del primer número es: " + (num1 * num1));
            Console.WriteLine("La raíz cuadrada del segundo número es: " + Math.Sqrt(num2));
            Console.WriteLine("La raíz cúbica del tercer número es: " + Math.Pow(num3, 1.0 / 3.0));





        }
    }
}
