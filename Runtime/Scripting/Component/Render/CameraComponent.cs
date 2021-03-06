﻿using UnityEngine;
using Unity.Collections;
using InfinityTech.Runtime.Core.Geometry;

namespace InfinityTech.Runtime.Component
{
    [ExecuteAlways]
    [RequireComponent(typeof(Camera))]
    [AddComponentMenu("InfinityRender/CameraComponent")]
    public class CameraComponent : EntityComponent
    {
        public Camera UnityCamera;
        public Plane[] FrustumPlane;
        public NativeArray<FPlane> ViewFrustum;

        // Function
        public CameraComponent() : base()
        {

        }

        protected override void OnRigister()
        {
            base.OnRigister();
            GetWorld().AddWorldView(this);

            UnityCamera = GetComponent<Camera>();
            ViewFrustum = new NativeArray<FPlane>(6, Allocator.Persistent);
        }

        protected override void EventPlay()
        {
            base.EventPlay();
        }

        protected override void EventTick()
        {
            base.EventTick();
        }

        protected override void OnTransformChange()
        {
            base.OnTransformChange();

            FrustumPlane = GeometryUtility.CalculateFrustumPlanes(UnityCamera);
            for (int PlaneIndex = 0; PlaneIndex < 6; PlaneIndex++)
            {
                ViewFrustum[PlaneIndex] = FrustumPlane[PlaneIndex];
            }
        }

        protected override void UnRigister()
        {
            GetWorld().RemoveWorldView(this);

            ViewFrustum.Dispose();
        }
    }
}
