﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fallout4Ini.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fallout4Ini.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Banner {
            get {
                object obj = ResourceManager.GetObject("Banner", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [General]
        ///sLanguage=en
        ///uGridsToLoad=5
        ///uExterior Cell Buffer=36
        ///bDisableAllGore=0
        ///
        ///[ScreenSplatter]
        ///bBloodSplatterEnabled=1
        ///
        ///[Display]
        ///iPresentInterval=1
        ///bDeferredCommands=1
        ///fShadowLODMaxStartFade=1000.0
        ///fSpecularLODMaxStartFade=2000.0
        ///fLightLODMaxStartFade=3500.0
        ///iShadowMapResolutionPrimary=2048
        ///bAllowScreenshot=1
        ///fMeshLODLevel1FadeDist=3500.0000
        ///fMeshLODLevel2FadeDist=2000.0000
        ///fMeshLODFadePercentDefault=1.2000
        ///bNvGodraysEnable=1
        ///bDynamicObjectQueryManager=1
        ///bMultiThreadedAccumulation [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Fallout4 {
            get {
                return ResourceManager.GetString("Fallout4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Display]
        ///flocalShadowMapHalveEveryXUnit=750.0000
        ///focusShadowMapDoubleEveryXUnit=450.0000
        ///fShadowBiasScale=1.0000
        ///fDirShadowDistance=20000
        ///fShadowDistance=20000
        ///uiOrthoShadowFilter=3
        ///uiShadowFilter=3
        ///iShadowMapResolution=4096
        ///uPipboyTargetHeight=700
        ///uPipboyTargetWidth=876
        ///iVolumetricLightingQuality=2
        ///bVolumetricLightingEnable=1
        ///bSAOEnable=1
        ///iDirShadowSplits=3
        ///bVolumetricLightingForceCasters=0
        ///iTiledLightingMinLights=40
        ///bComputeShaderDeferredTiledLighting=1
        ///iMaxFocusShadowsDialogue=4
        ///iMaxF [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Fallout4Prefs {
            get {
                return ResourceManager.GetString("Fallout4Prefs", resourceCulture);
            }
        }
    }
}
