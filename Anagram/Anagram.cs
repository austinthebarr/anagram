using System.Collections.Generic;
using System;

namespace Anagram
{
  public class Item
  {
    private string _userInput;
    private static List<Item> _instances = new List<Item> {};

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public Item (string userInput)
    {
      _userInput = userInput;
    }
    public void SetUserInput(string newUserInput)
    {
      _userInput = newUserInput;
    }
    public string GetUserInput()
    {
      return _userInput;
    }
    public char[] GetUserCharArray()
    {
      char[] temp = _userInput.ToLower().ToCharArray();
      Array.Sort(temp);
      return temp;
    }
    public string ToJoinedArray()
    {
      return String.Join("", this.GetUserCharArray());
    }
  }

}
