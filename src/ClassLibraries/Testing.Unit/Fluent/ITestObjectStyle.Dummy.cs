﻿namespace Cavity.Fluent
{
    using System;

    public class ITestObjectStyleDummy : ITestObjectStyle
    {
        public ITestObject IsAbstractBaseClass()
        {
            throw new NotSupportedException();
        }

        public ITestObjectSealed IsConcreteClass()
        {
            throw new NotSupportedException();
        }
    }
}