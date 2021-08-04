using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        //Método que faz usuário entrar com os dados do funcionario para cadastro
        public void CadastrarFuncionario()
        {
            Console.WriteLine("\n --- CADASTRO DE FUNCIONÁRIO --- \n");

            //Criando obj da classe funcionário
            var funcionario = new Funcionario();

            //Instanciando relacionamentos contidos
            funcionario.Setor = new Setor();
            funcionario.Dependentes = new List<Dependente>();

            //Inicia cadastro...
            funcionario.IdFuncionario = Guid.NewGuid();

            Console.Write("Nome do Funcionário......: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe o CPF............: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Informe a Matrícula......: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Data de Admissão.........: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            //Dados do SETOR (1 para 1)
            funcionario.Setor.IdSetor = Guid.NewGuid();

            Console.Write("Nome do Setor............: ");
            funcionario.Setor.Nome = Console.ReadLine();

            Console.Write("Descrição do Setor.......: ");
            funcionario.Setor.Descricao = Console.ReadLine();

            //Dados do DEPENDENTE (1 para Muitos)
            Console.Write("Número de Dependentes....: ");
            var numDependentes = int.Parse(Console.ReadLine());

            //Percorre o número de dependentes informados para cadastro da lista
            for (int i = 0; i < numDependentes; i++)
            {
                var dependente = new Dependente();

                dependente.IdDependente = Guid.NewGuid();

                Console.Write($"\nENTRE com o {i + 1}º DEPENDENTE: \n");
                
                Console.Write("Nome do Dependente.......: ");
                dependente.Nome = Console.ReadLine();

                Console.Write("Data de Nascimento.......: ");
                dependente.DataNascimento = DateTime.Parse(Console.ReadLine());

                //Adicionar objeto dependente em Funcionario.Depentende
                funcionario.Dependentes.Add(dependente);
            }

            //Grava os Dados do Funcionario em um arquivo json
            var funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.ExportarJSON(funcionario);

            Console.Write("\nARQUIVO JSON GERADO COM SUCESSO.\n");
        }
    }
}
