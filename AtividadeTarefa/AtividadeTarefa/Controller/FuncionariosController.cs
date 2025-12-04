using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Import Model para usar funciopnarios;
using AtividadeTarefa.Model;

namespace AtividadeTarefa.Controller
{
    internal class FuncionariosController
    {
        public List<Funcionarios> ListaFuncionario = new List<Funcionarios>();

        public void CadastrarFuncionario(string nome, string email, string matricula)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || String.IsNullOrEmpty(matricula))
            {
                return;
            }
            Funcionarios funcionarios = new Funcionarios(nome, email, matricula);
            ListaFuncionario.Add(funcionarios);
        }
        public List<Funcionarios> funcionarios1() 
        {
            return ListaFuncionario;
        }
    }
}
