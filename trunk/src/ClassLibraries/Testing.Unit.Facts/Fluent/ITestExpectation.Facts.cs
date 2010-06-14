﻿namespace Cavity.Fluent
{
    using System;
    using Xunit;

    public class ITestExpectationFacts
    {
        [Fact]
        public void typedef()
        {
            Assert.True(typeof(ITestExpectation).IsInterface);
        }

        [Fact]
        public void ITestExpectation_Check()
        {
            try
            {
                bool value = (new ITestExpectationDummy() as ITestExpectation).Check();
                Assert.True(false);
            }
            catch (NotSupportedException)
            {
            }
        }
    }
}