using BepInEx;
using System;
using UnityEngine;

namespace IIMenuNotificationsPatch {
    [BepInDependency("org.pragmate.pokruk.notifications")]
    [BepInDependency("org.iidk.gorillatag.iimenu")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin {
        void OnEnable() {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable() {
            HarmonyPatches.RemoveHarmonyPatches();
        }
    }
}
