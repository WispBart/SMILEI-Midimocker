using System;
using System.Collections;
using System.Collections.Generic;
using SMILEI.Core;
using SMILEI.MidiMocker;
using UnityEngine;

namespace SMILEI.MidiMocker
{
    [Serializable]
    public class MidiEmotionMixer : IEmotionMixer
    {
        public MidiDevice MidiDevice;
        public int Knob;

        public void StartRecording()
        {
            throw new NotImplementedException();
        }

        public Emotion StopRecording()
        {
            throw new NotImplementedException();
        }

        public Emotion GetRawValue()
        {
            return MidiDevice == null
                ? new Emotion(0f, 0f)
                : new Emotion(MidiDevice.GetValueForKnob(Knob), 1f);
        }
    }
}
