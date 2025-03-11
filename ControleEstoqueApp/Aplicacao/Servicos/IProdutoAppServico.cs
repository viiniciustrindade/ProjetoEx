using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Aplicacao.Servicos
{
    public interface IProdutoAppServico
    {
        void CadastrarProduto(string nomeProduto, int quantidade, decimal preco);
        void AlterarProduto(int id, string nomeProduto, int quantidade, decimal preco);
        void ExcluirProduto(Produto produto);
        List<Produto> GetProdutos();
    }
}
