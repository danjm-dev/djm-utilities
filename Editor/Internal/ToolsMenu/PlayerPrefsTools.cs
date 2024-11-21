using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.Internal.ToolsMenu
{
    internal static class PlayerPrefsTools
    {
        public const string PathRoot = "Tools/DJM/Player Prefs/";
        
        [MenuItem(PathRoot + "Clear", false, 200)]
        private static void ClearPlayerPrefs()
        {
            if (!EditorUtility.DisplayDialog("Clear Player Prefs", "Are you sure you want to permanently clear Player Prefs?", "Clear", "Cancel")) return;
            PlayerPrefs.DeleteAll();
        }
    }
}