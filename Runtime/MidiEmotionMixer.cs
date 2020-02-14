using System;
using SMILEI.Core;
using UnityEngine;

namespace SMILEI.MidiMocker
{
    /// <summary>
    /// Reads an emotion from a knob on a mididevice.
    /// </summary>
    [Serializable] public class MidiEmotionMixer : IEmotionMixer
    {
        [Tooltip("An asset with the settings for a midi channel")]
        public MidiDevice MidiDevice;
        [Tooltip("The knob this mixer should read from.")]
        public int Knob;

        public Emotion GetValue()
        {
            return MidiDevice == null
                ? new Emotion(0f, 0f)
                : new Emotion(MidiDevice.GetValueForKnob(Knob), 1f);
        }
        
    }
}
