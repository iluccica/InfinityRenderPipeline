﻿using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace InfinityTech.Runtime.Rendering.PostProcess
{
    [Serializable, VolumeComponentMenu("RayTracing/RTAO")]
    public class RayTraceAmbientOcclusion : VolumeComponent
    {
        [Header("Tracing Property")]
        public ClampedFloatParameter Radius = new ClampedFloatParameter(5, 5, 10);
        public ClampedIntParameter NumRays = new ClampedIntParameter(2, 1, 32);
    }
}
