namespace EscalasAgent
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
            btnacessar = new Button();
            SuspendLayout();
            // 
            // btnacessar
            // 
            btnacessar.Location = new Point(320, 197);
            btnacessar.Name = "btnacessar";
            btnacessar.Size = new Size(75, 23);
            btnacessar.TabIndex = 0;
            btnacessar.Text = "Acessar";
            btnacessar.UseVisualStyleBackColor = true;
            btnacessar.Click += btnacessar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnacessar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnacessar;
    }
}
