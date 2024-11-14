#if UNITY_EDITOR
using System;
using DJM.Utilities.Debugging;
using DJM.Utilities.Settings;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    [FilePath(PathUtils.AssetPathProjectSettings + nameof(CustomGizmosSettings), FilePathAttribute.Location.ProjectFolder)]
    internal sealed class CustomGizmosSettings : ScriptableSingleton<CustomGizmosSettings>
    {
        [SerializeField] private SignedAxis defaultRightAxis = SignedAxis.PositiveX;
        [SerializeField] private SignedAxis defaultUpAxis = SignedAxis.PositiveY;
        [SerializeField] private float defaultForwardDepth = 0f;
        [SerializeField] private RectPivot defaultPivot = RectPivot.Center;
        
        public static SignedAxis DefaultRightAxis
        {
            get => instance.defaultRightAxis;
            set
            {
                if(instance.defaultRightAxis == value) return;
                instance.defaultRightAxis = value;
                ValidateUpAxis(instance.defaultRightAxis, ref instance.defaultUpAxis);
                instance.Save(true);
            }
        }
        
        public static SignedAxis DefaultUpAxis
        {
            get => instance.defaultUpAxis;
            set
            {
                if(instance.defaultUpAxis == value) return;
                instance.defaultUpAxis = value;
                ValidateRightAxis(instance.defaultUpAxis, ref instance.defaultRightAxis);
                instance.Save(true);
            }
        }

        public static SignedAxis DefaultForwardAxis
        {
            get
            {
                var forward = Vector3.Cross
                (
                    instance.defaultRightAxis.GetDirection(), 
                    instance.defaultUpAxis.GetDirection()
                ).normalized;
                
                if(forward.x > 0.9f) return SignedAxis.PositiveX;
                if(forward.y > 0.9f) return SignedAxis.PositiveY;
                if(forward.z > 0.9f) return SignedAxis.PositiveZ;
                
                if(forward.x < -0.9f) return SignedAxis.NegativeX;
                if(forward.y < -0.9f) return SignedAxis.NegativeY;
                if(forward.z < -0.9f) return SignedAxis.NegativeZ;
                
                DebugUtils.LogError("Could not determine default forward axis, returning PositiveZ");
                return SignedAxis.PositiveZ;
            }
        }
        
        public static float DefaultForwardDepth
        {
            get => instance.defaultForwardDepth;
            set
            {
                if(Mathf.Approximately(instance.defaultForwardDepth, value)) return;
                instance.defaultForwardDepth = value;
                instance.Save(true);
            }
        }
        
        public static RectPivot DefaultPivot
        {
            get => instance.defaultPivot;
            set
            {
                if(instance.defaultPivot == value) return;
                instance.defaultPivot = value;
                instance.Save(true);
            }
        }
        
        private void OnEnable() => Initialize();
        private void Awake() => Initialize();
        
        private void Initialize()
        {
            if (CustomGizmoUtils.AreAxesValid(defaultRightAxis, defaultUpAxis)) return;
            ValidateUpAxis(defaultRightAxis, ref defaultUpAxis);
            instance.Save(true);
        }
        
        private static void ValidateUpAxis(in SignedAxis right, ref SignedAxis up)
        {
            if(CustomGizmoUtils.AreAxesValid(right, up)) return;

            up = right.GetUnsignedAxis() switch
            {
                Axis.X => SignedAxis.PositiveY,
                Axis.Y => SignedAxis.PositiveZ,
                Axis.Z => SignedAxis.PositiveX,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        
        private static void ValidateRightAxis(in SignedAxis up, ref SignedAxis right)
        {
            if(CustomGizmoUtils.AreAxesValid(right, up)) return;

            right = up.GetUnsignedAxis() switch
            {
                Axis.X => SignedAxis.PositiveY,
                Axis.Y => SignedAxis.PositiveZ,
                Axis.Z => SignedAxis.PositiveX,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
#endif