
namespace Exec02_AulaWF03
{
    partial class Exec04
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
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.idHistorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GnahosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeríodoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtinsert = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.rbcustos = new System.Windows.Forms.RadioButton();
            this.rbganhos = new System.Windows.Forms.RadioButton();
            this.rbperiodo = new System.Windows.Forms.RadioButton();
            this.rblucro = new System.Windows.Forms.RadioButton();
            this.lblaviso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.AllowUserToOrderColumns = true;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHistorico,
            this.CustosCol,
            this.GnahosCol,
            this.LucroCol,
            this.PeríodoCol});
            this.dgHistorico.Location = new System.Drawing.Point(21, 12);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.Size = new System.Drawing.Size(543, 199);
            this.dgHistorico.TabIndex = 0;
            // 
            // idHistorico
            // 
            this.idHistorico.HeaderText = "ID";
            this.idHistorico.Name = "idHistorico";
            this.idHistorico.ReadOnly = true;
            // 
            // CustosCol
            // 
            this.CustosCol.HeaderText = "Custos";
            this.CustosCol.Name = "CustosCol";
            this.CustosCol.ReadOnly = true;
            // 
            // GnahosCol
            // 
            this.GnahosCol.HeaderText = "Ganhos";
            this.GnahosCol.Name = "GnahosCol";
            this.GnahosCol.ReadOnly = true;
            // 
            // LucroCol
            // 
            this.LucroCol.HeaderText = "Lucro";
            this.LucroCol.Name = "LucroCol";
            this.LucroCol.ReadOnly = true;
            // 
            // PeríodoCol
            // 
            this.PeríodoCol.HeaderText = "Período";
            this.PeríodoCol.Name = "PeríodoCol";
            this.PeríodoCol.ReadOnly = true;
            // 
            // txtinsert
            // 
            this.txtinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinsert.Location = new System.Drawing.Point(226, 232);
            this.txtinsert.Name = "txtinsert";
            this.txtinsert.Size = new System.Drawing.Size(338, 38);
            this.txtinsert.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(570, 232);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(188, 38);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "PROXIMO";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // rbcustos
            // 
            this.rbcustos.AutoSize = true;
            this.rbcustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcustos.Location = new System.Drawing.Point(21, 232);
            this.rbcustos.Name = "rbcustos";
            this.rbcustos.Size = new System.Drawing.Size(118, 35);
            this.rbcustos.TabIndex = 7;
            this.rbcustos.TabStop = true;
            this.rbcustos.Text = "Custos";
            this.rbcustos.UseVisualStyleBackColor = true;
            // 
            // rbganhos
            // 
            this.rbganhos.AutoSize = true;
            this.rbganhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbganhos.Location = new System.Drawing.Point(21, 273);
            this.rbganhos.Name = "rbganhos";
            this.rbganhos.Size = new System.Drawing.Size(127, 35);
            this.rbganhos.TabIndex = 8;
            this.rbganhos.TabStop = true;
            this.rbganhos.Text = "Ganhos";
            this.rbganhos.UseVisualStyleBackColor = true;
            // 
            // rbperiodo
            // 
            this.rbperiodo.AutoSize = true;
            this.rbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbperiodo.Location = new System.Drawing.Point(21, 355);
            this.rbperiodo.Name = "rbperiodo";
            this.rbperiodo.Size = new System.Drawing.Size(125, 35);
            this.rbperiodo.TabIndex = 10;
            this.rbperiodo.TabStop = true;
            this.rbperiodo.Text = "Período";
            this.rbperiodo.UseVisualStyleBackColor = true;
            // 
            // rblucro
            // 
            this.rblucro.AutoSize = true;
            this.rblucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblucro.Location = new System.Drawing.Point(21, 314);
            this.rblucro.Name = "rblucro";
            this.rblucro.Size = new System.Drawing.Size(100, 35);
            this.rblucro.TabIndex = 11;
            this.rblucro.TabStop = true;
            this.rblucro.Text = "Lucro";
            this.rblucro.UseVisualStyleBackColor = true;
            // 
            // lblaviso
            // 
            this.lblaviso.AutoSize = true;
            this.lblaviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaviso.Location = new System.Drawing.Point(18, 393);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(157, 36);
            this.lblaviso.TabIndex = 12;
            this.lblaviso.Text = "*MODELO: MÊS/ANO\r\n                       00/0000";
            this.lblaviso.Click += new System.EventHandler(this.lblaviso_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exec04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblaviso);
            this.Controls.Add(this.rblucro);
            this.Controls.Add(this.rbperiodo);
            this.Controls.Add(this.rbganhos);
            this.Controls.Add(this.rbcustos);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtinsert);
            this.Controls.Add(this.dgHistorico);
            this.Name = "Exec04";
            this.Text = "Exec04";
            this.Load += new System.EventHandler(this.Exec04_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GnahosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeríodoCol;
        private System.Windows.Forms.TextBox txtinsert;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.RadioButton rbcustos;
        private System.Windows.Forms.RadioButton rbganhos;
        private System.Windows.Forms.RadioButton rbperiodo;
        private System.Windows.Forms.RadioButton rblucro;
        private System.Windows.Forms.Label lblaviso;
        private System.Windows.Forms.Button button1;
    }
}