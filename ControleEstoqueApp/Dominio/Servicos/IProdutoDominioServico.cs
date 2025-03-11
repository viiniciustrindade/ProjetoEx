using ControleEstoqueApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Dominio.Servicos
{
    public interface IProdutoDominioServico
    {
        void Validar(Produto produto);
        void ValidarId(int id);
    }
}
