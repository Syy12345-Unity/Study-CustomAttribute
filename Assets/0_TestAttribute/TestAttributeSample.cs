using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttributeSample : MonoBehaviour {
    [Test]
    public int hoge;
    [TestAttribute]
    public int fuga;
}
