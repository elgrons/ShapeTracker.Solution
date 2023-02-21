using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic; 
using System;

namespace ShapeTracker.Tests
{
  [TestClass]

    public class RectangleTests
  {
  [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(4);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }
  
  [TestMethod]
    public void GetSideLengthOne_ReturnsFirstSide_Int()
    {
      int length1 = 4;
      Rectangle newRectangle = new Rectangle(4);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }
  [TestMethod]
    public void SetSide1_SetValueOfSide1_Void()
    {
    Rectangle newRectangle = new Rectangle(4);
    int firstSide1 = 42;
    newRectangle.Side1 = firstSide1;
    Assert.AreEqual(newRectangle.Side1, firstSide1);
    }
  
    [TestMethod]
    public void GetSideLengthTwo_ReturnsSecondSide_Int()
    {
    Rectangle newRectangle = new Rectangle(4);
    int secondSide = 5;
    newRectangle.Side2 = secondSide;
    Assert.AreEqual(newRectangle.Side2, secondSide);
    }
  
  }
}