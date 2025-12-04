using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTarefa.Model
{
    internal class Funcionarios
    {
       public string nome { get; set; }
       public string email { get; set; }
       public string matricula { get; set; }

        public Funcionarios( string nome, string email, string matricula ) 
        { 
            this.nome = nome;
            this.email = email;
            this.matricula = matricula;
        }
    }
}
