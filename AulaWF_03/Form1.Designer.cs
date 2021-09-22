
namespace AulaWF_03
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbexec01 = new System.Windows.Forms.RadioButton();
            this.rdbexec02 = new System.Windows.Forms.RadioButton();
            this.btnescolher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbexec01
            // 
            this.rdbexec01.AutoSize = true;
            this.rdbexec01.Location = new System.Drawing.Point(12, 12);
            this.rdbexec01.Name = "rdbexec01";
            this.rdbexec01.Size = new System.Drawing.Size(220, 35);
            this.rdbexec01.TabIndex = 0;
            this.rdbexec01.TabStop = true;
            this.rdbexec01.Text = "EXERCICIO 01";
            this.rdbexec01.UseVisualStyleBackColor = true;
            // 
            // rdbexec02
            // 
            this.rdbexec02.AutoSize = true;
            this.rdbexec02.Location = new System.Drawing.Point(12, 62);
            this.rdbexec02.Name = "rdbexec02";
            this.rdbexec02.Size = new System.Drawing.Size(220, 35);
            this.rdbexec02.TabIndex = 1;
            this.rdbexec02.TabStop = true;
            this.rdbexec02.Text = "EXERCICIO 02";
            this.rdbexec02.UseVisualStyleBackColor = true;
            // 
            // btnescolher
            // 
            this.btnescolher.Location = new System.Drawing.Point(292, 25);
            this.btnescolher.Name = "btnescolher";
            this.btnescolher.Size = new System.Drawing.Size(275, 61);
            this.btnescolher.TabIndex = 2;
            this.btnescolher.Text = "ESCOLHER";
            this.btnescolher.UseVisualStyleBackColor = true;
            this.btnescolher.Click += new System.EventHandler(this.btnescolher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 493);
            this.Controls.Add(this.btnescolher);
            this.Controls.Add(this.rdbexec02);
            this.Controls.Add(this.rdbexec01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbexec01;
        private System.Windows.Forms.RadioButton rdbexec02;
        private System.Windows.Forms.Button btnescolher;
    }
}

