
namespace AulaWF_03
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
            this.cbnomes = new System.Windows.Forms.ComboBox();
            this.lblnomes = new System.Windows.Forms.Label();
            this.btnconfere = new System.Windows.Forms.Button();
            this.dgpessoa = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbnomes
            // 
            this.cbnomes.FormattingEnabled = true;
            this.cbnomes.Location = new System.Drawing.Point(32, 63);
            this.cbnomes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbnomes.Name = "cbnomes";
            this.cbnomes.Size = new System.Drawing.Size(242, 39);
            this.cbnomes.TabIndex = 0;
            // 
            // lblnomes
            // 
            this.lblnomes.AutoSize = true;
            this.lblnomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomes.Location = new System.Drawing.Point(26, 25);
            this.lblnomes.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblnomes.Name = "lblnomes";
            this.lblnomes.Size = new System.Drawing.Size(108, 31);
            this.lblnomes.TabIndex = 1;
            this.lblnomes.Text = "Nomes:";
            // 
            // btnconfere
            // 
            this.btnconfere.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfere.Location = new System.Drawing.Point(32, 116);
            this.btnconfere.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnconfere.Name = "btnconfere";
            this.btnconfere.Size = new System.Drawing.Size(242, 47);
            this.btnconfere.TabIndex = 2;
            this.btnconfere.Text = "CONFERE";
            this.btnconfere.UseVisualStyleBackColor = true;
            this.btnconfere.Click += new System.EventHandler(this.btnconfere_Click);
            // 
            // dgpessoa
            // 
            this.dgpessoa.AllowUserToAddRows = false;
            this.dgpessoa.AllowUserToDeleteRows = false;
            this.dgpessoa.AllowUserToOrderColumns = true;
            this.dgpessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.NomeCol,
            this.Cpf,
            this.IdadeCol});
            this.dgpessoa.Location = new System.Drawing.Point(32, 183);
            this.dgpessoa.Name = "dgpessoa";
            this.dgpessoa.ReadOnly = true;
            this.dgpessoa.Size = new System.Drawing.Size(743, 95);
            this.dgpessoa.TabIndex = 3;
            // 
            // idPessoa
            // 
            this.idPessoa.HeaderText = "ID";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Width = 70;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 260;
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 260;
            // 
            // IdadeCol
            // 
            this.IdadeCol.HeaderText = "Idade";
            this.IdadeCol.Name = "IdadeCol";
            this.IdadeCol.ReadOnly = true;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 423);
            this.Controls.Add(this.dgpessoa);
            this.Controls.Add(this.btnconfere);
            this.Controls.Add(this.lblnomes);
            this.Controls.Add(this.cbnomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Exec01";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Exec01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnomes;
        private System.Windows.Forms.Label lblnomes;
        private System.Windows.Forms.Button btnconfere;
        private System.Windows.Forms.DataGridView dgpessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeCol;
    }
}