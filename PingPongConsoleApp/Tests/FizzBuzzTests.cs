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
            string result = game.GetResult();

            Assert.NotNull(result);
            Assert.IsType<string>(result);
        }
    }
}
