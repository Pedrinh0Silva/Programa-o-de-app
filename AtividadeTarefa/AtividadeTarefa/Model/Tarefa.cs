 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AtividadeTarefa.Model
{
    internal class Tarefa
    {
        public string nomeTarefa { get; set;}
        public string data { get; set;}
        public string status { get; set;}
        
         
       
        public Tarefa(string nomeTarefa, string data, string status) 
        {
            this.nomeTarefa = nomeTarefa;
            this.data = data;
            this.status = status;
        }
    }
}
