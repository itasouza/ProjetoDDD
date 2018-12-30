using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Projeto.Infrastructure.Repository
{
    public static class DapperRepository
    {


        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        //Execute Without Return
        public static void ExecuteSemRetorno(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        //Execute Return Scalar DapperORM.ExecuteComRetorno<int>(_,_)
        public static T ExecuteComRetorno<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar(procedureName, param, commandType:
                CommandType.StoredProcedure), typeof(T));

            }
        }

        //Executa uma consulta sql pura para 1 registro
        public static T ExecuteSqlPuroComRetorno<T>(string consultaSql)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var sql = string.Format(consultaSql);
                return sqlCon.Query<T>(sql).SingleOrDefault();
            }
        }


        //Execute Return List DapperORM.RetornoList<EmployeeModel> <=
        public static IEnumerable<T> RetornoList<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

     

    }
}