using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyManger : MonoBehaviour
{
    public bool pressedSecond = false;


    private void OnTriggerEnter2D(Collider2D other)
    { 
       if(pressedSecond == true)
        {
           
                Destroy(other.gameObject);
            

        }
    
    }


}
