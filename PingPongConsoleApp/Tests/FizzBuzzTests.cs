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

        [Fact]
        public void GetResult_GivenANumberDivisibleByThree_WillReturnFizz()
        {
            string result = game.GetResult(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GetResult_GivenANumberDivisibleByFive_WillReturnBuzz()
        {
            string result = game.GetResult(5);

            Assert.Equal("Buzz", result);
        }
    }
}
