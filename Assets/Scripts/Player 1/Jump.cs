﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallMultiplier;

        }else if (rb.velocity.y >0 && !Input.GetButtonDown("Jump"))
        {
            rb.gravityScale = lowJumpMultiplier;
        }else
        {
            rb.gravityScale = 1f;
        }
    }
}
