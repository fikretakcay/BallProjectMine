using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneButtonCheck : MonoBehaviour
{
    public Image image;
    
    void Start()
    {
        image.gameObject.SetActive(false);
    }
    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }
    public void GameScene()
    {
        
        SceneManager.LoadScene(1);
    }

    public void HelpScene()
    {
        SceneManager.LoadScene(2);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
