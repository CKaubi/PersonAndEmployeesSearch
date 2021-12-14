using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationServicePerson
{
    public class DatabaseProvaider
    {
       private SqlConnection _connectionAdventure = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks2019"].ConnectionString);
       public SqlConnection ConnectionAdventure
        {
            get
            {
                return _connectionAdventure;
            }
        }

        public void Registration(string login, string password)
        {
            SqlConnection Connection = ConnectionAdventure;
            using (Connection)
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("RegistrUser", Connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter paramLog = new SqlParameter
                {
                    ParameterName = "@Login",
                    Value = login
                };

                SqlParameter paramPass = new SqlParameter
                {
                    ParameterName = "@Password",
                    Value = password
                };

                command.Parameters.Add(paramLog);
                command.Parameters.Add(paramPass);
                command.ExecuteNonQuery();
            }
        }

        public string GetPassword(string login)
        {
            SqlConnection Connection = ConnectionAdventure;
            using (Connection)
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("getuserPass", Connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paramLog = new SqlParameter
                {
                    ParameterName = "@Login",
                    Value = login
                };

                command.Parameters.Add(paramLog);
                if (command.ExecuteScalar() != null)
                {
                    string pass = command.ExecuteScalar().ToString();
                    return pass;
                }
                else
                {
                    return null;
                }
            }
        }
        public bool CheckLogins(string login)
        {
            SqlConnection Connection = ConnectionAdventure; 
            using (Connection)
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("CheckLogins", Connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paramLogin = new SqlParameter
                {
                    ParameterName = "@Login",
                    Value = login
                };
                command.Parameters.Add(paramLogin);
               
                return Convert.ToBoolean(command.ExecuteScalar());
            }
        }
        public void HirePerson(int id)
        {
            SqlConnection Connection = ConnectionAdventure;
            using (Connection)
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("HirePerson", Connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter paramBusinessEntityID = new SqlParameter
                {
                    ParameterName = "@BusinessEntityID",
                    Value = id
                };
                command.Parameters.Add(paramBusinessEntityID);
                command.ExecuteNonQuery();
            }
        }
    }
}