﻿using MySql.Data.MySqlClient;
using System.Data;

namespace AlunosApi.Repositores
{
    public class PessoaRepository
    {
        private readonly string _connectionString;
        

        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        private IDbConnection Connection => new MySqlConnection(_connectionString);
    }
}
