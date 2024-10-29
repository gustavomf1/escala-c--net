namespace EscalasAgent
{
    partial class FrmCadEscala
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
            label7 = new Label();
            dtdata = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbpessoasextras = new ComboBox();
            cbequipe = new ComboBox();
            txtdescricao = new TextBox();
            label3 = new Label();
            txttitulo = new TextBox();
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
            pdados.Controls.Add(label7);
            pdados.Controls.Add(dtdata);
            pdados.Controls.Add(label6);
            pdados.Controls.Add(label4);
            pdados.Controls.Add(label5);
            pdados.Controls.Add(cbpessoasextras);
            pdados.Controls.Add(cbequipe);
            pdados.Controls.Add(txtdescricao);
            pdados.Controls.Add(label3);
            pdados.Controls.Add(txttitulo);
            pdados.Controls.Add(label2);
            pdados.Controls.Add(txtid);
            pdados.Controls.Add(label1);
            pdados.Dock = DockStyle.Top;
            pdados.Location = new Point(0, 0);
            pdados.Name = "pdados";
            pdados.Size = new Size(800, 344);
            pdados.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(437, 119);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 14;
            label7.Text = "Data";
            // 
            // dtdata
            // 
            dtdata.Format = DateTimePickerFormat.Short;
            dtdata.Location = new Point(437, 157);
            dtdata.Name = "dtdata";
            dtdata.Size = new Size(200, 23);
            dtdata.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(536, 340);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 27);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 11;
            label4.Text = "Pessoas Extras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 27);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Equipes";
            // 
            // cbpessoasextras
            // 
            cbpessoasextras.FormattingEnabled = true;
            cbpessoasextras.Location = new Point(555, 59);
            cbpessoasextras.Name = "cbpessoasextras";
            cbpessoasextras.Size = new Size(144, 23);
            cbpessoasextras.TabIndex = 9;
            // 
            // cbequipe
            // 
            cbequipe.FormattingEnabled = true;
            cbequipe.Location = new Point(356, 59);
            cbequipe.Name = "cbequipe";
            cbequipe.Size = new Size(144, 23);
            cbequipe.TabIndex = 8;
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(36, 157);
            txtdescricao.Multiline = true;
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(289, 157);
            txtdescricao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 119);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // txttitulo
            // 
            txttitulo.Location = new Point(201, 59);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(100, 23);
            txttitulo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 27);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Titulo";
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(36, 59);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
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
            pbotoes.Location = new Point(0, 350);
            pbotoes.Name = "pbotoes";
            pbotoes.Size = new Size(800, 100);
            pbotoes.TabIndex = 1;
            // 
            // btnlocalizar
            // 
            btnlocalizar.Location = new Point(605, 39);
            btnlocalizar.Name = "btnlocalizar";
            btnlocalizar.Size = new Size(75, 23);
            btnlocalizar.TabIndex = 11;
            btnlocalizar.Text = "Localizar";
            btnlocalizar.UseVisualStyleBackColor = true;
            btnlocalizar.Click += btnlocalizar_Click_1;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(511, 39);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 10;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click_1;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(411, 39);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 9;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(315, 39);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(75, 23);
            btnsalvar.TabIndex = 8;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click_1;
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(212, 39);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(75, 23);
            btnalterar.TabIndex = 7;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click_1;
            // 
            // btnnovo
            // 
            btnnovo.Location = new Point(120, 39);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(75, 23);
            btnnovo.TabIndex = 6;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click_1;
            // 
            // FrmCadEscala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbotoes);
            Controls.Add(pdados);
            Name = "FrmCadEscala";
            Text = "FrmCadEscala";
            Load += FrmCadEscala_Load;
            pdados.ResumeLayout(false);
            pdados.PerformLayout();
            pbotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pdados;
        private Panel pbotoes;
        private TextBox txtidequipe;
        private TextBox txtdescricao;
        private Label label3;
        private TextBox txttitulo;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private ComboBox cbequipe;
        private ComboBox cbpessoasextras;
        private Label label5;
        private Label label6;
        private Label label4;
        private Button btnlocalizar;
        private Button btnexcluir;
        private Button btncancelar;
        private Button btnsalvar;
        private Button btnalterar;
        private Button btnnovo;
        private Label label7;
        private DateTimePicker dtdata;
    }
}