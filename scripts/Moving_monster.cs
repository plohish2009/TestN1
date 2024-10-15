using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moving_monster : MonoBehaviour
{
    [SerializeField]
    Transform right;

    [SerializeField]
    Transform left;
    private float speed = 3f;
    private Rigidbody2D rb;
    private Transform currentpoint;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentpoint = left.transform;
    }
    private void Update()
    {
        if (currentpoint == right)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == left)
        {
            currentpoint = right;
        }
        if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == right)
        {
            currentpoint = left;
        }
    }
}
