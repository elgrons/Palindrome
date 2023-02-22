using System;
using Palindrome.Models;

namespace Palindrome
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Palindrome app!");
      Console.WriteLine("We'll decide if you have submitted a palindrome based off of your input.");
      Console.WriteLine("Please enter a word:");
      string word = Console.ReadLine();
      Phrase newPhrase = new Phrase();
      newPhrase.IsPhrase(word);
      char[] wordArray = word.ToCharArray();
      newPhrase.IsReversePhrase(wordArray);
      string text = newPhrase.IsReversePhraseString(wordArray);
      bool result = newPhrase.BePalindrome(word, text);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Is " + word + " a palindrome? " + result);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    }
  }
}