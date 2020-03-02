using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quantidadePessoas = 1;

            bool acompanhado = quantidadePessoas>=2;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Anderson possui uma idade maior de 18 anos pode entrar");
            }
            else
            {
                Console.WriteLine("Anderson não possui uma idade maior de 18 anos, não pode entrar");

            }

            Console.WriteLine("Pressione qualquer tecla para sair.......");
            Console.ReadLine();
        }
        
    }
}
