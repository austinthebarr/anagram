using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class ItemTest
  {
    [TestMethod]
    public void GetDescription_UserInput()
    {
      //Arrange
      string userInput = "egg";
      Item newItem = new Item(userInput);

      //Act
      string result = newItem.GetUserInput();

      //Assert
      Assert.AreEqual(userInput, result);
    }
    [TestMethod]
    public void CharInput_Checker()
    {

      string userInput = "egg";
      Item newItem = new Item(userInput);

      //Act
      char[] result = newItem.GetUserCharArray();
      char[] expected = {'e','g','g'};

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CharInput_UpperCase_Checker()
    {

      string userInput = "Egg";
      Item newItem = new Item(userInput);

      //Act
      char[] result = newItem.GetUserCharArray();
      char[] expected = {'e','g','g'};

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CharInput_OutOfOrder_Checker()
    {

      string userInput = "Beard";
      Item newItem = new Item(userInput);

      //Act
      char[] result = newItem.GetUserCharArray();
      char[] expected = {'a','b','d','e','r'};

      //Assert
      CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CharInput_JoinedIntoString()
    {
      //Arrange
      string userInput = "Beard";
      Item newItem = new Item(userInput);

      //Act
      string result = newItem.ToJoinedArray();
      string expected = "abder";

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
