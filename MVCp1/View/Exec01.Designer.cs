
namespace MVCp1.View
{
    partial class Exec01
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
            this.txtconta = new System.Windows.Forms.TextBox();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lbllegenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(230, 154);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(278, 38);
            this.txtconta.TabIndex = 0;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(586, 396);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(144, 49);
            this.btnfechar.TabIndex = 1;
            this.btnfechar.Text = "FECHAR";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(586, 341);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(144, 49);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(276, 208);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(188, 49);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "CONFIRMAR";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lbllegenda
            // 
            this.lbllegenda.AutoSize = true;
            this.lbllegenda.Location = new System.Drawing.Point(239, 73);
            this.lbllegenda.Name = "lbllegenda";
            this.lbllegenda.Size = new System.Drawing.Size(269, 62);
            this.lbllegenda.TabIndex = 4;
            this.lbllegenda.Text = "INSIRA O NÚMERO \r\nDA SUA CONTA:";
            this.lbllegenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 454);
            this.Controls.Add(this.lbllegenda);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.txtconta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label lbllegenda;
    }
}