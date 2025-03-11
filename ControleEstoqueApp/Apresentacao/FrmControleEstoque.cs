using ControleEstoqueApp.Aplicacao.Servicos;
using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Dominio.Servicos;
using ControleEstoqueApp.Infraestrutura.Database;
using ControleEstoqueApp.Infraestrutura.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace ControleEstoqueApp
{
    public partial class FrmControleEstoque : Form
    {
        private readonly IProdutoAppServico _servico;
        public FrmControleEstoque(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servico = serviceProvider.GetRequiredService<IProdutoAppServico>();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("Nome do produto é obrigatório.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    _servico.CadastrarProduto(txtProduto.Text, int.Parse(txtQuantidade.Text), decimal.Parse(txtPreco.Text));
                    MessageBox.Show("Produto salvo com sucesso!");
                    CarregarProdutos();
                }
                else
                {
                    _servico.AlterarProduto(int.Parse(txtId.Text), txtProduto.Text, int.Parse(txtQuantidade.Text), decimal.Parse(txtPreco.Text));
                    MessageBox.Show("Produto atualizado com sucesso!");
                    CarregarProdutos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
            }

        }

        private void FrmControleEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("Nome do produto é obrigatório.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            try
            {
                var produto = new Produto(int.Parse(txtId.Text), txtProduto.Text,int.Parse(txtQuantidade.Text), decimal.Parse(txtPreco.Text));
                _servico.ExcluirProduto(produto);
                MessageBox.Show("Produto excluido com sucesso");
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
            }
        }
        private void CarregarProdutos()
        {
            var produtos = _servico.GetProdutos();

            dtgEstoque.DataSource = produtos;

            dtgEstoque.Columns["Id"].HeaderText = "ID";
            dtgEstoque.Columns["NomeProduto"].HeaderText = "Nome do Produto";
            dtgEstoque.Columns["Quantidade"].HeaderText = "Quantidade";
            dtgEstoque.Columns["Preco"].HeaderText = "Preço";
        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                var produtoSelecionado = dtgEstoque.Rows[e.RowIndex].DataBoundItem as Produto;

                if (produtoSelecionado != null)
                { 
                    txtId.Text = produtoSelecionado.Id.ToString();
                    txtProduto.Text = produtoSelecionado.NomeProduto;
                    txtQuantidade.Text = produtoSelecionado.Quantidade.ToString();
                    txtPreco.Text = produtoSelecionado.Preco.ToString("F2");
                }
            }
        }
    }
}
