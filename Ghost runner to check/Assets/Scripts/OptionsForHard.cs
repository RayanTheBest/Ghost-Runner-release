using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsForHard : MonoBehaviour
{




    public GameObject Restarte;




    public void Awake()
    {
        Restarte.SetActive(false);

    }


    public void Restart()
    {
        SceneManager.LoadScene("Fard");


    }


    public void menu()
    {
        SceneManager.LoadScene("Hardcore");
    }


}
