using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(TypeRestrictionAttribute))]
public class TypeRestrictionDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var cast = (TypeRestrictionAttribute) attribute;
        EditorGUI.LabelField(position, $"Name={label.text}, attribute={cast.GetType()}");
    }
}
