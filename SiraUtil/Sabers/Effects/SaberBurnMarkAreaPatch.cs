using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace SiraUtil.Sabers.Effects
{
    internal class SaberBurnMarkAreaPatch
    {
        private static readonly MethodInfo _destroyExtraLines;
        private static readonly MethodInfo _evaluateAllRenderers;
        private static readonly MethodInfo _safeDestroyMethodInfo;
        private static readonly FieldInfo _lineRendererInfo;
        private static readonly FieldInfo _sabersInfo;
        private static readonly MethodInfo _rendererGetEnabled;

        internal static void DynamicEnable(ref LineRenderer[] ____lineRenderers) { }
        internal static void DynamicDisable(ref LineRenderer[] ____lineRenderers) { }
        internal static IEnumerable<CodeInstruction> DynamicUpdate(IEnumerable<CodeInstruction> instructions) => instructions;
        internal static IEnumerable<CodeInstruction> DynamicDestroy(IEnumerable<CodeInstruction> instructions) => instructions;
        private static bool CompareAllRenderers(LineRenderer[] lineRenderers) => false;
        private static void DestroyExtraLines(LineRenderer[] lineRenderers) { }
    }
}
