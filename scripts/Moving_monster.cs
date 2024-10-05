using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_monster : MonoBehaviour
{
    //public int teleport = {12};
    public int tracker = 3;
    private float speed = 0.5f;
    private Vector3 dir;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        dir = transform.right;
    }

    void Update()
    {
        Move();
    }

    // Update is called once per frame
    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f);

        if (colliders.Length > 0) dir *= -1f;
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Игрок убит");
        }
    }


}
