using System;
using Models;
using Xunit;

namespace Tests
{
    public class FizzBuzzTests
    {
        public FizzBuzz game { get; set; } = new FizzBuzz();
    

        [Fact]        
        public void FizzBuzz_UsingDefaultConstructor_ReturnsFizzBuzzObject()
        {
            Assert.NotNull(game);
            Assert.IsType<FizzBuzz>(game);
        }

        [Fact]
        public void GetResult_GivenANumber_WillReturnAStringValue()
        {
            string result = game.GetResult(1);

            Assert.NotNull(result);
            Assert.IsType<string>(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void GetResult_GivenANumberDivisibleByThree_WillReturnFizz(int numberDivisibleByThree)
        {
            string result = game.GetResult(numberDivisibleByThree);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GetResult_GivenANumberDivisibleByFive_WillReturnBuzz()
        {
            string result = game.GetResult(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GetResult_GivenANumberDivisibleByThreeAndFive_WillReturnFizzBuzz()
        {
            string result = game.GetResult(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void GetResult_GivenANumberNotDivisibleByThreeOrFive_WillReturnTheNumber()
        {
            string result = game.GetResult(1);

            Assert.Equal("1", result);
        }
    }
}
