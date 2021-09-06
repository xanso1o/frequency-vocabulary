using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.IO;
using Task_01;

namespace Task_01_Tests
{
    [TestClass]
    public class Task_01_Tests
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void IsPathNotEmpty()
        {
            // arrange
            string path = @"D:\Users\Aleks\Downloads\DZ";

            // act
            var sut = new Text(path);

            // assert
            Assert.IsNotNull(sut);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void IsFileRead()
        {
            // arrange
            string expected = @"D:\Users\Aleks\Downloads\DZ";
            var sut = new Text(expected);

            // act
            var actual = sut.ReadFile();

            // assert
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// No error detected, test failed
        /// </summary>
        [TestMethod]
        public void IsPathTheSame()
        {
            // arrange
            string path = @"D:\Users\Aleks\Downloads\DZ";
            string[] expected = { @"D:\Users\Aleks\Downloads\DZ\21_08_21.txt" };

            // act
            var actual = Directory.GetFiles(path);

            // assert
            Assert.AreEqual<string[]>(expected, actual);

        }

        [TestMethod]
        public void Test_01()
        {
            // arrange

            // act

            // assert
            
        }
    }
}
