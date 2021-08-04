using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Funcionario
    {
        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }

        #region Relacionamentos
        public Setor Setor { get; set; }
        public List<Dependente> Dependentes { get; set; }
        #endregion


    }
}
