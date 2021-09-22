
namespace AulaFuncaoMultiRetorno
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
            this.dgpessoas = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMECOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDADECOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgpessoas
            // 
            this.dgpessoas.AllowUserToAddRows = false;
            this.dgpessoas.AllowUserToDeleteRows = false;
            this.dgpessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.NOMECOL,
            this.IDADECOL,
            this.CPFCOL,
            this.RGCOL});
            this.dgpessoas.Location = new System.Drawing.Point(12, 12);
            this.dgpessoas.Name = "dgpessoas";
            this.dgpessoas.ReadOnly = true;
            this.dgpessoas.Size = new System.Drawing.Size(776, 388);
            this.dgpessoas.TabIndex = 0;
            // 
            // idPessoa
            // 
            this.idPessoa.HeaderText = "ID";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Width = 50;
            // 
            // NOMECOL
            // 
            this.NOMECOL.HeaderText = "NOME";
            this.NOMECOL.Name = "NOMECOL";
            this.NOMECOL.ReadOnly = true;
            this.NOMECOL.Width = 200;
            // 
            // IDADECOL
            // 
            this.IDADECOL.HeaderText = "IDADE";
            this.IDADECOL.Name = "IDADECOL";
            this.IDADECOL.ReadOnly = true;
            this.IDADECOL.Width = 70;
            // 
            // CPFCOL
            // 
            this.CPFCOL.HeaderText = "CPF";
            this.CPFCOL.Name = "CPFCOL";
            this.CPFCOL.ReadOnly = true;
            this.CPFCOL.Width = 200;
            // 
            // RGCOL
            // 
            this.RGCOL.HeaderText = "RG";
            this.RGCOL.Name = "RGCOL";
            this.RGCOL.ReadOnly = true;
            this.RGCOL.Width = 200;
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgpessoas);
            this.Name = "Exec02";
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgpessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMECOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDADECOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGCOL;
    }
}