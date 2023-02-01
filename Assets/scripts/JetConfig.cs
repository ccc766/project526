using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetConfig : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3f;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    private bool upPressed;
    private bool downPressed;
    private bool leftPressed;
    private bool rightPressed;
    private float verticalInput;
    private float horizontalInput;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(up))
        {
            upPressed = true;
        }
        if (Input.GetKeyDown(down))
        {
            downPressed = true;
        }
        if (Input.GetKey(left))
        {
            leftPressed = true;
        }
        if (Input.GetKey(right))
        {
            rightPressed = true;
        }

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity=new Vector2(horizontalInput*10, verticalInput*10);
        float power = 60;
        if (upPressed)
        {
            rb.AddForce(Vector2.up * power, ForceMode2D.Force);
            upPressed= false;
        }
        if (downPressed)
        {
            rb.AddForce(Vector2.down * power, ForceMode2D.Force);
            downPressed = false;
        }
        if (leftPressed)
        {
            rb.AddForce(Vector2.left * power, ForceMode2D.Force);
            leftPressed = false;
        }
        if (rightPressed)
        {
            rb.AddForce(Vector2.right * power, ForceMode2D.Force);
            rightPressed = false;
        }

    }
}
