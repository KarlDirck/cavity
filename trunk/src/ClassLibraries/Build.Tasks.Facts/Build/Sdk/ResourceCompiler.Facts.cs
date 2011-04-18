﻿namespace Cavity.Build.Sdk
{
    using System.Collections.Generic;
    using System.IO;
    using Xunit;

    public sealed class ResourceCompilerFacts
    {
        [Fact]
        public void a_definition()
        {
            Assert.True(new TypeExpectations<ResourceCompiler>()
                            .DerivesFrom<CompilerBase>()
                            .IsConcreteClass()
                            .IsSealed()
                            .NoDefaultConstructor()
                            .IsNotDecorated()
                            .Result);
        }

        [Fact]
        public void ctor_FileInfo()
        {
            Assert.NotNull(new ResourceCompiler(new FileInfo("RC.exe")));
        }

        [Fact]
        public void op_ToArguments_IEnumerableOfString()
        {
            var files = new List<string>
            {
                "example.1",
                "example.2"
            };

            const string expected = "-r example.1 example.2";
            var actual = new ResourceCompiler(new FileInfo("RC.exe")).ToArguments(files);

            Assert.Equal(expected, actual);
        }
    }
}