using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversoes_e_Outros_tipos_numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 4- Conversoes e outros tipos numericos");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("Salario em Ponto Flutuante: " + salario);
            Console.WriteLine("Salario em I nteiro: " + salarioEmInteiro);

            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadLine();
        }
    }
}
