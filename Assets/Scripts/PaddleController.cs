using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;

    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Moveobject(GetInput());
    }
    private Vector2 GetInput()
    {
        if(Input.GetKey(upKey))
            return Vector2.up * speed;
        else if(Input.GetKey(downKey))
            return Vector2.down * speed;

        return Vector2.zero;
    }
    private void Moveobject(Vector2 movement)
    {
        rb.velocity = movement;
    }
}
