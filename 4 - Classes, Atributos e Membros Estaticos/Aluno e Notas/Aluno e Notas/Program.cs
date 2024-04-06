using System.Globalization;
namespace Aluno_e_Notas

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do aluno: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Digite as três notas do aluno: ");
            double nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine("NOTA FINAL: {0} ", aluno.NotaFinal());

            if (aluno.NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS ", 60 - aluno.NotaFinal());
             }
        }
    }
}