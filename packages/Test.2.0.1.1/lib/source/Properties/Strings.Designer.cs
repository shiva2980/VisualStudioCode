//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.454
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dnp.Properties {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dnp.Properties.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to There is no TypeConverter registered that can save type {0} to a string and back..
        /// </summary>
        internal static string CannotRoundTripType0 {
            get {
                return ResourceManager.GetString("CannotRoundTripType0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination file name must be set before saving..
        /// </summary>
        internal static string DestinationFileNameNotSet {
            get {
                return ResourceManager.GetString("DestinationFileNameNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Document root must not be null..
        /// </summary>
        internal static string DocumentRootMustNotBeNull {
            get {
                return ResourceManager.GetString("DocumentRootMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expand key not found: {0}..
        /// </summary>
        internal static string ExpandKeyMissing0 {
            get {
                return ResourceManager.GetString("ExpandKeyMissing0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expand section not found: {0}..
        /// </summary>
        internal static string ExpandSectionMissing0 {
            get {
                return ResourceManager.GetString("ExpandSectionMissing0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to convert string [{0}] to type [{1}]..
        /// </summary>
        internal static string FailedToConvert0T1 {
            get {
                return ResourceManager.GetString("FailedToConvert0T1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The short name may only be 1 or 2 characters.
        /// </summary>
        internal static string InvalidShortNameLength {
            get {
                return ResourceManager.GetString("InvalidShortNameLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must provide valid scope for settings..
        /// </summary>
        internal static string InvalidStorageScope {
            get {
                return ResourceManager.GetString("InvalidStorageScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key not found: [{0}] in current section: [{1}]..
        /// </summary>
        internal static string Key0NotFoundInSection1DuringExpansion {
            get {
                return ResourceManager.GetString("Key0NotFoundInSection1DuringExpansion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key cannot have a expand value of itself: {0}..
        /// </summary>
        internal static string KeyCannotExpandOnSelf0 {
            get {
                return ResourceManager.GetString("KeyCannotExpandOnSelf0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sections cannot have empty names..
        /// </summary>
        internal static string NoEmptySectionNames {
            get {
                return ResourceManager.GetString("NoEmptySectionNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no TypeConverter registered that can restore type {0} from a string. Please create a TypeConverter for type {0} that can save and restore from string..
        /// </summary>
        internal static string NoTypeConverterForRestore0 {
            get {
                return ResourceManager.GetString("NoTypeConverterForRestore0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be reloaded..
        /// </summary>
        internal static string TypeCantBeReloaded0 {
            get {
                return ResourceManager.GetString("TypeCantBeReloaded0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be saved..
        /// </summary>
        internal static string TypeCantBeSaved0 {
            get {
                return ResourceManager.GetString("TypeCantBeSaved0", resourceCulture);
            }
        }
    }
}
