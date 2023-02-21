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
      newPhrase.IsReversePhrase(word);
      newPhrase.IsReversePhraseString(word);
      bool result = newPhrase.BePalindrome(word, result);
      Console.WriteLine("Is " + word + " a palindrome? " + result);
    }
  }
}