using Modele;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestUnit
{
    public class UT_UE
    {
        //Test premier Constructeur UE (Tout les attributs)
        [Theory]
        [InlineData("UE 1", "Développer des applications informatiques simples", "UE 1", "Développer des applications informatiques simples",false)]
        [InlineData(null, "Développer des applications informatiques simples", "UE 1", "Développer des applications informatiques simples", true)]//Nom null
        public void TestConstructor(string num, string Description, string expectedNum, string expectedDescription, bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new UE(num, Description));
                return;
            }
            UE ue = new UE(num, Description);
            Assert.Equal(ue.num, expectedNum);
            Assert.Equal(ue.Description, expectedDescription);
        }

        //Test deuxième Constructeur UE(sans Description)
        [Theory]
        [InlineData("UE 1", "UE 1", null ,false)]
        [InlineData(null,  "UE 1", null ,true)]//Nom null
        public void TestSecondConstructor(string num, string expectedNum, string expectedDescription ,bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new UE(num));
                return;
            }
            UE ue = new UE(num);
            Assert.Equal(ue.num, expectedNum);
            Assert.Equal(ue.Description, expectedDescription);
        }

        [Theory]
        [InlineData(16, 6, 9, 15, 15, 40 ,"13,47")]
        [InlineData(16, 6, 9, 15, 15, 1, "11,81")]
        public void TestOperationUE(double premièreNote, double deuxièmeNote, double troisièmeNote, double quatrièmeNote, double noteSAE, int coefSAE ,string expectedNote)
        {
            //Création de note
            Note n = new Note(null, premièreNote);
            Note n2 = new Note(null, deuxièmeNote);
            Note n3 = new Note(null, troisièmeNote);
            Note n4 = new Note(null, quatrièmeNote);
            Note n5 = new Note(null, noteSAE);
            SAE sae = new SAE("SAE", n5,coefSAE);

            List<Note> notes = new List<Note>();
            notes.Add(n);
            notes.Add(n2);

            List<Note> notes2 = new List<Note>();
            notes2.Add(n3);
            notes2.Add(n4);

            //Première Matière
            Matiere mat = new Matiere(notes);

            //Deuxième Matière
            Matiere mat2 = new Matiere(notes2);

            //Creation Ressource

            Ressource TestRes = new Ressource("Test", 10, new List<Matiere>());
            TestRes.AddMatiere(mat);

            //Je prend différent coefficient pour les ressources pour verifier qu'elles sont bien prix en compte lors du calcul

            Ressource TestRes2 = new Ressource("Test2", 25, new List<Matiere>());
            TestRes2.AddMatiere(mat2);

            //Creation UE

            UE ue = new UE("Test");

            //Test des méthodes ajouter ressources et sae
            ue.AddRessource(TestRes);
            ue.AddRessource(TestRes2);
            ue.AddSAE(sae);

            //On test si la moyenne de l'UE renvoie bien le bon résultat
            string final = ue.MoyUE().ToString(".##");
            Assert.Equal(final, expectedNote);
        }
    }
}
