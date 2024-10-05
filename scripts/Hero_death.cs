using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_death : MonoBehaviour
{
    public Vector3 Teleport_Point;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Destroy(gameObject);
            Debug.Log(Teleport_Point);
            gameObject.transform.position = Teleport_Point;
        }
    }
}
