using Exiled.Events.EventArgs;

namespace SpawnBroadcasts.Handlers
{
    public class Player
    {
        public System.Random Gen = new System.Random();
        public Plugin plugin;
        public Player(Plugin plugin) => this.plugin = plugin;

        public void OnSpawn(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleType.ClassD && Plugin.Instance.Config.ClassD != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.ClassD}");
            }
            if (ev.NewRole == RoleType.Scientist && Plugin.Instance.Config.Scientist != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scientist}");
            }
            if (ev.NewRole == RoleType.FacilityGuard && Plugin.Instance.Config.FacilityGuard != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.FacilityGuard}");
            }
            if (ev.NewRole == RoleType.NtfCadet && Plugin.Instance.Config.MtfCadet != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.MtfCadet}");
            }
            if (ev.NewRole == RoleType.NtfLieutenant && Plugin.Instance.Config.MtfLieutenant != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.MtfLieutenant}");
            }
            if (ev.NewRole == RoleType.NtfScientist && Plugin.Instance.Config.MtfScientist != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.MtfScientist}");
            }
            if (ev.NewRole == RoleType.NtfCommander && Plugin.Instance.Config.MtfCommander != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.MtfCommander}");
            }
            if (ev.NewRole == RoleType.Tutorial && Plugin.Instance.Config.Tutorial != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Tutorial}");
            }
            if (ev.NewRole == RoleType.Scp049 && Plugin.Instance.Config.Scp049 != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scp049}");
            }
            if (ev.NewRole == RoleType.Scp0492 && Plugin.Instance.Config.Scp0492 != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scp0492}");
            }
            if (ev.NewRole == RoleType.Scp079 && Plugin.Instance.Config.Scp079 != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scp079}");
            }
            if (ev.NewRole == RoleType.Scp096 && Plugin.Instance.Config.Scp096 != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scp096}");
            }
            if (ev.NewRole == RoleType.Scp106 && Plugin.Instance.Config.Scp106 != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scp106}");
            }
            if (ev.NewRole == RoleType.Scp173 && Plugin.Instance.Config.Scp173 != "")
            {
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast((ushort)Plugin.Instance.Config.BroadcastDuration, $"{Plugin.Instance.Config.Scp173}");
            }
        }
    }
}