using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Scriptable S;

    void Start()
    {
        GetComponent<MeshRenderer>().material = S.material;
    }
}
