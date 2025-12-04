using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using AtividadeTarefa.Model;
using AtividadeTarefa;
namespace AtividadeTarefa.Controller
{
    internal class TarefaController
    {
        List<Tarefa> listaTarefa = new List<Tarefa>();
        
        public void cadastrarTarefa(string nomeTarefa, string data, string status)
        {
            if (string.IsNullOrEmpty(nomeTarefa) || string.IsNullOrEmpty(data) || string.IsNullOrEmpty(status))
            {
                return;
            }
            Tarefa tarefa = new Tarefa(nomeTarefa, data, status);
            listaTarefa.Add(tarefa);
        }
        public List<Tarefa> listarTarefa() 
        {
            return listaTarefa;
        }
      
    }
}
