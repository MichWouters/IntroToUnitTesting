using NUnit.Framework;
using IntroToUnitTesting;
using System;

namespace IntroToUnitTests.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenTwoIntegers_WhenMultiplying_ThenResultEqualToMultiplication()
        {
            // ARRANGE
            IMathExercises exercises = new MathExercises();
            int numA = 5;
            int numB = 7;

            // ACT
            int result = exercises.Add(numA, numB);

            // ASSERT
            Assert.AreEqual(12, result);
        }

        [TestCase(7,5,2)]
        [TestCase(10, 15, -5)]
        [TestCase(2, 2, 0)]
        public void GivenTwoIntegers_WhenSubtracting_ThenResultEqualToAdding(int numA, int numB, int expectedResult )
        {
            // ARRANGE
            IMathExercises exercises = new MathExercises();
            // See user input

            // ACT
            int result = exercises.Subtract(numA, numB);

            // ASSERT
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Given2Numbers_WhenMultiplicating_ThenResultIsCorrect()
        {
            // ARRANGE
            IMathExercises exercises = new MathExercises();
            int numA = 5;
            int numB = 7;

            // ACT
            int result = exercises.Multiply(numA, numB);

            // ASSERT
            Assert.AreEqual(35, result);
        }

        //[Test]
        //public void EverythingIsFine()
        //{
        //    Assert.True(false); 
        //}
    }
}