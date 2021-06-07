using System;
using uScript.API.Attributes;
using SDG.Unturned;
using Steamworks;

namespace EffectManagerExtended_uScript
{
    [ScriptModule("EffectManagerExtended")]
    public class Module
    {
        [ScriptFunction]
        public static void SetImage(string playerId, short key, string childName, string imageUrl)
        {
            var transport = Provider.findTransportConnection(new CSteamID(ulong.Parse(playerId)));
            EffectManager.sendUIEffectImageURL(key, transport, true, childName, imageUrl);
        }
        [ScriptFunction]
        public static void SetText(string playerId, short key, string childName, string text)
        {
            var transport = Provider.findTransportConnection(new CSteamID(ulong.Parse(playerId)));
            EffectManager.sendUIEffectText(key, transport, true, childName, text);
        }
        [ScriptFunction]
        public static void SetVisibility(string playerId, short key, string childName, string isVisible)
        {
            var transport = Provider.findTransportConnection(new CSteamID(ulong.Parse(playerId)));
            EffectManager.sendUIEffectVisibility(key, transport, true, childName, bool.Parse(isVisible));
        }
    }
}
