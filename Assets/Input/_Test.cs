using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Test : MonoBehaviour
{
    float timePassed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timePassed);
        if(Input.GetMouseButton(0)) {
            timePassed += Time.deltaTime;
            
        }

        if(Input.GetMouseButtonUp(0)) {
            timePassed = 0;
        }
    }
}
