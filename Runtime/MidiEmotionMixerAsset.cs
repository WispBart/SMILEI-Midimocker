using System;
using SMILEI.Core;
using UnityEngine;

namespace SMILEI.MidiMocker
{
    /// <summary>
    /// Passes through a single midi channel.
    /// </summary>
    [CreateAssetMenu(menuName = "SMILEI/MidiMocker/MidiEmotionMixerAsset")]
    public class MidiEmotionMixerAsset : EmotionMixerAsset
    {
        public override IEmotionMixer Implementation => MidiEmotionMixer;
        public MidiEmotionMixer MidiEmotionMixer;
    }
}

