using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace DyrLægeKlinik
{
    class ConnectionClass
    {
        protected SqlConnection conn;
        public static SqlConnection SqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "Vet",
                UserID = "ThomasTest",
                Password = "1234",
                DataSource = "localhost"
            };
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
        public static int Insert(string tableName,ArrayList values,List<string> keys,SqlConnection connection)
        {
            string colums = string.Join(",", keys);
            string parammeters = "@" + string.Join(",@", keys);
            string query = "INSERT INTO " + tableName + " (" + colums + ") Output Inserted.KæleDyr_ID" +
            " VALUES " + "(" + parammeters + ")";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            for (int i = 0; i < keys.Count; i++)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@" + keys[i], values[i]));
            }

            Console.WriteLine(query);

            connection.Open();
            int pk_Key = (int)sqlCommand.ExecuteScalar();
            //sqlCommand.ExecuteNonQuery();
            connection.Close();
            return pk_Key;
        }
        public static void Delete(string tableName,string colum,int delete_Id, SqlConnection connection)
        {
            string query = "Delete from " + tableName + " where " + colum + " = " + " @Delete_ID";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.Add(new SqlParameter("@Delete_ID", delete_Id));

            Console.WriteLine(query);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        public static void Update(string tableName, ArrayList values, List<string> keys, SqlConnection connection)
        {
            

        }
   
    }
}
