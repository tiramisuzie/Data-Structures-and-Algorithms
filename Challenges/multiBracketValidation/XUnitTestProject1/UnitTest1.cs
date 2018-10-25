using multiBracketValidation;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData('{')]
        [InlineData('(')]
        [InlineData('[')]
        public void ShouldValidateOpenBracket(char l)
        {
            Assert.True(Program.ValidateOpenBracket(l));
        }

        [Theory]
        [InlineData('}')]
        [InlineData(')')]
        [InlineData(']')]
        public void ShouldValidateCloseBracket(char l)
        {
            Assert.True(Program.ValidateCloseBracket(l));
        }

        [Theory]
        [InlineData("{}")]
        [InlineData("{}()[]")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void ShouldBeValidTestCase(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("([)")]
        [InlineData("{(})")]
        [InlineData("{")]
        [InlineData(")")]
        [InlineData("[}")]
        public void ShouldBeInValidTestCase(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
    }
}
