﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {



    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
       

            player.GetComponent<PLAYEREASY>().score++;
            Destroy(other.gameObject);

        
    }
    }
