﻿using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [TestCase(1, "1")]
        [TestCase(4, "4")]
        public void GetResult_WhenNumberNotDivisibleBy3or5_ShouldReturnNumber(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
 
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        public void GetResult_WhenNumberDivisibleBy3_ShouldReturnFizz(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        public void GetResult_WhenNumberDivisibleBy5_ShouldReturnBuzz(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(75, "FizzBuzz")]
        public void GetResult_WhenNumberDivisibleBy3and5_ShouldReturnFizzBuzz(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, "Whiz")]
        [TestCase(7, "Whiz")]
        [TestCase(11, "Whiz")]
        public void GetResult_WhenNumberPrimeNot3or5_ShouldReturnWhiz(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenNumber3_ShouldReturnFizzWhiz()
        {
            //---------------Set up test pack-------------------
            var input = 3;
            var expected = "FizzWhiz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetResult_WhenNumber5_ShouldReturnBuzzWhiz()
        {
            //---------------Set up test pack-------------------
            var input = 5;
            var expected = "BuzzWhiz";
            var fizzBuzzer = new FizzBuzzer();
            //---------------Execute Test ----------------------
            var result = fizzBuzzer.GetResult(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}
