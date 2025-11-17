using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17._11
{
    public class Sesi : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite sua Primeira Nota: ");
            double Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a sua Segunda Nota:");
            double Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a sua Terceira Nota: ");
            double Nota3 = Convert.ToDouble(Console.ReadLine());

            double media = Nota1 + Nota2 + Nota3;
            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else if (media >= 4)
            {
                Console.WriteLine("Aluno em Recuperação");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
    }
}