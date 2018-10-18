using System;
using Xunit;
using ll_merge;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void shouldReturnSecondListIfFirstListIsNull()
        {
            LList two = new LList(new Node(6));
            two.Add(new Node(4));
            two.Add(new Node(2));

            LList result = Program.Merge(null, two);
            Assert.Equal(two, result);
        }

        [Fact]
        public void shouldReturnFirstListIfSecondListIsNull()
        {
            LList one = new LList(new Node(5));
            one.Add(new Node(3));
            one.Add(new Node(1));

            LList result = Program.Merge(one, null);
            Assert.Equal(one, result);
        }

        [Fact]
        public void shouldMergeCorrect()
        {
            LList one = new LList(new Node(5));

            LList two = new LList(new Node(6));

            LList expected = new LList(new Node(6));
            expected.Add(new Node(5));

            LList result = Program.Merge(one, two);
            Assert.Equal(expected.Head.Value, result.Head.Value);
            Assert.Equal(expected.Head.Next.Value, result.Head.Next.Value);
        }
    }
}
