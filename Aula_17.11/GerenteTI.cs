 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17._11
{
    public class GerenteTI : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite o Total de Horas Extras feita pelo Gerente de TI este Mês: ");
            double horas = Convert.ToDouble(Console.ReadLine());

            if ( horas > 100)
            {
                double salario = (horas / 2) * 200 + 500;

                double descanso = (horas / 2) / 8;
                Console.WriteLine($"O valor é {salario}, e o descanso é {descanso}! ");
            }
            else
            {
                double result = horas * 400;
                Console.WriteLine("O valor Total é: " + result);
            }
        }
    }
}
