using UnityEngine;

public class ArgAttribute : PropertyAttribute
{
    public string Arg;

    public ArgAttribute(string arg)
    {
        this.Arg = arg;
    }
}
