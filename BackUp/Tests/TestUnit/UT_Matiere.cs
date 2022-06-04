using Modele;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestUnit
{
    public class UT_Matiere
    {
        //Premier Constructeur avec nom et notes
        [Theory]
        [InlineData("Structure de données", "Structure de données",false)]
        [InlineData(null, "", true)]
        public void TestConstructor(string nom, string expectedNom, bool shouldThrowException)
        {
            List<Note> notes = new List<Note>();
            Note note = new Note("Exam (sur 20.0)", 10.25);
            notes.Add(note);
            if(shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Matiere(nom, notes));
                return;
            }
            Matiere mat = new Matiere(nom, notes);
            Assert.Equal(mat.Nom, expectedNom);
        }

        //Deuxième Constructeur sans notes
        [Theory]
        [InlineData("Structure de données", "Structure de données", false)]
        [InlineData(null, "", true)]
        public void TestConstructorSansNotes(string nom, string expectedNom, bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Matiere(nom));
                return;
            }
            Matiere mat = new Matiere(nom);
            Assert.Equal(mat.Nom, expectedNom);
        }

        //3ième Constructeur sans nom
        [Theory]
        [InlineData("Aucun Nom")]
        public void TestConstructorSansNom(string expectedNom)
        {
            List<Note> notes = new List<Note>();
            Matiere mat = new Matiere(notes);
            Assert.Equal(mat.Nom, expectedNom);
        }

        [Theory]
        [InlineData(10, 10, 10, 20 ,"10")]
        [InlineData(16, 10, 9, 10 ,"11,67")]
        public void TestMoyenne(double premièreNote, double deuxièmeNote, double troisièmeNote, double quatrièmeNote, string expectedNote)
        {
            Matiere mat = new Matiere("Test");
            mat.AddNote(new Note("Test1", premièreNote));
            mat.AddNote(new Note("Test2", deuxièmeNote));
            mat.AddNote(new Note("Test3", troisièmeNote));
            Note n = new Note("Test4", quatrièmeNote);
            mat.AddNote(n);
            mat.SuppNote(n);//On verifie qu'on peut bien supprimer une note
            string final = mat.MoyMatière().ToString(".##");
            Assert.Equal(final, expectedNote);
        }
    }
}
