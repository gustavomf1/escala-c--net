namespace EscalasAgent
{
    partial class FrmConsultaEquipe
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
            label1 = new Label();
            txtconsulta = new TextBox();
            btnconsultar = new Button();
            dgdados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgdados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 28);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar por nome";
            // 
            // txtconsulta
            // 
            txtconsulta.Location = new Point(63, 69);
            txtconsulta.Name = "txtconsulta";
            txtconsulta.Size = new Size(448, 23);
            txtconsulta.TabIndex = 2;
            // 
            // btnconsultar
            // 
            btnconsultar.Location = new Point(559, 69);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(75, 23);
            btnconsultar.TabIndex = 4;
            btnconsultar.Text = "Consultar";
            btnconsultar.UseVisualStyleBackColor = true;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // dgdados
            // 
            dgdados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdados.Dock = DockStyle.Bottom;
            dgdados.Location = new Point(0, 300);
            dgdados.Name = "dgdados";
            dgdados.Size = new Size(800, 150);
            dgdados.TabIndex = 5;
            dgdados.CellDoubleClick += dgdados_CellDoubleClick;
            // 
            // FrmConsultaEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgdados);
            Controls.Add(btnconsultar);
            Controls.Add(txtconsulta);
            Controls.Add(label1);
            Name = "FrmConsultaEquipe";
            Text = "FrmConsultaEquipe";
            ((System.ComponentModel.ISupportInitialize)dgdados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtconsulta;
        private Button btnconsultar;
        private DataGridView dgdados;
    }
}