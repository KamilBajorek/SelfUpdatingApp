//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfUpdatingApp.Properties {
    using System;
    
    
    /// <summary>
    ///   Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    /// </summary>
    // Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    // przez narzędzie, takie jak ResGen lub Visual Studio.
    // Aby dodać lub usunąć składową, edytuj plik ResX, a następnie ponownie uruchom narzędzie ResGen
    // z opcją /str lub ponownie utwórz projekt VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        /// Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SelfUpdatingApp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        ///   przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
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
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Archive path.
        /// </summary>
        internal static string MainWindowArchivePathLabel {
            get {
                return ResourceManager.GetString("MainWindowArchivePathLabel", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Location of archived version of this application. Archivization is performed when updating to new version..
        /// </summary>
        internal static string MainWindowArchivePathTooltip {
            get {
                return ResourceManager.GetString("MainWindowArchivePathTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Installer path.
        /// </summary>
        internal static string MainWindowInstallerPathLabel {
            get {
                return ResourceManager.GetString("MainWindowInstallerPathLabel", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Location of application installer.
        /// </summary>
        internal static string MainWindowInstallerPathTooltip {
            get {
                return ResourceManager.GetString("MainWindowInstallerPathTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Settings.
        /// </summary>
        internal static string MainWindowLabel {
            get {
                return ResourceManager.GetString("MainWindowLabel", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu About.
        /// </summary>
        internal static string MenuAboutName {
            get {
                return ResourceManager.GetString("MenuAboutName", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Update available.
        /// </summary>
        internal static string UpdateAvailable {
            get {
                return ResourceManager.GetString("UpdateAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Error getting properties file, error message: .
        /// </summary>
        internal static string UpdateChecker_GetInstallerProperties_Error_getting_properties_file__error_message__ {
            get {
                return ResourceManager.GetString("UpdateChecker_GetInstallerProperties_Error_getting_properties_file__error_message" +
                        "__", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu No updates available.
        /// </summary>
        internal static string UpdateUnavailable {
            get {
                return ResourceManager.GetString("UpdateUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Dismiss.
        /// </summary>
        internal static string UpdateWindowCancel {
            get {
                return ResourceManager.GetString("UpdateWindowCancel", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Update.
        /// </summary>
        internal static string UpdateWindowConfirm {
            get {
                return ResourceManager.GetString("UpdateWindowConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu A new version of SelfUpdatingApp is available! Would you like to perform an update now?.
        /// </summary>
        internal static string UpdateWindowMessage {
            get {
                return ResourceManager.GetString("UpdateWindowMessage", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu Update available!.
        /// </summary>
        internal static string UpdateWindowTitle {
            get {
                return ResourceManager.GetString("UpdateWindowTitle", resourceCulture);
            }
        }
    }
}
