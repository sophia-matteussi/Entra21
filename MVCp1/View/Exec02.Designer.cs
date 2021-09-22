
namespace MVCp1.View
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
            this.dgestacionamento = new System.Windows.Forms.DataGridView();
            this.idVaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACACOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAENTRADACOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbplacas = new System.Windows.Forms.ComboBox();
            this.lblplacas = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbllavou = new System.Windows.Forms.Label();
            this.rbsim = new System.Windows.Forms.RadioButton();
            this.rbnao = new System.Windows.Forms.RadioButton();
            this.txthorasaida = new System.Windows.Forms.TextBox();
            this.lblhorasaida = new System.Windows.Forms.Label();
            this.cbvagas = new System.Windows.Forms.ComboBox();
            this.lblvagaslivres = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblhoraentrada = new System.Windows.Forms.Label();
            this.txthoraentrada = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnencerra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgestacionamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgestacionamento
            // 
            this.dgestacionamento.AllowUserToAddRows = false;
            this.dgestacionamento.AllowUserToDeleteRows = false;
            this.dgestacionamento.AllowUserToOrderColumns = true;
            this.dgestacionamento.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgestacionamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgestacionamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVaga,
            this.PLACACOL,
            this.HORAENTRADACOL});
            this.dgestacionamento.Location = new System.Drawing.Point(12, 12);
            this.dgestacionamento.Name = "dgestacionamento";
            this.dgestacionamento.ReadOnly = true;
            this.dgestacionamento.RowTemplate.Height = 50;
            this.dgestacionamento.Size = new System.Drawing.Size(648, 217);
            this.dgestacionamento.TabIndex = 0;
            // 
            // idVaga
            // 
            this.idVaga.HeaderText = "VAGA";
            this.idVaga.Name = "idVaga";
            this.idVaga.ReadOnly = true;
            // 
            // PLACACOL
            // 
            this.PLACACOL.HeaderText = "PLACA";
            this.PLACACOL.Name = "PLACACOL";
            this.PLACACOL.ReadOnly = true;
            this.PLACACOL.Width = 200;
            // 
            // HORAENTRADACOL
            // 
            this.HORAENTRADACOL.HeaderText = "HORA ENTRADA";
            this.HORAENTRADACOL.Name = "HORAENTRADACOL";
            this.HORAENTRADACOL.ReadOnly = true;
            this.HORAENTRADACOL.Width = 300;
            // 
            // cbplacas
            // 
            this.cbplacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbplacas.FormattingEnabled = true;
            this.cbplacas.Location = new System.Drawing.Point(12, 266);
            this.cbplacas.Name = "cbplacas";
            this.cbplacas.Size = new System.Drawing.Size(324, 39);
            this.cbplacas.TabIndex = 1;
            // 
            // lblplacas
            // 
            this.lblplacas.AutoSize = true;
            this.lblplacas.Location = new System.Drawing.Point(6, 232);
            this.lblplacas.Name = "lblplacas";
            this.lblplacas.Size = new System.Drawing.Size(136, 31);
            this.lblplacas.TabIndex = 2;
            this.lblplacas.Text = "PLACAS: ";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(185, 421);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(151, 47);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbllavou
            // 
            this.lbllavou.AutoSize = true;
            this.lbllavou.Location = new System.Drawing.Point(6, 352);
            this.lbllavou.Name = "lbllavou";
            this.lbllavou.Size = new System.Drawing.Size(121, 31);
            this.lbllavou.TabIndex = 4;
            this.lbllavou.Text = "LAVOU?";
            // 
            // rbsim
            // 
            this.rbsim.AutoSize = true;
            this.rbsim.Location = new System.Drawing.Point(7, 386);
            this.rbsim.Name = "rbsim";
            this.rbsim.Size = new System.Drawing.Size(80, 35);
            this.rbsim.TabIndex = 5;
            this.rbsim.TabStop = true;
            this.rbsim.Text = "SIM";
            this.rbsim.UseVisualStyleBackColor = true;
            // 
            // rbnao
            // 
            this.rbnao.AutoSize = true;
            this.rbnao.Location = new System.Drawing.Point(7, 427);
            this.rbnao.Name = "rbnao";
            this.rbnao.Size = new System.Drawing.Size(91, 35);
            this.rbnao.TabIndex = 6;
            this.rbnao.TabStop = true;
            this.rbnao.Text = "NÃO";
            this.rbnao.UseVisualStyleBackColor = true;
            // 
            // txthorasaida
            // 
            this.txthorasaida.Location = new System.Drawing.Point(239, 308);
            this.txthorasaida.Name = "txthorasaida";
            this.txthorasaida.Size = new System.Drawing.Size(97, 38);
            this.txthorasaida.TabIndex = 7;
            // 
            // lblhorasaida
            // 
            this.lblhorasaida.AutoSize = true;
            this.lblhorasaida.Location = new System.Drawing.Point(6, 308);
            this.lblhorasaida.Name = "lblhorasaida";
            this.lblhorasaida.Size = new System.Drawing.Size(227, 31);
            this.lblhorasaida.TabIndex = 8;
            this.lblhorasaida.Text = "HORA DE SAIDA";
            // 
            // cbvagas
            // 
            this.cbvagas.FormattingEnabled = true;
            this.cbvagas.Location = new System.Drawing.Point(355, 266);
            this.cbvagas.Name = "cbvagas";
            this.cbvagas.Size = new System.Drawing.Size(305, 39);
            this.cbvagas.TabIndex = 9;
            // 
            // lblvagaslivres
            // 
            this.lblvagaslivres.AutoSize = true;
            this.lblvagaslivres.Location = new System.Drawing.Point(349, 232);
            this.lblvagaslivres.Name = "lblvagaslivres";
            this.lblvagaslivres.Size = new System.Drawing.Size(226, 31);
            this.lblvagaslivres.TabIndex = 10;
            this.lblvagaslivres.Text = "VAGAS LIVRES: ";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(355, 345);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(300, 38);
            this.txtplaca.TabIndex = 11;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(349, 311);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(118, 31);
            this.lblplaca.TabIndex = 12;
            this.lblplaca.Text = "PLACA: ";
            // 
            // lblhoraentrada
            // 
            this.lblhoraentrada.AutoSize = true;
            this.lblhoraentrada.Location = new System.Drawing.Point(349, 390);
            this.lblhoraentrada.Name = "lblhoraentrada";
            this.lblhoraentrada.Size = new System.Drawing.Size(276, 31);
            this.lblhoraentrada.TabIndex = 13;
            this.lblhoraentrada.Text = "HORA DE ENTRADA";
            // 
            // txthoraentrada
            // 
            this.txthoraentrada.Location = new System.Drawing.Point(355, 427);
            this.txthoraentrada.Name = "txthoraentrada";
            this.txthoraentrada.Size = new System.Drawing.Size(130, 38);
            this.txthoraentrada.TabIndex = 14;
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(502, 424);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(158, 49);
            this.btnentrar.TabIndex = 15;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // btnencerra
            // 
            this.btnencerra.BackColor = System.Drawing.Color.Crimson;
            this.btnencerra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnencerra.Location = new System.Drawing.Point(683, 12);
            this.btnencerra.Name = "btnencerra";
            this.btnencerra.Size = new System.Drawing.Size(45, 461);
            this.btnencerra.TabIndex = 16;
            this.btnencerra.Text = "ENCERRAR";
            this.btnencerra.UseVisualStyleBackColor = false;
            this.btnencerra.Click += new System.EventHandler(this.btnencerra_Click);
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 474);
            this.Controls.Add(this.btnencerra);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txthoraentrada);
            this.Controls.Add(this.lblhoraentrada);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.lblvagaslivres);
            this.Controls.Add(this.cbvagas);
            this.Controls.Add(this.lblhorasaida);
            this.Controls.Add(this.txthorasaida);
            this.Controls.Add(this.rbnao);
            this.Controls.Add(this.rbsim);
            this.Controls.Add(this.lbllavou);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lblplacas);
            this.Controls.Add(this.cbplacas);
            this.Controls.Add(this.dgestacionamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgestacionamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgestacionamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACACOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAENTRADACOL;
        private System.Windows.Forms.ComboBox cbplacas;
        private System.Windows.Forms.Label lblplacas;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbllavou;
        private System.Windows.Forms.RadioButton rbsim;
        private System.Windows.Forms.RadioButton rbnao;
        private System.Windows.Forms.TextBox txthorasaida;
        private System.Windows.Forms.Label lblhorasaida;
        private System.Windows.Forms.ComboBox cbvagas;
        private System.Windows.Forms.Label lblvagaslivres;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblhoraentrada;
        private System.Windows.Forms.TextBox txthoraentrada;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnencerra;
    }
}