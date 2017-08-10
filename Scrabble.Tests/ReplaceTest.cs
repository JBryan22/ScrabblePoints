
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests 
{
 [TestClass]
 public class ScrabblesTest
 {
   [TestMethod] 
   public void GetValue_UserEntersSeattleGets7_7() {
   Scrabbles testScrabble = new Scrabbles("seattle");
   int expected = 7;
   int actual = testScrabble.GetValue();
   Assert.AreEqual(expected, actual);
   }

  [TestMethod]
   public void GetValue_UserEntersMUZJIKSGets29_29() {
   Scrabbles testScrabble = new Scrabbles("MUZJIKS");
   int expected = 29;
   int actual = testScrabble.GetValue();
   Assert.AreEqual(expected, actual);
   }
 }
}