
namespace AulaWF_03
{
    partial class Entrar
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
            this.cbvagas = new System.Windows.Forms.ComboBox();
            this.lblentrar = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbvagas
            // 
            this.cbvagas.FormattingEnabled = true;
            this.cbvagas.Location = new System.Drawing.Point(202, 104);
            this.cbvagas.Name = "cbvagas";
            this.cbvagas.Size = new System.Drawing.Size(347, 39);
            this.cbvagas.TabIndex = 0;
            // 
            // lblentrar
            // 
            this.lblentrar.AutoSize = true;
            this.lblentrar.Location = new System.Drawing.Point(196, 61);
            this.lblentrar.Name = "lblentrar";
            this.lblentrar.Size = new System.Drawing.Size(353, 31);
            this.lblentrar.TabIndex = 1;
            this.lblentrar.Text = "Selecione a vaga desejada: ";
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(276, 159);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(183, 31);
            this.lblplaca.TabIndex = 2;
            this.lblplaca.Text = "Insira a placa:";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(202, 205);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(347, 38);
            this.txtplaca.TabIndex = 3;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(263, 266);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(205, 40);
            this.btnconfirmar.TabIndex = 4;
            this.btnconfirmar.Text = "CONFIRMAR";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(578, 347);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(160, 43);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 411);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.lblentrar);
            this.Controls.Add(this.cbvagas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Entrar";
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.Entrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbvagas;
        private System.Windows.Forms.Label lblentrar;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btnvoltar;
    }
}