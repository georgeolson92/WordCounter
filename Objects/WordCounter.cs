using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    // public string wordToFind;
    // public string sentenceToSearch;

    public string CountRepeats(string wordToFind, string SentenceToSearch)
    {
      char[] separators = { ' ', ',', '.', ':' };
      string[] words = SentenceToSearch.Split(separators);
      List<string> matchedWords = new List<string>();

      foreach (string word in words)
      {
        if (word == wordToFind)
        {
          matchedWords.Add(word);
          Console.WriteLine(word);
        }
      }

      int amount = matchedWords.Count;
      string result = amount.ToString();
      return result;
    }
  }
}
