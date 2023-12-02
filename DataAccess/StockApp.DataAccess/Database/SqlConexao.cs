namespace StockPhone.DataBase.SqlServer.Conexao
{
    internal static class SqlConexao
    {
        internal static string StrConexao()
        {        
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=StockPhone;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        }
    }
}