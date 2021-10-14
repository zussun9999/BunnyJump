using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;

    public float jumpForce = 0.1f;

    Rigidbody2D rigidbody2d;

    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }


    private void Update()
    {
        Vector2 f = new Vector2(0,0);

        if(Input.GetKey(KeyCode.D))
        {
            f = new Vector2(speed,0);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            f = new Vector2(-speed,0);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            rigidbody2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        rigidbody2d.AddForce(f);
    }


}