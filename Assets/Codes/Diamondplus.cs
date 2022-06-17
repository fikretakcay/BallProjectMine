using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamondplus : MonoBehaviour
{
    int puan = 0;
    public Text puandeger;
    public GameObject karakter;
    public GameObject FinisPoint;
    public Image NextLevel;
    public Transform effect;
    void Start()
    {
        effect.GetComponent<ParticleSystem>().Stop();
    }
     void OnCollisionEnter(Collision carpma) //carpma gerceklestiği anda
    {
        if (carpma.gameObject.name == "elmas")
        {
            effect.GetComponent<ParticleSystem>().Play();
            Destroy(carpma.gameObject);
            puan++;
            puandeger.text = " " + puan;
            effect.transform.position = carpma.transform.position;
            

        }
        if (puan >=5 && carpma.gameObject.name == "FinishCube")
        {
            NextLevel.gameObject.SetActive(true);
            karakter.gameObject.SetActive(false);
        }


    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
