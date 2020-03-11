using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class AnimalSex:ConnectionClass
    {
        private string tableName = "Sex";
        private int køn_Id;
        private string køn;
        public AnimalSex(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
        }
        public int Køn_Id
        {
            get;
            set;
        }
        public string Køn
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Køn
            };
            List<string> keys = new List<string>()
            {
                "Køn"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
