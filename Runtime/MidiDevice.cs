using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MidiJack;
using UnityEngine;

namespace SMILEI.MidiMocker
{
    /// <summary>
    /// Represents a connected MidiDevice.
    /// </summary>
    [CreateAssetMenu(menuName = "SMILEI/MidiMocker/MidiDevice")]
    public class MidiDevice : ScriptableObject
    {
        /// <summary> The channel this midi device is using </summary>
        public MidiChannel MidiChannel;

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