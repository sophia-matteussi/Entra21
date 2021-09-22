using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec02_AulaWF03
{
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if ((cb2.Checked && cb3.Checked) && !(cb1.Checked || cb4.Checked || cb5.Checked))
            {
                MessageBox.Show("Login efetuado");
            }
            else
            {
                MessageBox.Show("Login falhou");
            }
        }
    }
}
