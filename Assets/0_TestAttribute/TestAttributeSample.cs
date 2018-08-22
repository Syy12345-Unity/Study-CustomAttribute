using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttributeSample : MonoBehaviour {
    [Test]
    int hoge;
    [TestAttribute]
    int fuga;
}
