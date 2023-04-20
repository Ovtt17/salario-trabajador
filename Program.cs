// Escriba un programa que encuentre el salario semanal de un trabajador, dada la tarifa horaria y
// el número de horas trabajadas diariamente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalarioTrabajador
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario la tarifa horaria y las horas trabajadas diariamente
            Console.Write("Ingrese la tarifa horaria: ");
            float tarifaHoraria = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de horas trabajadas diariamente: ");
            float horasDiarias = float.Parse(Console.ReadLine());

            // Calcular el salario semanal
            float salarioSemanal = tarifaHoraria * horasDiarias * 5;

            // Mostrar el salario semanal
            Console.WriteLine("El salario semanal del trabajador es: $" + salarioSemanal);
        }
    }
}