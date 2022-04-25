using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   
    private void Awake()
    {
        
    }

    public void playgame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
