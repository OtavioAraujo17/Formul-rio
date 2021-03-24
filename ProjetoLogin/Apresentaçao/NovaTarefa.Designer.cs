namespace ProjetoLogin
{
    partial class NovaTarefa
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAdicionarTar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(40, 135);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(156, 22);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "descrição da tarefa:";
            // 
            // btnAdicionarTar
            // 
            this.btnAdicionarTar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionarTar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnAdicionarTar.Location = new System.Drawing.Point(44, 423);
            this.btnAdicionarTar.Name = "btnAdicionarTar";
            this.btnAdicionarTar.Size = new System.Drawing.Size(285, 32);
            this.btnAdicionarTar.TabIndex = 2;
            this.btnAdicionarTar.Text = "adicionar tarefa";
            this.btnAdicionarTar.UseVisualStyleBackColor = false;
            this.btnAdicionarTar.Click += new System.EventHandler(this.btnAdicionarTar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(44, 160);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(285, 243);
            this.txtDescricao.TabIndex = 3;
            // 
            // NovaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 588);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnAdicionarTar);
            this.Controls.Add(this.lblDescricao);
            this.Name = "NovaTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaTarefa";
            this.Load += new System.EventHandler(this.NovaTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnAdicionarTar;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}