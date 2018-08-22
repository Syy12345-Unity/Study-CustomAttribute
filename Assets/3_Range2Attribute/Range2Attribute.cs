using UnityEngine;

public class Range2Attribute : PropertyAttribute
{
    public int Min, Max;
    public Range2Attribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}
