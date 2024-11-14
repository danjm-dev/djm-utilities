#if UNITY_EDITOR
using System;
using DJM.Utilities.Settings;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    [FilePath(PathUtils.AssetPathProjectSettings + nameof(CustomGizmosSettings), FilePathAttribute.Location.ProjectFolder)]
    internal sealed class CustomGizmosSettings : ScriptableSingleton<CustomGizmosSettings>
    {
        [SerializeField] private SignedAxis defaultRightAxis = SignedAxis.PositiveX;
        [SerializeField] private SignedAxis defaultUpAxis = SignedAxis.PositiveY;
        [SerializeField] private float defaultForwardDepth = 0f;
        
        [SerializeField] private AxisAlignedPlane defaultPlane = AxisAlignedPlane.XY;
        


        
        public static SignedAxis DefaultRightAxis
        {
            get => instance.defaultRightAxis;
            set
            {
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
                instance.defaultUpAxis = value;
                ValidateRightAxis(instance.defaultUpAxis, ref instance.defaultRightAxis);
                instance.Save(true);
            }
        }

        public static float DefaultForwardDepth
        {
            get => instance.defaultForwardDepth;
            set
            {
                instance.defaultForwardDepth = value;
                instance.Save(true);
            }
        }
        
        [Obsolete]
        public static AxisAlignedPlane DefaultPlane
        {
            get => instance.defaultPlane;
            set
            {
                instance.defaultPlane = value;
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