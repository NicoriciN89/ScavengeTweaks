#nullable disable
using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("ScavengeTweaks")]
[assembly: AssemblyProduct("ScavengeTweaks")]
[assembly: AssemblyCopyright("MIT License")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(ScavengeTweaks.Main), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonColor(200, 150, 80, 255)]

internal static class BuildInfo {
    internal const string ModName    = "Scavenge Tweaks";
    internal const string ModAuthor  = "NnicolaeN";
    internal const string ModVersion = "1.0.0";
}
