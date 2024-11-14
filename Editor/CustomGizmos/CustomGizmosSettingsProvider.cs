using DJM.Utilities.CustomGizmos;
using DJM.Utilities.Settings;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.CustomGizmos
{
    internal sealed class CustomGizmosSettingsProvider : SettingsProvider
    {
        private const string Path = PathUtils.ProjectSettingsHierarchyPathRoot + "Custom Gizmos";

        private CustomGizmosSettingsProvider(string path, SettingsScope scopes) : base(path, scopes) { }
        
        public override void OnGUI(string searchContext)
        {
            base.OnGUI(searchContext);
            
            using var serializedObject = new SerializedObject(CustomGizmosSettings.instance);
            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField(new GUIContent("2D Gizmos"), EditorStyles.boldLabel);

            
            var defaultRightAxisProperty = serializedObject.FindProperty("defaultRightAxis");
            CustomGizmosSettings.DefaultRightAxis = (SignedAxis)EditorGUILayout.EnumPopup
            (
                new GUIContent(defaultRightAxisProperty.displayName), 
                CustomGizmosSettings.DefaultRightAxis, 
                EditorStyles.popup
            );
            
            var defaultUpAxisProperty = serializedObject.FindProperty("defaultUpAxis");
            CustomGizmosSettings.DefaultUpAxis = (SignedAxis)EditorGUILayout.EnumPopup
            (
                new GUIContent(defaultUpAxisProperty.displayName), 
                CustomGizmosSettings.DefaultUpAxis, 
                EditorStyles.popup
            );
            
            // var defaultPlaneProperty = serializedObject.FindProperty("defaultPlane");
            // CustomGizmosSettings.DefaultPlane = (AxisAlignedPlane)EditorGUILayout.EnumPopup
            // (
            //     new GUIContent(defaultPlaneProperty.displayName), 
            //     CustomGizmosSettings.DefaultPlane, 
            //     EditorStyles.popup
            // );
            
            
            var defaultPositionDepthProperty = serializedObject.FindProperty("defaultForwardDepth");
            CustomGizmosSettings.DefaultForwardDepth = EditorGUILayout.FloatField
            (
                new GUIContent(defaultPositionDepthProperty.displayName), 
                CustomGizmosSettings.DefaultForwardDepth, 
                EditorStyles.numberField
            );
        }
        
        [SettingsProvider]
        private static SettingsProvider CreateSceneToolsSettingsProvider()
        {
            var provider = new CustomGizmosSettingsProvider(Path, SettingsScope.Project);
            return provider;
        }
    }
}