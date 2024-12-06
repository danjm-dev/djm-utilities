using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.Internal.Serialization.Interfaces
{
    internal static class InterfaceReferenceUtils
    {
        private static GUIStyle LabelStyle => new(EditorStyles.label) 
        {
            font = EditorStyles.objectField.font,
            fontSize = EditorStyles.objectField.fontSize,
            fontStyle = EditorStyles.objectField.fontStyle,
            alignment = TextAnchor.MiddleRight,
            padding = new RectOffset(0, 2, 0, 0)
        };

        public static void OnGUI(Rect position, SerializedProperty property, GUIContent label, InterfaceArguments arguments) 
        {
            var controlID = GUIUtility.GetControlID(FocusType.Passive) - 1;
            var isHovering = position.Contains(Event.current.mousePosition);
            var displayString = property.objectReferenceValue == null || isHovering 
                ? $"({arguments.InterfaceType.Name})" 
                : "*";
            DrawInterfaceNameLabel(position, displayString, controlID);
        }

        private static void DrawInterfaceNameLabel(Rect position, string displayString, int controlID)
        {
            const int additionalLeftWidth = 3;
            const int verticalIndent = 1;
            
            if (Event.current.type != EventType.Repaint) return;
            
            var content = EditorGUIUtility.TrTextContent(displayString);
            var size = LabelStyle.CalcSize(content);
            var labelPos = position;
            
            labelPos.width = size.x + additionalLeftWidth;
            labelPos.x += position.width - labelPos.width - 18;
            labelPos.height -= verticalIndent * 2;
            labelPos.y += verticalIndent;
            
            LabelStyle.Draw
            (
                labelPos, 
                EditorGUIUtility.TrTextContent(displayString), 
                controlID, 
                DragAndDrop.activeControlID == controlID, 
                false
            );
        }
    }
}