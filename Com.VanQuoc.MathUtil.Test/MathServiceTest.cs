

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
    }
}