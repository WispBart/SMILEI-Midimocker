using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MidiJack;
using UnityEngine;

namespace SMILEI.MidiMocker
{
    [CreateAssetMenu(menuName = "SMILEI/MidiMocker/MidiDevice")]
    public class MidiDevice : ScriptableObject
    {
        public MidiChannel Channel;

        public float PollInterval;
        public int[] KnobsInUse;

        private int _recordingClients;
        private bool _recording;
        
        public void StartRecording()
        {
            
        }

        public float GetValueForKnob(int knob)
        {
            return MidiMaster.GetKnob(Channel, knob);
        }

        public bool IsKnobUsed(int knob)
        {
            return KnobsInUse.Contains(knob);
        }

    }
}