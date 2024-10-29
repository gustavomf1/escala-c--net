namespace EscalasAgent
{
    partial class FrmCadPessoa
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
            pdados = new Panel();
            txtsenha = new TextBox();
            label8 = new Label();
            txtemail = new TextBox();
            label7 = new Label();
            Equipes = new Label();
            cbEquipe = new ComboBox();
            label6 = new Label();
            txtativo = new TextBox();
            label5 = new Label();
            txtidequipe = new TextBox();
            label4 = new Label();
            txtcpf = new TextBox();
            label3 = new Label();
            txtnome = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label1 = new Label();
            pbotoes = new Panel();
            btnlocalizar = new Button();
            btnexcluir = new Button();
            btncancelar = new Button();
            btnsalvar = new Button();
            btnalterar = new Button();
            btnnovo = new Button();
            pdados.SuspendLayout();
            pbotoes.SuspendLayout();
            SuspendLayout();
            // 
            // pdados
            // 
            pdados.Controls.Add(txtsenha);
            pdados.Controls.Add(label8);
            pdados.Controls.Add(txtemail);
            pdados.Controls.Add(label7);
            pdados.Controls.Add(Equipes);
            pdados.Controls.Add(cbEquipe);
            pdados.Controls.Add(label6);
            pdados.Controls.Add(txtativo);
            pdados.Controls.Add(label5);
            pdados.Controls.Add(txtidequipe);
            pdados.Controls.Add(label4);
            pdados.Controls.Add(txtcpf);
            pdados.Controls.Add(label3);
            pdados.Controls.Add(txtnome);
            pdados.Controls.Add(label2);
            pdados.Controls.Add(txtid);
            pdados.Controls.Add(label1);
            pdados.Dock = DockStyle.Top;
            pdados.Location = new Point(0, 0);
            pdados.Name = "pdados";
            pdados.Size = new Size(623, 344);
            pdados.TabIndex = 0;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(178, 195);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(174, 164);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "Senha";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(182, 126);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(100, 23);
            txtemail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 95);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // Equipes
            // 
            Equipes.AutoSize = true;
            Equipes.Location = new Point(353, 173);
            Equipes.Name = "Equipes";
            Equipes.Size = new Size(48, 15);
            Equipes.TabIndex = 12;
            Equipes.Text = "Equipes";
            // 
            // cbEquipe
            // 
            cbEquipe.FormattingEnabled = true;
            cbEquipe.Location = new Point(353, 195);
            cbEquipe.Name = "cbEquipe";
            cbEquipe.Size = new Size(121, 23);
            cbEquipe.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 27);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 10;
            label6.Text = "Código";
            // 
            // txtativo
            // 
            txtativo.Location = new Point(182, 58);
            txtativo.Name = "txtativo";
            txtativo.ReadOnly = true;
            txtativo.Size = new Size(100, 23);
            txtativo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 27);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Ativo";
            // 
            // txtidequipe
            // 
            txtidequipe.Location = new Point(353, 126);
            txtidequipe.Name = "txtidequipe";
            txtidequipe.Size = new Size(100, 23);
            txtidequipe.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 104);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 6;
            label4.Text = "Código Equipe";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(37, 195);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(100, 23);
            txtcpf.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 164);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(37, 126);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtid
            // 
            txtid.Location = new Point(37, 58);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // pbotoes
            // 
            pbotoes.Controls.Add(btnlocalizar);
            pbotoes.Controls.Add(btnexcluir);
            pbotoes.Controls.Add(btncancelar);
            pbotoes.Controls.Add(btnsalvar);
            pbotoes.Controls.Add(btnalterar);
            pbotoes.Controls.Add(btnnovo);
            pbotoes.Dock = DockStyle.Bottom;
            pbotoes.Location = new Point(0, 302);
            pbotoes.Name = "pbotoes";
            pbotoes.Size = new Size(623, 100);
            pbotoes.TabIndex = 1;
            // 
            // btnlocalizar
            // 
            btnlocalizar.Location = new Point(514, 35);
            btnlocalizar.Name = "btnlocalizar";
            btnlocalizar.Size = new Size(75, 23);
            btnlocalizar.TabIndex = 5;
            btnlocalizar.Text = "Localizar";
            btnlocalizar.UseVisualStyleBackColor = true;
            btnlocalizar.Click += btnlocalizar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(420, 35);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 4;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(320, 35);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(224, 35);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(75, 23);
            btnsalvar.TabIndex = 2;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(121, 35);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(75, 23);
            btnalterar.TabIndex = 1;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click;
            // 
            // btnnovo
            // 
            btnnovo.Location = new Point(29, 35);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(75, 23);
            btnnovo.TabIndex = 0;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // FrmCadPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 402);
            Controls.Add(pbotoes);
            Controls.Add(pdados);
            Name = "FrmCadPessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pessoa";
            Load += FrmCadPessoa_Load;
            pdados.ResumeLayout(false);
            pdados.PerformLayout();
            pbotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pdados;
        private TextBox txtid;
        private Label label1;
        private Panel pbotoes;
        private TextBox txtativo;
        private Label label5;
        private TextBox txtidequipe;
        private Label label4;
        private TextBox txtcpf;
        private Label label3;
        private TextBox txtnome;
        private Label label2;
        private Label label6;
        private Button btnlocalizar;
        private Button btnexcluir;
        private Button btncancelar;
        private Button btnsalvar;
        private Button btnalterar;
        private Button btnnovo;
        private Label Equipes;
        private ComboBox cbEquipe;
        private TextBox txtsenha;
        private Label label8;
        private TextBox txtemail;
        private Label label7;
    }
}