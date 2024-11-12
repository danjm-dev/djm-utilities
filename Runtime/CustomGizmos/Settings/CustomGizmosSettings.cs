#if UNITY_EDITOR
using DJM.Utilities.Settings;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    [FilePath(PathUtils.AssetPathProjectSettings + nameof(CustomGizmosSettings), FilePathAttribute.Location.ProjectFolder)]
    internal sealed class CustomGizmosSettings : ScriptableSingleton<CustomGizmosSettings>
    {
        [SerializeField] private AxisAlignedPlane defaultPlane = AxisAlignedPlane.XY;
        [SerializeField] private float defaultPositionDepth = 0f;
        
        private void Reset()
        {
            defaultPlane = AxisAlignedPlane.XY;
            defaultPositionDepth = 0f;
        }
        
        public static AxisAlignedPlane DefaultPlane
        {
            get => instance.defaultPlane;
            set
            {
                instance.defaultPlane = value;
                instance.Save(true);
            }
        }
        
        public static float DefaultPositionDepth
        {
            get => instance.defaultPositionDepth;
            set
            {
                instance.defaultPositionDepth = value;
                instance.Save(true);
            }
        }
    }
}
#endif