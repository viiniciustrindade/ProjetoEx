using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Infraestrutura.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly AppDbContext _context;

        public ProdutoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Salvar(Produto produto) 
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public void Excluir(Produto produto) 
        {
            _context.Remove(produto);
            _context.SaveChanges();
        }
        public void Alterar(Produto produto) 
        {
            var produtExistente = _context.Produtos.Find(produto.Id);
            if (produtExistente == null)
            {
                throw new Exception("Produto não existente");
            }

            produtExistente.NomeProduto = produto.NomeProduto;
            produtExistente.Preco = produto.Preco;
            produtExistente.Quantidade = produto.Quantidade;
        }
        public Produto? GetProdutoById(int id) 
        {
            return _context.Produtos.Find(id);
        }
        public List<Produto> GetProdutos() 
        {
            return _context.Produtos.ToList();
        }
    }
}
