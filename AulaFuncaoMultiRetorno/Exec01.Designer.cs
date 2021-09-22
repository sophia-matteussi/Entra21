
namespace AulaFuncaoMultiRetorno
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
            this.lblvalor01 = new System.Windows.Forms.Label();
            this.lblvalor02 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.btncalcula = new System.Windows.Forms.Button();
            this.dgresultado = new System.Windows.Forms.DataGridView();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.SOMACOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTRACAOCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MULTIPLICACAOCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIVISAOCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvalor01
            // 
            this.lblvalor01.AutoSize = true;
            this.lblvalor01.Location = new System.Drawing.Point(51, 46);
            this.lblvalor01.Name = "lblvalor01";
            this.lblvalor01.Size = new System.Drawing.Size(136, 31);
            this.lblvalor01.TabIndex = 0;
            this.lblvalor01.Text = "VALOR 1:";
            // 
            // lblvalor02
            // 
            this.lblvalor02.AutoSize = true;
            this.lblvalor02.Location = new System.Drawing.Point(51, 114);
            this.lblvalor02.Name = "lblvalor02";
            this.lblvalor02.Size = new System.Drawing.Size(136, 31);
            this.lblvalor02.TabIndex = 1;
            this.lblvalor02.Text = "VALOR 2:";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(193, 43);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(120, 38);
            this.txtvalor1.TabIndex = 2;
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(193, 114);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(120, 38);
            this.txtvalor2.TabIndex = 3;
            // 
            // btncalcula
            // 
            this.btncalcula.Location = new System.Drawing.Point(375, 72);
            this.btncalcula.Name = "btncalcula";
            this.btncalcula.Size = new System.Drawing.Size(169, 42);
            this.btncalcula.TabIndex = 8;
            this.btncalcula.Text = "CALCULA";
            this.btncalcula.UseVisualStyleBackColor = true;
            this.btncalcula.Click += new System.EventHandler(this.btncalcula_Click);
            // 
            // dgresultado
            // 
            this.dgresultado.AllowUserToAddRows = false;
            this.dgresultado.AllowUserToDeleteRows = false;
            this.dgresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOMACOL,
            this.SUBTRACAOCOL,
            this.MULTIPLICACAOCOL,
            this.DIVISAOCOL});
            this.dgresultado.Location = new System.Drawing.Point(35, 239);
            this.dgresultado.Name = "dgresultado";
            this.dgresultado.ReadOnly = true;
            this.dgresultado.RowTemplate.Height = 50;
            this.dgresultado.Size = new System.Drawing.Size(741, 205);
            this.dgresultado.TabIndex = 9;
            // 
            // btnencerrar
            // 
            this.btnencerrar.Location = new System.Drawing.Point(585, 72);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(182, 42);
            this.btnencerrar.TabIndex = 10;
            this.btnencerrar.Text = "ENCERRAR";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            // 
            // SOMACOL
            // 
            this.SOMACOL.HeaderText = "SOMA";
            this.SOMACOL.Name = "SOMACOL";
            this.SOMACOL.ReadOnly = true;
            // 
            // SUBTRACAOCOL
            // 
            this.SUBTRACAOCOL.HeaderText = "SUBTRAÇÃO";
            this.SUBTRACAOCOL.Name = "SUBTRACAOCOL";
            this.SUBTRACAOCOL.ReadOnly = true;
            this.SUBTRACAOCOL.Width = 200;
            // 
            // MULTIPLICACAOCOL
            // 
            this.MULTIPLICACAOCOL.HeaderText = "MULTIPLICAÇÃO";
            this.MULTIPLICACAOCOL.Name = "MULTIPLICACAOCOL";
            this.MULTIPLICACAOCOL.ReadOnly = true;
            this.MULTIPLICACAOCOL.Width = 240;
            // 
            // DIVISAOCOL
            // 
            this.DIVISAOCOL.HeaderText = "DIVISÃO";
            this.DIVISAOCOL.Name = "DIVISAOCOL";
            this.DIVISAOCOL.ReadOnly = true;
            this.DIVISAOCOL.Width = 150;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 498);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.dgresultado);
            this.Controls.Add(this.btncalcula);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.lblvalor02);
            this.Controls.Add(this.lblvalor01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec01";
            ((System.ComponentModel.ISupportInitialize)(this.dgresultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor01;
        private System.Windows.Forms.Label lblvalor02;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.Button btncalcula;
        private System.Windows.Forms.DataGridView dgresultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOMACOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTRACAOCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MULTIPLICACAOCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIVISAOCOL;
        private System.Windows.Forms.Button btnencerrar;
    }
}