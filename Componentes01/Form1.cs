using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_C_Sharp
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String txt;//Variável string com nome TXT
            //txt = textBox1.Text;//Variável pra guardar o que entrar na caixa de texto
            //label1.Text = txt;//label1 (LINK) recebe a variável TXT
            //OU
            label1.Text = textBox1.Text;//Meu LINK recebe o TEXTO que foi passado na textBox
        }
    }
}
