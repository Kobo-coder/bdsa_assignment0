using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program.IsLeapYear(1600));
            Assert.True(Program.IsLeapYear(1604));
            Assert.False(Program.IsLeapYear(1700));
            Assert.True(Program.IsLeapYear(4));
        }

        public void Test2(){
            
        }
    }
}