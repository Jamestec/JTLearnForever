using HarmonyLib;
using JTPrisonerRecruitment;
using MCM.Abstractions.Settings.Base.Global;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace JTForeverLearning
{
    public class SubModule : MBSubModuleBase
    {
        private bool done = false;
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            if (done)
            {
                Logs.log($"JTForeverLearning min={GlobalSettings<Settings>.Instance.MinLearningRate}", new Color(0, 1, 0));
            } else
            {
                var harmony = new Harmony("JTForeverLearning");
                harmony.PatchAll();
                done = true;
                Logs.log($"JTForeverLearning has patched, min={GlobalSettings<Settings>.Instance.MinLearningRate}", new Color(0, 1, 0));
            }
        }
    }


}
