﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cavity.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cavity.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not an abstract base class..
        /// </summary>
        internal static string AbstractBaseClassTestException_Message {
            get {
                return ResourceManager.GetString("AbstractBaseClassTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should not allow multiple usage..
        /// </summary>
        internal static string AttributeUsage_AllowMultipleFalse {
            get {
                return ResourceManager.GetString("AttributeUsage_AllowMultipleFalse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should allow multiple usage..
        /// </summary>
        internal static string AttributeUsage_AllowMultipleTrue {
            get {
                return ResourceManager.GetString("AttributeUsage_AllowMultipleTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should not allow inheritance..
        /// </summary>
        internal static string AttributeUsage_InheritedFalse {
            get {
                return ResourceManager.GetString("AttributeUsage_InheritedFalse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should allow inheritance..
        /// </summary>
        internal static string AttributeUsage_InheritedTrue {
            get {
                return ResourceManager.GetString("AttributeUsage_InheritedTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not have the expected attribute usage targets..
        /// </summary>
        internal static string AttributeUsage_ValidOn {
            get {
                return ResourceManager.GetString("AttributeUsage_ValidOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not derived from {1}..
        /// </summary>
        internal static string BaseClassTestException_Message {
            get {
                return ResourceManager.GetString("BaseClassTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a concrete class..
        /// </summary>
        internal static string ConcreteClassTestException_Message {
            get {
                return ResourceManager.GetString("ConcreteClassTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [{1}]..
        /// </summary>
        internal static string DecorationTestException_MissingMessage {
            get {
                return ResourceManager.GetString("DecorationTestException_MissingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is unexpectedly decorated with at least one attribute..
        /// </summary>
        internal static string DecorationTestException_UnexpectedMessage {
            get {
                return ResourceManager.GetString("DecorationTestException_UnexpectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not have a default constructor..
        /// </summary>
        internal static string DefaultConstructorTestException_Message {
            get {
                return ResourceManager.GetString("DefaultConstructorTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not implement {1}..
        /// </summary>
        internal static string ImplementationTestException_NoneMessage {
            get {
                return ResourceManager.GetString("ImplementationTestException_NoneMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} unexpectedly implements at least one interface..
        /// </summary>
        internal static string ImplementationTestException_UnexpectedMessage {
            get {
                return ResourceManager.GetString("ImplementationTestException_UnexpectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlSerializable(...) method instead of the Implements&lt;T&gt;() method..
        /// </summary>
        internal static string Implements_IXmlSerializable {
            get {
                return ResourceManager.GetString("Implements_IXmlSerializable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not an interface..
        /// </summary>
        internal static string InterfaceTestException_Message {
            get {
                return ResourceManager.GetString("InterfaceTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlArray(...) method instead of this generic method..
        /// </summary>
        internal static string PropertyExpectations_IsDecoratedWithXmlArray {
            get {
                return ResourceManager.GetString("PropertyExpectations_IsDecoratedWithXmlArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlAttribute(...) method instead of this generic method..
        /// </summary>
        internal static string PropertyExpectations_IsDecoratedWithXmlAttribute {
            get {
                return ResourceManager.GetString("PropertyExpectations_IsDecoratedWithXmlAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlElement(...) method instead of this generic method..
        /// </summary>
        internal static string PropertyExpectations_IsDecoratedWithXmlElement {
            get {
                return ResourceManager.GetString("PropertyExpectations_IsDecoratedWithXmlElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlIgnore() method instead of this generic method..
        /// </summary>
        internal static string PropertyExpectations_IsDecoratedWithXmlIgnore {
            get {
                return ResourceManager.GetString("PropertyExpectations_IsDecoratedWithXmlIgnore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlNamespaceDeclarationsAttribute() method instead of this generic method..
        /// </summary>
        internal static string PropertyExpectations_IsDecoratedWithXmlNamespaceDeclarations {
            get {
                return ResourceManager.GetString("PropertyExpectations_IsDecoratedWithXmlNamespaceDeclarations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlText() method instead of this generic method..
        /// </summary>
        internal static string PropertyExpectations_IsDecoratedWithXmlText {
            get {
                return ResourceManager.GetString("PropertyExpectations_IsDecoratedWithXmlText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.{1} did not equal the expected value..
        /// </summary>
        internal static string PropertyGetterTestException_Message {
            get {
                return ResourceManager.GetString("PropertyGetterTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.{1} did not equal the expected value..
        /// </summary>
        internal static string PropertyGetterTestOfTException_Message {
            get {
                return ResourceManager.GetString("PropertyGetterTestOfTException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.{1} did not throw the expected {2}..
        /// </summary>
        internal static string PropertySetterTestException_Message {
            get {
                return ResourceManager.GetString("PropertySetterTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} unexpectedly is a sealed class..
        /// </summary>
        internal static string SealedClassTestException_SealedMessage {
            get {
                return ResourceManager.GetString("SealedClassTestException_SealedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a sealed class..
        /// </summary>
        internal static string SealedClassTestException_UnsealedMessage {
            get {
                return ResourceManager.GetString("SealedClassTestException_UnsealedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the AttributeUsage(...) method instead of the IsDecoratedWith&lt;T&gt;() method..
        /// </summary>
        internal static string TypeExpectations_IsDecoratedWithAttributeUsage {
            get {
                return ResourceManager.GetString("TypeExpectations_IsDecoratedWithAttributeUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the Serializable() method instead of the IsDecoratedWith&lt;T&gt;() method..
        /// </summary>
        internal static string TypeExpectations_IsDecoratedWithSerializable {
            get {
                return ResourceManager.GetString("TypeExpectations_IsDecoratedWithSerializable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please use the XmlRoot(...) method instead of the IsDecoratedWith&lt;T&gt;() method..
        /// </summary>
        internal static string TypeExpectations_IsDecoratedWithXmlRoot {
            get {
                return ResourceManager.GetString("TypeExpectations_IsDecoratedWithXmlRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An interface type must be specified..
        /// </summary>
        internal static string TypeExpectationsException_InterfaceMessage {
            get {
                return ResourceManager.GetString("TypeExpectationsException_InterfaceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a value type..
        /// </summary>
        internal static string ValueTypeTestException_Message {
            get {
                return ResourceManager.GetString("ValueTypeTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlArray]..
        /// </summary>
        internal static string XmlArrayDecorationTestException_Message1 {
            get {
                return ResourceManager.GetString("XmlArrayDecorationTestException_Message1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlArray(\&quot;{1}\&quot;)]..
        /// </summary>
        internal static string XmlArrayDecorationTestException_Message2 {
            get {
                return ResourceManager.GetString("XmlArrayDecorationTestException_Message2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlArrayItem]..
        /// </summary>
        internal static string XmlArrayDecorationTestException_Message3 {
            get {
                return ResourceManager.GetString("XmlArrayDecorationTestException_Message3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlArrayItem(\&quot;{1}\&quot;)]..
        /// </summary>
        internal static string XmlArrayDecorationTestException_Message4 {
            get {
                return ResourceManager.GetString("XmlArrayDecorationTestException_Message4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlAttribute]..
        /// </summary>
        internal static string XmlAttributeDecorationTestException_Message1 {
            get {
                return ResourceManager.GetString("XmlAttributeDecorationTestException_Message1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlAttribute(\&quot;{1}\&quot;)]..
        /// </summary>
        internal static string XmlAttributeDecorationTestException_Message2 {
            get {
                return ResourceManager.GetString("XmlAttributeDecorationTestException_Message2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlAttribute(\&quot;{1}\&quot;, \&quot;{2}\&quot;)]..
        /// </summary>
        internal static string XmlAttributeDecorationTestException_Message3 {
            get {
                return ResourceManager.GetString("XmlAttributeDecorationTestException_Message3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlElement]..
        /// </summary>
        internal static string XmlElementDecorationTestException_Message1 {
            get {
                return ResourceManager.GetString("XmlElementDecorationTestException_Message1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlElement(\&quot;{1}\&quot;)]..
        /// </summary>
        internal static string XmlElementDecorationTestException_Message2 {
            get {
                return ResourceManager.GetString("XmlElementDecorationTestException_Message2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlElement(\&quot;{1}\&quot;, \&quot;{2}\&quot;)]..
        /// </summary>
        internal static string XmlElementDecorationTestException_Message3 {
            get {
                return ResourceManager.GetString("XmlElementDecorationTestException_Message3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlIgnore]..
        /// </summary>
        internal static string XmlIgnoreDecorationTestException_Message {
            get {
                return ResourceManager.GetString("XmlIgnoreDecorationTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlNamespaceDeclarations]..
        /// </summary>
        internal static string XmlNamespaceDeclarationsDecorationTestException_Message {
            get {
                return ResourceManager.GetString("XmlNamespaceDeclarationsDecorationTestException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlRoot(\&quot;{1}\&quot;)]..
        /// </summary>
        internal static string XmlRootDecorationTestException_NameMessage {
            get {
                return ResourceManager.GetString("XmlRootDecorationTestException_NameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlRoot(\&quot;{1}\&quot;, \&quot;{2}\&quot;)]..
        /// </summary>
        internal static string XmlRootDecorationTestException_NamespaceMessage {
            get {
                return ResourceManager.GetString("XmlRootDecorationTestException_NamespaceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlRoot]..
        /// </summary>
        internal static string XmlRootDecorationTestException_UndecoratedMessage {
            get {
                return ResourceManager.GetString("XmlRootDecorationTestException_UndecoratedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not equal to new {1}()..
        /// </summary>
        internal static string XmlSerialization_EqualsNew {
            get {
                return ResourceManager.GetString("XmlSerialization_EqualsNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not throw an NotSupportedException..
        /// </summary>
        internal static string XmlSerialization_GetSchema {
            get {
                return ResourceManager.GetString("XmlSerialization_GetSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not throw an ArgumentNullException when ReadXml(...) is invoked with a null reader..
        /// </summary>
        internal static string XmlSerialization_ReadXmlNull {
            get {
                return ResourceManager.GetString("XmlSerialization_ReadXmlNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not throw an ArgumentNullException when WriteXml(...) is invoked with a null writer..
        /// </summary>
        internal static string XmlSerialization_WriteXmlNull {
            get {
                return ResourceManager.GetString("XmlSerialization_WriteXmlNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not decorated with [XmlText]..
        /// </summary>
        internal static string XmlTextDecorationTestException_Message {
            get {
                return ResourceManager.GetString("XmlTextDecorationTestException_Message", resourceCulture);
            }
        }
    }
}
