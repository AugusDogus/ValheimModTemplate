using BepInEx;

namespace ValheimMod;

[BepInPlugin(PluginId, "ValheimMod", PluginVersion)]
public sealed class Plugin : BaseUnityPlugin
{
    public const string PluginId = "augusdogus.mods.ValheimMod";
    public const string PluginVersion = "1.0.0";

    private void Awake()
    {
        Logger.LogInfo("ValheimMod loaded.");
    }
}
