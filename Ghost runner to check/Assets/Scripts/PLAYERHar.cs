using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class PLAYERHar : MonoBehaviour
{
    public GameObject Player;

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    private Vector2 targetPos;

    private int health;

    public GameObject Restart = null;

    public GameObject moveEffect;
    public Animator camAnim;
    public Text healthDisplay;

    public GameObject spawner;
    public GameObject restartDisplay;

    private void Update()
    {




        if (health <= 0)
        {
            Player.SetActive(false);

            Restart.SetActive(true);

        }





        if (health <= 0)
        {
            spawner.SetActive(false);

            restartDisplay.SetActive(true);



        }

        healthDisplay.text = health.ToString();



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

}



