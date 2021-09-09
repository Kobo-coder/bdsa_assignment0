using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program.IsLeapYear(1600));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Program.IsLeapYear(1604));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Program.IsLeapYear(1700));
        }

        [Fact]
        public void Test4()
        {
            Assert.False(Program.IsLeapYear(1802));
        }

        [Fact]
        public void Test5() {
            Assert.Throws<ArgumentException>(() => Program.IsLeapYear(1581));
        }  

        [Fact]
        public void Test6() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.Main(new string[0]);
            var outputarray = writer.ToString().Split("\n");
            //Having difficulty fixing the fact that there is a need to press enter to complete this test.
            Assert.Equal("Input string was not in a correct format.", outputarray[3]);
        }   

    }
}