using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombConfig : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public GameObject bomb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb)
        {
            rb.velocity = Vector2.left * 8;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float distance = bomb.transform.position.y+5;
        Debug.Log(distance*100/10+"%");
    }
}
