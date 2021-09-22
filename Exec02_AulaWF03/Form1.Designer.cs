
namespace Exec02_AulaWF03
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
            this.btnexec02 = new System.Windows.Forms.Button();
            this.btnexec01 = new System.Windows.Forms.Button();
            this.btnexec03 = new System.Windows.Forms.Button();
            this.btnexec04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexec02
            // 
            this.btnexec02.Location = new System.Drawing.Point(189, 12);
            this.btnexec02.Name = "btnexec02";
            this.btnexec02.Size = new System.Drawing.Size(171, 65);
            this.btnexec02.TabIndex = 0;
            this.btnexec02.Text = "EXEC02";
            this.btnexec02.UseVisualStyleBackColor = true;
            this.btnexec02.Click += new System.EventHandler(this.btnexec02_Click);
            // 
            // btnexec01
            // 
            this.btnexec01.Location = new System.Drawing.Point(12, 12);
            this.btnexec01.Name = "btnexec01";
            this.btnexec01.Size = new System.Drawing.Size(171, 65);
            this.btnexec01.TabIndex = 1;
            this.btnexec01.Text = "EXEC01";
            this.btnexec01.UseVisualStyleBackColor = true;
            this.btnexec01.Click += new System.EventHandler(this.btnexec01_Click);
            // 
            // btnexec03
            // 
            this.btnexec03.Location = new System.Drawing.Point(366, 12);
            this.btnexec03.Name = "btnexec03";
            this.btnexec03.Size = new System.Drawing.Size(171, 65);
            this.btnexec03.TabIndex = 2;
            this.btnexec03.Text = "EXEC03";
            this.btnexec03.UseVisualStyleBackColor = true;
            this.btnexec03.Click += new System.EventHandler(this.btnexec03_Click);
            // 
            // btnexec04
            // 
            this.btnexec04.Location = new System.Drawing.Point(543, 12);
            this.btnexec04.Name = "btnexec04";
            this.btnexec04.Size = new System.Drawing.Size(171, 65);
            this.btnexec04.TabIndex = 3;
            this.btnexec04.Text = "EXEC04";
            this.btnexec04.UseVisualStyleBackColor = true;
            this.btnexec04.Click += new System.EventHandler(this.btnexec04_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 448);
            this.Controls.Add(this.btnexec04);
            this.Controls.Add(this.btnexec03);
            this.Controls.Add(this.btnexec01);
            this.Controls.Add(this.btnexec02);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexec02;
        private System.Windows.Forms.Button btnexec01;
        private System.Windows.Forms.Button btnexec03;
        private System.Windows.Forms.Button btnexec04;
    }
}

