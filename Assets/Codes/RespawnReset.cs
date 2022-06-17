﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnReset : MonoBehaviour
{
    [SerializeField] public Transform Player;
    [SerializeField] public Transform RespawnPoint;


    void OnTriggerEnter(Collider other)
    {
       Player.transform.position = RespawnPoint.transform.position;

    }
}
