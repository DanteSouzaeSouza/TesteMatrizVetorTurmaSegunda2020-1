namespace TesteMatrizVetorTurmaSegunda2020_1
{
    partial class FrmVetorMatriz
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
            this.lstVetor = new System.Windows.Forms.ListBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.btnVetor = new System.Windows.Forms.Button();
            this.btnVetorFor = new System.Windows.Forms.Button();
            this.lstTransposta = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVetor
            // 
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.Location = new System.Drawing.Point(23, 42);
            this.lstVetor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(91, 160);
            this.lstVetor.TabIndex = 0;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(158, 11);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(90, 19);
            this.btnMatriz.TabIndex = 3;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.Location = new System.Drawing.Point(158, 42);
            this.lstMatriz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(234, 160);
            this.lstMatriz.TabIndex = 2;
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(23, 11);
            this.btnVetor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(90, 19);
            this.btnVetor.TabIndex = 1;
            this.btnVetor.Text = "Vetor (foreach)";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnVetorFor
            // 
            this.btnVetorFor.Location = new System.Drawing.Point(23, 206);
            this.btnVetorFor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVetorFor.Name = "btnVetorFor";
            this.btnVetorFor.Size = new System.Drawing.Size(90, 19);
            this.btnVetorFor.TabIndex = 4;
            this.btnVetorFor.Text = "Vetor (for)";
            this.btnVetorFor.UseVisualStyleBackColor = true;
            this.btnVetorFor.Click += new System.EventHandler(this.btnVetorFor_Click);
            // 
            // lstTransposta
            // 
            this.lstTransposta.FormattingEnabled = true;
            this.lstTransposta.Location = new System.Drawing.Point(419, 42);
            this.lstTransposta.Margin = new System.Windows.Forms.Padding(2);
            this.lstTransposta.Name = "lstTransposta";
            this.lstTransposta.Size = new System.Drawing.Size(234, 160);
            this.lstTransposta.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = ">>";
            // 
            // FrmVetorMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTransposta);
            this.Controls.Add(this.btnVetorFor);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnVetor);
            this.Controls.Add(this.lstVetor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVetorMatriz";
            this.Text = "Testes Vetor e Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVetor;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox lstMatriz;
        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnVetorFor;
        private System.Windows.Forms.ListBox lstTransposta;
        private System.Windows.Forms.Label label1;
    }
}

