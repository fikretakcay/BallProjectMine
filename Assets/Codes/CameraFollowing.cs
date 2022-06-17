using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    Vector3 mesafe;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
        mesafe = transform.position - character.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mesafe + character.transform.position;

    }
}
