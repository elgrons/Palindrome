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
    public void IsPhrase_StringToChar_Char()

    {
      Phrase testPhrase = new Phrase();
      CollectionAssert.AreEqual(new char[]{'e','p','i','c'}, testPhrase.IsPhrase("epic"));
    }
    // [TestMethod]
    // public void Phrase_CreatesInstanceOfPhrase_String()
    // {
    //   // Arrange
    //   string Word = "racecar";
    //   Phrase newPhrase = new Phrase(Word);
    //   // Act
    //   string result = newPhrase.Word;
    //   // Assert
    //   Assert.AreEqual(Word, result);
    // }
    // [TestMethod]
    // {

    // }
  }
}