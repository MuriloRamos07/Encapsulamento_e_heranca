using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17._11
{
    public class Bancario : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite o total de Horas Extras feitas pelo Bancario esse mês: ");
            double horas = Convert.ToDouble(Console.ReadLine());

            double result = horas * 250;

            if (result > 1000)
            {
                double imposto = result * 0.15;
                Console.WriteLine("O novo valor com o imposto é: " + imposto);
            }
            else if (result > 500)
            {
                double imposto = result * 0.10;
                Console.WriteLine("O novo valor com o imposto é: " + imposto);
            }
            else
            {
                Console.WriteLine("O valor é: " + result);
            }
        }
    }
}
