using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class Adresse:ConnectionClass
    {
        private string tableName = "Adresse";
        private int adresse_ID;
        private string gadeNavn;
        private ZipCode zipCode_ID;
        public int Adresse_ID { get; set; }
        public string GadeNavn { get; set; }
        public ZipCode ZipCode_ID { get; set; }
        public Adresse(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                GadeNavn,
                ZipCode_ID.ZipCode_ID
            };
            List<string> keys = new List<string>()
            {
                "GadeNavn",
                "ZipCode_ID"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
        
    }
}
