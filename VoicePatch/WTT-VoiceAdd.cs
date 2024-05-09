using System;
using BepInEx;
using UnityEngine;

namespace WTT_VoicePatcher
{

    [BepInPlugin("com.grooveypenguinx.basedonCWXVoiceAdder.cheechandchongvoiceadder", "CheechAndChong Adder", "0.6.9")]
    public class WTTVoiceAdd : BaseUnityPlugin
    {
        private void Start()
        {
            new WTTVoicePatcher().Enable();
        }
    }
}