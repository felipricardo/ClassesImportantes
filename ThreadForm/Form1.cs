using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propridade, object valor);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            while (true)
            {
                lblResultado.Text = DateTime.Now.Second.ToString();
            }
        }
    }
}
