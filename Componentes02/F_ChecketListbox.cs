using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes02
{
    public partial class F_ChecketListbox : Form
    {
        public F_ChecketListbox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            //clb_transportes.Items.Add("Carro", false);//Adiciona um a um
            //clb_transportes.Items.Add("Avião", false);
            //clb_transportes.Items.Add("Navio", false);
            //clb_transportes.Items.Add("Ônibus", false);
            //clb_transportes.Items.Add("Trem", false);

            List<string> tr = new List<string>();

            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());//Adiciona a lista completa
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
        }
    }
}
