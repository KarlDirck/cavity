﻿namespace Cavity.Tests
{
    using Cavity.Fluent;
    using Xunit;

    public class SealedClassTestOfTFacts
    {
        [Fact]
        public void is_ITestExpectation()
        {
            Assert.IsAssignableFrom<ITestExpectation>(new SealedClassTest<int>(true));
        }

        [Fact]
        public void ctor()
        {
            Assert.NotNull(new SealedClassTest<object>(true));
        }

        [Fact]
        public void prop_Value()
        {
            bool expected = true;

            var obj = new SealedClassTest<object>(false);

            obj.Value = expected;
            bool actual = obj.Value;

            Assert.Equal<bool>(expected, actual);
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<TestException>(() => new SealedClassTest<string>(false).Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new SealedClassTest<string>(true).Check());
        }
    }
}