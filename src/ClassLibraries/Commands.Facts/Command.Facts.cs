﻿namespace Cavity
{
    using System;
    using System.Xml.Serialization;
    using Cavity.Xml.XPath;
    using Xunit;

    public sealed class CommandFacts
    {
        [Fact]
        public void a_definition()
        {
            Assert.True(new TypeExpectations<Command>()
                            .DerivesFrom<object>()
                            .IsAbstractBaseClass()
                            .IsNotDecorated()
                            .Implements<ICommand>()
                            .Result);
        }

        [Fact]
        public void ctor()
        {
            Assert.NotNull(new DerivedCommand());
        }

        [Fact]
        public void ctor_bool()
        {
            Assert.True(new DerivedCommand(true).Unidirectional);
        }

        [Fact]
        public void prop_Undo()
        {
            Assert.True(new PropertyExpectations<Command>(p => p.Undo)
                            .TypeIs<bool>()
                            .IsNotDecorated()
                            .Result);
        }

        [Fact]
        public void prop_Unidirectional()
        {
            Assert.True(new PropertyExpectations<Command>(p => p.Unidirectional)
                            .TypeIs<bool>()
                            .IsNotDecorated()
                            .Result);
        }

        [Fact]
        public void op_GetSchema()
        {
            Assert.Throws<NotSupportedException>(() => (new DerivedCommand() as IXmlSerializable).GetSchema());
        }

        [Fact]
        public void op_ReadXml_XmlReaderNull()
        {
            Assert.Throws<ArgumentNullException>(() => (new DerivedCommand() as IXmlSerializable).ReadXml(null));
        }

        [Fact]
        public void op_WriteXml_XmlWriterNull()
        {
            Assert.Throws<ArgumentNullException>(() => (new DerivedCommand() as IXmlSerializable).WriteXml(null));
        }

        [Fact]
        public void serialize()
        {
            var obj = new DerivedCommand(true);

            var navigator = obj.XmlSerialize().CreateNavigator();

            Assert.True(navigator.Evaluate<bool>("1 = count(/command)"));
            const string xpath = "1 = count(command[@undo='false'][@unidirectional='true'])";
            Assert.True(navigator.Evaluate<bool>(xpath));
        }

        [Fact]
        public void deserialize()
        {
            var obj = "<command undo='true' unidirectional='true' />".XmlDeserialize<DerivedCommand>();

            Assert.True(obj.Undo);
            Assert.True(obj.Unidirectional);
        }
    }
}