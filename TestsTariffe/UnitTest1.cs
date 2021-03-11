using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;
namespace TestsTariffe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodB()
        {
            int t = 23;
            string valore = Gestione.ContoB(t);
            string valoreaspettato = $"la tariffa B costa {23}";
            Assert.AreEqual(valore, valoreaspettato);

        }
        [TestMethod]
        public void TestMethodA()
        {
            int giorni = 2;
            int valore = Gestione.ContoA(giorni);
            int valoreaspettato = 30;
            Assert.AreEqual(valore, valoreaspettato);

        }
        [TestMethod]
        public void TestMethodC()
        {
            int t = 1;
            string valore = Gestione.ContoC(t);
            string valoreaspettato = $"se è solo per un'ora spendi {0}";
            Assert.AreEqual(valore, valoreaspettato);

        }
        [TestMethod]
        public void TestMethodC2()
        {
            int t = 5;
            string valore = Gestione.ContoC(t);
            string valoreaspettato = $"paghi {4.80}";
            Assert.AreEqual(valore, valoreaspettato);

        }

    }
}
