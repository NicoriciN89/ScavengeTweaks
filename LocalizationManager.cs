#nullable disable
using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using UnityEngine;

namespace ScavengeTweaks {

    internal class LocalizationManager {

        private static Dictionary<string, Dictionary<string, string>> _data;
        private const string PREFIX = "ST_";

        internal static void Load() {
            try {
                var asm = Assembly.GetExecutingAssembly();
                using Stream stream = asm.GetManifestResourceStream("ScavengeTweaks.localization.json");
                if (stream == null) {
                    MelonLogger.Warning("[Scavenge Tweaks] localization.json not found in embedded resources.");
                    return;
                }
                using StreamReader reader = new(stream);
                _data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(reader.ReadToEnd());
                MelonLogger.Msg("[Scavenge Tweaks] Localization loaded.");
            } catch (System.Exception ex) {
                MelonLogger.Error("[Scavenge Tweaks] Failed to load localization: " + ex.Message);
            }
        }

        internal static string Get(string key) {
            if (_data == null) return key;
            string raw  = Localization.Language ?? "English";
            string lang = NormalizeLanguage(raw);
            if (_data.TryGetValue(lang, out var dict) && dict.TryGetValue(key, out var val))
                return val;
            if (_data.TryGetValue("English", out var en) && en.TryGetValue(key, out var fallback))
                return fallback;
            return key;
        }

        private static string NormalizeLanguage(string raw) => raw switch {
            "Russian"                  => "Russian",
            "German"                   => "German",
            "French"                   => "French",
            "French (France)"          => "French",
            "Spanish"                  => "Spanish",
            "Spanish (Latin America)"  => "Spanish",
            "Brazilian"                => "Brazilian",
            "Portuguese (Brazil)"      => "Brazilian",
            "Italian"                  => "Italian",
            "Italian (Italy)"          => "Italian",
            "Dutch"                    => "Dutch",
            "Dutch (Netherlands)"      => "Dutch",
            "Polish"                   => "Polish",
            "Polish (Poland)"          => "Polish",
            "Turkish"                  => "Turkish",
            "Turkish (Turkey)"         => "Turkish",
            "ChineseSimplified"        => "ChineseSimplified",
            "Simplified Chinese"       => "ChineseSimplified",
            "Chinese (Simplified)"     => "ChineseSimplified",
            "ChineseTraditional"       => "ChineseTraditional",
            "Traditional Chinese"      => "ChineseTraditional",
            "Chinese (Traditional)"    => "ChineseTraditional",
            "Korean"                   => "Korean",
            "Korean (Korea)"           => "Korean",
            "Japanese"                 => "Japanese",
            "Japanese (Japan)"         => "Japanese",
            "Ukrainian"                => "Ukrainian",
            "Ukrainian (Ukraine)"      => "Ukrainian",
            "Swedish"                  => "Swedish",
            "Swedish (Sweden)"         => "Swedish",
            "Norwegian"                => "Norwegian",
            "Finnish"                  => "Finnish",
            _                          => "English"
        };

        private static readonly List<(UILabel label, string key)> s_labels = new();
        private static readonly List<(Component holder, MethodInfo setter, string key)> s_descs = new();

        internal static void BuildCache(Transform modTab) {
            s_labels.Clear();
            s_descs.Clear();

            UILocalize[] localizers = ((Component)(object)modTab).GetComponentsInChildren<UILocalize>(true);
            foreach (UILocalize ul in localizers) {
                if (ul == null || ul.key == null || !ul.key.StartsWith(PREFIX)) continue;
                UILabel lbl = ((Component)(object)ul).GetComponent<UILabel>();
                if (lbl != null)
                    s_labels.Add((lbl, ul.key));
            }

            Component[] all = ((Component)(object)modTab).GetComponentsInChildren<Component>(true);
            foreach (Component comp in all) {
                if (comp == null) continue;
                if (comp.GetType().Name != "DescriptionHolder") continue;
                PropertyInfo prop = comp.GetType().GetProperty("Text",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (prop == null) continue;
                string current = prop.GetValue(comp) as string;
                if (current == null || !current.StartsWith(PREFIX)) continue;
                MethodInfo setter = prop.GetSetMethod(nonPublic: true);
                if (setter == null) continue;
                s_descs.Add((comp, setter, current));
            }
        }

        internal static void ApplyTranslations() {
            foreach (var (lbl, key) in s_labels)
                if ((UnityEngine.Object)(object)lbl != null)
                    lbl.text = Get(key);

            foreach (var (holder, setter, key) in s_descs)
                if ((UnityEngine.Object)(object)holder != null)
                    setter.Invoke(holder, new object[] { key });
        }

        [HarmonyPatch(typeof(Panel_OptionsMenu), "InitializeAutosaveMenuItems")]
        internal static class Patch_BuildCache {
            [HarmonyPriority(Priority.Low)]
            static void Postfix(Panel_OptionsMenu __instance) {
                Transform pages = ((Component)(object)__instance).transform.Find("Pages");
                if (pages == null) return;
                Transform modTab = pages.Find("ModSettings");
                if (modTab == null) return;
                BuildCache(modTab);
                ApplyTranslations();
            }
        }

        [HarmonyPatch(typeof(Panel_OptionsMenu), "SetLanguage")]
        internal static class Patch_SetLanguage {
            static void Postfix() => ApplyTranslations();
        }

        [HarmonyPatch(typeof(Localization), nameof(Localization.Get))]
        internal static class Patch_Localization_Get {
            static void Postfix(string key, ref string __result) {
                if (key != null && key.StartsWith(PREFIX))
                    __result = Get(key);
            }
        }

        [HarmonyPatch]
        internal static class Patch_DescriptionText {
            static MethodBase TargetMethod() =>
                AccessTools.PropertyGetter(
                    AccessTools.TypeByName("ModSettings.DescriptionHolder"), "Text");

            static void Postfix(ref string __result) {
                if (__result != null && __result.StartsWith(PREFIX))
                    __result = Get(__result);
            }
        }
    }
}
