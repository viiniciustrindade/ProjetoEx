using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Dominio.Entidades
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column("nomeProduto")]
        public string NomeProduto { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public Produto(string nomeProduto, int quantidade, decimal preco) 
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Preco = preco;
        }
        public Produto(int id, string nomeProduto, int quantidade, decimal preco)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Preco = preco;
        }

    }
}
