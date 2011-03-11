﻿namespace Cavity.Tests
{
    using System.Reflection;
    using Cavity.Properties;

    public sealed class PropertyGetterTest<T> : PropertyTestBase
    {
        public PropertyGetterTest(PropertyInfo property)
            : base(property)
        {
        }

        public object Expected { get; set; }

        public override bool Check()
        {
            if (Equals(typeof(T), Property.PropertyType))
            {
                return true;
            }

            throw new UnitTestException(Resources.PropertyGetterTestOfTException_Message.FormatWith(Property.PropertyType, typeof(T)));
        }
    }
}