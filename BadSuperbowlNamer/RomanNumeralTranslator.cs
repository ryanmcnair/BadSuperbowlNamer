using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class RomanNumeralTranslator
    {
        public string NumberToNumeral(int numberToConvert)
        {
            //throw new NotImplementedException(); //For when you want to just have a non-functioning method


            //var result = numberToConvert switch //Switch Expression
            //{
            //    1 => "I",
            //    5 => "V",
            //    9 => "IX"
            //};

            var result = "";

            while (numberToConvert > 0)
            {
                if (numberToConvert >= 100)
                {
                    result += "C";
                    numberToConvert -= 100;
                }
                else if (numberToConvert >= 50)
                {
                    result += "L";
                    numberToConvert -= 50;
                }
                else if (numberToConvert >= 40)
                {
                    result += "XL";
                    numberToConvert -= 40;
                }
                else if (numberToConvert >= 10)
                {
                    result += "X";
                    numberToConvert -= 10;

                }
                else if (numberToConvert == 9)
                {
                    result += "IX";
                    numberToConvert = 0;
                }
                else if (numberToConvert >= 5)
                {
                    result += "V";
                    numberToConvert -= 5;
                }
                else if (numberToConvert == 4)
                {
                    result += "IV";
                    numberToConvert = 0;
                }
                else if (numberToConvert <= 3)
                {
                    result += new string('I', numberToConvert);
                    numberToConvert = 0;
                }
                
            }

            return result;


            //if (numberToConvert == 1)
            //{
            //    result += "I";
            //}

            //else if (numberToConvert == 5)
            //{
            //    result += "V";
            //}

            //else if (numberToConvert == 9)
            //{
            //    result += "IX";
            //}

            //return result;
            
        }
    }
}
