using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Projeto.Infrastructure.Repository
{
    public  class DapperRepository : IDisposable
    {

        private readonly SqlConnection minhaConexao;

        public DapperRepository()
        {
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            minhaConexao.Open();
        }


        //Execute Without Return
        public  void ExecuteSemRetorno(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(minhaConexao.ToString()))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        //Execute Return Scalar DapperORM.ExecuteComRetorno<int>(_,_)
        public  T ExecuteComRetorno<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(minhaConexao.ToString()))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar(procedureName, param, commandType:
                CommandType.StoredProcedure), typeof(T));

            }
        }

        //Executa uma consulta sql pura para 1 registro
        public  T ExecuteSqlPuroComRetorno<T>(string consultaSql)
        {
            using (SqlConnection sqlCon = new SqlConnection(minhaConexao.ToString()))
            {
                sqlCon.Open();
                var sql = string.Format(consultaSql);
                return sqlCon.Query<T>(sql).SingleOrDefault();
            }
        }


        //Execute Return List DapperORM.RetornoList<EmployeeModel> <=
        public  IEnumerable<T> RetornoList<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(minhaConexao.ToString()))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open)
                minhaConexao.Close();
        }
    }
}