using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 1;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Anderson possui uma idade maior de 18 anos pode entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Anderson nao possui uma idade uma 18 anos, mas está acompanhado pode entrar");
                }
                else
                {

                    Console.WriteLine("Anderson nao possui uma idade uma 18 anos, e não está acompanhado não pode entrar");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair.......");
            Console.ReadLine();
        }
    }
}
