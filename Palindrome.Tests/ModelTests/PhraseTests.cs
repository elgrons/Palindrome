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
    // [TestMethod]
    // {

    // }
  }
}