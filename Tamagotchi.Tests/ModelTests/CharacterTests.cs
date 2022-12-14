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
  }
}
