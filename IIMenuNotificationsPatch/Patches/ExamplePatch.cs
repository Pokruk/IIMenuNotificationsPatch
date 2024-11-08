using GorillaLocomotion;
using HarmonyLib;
using UnityEngine;

using PokrukNotify = PokrukNotifyLib.Notifications.NotifiLib;
using IINotify = iiMenu.Notifications.NotifiLib;

namespace IIMenuNotificationsPatch.Patches {
    [HarmonyPatch(typeof(IINotify), "FixedUpdate")]
    public class UpdatePatch {
        private static bool Prefix() {
            return false;
        }
    }
    
    [HarmonyPatch(typeof(IINotify), nameof(IINotify.SendNotification))]
    public class SendPatch {
        private static bool Prefix(string NotificationText, int clearTime) {
            if (clearTime < 0) {
                clearTime = 1000;
            }
            PokrukNotify.SendNotification(NotificationText, clearTime);
            return false;
        }
    }
}