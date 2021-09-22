
namespace AulaFuncaoMultiRetorno
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
            this.rbexec01 = new System.Windows.Forms.RadioButton();
            this.rbexec02 = new System.Windows.Forms.RadioButton();
            this.rbexec04 = new System.Windows.Forms.RadioButton();
            this.btninicia = new System.Windows.Forms.Button();
            this.rbexec03 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbexec01
            // 
            this.rbexec01.AutoSize = true;
            this.rbexec01.Location = new System.Drawing.Point(12, 12);
            this.rbexec01.Name = "rbexec01";
            this.rbexec01.Size = new System.Drawing.Size(136, 35);
            this.rbexec01.TabIndex = 0;
            this.rbexec01.TabStop = true;
            this.rbexec01.Text = "EXEC01";
            this.rbexec01.UseVisualStyleBackColor = true;
            // 
            // rbexec02
            // 
            this.rbexec02.AutoSize = true;
            this.rbexec02.Location = new System.Drawing.Point(12, 68);
            this.rbexec02.Name = "rbexec02";
            this.rbexec02.Size = new System.Drawing.Size(136, 35);
            this.rbexec02.TabIndex = 1;
            this.rbexec02.TabStop = true;
            this.rbexec02.Text = "EXEC02";
            this.rbexec02.UseVisualStyleBackColor = true;
            // 
            // rbexec04
            // 
            this.rbexec04.AutoSize = true;
            this.rbexec04.Location = new System.Drawing.Point(12, 190);
            this.rbexec04.Name = "rbexec04";
            this.rbexec04.Size = new System.Drawing.Size(136, 35);
            this.rbexec04.TabIndex = 3;
            this.rbexec04.TabStop = true;
            this.rbexec04.Text = "EXEC04";
            this.rbexec04.UseVisualStyleBackColor = true;
            // 
            // btninicia
            // 
            this.btninicia.Location = new System.Drawing.Point(250, 266);
            this.btninicia.Name = "btninicia";
            this.btninicia.Size = new System.Drawing.Size(226, 107);
            this.btninicia.TabIndex = 4;
            this.btninicia.Text = "INICIA";
            this.btninicia.UseVisualStyleBackColor = true;
            this.btninicia.Click += new System.EventHandler(this.btninicia_Click);
            // 
            // rbexec03
            // 
            this.rbexec03.AutoSize = true;
            this.rbexec03.Location = new System.Drawing.Point(12, 127);
            this.rbexec03.Name = "rbexec03";
            this.rbexec03.Size = new System.Drawing.Size(136, 35);
            this.rbexec03.TabIndex = 5;
            this.rbexec03.TabStop = true;
            this.rbexec03.Text = "EXEC03";
            this.rbexec03.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 417);
            this.Controls.Add(this.rbexec03);
            this.Controls.Add(this.btninicia);
            this.Controls.Add(this.rbexec04);
            this.Controls.Add(this.rbexec02);
            this.Controls.Add(this.rbexec01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbexec01;
        private System.Windows.Forms.RadioButton rbexec02;
        private System.Windows.Forms.RadioButton rbexec04;
        private System.Windows.Forms.Button btninicia;
        private System.Windows.Forms.RadioButton rbexec03;
    }
}

