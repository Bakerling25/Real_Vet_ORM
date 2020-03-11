using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class Program
    {
        static void Main(string[] args)
        {

            Model.Behandling behandling = new Model.Behandling(ConnectionClass.SqlConnection())
            {
                BehandlingsType_ID = new List<Model.BehandlingsType>()
                {
                    new Model.BehandlingsType(ConnectionClass.SqlConnection())
                    {
                        Price = 134,
                        Procedure = "TandPleje"
                    }
                },
                KæleDyr_ID = new List<Model.AnimalPet>()
                {
                    new Model.AnimalPet(ConnectionClass.SqlConnection())
                    {
                        Alder = 6,
                        Navn = "Fido",
                        DyrEjer = new Model.AnimalOwner(ConnectionClass.SqlConnection())
                        {
                            Adresse = new List<Model.Adresse>()
                            {
                                new Model.Adresse(ConnectionClass.SqlConnection())
                                {
                                    GadeNavn = "Vej-199",
                                    ZipCode_ID = new Model.ZipCode(ConnectionClass.SqlConnection())
                                    {
                                        City = "Odense"
                                    }
                                }
                               
                            },
                            Navn = "ThomasEjer"
                        },
                        DyrKøn = new Model.AnimalSex(ConnectionClass.SqlConnection())
                        {
                            Køn = "HanKøn"
                        },
                        DyrRace = new Model.AnimalRace(ConnectionClass.SqlConnection())
                        {
                            Race = "Pudel"
                        }
                    }
                }
            };
            behandling.Save();
            Console.ReadLine();
        }
    }
}
