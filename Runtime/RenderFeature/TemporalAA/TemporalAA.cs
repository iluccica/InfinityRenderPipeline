﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InfinityTech.Runtime.Rendering.Feature
{
    public class HaltonSequence
    {
        public static float Get(int index, int radix)
        {
            float result = 0f;
            float fraction = 1f / radix;

            while (index > 0) {
                result += (index % radix) * fraction;

                index /= radix;
                fraction /= radix;
            }

            return result;
        }
    }

    public class TemporalAA 
    {

    }
}
