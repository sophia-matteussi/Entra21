﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWF_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btexec02_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
