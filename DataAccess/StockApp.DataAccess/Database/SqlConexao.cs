﻿namespace StockPhone.DataBase.SqlServer.Conexao
{
    internal static class SqlConexao
    {
        internal static string ConexaoSemBanco => @"server=CEPEAS21103947\SQLEXPRESS; Integrated Security=True; User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        internal static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockApp;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";

        
    }
}