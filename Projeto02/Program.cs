using Projeto02.Controllers;
using System;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var funcionarioController = new FuncionarioController();
                funcionarioController.CadastrarFuncionario();
            }
            catch(Exception e)
            {
                Console.WriteLine($"\nOcorreu um erro: {e.Message}");
            }

            //Pausa o Prompt
            Console.ReadKey();
        }
    }
}
