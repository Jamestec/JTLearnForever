using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Settings.Base.Global;
using System.ComponentModel;

namespace JTForeverLearning
{
    class Settings : AttributeGlobalSettings<Settings>
    {
        public override string Id => "JTForeverLearning";
        public override string DisplayName => "JTForeverLearning";
        public override string FolderName => "JTForeverLearning";
        public override string Format => "json";

        [SettingPropertyFloatingInteger("Minimum Learning Rate", 0f, 1f, "0.###", Order = 0, RequireRestart = false, HintText = "Don't set this to 0, baka!")]
        public float MinLearningRate
        {
            get;
            set;
        } = 0.1f;
    }
}