﻿using ConsoleApp4Menu.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuTests
{
    [TestClass]
    public class InputValidatorTests
    {

        [TestMethod]
        public void TestIsValidStringSuccess()
        {
            var validName = "Adam";

            Assert.IsTrue(InputValidation.IsValidName(validName));
        }
    }
}