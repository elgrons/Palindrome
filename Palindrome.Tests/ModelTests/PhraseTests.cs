using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System.Collections.Generic; 
using System;

namespace Palindrome.Tests
{
  [TestClass]
  public class PhraseTests
  {
    [TestMethod]
    public void PhraseConstructor_CreatesInstanceOfPhrase_Phrase()

    {
      Phrase newPhrase = new Phrase();
      Assert.AreEqual(typeof(Phrase), newPhrase.GetType());
    }
    [TestMethod]
    public void PhraseConstructor_CreatesInstanceOfPhrase_String()

    {
      // Arrange
      string Word = "racecar";
      Phrase newPhrase = new Phrase("racecar");
      // Act
      string result = newPhrase.Word;
      // Assert
      Assert.AreEqual(Word, result);
    }
  }
}