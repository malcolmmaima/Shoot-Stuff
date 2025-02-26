﻿using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //if the object that triggered the event is tagged player
        if (other.tag == "Player")
        {

            Debug.Break();
            return;
        }
        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

}