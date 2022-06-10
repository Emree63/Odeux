using Modele;
using System;
using Xunit;

namespace TestUnit
{
    public class UT_Sae
    {
        [Theory]
        [InlineData("Recueil de besoin", 10, "Recueil de besoin", 10)]//Nom, Coef et note correct
        [InlineData("", -2, "Aucun Nom", 1)]//Nom vide et coefficient inférieur à 0
        public void TestConstructor(string nom, int coef, string expectedNom, int expectedCoef)
        {
            Note note = new Note("Exam (sur 20.0)", 10.25);
            SAE sae = new SAE(nom, note, coef);
            Assert.Equal(sae.Nom, expectedNom);
            Assert.Equal(sae.Coef, expectedCoef);
        }
    }
}
