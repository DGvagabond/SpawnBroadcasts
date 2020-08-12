using System.ComponentModel;
using Exiled.API.Interfaces;

namespace SpawnBroadcasts
{
    public class Config : IConfig
    {
        [Description("Leave a class setting blank to disable spawn broadcasts for that class.")]
        public bool IsEnabled { get; set; } = false;
        public int BroadcastDuration { get; set; } = 10;
        public string ClassD { get; set; } = "";
        public string ChaosInsurgency { get; set; } = "";
        public string Scientist { get; set; } = "";
        public string FacilityGuard { get; set; } = "";
        public string MtfCadet { get; set; } = "";
        public string MtfLieutenant { get; set; } = "";
        public string MtfScientist { get; set; } = "";
        public string MtfCommander { get; set; } = "";
        public string Tutorial { get; set; } = "";
        public string Scp049 { get; set; } = "";
        public string Scp0492 { get; set; } = "";
        public string Scp079 { get; set; } = "";
        public string Scp096 { get; set; } = "";
        public string Scp106 { get; set; } = "";
        public string Scp173 { get; set; } = "";
    }
}