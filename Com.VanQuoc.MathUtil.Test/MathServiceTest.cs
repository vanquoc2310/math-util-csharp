

using Com.VanQuoc.MathUtil.Core;

namespace Com.VanQuoc.MathUtil.Test
{
    public class MathServiceTest
    {
        private readonly MathService _mathService;

        public MathServiceTest()
        {
            _mathService = new MathService();
        }

        [Fact]
        public void GetGCD_NegativeInput_ReturnsPositiveGCD()
        {
            int result = _mathService.GetGCD(-54, 24);
            Assert.Equal(6, result);
        }

        [Fact]
        public void GetGCD_ValidNumbers_ReturnsCorrectGCD()
        {
            int result = _mathService.GetGCD(24, 36);
            Assert.Equal(12, result);
        }

        [Fact]
        public void GetGCD_BothNumbersAreZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _mathService.GetGCD(0, 0));
            //var ex = Assert.Throws<ArgumentException>(() => _mathService.GetGCD(0, 0));
            //Assert.Equal("Both numbers cannot be zero.", ex.Message);
        }
    }
}