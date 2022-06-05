using Modele;
using System;

namespace Test_DataContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Stub.Stub());
            manager.ChargeDonnées();
            manager.Persistance = new DataContractPersistance.DataContractPersJSON();
            manager.SauvegardeDonnées();
        }
    }
}
