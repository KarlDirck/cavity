﻿namespace Cavity.Tests
{
    using System;
    using System.Globalization;
    using System.Reflection;

    public sealed class PropertyDefaultIsNotNullTest : PropertyTestBase
    {
        public PropertyDefaultIsNotNullTest(PropertyInfo property)
            : base(property)
        {
        }

        public override bool Check()
        {
            if (Equals(
                null,
                Property.GetGetMethod(true).Invoke(Activator.CreateInstance(Property.ReflectedType), null)))
            {
                throw new TestException(string.Format(CultureInfo.InvariantCulture, "{0}.{1} was unexpectedly null.", Property.ReflectedType.Name, Property.Name));
            }

            return true;
        }
    }
}