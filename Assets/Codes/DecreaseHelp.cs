using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DecreaseHelp : MonoBehaviour
{
    [SerializeField] public GameObject karakter;
    [SerializeField] private int Damage;

    [SerializeField] private HealthSystem healthController;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("çalışmıyor");
        if (collision.CompareTag("Play"))
            {
            decraseHeart();
        }
    }
    void start()
    {
       
    }
    void decraseHeart()
    {
        healthController.playerHeart = healthController.playerHeart - Damage;
        healthController.UpdateHealth();
        karakter.transform.position = new Vector3(1, 1, -1);
    }
}
