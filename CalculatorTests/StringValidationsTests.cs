using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Services;

namespace CalculatorTests
{
    public class StringValidationsTests
    {
        private StringValidations _validations;

        public StringValidationsTests()
        {
            _validations = new StringValidations();
        }


        [Fact]
        public void MustCount3CharsInStringAndReturn3()
        {
            // Arrange
            string txt = "Gui";

            // Act
            var result = _validations.CountChar(txt);

            // Assert

            Assert.Equal(3, result);
        }


    }
}
