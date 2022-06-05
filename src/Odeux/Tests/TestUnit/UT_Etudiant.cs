using Modele;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestUnit
{
    public class UT_Etudiant
    {
        //Test Constructeur Etudiant
        [Theory]
        [InlineData("Kartal", "Emre", 2003, "0000", "Kartal", "Emre", 2003, "0000", false)]
        [InlineData("", "Emre", 2003, "0000", "Kartal", "Emre", 2003, "0000", true)]//Etudiant sans nom
        [InlineData("Kartal", "", 2003, "0000", "Kartal", "Emre", 2003, "0000", true)]//Etudiant sans prénom
        [InlineData("Kartal", "Emre", 2024, "0000", "Kartal", "Emre", 2003, "0000", true)]//Année de naissance qui n'existe toujours pas
        [InlineData("Kartal", "Emre", 2003, "", "Kartal", "Emre", 2003, "0000", true)]//Etudiant sans mot de passe
        public void TestConstructor(string nom, string prénom, int AnnéeDeNais, string password, string expectedNom, string expectedPrénom, int expectedAnnéeDeNais, string expectedPassword, bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new Etudiant(nom, prénom, new DateTime(AnnéeDeNais,1,1), password, new Semestre(1, new List<UE>()), new Semestre(2, new List<UE>())));
                return;
            }
            Etudiant etu = new Etudiant(nom, prénom, new DateTime(AnnéeDeNais, 1, 1), password, new Semestre(1, new List<UE>()), new Semestre(2, new List<UE>()));
            Assert.Equal(etu.Nom, expectedNom);
            Assert.Equal(etu.Prénom, expectedPrénom);
            Assert.Equal(etu.Naissance.Year, expectedAnnéeDeNais);
            Assert.Equal(etu.Password, expectedPassword);
        }

        //Test fonction GetNote
        [Theory]
        [InlineData(1,"UE 1","R1.01","Algorithme","DS",11)]//Note existante
        [InlineData(1, "UE 1", "R1.01", "Algorithme", "Tp noté", 13)]//Note existante deuxième test
        [InlineData(1, "UE 2", "R1.01", "Structure de données", "DS", 15)]//Note existante troisième test
        [InlineData(1,"UE 1", "R1.01", "Bases de données", "DS", -1)]//Ressource non existante
        [InlineData(1,"", "R1.01", "Algorithme", "DS", -1)]//UE non Existante
        [InlineData(5,"UE 1", "R1.01", "Algorithme", "DS", -1)]//Semestre non Existante
        [InlineData(1,"UE 1", "R1.01", "", "DS", -1)]//Matière non Existante
        public void TestGetNote(int Sem, string UE, string Ressource, string Mat, string Note, int expectedNote)
        {
            // Creation des Liste de note
            List<Note> notes = new List<Note>();
            Note n1 = new Note("Tp noté", 10);
            notes.Add(n1);

            Note n2 = new Note("DS", 15);
            notes.Add(n2);


            List<Note> notes2 = new List<Note>();
            Note n3 = new Note("Tp noté", 13);
            notes2.Add(n3);

            Note n4 = new Note("DS", 11);
            notes2.Add(n4);

            Note n5 = new Note("Situation 1 (sur 20.0)", 16);

            Note n6 = new Note("Situation 2 (sur 20.0)", 11);

            //Creation des Matières

            List<Matiere> matieres = new List<Matiere>();
            List<Matiere> matieres2 = new List<Matiere>();

            Matiere mat1 = new Matiere("Structure de données", notes);
            Matiere mat2 = new Matiere("Algorithme", notes2);

            matieres.Add(mat1);
            matieres.Add(mat2);
            matieres2.Add(mat1);

            //Creation des Ressource

            Ressource res = new Ressource("R1.01", "Initiation au développement", 42, matieres);
            Ressource res2 = new Ressource("R1.02", 12, matieres2);

            //Creation d'une UE

            List<UE> lesUE = new List<UE>();
            List<UE> lesUE2 = new List<UE>();

            UE ue = new UE("UE 1", "Développer des applications informatiques simples");
            UE ue2 = new UE("UE 2", "Appréhender et construire des algorithmes");

            ue.AddRessource(res);
            ue.AddRessource(res2);
            ue2.AddRessource(res);

            lesUE.Add(ue);
            lesUE2.Add(ue2);

            //Creation SAE

            SAE sae = new SAE("S1.01 : Implémentation d’un besoin client", n5, 40);
            ue.AddSAE(sae);

            SAE sae2 = new SAE("S1.02 : Comparaison d’approches algorithmiques", n6, 40);
            ue2.AddSAE(sae2);


            //Creation de deux Semestre

            Semestre s1 = new Semestre(1, lesUE);
            Semestre s2 = new Semestre(2, lesUE2);

            //Creation d'un Etudiant

            DateTime nais = new DateTime(2002, 10, 22);
            Etudiant etu = new Etudiant("Emre ", "KARTAL", nais, "Cinq combattants distinguent des esquives et les rêves.", s1, s2);

            Assert.Equal(etu.getNote(Sem, UE, Ressource, Mat, Note), expectedNote);
        }

    }

}
