namespace AtividadeTarefa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCasdastrarTarefa = new Label();
            lblNomeTarefa = new Label();
            lblData = new Label();
            lblStatus = new Label();
            txtNomeTarefa = new TextBox();
            CalendarioTarefa = new DateTimePicker();
            bntCadastrar = new Button();
            CbxStatusAtividade = new ComboBox();
            GridTarefa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridTarefa).BeginInit();
            SuspendLayout();
            // 
            // lblCasdastrarTarefa
            // 
            lblCasdastrarTarefa.AutoSize = true;
            lblCasdastrarTarefa.Font = new Font("Segoe UI Variable Display", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCasdastrarTarefa.Location = new Point(379, 17);
            lblCasdastrarTarefa.Margin = new Padding(2, 0, 2, 0);
            lblCasdastrarTarefa.Name = "lblCasdastrarTarefa";
            lblCasdastrarTarefa.Size = new Size(190, 30);
            lblCasdastrarTarefa.TabIndex = 0;
            lblCasdastrarTarefa.Text = "Casdastrar Tarefas";
            // 
            // lblNomeTarefa
            // 
            lblNomeTarefa.AutoSize = true;
            lblNomeTarefa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeTarefa.Location = new Point(17, 92);
            lblNomeTarefa.Margin = new Padding(2, 0, 2, 0);
            lblNomeTarefa.Name = "lblNomeTarefa";
            lblNomeTarefa.Size = new Size(49, 20);
            lblNomeTarefa.TabIndex = 1;
            lblNomeTarefa.Text = "Tarefa";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(181, 92);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(511, 92);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(114, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status da Tarefa";
            // 
            // txtNomeTarefa
            // 
            txtNomeTarefa.Location = new Point(71, 92);
            txtNomeTarefa.Margin = new Padding(2);
            txtNomeTarefa.Name = "txtNomeTarefa";
            txtNomeTarefa.Size = new Size(106, 23);
            txtNomeTarefa.TabIndex = 4;
            // 
            // CalendarioTarefa
            // 
            CalendarioTarefa.Location = new Point(248, 92);
            CalendarioTarefa.Margin = new Padding(2);
            CalendarioTarefa.Name = "CalendarioTarefa";
            CalendarioTarefa.Size = new Size(247, 23);
            CalendarioTarefa.TabIndex = 7;
            // 
            // bntCadastrar
            // 
            bntCadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            bntCadastrar.FlatAppearance.BorderSize = 3;
            bntCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            bntCadastrar.Location = new Point(776, 91);
            bntCadastrar.Margin = new Padding(2);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(79, 22);
            bntCadastrar.TabIndex = 8;
            bntCadastrar.Text = "Casdastrar";
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += bntCadastrar_Click_1;
            // 
            // CbxStatusAtividade
            // 
            CbxStatusAtividade.FormattingEnabled = true;
            CbxStatusAtividade.Items.AddRange(new object[] { "Em andamento", "Em Pausa", "Concluida" });
            CbxStatusAtividade.Location = new Point(637, 91);
            CbxStatusAtividade.Margin = new Padding(2);
            CbxStatusAtividade.Name = "CbxStatusAtividade";
            CbxStatusAtividade.Size = new Size(118, 23);
            CbxStatusAtividade.TabIndex = 9;
            // 
            // GridTarefa
            // 
            GridTarefa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTarefa.Location = new Point(0, 132);
            GridTarefa.Name = "GridTarefa";
            GridTarefa.Size = new Size(877, 100);
            GridTarefa.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(875, 272);
            Controls.Add(GridTarefa);
            Controls.Add(CbxStatusAtividade);
            Controls.Add(bntCadastrar);
            Controls.Add(CalendarioTarefa);
            Controls.Add(txtNomeTarefa);
            Controls.Add(lblStatus);
            Controls.Add(lblData);
            Controls.Add(lblNomeTarefa);
            Controls.Add(lblCasdastrarTarefa);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridTarefa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCasdastrarTarefa;
        private Label lblNomeTarefa;
        private Label lblData;
        private Label lblStatus;
        private TextBox txtNomeTarefa;
        private DateTimePicker CalendarioTarefa;
        private Button bntCadastrar;
        private ComboBox CbxStatusAtividade;
        private DataGridView GridTarefa;
    }
}
