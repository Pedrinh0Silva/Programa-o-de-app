using AtividadeTarefa.Controller;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AtividadeTarefa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        DataTable tabelaTarefas = new DataTable();
        TarefaController TarefaController = new TarefaController();

        public void ConfigurarGrid()
        {
            if (tabelaTarefas.Columns.Count == 0)
            {
                tabelaTarefas.Columns.Add("Tarefa");
                tabelaTarefas.Columns.Add("Data");
                tabelaTarefas.Columns.Add("Status");
            }
            GridTarefa.DataSource = tabelaTarefas;
            GridTarefa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void bntCadastrar_Click_1(object sender, EventArgs e)
        {
            string status = CbxStatusAtividade.Text;
            string Data = CalendarioTarefa.Value.ToShortDateString();
            string nomeTarefa = txtNomeTarefa.Text;


            if (string.IsNullOrEmpty(nomeTarefa))
            {
                MessageBox.Show("Preencha o campo com o nome da tarefa");
            }
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Preencha o campo com o status da terefa");
            }
            try
            {
                TarefaController.cadastrarTarefa(nomeTarefa, Data, status);
                MessageBox.Show($"Demanda {nomeTarefa}, com a data {Data}. Criada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ao cadastrar {ex}");
            }

            tabelaTarefas.Clear();

            var listagem = TarefaController.listarTarefa();
            foreach (var item in listagem)
            {
                tabelaTarefas.Rows.Add(item.nomeTarefa, item.data, item.status);
            }
            txtNomeTarefa.Clear();
            CbxStatusAtividade.SelectedIndex = -1;

        }
    }
}