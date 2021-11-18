using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1LAURA26
{
    public partial class Frm_marca : Form
    {
        public Frm_marca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.marca = txtMarca.Text;
            obj.descricao = txtDescricao.Text;
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.marca = txtMarca.Text;
            obj.descricao = txtDescricao.Text;
            obj.Alterar();
            MessageBox.Show("Alterado!");
            txtId.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtMarca.Clear();
            txtDescricao.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_perfumes Frm_perfumes = new Frm_perfumes();
            Frm_perfumes.ShowDialog();
        }
    }
}
