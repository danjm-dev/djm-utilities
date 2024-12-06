using DJM.Utilities.EditorTools.Gizmos;
using DJM.Utilities.Internal;
using DJM.Utilities.Math;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.Internal.CustomGizmos
{
    internal sealed class CustomGizmosSettingsProvider : SettingsProvider
    {
        private const string Path = PathUtils.ProjectSettingsMenuPathRoot + "Custom Gizmos";

        private CustomGizmosSettingsProvider(string path, SettingsScope scopes) : base(path, scopes) { }
        
        public override void OnGUI(string searchContext)
        {
            base.OnGUI(searchContext);
            
            using var serializedObject = new SerializedObject(CustomGizmosSettings.instance);
            
            EditorGUILayout.Space();
            
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
            
            EditorGUILayout.LabelField
            (
                new GUIContent("Default Forward Axis"), 
                new GUIContent(CustomGizmosSettings.DefaultForwardAxis.ToString()), 
                EditorStyles.label
            );
            
            
            
            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField(new GUIContent("2D Gizmos"), EditorStyles.boldLabel);
            
            var defaultPositionDepthProperty = serializedObject.FindProperty("default2dDepth");
            CustomGizmosSettings.Default2dDepth = EditorGUILayout.FloatField
            (
                new GUIContent(defaultPositionDepthProperty.displayName), 
                CustomGizmosSettings.Default2dDepth, 
                EditorStyles.numberField
            );
            
            
            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField(new GUIContent("Rects and Cubes"), EditorStyles.boldLabel);
            
            var defaultPivotProperty = serializedObject.FindProperty("defaultPivot");
            CustomGizmosSettings.DefaultPivot = (RectPivot)EditorGUILayout.EnumPopup
            (
                new GUIContent(defaultPivotProperty.displayName), 
                CustomGizmosSettings.DefaultPivot, 
                EditorStyles.popup
            );
            

            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField(new GUIContent("Bezier Curves"), EditorStyles.boldLabel);
            
            var defaultBezierCurveSegmentResolutionProperty = serializedObject.FindProperty("defaultBezierCurveSegmentResolution");
            CustomGizmosSettings.DefaultBezierCurveSegmentResolution = EditorGUILayout.IntField
            (
                new GUIContent(defaultBezierCurveSegmentResolutionProperty.displayName), 
                CustomGizmosSettings.DefaultBezierCurveSegmentResolution, 
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