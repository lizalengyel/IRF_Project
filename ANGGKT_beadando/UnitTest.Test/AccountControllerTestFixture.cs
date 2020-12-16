﻿using ANGGKT_beadando;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace UnitTest.Test
{
    public class AccountControllerTestFixture
    {
        [
                   Test,
                   TestCase("abcd1234", false),
                   TestCase("irf@uni-corvinus", false),
                   TestCase("irf.uni-corvinus.hu", false),
                   TestCase("irf@uni-corvinus.hu", true)
               ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange

           UserControl1 uc = new UserControl1();
            // Act
            var actualresult = uc.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualresult);
        }

        [Test,
            TestCase("TomAndJerry", false),
            TestCase("22TOMANDJERRY", false),
            TestCase("22tomandjerry", false),
            TestCase("Jerry2", false),
            TestCase("22TomandJerry", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            Regex regex = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,}$");

            // Act
            var actualResult = regex.IsMatch(password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }


    }
}
