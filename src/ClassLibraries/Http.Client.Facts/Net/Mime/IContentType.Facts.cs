﻿namespace Cavity.Net.Mime
{
    using System;
    using System.Net.Mime;
    using Xunit;

    public sealed class IContentTypeFacts
    {
        [Fact]
        public void type_definition()
        {
            Assert.True(typeof(IContentType).IsInterface);
        }

        [Fact]
        public void IContentType_ContentType_get()
        {
            try
            {
                ContentType value = (new IContentTypeDummy() as IContentType).ContentType;
                Assert.True(false);
            }
            catch (NotSupportedException)
            {
            }
        }
    }
}