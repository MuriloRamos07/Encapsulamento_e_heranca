using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17._11
{
    public class Desenvolvedor : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a Modalidade de Trabalho: \n A- Presencial \n B- Híbrido \n C- Remoto");
            string opcao = Console.ReadLine();

            if (opcao == "A")
            {
                Console.WriteLine("Digite o total de Horas Extras: ");
                double horas = Convert.ToDouble(Console.ReadLine());

                double total = horas * 100;

                Console.WriteLine("O total é dê: " + total);
            }
            else if (opcao == "B")
            {
                Console.WriteLine("Digite o total de Horas Extras: ");
                double horas = Convert.ToDouble(Console.ReadLine());

                double total = horas * 50;

                Console.WriteLine("O total é dê: " + total);
            }
            else if (opcao == "C")
            {
                Console.WriteLine("Seu horário é flexível, não precisa de Horas extras! ");
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}
