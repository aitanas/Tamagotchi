using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class CharacterTests
  {
    [TestMethod]
    public void CharacterConstructor_CreatesCharacter_Obj()
    {
      Character luni = new Character("Luni");
      Assert.AreEqual(typeof(Character), luni.GetType());
      Assert.AreEqual(100, luni.Food);
    }

    [TestMethod]
    public void PassTime_DecreaseStats_Obj()
    {
      Character luni = new Character("Luni");
      luni.PassTime();
      Assert.AreEqual(typeof(int), luni.Food.GetType());
      Assert.AreEqual(typeof(int), luni.Attention.GetType());
      Assert.AreEqual(typeof(int), luni.Rest.GetType());
    }

    [TestMethod]
    public void Feed_ReplenishFood_Int()
    {
      Character luni = new Character("Luni");
      luni.PassTime();
      Assert.AreEqual(typeof(int), luni.Food.GetType());
      luni.Feed();
      Assert.AreEqual(typeof(int), luni.Food.GetType());
    }

    [TestMethod]
    public void Rest_ReplenishRestInt()
    {
      Character luni = new Character("Luni");
      luni.PassTime();
      Assert.AreEqual(typeof(int), luni.Rest.GetType());
      luni.Nap();
      Assert.AreEqual(typeof(int), luni.Rest.GetType());
    }

    [TestMethod]
    public void Attention_ReplenishAttention_Int()
    {
      Character luni = new Character("Luni");
      luni.PassTime();
      Assert.AreEqual(typeof(int), luni.Attention.GetType());
      luni.Play();
      Assert.AreEqual(typeof(int), luni.Attention.GetType());
    }

    // [TestMethod]
    // public void CheckIfAlive_FindSignsOfLife_Int()
    // {
    //   Character luni = new Character("Luni");
    //   luni.CheckIfAlive();
    // }
  }
}
