using TagHelpers.Services;
using Xunit;

namespace TestingWithxUnit
{
    public class GreeterServiceTests
    {
        [Fact]
        public void GreetTest()
        {
            var greeter = new GreeterService();

            Assert.Equal(greeter.Greet(), "no 1");
        }

        [Fact]
        public void RiggedGreetTest()
        {
            var greeter = new GreeterService();

            Assert.Equal(greeter.RiggedGreet(42), "no 42");
        }

        [Fact]
        public void GreetNameTest()
        {
            var greeter = new GreeterService();

            Assert.Equal(greeter.GreetName("SweNug"), "Hello SweNug from the Greeter tag!");

        }


    }
}
