namespace Cadastro_20_10_2023
{
    partial class ListaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFuncionario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nome,
            this.dataNascimento,
            this.telefone,
            this.email,
            this.rg,
            this.cpf,
            this.funcao,
            this.estCivil,
            this.salario});
            this.dataGridView1.Location = new System.Drawing.Point(116, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 520);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // dataNascimento
            // 
            this.dataNascimento.HeaderText = "Data de Nascimento";
            this.dataNascimento.MinimumWidth = 6;
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            this.dataNascimento.Width = 125;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 6;
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.MinimumWidth = 6;
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 125;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 6;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 125;
            // 
            // funcao
            // 
            this.funcao.HeaderText = "Função";
            this.funcao.MinimumWidth = 6;
            this.funcao.Name = "funcao";
            this.funcao.ReadOnly = true;
            this.funcao.Width = 125;
            // 
            // estCivil
            // 
            this.estCivil.HeaderText = "Estado civil";
            this.estCivil.MinimumWidth = 6;
            this.estCivil.Name = "estCivil";
            this.estCivil.ReadOnly = true;
            this.estCivil.Width = 125;
            // 
            // salario
            // 
            this.salario.HeaderText = "Salário";
            this.salario.MinimumWidth = 6;
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            this.salario.Width = 125;
            // 
            // ListaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 674);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(969, 520);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListaFuncionario";
            this.Text = "ListaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
    }
}