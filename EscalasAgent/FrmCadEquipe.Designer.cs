namespace EscalasAgent
{
    partial class FrmCadEquipe
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
            txtnome = new TextBox();
            txtid = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pbotao = new Panel();
            btnlocalizar = new Button();
            btnexcluir = new Button();
            btncancelar = new Button();
            btnsalvar = new Button();
            btnalterar = new Button();
            btnnovo = new Button();
            pdados.SuspendLayout();
            pbotao.SuspendLayout();
            SuspendLayout();
            // 
            // pdados
            // 
            pdados.Controls.Add(txtnome);
            pdados.Controls.Add(txtid);
            pdados.Controls.Add(label2);
            pdados.Controls.Add(label1);
            pdados.Dock = DockStyle.Top;
            pdados.Location = new Point(0, 0);
            pdados.Name = "pdados";
            pdados.Size = new Size(800, 344);
            pdados.TabIndex = 0;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(63, 198);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(189, 23);
            txtnome.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(63, 102);
            txtid.Name = "txtid";
            txtid.Size = new Size(189, 23);
            txtid.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 161);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 64);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // pbotao
            // 
            pbotao.Controls.Add(btnlocalizar);
            pbotao.Controls.Add(btnexcluir);
            pbotao.Controls.Add(btncancelar);
            pbotao.Controls.Add(btnsalvar);
            pbotao.Controls.Add(btnalterar);
            pbotao.Controls.Add(btnnovo);
            pbotao.Dock = DockStyle.Bottom;
            pbotao.Location = new Point(0, 350);
            pbotao.Name = "pbotao";
            pbotao.Size = new Size(800, 100);
            pbotao.TabIndex = 1;
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
            btncancelar.Click += btncancelar_Click_1;
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
            btnnovo.Click += btnnovo_Click;
            // 
            // FrmCadEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbotao);
            Controls.Add(pdados);
            Name = "FrmCadEquipe";
            Text = "FrmCadEquipe";
            pdados.ResumeLayout(false);
            pdados.PerformLayout();
            pbotao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pdados;
        private Panel pbotao;
        private TextBox txtnome;
        private TextBox txtid;
        private Label label2;
        private Label label1;
        private Button btnlocalizar;
        private Button btnexcluir;
        private Button btncancelar;
        private Button btnsalvar;
        private Button btnalterar;
        private Button btnnovo;
    }
}