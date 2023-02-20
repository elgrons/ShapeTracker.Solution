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
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }
  }
}