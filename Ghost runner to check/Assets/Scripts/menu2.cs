using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class menu2 : MonoBehaviour
{

  


    private void Awake()
    {
     
     
    }


  

    private void Start()
    {
        
    }

    public void playgame()
    {
        SceneManager.LoadScene("Fard");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


    public void Save()
    {
     
    }
}
