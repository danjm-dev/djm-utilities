using System.IO;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.Internal.ToolsMenu
{
    internal static class PersistentDataPathTools
    {
        public const string PathRoot = "Tools/DJM/Persistent Data Path/";
        
        [MenuItem(PathRoot + "Open", false, 200)]
        private static void OpenPersistentDataPath()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
        }

        [MenuItem(PathRoot + "Clear", false, 200)]
        private static void ClearPersistentDataPath()
        {
            if (!EditorUtility.DisplayDialog("Clear Persistent Data Path", "Are you sure you want to permanently clear the persistent data path?", "Clear", "Cancel")) return;
            var di = new DirectoryInfo(Application.persistentDataPath);
            foreach (var file in di.GetFiles()) file.Delete();
            foreach (var dir in di.GetDirectories()) dir.Delete(true);
        }
    }
}