using System.Runtime.Intrinsics.X86;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa que leia o número de um funcionário, " +
                "\r\nseu número de horas trabalhadas, o valor que recebe por hora e " +
                "\r\ncalcula o salário desse funcionário. A seguir, mostre o número e o" +
                "\r\nsalário do funcionário, com duas casas\r\ndecimais.");


            Console.WriteLine("Numero do funcionario: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Horas trabalhadas: ");
            int h = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Valor por hora: ");
            double v = double.Parse(Console.ReadLine()!);

            double salario = h * v;

            Console.WriteLine("Number = {}", n);
            Console.WriteLine("Salario = {}", salario.ToString("f2"));

            
        }
    }
}