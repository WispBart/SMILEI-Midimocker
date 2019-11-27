using System;
using SMILEI.Core;
using UnityEngine;

namespace SMILEI.MidiMocker
{
    /// <summary>
    /// Passes through a single midi channel.
    /// </summary>
    [CreateAssetMenu(menuName = "SMILEI/MidiMocker/MidiMixer")]
    public class MidiEmixerAsset : EMixerAsset
    {
        public override IEMixer Implementation => Mixer;
        public MidiEmixer Mixer;
    }

    [Serializable] public class MidiEmixer : IEMixer
    {
        public MidiDevice Device;
        public int Knob;

        public void StartRecording()
        {
            throw new System.NotImplementedException();
        }

        public EValue StopRecording()
        {
            throw new System.NotImplementedException();
        }

        public EValue GetRawValue()
        {
            return Device == null
                ? new EValue()
                {
                    Confidence = 0f,
                    Value = 0f,
                }
                : new EValue()
                {
                    Confidence = 1f,
                    Value = Device.GetValueForKnob(Knob)
                };
        }
    }
}

