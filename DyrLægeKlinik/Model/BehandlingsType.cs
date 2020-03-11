using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class BehandlingsType:ConnectionClass
    {
        private string tableName = "BehandlingsType";
        private int behandlingsType_Id;
        private string procedure;
        private decimal price;
        public BehandlingsType(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
        }
        public int BehandlingsType_Id
        {
            get;
            set;
        }
        public string Procedure
        {
            get;
            set;
        }
        public decimal Price 
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Procedure,
                Price
            };
            List<string> keys = new List<string>()
            {
                "Procedure",
                "Price"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
