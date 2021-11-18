using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1LAURA26
{
    public partial class Frm_perfumes : Form
    {
        public Frm_perfumes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Perfumes obj = new Perfumes();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Perfumes obj = new Perfumes();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Alterar();
            MessageBox.Show("Alterado!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Perfumes obj = new Perfumes();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Perfumes obj = new Perfumes();
            dataGridView1.DataSource = obj.Listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_marca Frm_marca = new Frm_marca();
            Frm_marca.ShowDialog();
        }
    }
}
