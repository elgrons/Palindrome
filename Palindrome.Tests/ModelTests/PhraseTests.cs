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
    [TestMethod]
    public void IsPhrase_ReverseItChangeItRearrangeItArray_Reverse()
    {
      Phrase newPhrase = new Phrase();
      CollectionAssert.AreEqual(new char[]{'c','i','p','e'}, newPhrase.IsReversePhrase(new char[]{'e','p','i','c'}));
    }
    [TestMethod]
    public void IsPhrase_ReverseItChangeItRearrangeItString_String()
    {
      Phrase newPhrase = new Phrase();
      Assert.AreEqual(new string("cipe"), newPhrase.IsReversePhraseString(new char[]{'c','i','p','e'}));
    }
    [TestMethod]
    public void IsPhrase_BePalindrome_False()
    {
      Phrase newPhrase = new Phrase();
      Assert.AreEqual(false, newPhrase.BePalindrome("epic", "cipe"));
    }
    [TestMethod]

    public void IsPhrase_ComparePhraseWord_True()
    {
      Phrase newPhrase = new Phrase();
      Assert.AreEqual(true, newPhrase.BePalindrome("racecar", "racecar"));
    }
  }
}  //Never odd or even,  Yo Banana Boy! (Phrases)