using MVCp1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnavancar_Click(object sender, EventArgs e)
        {
            if (rbexec02.Checked)
            {
                //quando for fazer o new exec02, irá dar erro: selecionar e fazer ctrl '.'

                new Exec02().Show();
                this.Hide();
            }
            if (rbexec01.Checked)
            {
                new Exec01().Show();
                this.Hide();
            }
            if (rbexec03.Checked)
            {
                new Exec03().Show();
                this.Hide();
            }
            if (rbtabela01.Checked)
            {
                new Tabela01().Show();
                this.Hide();
            }
        }

        private void rbtabela01_CheckedChanged(object sender, EventArgs e)
        {
            //errado
        }
    }
}
