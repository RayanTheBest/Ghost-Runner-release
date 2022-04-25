using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easy : MonoBehaviour
{
    public GameObject player;

    public float speed;
    public GameObject effect;

    public GameObject explosionSound;
    void Update()
    {


       

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

           
                Instantiate(explosionSound, transform.position, Quaternion.identity);

                other.GetComponent<PLAYEREASY>().curentHealth--;
                other.GetComponent<PLAYEREASY>().camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                Destroy(gameObject);

            
           
                


        }

        if (other.CompareTag("Bullet"))
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

 
    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
 
}


