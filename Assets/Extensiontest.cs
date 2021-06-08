using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionMethods;

public class Extensiontest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string s = "Hello Extension";
        float f = 1.25f;
        int i = s.WordCount();
        string floatString = f.MaxValueString();
        Debug.Log(i + " " + floatString);
    }
}
