using System;
using Exiled.API.Features;
using Exiled.API.Enums;
using Player = Exiled.Events.Handlers.Player;

namespace SpawnBroadcasts
{
    public class Plugin : Plugin<Config>
    {
        private static readonly Lazy<Plugin> LInstance = new Lazy<Plugin>(() => new Plugin());
        public static Plugin Instance => LInstance.Value;
        private Plugin()
        {
        }

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public override string Author { get; } = "DGvagabond";
        public override string Name { get; } = "SpawnBroadcasts";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 0, 10);

        private Handlers.Player PlayerEvents;
        public static Plugin Singleton;

        public override void OnEnabled()
        {
            try
            {
                RegisterEvents();
                Log.Info($"v{Version}, made by {Author}, successfully loaded.");
            }

            catch (Exception e)
            {
                Log.Error($"There was an error loading the plugin: {e}");
            }
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            Singleton = this;
            PlayerEvents = new Handlers.Player(this);

            Player.ChangingRole += PlayerEvents.OnSpawn;
        }
        public void UnregisterEvents()
        {
            Player.ChangingRole -= PlayerEvents.OnSpawn;

            PlayerEvents = null;
        }
    }
}