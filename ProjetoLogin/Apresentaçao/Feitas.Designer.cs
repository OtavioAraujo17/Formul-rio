namespace ProjetoLogin.Apresentaçao
{
    partial class Feitas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 131);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemover.Location = new System.Drawing.Point(235, 277);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(87, 32);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnRemover2
            // 
            this.btnRemover2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemover2.Location = new System.Drawing.Point(235, 491);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(87, 32);
            this.btnRemover2.TabIndex = 7;
            this.btnRemover2.Text = "remover";
            this.btnRemover2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 354);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 131);
            this.textBox2.TabIndex = 4;
            // 
            // Feitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 588);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.textBox1);
            this.Name = "Feitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feitas";
            this.Load += new System.EventHandler(this.Feitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.TextBox textBox2;
    }
}