﻿namespace Cavity.Tests
{
    using System;
    using System.Reflection;

    public class DerivedPropertyTest : PropertyTest
    {
        public DerivedPropertyTest(PropertyInfo property)
            : base(property)
        {
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }
    }
}