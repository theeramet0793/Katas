using StringCalculatorNamespace;
using System;
using System.Collections.Generic;
using Xunit;

namespace StringCalculatorXunitTest
{
    public class StringCalculatorXunitTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, "1,2,3")]
        [InlineData(new int[] { 1, 2, 3 }, "1\n2,3")]
        [InlineData(new int[] { 1 }, "1,\n")]
        [InlineData(new int[] { 1, 2 }, "//;\n1;2")]
        [InlineData(new int[] { -1, 2 }, "-1,2")]
        [InlineData(new int[] { -1, 2, 1112 }, "-1,2dfhgt*/*rdsdrgr*/1112")]
        [InlineData(new int[] { -1, 2, -1112 }, "-1,2dfhgt*/*rdsdrgr*/---1112")]
        public void PickNumberOut_ArgumentIs_ExpectedOutput_StringInput(int[] expectedArray, string str)
        {
            var stringCalculator = new StringCalculator();
            var expectedList = new List<int>();
            expectedList.AddRange(expectedArray);

            var result = stringCalculator.PickNumberOut(str);

            Assert.Equal(expectedList, result);
        }


        [Theory] 
        [InlineData(-2, "///*-/-*\\0")]
        [InlineData(6, "1,2,3")]
        [InlineData(2, "1001,2")]
        [InlineData(-1, "-4,2,-5")]
        [InlineData(6, "//[|||]1|||2|||3")]
        [InlineData(6, "//[|][%]\n1|2%3")]
        [InlineData(-2, "//[|][%]1|2%3")]
        [InlineData(-2, "5dfgfg5")]
        [InlineData(3, "//;\n1;2")]
        [InlineData(-2, "//;1;2")]
        public void Add_ArgumentIs_ExpectedOutput_StringInput(int expectedResult, string str)
        {
            var stringCalculator = new StringCalculator();


            var result = stringCalculator.Add(str);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(true, "1,2,3")]
        [InlineData(true, "1\n2,3")]
        [InlineData(true, "//;\n1;2")]
        [InlineData(true, "//[;;]1;;2")]
        [InlineData(true, "//[;][//]\n1;2//3")]
        [InlineData(true, "///\n1/2")]
        [InlineData(false, "//;1,2")]
        [InlineData(false, "//;\n1/2")]
        [InlineData(false, "//;;\n1/2")]
        [InlineData(false, "//[;;]\n1;;2")]
        [InlineData(false, "//[;][//]1;2//3")]
        public void IsSyntaxTrue_ArgumentIs_ExpectedOutput_StringInput(bool expectedResult, string str)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.IsSyntaxTrue(str);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(true, new string[] {"1","2"} )]
        [InlineData(false, new string[] { "1", "a" })]
        public void IsAllInteger_ArgumentIs_ExpectedOutput_stringArrayInput(bool expectedResult, string[] strArray)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.IsAllInteger(strArray);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(true,"//;\n1;2",'\n')]
        [InlineData(true, "//[|||]1|||2", ']')]
        [InlineData(true, "//[%][;]\n1%2;3", '\n')]
        [InlineData(false, "//;1;2", '\n')]
        [InlineData(false, "//[|||]\n1|||2", ']')]
        [InlineData(false, "//[%][;]1%2;3", '\n')]
        public void IsChangedDelimiterCorrectFormat_ArgIs_expecResult_StringInput_CharInput(bool expectedResult, string str, char ch)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.IsDefinedDelimiterCorrectFormat(str, ch);
            Assert.Equal(expectedResult,result);
        }
        
        // Version 2 XUnit test
        [Theory]
        [InlineData(1,"0+0+0+1")]
        [InlineData(8.96, "1+5+8+9*8/75-6")]
        [InlineData(19, "9*8/4-5+3*2")]
        [InlineData(5, "5")]
        public void Calculate_argument_is_expectedResult_and_stringTest(double expectedResult,string strInput)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Calculate(strInput);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-0+0+0+1")]
        [InlineData("1+-8")]
        [InlineData("9*2+")]
        [InlineData("-5")]
        [InlineData("5x8x9x10")]
        public void Calculate_Must_return_throw_exception( string strInput)
        {
            var stringCalculator = new StringCalculator();
            
            Assert.Throws<InvalidSyntaxException>(() => stringCalculator.Calculate(strInput));
        }
    }
}