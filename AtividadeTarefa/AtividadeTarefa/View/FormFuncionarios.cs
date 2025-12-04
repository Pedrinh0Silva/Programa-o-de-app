using AtividadeTarefa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace AtividadeTarefa.View
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            ConfigurarGridF();
        }

        DataTable ListaF = new DataTable();
        FuncionariosController FuncionariosController = new FuncionariosController();


        public void ConfigurarGridF()
        {
            if (ListaF.Columns.Count == 0)
            {
                ListaF.Columns.Add("Nome Do Funcionário");
                ListaF.Columns.Add("Email");
                ListaF.Columns.Add("Matrícula");
            }
            GridFuncionarios.DataSource = ListaF;
            GridFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void CadastroF_Click(object sender, EventArgs e)
        {
            string nome = txtNomeF.Text;
            string Email = txtEmail.Text;
            string Matricula = txtMatricula.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Matricula))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios: Nome, Email e Matrícula.");
            }

            try
            {
                FuncionariosController.CadastrarFuncionario(nome, Email, Matricula);
                MessageBox.Show($"As inforamções: {nome}, {Email}, {Matricula}. Foram cadastradas com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ao Matricular-se{ex}");
            }

            ListaF.Clear();

            var ListaFun = FuncionariosController.funcionarios1();
            GridFuncionarios.DataSource = null;
            GridFuncionarios.DataSource = ListaFun;


            txtEmail.Clear();
            txtMatricula.Clear();
            txtNomeF.Clear();
        }
    }
}
