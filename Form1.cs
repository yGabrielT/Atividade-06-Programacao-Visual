using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void brnGerarPedido_Click(object sender, EventArgs e)
        {
            // Validações mínimas
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Validação");
                txtCliente.Focus();
                return;
            }

            if (cmbProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto.", "Validação");
                cmbProduto.Focus();
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.", "Validação");
                txtQuantidade.Focus();
                return;
            }

            // Grava data e hora no momento do clique
            DateTime dataHoraPedido = DateTime.Now;
            lblDataHora.Text = dataHoraPedido.ToString("dd/MM/yyyy HH:mm:ss");

            // Protocolo único baseado em data/hora
            string protocolo = "PED-" + dataHoraPedido.ToString("yyyyMMddHHmmss");
            lblProtocolo.Text = protocolo;

            string entrega = rdbRetirada.Checked ? "Retirada" : "Entrega";

            // Exemplo usando repetição para montar itens da ListBox
            string itens = "";
            for (int i = 0; i < lstItensPedido.Items.Count; i++)
            {
                itens += "- " + lstItensPedido.Items[i].ToString() + Environment.NewLine;
            }

            lblResumo.Text =
              "Cliente: " + txtCliente.Text + Environment.NewLine +
              "Produto: " + cmbProduto.Text + Environment.NewLine +
              "Quantidade: " + qtd + Environment.NewLine +
              "Entrega: " + entrega + Environment.NewLine +
              "Itens:" + Environment.NewLine + itens;
        }

        private void btnGerarNovoPedido_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtQuantidade.Clear();
            cmbProduto.SelectedIndex = -1;
            rdbRetirada.Checked = false;
            rdbEntrega.Checked = false;
            lstItensPedido.Items.Clear();

            // Limpa saídas do protocolo
            lblResumo.Text = "";
            lblDataHora.Text = "";
            lblProtocolo.Text = "";

            txtCliente.Focus();
        }
    }
}
