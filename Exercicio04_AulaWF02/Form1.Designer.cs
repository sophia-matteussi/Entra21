
namespace Exercicio04_AulaWF02
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
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnomesinseridos = new System.Windows.Forms.Label();
            this.listnomes = new System.Windows.Forms.ListBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft New Tai Lue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(1, 10);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(283, 48);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Insira um nome:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(290, 15);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(489, 38);
            this.txtnome.TabIndex = 1;
            // 
            // lblnomesinseridos
            // 
            this.lblnomesinseridos.AutoSize = true;
            this.lblnomesinseridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomesinseridos.Location = new System.Drawing.Point(527, 70);
            this.lblnomesinseridos.Name = "lblnomesinseridos";
            this.lblnomesinseridos.Size = new System.Drawing.Size(252, 31);
            this.lblnomesinseridos.TabIndex = 2;
            this.lblnomesinseridos.Text = "Nomes já inseridos:";
            // 
            // listnomes
            // 
            this.listnomes.FormattingEnabled = true;
            this.listnomes.Location = new System.Drawing.Point(533, 117);
            this.listnomes.Name = "listnomes";
            this.listnomes.Size = new System.Drawing.Size(241, 303);
            this.listnomes.TabIndex = 3;
            this.listnomes.SelectedIndexChanged += new System.EventHandler(this.listnomes_SelectedIndexChanged);
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(290, 72);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(200, 39);
            this.btninserir.TabIndex = 4;
            this.btninserir.Text = "INSERIR";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.listnomes);
            this.Controls.Add(this.lblnomesinseridos);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnomesinseridos;
        private System.Windows.Forms.ListBox listnomes;
        private System.Windows.Forms.Button btninserir;
    }
}

