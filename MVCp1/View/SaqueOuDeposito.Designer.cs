
namespace MVCp1.View
{
    partial class SaqueOuDeposito
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
            this.rbsaque = new System.Windows.Forms.RadioButton();
            this.rbdeposito = new System.Windows.Forms.RadioButton();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnconfirma = new System.Windows.Forms.Button();
            this.btnfinalizarop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbsaque
            // 
            this.rbsaque.AutoSize = true;
            this.rbsaque.Location = new System.Drawing.Point(12, 45);
            this.rbsaque.Name = "rbsaque";
            this.rbsaque.Size = new System.Drawing.Size(127, 35);
            this.rbsaque.TabIndex = 0;
            this.rbsaque.TabStop = true;
            this.rbsaque.Text = "SAQUE";
            this.rbsaque.UseVisualStyleBackColor = true;
            // 
            // rbdeposito
            // 
            this.rbdeposito.AutoSize = true;
            this.rbdeposito.Location = new System.Drawing.Point(12, 95);
            this.rbdeposito.Name = "rbdeposito";
            this.rbdeposito.Size = new System.Drawing.Size(173, 35);
            this.rbdeposito.TabIndex = 1;
            this.rbdeposito.TabStop = true;
            this.rbdeposito.Text = "DEPOSITO";
            this.rbdeposito.UseVisualStyleBackColor = true;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(256, 64);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(286, 38);
            this.txtvalor.TabIndex = 2;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(610, 402);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(187, 59);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnconfirma
            // 
            this.btnconfirma.Location = new System.Drawing.Point(561, 64);
            this.btnconfirma.Name = "btnconfirma";
            this.btnconfirma.Size = new System.Drawing.Size(169, 38);
            this.btnconfirma.TabIndex = 4;
            this.btnconfirma.Text = "CONFIRMA";
            this.btnconfirma.UseVisualStyleBackColor = true;
            this.btnconfirma.Click += new System.EventHandler(this.btnconfirma_Click);
            // 
            // btnfinalizarop
            // 
            this.btnfinalizarop.Location = new System.Drawing.Point(134, 402);
            this.btnfinalizarop.Name = "btnfinalizarop";
            this.btnfinalizarop.Size = new System.Drawing.Size(439, 59);
            this.btnfinalizarop.TabIndex = 5;
            this.btnfinalizarop.Text = "FINALIZAR OPERAÇÃO";
            this.btnfinalizarop.UseVisualStyleBackColor = true;
            this.btnfinalizarop.Click += new System.EventHandler(this.btnfinalizarop_Click);
            // 
            // SaqueOuDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 473);
            this.Controls.Add(this.btnfinalizarop);
            this.Controls.Add(this.btnconfirma);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.rbdeposito);
            this.Controls.Add(this.rbsaque);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SaqueOuDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolhaSaqueOuDeposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbsaque;
        private System.Windows.Forms.RadioButton rbdeposito;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnconfirma;
        private System.Windows.Forms.Button btnfinalizarop;
    }
}