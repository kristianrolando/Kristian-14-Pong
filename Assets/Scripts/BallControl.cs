 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }


    void Update()
    {
        
    }
}
