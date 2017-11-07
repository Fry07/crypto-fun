using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void BTC_Check_Gain42()
        {           
            string currency = "BTC";
            int rand = 42;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);
             
            String expected = "Время закупаться, братан, BTC будет расти";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BTC_Check_Gain41()
        {
            string currency = "BTC";
            int rand = 41;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время закупаться, братан, BTC будет расти";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BTC_Check_Decrease40()
        {
            string currency = "BTC";
            int rand = 40;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время сливать, братан, BTC будет падать";
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ETH_Check_Gain62()
        {
            string currency = "ETH";
            int rand = 62;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время закупаться, братан, ETH будет расти";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ETH_Check_Gain61()
        {
            string currency = "ETH";
            int rand = 61;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время закупаться, братан, ETH будет расти";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ETH_Check_Decrease60()
        {
            string currency = "ETH";
            int rand = 60;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время сливать, братан, ETH будет падать";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ADC_Check_Gain62()
        {
            string currency = "Other";
            int rand = 62;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время закупаться, братан, ADC будет расти";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ADC_Check_Gain61()
        {
            string currency = "Other";
            int rand = 61;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время закупаться, братан, ADC будет расти";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ADC_Check_Decrease60()
        {
            string currency = "Other";
            int rand = 60;
            string other = "ADC";

            Generate generate = new Generate();
            String actual = generate.generate(currency, rand, other);

            String expected = "Время сливать, братан, ADC будет падать";
            Assert.AreEqual(expected, actual);
        }
    }
}
