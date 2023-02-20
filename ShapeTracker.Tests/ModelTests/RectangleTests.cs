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
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2, 3, 8);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }
  }
}