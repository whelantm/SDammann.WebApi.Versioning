﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDammann.WebApi.Versioning {
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
    internal class ExceptionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SDammann.WebApi.Versioning.ExceptionResources", typeof(ExceptionResources).Assembly);
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
        ///   Looks up a localized string similar to Multiple possibilities for {0}, using route template {1}. The following types were selected: {2}..
        /// </summary>
        internal static string AmbigiousControllerRequest {
            get {
                return ResourceManager.GetString("AmbigiousControllerRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find controller with name &apos;{0}&apos;.
        /// </summary>
        internal static string ApiControllerNotFound {
            get {
                return ResourceManager.GetString("ApiControllerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The API &apos;{0}&apos; doesn&apos;t exist.
        /// </summary>
        internal static string ApiDoesntExist {
            get {
                return ResourceManager.GetString("ApiDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API version is already added.
        /// </summary>
        internal static string ApiVersionAlreadyAdded {
            get {
                return ResourceManager.GetString("ApiVersionAlreadyAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not determine version and controller name from the request..
        /// </summary>
        internal static string CannotDetermineRequestVersion {
            get {
                return ResourceManager.GetString("CannotDetermineRequestVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not determine controller identity of controller type &apos;{0}&apos;..
        /// </summary>
        internal static string ControllerCouldNotBeIdentified {
            get {
                return ResourceManager.GetString("ControllerCouldNotBeIdentified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get service of type &apos;{0}&apos;. Please configure the dependency container..
        /// </summary>
        internal static string DependencyContainerNotConfigured {
            get {
                return ResourceManager.GetString("DependencyContainerNotConfigured", resourceCulture);
            }
        }
    }
}
