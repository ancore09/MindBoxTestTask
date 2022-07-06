using System;
using FigureLib;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea());
        }
        
        [Test]
        public void IsRightTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());
        }
        
        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(1);
            Assert.AreEqual(Math.PI, circle.GetArea());
        }
    }
}