using UnityEditor;
using UnityEngine;

namespace ScriptableFlow.Editor.Helpers
{
    internal static class EditorGUIStatics
    {
        public static readonly Color s_darkBackgroundColor = new(0.1f, 0.1f, 0.1f);
        public static readonly GUIStyle s_headerTextStyle = new(EditorStyles.boldLabel) { alignment = TextAnchor.MiddleCenter };
    }
}