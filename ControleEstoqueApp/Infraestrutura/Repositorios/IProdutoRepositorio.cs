using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Infraestrutura.Repositorios
{
    public interface IProdutoRepositorio
    {
        void Salvar(Produto produto);
        void Excluir(Produto produto);
        void Alterar(Produto produto);

        Produto? GetProdutoById(int id);
        List<Produto> GetProdutos();
    }
}
