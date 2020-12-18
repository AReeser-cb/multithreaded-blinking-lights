﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultithreadedBlinkingLights
{
    public class LightHardwareSource: ILightHardwareSource
    {
        public int GetNumberOfAvailableDiodes()
        {
            return CONSTANTS.NUM_AVAIL_DIODES_TEST;
        }

        private string[] _flavoredAmps = new string[CONSTANTS.NUM_AVAIL_DIODES_TEST];

        public void IncreaseAmperage(int i, string flavor)
        {
            _flavoredAmps[i] = "█";
        }

        public void ReduceAmperage(int i)
        {
            _flavoredAmps[i] = ".";
        }

        public string[] FlavoredAmperage()
        {
            return _flavoredAmps;
        }
    }
}