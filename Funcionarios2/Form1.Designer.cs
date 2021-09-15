
namespace Funcionarios2
{
    partial class Funcionários
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNome = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lNascimento = new System.Windows.Forms.Label();
            this.lContratacao = new System.Windows.Forms.Label();
            this.dtpContratacao = new System.Windows.Forms.DateTimePicker();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lSetor = new System.Windows.Forms.Label();
            this.tbSetor = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.collId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collContratacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAlterar = new System.Windows.Forms.Button();
            this.bDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(41, 40);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(55, 20);
            this.lNome.TabIndex = 0;
            this.lNome.Text = "Nome:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "yyy/MM/dd";
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(205, 107);
            this.dtpNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.ShowUpDown = true;
            this.dtpNascimento.Size = new System.Drawing.Size(124, 26);
            this.dtpNascimento.TabIndex = 1;
            this.dtpNascimento.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lNascimento
            // 
            this.lNascimento.AutoSize = true;
            this.lNascimento.Location = new System.Drawing.Point(41, 107);
            this.lNascimento.Name = "lNascimento";
            this.lNascimento.Size = new System.Drawing.Size(158, 20);
            this.lNascimento.TabIndex = 2;
            this.lNascimento.Text = "Data de Nascimento:";
            // 
            // lContratacao
            // 
            this.lContratacao.AutoSize = true;
            this.lContratacao.Location = new System.Drawing.Point(356, 107);
            this.lContratacao.Name = "lContratacao";
            this.lContratacao.Size = new System.Drawing.Size(162, 20);
            this.lContratacao.TabIndex = 3;
            this.lContratacao.Text = "Data da Contratação:";
            // 
            // dtpContratacao
            // 
            this.dtpContratacao.CustomFormat = "yyyy/MM/dd";
            this.dtpContratacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContratacao.Location = new System.Drawing.Point(524, 107);
            this.dtpContratacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpContratacao.Name = "dtpContratacao";
            this.dtpContratacao.ShowUpDown = true;
            this.dtpContratacao.Size = new System.Drawing.Size(124, 26);
            this.dtpContratacao.TabIndex = 4;
            this.dtpContratacao.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(101, 37);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(228, 26);
            this.tbNome.TabIndex = 5;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // lSetor
            // 
            this.lSetor.AutoSize = true;
            this.lSetor.Location = new System.Drawing.Point(356, 40);
            this.lSetor.Name = "lSetor";
            this.lSetor.Size = new System.Drawing.Size(142, 20);
            this.lSetor.TabIndex = 6;
            this.lSetor.Text = "Setor da Empresa:";
            // 
            // tbSetor
            // 
            this.tbSetor.Location = new System.Drawing.Point(524, 37);
            this.tbSetor.Name = "tbSetor";
            this.tbSetor.Size = new System.Drawing.Size(228, 26);
            this.tbSetor.TabIndex = 7;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(79, 169);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(120, 41);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(372, 170);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(104, 41);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collId,
            this.collNome,
            this.collNascimento,
            this.collContratacao,
            this.collSetor});
            this.dataGridView1.Location = new System.Drawing.Point(31, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 195);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // collId
            // 
            this.collId.HeaderText = "Id";
            this.collId.MinimumWidth = 3;
            this.collId.Name = "collId";
            this.collId.Width = 150;
            // 
            // collNome
            // 
            this.collNome.HeaderText = "Nome";
            this.collNome.MinimumWidth = 8;
            this.collNome.Name = "collNome";
            this.collNome.Width = 150;
            // 
            // collNascimento
            // 
            this.collNascimento.HeaderText = "Data de nascimento";
            this.collNascimento.MinimumWidth = 8;
            this.collNascimento.Name = "collNascimento";
            this.collNascimento.Width = 150;
            // 
            // collContratacao
            // 
            this.collContratacao.HeaderText = "Data da contratação";
            this.collContratacao.MinimumWidth = 8;
            this.collContratacao.Name = "collContratacao";
            this.collContratacao.Width = 150;
            // 
            // collSetor
            // 
            this.collSetor.HeaderText = "Setor da Empresa";
            this.collSetor.MinimumWidth = 8;
            this.collSetor.Name = "collSetor";
            this.collSetor.Width = 150;
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(225, 169);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(124, 42);
            this.bAlterar.TabIndex = 11;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // bDeletar
            // 
            this.bDeletar.Location = new System.Drawing.Point(493, 170);
            this.bDeletar.Name = "bDeletar";
            this.bDeletar.Size = new System.Drawing.Size(104, 41);
            this.bDeletar.TabIndex = 12;
            this.bDeletar.Text = "Deletar";
            this.bDeletar.UseVisualStyleBackColor = true;
            this.bDeletar.Click += new System.EventHandler(this.bDeletar_Click);
            // 
            // Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bDeletar);
            this.Controls.Add(this.bAlterar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbSetor);
            this.Controls.Add(this.lSetor);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.dtpContratacao);
            this.Controls.Add(this.lContratacao);
            this.Controls.Add(this.lNascimento);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lNome);
            this.Name = "Funcionários";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Funcionários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lNascimento;
        private System.Windows.Forms.Label lContratacao;
        private System.Windows.Forms.DateTimePicker dtpContratacao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lSetor;
        private System.Windows.Forms.TextBox tbSetor;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn collId;
        private System.Windows.Forms.DataGridViewTextBoxColumn collNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn collNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn collContratacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn collSetor;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Button bDeletar;
    }
}

