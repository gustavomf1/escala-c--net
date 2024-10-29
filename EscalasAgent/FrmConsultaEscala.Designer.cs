namespace EscalasAgent
{
    partial class FrmConsultaEscala
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
            panel1 = new Panel();
            btnconsultar = new Button();
            txtconsulta = new TextBox();
            label1 = new Label();
            dgdados = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnconsultar);
            panel1.Controls.Add(txtconsulta);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 294);
            panel1.TabIndex = 1;
            // 
            // btnconsultar
            // 
            btnconsultar.Location = new Point(585, 95);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(75, 23);
            btnconsultar.TabIndex = 7;
            btnconsultar.Text = "Consultar";
            btnconsultar.UseVisualStyleBackColor = true;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // txtconsulta
            // 
            txtconsulta.Location = new Point(89, 95);
            txtconsulta.Name = "txtconsulta";
            txtconsulta.Size = new Size(448, 23);
            txtconsulta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 54);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 5;
            label1.Text = "Pesquisar por nome";
            // 
            // dgdados
            // 
            dgdados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdados.Dock = DockStyle.Bottom;
            dgdados.Location = new Point(0, 300);
            dgdados.Name = "dgdados";
            dgdados.Size = new Size(800, 150);
            dgdados.TabIndex = 7;
            dgdados.CellDoubleClick += dgdados_CellDoubleClick;
            // 
            // FrmConsultaEscala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgdados);
            Controls.Add(panel1);
            Name = "FrmConsultaEscala";
            Text = "FrmConsultaEscala";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgdados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnconsultar;
        private TextBox txtconsulta;
        private Label label1;
        private DataGridView dgdados;
    }
}