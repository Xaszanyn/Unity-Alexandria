using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Text : MonoBehaviour
{
    [SerializeField] InputRecognizer IR;

    // Update is called once per frame
    void Update()
    {
        if(IR.isPressed) {
            GetComponent<UnityEngine.UI.Text>().text = ">-PRESSED-<";
            Invoke("Reset", 0.75F);
        }
    }
    void Reset() {
        GetComponent<UnityEngine.UI.Text>().text = "<-NOT PRESSED->";
    }
}
