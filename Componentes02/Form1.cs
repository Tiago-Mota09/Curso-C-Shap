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
    public partial class F_Principal : Form
    {
        public int num;

        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                tb_veiculo.Focus();//Define o focus de entrada para o controlo
                return;
            }
            //tb_listaVeiculos.Text = tb_veiculo.Text;
            //tb_listaVeiculos.Text = tb_listaVeiculos.Text + tb_veiculo.Text;//para o novo veiculo não substituir o anterior
            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";//para o novo veiculo não substituir o anterior(Abreviado)

            tb_veiculo.Clear();// Para limpar a cada nome
            tb_veiculo.Focus();//Para definir focus a cada nome
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculos.Text, this );
            f_Veiculos.ShowDialog();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_Checkbox = new F_CheckBox();
            f_Checkbox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ChecketListbox f_CheckedListBox = new F_ChecketListbox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }
    }
}
