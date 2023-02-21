using System.Collections.Generic;
using System;

namespace Palindrome.Models
{
  public class Phrase
  {
    public char[] IsPhrase(string word)
    {
      char[] wordArray = word.ToCharArray();
      return wordArray;
    }
    public char[] IsReversePhrase(char[] wordArray)
    {
      Array.Reverse(wordArray);
      return wordArray;
    }
    public string IsReversePhraseString(char[] wordArray)
    {
      string endIt = new string(wordArray);
      return endIt;
    }
        public bool BePalindrome(string endIt, string text)
    {
      if ( endIt == text)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}