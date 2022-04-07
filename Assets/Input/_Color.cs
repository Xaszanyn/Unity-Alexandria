using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Color : MonoBehaviour
{
    [SerializeField] InputRecognizer IR;
    Color C;
    int mod;
    void Update()
    {
        C = GetComponent<MeshRenderer>().material.color;

        if(mod == 0) {
            GetComponent<MeshRenderer>().material.color = Color.Lerp(C, Color.green, 0.2F);
        } else if(mod == 1) {
            GetComponent<MeshRenderer>().material.color = Color.Lerp(C, Color.white, 0.2F);
        } else if(mod == 2) {
            GetComponent<MeshRenderer>().material.color = Color.Lerp(C, Color.cyan, 0.2F);
        } else if(mod == 3) {
            GetComponent<MeshRenderer>().material.color = Color.Lerp(C, Color.black, 0.2F);
        } else if(mod == 4) {
            GetComponent<MeshRenderer>().material.color = Color.Lerp(C, Color.red, 0.2F);
        }
        

        if(IR.isDragging) {
            GetComponent<MeshRenderer>().material.color = new Color(0, 0.6F, 0);
        }

        if(IR.swipeMode == 1) {
            mod = 1;
            Invoke("Reset", 2);
        } else if(IR.swipeMode == 2) {
            mod = 2;
            Invoke("Reset", 2);
        } else if(IR.swipeMode == 3) {
            mod = 3;
            Invoke("Reset", 2);
        } else if(IR.swipeMode == 4) {
            mod = 4;
            Invoke("Reset", 2);
        }
    }

    void Reset() {
        mod = 0;
    }
}
