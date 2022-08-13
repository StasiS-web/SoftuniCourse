using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault vault;
        private Item item;
        
        [SetUp]
        public void Setup()
        {
            this.vault = new BankVault();
            this.item = new Item("me", "16");
        }

        [Test]
        public void TestConstructor()
        {
            int expectedaCell = 12;

            Assert.AreEqual(expectedaCell, vault.VaultCells.Count);
        }

        [Test]
        public void AddItem_ShouldReturnCorrectString()
        {
            var expectedItem = $"Item:{item.ItemId} saved successfully!";
            var actualItem = vault.AddItem("A1", item);

            Assert.AreEqual(expectedItem, actualItem);
        }

        [Test]
        public void AddItem_ShouldThrowsException_IfCellDoesNotExist()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("not exist", item);
            }, "Cell doesn't exists!");
        }

        [Test]
        public void AddItem_ShouldThrowsException_WhenCellIsTaken()
        {
            vault.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A1", new Item("Ann", "111"));
            }, "Cell is already taken!");
        }

        [Test]
        public void AddItem_ShouldThrowsException_CellWithExistingItem()
        {
            vault.AddItem("A1", item);

            Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A2", item);
            },"Item is already in cell!");
        }

        [Test]
        public void RemoveItem_ShouldReturnCorrectString()
        {
            vault.AddItem("A2", item);
            var expectedItemToRemove = $"Remove item:{item.ItemId} successfully!";
            var actualItemToRemove = vault.RemoveItem("A2", item);

            Assert.AreEqual(expectedItemToRemove, actualItemToRemove);
        }

        [Test]
        public void RemoveItem_ShouldThrowsException_IfCellDoesNotExist()
        {
            vault.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A3", item);
            }, "Cell doesn't exists!");
        }

        [Test]
        public void RemoveItem_ShouldThrowsException_WithDifferentItem()
        {
            Item itemTwo = new Item("Ana", "123");
            vault.AddItem("A2", item);
            Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A1", itemTwo);
            }, $"Item in that cell doesn't exists!");
        }

        [Test]
        public void RemoveItem_SetCellValueToNull()
        {
            vault.AddItem("A2", item);
            vault.RemoveItem("A2", item);

            Assert.IsNull(vault.VaultCells["A2"]);
        }
    }
}