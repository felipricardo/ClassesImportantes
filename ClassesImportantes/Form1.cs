﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //    //MessageBox.Show("Ola galera!");
            //    //MessageBox.Show("Mensagem a ser impressa", "Titulo da mensagem");

            //    DialogResult res = MessageBox.Show("Texto da mensagem", "Titulo", MessageBoxButtons.OKCancel);

            //    if (res == DialogResult.OK)
            //    {
            //        lblResultado.Text = "Clicou em Ok";
            //    }
            //    else if (res == DialogResult.Cancel)
            //    {
            //        lblResultado.Text = "Clicou em Cancelar";
            //    }

            MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}