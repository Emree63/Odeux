using Modele;
using System;
using Xunit;

namespace TestUnit
{
    public class UT_Note
    {
        [Theory]
        [InlineData("Exam (sur 20.0)",10.25, "Exam (sur 20.0)",10.25)] //Tout bon
        [InlineData("", -2, "Aucun Nom", 0)]//Nom vide et note inférieur à 0
        [InlineData("", 52, "Aucun Nom", 0)]//Nom vide et note supérieur à 20
        public void TestConstructor(string nom, double Note, string expectedNom, double expectedNote)
        {
            Note note = new Note(nom, Note);
            Assert.Equal(expectedNom, note.Nom);
            Assert.Equal(expectedNote, note.note);
        }

        [Theory]
        [InlineData("Exam",7.0,11.71,11.71)]
        [InlineData("Exam", 7.0, -1, 7)]
        [InlineData("Exam", 7.0, 31, 7.0)]
        public void TestModifier(string nom, double note, double NouvelNote, double expectedNote)
        {
            Note Testnote = new Note(nom, note);
            Testnote.Modifier(NouvelNote);
            Assert.Equal(expectedNote, Testnote.note);
        }
    }
}
