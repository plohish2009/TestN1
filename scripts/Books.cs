using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class Books : MonoBehaviour
{
    public GameObject[] GObject;
    public int counter = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
   {
        GObject = GameObject.FindGameObjectsWithTag("door");

        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            counter++;
            Debug.Log(counter);
            if (counter == 1)
            {
                Destroy(GObject[0]);
            }
        }
   }
}
