using System;
using Xunit;
using WebApplication7.Controllers;
namespace XUnitTestProject1
{
    public class TestController
    {
        [Fact]
        public void Test_Get_Hello()
        {
            var controllerHello = new HelloHiiController();
           Assert.Equal("Hii", controllerHello.Get("Hello"));
        }
        [Fact]
        public void Test_Get_Hii()
        {
            var controllerHello = new HelloHiiController();
            Assert.Equal("Hello", controllerHello.Get("Hii"));
        }
        [Fact]
        public void Test_Get()
        {
            var controllerHello = new HelloHiiController();
            Assert.Equal("Something went wrong", controllerHello.Get());
        }
    }
}
