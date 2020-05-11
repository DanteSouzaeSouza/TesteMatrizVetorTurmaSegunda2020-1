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
            this.SuspendLayout();
            // 
            // lstVetor
            // 
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.ItemHeight = 16;
            this.lstVetor.Location = new System.Drawing.Point(31, 52);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(120, 196);
            this.lstVetor.TabIndex = 0;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(210, 13);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(120, 23);
            this.btnMatriz.TabIndex = 3;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.ItemHeight = 16;
            this.lstMatriz.Location = new System.Drawing.Point(210, 52);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(120, 196);
            this.lstMatriz.TabIndex = 2;
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(31, 13);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(120, 23);
            this.btnVetor.TabIndex = 1;
            this.btnVetor.Text = "Vetor (foreach)";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // btnVetorFor
            // 
            this.btnVetorFor.Location = new System.Drawing.Point(31, 254);
            this.btnVetorFor.Name = "btnVetorFor";
            this.btnVetorFor.Size = new System.Drawing.Size(120, 23);
            this.btnVetorFor.TabIndex = 4;
            this.btnVetorFor.Text = "Vetor (for)";
            this.btnVetorFor.UseVisualStyleBackColor = true;
            this.btnVetorFor.Click += new System.EventHandler(this.btnVetorFor_Click);
            // 
            // FrmVetorMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.btnVetorFor);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnVetor);
            this.Controls.Add(this.lstVetor);
            this.Name = "FrmVetorMatriz";
            this.Text = "Testes Vetor e Matriz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVetor;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox lstMatriz;
        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Button btnVetorFor;
    }
}

