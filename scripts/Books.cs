using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class Books : MonoBehaviour
{
    public int counter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            counter++;
            Debug.Log(counter);
        }
   }
}
