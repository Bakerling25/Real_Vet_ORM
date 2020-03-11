using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace DyrLægeKlinik.Model
{
    class AnimalRace:ConnectionClass
    {
        private string tableName = "DyrRace";
        private int dyrRace_Id;
        private string race;
        public AnimalRace(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
        }
        public int DyrRace_Id
        {
            get;
            set;
        }
        public string Race
        {
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Race
            };
            List<string> keys = new List<string>()
            {
                "Race"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);
        }
    }
}
