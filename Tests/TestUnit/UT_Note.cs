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
        public void TestConstructor(string nom, int Note, string expectedNom, int expectedNote)
        {
            Note note = new Note(nom, Note);
            Assert.Equal(expectedNom, note.Nom);
            Assert.Equal(expectedNote, note.note);

        }
    }
}
