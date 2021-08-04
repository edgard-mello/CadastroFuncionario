using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Dependente
    {
        public Guid IdDependente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
