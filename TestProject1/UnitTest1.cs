using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq.AutoMock;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly AutoMocker _mocker = new();
        
        [Fact]
        public void Test1()
        {
            var instance = _mocker.CreateInstance<Program>();
        }
    }
}