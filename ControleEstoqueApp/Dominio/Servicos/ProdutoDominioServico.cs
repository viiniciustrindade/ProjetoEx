using ControleEstoqueApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Dominio.Servicos
{
    public class ProdutoDominioServico : IProdutoDominioServico
    {
        public void Validar(Produto produto)
        { 
            if (string.IsNullOrEmpty(produto.NomeProduto))
            {
                throw new Exception("Nome é obrigatório");
            }
            if (produto.Quantidade < 0)
            {
                throw new Exception("Quantidade deve ser maior que zero");
            }
            if (produto.Preco < 0)
            {
                throw new Exception("Preço deve ser maior que zero");
            }
        }
        public void ValidarId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Id inválido");
            }
        }
    }
}
