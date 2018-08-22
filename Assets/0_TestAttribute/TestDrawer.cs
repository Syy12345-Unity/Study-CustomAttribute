using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(TestAttribute))]
public class TestDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.LabelField(position, label);
        position.x += 50;
        EditorGUI.LabelField(position, "Test");
        position.x += 50;
        EditorGUI.LabelField(position, label);
    }
}
