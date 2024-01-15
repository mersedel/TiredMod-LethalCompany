using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using TiredMod.Patches;

namespace TiredMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class TiredModBase : BaseUnityPlugin
    {
        private const string modGUID = "mersedel.TiredMod";
        private const string modName = "Tired mod";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static TiredModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The Tired Mod has awaken!");

            harmony.PatchAll(typeof(TiredModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
