using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class Restart : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Start()
    {
        SceneManager.LoadScene("menu");
        
    }

    private void Awake()
    {
       
    }

    void Ads()
    {
       
    }


  
}

