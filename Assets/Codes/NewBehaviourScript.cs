using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.V))
            rb.WakeUp();
        else if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0, 200f, 0));
        else if (Input.GetKeyDown(KeyCode.W))
            rb.AddForce(new Vector3(0, 0, 175f));
        else if (Input.GetKeyDown(KeyCode.A))
            rb.AddForce(new Vector3(-150f, 0, 0));
        else if (Input.GetKeyDown(KeyCode.Q))
            rb.AddForce(new Vector3(-150f, 200f, 0));
        else if (Input.GetKeyDown(KeyCode.E))
            rb.AddForce(new Vector3(150f, 200f, 0));
        else if (Input.GetKeyDown(KeyCode.D))
            rb.AddForce(new Vector3(150f, 0, 0));
        else if (Input.GetKeyDown(KeyCode.S))
            rb.AddForce(new Vector3(0, 0, -175f));
    }
}
