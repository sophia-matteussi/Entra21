
namespace MVCp1
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
            this.rbexec02 = new System.Windows.Forms.RadioButton();
            this.rbexec01 = new System.Windows.Forms.RadioButton();
            this.rbexec03 = new System.Windows.Forms.RadioButton();
            this.btnavancar = new System.Windows.Forms.Button();
            this.rbtabela01 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbexec02
            // 
            this.rbexec02.AutoSize = true;
            this.rbexec02.Location = new System.Drawing.Point(12, 63);
            this.rbexec02.Name = "rbexec02";
            this.rbexec02.Size = new System.Drawing.Size(143, 35);
            this.rbexec02.TabIndex = 1;
            this.rbexec02.TabStop = true;
            this.rbexec02.Text = "EXEC 02";
            this.rbexec02.UseVisualStyleBackColor = true;
            // 
            // rbexec01
            // 
            this.rbexec01.AutoSize = true;
            this.rbexec01.Location = new System.Drawing.Point(12, 22);
            this.rbexec01.Name = "rbexec01";
            this.rbexec01.Size = new System.Drawing.Size(143, 35);
            this.rbexec01.TabIndex = 2;
            this.rbexec01.TabStop = true;
            this.rbexec01.Text = "EXEC 01";
            this.rbexec01.UseVisualStyleBackColor = true;
            // 
            // rbexec03
            // 
            this.rbexec03.AutoSize = true;
            this.rbexec03.Location = new System.Drawing.Point(12, 104);
            this.rbexec03.Name = "rbexec03";
            this.rbexec03.Size = new System.Drawing.Size(143, 35);
            this.rbexec03.TabIndex = 3;
            this.rbexec03.TabStop = true;
            this.rbexec03.Text = "EXEC 03";
            this.rbexec03.UseVisualStyleBackColor = true;
            // 
            // btnavancar
            // 
            this.btnavancar.BackColor = System.Drawing.Color.Crimson;
            this.btnavancar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnavancar.Location = new System.Drawing.Point(520, 413);
            this.btnavancar.Name = "btnavancar";
            this.btnavancar.Size = new System.Drawing.Size(209, 63);
            this.btnavancar.TabIndex = 4;
            this.btnavancar.Text = "AVANÇAR";
            this.btnavancar.UseVisualStyleBackColor = false;
            this.btnavancar.Click += new System.EventHandler(this.btnavancar_Click);
            // 
            // rbtabela01
            // 
            this.rbtabela01.AutoSize = true;
            this.rbtabela01.Location = new System.Drawing.Point(12, 145);
            this.rbtabela01.Name = "rbtabela01";
            this.rbtabela01.Size = new System.Drawing.Size(173, 35);
            this.rbtabela01.TabIndex = 5;
            this.rbtabela01.TabStop = true;
            this.rbtabela01.Text = "TABELA 01";
            this.rbtabela01.UseVisualStyleBackColor = true;
            this.rbtabela01.CheckedChanged += new System.EventHandler(this.rbtabela01_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 488);
            this.Controls.Add(this.rbtabela01);
            this.Controls.Add(this.btnavancar);
            this.Controls.Add(this.rbexec03);
            this.Controls.Add(this.rbexec01);
            this.Controls.Add(this.rbexec02);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbexec02;
        private System.Windows.Forms.RadioButton rbexec01;
        private System.Windows.Forms.RadioButton rbexec03;
        private System.Windows.Forms.Button btnavancar;
        private System.Windows.Forms.RadioButton rbtabela01;
    }
}

