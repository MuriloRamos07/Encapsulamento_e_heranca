using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17._11
{
    public class Senai : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digite sua Primeira Nota: ");
            double Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua Segunda Nota: ");
            double Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua Terceira Nota: ");
            double Nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua Quarta Nota: ");
            double Nota4 = Convert.ToDouble(Console.ReadLine());

            double media = Nota1 + Nota2 + Nota3 + Nota4;

            Console.WriteLine("Agora digite a sua Frequência: ");
            int frequencia = Convert.ToInt32(Console.ReadLine());

            if (frequencia >= 90 && media >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado no curso técnico do Senai! ");
            }
            else if (frequencia >= 90 && media < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação! ");
            }
            else if(frequencia <90 && media >= 7)
            {
                Console.WriteLine("Você reprovou por Falta! ");
            }
            else
            {
                Console.WriteLine("Aluno reprovado! ");
            }
        }
    }
}
