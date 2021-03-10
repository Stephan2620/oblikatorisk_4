using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Beer.Tests
{
    [TestClass]
    public class BeerTests
    {
        private readonly Beer ol = new Beer(1, "øller", 25, 1);

        [TestMethod]
        public void id()
        {
            ol.Id = 1;

            Assert.AreEqual(1, ol.Id);
        }

        [TestMethod]
        public void Name()
        {
            ol.Name = "øller";

            Assert.AreEqual("øller", ol.Name);

            Assert.ThrowsException<ArgumentException>(() => ol.Name = "abc");
        }

        [TestMethod]
        public void Price()
        {
            ol.Price = 25;

            Assert.AreEqual(25, ol.Price);
            Assert.ThrowsException<ArgumentException>(() => ol.Price = 0);
        }

        [TestMethod]
        public void Abv()
        {
            ol.Abv = 0;
            Assert.AreEqual(0, ol.Abv);
            ol.Abv = 100;
            Assert.AreEqual(100, ol.Abv);
            ol.Abv = 50;
            Assert.AreEqual(50, ol.Abv);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ol.Abv = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ol.Abv = 101);
        }
    }
}