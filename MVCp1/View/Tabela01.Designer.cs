
namespace MVCp1.View
{
    partial class Tabela01
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.cbvip = new System.Windows.Forms.CheckBox();
            this.rbpessoa = new System.Windows.Forms.RadioButton();
            this.rbfuncionario = new System.Windows.Forms.RadioButton();
            this.rbcliente = new System.Windows.Forms.RadioButton();
            this.btnexecuta = new System.Windows.Forms.Button();
            this.btnconfere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(173, 22);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(245, 38);
            this.txtnome.TabIndex = 0;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(173, 66);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(245, 38);
            this.txtcpf.TabIndex = 1;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(173, 110);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(245, 38);
            this.txtrg.TabIndex = 2;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(173, 154);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(245, 38);
            this.txtsalario.TabIndex = 3;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 25);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(95, 31);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "NOME";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(12, 69);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(69, 31);
            this.lblcpf.TabIndex = 5;
            this.lblcpf.Text = "CPF";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(12, 113);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(55, 31);
            this.lblrg.TabIndex = 6;
            this.lblrg.Text = "RG";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(12, 157);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(132, 31);
            this.lblsalario.TabIndex = 7;
            this.lblsalario.Text = "SALARIO";
            // 
            // cbvip
            // 
            this.cbvip.AutoSize = true;
            this.cbvip.Location = new System.Drawing.Point(173, 198);
            this.cbvip.Name = "cbvip";
            this.cbvip.Size = new System.Drawing.Size(77, 35);
            this.cbvip.TabIndex = 8;
            this.cbvip.Text = "VIP";
            this.cbvip.UseVisualStyleBackColor = true;
            // 
            // rbpessoa
            // 
            this.rbpessoa.AutoSize = true;
            this.rbpessoa.Location = new System.Drawing.Point(444, 21);
            this.rbpessoa.Name = "rbpessoa";
            this.rbpessoa.Size = new System.Drawing.Size(143, 35);
            this.rbpessoa.TabIndex = 9;
            this.rbpessoa.TabStop = true;
            this.rbpessoa.Text = "PESSOA";
            this.rbpessoa.UseVisualStyleBackColor = true;
            // 
            // rbfuncionario
            // 
            this.rbfuncionario.AutoSize = true;
            this.rbfuncionario.Location = new System.Drawing.Point(444, 157);
            this.rbfuncionario.Name = "rbfuncionario";
            this.rbfuncionario.Size = new System.Drawing.Size(225, 35);
            this.rbfuncionario.TabIndex = 10;
            this.rbfuncionario.TabStop = true;
            this.rbfuncionario.Text = "FUNCIONÁRIO";
            this.rbfuncionario.UseVisualStyleBackColor = true;
            // 
            // rbcliente
            // 
            this.rbcliente.AutoSize = true;
            this.rbcliente.Location = new System.Drawing.Point(444, 88);
            this.rbcliente.Name = "rbcliente";
            this.rbcliente.Size = new System.Drawing.Size(148, 35);
            this.rbcliente.TabIndex = 11;
            this.rbcliente.TabStop = true;
            this.rbcliente.Text = "CLIENTE";
            this.rbcliente.UseVisualStyleBackColor = true;
            // 
            // btnexecuta
            // 
            this.btnexecuta.Location = new System.Drawing.Point(18, 390);
            this.btnexecuta.Name = "btnexecuta";
            this.btnexecuta.Size = new System.Drawing.Size(311, 60);
            this.btnexecuta.TabIndex = 12;
            this.btnexecuta.Text = "EXECUTAR";
            this.btnexecuta.UseVisualStyleBackColor = true;
            this.btnexecuta.Click += new System.EventHandler(this.btnexecuta_Click);
            // 
            // btnconfere
            // 
            this.btnconfere.Location = new System.Drawing.Point(349, 390);
            this.btnconfere.Name = "btnconfere";
            this.btnconfere.Size = new System.Drawing.Size(311, 60);
            this.btnconfere.TabIndex = 13;
            this.btnconfere.Text = "CONFERIR";
            this.btnconfere.UseVisualStyleBackColor = true;
            this.btnconfere.Click += new System.EventHandler(this.btnconfere_Click);
            // 
            // Tabela01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 462);
            this.Controls.Add(this.btnconfere);
            this.Controls.Add(this.btnexecuta);
            this.Controls.Add(this.rbcliente);
            this.Controls.Add(this.rbfuncionario);
            this.Controls.Add(this.rbpessoa);
            this.Controls.Add(this.cbvip);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Tabela01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tabela01_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.CheckBox cbvip;
        private System.Windows.Forms.RadioButton rbpessoa;
        private System.Windows.Forms.RadioButton rbfuncionario;
        private System.Windows.Forms.RadioButton rbcliente;
        private System.Windows.Forms.Button btnexecuta;
        private System.Windows.Forms.Button btnconfere;
    }
}