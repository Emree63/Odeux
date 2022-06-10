using Modele;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestUnit
{
    public class UT_Ressource
    {
        //Test Premier Constructeur (Tout les attributs renseigner)
        [Theory]
        [InlineData("R1:01", "D�veloppement en Algorithme", 16, "R1:01", "D�veloppement en Algorithme", 16, false)]
        [InlineData(null, "D�veloppement en Algorithme", 16, "R1:01", "D�veloppement en Algorithme", 16, true)]//Num de la ressource null
        [InlineData("R1:01", "D�veloppement en Algorithme", -5, "R1:01", "D�veloppement en Algorithme", 16, true)]//Coefficient n�gative
        public void TestConstructor(string num, string Description, int coef, string expectedNum, string expectedDescription, int expectedCoef, bool shouldThrowException)
        {
            List<Matiere> mat = new List<Matiere>();
            mat.Add(new Matiere("Test"));
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Ressource(num, Description, coef, mat));
                return;
            }
            Ressource res = new Ressource(num, Description, coef, mat);
            Assert.Equal(res.Num, expectedNum);
            Assert.Equal(res.Description, expectedDescription);
            Assert.Equal(res.Coef, expectedCoef);
        }

        //Test Deuxi�me Constructeur (Sans Description)
        [Theory]
        [InlineData("R1:01", 16, "R1:01", "Aucune Description", 16, false)]
        [InlineData(null, 16, "R1:01", "Aucune Description", 16, true)]//Num de la ressource null
        [InlineData("R1:01", -5, "R1:01", "Aucune Description", 16, true)]//Coefficient n�gative
        public void TestSecondConstructor(string num, int coef, string expectedNum, string expectedDes, int expectedCoef, bool shouldThrowException)
        {
            List<Matiere> mat = new List<Matiere>();
            mat.Add(new Matiere("Test"));
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Ressource(num, coef, mat));
                return;
            }
            Ressource res = new Ressource(num, coef, mat);
            Assert.Equal(res.Num, expectedNum);
            Assert.Equal(res.Description, expectedDes);
            Assert.Equal(res.Coef, expectedCoef);
        }


        [Theory]
        [InlineData(10, 10, 11, 10, "10,25", false)]
        [InlineData(16, 6, 9, 15, "11,5", false)]
        [InlineData(16, 6, 1, 1, "11", true)]
        public void TestMoyenneRes(double premi�reNote, double deuxi�meNote, double troisi�meNote, double quatri�meNote, string expectedNote, bool expectedMat)
        {
            //Cr�ation de note
            Note n = new Note(null, premi�reNote);
            Note n2 = new Note(null, deuxi�meNote);
            Note n3 = new Note(null, troisi�meNote);
            Note n4 = new Note(null, quatri�meNote);

            List<Note> notes = new List<Note>();
            notes.Add(n);
            notes.Add(n2);

            List<Note> notes2 = new List<Note>();
            if (!expectedMat)//On teste le cas d'une mati�re sans note
            {
                notes2.Add(n3);
                notes2.Add(n4);
            }

            //Premi�re Mati�re
            Matiere mat = new Matiere(notes);

            //Deuxi�me Mati�re
            Matiere mat2 = new Matiere(notes2);

            //Creation Ressource

            List<Matiere> matieres = new List<Matiere>();
            Ressource TestRes = new Ressource("Test", 10, matieres);
            TestRes.AddMatiere(mat);
            TestRes.AddMatiere(mat2);
            string final = TestRes.MoyRessource().ToString(".##");
            Assert.Equal(final, expectedNote);
        }
    }
}
