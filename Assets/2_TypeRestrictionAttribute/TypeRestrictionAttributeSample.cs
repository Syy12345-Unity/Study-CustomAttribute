using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeRestrictionAttributeSample : MonoBehaviour {
    // [TypeRestriction] its error
    public int hoge;
    
    public TestSample hogeClass;
}

[TypeRestriction,Serializable]
public class TestSample
{
    
}
