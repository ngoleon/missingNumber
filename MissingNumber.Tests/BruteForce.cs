using MissingNumber.Solutions;

namespace MissingNumber.Tests
{
    public class BruteForceTests
    {
        [Fact]
        public void FindMissingNumberFromSmallArray()
        {
            var solution = new BruteForce();
            int[] input = { 3, 0, 1 };
            int result = solution.FindMissingNumber(input);

            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMissingNumberFromBigArray()
        {
            var solution = new BruteForce();
            int[] input = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int result = solution.FindMissingNumber(input);

            Assert.Equal(8, result);
        }
    }
}