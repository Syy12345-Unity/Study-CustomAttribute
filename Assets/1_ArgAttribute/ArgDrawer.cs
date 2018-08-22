using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ArgAttribute))]
public class ArgDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var cast = (ArgAttribute) attribute;
        EditorGUI.LabelField(position, $"Arg {cast.Arg}");
    }
}
