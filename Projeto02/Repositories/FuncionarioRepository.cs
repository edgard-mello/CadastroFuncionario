using Newtonsoft.Json;
using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarJSON(Funcionario funcionario)
        {
            //Define Path onde será gravado o arquivo
            var path = $"c:\\temp\\funcionario_{funcionario.IdFuncionario}.json";

            //Abre o arquivo para gravação
            var streamWriter = new StreamWriter(path);

            //Serializa os dados de Funcionario em JSON
            var json = JsonConvert.SerializeObject(funcionario,Formatting.Indented);

            //Escreve os dados serializados no arquivo
            streamWriter.WriteLine(json);

            //Fecha o arquivo
            streamWriter.Close();

        }
    }
}
