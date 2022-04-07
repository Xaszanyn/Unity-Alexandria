using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour
{
    Rigidbody RB;
    [SerializeField] int speed;
    [SerializeField] int jumpSpeed;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.A)) {
        //     Debug.Log("AADDD");
        //     RB.AddForce(new Vector3(-speed, RB.velocity.y, RB.velocity.z));
        // }

        // if(Input.anyKeyDown) Debug.Log("A");
    }
}
