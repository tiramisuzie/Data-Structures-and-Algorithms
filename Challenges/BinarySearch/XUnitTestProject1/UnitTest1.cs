using System;
using Xunit;

namespace BinarySearch
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnKeyifFound()
        {
            ArrayBinarySearch arrayBinarySearch = new ArrayBinarySearch();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = arrayBinarySearch.BinarySearch(array, 5);

            Assert.Equal(5, result);
        }

        [Fact]
        public void ShouldReturnNegative1IfNotFound()
        {
            ArrayBinarySearch arrayBinarySearch = new ArrayBinarySearch();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = arrayBinarySearch.BinarySearch(array, 11);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void ShouldReturnNegative1IfArrayIsEmpty()
        {
            ArrayBinarySearch arrayBinarySearch = new ArrayBinarySearch();
            int[] array = new int[10];

            int result = arrayBinarySearch.BinarySearch(array, 11);

            Assert.Equal(-1, result);
        }
    }
}
