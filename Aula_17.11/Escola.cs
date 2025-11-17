using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17._11
{
    public abstract class Escola
    {
        public string escola;
        public string cidade;
        public string estado;
        public string serie;

        public abstract void CalcularMedia();
        public virtual void DescobrirNome()
        {
            Console.Write("Digite o Nome da escola: ");
            string escola = Console.ReadLine();

            Console.Write("Digite a Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Digite o Estado: ");
            string estado = Console.ReadLine();

            Console.Write("Digite a Série que estuda: ");
            string serie = Console.ReadLine();

            if (escola.ToUpper() == "SESISENAI" && cidade.ToUpper() == "GARÇA")
            {
                Console.WriteLine("Aluno Sesi/Senai");
            }
            else
            {
                Console.WriteLine($"Aluno da escola {escola} da cidade de {cidade}.");
            }
        }
    }
}
