using StockApp.Business.Interfaces.Banco;
using StockApp.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.WindowsForms._inicializar
{
    internal class InicializarDataBase
    {
        private  readonly IBancoServicos _bancoservicos;
        public InicializarDataBase()
        {
            _bancoservicos = new DatabaseServices();
        }

        internal void Init()
        {
            _bancoservicos.CriarBanco();
            _bancoservicos.CriarTabelaCategoria();
        }
    }
}
