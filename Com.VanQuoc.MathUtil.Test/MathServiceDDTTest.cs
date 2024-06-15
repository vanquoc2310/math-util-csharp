using Com.VanQuoc.MathUtil.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.VanQuoc.MathUtil.Test
{
    public class MathServiceDDTTest
    {
        private readonly MathService _mathService;

        public MathServiceDDTTest()
        {
            _mathService = new MathService();
        }

        public static TheoryData<int, int, int> InitData()
        {
            return new TheoryData<int, int, int>
        {
            { 54, 24, 6 },  
            { 30, 15, 15 }, 
            { 48, 18, 6 },  
        };
        }

        // Phương thức kiểm thử tham số hóa
        [Theory]
        [MemberData(nameof(InitData))]
        public void TestGCD_ValidInput_ReturnsExpectedResult(int a, int b, int expectedGCD)
        {
            var mathService = new MathService();

            Assert.Equal(expectedGCD, mathService.GetGCD(a, b));
        }




        [Theory]
        [InlineData(54, 24, 6)]
        [InlineData(48, 18, 6)]
        [InlineData(101, 10, 1)]
        [InlineData(0, 5, 5)]
        [InlineData(5, 0, 5)]
        [InlineData(27, 36, 9)]
        [InlineData(56, 98, 14)]
        public void GetGCD_ValidInput_ReturnsExpectedResult(int a, int b, int expected)
        {
            int result = _mathService.GetGCD(a, b);

            Assert.Equal(expected, result);
        }
    }
}
