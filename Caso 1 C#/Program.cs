using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer salario: ");
            int salario1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo salario: ");
            int salario2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer salario: ");
            int salario3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso del primer salario: ");
            int peso1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso del segundo salario: ");
            int peso2 = int.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese el peso del tercer salario: ");
            int peso3 = int.Parse(Console.ReadLine());

            float salarioT, promedio, porsentaje1, porsentaje2, porsentaje3, mediaP, mediaG, mediaA;

            salarioT = salario1 + salario2 + salario3;
            promedio = (salario1 + salario2 + salario3) / 3;
            porsentaje1 = (salario1 * 100) / salarioT;
            porsentaje2 = (salario2 * 100) / salarioT;
            porsentaje3 = (salario3 * 100) / salarioT;
            mediaP = (peso1 * salario1 + peso2 * salario2 + peso3 * salario3) / (peso1 + peso2 + peso3);
            mediaG = (salario1 * salario2 * salario3) ^ (1 / 3);
            mediaA = (3)/(1/salario1+1/salario2+1/salario3);

            Console.WriteLine("La suma de los salarios es : ",salarioT);
            Console.WriteLine("El promedio de los salarios es: ",promedio);
            Console.WriteLine($"El porcentaje del primer salario es: {porsentaje1}%");
            Console.WriteLine($"El porcentaje del segundo salario es: {porsentaje2}%");
            Console.WriteLine($"El porcentaje del tercer salario es: {porsentaje3}%");
            Console.WriteLine("La media ponderada de los salarios es: ",mediaP);
            Console.WriteLine("La media geometrica de los salarios es: ",mediaG);
            Console.WriteLine("La media armonica de los salarios es: ",mediaA);
            Console.ReadKey();
        }
    }
}
