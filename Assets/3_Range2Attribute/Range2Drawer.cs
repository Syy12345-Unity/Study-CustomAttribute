using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Range2Attribute))]
public class Range2Drawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if(property.propertyType == SerializedPropertyType.Integer)
        {
            var cast = (Range2Attribute)attribute;
            //property.intValue = EditorGUI.IntSlider(position, property.intValue, cast.Min, cast.Max);
            EditorGUI.IntSlider(position, property, cast.Min, cast.Max, label);
        }
        
    }
}
