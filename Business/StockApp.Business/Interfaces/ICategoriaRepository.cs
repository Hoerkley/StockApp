using StockApp.Business.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Interfaces
{
    public interface ICategoriaRepository
    {
        bool Incluir(Categoria categoria);
        bool Atualizar (Categoria categoria);
        bool Deletar (int id);
        bool Ativar(int id);
        bool Inativar (int id);
        Categoria ObterPorId(int id);
        List<Categoria> ObterTodos();
        List<Categoria> ObterAtivas();
    }
}
