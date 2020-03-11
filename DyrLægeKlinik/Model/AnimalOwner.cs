using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class AnimalOwner:ConnectionClass
    {
        private string tableName = "DyrEjer";
        private int dyrEjer_ID;
        private string navn;
        private List<Adresse> adresse;
        public AnimalOwner(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
        }
        public int DyrEjer_ID
        {
            get;
            set;
        }
        public string Navn
        { 
            get;
            set;
        }
        public List<Adresse> Adresse
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Navn,
                Adresse
            };
            List<string> keys = new List<string>()
            {
                "Navn",
                "Adresse"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
        public void Delete()
        {
            ConnectionClass.Delete(tableName, "DyrEjer_ID", DyrEjer_ID, conn);
        }
    }
}
