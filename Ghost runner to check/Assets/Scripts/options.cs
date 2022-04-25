using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class options : MonoBehaviour
{

    public GameObject Restarte;





    public void Restart()
    {
        SceneManager.LoadScene("Game");

       
    }


    public void menu()
    {
        SceneManager.LoadScene("menu");
    }


}
