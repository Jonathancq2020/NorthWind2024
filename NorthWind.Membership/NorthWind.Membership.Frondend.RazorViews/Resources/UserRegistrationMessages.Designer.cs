﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthWind.Membership.Frondend.RazorViews.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UserRegistrationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserRegistrationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NorthWind.Membership.Frondend.RazorViews.Resources.UserRegistrationMessages", typeof(UserRegistrationMessages).Assembly);
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
        ///   Looks up a localized string similar to La contraseña y la confirmacion no coinciden..
        /// </summary>
        internal static string ConfirmPasswordErrorMessage {
            get {
                return ResourceManager.GetString("ConfirmPasswordErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre.
        /// </summary>
        internal static string FirsNameLabel {
            get {
                return ResourceManager.GetString("FirsNameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apellidos.
        /// </summary>
        internal static string LastNameLabel {
            get {
                return ResourceManager.GetString("LastNameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirmar contraseña.
        /// </summary>
        internal static string PasswordConfirmationLabel {
            get {
                return ResourceManager.GetString("PasswordConfirmationLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuario registrado exitosamente..
        /// </summary>
        internal static string RegisteredUserMessage {
            get {
                return ResourceManager.GetString("RegisteredUserMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registrar.
        /// </summary>
        internal static string RegistrerButtonText {
            get {
                return ResourceManager.GetString("RegistrerButtonText", resourceCulture);
            }
        }
    }
}
