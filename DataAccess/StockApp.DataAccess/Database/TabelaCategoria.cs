using Dapper;
using Microsoft.Data.SqlClient;
using StockPhone.DataBase.SqlServer.Conexao;

namespace StockApp.DataAccess.Database
{
    public partial class DatabaseServices
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Categoria')
                        BEGIN
                            CREATE TABLE Categoria 
                            (
                                Id INT PRIMARY KEY,
                                Nome NVARCHAR(255) NOT NULL 
                            );
                        END";

            try
            {
                using (var conexao = new SqlConnection(SqlConexao.ConexaoComBanco))
                {
                    conexao.Open();
                    var resultado = conexao.Execute(sql);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
