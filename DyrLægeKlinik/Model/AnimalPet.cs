using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik.Model
{
    class AnimalPet:ConnectionClass
    {
        private string tableName = "AnimalPet";
        private int kæleDyr_ID;
        private string navn;
        private int alder;
        private AnimalRace dyrRace;
        private AnimalSex dyrKøn;
        private AnimalOwner dyrEjer;
        public AnimalPet(SqlConnection connection)
        {
            conn = connection;
        }
        public int KæleDyr_ID
        {
            get;
            set;
        }
        public string Navn
        {
            get;
            set;
        }
        public int Alder
        {
            get;
            set;
        }
        public AnimalRace DyrRace
        {
            get;
            set;
        }
        public AnimalSex DyrKøn
        {
            get;
            set;
        }
        public AnimalOwner DyrEjer 
        { 
            get;
            set;
        }
        public void Save()
        {
            ArrayList values = new ArrayList()
            {
                Navn,
                Alder,
                DyrRace.DyrRace_Id,
                DyrEjer.DyrEjer_ID,
                DyrKøn.Køn_Id
            };
            List<string> keys = new List<string>()
            {
                "Navn",
                "Alder",
                "DyrRace_ID",
                "DyrEjer_ID",
                "Køn_ID"
            };
            Console.WriteLine(ConnectionClass.Insert(tableName, values, keys,conn).ToString() + " Primærnøgle");
        }
        public void Delete()
        {
            
            ConnectionClass.Delete(tableName, "KæleDyr_ID", KæleDyr_ID, conn);
        }
        public void Update()
        {
            ArrayList values = new ArrayList()
            {
                Navn,
                Alder
            };
            List<string> keys = new List<string>()
            {
                "Navn",
                "Alder"
            };
            ConnectionClass.Update(tableName, values, keys, conn);
        }
       

    }
}
