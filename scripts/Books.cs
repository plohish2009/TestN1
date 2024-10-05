using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Books : MonoBehaviour
{
    public int counter = 0;
    private void OnCollisionEnter2D(Collision2D collision)
   {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            counter++;
            Debug.Log(counter);
        }
   }
}
