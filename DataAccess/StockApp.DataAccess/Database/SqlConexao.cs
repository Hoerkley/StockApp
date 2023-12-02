namespace StockPhone.DataBase.SqlServer.Conexao
{
    internal static class SqlConexao
    {
        internal static string ConexaoSemBanco => @"Data Source=.\SQLEXPRESS;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockPhone;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";

        
    }
}