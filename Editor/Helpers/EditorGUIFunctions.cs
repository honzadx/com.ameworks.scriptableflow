using UnityEditor;

namespace ScriptableFlow.Editor.Helpers
{
    public static class EditorGUIFunctions
    {
        public static void DrawHeaderText(string text)
        {
            var rect = EditorGUILayout.BeginVertical();
            EditorGUI.DrawRect(rect, EditorGUIStatics.s_darkBackgroundColor);
            EditorGUILayout.LabelField(text, EditorGUIStatics.s_headerTextStyle);
            EditorGUILayout.EndVertical();
        }
    }
}