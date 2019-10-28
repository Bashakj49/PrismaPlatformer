using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advanced_Jump : MonoBehaviour
{
    public float fallX = 2.5f;
    public float lowJumpX = 2f;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallX - 1) * Time.deltaTime;
        } 
        else if (rb.velocity.y > 0 && !Input.GetButton ("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpX - 1) * Time.deltaTime;
        }
    

    }
}
