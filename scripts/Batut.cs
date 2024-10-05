using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batut : MonoBehaviour
{
   [Header("Упругость батута")]
   [Space]
   [SerializeField] private float _force;

   private void OnCollisionEnter2D(Collision2D collision)
   {
        if(collision.gameObject.tag == "Player")
        {
            collision.rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
        }
   }
}
