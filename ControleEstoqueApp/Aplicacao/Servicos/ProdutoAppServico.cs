using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Dominio.Servicos;
using ControleEstoqueApp.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Aplicacao.Servicos
{
    public class ProdutoAppServico : IProdutoAppServico
    {
        private readonly IProdutoDominioServico _dominioServico;
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoAppServico(IProdutoDominioServico dominioServico, IProdutoRepositorio produtoRepositorio)
        {
            _dominioServico = dominioServico;
            _produtoRepositorio = produtoRepositorio;
        }

        public void CadastrarProduto(string nomeProduto, int quantidade, decimal preco)
        {
            var produto = new Produto(nomeProduto, quantidade, preco);
            _dominioServico.Validar(produto);
            _produtoRepositorio.Salvar(produto);
        }
        public void AlterarProduto(int id, string nomeProduto, int quantidade, decimal preco)
        {
            _dominioServico.ValidarId(id);

            var produtoExistente = _produtoRepositorio.GetProdutoById(id);
            if (produtoExistente == null) 
            {
                throw new Exception("Produto não encontrado para alteração");
            }
            produtoExistente.NomeProduto = nomeProduto;
            produtoExistente.Quantidade = quantidade;
            produtoExistente.Preco = preco;
            
            _dominioServico.Validar(produtoExistente);
            _produtoRepositorio.Alterar(produtoExistente);
        }
        public void ExcluirProduto(Produto produto) 
        {
            var produtoExistente = _produtoRepositorio.GetProdutoById(produto.Id);
            if (produtoExistente == null)
            {
                throw new Exception("Produto não encontrado para alteração");
            }

            _produtoRepositorio.Excluir(produtoExistente);
        }
        public List<Produto> GetProdutos() 
        {
            return _produtoRepositorio.GetProdutos();
        }

    }
}
