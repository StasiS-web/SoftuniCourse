namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;

    public class AquariumsTests
    {
        private Aquarium aquarium;

        [Test]
        public void ConstrustorWorkingCorrectlly()
        {
            string name = "ocean";
            int capacity = 1;
            this.aquarium = new Aquarium(name, capacity);
            Assert.AreEqual(aquarium.Name, name);
            Assert.AreEqual(aquarium.Capacity, capacity);
        }

        [Test]
        public void SetNameThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 1));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(string.Empty, 1));
        }

        [Test]
        public void SetCapacityThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("ocena", -1));
        }

        [Test]
        public void CountFish()
        {
            this.aquarium = new Aquarium("ocean", 1);
            aquarium.Add(new Fish("Nemo"));
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, aquarium.Count);
        }

        [Test]
        public void AddFishShoudThrowExceptiom()
        {
            this.aquarium = new Aquarium("test", 0);
            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("fishy")));
        }

        [Test]
        public void RemoveFishShoudThrowExceptiom()
        {
            this.aquarium = new Aquarium("ocean", 1);
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish(null));
        }

        [Test]
        public void RemoveFish()
        {
            this.aquarium = new Aquarium("ocean", 1);
            aquarium.Add(new Fish("alabala"));
            aquarium.RemoveFish("alabala");
            Assert.AreEqual(aquarium.Count, 0);
        }

        [Test]
        public void SellFishThrowException()
        {
            this.aquarium = new Aquarium("ocwean", 1);
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish(null));
        }

        [Test]
        public void SellFish()
        {
            this.aquarium = new Aquarium("ocean", 1);
            aquarium.Add(new Fish("alabala"));
            var fish = aquarium.SellFish("alabala");
            Assert.AreEqual(fish.Name, "alabala");
            Assert.AreEqual(fish.Available, false);
        }

        [Test]
        public void Report()
        {
            this.aquarium = new Aquarium("ocean", 1);
            aquarium.Add(new Fish("alabala"));
            string expectedMessage = $"Fish available at ocean: alabala";
            Assert.AreEqual(expectedMessage, aquarium.Report());
        }
    }
}
