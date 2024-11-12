using DJM.Utilities.Settings;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.CustomGizmos
{
    internal sealed class CustomGizmosSettingsProvider : SettingsProvider
    {
        private const string Name = "Custom Gizmos";
        private const string Path = PathUtils.ProjectSettingsHierarchyPathPrefix + Name;

        private CustomGizmosSettingsProvider(string path, SettingsScope scopes) : base(path, scopes) { }
        
        public override void OnGUI(string searchContext)
        {
            base.OnGUI(searchContext);
            
            var serializedObject = new SerializedObject(CustomGizmosSettings.instance);
            var defaultPlaneProperty = serializedObject.FindProperty("defaultPlane");
            var defaultPositionDepthProperty = serializedObject.FindProperty("defaultPositionDepth");

            EditorGUILayout.Space();
            
            EditorGUILayout.PropertyField(defaultPlaneProperty);
            EditorGUILayout.PropertyField(defaultPositionDepthProperty);

            if(!serializedObject.hasModifiedProperties) return;
            serializedObject.ApplyModifiedProperties();
        }
        
        [SettingsProvider]
        private static SettingsProvider CreateSceneToolsSettingsProvider()
        {
            var provider = new CustomGizmosSettingsProvider(Path, SettingsScope.Project);
            return provider;
        }
    }
}