using HarmonyLib;
using System.Collections.Generic;
using System.Reflection.Emit;
using static PulsarPluginLoader.Patches.HarmonyHelpers;

namespace CypherButtonFix
{
    [HarmonyPatch(typeof(PLSylvassiCypher_ControlStation), "Update")]
    class ControlStationUpdatePatch
    {
        public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> targetSequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(UnityEngine.Color), "get_magenta")),
            };

            List<CodeInstruction> injectedSequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(UnityEngine.Color), "get_yellow")),
            };
            return PatchBySequence(instructions, targetSequence, injectedSequence, PatchMode.REPLACE);
        }
    }
}
