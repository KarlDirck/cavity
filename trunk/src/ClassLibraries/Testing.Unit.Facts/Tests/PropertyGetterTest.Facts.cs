﻿namespace Cavity.Tests
{
    using Cavity.Types;
    using Xunit;

    public sealed class PropertyGetterTestFacts
    {
        [Fact]
        public void ctor_PropertyInfo_object()
        {
            Assert.NotNull(new PropertyGetterTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"), true));
        }

        [Fact]
        public void is_PropertyTest()
        {
            Assert.IsAssignableFrom<PropertyTestBase>(new PropertyGetterTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"), true));
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<TestException>(() => new PropertyGetterTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"), true).Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new PropertyGetterTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"), false).Check());
        }

        [Fact]
        public void prop_Expected()
        {
            object expected = true;

            var obj = new PropertyGetterTest(null, false)
            {
                Expected = expected
            };

            var actual = obj.Expected;

            Assert.Same(expected, actual);
        }
    }
}