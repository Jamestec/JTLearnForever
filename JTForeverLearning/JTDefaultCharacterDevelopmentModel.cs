using HarmonyLib;
using MCM.Abstractions.Settings.Base.Global;
using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using TaleWorlds.Localization;

namespace JTForeverLearning
{
    [HarmonyPatch(typeof(DefaultCharacterDevelopmentModel))]
    [HarmonyPatch("CalculateLearningRate")]
    [HarmonyPatch(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(TextObject), typeof(StatExplainer) })]
    class JTDefaultCharacterDevelopmentModel
    {
        static void Postfix(ref float __result)
        {
            if (__result < GlobalSettings<Settings>.Instance.MinLearningRate)
            {
                __result = GlobalSettings<Settings>.Instance.MinLearningRate;
            }
        }
    }
}
