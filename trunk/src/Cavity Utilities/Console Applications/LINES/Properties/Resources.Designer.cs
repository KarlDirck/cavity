﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
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
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        internal static string ExceptionFormat {
            get {
                return ResourceManager.GetString("ExceptionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ------------------------------
        ///File:    {0}.
        /// </summary>
        internal static string FileInfo {
            get {
                return ResourceManager.GetString("FileInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lines: {0:0,0}.
        /// </summary>
        internal static string LineCount {
            get {
                return ResourceManager.GetString("LineCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press any key to exit....
        /// </summary>
        internal static string PressAnyKeyToExit {
            get {
                return ResourceManager.GetString("PressAnyKeyToExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Counts file lines.
        ///
        ///Usage: LINES names
        ///
        ///  names         Specifies a list of one or more files.
        ///                Wildcards may be used to process multiple files.
        ///
        ///Examples:
        ///                Process the example text file:
        ///		LINES C:\Temp\example.txt
        ///
        ///                Process all text files in Temp directory only:
        ///		LINES C:\Temp\*.txt
        ///
        ///                Process all text files in Temp and child directories:
        ///		LINES C:\Temp\**\*.txt.
        /// </summary>
        internal static string UsageHelp {
            get {
                return ResourceManager.GetString("UsageHelp", resourceCulture);
            }
        }
    }
}
