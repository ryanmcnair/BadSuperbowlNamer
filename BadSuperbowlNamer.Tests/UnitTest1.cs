using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    //name the class for the things we are testing
    public class TranslateNumbersToRomanNumerals
    {
        [Fact]  // <--- explains that this method is a test
        public void when_the_number_1_is_passed_I_should_be_returned()  //<--- must be public, return nothing/void and take no parameters
        {
            //ARRANGE ---> context creation
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();

            //ACT  ---> the action being taken in a given context
            var result = translator.NumberToNumeral(numberToConvert);

            //ASSERT  ---> my expectations as a result of the action
            //Assert.False(true);
            //throw new Exception("This will bomb out");
            Assert.Equal("I", result);
        }

        [Fact]
        public void when_the_number_5_is_passed_V_should_be_returned()
        {
            //ARRANGE
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "V";

            //ACT
            var result = translator.NumberToNumeral(numberToConvert);

            //ASSERT
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void when_the_number_9_is_passed_IX_should_be_returned()
        {
            //ARRANGE
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();
            var expectedResult = "IX";

            //ACT
            var result = translator.NumberToNumeral(numberToConvert);

            //ASSERT
            Assert.Equal(expectedResult, result);

        }
    }
}
