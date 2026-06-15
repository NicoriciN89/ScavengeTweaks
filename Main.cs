#nullable disable
using MelonLoader;

namespace ScavengeTweaks {

    public class Main : MelonMod {

        public override void OnInitializeMelon() {
            Settings.Initialize();
            LocalizationManager.Load();
            MelonLogger.Msg("Scavenge Tweaks v" + BuildInfo.ModVersion + " loaded.");
        }
    }
}
