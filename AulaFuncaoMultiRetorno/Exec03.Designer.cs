
namespace AulaFuncaoMultiRetorno
{
    partial class Exec03
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
            this.lblvaloremcaixalabel = new System.Windows.Forms.Label();
            this.lblvaloremcaixa = new System.Windows.Forms.Label();
            this.lbldespesas = new System.Windows.Forms.Label();
            this.lblganhosdomes = new System.Windows.Forms.Label();
            this.txtganhos = new System.Windows.Forms.TextBox();
            this.txtdespesas = new System.Windows.Forms.TextBox();
            this.dgfaturamento = new System.Windows.Forms.DataGridView();
            this.ganhosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncalcula = new System.Windows.Forms.Button();
            this.btmsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvaloremcaixalabel
            // 
            this.lblvaloremcaixalabel.AutoSize = true;
            this.lblvaloremcaixalabel.Location = new System.Drawing.Point(299, 27);
            this.lblvaloremcaixalabel.Name = "lblvaloremcaixalabel";
            this.lblvaloremcaixalabel.Size = new System.Drawing.Size(284, 31);
            this.lblvaloremcaixalabel.TabIndex = 0;
            this.lblvaloremcaixalabel.Text = "VALOR EM CAIXA R$";
            // 
            // lblvaloremcaixa
            // 
            this.lblvaloremcaixa.AutoSize = true;
            this.lblvaloremcaixa.Location = new System.Drawing.Point(12, 27);
            this.lblvaloremcaixa.Name = "lblvaloremcaixa";
            this.lblvaloremcaixa.Size = new System.Drawing.Size(284, 31);
            this.lblvaloremcaixa.TabIndex = 1;
            this.lblvaloremcaixa.Text = "VALOR EM CAIXA R$";
            // 
            // lbldespesas
            // 
            this.lbldespesas.AutoSize = true;
            this.lbldespesas.Location = new System.Drawing.Point(12, 131);
            this.lbldespesas.Name = "lbldespesas";
            this.lbldespesas.Size = new System.Drawing.Size(315, 31);
            this.lbldespesas.TabIndex = 2;
            this.lbldespesas.Text = "DESPESAS DO MÊS R$";
            // 
            // lblganhosdomes
            // 
            this.lblganhosdomes.AutoSize = true;
            this.lblganhosdomes.Location = new System.Drawing.Point(12, 80);
            this.lblganhosdomes.Name = "lblganhosdomes";
            this.lblganhosdomes.Size = new System.Drawing.Size(287, 31);
            this.lblganhosdomes.TabIndex = 3;
            this.lblganhosdomes.Text = "GANHOS DO MÊS R$";
            // 
            // txtganhos
            // 
            this.txtganhos.Location = new System.Drawing.Point(305, 77);
            this.txtganhos.Name = "txtganhos";
            this.txtganhos.Size = new System.Drawing.Size(294, 38);
            this.txtganhos.TabIndex = 4;
            // 
            // txtdespesas
            // 
            this.txtdespesas.Location = new System.Drawing.Point(333, 131);
            this.txtdespesas.Name = "txtdespesas";
            this.txtdespesas.Size = new System.Drawing.Size(294, 38);
            this.txtdespesas.TabIndex = 5;
            // 
            // dgfaturamento
            // 
            this.dgfaturamento.AllowUserToAddRows = false;
            this.dgfaturamento.AllowUserToDeleteRows = false;
            this.dgfaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgfaturamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganhosCol,
            this.DespesasCol,
            this.ValorLiquidoCol,
            this.LucroCol});
            this.dgfaturamento.Location = new System.Drawing.Point(18, 190);
            this.dgfaturamento.Name = "dgfaturamento";
            this.dgfaturamento.ReadOnly = true;
            this.dgfaturamento.RowTemplate.Height = 50;
            this.dgfaturamento.Size = new System.Drawing.Size(749, 221);
            this.dgfaturamento.TabIndex = 6;
            // 
            // ganhosCol
            // 
            this.ganhosCol.HeaderText = "GANHOS";
            this.ganhosCol.Name = "ganhosCol";
            this.ganhosCol.ReadOnly = true;
            this.ganhosCol.Width = 150;
            // 
            // DespesasCol
            // 
            this.DespesasCol.HeaderText = "DESPESAS";
            this.DespesasCol.Name = "DespesasCol";
            this.DespesasCol.ReadOnly = true;
            this.DespesasCol.Width = 170;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "VALOR LIQUIDO";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            this.ValorLiquidoCol.Width = 250;
            // 
            // LucroCol
            // 
            this.LucroCol.HeaderText = "LUCRO";
            this.LucroCol.Name = "LucroCol";
            this.LucroCol.ReadOnly = true;
            this.LucroCol.Width = 130;
            // 
            // btncalcula
            // 
            this.btncalcula.Location = new System.Drawing.Point(18, 417);
            this.btncalcula.Name = "btncalcula";
            this.btncalcula.Size = new System.Drawing.Size(581, 38);
            this.btncalcula.TabIndex = 7;
            this.btncalcula.Text = "CALCULA";
            this.btncalcula.UseVisualStyleBackColor = true;
            this.btncalcula.Click += new System.EventHandler(this.btncalcula_Click);
            // 
            // btmsair
            // 
            this.btmsair.BackColor = System.Drawing.Color.RosyBrown;
            this.btmsair.ForeColor = System.Drawing.Color.Black;
            this.btmsair.Location = new System.Drawing.Point(611, 417);
            this.btmsair.Name = "btmsair";
            this.btmsair.Size = new System.Drawing.Size(156, 38);
            this.btmsair.TabIndex = 8;
            this.btmsair.Text = "SAIR";
            this.btmsair.UseVisualStyleBackColor = false;
            this.btmsair.Click += new System.EventHandler(this.btmsair_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 471);
            this.Controls.Add(this.btmsair);
            this.Controls.Add(this.btncalcula);
            this.Controls.Add(this.dgfaturamento);
            this.Controls.Add(this.txtdespesas);
            this.Controls.Add(this.txtganhos);
            this.Controls.Add(this.lblganhosdomes);
            this.Controls.Add(this.lbldespesas);
            this.Controls.Add(this.lblvaloremcaixa);
            this.Controls.Add(this.lblvaloremcaixalabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Exec03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgfaturamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvaloremcaixalabel;
        private System.Windows.Forms.Label lblvaloremcaixa;
        private System.Windows.Forms.Label lbldespesas;
        private System.Windows.Forms.Label lblganhosdomes;
        private System.Windows.Forms.TextBox txtganhos;
        private System.Windows.Forms.TextBox txtdespesas;
        private System.Windows.Forms.DataGridView dgfaturamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganhosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroCol;
        private System.Windows.Forms.Button btncalcula;
        private System.Windows.Forms.Button btmsair;
    }
}