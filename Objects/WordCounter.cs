using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    public string CountRepeats(string wordToFind, string sentenceToSearch)
    {
      wordToFind = wordToFind.ToLower();
      sentenceToSearch = sentenceToSearch.ToLower();
      char[] separators = { ' ', ',', '.', ':' };
      string[] words = sentenceToSearch.Split(separators);
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
