using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        // Delegado para atualizar controles da interface gráfica de forma segura
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t; // Declaração da thread

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true; // Define a thread como um thread em segundo plano
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal"); // Exibe uma mensagem de caixa de diálogo
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive) // Verifica se a thread está em execução
            {
                t.Start(); // Inicia a thread se não estiver em execução
            }
        }

        private void Tarefa()
        {
            while (true)
            {
                //lblResultado.Text = DateTime.Now.Second.ToString(); // Atualiza o texto de um controle no formulário
                DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString()); // Chama o método para atualizar a propriedade de controle
            }

            //DefinirValorPropriedade(lblResultado, "BackColor", Color.Orange); // Define a cor de fundo de um controle
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                // Se a chamada não está no thread de interface, invoque o método de forma segura no thread de interface
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                // Caso contrário, atualize a propriedade do controle diretamente
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }
    }
}
