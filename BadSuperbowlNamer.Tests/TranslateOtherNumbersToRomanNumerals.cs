using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class TranslateOtherNumbersToRomanNumerals
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(14, "XIV")]
        [InlineData(73, "LXXIII")]
        [InlineData(49, "XLIX")]
        [InlineData(7, "VII")]
        [InlineData(143, "CXLIII")]
        public void the_number_is_translated_correctly_to_roman_numerals(int numberToConvert, string expectedNumeral)
        {
            //ARRANGE
            var translator = new RomanNumeralTranslator();
            //ACT
            var actualResult = translator.NumberToNumeral(numberToConvert);

            //ASSERT
            Assert.Equal(expectedNumeral, actualResult);
        }
    }
}
