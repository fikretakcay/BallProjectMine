using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int playerHeart;
    [SerializeField] public GameObject karakter;
    //[SerializeField] public Transform Player;
    //[SerializeField] public Transform RespawnPoint;
    [SerializeField] private Image[] hearts;
    [SerializeField] private Image GameOver;
    //[SerializeField] private Image GameOver;


    public void Start()
    {
        GameOver.gameObject.SetActive(false);
        //GameOver.enabled = false;
        UpdateHealth();
        
    }

    public void UpdateHealth()
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            if(playerHeart <= 0)
            {
                karakter.gameObject.SetActive(false);
                GameOver.gameObject.SetActive(true);
                
            }

            if (i < playerHeart)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }
    //public void OnTriggerEnter(Collider other)
    //{
    //    Player.transform.position = RespawnPoint.transform.position;
    //}
    
}
