namespace EstudoIfElse
{
    partial class frmIfElse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnVerificarIdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a idade desejada:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(139, 6);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // btnVerificarIdade
            // 
            this.btnVerificarIdade.Location = new System.Drawing.Point(245, 4);
            this.btnVerificarIdade.Name = "btnVerificarIdade";
            this.btnVerificarIdade.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarIdade.TabIndex = 2;
            this.btnVerificarIdade.Text = "Verificar";
            this.btnVerificarIdade.UseVisualStyleBackColor = true;
            this.btnVerificarIdade.Click += new System.EventHandler(this.btnVerificarIdade_Click);
            // 
            // frmIfElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 33);
            this.Controls.Add(this.btnVerificarIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Name = "frmIfElse";
            this.Text = "Estudo de If/Else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnVerificarIdade;
    }
}

