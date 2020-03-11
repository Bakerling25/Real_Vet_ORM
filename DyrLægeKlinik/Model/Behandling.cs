using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DyrLægeKlinik.Model
{
    class Behandling : ConnectionClass
    {
        private string tableName = "Behandling";
        private int behandling_ID;
        private DateTime dateOfProcedure = DateTime.Now;
        private List<BehandlingsType> behandlingsType_ID;
        private List<AnimalPet> kæleDyr_ID;
        public Behandling(SqlConnection sqlConnection)
        {
            conn = sqlConnection;
            
        }
        public int Behandling_ID
        {
            get;
            set;
        }
        public DateTime DateOfProcedure
        {
            get { return dateOfProcedure; }
            set { dateOfProcedure = value; }
        }
        public List<BehandlingsType> BehandlingsType_ID
        {
            get;
            set;
        }
        public List<AnimalPet> KæleDyr_ID
        {
            get;
            set;
        }
        public void Save()
        {
             
            ArrayList values = new ArrayList()
            {
                DateOfProcedure,
                BehandlingsType_ID,
                KæleDyr_ID
            };
            List<string> keys = new List<string>()
            {
                "DateOfProcedure",
                "BehandlingsType_ID",
                "Kæledyr_ID"
            };
            ConnectionClass.Insert(tableName, values, keys, conn);

        }
        public void Delete()
        {
            ConnectionClass.Delete(tableName, "Behandling_ID", Behandling_ID, conn);
        }
    }
}
