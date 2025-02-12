using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void IsPrime_InputIs2_ReturnTrue()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(2);

            Assert.True(result, "2 is a prime");
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnTrue()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(3);

            Assert.True(result, "3 is a prime");
        }

        [Fact]
        public void IsPrime_InputIs4_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(4);

            Assert.False(result, "4 should not be a prime");
        }

        [Fact]
        public void IsPrime_InputIs5_ReturnTrue()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(5);

            Assert.True(result, "5 is a prime");
        }
    }
}