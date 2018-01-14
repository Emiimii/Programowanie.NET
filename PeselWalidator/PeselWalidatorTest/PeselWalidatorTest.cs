using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeselWal;
using System.Linq;

namespace PeselWalidatorTest
{
    [TestClass]
    public class PeselWalidatorTest
    {
        PeselWalidator walidator;

        [TestInitialize]
        public void PrzygotujWalidator()
        {
            walidator = new PeselWalidator("81020366661");            
        }
        
        [TestMethod]
        public void TestCzyPeselJestPoprawny_Zawiera11Cyfr()
        {            
            bool wynik = walidator.SprawdzPesel();
            Assert.IsTrue(wynik);
        }

        [TestMethod]
        public void TestCzyDataMaOdpowieniaIloscZnakow()
        {
            Assert.AreEqual(6, walidator.DataUrodzenia.Length);
        }

        [TestMethod]
        public void TestCzyDzienJestPoprawny()
        {
            var dzien = int.Parse(walidator.DataUrodzenia.Substring(4, 2));
            bool wynik = dzien > 0 && dzien <= 12;
            Assert.IsTrue(wynik);
        }

        [TestMethod]
        public void TestCzyMiesiacJestPoprawny()
        {
            var miesiac = int.Parse(walidator.DataUrodzenia.Substring(2, 2));
            bool wynik = miesiac > 0 && miesiac <= 32;
            Assert.IsTrue(wynik);
        }

        [TestMethod]
        public void TestCzyRokJestPoprawny()
        {
            var rok = int.Parse(walidator.DataUrodzenia.Substring(0, 2));
            bool wynik = rok >= 0 && rok < 100;
            Assert.IsTrue(wynik);
        }

        [TestMethod]
        public void TestCzyRokJestPoprawny_Rok()
        {
            var rok = int.Parse(walidator.DataUrodzenia.Substring(0, 2));
            bool wynik = rok >= 0 && rok < 100;
            Assert.IsTrue(wynik);
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieRozpoznajeKobiete_Przy0()
        {
            walidator.WczytajPesel("81020366601");
            Assert.AreEqual(PlecEnum.Kobieta.ToString(), walidator.Plec);
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieRozpoznajeKobiete_Przy6()
        {
            walidator.WczytajPesel("81020366661");
            Assert.AreEqual(PlecEnum.Kobieta.ToString(), walidator.Plec);
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieRozpoznajeMezczyzne_Przy1()
        {
            walidator.WczytajPesel("81020366611");
            Assert.AreEqual(PlecEnum.Mezczyzna.ToString(), walidator.Plec);
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieRozpoznajeMezczyzne_Przy9()
        {
            walidator.WczytajPesel("81020366691");
            Assert.AreEqual(PlecEnum.Mezczyzna.ToString(), walidator.Plec);
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieLiczySumeKontrolna_Dla1()
        {
            walidator.WczytajPesel("72070803621");
            Assert.AreEqual(1, walidator.SumaKontrolna());
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieLiczySumeKontrolna_Dla0()
        {
            walidator.WczytajPesel("82070803620");
            Assert.AreEqual(0, walidator.SumaKontrolna());
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieLiczySumeKontrolna_Dla5()
        {
            walidator.WczytajPesel("32070803625");
            Assert.AreEqual(5, walidator.SumaKontrolna());
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieLiczySumeKontrolna_Dla8()
        {
            walidator.WczytajPesel("02070803628");
            Assert.AreEqual(8, walidator.SumaKontrolna());
        }

        [TestMethod]
        public void TestCzyWalidatorPoprawnieLiczySumeKontrolna_Dla9()
        {
            walidator.WczytajPesel("92070803629");
            Assert.AreEqual(9, walidator.SumaKontrolna());
        }
    }
}
