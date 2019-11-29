using System;
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
        public MidiChannel MidiChannel;

        public float PollInterval;
        public int[] KnobsInUse;

        public float GetValueForKnob(int knob)
        {
            return MidiMaster.GetKnob(MidiChannel, knob);
        }

        public bool IsKnobUsed(int knob)
        {
            return KnobsInUse.Contains(knob);
        }

    }
}