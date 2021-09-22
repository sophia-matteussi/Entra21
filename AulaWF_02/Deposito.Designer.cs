
namespace AulaWF_02
{
    partial class Deposito
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
            this.txtcontadep = new System.Windows.Forms.TextBox();
            this.txtvalordep = new System.Windows.Forms.TextBox();
            this.lblcontadep = new System.Windows.Forms.Label();
            this.lblvalordep = new System.Windows.Forms.Label();
            this.btextratodep = new System.Windows.Forms.Button();
            this.btdeposito = new System.Windows.Forms.Button();
            this.btvoltardep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcontadep
            // 
            this.txtcontadep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontadep.Location = new System.Drawing.Point(276, 33);
            this.txtcontadep.Name = "txtcontadep";
            this.txtcontadep.Size = new System.Drawing.Size(287, 38);
            this.txtcontadep.TabIndex = 0;
            // 
            // txtvalordep
            // 
            this.txtvalordep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalordep.Location = new System.Drawing.Point(214, 85);
            this.txtvalordep.Name = "txtvalordep";
            this.txtvalordep.Size = new System.Drawing.Size(349, 38);
            this.txtvalordep.TabIndex = 1;
            // 
            // lblcontadep
            // 
            this.lblcontadep.AutoSize = true;
            this.lblcontadep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontadep.Location = new System.Drawing.Point(12, 33);
            this.lblcontadep.Name = "lblcontadep";
            this.lblcontadep.Size = new System.Drawing.Size(258, 31);
            this.lblcontadep.TabIndex = 2;
            this.lblcontadep.Text = "Conta para deposito";
            // 
            // lblvalordep
            // 
            this.lblvalordep.AutoSize = true;
            this.lblvalordep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalordep.Location = new System.Drawing.Point(12, 85);
            this.lblvalordep.Name = "lblvalordep";
            this.lblvalordep.Size = new System.Drawing.Size(196, 31);
            this.lblvalordep.TabIndex = 3;
            this.lblvalordep.Text = "Quantidade R$";
            // 
            // btextratodep
            // 
            this.btextratodep.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btextratodep.Location = new System.Drawing.Point(583, 49);
            this.btextratodep.Name = "btextratodep";
            this.btextratodep.Size = new System.Drawing.Size(205, 55);
            this.btextratodep.TabIndex = 4;
            this.btextratodep.Text = "EXTRATO";
            this.btextratodep.UseVisualStyleBackColor = true;
            this.btextratodep.Click += new System.EventHandler(this.btextratodep_Click);
            // 
            // btdeposito
            // 
            this.btdeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeposito.Location = new System.Drawing.Point(262, 140);
            this.btdeposito.Name = "btdeposito";
            this.btdeposito.Size = new System.Drawing.Size(249, 55);
            this.btdeposito.TabIndex = 5;
            this.btdeposito.Text = "DEPOSITAR";
            this.btdeposito.UseVisualStyleBackColor = true;
            this.btdeposito.Click += new System.EventHandler(this.btdeposito_Click);
            // 
            // btvoltardep
            // 
            this.btvoltardep.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltardep.Location = new System.Drawing.Point(583, 372);
            this.btvoltardep.Name = "btvoltardep";
            this.btvoltardep.Size = new System.Drawing.Size(205, 54);
            this.btvoltardep.TabIndex = 6;
            this.btvoltardep.Text = "VOLTAR";
            this.btvoltardep.UseVisualStyleBackColor = true;
            this.btvoltardep.Click += new System.EventHandler(this.btvoltardep_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btvoltardep);
            this.Controls.Add(this.btdeposito);
            this.Controls.Add(this.btextratodep);
            this.Controls.Add(this.lblvalordep);
            this.Controls.Add(this.lblcontadep);
            this.Controls.Add(this.txtvalordep);
            this.Controls.Add(this.txtcontadep);
            this.Name = "Deposito";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontadep;
        private System.Windows.Forms.TextBox txtvalordep;
        private System.Windows.Forms.Label lblcontadep;
        private System.Windows.Forms.Label lblvalordep;
        private System.Windows.Forms.Button btextratodep;
        private System.Windows.Forms.Button btdeposito;
        private System.Windows.Forms.Button btvoltardep;
    }
}