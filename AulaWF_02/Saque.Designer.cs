
namespace AulaWF_02
{
    partial class Saque
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.lblconta = new System.Windows.Forms.Label();
            this.lblqnt = new System.Windows.Forms.Label();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.btextrato = new System.Windows.Forms.Button();
            this.btsaque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(631, 359);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(162, 63);
            this.btVoltar.TabIndex = 0;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lblconta
            // 
            this.lblconta.AutoSize = true;
            this.lblconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconta.Location = new System.Drawing.Point(22, 20);
            this.lblconta.Name = "lblconta";
            this.lblconta.Size = new System.Drawing.Size(87, 31);
            this.lblconta.TabIndex = 1;
            this.lblconta.Text = "Conta";
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqnt.Location = new System.Drawing.Point(22, 64);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(196, 31);
            this.lblqnt.TabIndex = 2;
            this.lblqnt.Text = "Quantidade R$";
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(130, 31);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(361, 20);
            this.txtconta.TabIndex = 3;
            // 
            // txtqnt
            // 
            this.txtqnt.Location = new System.Drawing.Point(224, 75);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(267, 20);
            this.txtqnt.TabIndex = 4;
            // 
            // btextrato
            // 
            this.btextrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btextrato.Location = new System.Drawing.Point(24, 118);
            this.btextrato.Name = "btextrato";
            this.btextrato.Size = new System.Drawing.Size(194, 64);
            this.btextrato.TabIndex = 5;
            this.btextrato.Text = "EXTRATO";
            this.btextrato.UseVisualStyleBackColor = true;
            this.btextrato.Click += new System.EventHandler(this.btextrato_Click);
            // 
            // btsaque
            // 
            this.btsaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaque.Location = new System.Drawing.Point(247, 118);
            this.btsaque.Name = "btsaque";
            this.btsaque.Size = new System.Drawing.Size(194, 64);
            this.btsaque.TabIndex = 6;
            this.btsaque.Text = "SAQUE";
            this.btsaque.UseVisualStyleBackColor = true;
            this.btsaque.Click += new System.EventHandler(this.btsaque_Click);
            // 
            // Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsaque);
            this.Controls.Add(this.btextrato);
            this.Controls.Add(this.txtqnt);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.lblconta);
            this.Controls.Add(this.btVoltar);
            this.Name = "Saque";
            this.Text = "Saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lblconta;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Button btextrato;
        private System.Windows.Forms.Button btsaque;
    }
}