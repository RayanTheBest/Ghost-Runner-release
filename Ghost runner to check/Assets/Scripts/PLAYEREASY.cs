using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class PLAYEREASY : MonoBehaviour, IUnityAdsListener
{
    public GameObject Player;

    public GameObject PlayerIcon;
    public GameObject mainMenu;


    public GameObject destroyManager;

 
    public GameObject Obstacle;

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    private Vector2 targetPos;

    public int curentHealth = 3;

    public GameObject Restart = null;

    public GameObject moveEffect;
    public Animator camAnim;
    public Text healthDisplay;

    public GameObject spawner;
    public GameObject restartDisplay;


    public GameObject ScoreDisGameobject;
    public GameObject healthDisGameobject;

 

    private void Update()
    {
        healthDisplay.text = curentHealth.ToString();


        scoreDisplay.text = score.ToString();


     



        if (curentHealth <= 0)
        {
            Player.SetActive(false);

            Restart.SetActive(true);

            spawner.SetActive(false);

          
        }

            





        if (Input.touchCount > 0)
        {
            // The screen has been touched so store the touch
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                // If the finger is on the screen, move the object smoothly to the touch position

                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
                touchPosition.x = transform.position.x;
                if (touchPosition.y < maxY && touchPosition.y > minY)
                    transform.position = Vector3.Lerp(transform.position, touchPosition, 90 * Time.deltaTime);
            }

        }
    }



    public void disableHealthDisplay()
    {
        Player.GetComponent<PLAYEREASY>().restartDisplay.SetActive(false);

     
    }








    public GameObject scoreManager;

    public int score;
    public Text scoreDisplay;

  

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }












    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {

        Player.SetActive(true);

        disableDeathScreen();

        curentHealth++;




        addHealth();



        StartCoroutine(Text());
        




        // Load another ad:
        Advertisement.Initialize("4580601");

    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsReady(string placementId)
    {

    }

    private void Start()
    {
       
        Advertisement.Initialize("4580601");
        Advertisement.AddListener(this);
    }


    public void playRewardedAd()
    {
        

        


        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.Log("Rewarded ad is not ready");
        }
    }



    public void addHealth()
    {
      

        spawner.SetActive(true);
        

    }

    public void disableDeathScreen()
    {
       
        restartDisplay.SetActive(false);
    }




    IEnumerator Text()  //  <-  its a standalone method
    {
        destroyManager.GetComponent<destroyManger>().pressedSecond = true;
        yield return new WaitForSeconds(2);
        destroyManager.GetComponent<destroyManger>().pressedSecond = false;
    }




















    public GameObject Icon;
    

    public float timebtwspawns;



    public void restart()
    {
        
        Player.SetActive(true);
        spawner.SetActive(true);
        curentHealth = 3;
        restartDisplay.SetActive(false);
        score = 0;
       spawner.GetComponent<Spawner>().startTimeBtwSpawns = timebtwspawns;


        ScoreDisGameobject.SetActive(true);
        healthDisGameobject.SetActive(true);

        StartCoroutine(Text());
        mainMenu.SetActive(false);
        Icon.SetActive(false);

        restartDisplay.SetActive(false);

        ScoreDisGameobject.SetActive(true);
        healthDisGameobject.SetActive(true);

    }

  


    public void menu()
    {
        Player.SetActive(false);
        spawner.SetActive (false);

        mainMenu.SetActive(true);
        PlayerIcon.SetActive(true);
        ScoreDisGameobject.SetActive(false);
        healthDisGameobject.SetActive(false);
        restartDisplay.SetActive(false);
    }


}



