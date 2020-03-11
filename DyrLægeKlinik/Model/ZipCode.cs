using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class ZipCode:ConnectionClass
    {
        private string tableName = "ZipCode";
        private int zipCode_ID;
        private string city;
        public ZipCode(SqlConnection sqlConnecntion)
        {
            conn = sqlConnecntion;
        }
        public int ZipCode_ID
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                City
            };
            List<string> keys = new List<string>()
            {
                "City"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
