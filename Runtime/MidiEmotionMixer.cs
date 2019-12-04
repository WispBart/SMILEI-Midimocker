using System;
using SMILEI.Core;

namespace SMILEI.MidiMocker
{
    [Serializable]
    public class MidiEmotionMixer : IEmotionMixer
    {
        public MidiDevice MidiDevice;
        public int Knob;

        public Emotion GetValue()
        {
            return MidiDevice == null
                ? new Emotion(0f, 0f)
                : new Emotion(MidiDevice.GetValueForKnob(Knob), 1f);
        }
        
    }
}
