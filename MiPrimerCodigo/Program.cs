using System;

namespace MiPrimerCodigo
{
    public class Program
    {
        static void Main(string[] args)
    {

            //ingresar por pantalla dos numeros y calcular las 4 operaciones aritmeticas con dichos numeros.
            //Moatrar en panatalla un mensaje de advertencia que indique que el segundo numero debe de ser diferente de cero.
            //Imprimer en pantalla el resultado de cada operación


            // declaración de variables 

            int num1, num2;
            double sum, rest, prod, coc;
            string name;


            //leer 


            
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine()); 

            
            Console.WriteLine("Ingrese el primer número. Este número debe de ser diferente de cero");
            num2 = Convert.ToInt32(Console.ReadLine()); 

            // Hcaer los calculos 

            sum = num1 + num2;
            rest = num1 - num2;
            prod = num1 * num2;
            coc = num1 / num2;

            // imprimir pantalla 
            Console.WriteLine( " Suma: " + num1 + " + "  + num2 +  " = " +  sum);
            Console.WriteLine(" Resta: " + num1 + " - " + num2 + " = " + rest);
            Console.WriteLine(" producto: " + num1 + " x " + num2 + " = " + prod);
            Console.WriteLine(" Cociente: " + num1 + " / " + num2 + " = " + coc);








        }

    }

}
