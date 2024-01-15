using GameNetcodeStuff;
using HarmonyLib;

namespace TiredMod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]

        static void NoSprintAndJumpPatch(ref float ___jumpForce, ref float ___sprintTime)
        {
            ___jumpForce = 1f;
            ___sprintTime = 0f;
        }
    }
}
