
namespace AulaWF_02
{
    partial class Exec02
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
            this.btFechar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.btcontasativas = new System.Windows.Forms.Button();
            this.btdeposito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(612, 365);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(120, 55);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btSacar
            // 
            this.btSacar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSacar.Location = new System.Drawing.Point(105, 33);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(536, 59);
            this.btSacar.TabIndex = 1;
            this.btSacar.Text = "SACAR";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.UseWaitCursor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // btcontasativas
            // 
            this.btcontasativas.Location = new System.Drawing.Point(105, 170);
            this.btcontasativas.Name = "btcontasativas";
            this.btcontasativas.Size = new System.Drawing.Size(536, 62);
            this.btcontasativas.TabIndex = 2;
            this.btcontasativas.Text = "ACESSAR CONTAS ATIVAS";
            this.btcontasativas.UseVisualStyleBackColor = true;
            this.btcontasativas.Click += new System.EventHandler(this.btcontasativas_Click);
            // 
            // btdeposito
            // 
            this.btdeposito.Location = new System.Drawing.Point(105, 98);
            this.btdeposito.Name = "btdeposito";
            this.btdeposito.Size = new System.Drawing.Size(536, 66);
            this.btdeposito.TabIndex = 3;
            this.btdeposito.Text = "DEPOSITAR";
            this.btdeposito.UseVisualStyleBackColor = true;
            this.btdeposito.Click += new System.EventHandler(this.btdeposito_Click);
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.btdeposito);
            this.Controls.Add(this.btcontasativas);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btFechar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Exec02";
            this.Text = "Exec02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Button btcontasativas;
        private System.Windows.Forms.Button btdeposito;
    }
}