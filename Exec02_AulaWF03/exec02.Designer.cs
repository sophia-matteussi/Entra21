
namespace Exec02_AulaWF03
{
    partial class exec02
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
            this.dtvproduto = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkadd = new System.Windows.Forms.CheckBox();
            this.checkremove = new System.Windows.Forms.CheckBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtfornecedor = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblfornecedor = new System.Windows.Forms.Label();
            this.btnexecutar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvproduto
            // 
            this.dtvproduto.AllowUserToAddRows = false;
            this.dtvproduto.AllowUserToDeleteRows = false;
            this.dtvproduto.AllowUserToOrderColumns = true;
            this.dtvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.NomeCol,
            this.Preco});
            this.dtvproduto.Location = new System.Drawing.Point(12, 12);
            this.dtvproduto.Name = "dtvproduto";
            this.dtvproduto.ReadOnly = true;
            this.dtvproduto.Size = new System.Drawing.Size(764, 324);
            this.dtvproduto.TabIndex = 0;
            this.dtvproduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 200;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 150;
            // 
            // checkadd
            // 
            this.checkadd.AutoSize = true;
            this.checkadd.Location = new System.Drawing.Point(12, 342);
            this.checkadd.Name = "checkadd";
            this.checkadd.Size = new System.Drawing.Size(186, 35);
            this.checkadd.TabIndex = 1;
            this.checkadd.Text = "ADICIONAR";
            this.checkadd.UseVisualStyleBackColor = true;
            this.checkadd.CheckedChanged += new System.EventHandler(this.checkadd_CheckedChanged);
            // 
            // checkremove
            // 
            this.checkremove.AutoSize = true;
            this.checkremove.Location = new System.Drawing.Point(12, 383);
            this.checkremove.Name = "checkremove";
            this.checkremove.Size = new System.Drawing.Size(170, 35);
            this.checkremove.TabIndex = 2;
            this.checkremove.Text = "REMOVER";
            this.checkremove.UseVisualStyleBackColor = true;
            this.checkremove.CheckedChanged += new System.EventHandler(this.checkremove_CheckedChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(379, 342);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(210, 38);
            this.txtnome.TabIndex = 3;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(379, 386);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(210, 38);
            this.txtpreco.TabIndex = 4;
            // 
            // txtfornecedor
            // 
            this.txtfornecedor.Location = new System.Drawing.Point(477, 429);
            this.txtfornecedor.Name = "txtfornecedor";
            this.txtfornecedor.Size = new System.Drawing.Size(210, 38);
            this.txtfornecedor.TabIndex = 5;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(262, 342);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(95, 31);
            this.lblnome.TabIndex = 6;
            this.lblnome.Text = "NOME";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(262, 384);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(111, 31);
            this.lblpreco.TabIndex = 7;
            this.lblpreco.Text = "PREÇO";
            // 
            // lblfornecedor
            // 
            this.lblfornecedor.AutoSize = true;
            this.lblfornecedor.Location = new System.Drawing.Point(262, 429);
            this.lblfornecedor.Name = "lblfornecedor";
            this.lblfornecedor.Size = new System.Drawing.Size(209, 31);
            this.lblfornecedor.TabIndex = 8;
            this.lblfornecedor.Text = "FORNECEDOR";
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(604, 366);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(181, 40);
            this.btnexecutar.TabIndex = 9;
            this.btnexecutar.Text = "EXECUTAR";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.btnexecutar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(12, 429);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(181, 40);
            this.btnfechar.TabIndex = 10;
            this.btnfechar.Text = "FECHAR";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 493);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnexecutar);
            this.Controls.Add(this.lblfornecedor);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtfornecedor);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.checkremove);
            this.Controls.Add(this.checkadd);
            this.Controls.Add(this.dtvproduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "exec02";
            this.Text = "exec02";
            this.Load += new System.EventHandler(this.exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.CheckBox checkadd;
        private System.Windows.Forms.CheckBox checkremove;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtfornecedor;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblfornecedor;
        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.Button btnfechar;
    }
}