namespace AtividadeTarefa.View
{
    partial class FormFuncionarios : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFuncionarios = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GridFuncionarios = new DataGridView();
            txtNomeF = new TextBox();
            txtMatricula = new TextBox();
            txtEmail = new TextBox();
            CadastroF = new Button();
            lblListaF = new Label();
            ((System.ComponentModel.ISupportInitialize)GridFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionarios.Location = new Point(481, 43);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(166, 36);
            lblFuncionarios.TabIndex = 0;
            lblFuncionarios.Text = "Funcionários";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(379, 167);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(379, 258);
            label2.Name = "label2";
            label2.Size = new Size(64, 30);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(379, 213);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 3;
            label3.Text = "Matrícula";
            // 
            // GridFuncionarios
            // 
            GridFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFuncionarios.Location = new Point(1, 459);
            GridFuncionarios.Name = "GridFuncionarios";
            GridFuncionarios.Size = new Size(1006, 150);
            GridFuncionarios.TabIndex = 4;
            // 
            // txtNomeF
            // 
            txtNomeF.Location = new Point(481, 176);
            txtNomeF.Name = "txtNomeF";
            txtNomeF.Size = new Size(164, 23);
            txtNomeF.TabIndex = 5;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(481, 222);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(164, 23);
            txtMatricula.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(481, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 7;
            // 
            // CadastroF
            // 
            CadastroF.Font = new Font("Segoe UI", 12F);
            CadastroF.Location = new Point(506, 309);
            CadastroF.Name = "CadastroF";
            CadastroF.Size = new Size(113, 29);
            CadastroF.TabIndex = 8;
            CadastroF.Text = "Matrícular-se";
            CadastroF.UseVisualStyleBackColor = true;
            CadastroF.Click += CadastroF_Click;
            // 
            // lblListaF
            // 
            lblListaF.AutoSize = true;
            lblListaF.Font = new Font("Segoe UI", 18F);
            lblListaF.Location = new Point(445, 379);
            lblListaF.Name = "lblListaF";
            lblListaF.Size = new Size(237, 32);
            lblListaF.TabIndex = 9;
            lblListaF.Text = "Lista de Funcionários";
            // 
            // FormFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1005, 677);
            Controls.Add(lblListaF);
            Controls.Add(CadastroF);
            Controls.Add(txtEmail);
            Controls.Add(txtMatricula);
            Controls.Add(txtNomeF);
            Controls.Add(GridFuncionarios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFuncionarios);
            Name = "FormFuncionarios";
            Text = "FormFuncionarios";
            ((System.ComponentModel.ISupportInitialize)GridFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncionarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView GridFuncionarios;
        private TextBox txtNomeF;
        private TextBox txtMatricula;
        private TextBox txtEmail;
        private Button CadastroF;
        private Label lblListaF;
    }
}