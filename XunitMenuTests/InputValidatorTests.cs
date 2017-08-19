using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp4Menu.BLL;
using Xunit;

namespace XunitMenuTests
{
    public class InputValidatorTests
    {
        [Fact]
        public void TestIsValidStringSuccess()
        {
            var validName = "Adam";

            Assert.True(InputValidation.IsValidName(validName));
        }
    }
}
