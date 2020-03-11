using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.AnimalPet animalPet = new Model.AnimalPet(ConnectionClass.SqlConnection())
            {
                //KæleDyr_ID = 13018,
                Navn = "Fidotest",
                Alder = 10,
                DyrKøn = new Model.AnimalSex(ConnectionClass.SqlConnection())
                {
                    Køn_Id = 2,
                    Køn = "HanKøn"
                },
                DyrEjer = new Model.AnimalOwner(ConnectionClass.SqlConnection())
                {
                    DyrEjer_ID = 150,
                    Navn = "ThomasEjer"
                },
                DyrRace = new Model.AnimalRace(ConnectionClass.SqlConnection())
                {
                    DyrRace_Id = 32,
                    Race = "Pudel"
                }
            };
            //animalPet.Save();
            //animalPet.Delete();
            animalPet.Update();
            Console.ReadLine();
        }
    }
}
