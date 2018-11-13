using Hashtables;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("test1", "test2")]
        [InlineData("Hello", 88)]
        [InlineData("you", true)]
        public void TestInsertion(string key, object value)
        {
            Hashtable ht = new Hashtable(10);
            ht.Add(key, value);
            Assert.Equal(value, ht.Find(key));
        }
        
        [Fact]
        public void TestUpdate()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("hello", "world");
            ht.Add("hello", "you");
            Assert.Equal("you", ht.Find("hello"));
        }
        
        [Theory]
        [InlineData("test1", "test1")]
        [InlineData("Hello", 88)]
        [InlineData("you", true)]
        public void TestContains(string key, object value)
        {
            Hashtable ht = new Hashtable(10);
            ht.Add(key, value);
            Assert.True(ht.Contains(key));
        }
        
        [Fact]
        public void TestContainsKeyNotFound()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("hello", "world");
            Assert.False(ht.Contains("hi"));
        }
        
        [Fact]
        public void TestCollisions1()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("2", "world");
            ht.Add("12", "bar");
            Assert.True(ht.Contains("2") && ht.Contains("12"));
        }
        
        [Fact]
        public void TestCollisions2()
        {
            Hashtable ht = new Hashtable(5);
            ht.Add("2", "world");
            ht.Add("12", "bar");
            Assert.True(ht.Find("2") != ht.Find("12"));
        }
    }
}
