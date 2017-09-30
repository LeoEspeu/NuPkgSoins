using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soins;

namespace Tests
{
    /// <summary>
    /// Classe test de la classe prestation
    /// </summary>
    [TestClass]
    public class PrestationTests
    {
        /// <summary>
        /// Test de la méthode compareTo (si les 2 dates sont égales est égale)
        /// </summary>
        [TestMethod]
        public void CompareToTest()
        {
            Prestation unePrestation = new Prestation("Libelle P2", new DateTime(2015, 9, 8), Convert.ToDateTime("17:00:00"), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            Assert.AreEqual(0, unePrestation.CompareTo(new Prestation("Libelle P1", new DateTime(2015, 9, 8), Convert.ToDateTime("15:00:00"), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"))), "Les dates sont identiques");
        }

        /// <summary>
        /// Test de la méthode compareTo (si la date courante est supérieure
        /// </summary>
        [TestMethod]
        public void CompareToSupTest()
        {
            Prestation unePrestation = new Prestation("Libelle P2", new DateTime(2017, 10, 15), Convert.ToDateTime("17:00:00"), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            Assert.AreEqual(1, unePrestation.CompareTo(new Prestation("Libelle P1", new DateTime(2015, 9, 8), Convert.ToDateTime("15:00:00"), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"))), "La date courante est supérieures");
        }

        /// <summary>
        /// Test de la méthode compareTo (si la date courante est inférieure)
        /// </summary>
        [TestMethod]
        public void CompareToInfTest()
        {
            Prestation unePrestation = new Prestation("Libelle P2", new DateTime(2011, 8, 22), Convert.ToDateTime("17:00:00"), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            Assert.AreEqual(-1, unePrestation.CompareTo(new Prestation("Libelle P1", new DateTime(2015, 9, 8), Convert.ToDateTime("15:00:00"), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"))), "La date courante est inférieure");
        }
    }
}